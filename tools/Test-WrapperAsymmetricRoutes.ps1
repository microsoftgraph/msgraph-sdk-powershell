<#
.SYNOPSIS
Compiles and invokes the reviewed Files and Search asymmetric GET dispatchers with local workers.

.DESCRIPTION
Requires built WrapperGenerator and shared runtime assemblies and Microsoft.Graph.Authentication.
Uses real PowerShell binding and the real runtime; no Graph session or HTTP requests are made.

.EXAMPLE
pwsh -NoProfile -NonInteractive -File .\tools\Test-WrapperAsymmetricRoutes.ps1
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
    $FixtureRoot = Join-Path $repoRoot ".wrapper-asymmetric-tests-$PID-$([guid]::NewGuid().ToString('N'))"
}
if (-not $Probe) {
    try {
        & pwsh -NoProfile -NonInteractive -File $PSCommandPath -GeneratorAssembly $GeneratorAssembly `
            -RuntimeAssembly $RuntimeAssembly -FixtureRoot $FixtureRoot -Probe
        if ($LASTEXITCODE -ne 0) { throw "Asymmetric dispatcher probe exited $LASTEXITCODE." }
    }
    finally { Remove-Item $FixtureRoot -Recurse -Force -ErrorAction SilentlyContinue }
    exit 0
}

function Assert-AsymmetricTest([bool]$Condition, [string]$Message) {
    if (-not $Condition) { throw $Message }
}

function New-AsymmetricParameter($Name, $Type, $Mandatory = $false, $Position = $null, $Alias = $null) {
    if ($null -eq $Alias) {
        [WrapperGenerator.CmdletEmitter+DispatchParameter]::new($Name, $Type, $Mandatory, $Position)
    }
    else {
        [WrapperGenerator.CmdletEmitter+DispatchParameter]::new($Name, $Type, $Mandatory, $Position, $Alias)
    }
}

function New-AsymmetricWorker($Noun, $Path, $Label, $Shape, $Index, $Parameters, $OutputType, [string[]]$Ids) {
    $naming = [WrapperGenerator.CmdletNaming]::new(
        'VerbsCommon', 'Get', $Noun, "Get${Noun}Command", $Ids, 'Unused',
        [WrapperGenerator.HeaderParam[]]@(), [WrapperGenerator.OperationKind]::Resource,
        $null, '', '', '', $null, '', $Path, 'GET')
    [WrapperGenerator.CmdletEmitter+RouteWorker]::new(
        $naming, [WrapperGenerator.Naming]::WithSuffix($naming, "_Route$Index"),
        $Label, $Shape, [WrapperGenerator.CmdletEmitter+DispatchParameter[]]$Parameters, $OutputType)
}

function Write-AsymmetricSource($Workers, $DefaultRoute, $ApiVersion = 'v1.0') {
    $routes = @($Workers | ForEach-Object {
        [WrapperGenerator.MultiRoute]::new('GET', $_.Naming.SourcePath, $_.RouteName)
    })
    $group = [WrapperGenerator.MultiRouteGroup]::new($ApiVersion, [WrapperGenerator.MultiRoute[]]$routes, $DefaultRoute, 'Route')
    $group.AllowAsymmetricRoutes = $true
    $group.AllowResponseUnion = $true
    $source = [WrapperGenerator.CmdletEmitter]::EmitMultiRouteDispatcher(
        $group, [WrapperGenerator.CmdletEmitter+RouteWorker[]]$Workers,
        [WrapperGenerator.EmitContext]::new('AsymmetricInvocationFixture.Client'))
    $path = Join-Path $FixtureRoot ($Workers[0].Naming.ClassName + '.cs')
    Set-Content $path $source
    $path
}

function Register-AsymmetricWorker([string]$Name) {
    $source = @'
[CmdletBinding()]
param(
    [string]$ShareId, [string]$RunId, [string]$ActivityId,
    [switch]$All, [int]$Top, [string]$Filter, [switch]$Count,
    [Alias('Select')][string[]]$Property, [Alias('Expand')][string[]]$ExpandProperty,
    [Alias('OrderBy')][string[]]$Sort, [string]$ConsistencyLevel,
    [string]$AccessToken, [System.Collections.IDictionary]$Headers
)
$call = [pscustomobject]@{ Worker = '__NAME__'; Bound = @{} + $PSBoundParameters }
$global:AsymmetricRouteCalls.Add($call)
if ($ShareId -eq 'fail') {
    $PSCmdlet.ThrowTerminatingError([System.Management.Automation.ErrorRecord]::new(
        [System.InvalidOperationException]::new('synthetic asymmetric worker failure'),
        'AsymmetricWorkerFailure', [System.Management.Automation.ErrorCategory]::InvalidOperation, $ShareId))
}
$call
'@
    Set-Item "Function:\global:$Name" ([scriptblock]::Create($source.Replace('__NAME__', $Name)))
}

function Assert-AsymmetricRejected([scriptblock]$Invocation, [string[]]$Details) {
    $before = $global:AsymmetricRouteCalls.Count
    $failure = $null
    try { $null = & $Invocation }
    catch { $failure = $_ }
    Assert-AsymmetricTest ($null -ne $failure) 'Invalid parameters unexpectedly reached a worker.'
    Assert-AsymmetricTest ($failure.FullyQualifiedErrorId.StartsWith('InvalidGraphRouteParameters')) "Wrong route error identity: $failure"
    Assert-AsymmetricTest ($failure.CategoryInfo.Category -eq 'InvalidArgument') "Wrong route error category: $failure"
    Assert-AsymmetricTest ($global:AsymmetricRouteCalls.Count -eq $before) 'An invalid route invoked a worker.'
    foreach ($detail in $Details) {
        Assert-AsymmetricTest ($failure.Exception.Message -match [regex]::Escape($detail)) "Missing diagnostic '$detail': $failure"
    }
}

function Assert-AsymmetricMetadata($CommandName, $Workers, [string[]]$Labels, $DefaultSet) {
    $command = Get-Command $CommandName
    Assert-AsymmetricTest ((($command.ParameterSets.Name | Sort-Object) -join ',') -eq 'Get,List') "$CommandName must expose only shared Get/List parameter sets."
    Assert-AsymmetricTest ($command.DefaultParameterSet -eq $DefaultSet) "$CommandName has the wrong published default shape."
    $validate = @($command.Parameters['Route'].Attributes | Where-Object { $_ -is [System.Management.Automation.ValidateSetAttribute] })[0]
    Assert-AsymmetricTest ((($validate.ValidValues | Sort-Object) -join ',') -eq ((@('Published') + $Labels | Sort-Object) -join ',')) "$CommandName has incorrect public route labels."
    $routes = @($command.ImplementingType.GetCustomAttributes($false) | Where-Object { $_.GetType().Name -eq 'GraphRouteAttribute' })
    Assert-AsymmetricTest ($routes.Count -eq $Workers.Count) "$CommandName lost route metadata."
    foreach ($worker in $Workers) {
        $match = @($routes | Where-Object { $_.Method -eq 'GET' -and $_.Path -eq $worker.Naming.SourcePath -and $_.ParameterSetName -eq $worker.Shape })
        Assert-AsymmetricTest ($match.Count -eq 1) "$CommandName lost exact metadata for $($worker.RouteName)/$($worker.Shape)."
        $output = @($command.ImplementingType.GetCustomAttributes($false) | Where-Object {
            $_ -is [System.Management.Automation.OutputTypeAttribute] -and
            $_.ParameterSetName -contains $worker.Shape -and
            @($_.Type | Where-Object { $_.Type.FullName -eq $worker.OutputType }).Count -gt 0
        })
        Assert-AsymmetricTest ($output.Count -gt 0) "$CommandName lost output type $($worker.OutputType) in $($worker.Shape)."
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

    $itemQuery = @(
        New-AsymmetricParameter Property 'string[]?' $false $null Select
        New-AsymmetricParameter ExpandProperty 'string[]?' $false $null Expand
    )
    $listQuery = @($itemQuery) + @(
        New-AsymmetricParameter All SwitchParameter
        New-AsymmetricParameter Top int
        New-AsymmetricParameter Filter 'string?'
        New-AsymmetricParameter Count SwitchParameter
        New-AsymmetricParameter Sort 'string[]?' $false $null OrderBy
        New-AsymmetricParameter ConsistencyLevel 'string?'
    )
    $share = New-AsymmetricParameter ShareId string $true 0
    $run = New-AsymmetricParameter RunId string $true 0
    $activity = New-AsymmetricParameter ActivityId string $true 1
    $filesWorkers = @(
        New-AsymmetricWorker MgAsymmetricFiles '/shares/{sharedDriveItem-id}/driveItem' Singleton Get 0 `
            (@($share) + $itemQuery) System.String @('ShareId')
        New-AsymmetricWorker MgAsymmetricFiles '/shares/{sharedDriveItem-id}/items' Collection List 1 `
            (@($share) + $listQuery) System.String @('ShareId')
    )
    $searchWorkers = @(
        New-AsymmetricWorker MgAsymmetricSearch '/external/industryData/runs/{industryDataRun-id}/activities' RunActivity List 0 `
            (@($run) + $listQuery) System.String @('RunId')
        New-AsymmetricWorker MgAsymmetricSearch '/external/industryData/runs/{industryDataRun-id}/activities/{industryDataRunActivity-id}' RunActivity Get 1 `
            (@($run, $activity) + $itemQuery) System.String @('RunId', 'ActivityId')
        New-AsymmetricWorker MgAsymmetricSearch '/external/industryData/runs/{industryDataRun-id}/activities/{industryDataRunActivity-id}/activity' Activity Get 2 `
            (@($run, $activity) + $itemQuery) System.Int32 @('RunId', 'ActivityId')
    )
    $sources = @(
        Write-AsymmetricSource $filesWorkers Singleton
        Write-AsymmetricSource $searchWorkers RunActivity beta
    )
    $modulePath = Join-Path $FixtureRoot 'Microsoft.Graph.Wrapper.AsymmetricProbe.dll'
    $references = @(
        $RuntimeAssembly, [System.Management.Automation.PSCmdlet].Assembly.Location
    ) + @(Get-ChildItem (Join-Path $PSHOME 'ref') -Filter '*.dll' -File | Select-Object -ExpandProperty FullName)
    Add-Type -Path $sources -OutputAssembly $modulePath -CompilerOptions '/nowarn:1701' -ReferencedAssemblies $references
    $module = Import-Module $modulePath -PassThru
    $global:AsymmetricRouteCalls = [System.Collections.Generic.List[object]]::new()
    foreach ($worker in @($filesWorkers) + @($searchWorkers)) {
        $name = "$($worker.InternalNaming.VerbName)-$($worker.InternalNaming.Noun)"
        Register-AsymmetricWorker $name
        $workerNames += $name
    }

    foreach ($selector in @{}, @{ Route = 'Published' }, @{ Route = 'pUbLiShEd' }) {
        Assert-AsymmetricTest ((Get-MgAsymmetricFiles -ShareId s @selector).Worker -eq 'Get-MgAsymmetricFiles_Route0') 'Files Published must default to Singleton/Get.'
        foreach ($query in @{ All = $true }, @{ Top = 2 }, @{ Filter = 'active' }) {
            Assert-AsymmetricTest ((Get-MgAsymmetricFiles -ShareId s @selector @query).Worker -eq 'Get-MgAsymmetricFiles_Route1') 'Files list-only queries must infer Collection/List.'
        }
        Assert-AsymmetricTest ((Get-MgAsymmetricSearch -RunId r @selector).Worker -eq 'Get-MgAsymmetricSearch_Route0') 'Search Published must default to RunActivity/List.'
        Assert-AsymmetricTest ((Get-MgAsymmetricSearch -RunId r -ActivityId a @selector).Worker -eq 'Get-MgAsymmetricSearch_Route1') 'Search Published with both IDs must prefer RunActivity/Get over nested Activity/Get.'
    }
    Assert-AsymmetricTest ((Get-MgAsymmetricFiles -Route Singleton -ShareId s).Worker -eq 'Get-MgAsymmetricFiles_Route0') 'Explicit Singleton selected the wrong worker.'
    Assert-AsymmetricTest ((Get-MgAsymmetricFiles -Route cOlLeCtIoN -ShareId s).Worker -eq 'Get-MgAsymmetricFiles_Route1') 'Explicit Collection must select List even when binding defaults to Get.'
    Assert-AsymmetricTest ((Get-MgAsymmetricSearch -Route RunActivity -RunId r).Worker -eq 'Get-MgAsymmetricSearch_Route0') 'Explicit RunActivity list selected the wrong worker.'
    Assert-AsymmetricTest ((Get-MgAsymmetricSearch -Route RunActivity -RunId r -ActivityId a).Worker -eq 'Get-MgAsymmetricSearch_Route1') 'Explicit RunActivity item selected the wrong worker.'
    Assert-AsymmetricTest ((Get-MgAsymmetricSearch -Route aCtIvItY -RunId r -ActivityId a).Worker -eq 'Get-MgAsymmetricSearch_Route2') 'Explicit Activity must not fall back to the default label.'
    $singletonQuery = Get-MgAsymmetricFiles -ShareId s -Select id -Expand children
    Assert-AsymmetricTest ($singletonQuery.Worker -eq 'Get-MgAsymmetricFiles_Route0' -and $singletonQuery.Bound.Property[0] -eq 'id') 'Shared query aliases must preserve the published Singleton/Get route.'
    $activityQuery = Get-MgAsymmetricSearch -Route Activity -RunId r -ActivityId a -Select id
    Assert-AsymmetricTest ($activityQuery.Worker -eq 'Get-MgAsymmetricSearch_Route2' -and $activityQuery.Bound.Property[0] -eq 'id') 'Shared query aliases must reach explicit nested Activity/Get.'

    foreach ($query in @{ All = $true }, @{ Top = 2 }, @{ Filter = 'active' }) {
        Assert-AsymmetricRejected { Get-MgAsymmetricFiles -Route Singleton -ShareId s @query -ErrorAction Stop } @('Singleton/Get', 'unsupported', @($query.Keys)[0])
    }
    Assert-AsymmetricRejected { Get-MgAsymmetricSearch -Route Activity -RunId r -ErrorAction Stop } @('Activity/Get', 'missing', 'ActivityId')
    Assert-AsymmetricRejected { Get-MgAsymmetricSearch -Route Activity -RunId r -All -ErrorAction Stop } @('ActivityId', 'unsupported', 'All')
    Assert-AsymmetricRejected { Get-MgAsymmetricFiles -Route Singleton -ShareId s -ConsistencyLevel eventual -ErrorAction Stop } @('ConsistencyLevel', 'unsupported')
    $before = $global:AsymmetricRouteCalls.Count
    $invalid = $null
    try { Get-MgAsymmetricFiles -Route Unknown -ShareId s -ErrorAction Stop } catch { $invalid = $_ }
    Assert-AsymmetricTest ($null -ne $invalid -and $global:AsymmetricRouteCalls.Count -eq $before) 'Unknown labels must fail before a worker.'

    $forwarded = Get-MgAsymmetricFiles -Route Collection -ShareId s -All -Top 2 -Filter active -Count `
        -Select id,name -Expand children -OrderBy name -ConsistencyLevel eventual `
        -AccessToken fixture-token -Headers @{ 'x-fixture' = 'present' } -Verbose -ErrorAction Stop
    Assert-AsymmetricTest ($forwarded.Worker -eq 'Get-MgAsymmetricFiles_Route1') 'Forwarding probe selected the wrong worker.'
    Assert-AsymmetricTest ($forwarded.Bound.ShareId -eq 's' -and $forwarded.Bound.All.IsPresent -and $forwarded.Bound.Top -eq 2 -and $forwarded.Bound.Count.IsPresent) 'IDs, switches, or query values were lost.'
    Assert-AsymmetricTest (($forwarded.Bound.Property -join ',') -eq 'id,name' -and ($forwarded.Bound.ExpandProperty -join ',') -eq 'children' -and ($forwarded.Bound.Sort -join ',') -eq 'name') 'Canonical query alias forwarding failed.'
    Assert-AsymmetricTest ($forwarded.Bound.Filter -eq 'active' -and $forwarded.Bound.ConsistencyLevel -eq 'eventual') 'Non-path operation parameters were lost.'
    Assert-AsymmetricTest ($forwarded.Bound.AccessToken -eq 'fixture-token' -and $forwarded.Bound.Headers['x-fixture'] -eq 'present') 'Inherited token or headers were lost.'
    Assert-AsymmetricTest ($forwarded.Bound.ContainsKey('Verbose') -and $forwarded.Bound.ContainsKey('ErrorAction')) 'Common parameters were lost.'
    Assert-AsymmetricTest (-not $forwarded.Bound.ContainsKey('Route')) 'Selector leaked into the worker.'
    $canonical = Get-MgAsymmetricFiles -Route Collection -ShareId s -Property id -ExpandProperty children -Sort name
    Assert-AsymmetricTest ($canonical.Bound.Property[0] -eq 'id' -and $canonical.Bound.ExpandProperty[0] -eq 'children' -and $canonical.Bound.Sort[0] -eq 'name') 'Canonical operation parameter names must also work.'

    $failure = $null
    try { Get-MgAsymmetricFiles -ShareId fail -ErrorAction Stop } catch { $failure = $_ }
    Assert-AsymmetricTest ($null -ne $failure -and $failure.FullyQualifiedErrorId.StartsWith('AsymmetricWorkerFailure')) 'Worker terminating error identity was rewritten.'
    Assert-AsymmetricMetadata Get-MgAsymmetricFiles $filesWorkers @('Singleton', 'Collection') Get
    Assert-AsymmetricMetadata Get-MgAsymmetricSearch $searchWorkers @('RunActivity', 'Activity') List
    'Asymmetric Files/Search dispatchers passed real binding, Published inference, explicit labels, validation, forwarding, metadata and output-union checks.'
}
finally {
    foreach ($name in $workerNames) { Remove-Item "Function:\global:$name" -ErrorAction SilentlyContinue }
    Remove-Variable AsymmetricRouteCalls -Scope Global -ErrorAction SilentlyContinue
    if ($module) { Remove-Module $module -ErrorAction SilentlyContinue }
    Remove-Item $FixtureRoot -Recurse -Force -ErrorAction SilentlyContinue
}
exit 0
