<#
.SYNOPSIS
Compiles real route-specific action dispatchers and checks PowerShell binding with local workers.

.DESCRIPTION
Requires built WrapperGenerator and shared runtime assemblies, plus Microsoft.Graph.Authentication
for the runtime's assembly-resolution hook. No Graph session, tenant data or HTTP calls are used.

.EXAMPLE
pwsh -NoProfile -NonInteractive -File .\tools\Test-WrapperRouteSpecificActions.ps1
#>
[CmdletBinding()]
param(
    [string]$GeneratorAssembly = "$PSScriptRoot\WrapperGenerator\bin\Debug\net10.0\WrapperGenerator.dll",
    [string]$RuntimeAssembly = "$PSScriptRoot\..\src\GraphWrapperRuntime\Runtime\bin\Debug\netstandard2.0\Microsoft.Graph.Wrapper.Runtime.dll",
    [Parameter(DontShow)][string]$FixtureRoot,
    [Parameter(DontShow)][switch]$Probe
)

$ErrorActionPreference = 'Stop'
if (-not $FixtureRoot) {
    $FixtureRoot = Join-Path (Resolve-Path (Join-Path $PSScriptRoot '..')).Path ".wrapper-action-tests-$PID-$([guid]::NewGuid().ToString('N'))"
}
# Windows holds the imported binary open until its process exits.
if (-not $Probe) {
    try {
        & pwsh -NoProfile -NonInteractive -File $PSCommandPath -GeneratorAssembly $GeneratorAssembly `
            -RuntimeAssembly $RuntimeAssembly -FixtureRoot $FixtureRoot -Probe
        if ($LASTEXITCODE -ne 0) { throw "Route-specific action probe exited $LASTEXITCODE." }
    }
    finally { Remove-Item $FixtureRoot -Recurse -Force -ErrorAction SilentlyContinue }
    exit 0
}

function Assert-ActionTest([bool]$Condition, [string]$Message) {
    if (-not $Condition) { throw $Message }
}

function New-ActionWorker([string]$Action, [bool]$Recommendation, [bool]$Item) {
    $noun = 'MgDirectory' + $(if ($Recommendation) { 'Recommendation' }) + "ImpactedResource$Action"
    $root = if ($Recommendation) { '/directory/recommendations/{recommendation-id}/impactedResources' } else { '/directory/impactedResources' }
    $path = $root + $(if ($Item) { '/{impactedResource-id}' }) + '/' + $Action.Substring(0, 1).ToLowerInvariant() + $Action.Substring(1)
    $pathNames = @(
        if ($Recommendation) { 'RecommendationId' }
        if ($Item) { 'ImpactedResourceId' }
    )
    $templates = @(
        if ($Recommendation) { 'recommendation-id' }
        if ($Item) { 'impactedResource-id' }
    )
    $builder = 'Directory.' + $(if ($Recommendation) { 'Recommendations[RecommendationId].' }) + 'ImpactedResources' `
        + $(if ($Item) { '[ImpactedResourceId]' }) + ".$Action"
    $operationNamespace = 'DirectoryNamespace.' + $(if ($Recommendation) { 'Recommendations.Item.' }) `
        + 'ImpactedResources.' + $(if ($Item) { 'Item.' }) + $Action
    $naming = [WrapperGenerator.CmdletNaming]::new(
        'VerbsLifecycle', 'Invoke', $noun, "Invoke${noun}Command", [string[]]$pathNames, $builder,
        [WrapperGenerator.HeaderParam[]]@([WrapperGenerator.HeaderParam]::new('x-action-probe', 'ActionProbeHeader')),
        [WrapperGenerator.OperationKind]::Action, $null, $operationNamespace, $Action, $Action,
        [string[]]$templates, $path.ToLowerInvariant(), $path, 'POST')
    $body = @(
        if (-not $Item) {
            [WrapperGenerator.CmdletEmitter+DispatchParameter]::new('ResourceIds', 'string[]?', $false, $null)
        }
        if ($Item -and $Action -eq 'RemoveTag') {
            [WrapperGenerator.CmdletEmitter+DispatchParameter]::new('TagId', 'string?', $false, $null)
        } else {
            [WrapperGenerator.CmdletEmitter+DispatchParameter]::new('DisplayName', 'string?', $false, $null)
        }
    )
    $parameters = [WrapperGenerator.CmdletEmitter]::GetDispatchParameters(
        $naming, 'Invoke', [System.Collections.Generic.HashSet[string]]::new(),
        [WrapperGenerator.CmdletEmitter+DispatchParameter[]]$body)
    $index = if ($Item) { 1 } else { 0 }
    [WrapperGenerator.CmdletEmitter+RouteWorker]::new(
        $naming, [WrapperGenerator.Naming]::WithSuffix($naming, "_Route$index"),
        $(if ($Item) { 'Item' } else { 'Collection' }), 'Invoke', $parameters,
        $(if ($Item) { 'int' } else { 'string' }))
}

function Register-ActionWorker($Worker) {
    $name = "$($Worker.InternalNaming.VerbName)-$($Worker.InternalNaming.Noun)"
    $parameters = @($Worker.Parameters | ForEach-Object {
        $type = $_.Type.TrimEnd('?')
        "[$type]`$$($_.Name)"
    }) + @('[string]$AccessToken', '[System.Collections.IDictionary]$Headers')
    $body = @'
