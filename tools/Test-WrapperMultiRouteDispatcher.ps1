<#
.SYNOPSIS
Compiles real emitted multi-route dispatchers and invokes them with local stub workers.

.DESCRIPTION
Requires built WrapperGenerator and shared runtime assemblies, plus Microsoft.Graph.Authentication
for the runtime's assembly-resolution hook. No Graph session, tenant data or HTTP calls are used.

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
# Windows holds the imported binary open until its process exits.
if (-not $Probe) {
    try {
        & pwsh -NoProfile -NonInteractive -File $PSCommandPath -GeneratorAssembly $GeneratorAssembly `
            -RuntimeAssembly $RuntimeAssembly -FixtureRoot $FixtureRoot -Probe
        if ($LASTEXITCODE -ne 0) { throw "Dispatcher probe exited $LASTEXITCODE." }
    }
    finally { Remove-Item $FixtureRoot -Recurse -Force -ErrorAction SilentlyContinue }
    exit 0
}

function Assert-DispatchTest([bool]$Condition, [string]$Message) {
    if (-not $Condition) { throw $Message }
}

function New-DispatchWorker($Verb, $Noun, $Method, $Path, $Label, $Shape, $Index, $Parameters, [string[]]$PathParameters = @()) {
    $naming = [WrapperGenerator.CmdletNaming]::new(
        $(if ($Verb -eq 'Update') { 'VerbsData' } else { 'VerbsCommon' }), $Verb, $Noun,
        "${Verb}${Noun}Command", $PathParameters, 'Unused', [WrapperGenerator.HeaderParam[]]@(),
        [WrapperGenerator.OperationKind]::Resource, $null, '', '', '', $null, '', $Path, $Method)
    [WrapperGenerator.CmdletEmitter+RouteWorker]::new(
        $naming, [WrapperGenerator.Naming]::WithSuffix($naming, "_Route$Index"),
        $Label, $Shape, [WrapperGenerator.CmdletEmitter+DispatchParameter[]]$Parameters, 'string')
}

function Write-DispatchSource($Workers, $DefaultRoute, $Selector = 'Route') {
    $routes = @($Workers | ForEach-Object {
        [WrapperGenerator.MultiRoute]::new($_.Naming.SourceMethod, $_.Naming.SourcePath, $_.RouteName)
    })
    $group = [WrapperGenerator.MultiRouteGroup].GetConstructors()[0].Invoke(
        [object[]]@('v1.0', [WrapperGenerator.MultiRoute[]]$routes, $DefaultRoute, $Selector))
    $context = [WrapperGenerator.EmitContext]::new('RouteInvocationFixture.Client')
    $source = [WrapperGenerator.CmdletEmitter]::EmitMultiRouteDispatcher(
        $group, [WrapperGenerator.CmdletEmitter+RouteWorker[]]$Workers, $context)
    $path = Join-Path $fixtureRoot ($Workers[0].Naming.ClassName + '.cs')
    Set-Content $path $source
    $path
}

function Assert-DispatchRejected($Workers, $DefaultRoute, $Selector, [string]$Description, [string]$ExpectedMessage) {
    $failure = $null
    try { $null = Write-DispatchSource $Workers $DefaultRoute $Selector }
    catch { $failure = $_.Exception.GetBaseException() }
    Assert-DispatchTest ($failure -is [System.InvalidOperationException]) "Emitter must reject $Description with InvalidOperationException, not emit unusable source: $failure"
    Assert-DispatchTest ($failure.Message -match $ExpectedMessage) "Emitter rejected $Description for the wrong reason: $failure"
    $path = Join-Path $fixtureRoot ($Workers[0].Naming.ClassName + '.cs')
    Assert-DispatchTest (-not (Test-Path $path)) "Invalid plan reached source compilation: $Description"
}

function Assert-BinderRejected([scriptblock]$Script, [string]$ErrorId, [string]$Description) {
    $failure = $null
    try { $null = & $Script }
    catch { $failure = $_ }
    Assert-DispatchTest ($null -ne $failure -and $failure.FullyQualifiedErrorId -eq $ErrorId) "PowerShell must reject $Description with ${ErrorId}: $failure"
}

function Register-StubWorker([string]$Name, [switch]$Mutation) {
    $binding = if ($Mutation) { "[CmdletBinding(SupportsShouldProcess, ConfirmImpact = 'High')]" } else { '[CmdletBinding()]' }
    $shouldProcess = if ($Mutation) { 'if (-not $PSCmdlet.ShouldProcess($ThingId, "Probe mutation")) { return }' } else { '' }
    $body = @'
__BINDING__
param(
    [string]$ThingId, [string]$ParentId, [string]$GroupId,
    [switch]$All, [int]$Top, [Alias('Select')][string[]]$Property, [string]$Filter,
    [string]$AccessToken, [System.Collections.IDictionary]$Headers
)
$call = [pscustomobject]@{ Worker = '__NAME__'; Bound = @{} + $PSBoundParameters }
$global:RouteProbeAttempts.Add($call)
if ($ThingId -eq 'fail') {
    $PSCmdlet.ThrowTerminatingError([System.Management.Automation.ErrorRecord]::new(
        [System.InvalidOperationException]::new('synthetic worker failure'),
        'RouteProbeFailure', [System.Management.Automation.ErrorCategory]::InvalidOperation, $ThingId))
}
__SHOULD_PROCESS__
$global:RouteProbeCalls.Add($call)
$call
'@
    $body = $body.Replace('__BINDING__', $binding).Replace('__NAME__', $Name).Replace('__SHOULD_PROCESS__', $shouldProcess)
    Set-Item "Function:\global:$Name" ([scriptblock]::Create($body))
}

$workerNames = @()
try {
    foreach ($assembly in $GeneratorAssembly, $RuntimeAssembly) {
        if (-not (Test-Path $assembly)) { throw "Build prerequisite missing: $assembly" }
    }
    $GeneratorAssembly = (Resolve-Path $GeneratorAssembly).Path
    $RuntimeAssembly = (Resolve-Path $RuntimeAssembly).Path
    $null = New-Item $fixtureRoot -ItemType Directory
    Import-Module Microsoft.Graph.Authentication -ErrorAction Stop
    $null = [System.Reflection.Assembly]::LoadFrom($GeneratorAssembly)
    $null = [System.Reflection.Assembly]::LoadFrom($RuntimeAssembly)

    # The list's required query parameter makes its effective mandatory set identical to the item's path IDs.
    $children = New-DispatchWorker Get MgRouteShadow GET '/widgets/{widget-id}/widgets' Children List 0 @() @('WidgetId')
    $childrenParameters = [WrapperGenerator.CmdletEmitter]::GetDispatchParameters(
        $children.Naming, 'List', [System.Collections.Generic.HashSet[string]]::new(),
        [WrapperGenerator.CmdletEmitter+DispatchParameter[]]@(),
        [WrapperGenerator.CmdletEmitter+StringQueryParameter[]]@(
            [WrapperGenerator.CmdletEmitter+StringQueryParameter]::new('parentId', 'ParentId', $true)))
    $shadowWorkers = @(
        [WrapperGenerator.CmdletEmitter+RouteWorker]::new(
            $children.Naming, $children.InternalNaming, 'Children', 'List', $childrenParameters, 'string')
        New-DispatchWorker Get MgRouteShadow GET '/widgets/{widget-id}/widgets/{parent-id}' Item Get 1 @(
            [WrapperGenerator.CmdletEmitter+DispatchParameter]::new('WidgetId', 'string', $true, 0)
            [WrapperGenerator.CmdletEmitter+DispatchParameter]::new('ParentId', 'string', $true, 1)
        ) @('WidgetId', 'ParentId')
    )
    $shadowBinder = @'
[CmdletBinding(__DEFAULT__)]
param(
    [Parameter(Mandatory, ParameterSetName = 'ChildrenList')]
    [Parameter(Mandatory, ParameterSetName = 'ItemGet')]
    [string]$WidgetId,
    [Parameter(Mandatory, ParameterSetName = 'ChildrenList')]
    [Parameter(Mandatory, ParameterSetName = 'ItemGet')]
    [string]$ParentId,
    [Parameter(ParameterSetName = 'ChildrenList')][switch]$All
)
$PSCmdlet.ParameterSetName
'@
    foreach ($defaultRoute in 'Children', 'Item') {
        $setName = if ($defaultRoute -eq 'Children') { 'ChildrenList' } else { 'ItemGet' }
        $bind = [scriptblock]::Create($shadowBinder.Replace('__DEFAULT__', "DefaultParameterSetName = '$setName'"))
        Assert-DispatchTest ((& $bind -WidgetId w -ParentId p) -eq $setName) 'Identical mandatory parameters must reproduce default-dependent route shadowing in PowerShell.'
        Assert-DispatchRejected $shadowWorkers $defaultRoute $null "identical effective mandatory sets with $defaultRoute as default" 'identical mandatory'
    }
    $bind = [scriptblock]::Create($shadowBinder.Replace('__DEFAULT__', ''))
    Assert-BinderRejected { & $bind -WidgetId w -ParentId p } 'AmbiguousParameterSet' 'identical mandatory sets without a default'

    foreach ($query in @(
        @{ Name = 'Property'; Alias = 'Select'; Selector = 'sElEcT' }
        @{ Name = 'ExpandProperty'; Alias = 'Expand'; Selector = 'eXpAnD' }
        @{ Name = 'Sort'; Alias = 'OrderBy'; Selector = 'oRdErBy' }
    )) {
        $bind = [scriptblock]::Create(
            "[CmdletBinding()] param([Alias('$($query.Alias)')][string[]]`$$($query.Name), [string]`$$($query.Selector)) 'unexpected'")
        Assert-BinderRejected $bind 'ParameterNameConflictsWithAlias' "$($query.Selector) selector versus $($query.Name) alias"
        $parameters = @([WrapperGenerator.CmdletEmitter+DispatchParameter]::new($query.Name, 'string[]?', $false, $null, $query.Alias))
        $workers = @(
            New-DispatchWorker Get MgRouteAliasConflict GET '/legacy/widgets' Legacy List 0 $parameters
            New-DispatchWorker Get MgRouteAliasConflict GET '/solutions/widgets' Solutions List 1 $parameters
        )
        Assert-DispatchRejected $workers Legacy $query.Selector "$($query.Selector) selector versus $($query.Name) alias" 'selector'
    }

    # Aliases belong to the whole dispatcher, even when their parameters come from different workers.
    foreach ($secondAlias in $false, $true) {
        $secondDeclaration = if ($secondAlias) { "[Alias('sElEcT')][string[]]`$OtherProperty" } else { '[string[]]$sElEcT' }
        $bind = [scriptblock]::Create("[CmdletBinding()] param([Alias('Select')][string[]]`$Property, $secondDeclaration) 'unexpected'")
        $errorId = if ($secondAlias) { 'AliasDeclaredMultipleTimes' } else { 'ParameterNameConflictsWithAlias' }
        Assert-BinderRejected $bind $errorId 'case-insensitive cross-worker parameter aliases'
        $secondParameter = if ($secondAlias) {
            [WrapperGenerator.CmdletEmitter+DispatchParameter]::new('OtherProperty', 'string[]?', $false, $null, 'sElEcT')
        } else { [WrapperGenerator.CmdletEmitter+DispatchParameter]::new('sElEcT', 'string[]?', $false, $null) }
        $workers = @(
            New-DispatchWorker Get MgRouteAliasConflict GET '/legacy/widgets' Legacy List 0 @(
                [WrapperGenerator.CmdletEmitter+DispatchParameter]::new('Property', 'string[]?', $false, $null, 'Select')
            )
            New-DispatchWorker Get MgRouteAliasConflict GET '/solutions/widgets/{widget-id}' Solutions Get 1 @($secondParameter)
        )
        Assert-DispatchRejected $workers Legacy Route 'case-insensitive cross-worker parameter aliases' 'alias'
    }

    foreach ($alias in 'vb', 'db', 'ea', 'wa', 'infa', 'proga', 'ev', 'wv', 'iv', 'ov', 'ob', 'pv', 'cf', 'wi') {
        $selector = $alias.ToUpperInvariant()
        $mutation = $alias -in 'cf', 'wi'
        $binding = if ($mutation) { '[CmdletBinding(SupportsShouldProcess)]' } else { '[CmdletBinding()]' }
        $bind = [scriptblock]::Create("$binding param([string]`$$selector) 'unexpected'")
        Assert-BinderRejected $bind 'ParameterNameConflictsWithAlias' "selector $selector versus a common PowerShell alias"
        $verb, $method = if ($mutation) { 'Remove', 'DELETE' } else { 'Get', 'GET' }
        $workers = @(
            New-DispatchWorker $verb MgRouteCommonConflict $method '/legacy/widgets' Legacy Invoke 0 @()
            New-DispatchWorker $verb MgRouteCommonConflict $method '/solutions/widgets' Solutions Invoke 1 @()
        )
        Assert-DispatchRejected $workers Legacy $selector "selector $selector versus a common PowerShell alias" 'common parameter|selector'
        foreach ($asAlias in $false, $true) {
            $parameter = if ($asAlias) {
                $bind = [scriptblock]::Create("$binding param([Alias('$selector')][string]`$Custom) 'unexpected'")
                Assert-BinderRejected $bind 'AliasParameterNameAlreadyExistsForCommand' "parameter alias $selector versus a common PowerShell alias"
                [WrapperGenerator.CmdletEmitter+DispatchParameter]::new('Custom', 'string?', $false, $null, $selector)
            } else { [WrapperGenerator.CmdletEmitter+DispatchParameter]::new($selector, 'string?', $false, $null) }
            $workers = @(
                New-DispatchWorker $verb MgRouteCommonConflict $method '/legacy/widgets' Legacy Invoke 0 @($parameter)
                New-DispatchWorker $verb MgRouteCommonConflict $method '/solutions/widgets' Solutions Invoke 1 @($parameter)
            )
            Assert-DispatchRejected $workers Legacy Route "parameter or alias $selector versus a common PowerShell alias" 'common parameter'
        }
    }

    $list = @(
        [WrapperGenerator.CmdletEmitter+DispatchParameter]::new('All', 'SwitchParameter', $false, $null)
        [WrapperGenerator.CmdletEmitter+DispatchParameter]::new('Top', 'int', $false, $null)
        [WrapperGenerator.CmdletEmitter+DispatchParameter]::new('Property', 'string[]?', $false, $null, 'Select')
        [WrapperGenerator.CmdletEmitter+DispatchParameter]::new('Filter', 'string?', $false, $null)
    )
    $item = @(
        [WrapperGenerator.CmdletEmitter+DispatchParameter]::new('ThingId', 'string', $true, 0)
        [WrapperGenerator.CmdletEmitter+DispatchParameter]::new('Property', 'string[]?', $false, $null, 'Select')
    )
    $getWorkers = @(
        New-DispatchWorker Get MgRouteProbe GET '/legacy/things' Legacy List 0 $list
        New-DispatchWorker Get MgRouteProbe GET '/legacy/things/{thing-id}' Legacy Get 1 $item
        New-DispatchWorker Get MgRouteProbe GET '/solutions/things' Solutions List 2 $list
        New-DispatchWorker Get MgRouteProbe GET '/solutions/things/{thing-id}' Solutions Get 3 $item
    )
    $removeWorkers = @(
        New-DispatchWorker Remove MgRouteProbe DELETE '/legacy/things/{thing-id}' Legacy Invoke 0 @($item[0])
        New-DispatchWorker Remove MgRouteProbe DELETE '/solutions/things/{thing-id}' Solutions Invoke 1 @($item[0])
    )
    $distinctWorkers = @(
        New-DispatchWorker Get MgRouteDistinct GET '/parents/{parent-id}/things/{thing-id}' Legacy Get 0 @(
            [WrapperGenerator.CmdletEmitter+DispatchParameter]::new('ParentId', 'string', $true, 0)
            [WrapperGenerator.CmdletEmitter+DispatchParameter]::new('ThingId', 'string', $true, 1)
        )
        New-DispatchWorker Get MgRouteDistinct GET '/groups/{group-id}/things/{thing-id}' Solutions Get 1 @(
            [WrapperGenerator.CmdletEmitter+DispatchParameter]::new('GroupId', 'string', $true, 0)
            [WrapperGenerator.CmdletEmitter+DispatchParameter]::new('ThingId', 'string', $true, 1)
        )
    )
    $sources = @(
        Write-DispatchSource $getWorkers Legacy
        Write-DispatchSource $removeWorkers Solutions
        Write-DispatchSource $distinctWorkers Legacy $null
    )
    $modulePath = Join-Path $fixtureRoot 'Microsoft.Graph.Wrapper.MultiRouteProbe.dll'
    $references = @(
        $RuntimeAssembly, [System.Management.Automation.PSCmdlet].Assembly.Location
    ) + @(Get-ChildItem (Join-Path $PSHOME 'ref') -Filter '*.dll' -File | Select-Object -ExpandProperty FullName)
    Add-Type -Path $sources -OutputAssembly $modulePath -CompilerOptions '/nowarn:1701' -ReferencedAssemblies $references
    $module = Import-Module $modulePath -PassThru
    $global:RouteProbeCalls = [System.Collections.Generic.List[object]]::new()
    $global:RouteProbeAttempts = [System.Collections.Generic.List[object]]::new()
    foreach ($worker in @($getWorkers) + @($removeWorkers) + @($distinctWorkers)) {
        $name = "$($worker.InternalNaming.VerbName)-$($worker.InternalNaming.Noun)"
        Register-StubWorker $name -Mutation:($worker.Naming.SourceMethod -ne 'GET')
        $workerNames += $name
    }

    Assert-DispatchTest ((Get-MgRouteProbe).Worker -eq 'Get-MgRouteProbe_Route0') 'Unbound Route must use the published default list worker.'
    Assert-DispatchTest ((Get-MgRouteProbe -Route Published -ThingId t).Worker -eq 'Get-MgRouteProbe_Route1') 'Published item route selected the wrong worker.'
    Assert-DispatchTest ((Get-MgRouteProbe -Route Legacy).Worker -eq 'Get-MgRouteProbe_Route0') 'Explicit legacy list selected the wrong worker.'
    Assert-DispatchTest ((Get-MgRouteProbe -Route Legacy -ThingId t).Worker -eq 'Get-MgRouteProbe_Route1') 'Explicit legacy item selected the wrong worker.'
    Assert-DispatchTest ((Get-MgRouteProbe -Route Solutions).Worker -eq 'Get-MgRouteProbe_Route2') 'Solutions list selected the wrong worker.'
    Assert-DispatchTest ((Get-MgRouteProbe -Route sOlUtIoNs -ThingId t).Worker -eq 'Get-MgRouteProbe_Route3') 'Case-insensitive solutions item selected the wrong worker.'

    $forwarded = Get-MgRouteProbe -Route Solutions -All -Top 2 -Select id,name -Filter 'active' `
        -AccessToken 'fixture-token' -Headers @{ 'x-probe' = 'fixture' } -Verbose -ErrorAction Stop
    Assert-DispatchTest ($forwarded.Bound.All.IsPresent -and $forwarded.Bound.Top -eq 2) 'List switches and values were not forwarded.'
    Assert-DispatchTest (($forwarded.Bound.Property -join ',') -eq 'id,name' -and $forwarded.Bound.Filter -eq 'active') 'Query alias or filter forwarding failed.'
    Assert-DispatchTest ($forwarded.Bound.AccessToken -eq 'fixture-token' -and $forwarded.Bound.Headers['x-probe'] -eq 'fixture') 'Inherited token/header parameters were lost.'
    Assert-DispatchTest ($forwarded.Bound.ContainsKey('Verbose') -and $forwarded.Bound.ContainsKey('ErrorAction')) 'Common bound parameters were lost.'
    Assert-DispatchTest (-not $forwarded.Bound.ContainsKey('Route')) 'The dispatcher selector leaked into the worker.'

    $before = $global:RouteProbeAttempts.Count
    $invalid = $null
    try { Get-MgRouteProbe -Route Unknown -ErrorAction Stop } catch { $invalid = $_ }
    Assert-DispatchTest ($null -ne $invalid -and $global:RouteProbeAttempts.Count -eq $before) 'Invalid route labels must fail before invoking a worker.'
    $invalid = $null
    try { Get-MgRouteProbe -ThingId t -All -ErrorAction Stop } catch { $invalid = $_ }
    Assert-DispatchTest ($null -ne $invalid -and $global:RouteProbeAttempts.Count -eq $before) 'Invalid list/item parameter combinations must fail before dispatch.'

    Assert-DispatchTest ((Get-MgRouteDistinct -ParentId p -ThingId t).Worker -eq 'Get-MgRouteDistinct_Route0') 'Distinct parent-id set selected the wrong worker.'
    Assert-DispatchTest ((Get-MgRouteDistinct -GroupId g -ThingId t).Worker -eq 'Get-MgRouteDistinct_Route1') 'Distinct group-id set selected the wrong worker.'
    $distinct = Get-Command Get-MgRouteDistinct
    Assert-DispatchTest (-not $distinct.Parameters.ContainsKey('Route')) 'Distinct-id routing must not invent a selector.'
    Assert-DispatchTest ((($distinct.ParameterSets.Name | Sort-Object) -join ',') -eq 'LegacyGet,SolutionsGet') 'Distinct-id parameter sets were not preserved.'

    $remove = Get-Command Remove-MgRouteProbe
    Assert-DispatchTest ($remove.Parameters.ContainsKey('WhatIf') -and $remove.Parameters.ContainsKey('Confirm')) 'Mutation dispatcher lost SupportsShouldProcess.'
    Assert-DispatchTest ((Remove-MgRouteProbe -ThingId t -Confirm:$false).Worker -eq 'Remove-MgRouteProbe_Route1') 'Mutation published default must be independently configurable.'
    Assert-DispatchTest ((Remove-MgRouteProbe -Route Legacy -ThingId t -Confirm:$false).Worker -eq 'Remove-MgRouteProbe_Route0') 'Explicit legacy mutation selected the wrong worker.'
    $before = $global:RouteProbeCalls.Count
    $attemptsBefore = $global:RouteProbeAttempts.Count
    $whatIf = @(Remove-MgRouteProbe -Route Solutions -ThingId t -WhatIf)
    Assert-DispatchTest ($whatIf.Count -eq 0 -and $global:RouteProbeCalls.Count -eq $before) 'WhatIf must not perform the worker mutation.'
    Assert-DispatchTest ($global:RouteProbeAttempts.Count -eq $attemptsBefore + 1 -and $global:RouteProbeAttempts[-1].Bound.WhatIf.IsPresent) 'WhatIf must reach the selected worker unchanged.'
    $failure = $null
    try { Remove-MgRouteProbe -ThingId fail -Confirm:$false -ErrorAction Stop } catch { $failure = $_ }
    Assert-DispatchTest ($null -ne $failure -and $failure.FullyQualifiedErrorId.StartsWith('RouteProbeFailure')) "Worker terminating error identity was rewritten: $failure"

    $getType = (Get-Command Get-MgRouteProbe).ImplementingType
    $routes = @($getType.GetCustomAttributesData() | Where-Object { $_.AttributeType.Name -eq 'GraphRouteAttribute' })
    Assert-DispatchTest ($routes.Count -eq 4) 'Compiled dispatcher lost exact source operation metadata.'
    'Emitted multi-route dispatchers passed mandatory-set and alias rejection, compilation, routing, binding, forwarding, WhatIf and error checks.'
}
finally {
    foreach ($name in $workerNames) { Remove-Item "Function:\global:$name" -ErrorAction SilentlyContinue }
    Remove-Variable RouteProbeCalls, RouteProbeAttempts -Scope Global -ErrorAction SilentlyContinue
    if ($module) { Remove-Module $module -ErrorAction SilentlyContinue }
    Remove-Item $fixtureRoot -Recurse -Force -ErrorAction SilentlyContinue
}
exit 0
