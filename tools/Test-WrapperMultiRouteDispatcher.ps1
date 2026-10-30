<#
.SYNOPSIS
Compiles the Applications GET dispatchers against the real runtime and invokes local stub workers.

.DESCRIPTION
Requires built WrapperGenerator and shared runtime assemblies, plus Microsoft.Graph.Authentication
for the runtime's assembly-resolution hook. Uses the five actual Applications beta agentGroups
paths: root list/item, agent list, and root/agent count. No Graph session or HTTP calls are used.

.EXAMPLE
dotnet build .\tools\WrapperGenerator\WrapperGenerator.csproj --no-restore
dotnet build .\src\GraphWrapperRuntime\Runtime\Microsoft.Graph.Wrapper.Runtime.csproj --no-restore
pwsh -NoProfile -NonInteractive -File .\tools\Test-WrapperMultiRouteDispatcher.ps1
#>
[CmdletBinding()]
param(
    [string]$GeneratorAssembly = "$PSScriptRoot\WrapperGenerator\bin\Debug\net10.0\WrapperGenerator.dll",
    [string]$RuntimeAssembly = "$PSScriptRoot\..\src\GraphWrapperRuntime\Runtime\bin\Debug\netstandard2.0\Microsoft.Graph.Wrapper.Runtime.dll",
    [Parameter(DontShow)][string]$FixtureRoot,
    [Parameter(DontShow)][switch]$Probe
)