[CmdletBinding(SupportsShouldProcess, ConfirmImpact = 'Medium')]
param(__PARAMETERS__)
$call = [pscustomobject]@{ Worker = '__NAME__'; Bound = @{} + $PSBoundParameters }
$global:ActionProbeAttempts.Add($call)
if (-not $PSCmdlet.ShouldProcess('__NAME__', 'Probe action')) { return }
$global:ActionProbeCalls.Add($call)
__OUTPUT__
'@
    $body = $body.Replace('__PARAMETERS__', ($parameters -join ', ')).Replace('__NAME__', $name)
    $body = $body.Replace('__OUTPUT__', $(if ($Worker.RouteName -eq 'Item') { '17' } else { "'collection-result'" }))
    Set-Item "Function:\global:$name" ([scriptblock]::Create($body))
    $name
}

function Invoke-CheckedAction($Fixture, [hashtable]$Bound, [string]$Route) {
    $before = $global:ActionProbeAttempts.Count
    $callsBefore = $global:ActionProbeCalls.Count
    $invocation = @{} + $Bound
    $invocation.Confirm = $false
    $invocation.ErrorAction = 'Stop'
    $output = @(& $Fixture.Command @invocation)
    Assert-ActionTest ($global:ActionProbeAttempts.Count -eq $before + 1) "$($Fixture.Command) must invoke exactly one $Route worker."
    $call = $global:ActionProbeAttempts[-1]
    $worker = @($Fixture.Workers | Where-Object RouteName -eq $Route)[0]
    Assert-ActionTest ($call.Worker -eq "$($worker.InternalNaming.VerbName)-$($worker.InternalNaming.Noun)") "$($Fixture.Command) selected the wrong $Route worker."
    foreach ($key in $invocation.Keys) {
        Assert-ActionTest ($call.Bound.ContainsKey($key)) "$($Fixture.Command) dropped bound parameter $key."
        if ($key -in 'WhatIf', 'Confirm', 'Verbose') {
            Assert-ActionTest ($call.Bound[$key].IsPresent -eq [bool]$invocation[$key]) "$key changed during forwarding."
        } elseif ($key -eq 'Headers') {
            Assert-ActionTest ($call.Bound.Headers['x-generic-probe'] -eq 'generic-value') 'Generic headers changed during forwarding.'
        } else {
            Assert-ActionTest (($call.Bound[$key] -join ',') -eq ($invocation[$key] -join ',')) "$key changed during forwarding."
        }
    }
    Assert-ActionTest (-not $call.Bound.ContainsKey('Route') -and -not $call.Bound.ContainsKey('BodyParameter')) 'An invented selector or body union leaked to the worker.'
    if ($invocation.WhatIf) {
        Assert-ActionTest ($output.Count -eq 0 -and $global:ActionProbeCalls.Count -eq $callsBefore) 'WhatIf must reach the selected worker without performing the action.'
    } else {
        $type = if ($Route -eq 'Item') { [int] } else { [string] }
        Assert-ActionTest ($output.Count -eq 1 -and $output[0].GetType() -eq $type) 'The selected worker output does not match its scoped output metadata.'
        Assert-ActionTest ($global:ActionProbeCalls.Count -eq $callsBefore + 1) 'The selected action did not run exactly once.'
    }
    $call
}

function Assert-ActionBindingRejected($Fixture, [hashtable]$Bound, [string]$ErrorId) {
    $before = $global:ActionProbeAttempts.Count
    $failure = $null
    try { $null = & $Fixture.Command @Bound -Confirm:$false -ErrorAction Stop }
    catch { $failure = $_ }
    Assert-ActionTest ($null -ne $failure -and $failure.Exception -is [System.Management.Automation.ParameterBindingException]) "$($Fixture.Command) must reject invalid parameters through the real PowerShell binder: $failure"
    Assert-ActionTest ($failure.FullyQualifiedErrorId.StartsWith("$ErrorId,")) "Expected $ErrorId from $($Fixture.Command): $failure"
    Assert-ActionTest ($global:ActionProbeAttempts.Count -eq $before) 'Invalid parameters reached a worker instead of failing binding.'
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
    $fixtures = @(
        foreach ($recommendation in $false, $true) {
            foreach ($action in 'AddTag', 'RemoveTag') {
                $workers = @(
                    New-ActionWorker $action $recommendation $false
                    New-ActionWorker $action $recommendation $true
                )
                $routes = @($workers | ForEach-Object {
                    [WrapperGenerator.MultiRoute]::new('POST', $_.Naming.SourcePath, $_.RouteName)
                })
                $group = [WrapperGenerator.MultiRouteGroup].GetConstructors()[0].Invoke(
                    [object[]]@('v1.0', [WrapperGenerator.MultiRoute[]]$routes, 'Collection', $null))
                $group.AllowRouteSpecificBodies = $true
                $group.AllowResponseUnion = $true
                $source = [WrapperGenerator.CmdletEmitter]::EmitMultiRouteDispatcher(
                    $group, [WrapperGenerator.CmdletEmitter+RouteWorker[]]$workers,
                    [WrapperGenerator.EmitContext]::new('RouteSpecificActionFixture.Client'))
                $path = Join-Path $FixtureRoot ($workers[0].Naming.ClassName + '.cs')
                Set-Content $path $source
                [pscustomobject]@{
                    Command = "$($workers[0].Naming.VerbName)-$($workers[0].Naming.Noun)"
                    Action = $action; Recommendation = $recommendation; Workers = $workers; SourcePath = $path
                }
            }
        }
    )
    $modulePath = Join-Path $FixtureRoot 'Microsoft.Graph.Wrapper.RouteSpecificActionProbe.dll'
    $references = @($RuntimeAssembly, [System.Management.Automation.PSCmdlet].Assembly.Location) `
        + @(Get-ChildItem (Join-Path $PSHOME 'ref') -Filter '*.dll' -File | Select-Object -ExpandProperty FullName)
    Add-Type -Path $fixtures.SourcePath -OutputAssembly $modulePath -CompilerOptions '/nowarn:1701' -ReferencedAssemblies $references
    $module = Import-Module $modulePath -PassThru
    $global:ActionProbeAttempts = [System.Collections.Generic.List[object]]::new()
    $global:ActionProbeCalls = [System.Collections.Generic.List[object]]::new()
    foreach ($fixture in $fixtures) {
        foreach ($worker in $fixture.Workers) { $workerNames += Register-ActionWorker $worker }
        $command = Get-Command $fixture.Command
        Assert-ActionTest ((($command.ParameterSets.Name | Sort-Object) -join ',') -eq 'CollectionInvoke,ItemInvoke') 'Action dispatchers must expose exactly their two route-specific sets, without Expanded sets.'
        Assert-ActionTest (@($command.ParameterSets | Where-Object IsDefault).Name -eq 'CollectionInvoke') 'Collection must remain the published default.'
        Assert-ActionTest (-not $command.Parameters.ContainsKey('Route') -and -not $command.Parameters.ContainsKey('BodyParameter')) 'Action dispatchers must not invent a selector or a body union.'
        Assert-ActionTest ($command.Parameters.ContainsKey('WhatIf') -and $command.Parameters.ContainsKey('Confirm')) 'Action dispatcher lost SupportsShouldProcess.'
        foreach ($worker in $fixture.Workers) {
            $set = @($command.ParameterSets | Where-Object Name -eq ($worker.RouteName + 'Invoke'))[0]
            foreach ($parameter in $worker.Parameters) {
                $metadata = @($set.Parameters | Where-Object Name -eq $parameter.Name)[0]
                Assert-ActionTest ($null -ne $metadata -and $metadata.IsMandatory -eq $parameter.Mandatory) "Incorrect scoped mandatory metadata for $($parameter.Name)."
                Assert-ActionTest ($command.Parameters.Keys -ccontains $parameter.Name) "Canonical parameter name $($parameter.Name) was changed."
                Assert-ActionTest ($metadata.Aliases.Count -eq 0) "Unexpected alias on canonical parameter $($parameter.Name)."
            }
            foreach ($name in 'ResourceIds', 'DisplayName', 'TagId', 'ImpactedResourceId', 'RecommendationId') {
                $expected = @($worker.Parameters | Where-Object Name -eq $name).Count -gt 0
                Assert-ActionTest (($set.Parameters.Name -contains $name) -eq $expected) "$name leaked into the wrong route's public parameter set."
            }
        }
        $outputs = @($command.ImplementingType.GetCustomAttributes([System.Management.Automation.OutputTypeAttribute], $false))
        Assert-ActionTest ($outputs.Count -eq 2) 'Action output metadata must preserve both route-specific response types.'
        foreach ($route in 'Collection', 'Item') {
            $output = @($outputs | Where-Object { $_.ParameterSetName -contains "${route}Invoke" })
            $expectedType = if ($route -eq 'Item') { [int] } else { [string] }
            Assert-ActionTest ($output.Count -eq 1 -and $output[0].Type[0].Type -eq $expectedType) "$route output type was erased or assigned to the wrong parameter set."
            Assert-ActionTest ($output[0].ParameterSetName.Count -eq 1) 'Response union metadata must not claim both types for every route.'
        }
        $routes = @($command.ImplementingType.GetCustomAttributesData() | Where-Object { $_.AttributeType.Name -eq 'GraphRouteAttribute' })
        Assert-ActionTest ($routes.Count -eq 2) 'Action dispatcher lost exact route metadata.'
        foreach ($worker in $fixture.Workers) {
            $route = @($routes | Where-Object { $_.ConstructorArguments[1].Value -eq $worker.Naming.SourcePath })
            Assert-ActionTest ($route.Count -eq 1 -and $route[0].ConstructorArguments[0].Value -eq 'POST') 'Action route path or HTTP method was changed.'
            Assert-ActionTest (@($route[0].NamedArguments | Where-Object MemberName -eq 'ParameterSetName')[0].TypedValue.Value -eq ($worker.RouteName + 'Invoke')) 'Action route metadata has the wrong parameter set.'
        }

        $parent = if ($fixture.Recommendation) { @{ RecommendationId = 'recommendation-1' } } else { @{} }
        $null = Invoke-CheckedAction $fixture $parent Collection
        $common = @{
            AccessToken = 'fixture-token'; Headers = @{ 'x-generic-probe' = 'generic-value' }
            ActionProbeHeader = 'named-value'; Verbose = $true
        }
        $collection = $parent + $common + @{ ResourceIds = @('resource-1', 'resource-2'); DisplayName = 'collection-tag' }
        $call = Invoke-CheckedAction $fixture $collection Collection
        Assert-ActionTest (-not $call.Bound.ContainsKey('ImpactedResourceId') -and -not $call.Bound.ContainsKey('TagId')) 'Collection dispatch received item-only parameters.'
        $item = $parent + $common + @{ ImpactedResourceId = 'resource-1' }
        if ($fixture.Action -eq 'AddTag') { $item.DisplayName = 'item-tag' } else { $item.TagId = 'tag-1' }
        $call = Invoke-CheckedAction $fixture $item Item
        Assert-ActionTest (-not $call.Bound.ContainsKey('ResourceIds')) 'Item dispatch received collection-only ResourceIds.'
        $null = Invoke-CheckedAction $fixture ($parent + @{ ImpactedResourceId = 'resource-1' }) Item
        $null = Invoke-CheckedAction $fixture ($collection + @{ WhatIf = $true }) Collection
        $null = Invoke-CheckedAction $fixture ($item + @{ WhatIf = $true }) Item
        Assert-ActionBindingRejected $fixture ($parent + @{ ResourceIds = @('resource-1'); ImpactedResourceId = 'resource-1' }) AmbiguousParameterSet
        if ($fixture.Action -eq 'RemoveTag') {
            Assert-ActionBindingRejected $fixture ($parent + @{ TagId = 'tag-1' }) MissingMandatoryParameter
            Assert-ActionBindingRejected $fixture ($parent + @{ ImpactedResourceId = 'resource-1'; DisplayName = 'unsupported-item-field' }) AmbiguousParameterSet
        }
        if ($fixture.Recommendation) {
            Assert-ActionBindingRejected $fixture @{ ImpactedResourceId = 'resource-1' } MissingMandatoryParameter
        }
    }
    'Four real action dispatchers passed route-specific binding, body scoping, response union, forwarding, WhatIf and invalid-combination checks.'
}
finally {
    foreach ($name in $workerNames) { Remove-Item "Function:\global:$name" -ErrorAction SilentlyContinue }
    Remove-Variable ActionProbeAttempts, ActionProbeCalls -Scope Global -ErrorAction SilentlyContinue
    if ($module) { Remove-Module $module -ErrorAction SilentlyContinue }
    Remove-Item $FixtureRoot -Recurse -Force -ErrorAction SilentlyContinue
}
exit 0