$ErrorActionPreference = 'Stop'
$repoRoot = (Resolve-Path (Join-Path $PSScriptRoot '..')).Path
if (-not $FixtureRoot) {
    $FixtureRoot = Join-Path $repoRoot ".wrapper-dispatch-tests-$PID-$([guid]::NewGuid().ToString('N'))"
}
# The child releases imported binaries before the parent removes the fixture on Windows.
if (-not $Probe) {
    if (Test-Path -LiteralPath $FixtureRoot) {
        throw "FixtureRoot must be a new directory: $FixtureRoot"
    }
    try {
        & pwsh -NoProfile -NonInteractive -File $PSCommandPath -GeneratorAssembly $GeneratorAssembly `
            -RuntimeAssembly $RuntimeAssembly -FixtureRoot $FixtureRoot -Probe
        if ($LASTEXITCODE -ne 0) { throw "Dispatcher probe exited $LASTEXITCODE." }
    }
    finally { Remove-Item -LiteralPath $FixtureRoot -Recurse -Force -ErrorAction SilentlyContinue }
    exit 0
}

function Assert-DispatchTest([bool]$Condition, [string]$Message) {
    if (-not $Condition) { throw $Message }
}

function New-DispatchWorker([string]$Path, [string]$Label, [string]$Shape, [int]$Index, [string[]]$Query) {
    $config = [WrapperGenerator.GeneratorConfig]::new('RouteInvocationFixture.Client', '.', $false)
    $operation = [WrapperGenerator.OperationInfo]::new(
        [System.Net.Http.HttpMethod]::Get, $Path, [string[]]@('ConsistencyLevel'), [WrapperGenerator.OperationKind]::Resource)
    $naming = [WrapperGenerator.Naming]::Resolve($operation, $config)
    $queries = [System.Collections.Generic.HashSet[string]]::new([System.StringComparer]::Ordinal)
    foreach ($name in $Query) { $null = $queries.Add($name) }
    $parameters = [WrapperGenerator.CmdletEmitter]::GetDispatchParameters($naming, $Shape, $queries)
    [WrapperGenerator.CmdletEmitter+RouteWorker]::new(
        $naming, [WrapperGenerator.Naming]::WithSuffix($naming, "_Route$Index"),
        $Label, $Shape, $parameters, 'string')
}

function Write-DispatchSource($Workers) {
    $routes = [WrapperGenerator.CmdletConfigurator+OperationVariant[]]@($Workers | ForEach-Object {
        [WrapperGenerator.CmdletConfigurator+OperationVariant]::new('GET', $_.Naming.SourcePath, $_.RouteName)
    })
    $group = [WrapperGenerator.CmdletConfigurator+OperationVariantGroup]::new($routes, 'Root')
    $context = [WrapperGenerator.EmitContext]::new('RouteInvocationFixture.Client')
    $source = [WrapperGenerator.CmdletEmitter]::EmitMultiRouteDispatcher(
        $group, [WrapperGenerator.CmdletEmitter+RouteWorker[]]$Workers, $context)
    $path = Join-Path $FixtureRoot ($Workers[0].Naming.ClassName + '.cs')
    Set-Content $path $source
    $path
}

function Register-StubWorker([string]$Name) {
    $body = @'
[CmdletBinding()]
param(
    [string]$OnPremisesPublishingProfileId,
    [string]$OnPremisesAgentGroupId,
    [string]$OnPremisesAgentId,
    [switch]$All, [int]$Top, [int]$Skip, [switch]$Count,
    [Alias('Select')][string[]]$Property,
    [Alias('Expand')][string[]]$ExpandProperty,
    [Alias('OrderBy')][string[]]$Sort,
    [string]$Filter, [string]$Search, [string]$ConsistencyLevel,
    [string]$AccessToken, [System.Collections.IDictionary]$Headers
)
$call = [pscustomobject]@{ Worker = '__NAME__'; Bound = @{} + $PSBoundParameters }
$global:RouteProbeAttempts.Add($call)
if ($OnPremisesPublishingProfileId -eq 'fail') {
    $PSCmdlet.ThrowTerminatingError($global:RouteProbeErrorRecord)
}
$call
'@
    Set-Item "Function:\global:$Name" ([scriptblock]::Create($body.Replace('__NAME__', $Name)))
}

function Assert-BinderRejected([scriptblock]$Script, [string]$Description) {
    $before = $global:RouteProbeAttempts.Count
    $failure = $null
    try { $null = & $Script }
    catch { $failure = $_ }
    Assert-DispatchTest ($null -ne $failure) "PowerShell accepted invalid binding: $Description"
    Assert-DispatchTest ($failure.Exception -is [System.Management.Automation.ParameterBindingException]) `
        "Expected a binder failure for ${Description}, got: $failure"
    Assert-DispatchTest ($global:RouteProbeAttempts.Count -eq $before) "Invalid binding invoked a worker: $Description"
}

function Assert-CommandMetadata($Command, $Workers, [string]$DefaultSet) {
    Assert-DispatchTest ($Command.DefaultParameterSet -eq $DefaultSet) "Incorrect default set for $($Command.Name)."
    Assert-DispatchTest (-not $Command.Parameters.ContainsKey('Route')) "Dispatcher invented a Route parameter."
    Assert-DispatchTest (-not $Command.Parameters.ContainsKey('BodyParameter')) "GET dispatcher invented a body parameter."
    Assert-DispatchTest (-not $Command.Parameters.ContainsKey('WhatIf')) "GET dispatcher acquired mutation parameters."
    $sets = @($Command.ParameterSets)
    Assert-DispatchTest ($sets.Count -eq $Workers.Count) "Incorrect parameter-set count for $($Command.Name)."
    $routes = @($Command.ImplementingType.GetCustomAttributes($false) | Where-Object { $_.GetType().Name -eq 'GraphRouteAttribute' })
    Assert-DispatchTest ($routes.Count -eq $Workers.Count) "Dispatcher lost source operation metadata."
    foreach ($worker in $Workers) {
        $setName = $worker.RouteName + $worker.Shape
        $set = @($sets | Where-Object Name -eq $setName)
        Assert-DispatchTest ($set.Count -eq 1) "Missing parameter set $setName."
        $required = @($set[0].Parameters | Where-Object IsMandatory | Select-Object -ExpandProperty Name | Sort-Object)
        $expected = @($worker.Naming.PathParamNames | Sort-Object)
        Assert-DispatchTest (($required -join ',') -ceq ($expected -join ',')) "Wrong mandatory path IDs for $setName."
        $route = @($routes | Where-Object { $_.Path -ceq $worker.Naming.SourcePath -and $_.ParameterSetName -ceq $setName })
        Assert-DispatchTest ($route.Count -eq 1 -and $route[0].Method -ceq 'GET') "Incorrect route metadata for $setName."
    }
}

$workerNames = @()
$module = $null
try {
    foreach ($assembly in $GeneratorAssembly, $RuntimeAssembly) {
        if (-not (Test-Path $assembly)) { throw "Build prerequisite missing: $assembly" }
    }
    $GeneratorAssembly = (Resolve-Path $GeneratorAssembly).Path
    $RuntimeAssembly = (Resolve-Path $RuntimeAssembly).Path
    $null = New-Item $FixtureRoot -ItemType Directory
    Import-Module Microsoft.Graph.Authentication -ErrorAction Stop
    $null = [System.Reflection.Assembly]::LoadFrom($GeneratorAssembly)
    $null = [System.Reflection.Assembly]::LoadFrom($RuntimeAssembly)

    $root = '/onPremisesPublishingProfiles/{onPremisesPublishingProfile-id}/agentGroups'
    $agent = '/onPremisesPublishingProfiles/{onPremisesPublishingProfile-id}/agents/{onPremisesAgent-id}/agentGroups'
    $listQuery = @('$select', '$expand', '$filter', '$search', '$orderby', '$top', '$skip', '$count')
    $getWorkers = @(
        New-DispatchWorker $root Root List 0 $listQuery
        New-DispatchWorker ($root + '/{onPremisesAgentGroup-id}') Root Get 1 @('$select', '$expand')
        New-DispatchWorker $agent Agent List 2 $listQuery
    )
    $countWorkers = @(
        New-DispatchWorker ($root + '/$count') Root Scalar 0 @('$filter', '$search')
        New-DispatchWorker ($agent + '/$count') Agent Scalar 1 @('$filter', '$search')
    )
    $sources = @(
        Write-DispatchSource $getWorkers
        Write-DispatchSource $countWorkers
    )
    $modulePath = Join-Path $FixtureRoot 'Microsoft.Graph.Wrapper.MultiRouteProbe.dll'
    $references = @(
        $RuntimeAssembly, [System.Management.Automation.PSCmdlet].Assembly.Location
    ) + @(Get-ChildItem (Join-Path $PSHOME 'ref') -Filter '*.dll' -File | Select-Object -ExpandProperty FullName)
    Add-Type -Path $sources -OutputAssembly $modulePath -CompilerOptions '/nowarn:1701' -ReferencedAssemblies $references
    $module = Import-Module $modulePath -PassThru
    $global:RouteProbeAttempts = [System.Collections.Generic.List[object]]::new()
    $target = [pscustomobject]@{ Identity = 'original-worker-target' }
    $global:RouteProbeErrorRecord = [System.Management.Automation.ErrorRecord]::new(
        [System.InvalidOperationException]::new('synthetic worker failure'),
        'RouteProbeFailure', [System.Management.Automation.ErrorCategory]::InvalidOperation, $target)
    foreach ($worker in @($getWorkers) + @($countWorkers)) {
        $name = "$($worker.InternalNaming.VerbName)-$($worker.InternalNaming.Noun)"
        Register-StubWorker $name
        $workerNames += $name
    }

    $getName = "$($getWorkers[0].Naming.VerbName)-$($getWorkers[0].Naming.Noun)"
    $countName = "$($countWorkers[0].Naming.VerbName)-$($countWorkers[0].Naming.Noun)"
    $getCommand = Get-Command $getName
    $countCommand = Get-Command $countName
    Assert-CommandMetadata $getCommand $getWorkers RootList
    Assert-CommandMetadata $countCommand $countWorkers RootScalar

    $profile = @{ OnPremisesPublishingProfileId = 'p' }
    $item = $profile + @{ OnPremisesAgentGroupId = 'g' }
    $agentList = $profile + @{ OnPremisesAgentId = 'a' }
    Assert-DispatchTest ((& $getName @profile).Worker -eq $workerNames[0]) 'P must select the default root list.'
    Assert-DispatchTest ((& $getName @item).Worker -eq $workerNames[1]) 'P+G must select the root item.'
    Assert-DispatchTest ((& $getName @agentList).Worker -eq $workerNames[2]) 'P+A must select the agent list.'
    Assert-DispatchTest ((& $countName @profile).Worker -eq $workerNames[3]) 'P must select the root count.'
    Assert-DispatchTest ((& $countName @agentList).Worker -eq $workerNames[4]) 'P+A must select the agent count.'
    $mixedCase = @{ onpremisespublishingprofileid = 'p'; ONPREMISESAGENTID = 'a' }
    Assert-DispatchTest ((& $getName.ToLowerInvariant() @mixedCase).Worker -eq $workerNames[2]) 'Case-insensitive command/parameter context changed routing.'

    $forwarded = & $getName @agentList -All -Top 2 -Skip 1 -Count -Select id,displayName -Expand owners `
        -OrderBy displayName -Filter 'active' -Search '"name:fixture"' -ConsistencyLevel eventual `
        -AccessToken 'fixture-token' -Headers @{ 'x-probe' = 'fixture' } -Verbose -Debug:$false -ErrorAction Stop
    $bound = $forwarded.Bound
    Assert-DispatchTest ($bound.All.IsPresent -and $bound.Top -eq 2 -and $bound.Skip -eq 1 -and $bound.Count.IsPresent) 'Pagination switches and values were lost.'
    Assert-DispatchTest (($bound.Property -join ',') -eq 'id,displayName' -and ($bound.ExpandProperty -join ',') -eq 'owners' -and ($bound.Sort -join ',') -eq 'displayName') 'Query aliases were not forwarded as canonical parameters.'
    Assert-DispatchTest ($bound.Filter -eq 'active' -and $bound.Search -eq '"name:fixture"' -and $bound.ConsistencyLevel -eq 'eventual') 'Query strings or named header were lost.'
    Assert-DispatchTest ($bound.AccessToken -eq 'fixture-token' -and $bound.Headers['x-probe'] -eq 'fixture') 'Inherited token/header parameters were lost.'
    Assert-DispatchTest ($bound.ContainsKey('Verbose') -and $bound.ContainsKey('Debug') -and $bound.ContainsKey('ErrorAction')) 'Common bound parameters were lost.'
    Assert-DispatchTest ($bound.OnPremisesPublishingProfileId -eq 'p' -and $bound.OnPremisesAgentId -eq 'a') 'Mandatory path IDs were lost.'
    $scalar = & $countName @agentList -Filter 'active' -Search 'fixture' -Headers @{ 'x-count' = 'yes' } -AccessToken 'count-token'
    Assert-DispatchTest ($scalar.Bound.Filter -eq 'active' -and $scalar.Bound.Search -eq 'fixture' -and $scalar.Bound.Headers['x-count'] -eq 'yes' -and $scalar.Bound.AccessToken -eq 'count-token') 'Count forwarding changed the existing parameter surface.'
    $itemResult = & $getName @item -Select id -Expand owners
    Assert-DispatchTest ($itemResult.Bound.Property[0] -eq 'id' -and $itemResult.Bound.ExpandProperty[0] -eq 'owners') 'Item select/expand forwarding failed.'

    Assert-BinderRejected { & $getName @profile -OnPremisesAgentId a -OnPremisesAgentGroupId g } 'P+G+A'
    Assert-BinderRejected { & $getName -OnPremisesAgentGroupId g } 'missing P on an item'
    Assert-BinderRejected { & $getName } 'missing P on the default root list'
    Assert-BinderRejected { & $getName @item -All } 'item with All'
    Assert-BinderRejected { & $getName @item -Top 1 } 'item with Top'
    Assert-BinderRejected { & $getName @profile -Route Root } 'invented Route parameter'
    Assert-BinderRejected { & $countName -OnPremisesAgentId a } 'missing P on agent count'
    Assert-BinderRejected { & $countName @agentList -OnPremisesAgentGroupId g } 'count with G'
    Assert-BinderRejected { & $countName @profile -All } 'count with All'
    Assert-BinderRejected { & $countName @profile -Top 1 } 'count with Top'
    Assert-BinderRejected { & $countName @profile -Route Root } 'count with invented Route parameter'

    $directFailure = $null
    $failure = $null
    try { & $workerNames[0] -OnPremisesPublishingProfileId fail -ErrorAction Stop } catch { $directFailure = $_ }
    try { & $getName -OnPremisesPublishingProfileId fail -ErrorAction Stop } catch { $failure = $_ }
    Assert-DispatchTest ($null -ne $failure -and $failure.FullyQualifiedErrorId.Split(',')[0] -eq $directFailure.FullyQualifiedErrorId.Split(',')[0]) 'Worker terminating-error identity was rewritten.'
    Assert-DispatchTest ([object]::ReferenceEquals($failure.Exception, $global:RouteProbeErrorRecord.Exception)) 'Worker exception instance was replaced.'
    Assert-DispatchTest ([object]::ReferenceEquals($failure.TargetObject, $target) -and $failure.CategoryInfo.Category -eq 'InvalidOperation') 'Worker error target or category was replaced.'
    'Applications multi-route dispatchers passed real-runtime compilation, five-route binding, metadata, forwarding, invalid-binding and worker-error identity checks.'
}
finally {
    foreach ($name in $workerNames) { Remove-Item "Function:\global:$name" -ErrorAction SilentlyContinue }
    Remove-Variable RouteProbeAttempts, RouteProbeErrorRecord -Scope Global -ErrorAction SilentlyContinue
    if ($module) { Remove-Module $module -ErrorAction SilentlyContinue }
}
exit 0
