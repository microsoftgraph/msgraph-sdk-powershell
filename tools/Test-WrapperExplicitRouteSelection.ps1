<#
.SYNOPSIS
Compiles explicit-selector count, action and Notes dispatchers with real PowerShell binding.

.DESCRIPTION
Uses the built generator and shared runtime with local stub workers. No Graph session or HTTP
requests are used. Published must retain the configured default even when its required ID is absent.

.EXAMPLE
pwsh -NoProfile -NonInteractive -File .\tools\Test-WrapperExplicitRouteSelection.ps1
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
    $FixtureRoot = Join-Path $repoRoot ".wrapper-explicit-tests-$PID-$([guid]::NewGuid().ToString('N'))"
}
if (-not $Probe) {
    try {
        & pwsh -NoProfile -NonInteractive -File $PSCommandPath -GeneratorAssembly $GeneratorAssembly `
            -RuntimeAssembly $RuntimeAssembly -FixtureRoot $FixtureRoot -Probe
        if ($LASTEXITCODE -ne 0) { throw "Explicit route probe exited $LASTEXITCODE." }
    }
    finally { Remove-Item $FixtureRoot -Recurse -Force -ErrorAction SilentlyContinue }
    exit 0
}

function Assert-ExplicitTest([bool]$Condition, [string]$Message) {
    if (-not $Condition) { throw $Message }
}

function New-ExplicitParameter($Name, $Type, $Mandatory = $false, $Position = $null) {
    [WrapperGenerator.CmdletEmitter+DispatchParameter]::new($Name, $Type, $Mandatory, $Position)
}

function New-ExplicitWorker($Noun, $Path, $Label, $Index, $Parameters, [string[]]$PathIds, [switch]$Action, [string]$Shape) {
    $verb, $verbClass, $method, $defaultShape, $kind = if ($Action) {
        'Invoke', 'VerbsLifecycle', 'POST', 'Invoke', [WrapperGenerator.OperationKind]::Action
    } else {
        'Get', 'VerbsCommon', 'GET', 'Scalar', [WrapperGenerator.OperationKind]::Resource
    }
    if (-not $Shape) { $Shape = $defaultShape }
    $naming = [WrapperGenerator.CmdletNaming]::new(
        $verbClass, $verb, $Noun, "${verb}${Noun}Command", $PathIds, 'Unused',
        [WrapperGenerator.HeaderParam[]]@(), $kind, $null, '', '', '', $null, '', $Path, $method)
    [WrapperGenerator.CmdletEmitter+RouteWorker]::new(
        $naming, [WrapperGenerator.Naming]::WithSuffix($naming, "_Route$Index"),
        $Label, $Shape, [WrapperGenerator.CmdletEmitter+DispatchParameter[]]$Parameters,
        $(if ($Action) { 'System.String' } else { 'System.Int32' }))
}

function Write-ExplicitSource($Workers, $DefaultRoute, [switch]$Action, [switch]$Asymmetric, [switch]$PublishedInference) {
    $routes = @($Workers | ForEach-Object {
        [WrapperGenerator.MultiRoute]::new($_.Naming.SourceMethod, $_.Naming.SourcePath, $_.RouteName)
    })
    $group = [WrapperGenerator.MultiRouteGroup]::new('beta', [WrapperGenerator.MultiRoute[]]$routes, $DefaultRoute, 'Route')
    $group.AllowExplicitRouteSelection = $true
    $group.AllowRouteSpecificBodies = $Action.IsPresent
    $group.AllowAsymmetricRoutes = $Asymmetric.IsPresent
    $group.AllowPublishedParameterInference = $PublishedInference.IsPresent
    $source = [WrapperGenerator.CmdletEmitter]::EmitMultiRouteDispatcher(
        $group, [WrapperGenerator.CmdletEmitter+RouteWorker[]]$Workers,
        [WrapperGenerator.EmitContext]::new('ExplicitInvocationFixture.Client'))
    $path = Join-Path $FixtureRoot ($Workers[0].Naming.ClassName + '.cs')
    Set-Content $path $source
    $path
}

function Assert-ExplicitFlagRequired($Workers, $DefaultRoute, [switch]$Action, [switch]$Asymmetric) {
    $routes = @($Workers | ForEach-Object {
        [WrapperGenerator.MultiRoute]::new($_.Naming.SourceMethod, $_.Naming.SourcePath, $_.RouteName)
    })
    $group = [WrapperGenerator.MultiRouteGroup]::new('beta', [WrapperGenerator.MultiRoute[]]$routes, $DefaultRoute, 'Route')
    $group.AllowRouteSpecificBodies = $Action.IsPresent
    $group.AllowAsymmetricRoutes = $Asymmetric.IsPresent
    Assert-ExplicitTest (-not $group.AllowExplicitRouteSelection) 'Explicit route selection must remain opt-in.'
    Assert-ExplicitTest (-not $group.AllowPublishedParameterInference) 'Published parameter inference must remain opt-in.'
    $failure = $null
    try {
        $null = [WrapperGenerator.CmdletEmitter]::EmitMultiRouteDispatcher(
            $group, [WrapperGenerator.CmdletEmitter+RouteWorker[]]$Workers,
            [WrapperGenerator.EmitContext]::new('ExplicitInvocationFixture.Client'))
    }
    catch { $failure = $_.Exception.GetBaseException() }
    Assert-ExplicitTest ($failure -is [System.InvalidOperationException]) 'Without the new flag, incompatible selector parameter sets must still be rejected.'
}

function Register-ExplicitWorker([string]$Name, [switch]$Action) {
    $binding = if ($Action) { '[CmdletBinding(SupportsShouldProcess)]' } else { '[CmdletBinding()]' }
    $process = if ($Action) { 'if (-not $PSCmdlet.ShouldProcess($ParentId, "Explicit route action")) { return }' } else { '' }
    $source = @'
__BINDING__
param(
    [string]$NestedId, [string]$ParentId, [string]$ItemId, [string]$GroupId, [string]$SectionGroupId,
    [string[]]$Ids, [string]$Filter, [switch]$All, [int]$Top,
    [string]$AccessToken, [System.Collections.IDictionary]$Headers
)
$call = [pscustomobject]@{ Worker = '__NAME__'; Bound = @{} + $PSBoundParameters }
$global:ExplicitRouteAttempts.Add($call)
__PROCESS__
$global:ExplicitRouteCalls.Add($call)
$call
'@
    $source = $source.Replace('__BINDING__', $binding).Replace('__NAME__', $Name).Replace('__PROCESS__', $process)
    Set-Item "Function:\global:$Name" ([scriptblock]::Create($source))
}

function Assert-ExplicitRejected([scriptblock]$Invocation, [string[]]$Details) {
    $before = $global:ExplicitRouteAttempts.Count
    $failure = $null
    try { $null = & $Invocation } catch { $failure = $_ }
    Assert-ExplicitTest ($null -ne $failure) 'Invalid route parameters unexpectedly succeeded.'
    Assert-ExplicitTest ($failure.FullyQualifiedErrorId.StartsWith('InvalidGraphRouteParameters')) "Incorrect error identity: $failure"
    Assert-ExplicitTest ($failure.CategoryInfo.Category -eq 'InvalidArgument') "Incorrect error category: $failure"
    Assert-ExplicitTest ($global:ExplicitRouteAttempts.Count -eq $before) 'An invalid route reached a worker.'
    foreach ($detail in $Details) {
        Assert-ExplicitTest ($failure.Exception.Message -match [regex]::Escape($detail)) "Diagnostic missing '$detail': $failure"
    }
}

function Assert-ExplicitMetadata($CommandName, $Workers, $Shape, [string[]]$Labels, [string[]]$OptionalIds, [string[]]$RequiredIds) {
    $command = Get-Command $CommandName
    Assert-ExplicitTest ($command.ParameterSets.Count -eq 1 -and $command.ParameterSets[0].Name -eq $Shape) "$CommandName must expose a shared $Shape parameter set."
    $set = $command.ParameterSets[0]
    foreach ($id in $OptionalIds) {
        $parameter = @($set.Parameters | Where-Object Name -eq $id)[0]
        Assert-ExplicitTest ($null -ne $parameter -and -not $parameter.IsMandatory) "$CommandName route-unique $id must be publicly optional."
    }
    foreach ($id in $RequiredIds) {
        $parameter = @($set.Parameters | Where-Object Name -eq $id)[0]
        Assert-ExplicitTest ($null -ne $parameter -and $parameter.IsMandatory) "$CommandName common $id must stay mandatory."
    }
    $validate = @($command.Parameters['Route'].Attributes | Where-Object { $_ -is [System.Management.Automation.ValidateSetAttribute] })[0]
    Assert-ExplicitTest ((($validate.ValidValues | Sort-Object) -join ',') -eq ((@('Published') + $Labels | Sort-Object) -join ',')) "$CommandName public selector labels changed."
    $attributes = @($command.ImplementingType.GetCustomAttributes($false))
    $routes = @($attributes | Where-Object { $_.GetType().Name -eq 'GraphRouteAttribute' })
    Assert-ExplicitTest ($routes.Count -eq $Workers.Count) "$CommandName route metadata count changed."
    foreach ($worker in $Workers) {
        $matches = @($routes | Where-Object {
            $_.Method -eq $worker.Naming.SourceMethod -and $_.Path -eq $worker.Naming.SourcePath -and $_.ParameterSetName -eq $Shape
        })
        Assert-ExplicitTest ($matches.Count -eq 1) "$CommandName lost exact operation metadata."
    }
    $outputs = @($attributes | Where-Object { $_ -is [System.Management.Automation.OutputTypeAttribute] })
    Assert-ExplicitTest (@($outputs | Where-Object {
        $_.ParameterSetName -contains $Shape -and @($_.Type | Where-Object { $_.Type.FullName -eq $Workers[0].OutputType }).Count -gt 0
    }).Count -gt 0) "$CommandName lost its output type."
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

    $nested = New-ExplicitParameter NestedId string $true 0
    $filter = New-ExplicitParameter Filter 'string?'
    $countWorkers = @(
        New-ExplicitWorker MgExplicitArticleIndicatorCount '/security/threatIntelligence/articles/{article-id}/indicators/$count' Nested 0 @($nested, $filter) @('NestedId')
        New-ExplicitWorker MgExplicitArticleIndicatorCount '/security/threatIntelligence/articleIndicators/$count' TopLevel 1 @($filter) @()
    )
    $componentWorkers = @(
        New-ExplicitWorker MgExplicitHostComponentCount '/security/threatIntelligence/hosts/{host-id}/components/$count' Nested 0 @($nested, $filter) @('NestedId')
        New-ExplicitWorker MgExplicitHostComponentCount '/security/threatIntelligence/hostComponents/$count' TopLevel 1 @($filter) @()
    )
    $parent = New-ExplicitParameter ParentId string $true 0
    $item = New-ExplicitParameter ItemId string $true 1
    $ids = New-ExplicitParameter Ids 'string[]?'
    $actionWorkers = @(
        New-ExplicitWorker MgExplicitAction '/security/cases/ediscoveryCases/{ediscoveryCase-id}/custodians/{ediscoveryCustodian-id}/microsoft.graph.security.applyHold' Item 0 @($parent, $item) @('ParentId', 'ItemId') -Action
        New-ExplicitWorker MgExplicitAction '/security/cases/ediscoveryCases/{ediscoveryCase-id}/custodians/microsoft.graph.security.applyHold' Collection 1 @($parent, $ids) @('ParentId') -Action
    )
    $groupId = New-ExplicitParameter GroupId string $true 0
    $sectionId = New-ExplicitParameter SectionGroupId string $true 1
    $all = New-ExplicitParameter All SwitchParameter
    $top = New-ExplicitParameter Top int
    $notesWorkers = @(
        New-ExplicitWorker MgExplicitNotes '/groups/{group-id}/onenote/sectionGroups' Root 0 `
            @($groupId, $all, $top) @('GroupId') -Shape List
        New-ExplicitWorker MgExplicitNotes '/groups/{group-id}/onenote/sectionGroups/{sectionGroup-id}' Root 1 `
            @($groupId, $sectionId) @('GroupId', 'SectionGroupId') -Shape Get
        New-ExplicitWorker MgExplicitNotes '/groups/{group-id}/onenote/sectionGroups/{sectionGroup-id}/sectionGroups' Nested 2 `
            @($groupId, $sectionId, $all, $top) @('GroupId', 'SectionGroupId') -Shape List
    )
    $inferredNotesWorkers = @(
        New-ExplicitWorker MgInferredNotes '/groups/{group-id}/onenote/sectionGroups' Root 0 `
            @($groupId, $all, $top) @('GroupId') -Shape List
        New-ExplicitWorker MgInferredNotes '/groups/{group-id}/onenote/sectionGroups/{sectionGroup-id}' Root 1 `
            @($groupId, $sectionId) @('GroupId', 'SectionGroupId') -Shape Get
        New-ExplicitWorker MgInferredNotes '/groups/{group-id}/onenote/sectionGroups/{sectionGroup-id}/sectionGroups' Nested 2 `
            @($groupId, $sectionId, $all, $top) @('GroupId', 'SectionGroupId') -Shape List
    )
    Assert-ExplicitFlagRequired $countWorkers Nested
    Assert-ExplicitFlagRequired $componentWorkers Nested
    Assert-ExplicitFlagRequired $actionWorkers Item -Action
    Assert-ExplicitFlagRequired $notesWorkers Root -Asymmetric
    $sources = @(
        Write-ExplicitSource $countWorkers Nested
        Write-ExplicitSource $componentWorkers Nested
        Write-ExplicitSource $actionWorkers Item -Action
        Write-ExplicitSource $notesWorkers Root -Asymmetric
        Write-ExplicitSource $inferredNotesWorkers Root -Asymmetric -PublishedInference
    )
    $modulePath = Join-Path $FixtureRoot 'Microsoft.Graph.Wrapper.ExplicitProbe.dll'
    $references = @(
        $RuntimeAssembly, [System.Management.Automation.PSCmdlet].Assembly.Location
    ) + @(Get-ChildItem (Join-Path $PSHOME 'ref') -Filter '*.dll' -File | Select-Object -ExpandProperty FullName)
    Add-Type -Path $sources -OutputAssembly $modulePath -CompilerOptions '/nowarn:1701' -ReferencedAssemblies $references
    $module = Import-Module $modulePath -PassThru
    $global:ExplicitRouteAttempts = [System.Collections.Generic.List[object]]::new()
    $global:ExplicitRouteCalls = [System.Collections.Generic.List[object]]::new()
    foreach ($worker in @($countWorkers) + @($componentWorkers) + @($actionWorkers) + @($notesWorkers) + @($inferredNotesWorkers)) {
        $name = "$($worker.InternalNaming.VerbName)-$($worker.InternalNaming.Noun)"
        Register-ExplicitWorker $name -Action:($worker.Naming.SourceMethod -eq 'POST')
        $workerNames += $name
    }

    foreach ($selector in @{}, @{ Route = 'Published' }, @{ Route = 'pUbLiShEd' }) {
        Assert-ExplicitTest ((Get-MgExplicitArticleIndicatorCount -NestedId n @selector).Worker -eq 'Get-MgExplicitArticleIndicatorCount_Route0') 'Published article-indicator count must retain Nested.'
        Assert-ExplicitRejected { Get-MgExplicitArticleIndicatorCount @selector -ErrorAction Stop } @('Nested/Scalar', 'missing', 'NestedId')
        Assert-ExplicitTest ((Get-MgExplicitHostComponentCount -NestedId n @selector).Worker -eq 'Get-MgExplicitHostComponentCount_Route0') 'Published host-component count must retain Nested.'
        Assert-ExplicitRejected { Get-MgExplicitHostComponentCount @selector -ErrorAction Stop } @('Nested/Scalar', 'NestedId')
        Assert-ExplicitTest ((Invoke-MgExplicitAction -ParentId p -ItemId i @selector -Confirm:$false).Worker -eq 'Invoke-MgExplicitAction_Route0') 'Published action must retain Item.'
        Assert-ExplicitRejected { Invoke-MgExplicitAction -ParentId p @selector -Confirm:$false -ErrorAction Stop } @('Item/Invoke', 'missing', 'ItemId')
        Assert-ExplicitRejected { Invoke-MgExplicitAction -ParentId p -Ids x,y @selector -Confirm:$false -ErrorAction Stop } @('ItemId', 'unsupported', 'Ids')
        Assert-ExplicitRejected { Invoke-MgExplicitAction -ParentId p -ItemId i -Ids x @selector -Confirm:$false -ErrorAction Stop } @('unsupported', 'Ids')
        Assert-ExplicitTest ((Get-MgExplicitNotes -GroupId g @selector).Worker -eq 'Get-MgExplicitNotes_Route0') 'Published Notes with the parent ID must select Root/List.'
        Assert-ExplicitTest ((Get-MgExplicitNotes -GroupId g -SectionGroupId s @selector).Worker -eq 'Get-MgExplicitNotes_Route1') 'Published Notes with both IDs must select Root/Get, not Nested/List.'
        Assert-ExplicitTest ((Get-MgExplicitNotes -GroupId g -All @selector).Worker -eq 'Get-MgExplicitNotes_Route0') 'Published Notes must infer a list only within Root.'
        Assert-ExplicitRejected { Get-MgExplicitNotes -GroupId g -SectionGroupId s -All @selector -ErrorAction Stop } @('Root/List', 'SectionGroupId', 'Root/Get', 'All', 'unsupported')
        Assert-ExplicitTest ((Get-MgInferredNotes -GroupId g @selector).Worker -eq 'Get-MgInferredNotes_Route0') 'Inference-enabled Notes must still prefer Root/List with the parent ID.'
        Assert-ExplicitTest ((Get-MgInferredNotes -GroupId g -SectionGroupId s @selector).Worker -eq 'Get-MgInferredNotes_Route1') 'Inference-enabled Notes must prefer compatible Root/Get over Nested/List.'
        Assert-ExplicitTest ((Get-MgInferredNotes -GroupId g -SectionGroupId s -All @selector).Worker -eq 'Get-MgInferredNotes_Route2') 'Inference-enabled Notes must select uniquely compatible Nested/List.'
    }
    Assert-ExplicitTest ((Get-MgExplicitArticleIndicatorCount -Route tOpLeVeL).Worker -eq 'Get-MgExplicitArticleIndicatorCount_Route1') 'Explicit TopLevel must bypass the optional nested ID.'
    Assert-ExplicitTest ((Get-MgExplicitArticleIndicatorCount -Route Nested -NestedId n).Worker -eq 'Get-MgExplicitArticleIndicatorCount_Route0') 'Explicit Nested selected the wrong worker.'
    Assert-ExplicitRejected { Get-MgExplicitArticleIndicatorCount -Route TopLevel -NestedId n -ErrorAction Stop } @('TopLevel/Scalar', 'unsupported', 'NestedId')
    Assert-ExplicitRejected { Get-MgExplicitArticleIndicatorCount -Route Nested -ErrorAction Stop } @('Nested/Scalar', 'missing', 'NestedId')
    Assert-ExplicitTest ((Get-MgExplicitHostComponentCount -Route TopLevel).Worker -eq 'Get-MgExplicitHostComponentCount_Route1') 'Explicit TopLevel host-component count selected the wrong worker.'
    Assert-ExplicitRejected { Get-MgExplicitHostComponentCount -Route TopLevel -NestedId n -ErrorAction Stop } @('NestedId', 'unsupported')
    Assert-ExplicitRejected { Get-MgExplicitHostComponentCount -Route Nested -ErrorAction Stop } @('NestedId', 'missing')

    $collection = Invoke-MgExplicitAction -Route cOlLeCtIoN -ParentId p -Ids x,y -Confirm:$false
    Assert-ExplicitTest ($collection.Worker -eq 'Invoke-MgExplicitAction_Route1' -and ($collection.Bound.Ids -join ',') -eq 'x,y') 'Explicit Collection must forward its body without requiring ItemId.'
    Assert-ExplicitTest ((Invoke-MgExplicitAction -Route Item -ParentId p -ItemId i -Confirm:$false).Worker -eq 'Invoke-MgExplicitAction_Route0') 'Explicit Item selected the wrong worker.'
    Assert-ExplicitRejected { Invoke-MgExplicitAction -Route Item -ParentId p -ItemId i -Ids x -Confirm:$false -ErrorAction Stop } @('Ids', 'unsupported')
    Assert-ExplicitRejected { Invoke-MgExplicitAction -Route Item -ParentId p -Confirm:$false -ErrorAction Stop } @('ItemId', 'missing')
    Assert-ExplicitRejected { Invoke-MgExplicitAction -Route Collection -ParentId p -ItemId i -Confirm:$false -ErrorAction Stop } @('ItemId', 'unsupported')
    Assert-ExplicitTest ((Get-MgExplicitNotes -Route nEsTeD -GroupId g -SectionGroupId s).Worker -eq 'Get-MgExplicitNotes_Route2') 'Explicit Nested with both IDs must select Nested/List despite the shared Route binder set.'
    Assert-ExplicitTest ((Get-MgExplicitNotes -Route Root -GroupId g).Worker -eq 'Get-MgExplicitNotes_Route0') 'Explicit Root with the parent ID must select Root/List.'
    Assert-ExplicitTest ((Get-MgExplicitNotes -Route Root -GroupId g -SectionGroupId s).Worker -eq 'Get-MgExplicitNotes_Route1') 'Explicit Root with both IDs must select Root/Get.'
    Assert-ExplicitRejected { Get-MgExplicitNotes -Route Nested -GroupId g -ErrorAction Stop } @('Nested/List', 'SectionGroupId', 'missing')
    Assert-ExplicitRejected { Get-MgExplicitNotes -Route Root -GroupId g -SectionGroupId s -Top 2 -ErrorAction Stop } @('Root/List', 'SectionGroupId', 'Root/Get', 'Top')
    Assert-ExplicitTest ((Get-MgInferredNotes -Route Nested -GroupId g -SectionGroupId s).Worker -eq 'Get-MgInferredNotes_Route2') 'Published inference must not affect explicit Nested selection.'
    Assert-ExplicitRejected { Get-MgInferredNotes -Route Root -GroupId g -SectionGroupId s -All -ErrorAction Stop } @('Root/List', 'SectionGroupId', 'Root/Get', 'All')
    Assert-ExplicitRejected { Get-MgInferredNotes -Route Nested -GroupId g -ErrorAction Stop } @('Nested/List', 'SectionGroupId', 'missing')

    $forwarded = Get-MgExplicitArticleIndicatorCount -Route TopLevel -Filter active -Headers @{ 'x-fixture' = 'present' } `
        -AccessToken fixture-token -Verbose -ErrorAction Stop
    Assert-ExplicitTest ($forwarded.Bound.Filter -eq 'active' -and $forwarded.Bound.Headers['x-fixture'] -eq 'present' -and $forwarded.Bound.AccessToken -eq 'fixture-token') 'Count query/header/token forwarding failed.'
    Assert-ExplicitTest ($forwarded.Bound.ContainsKey('Verbose') -and $forwarded.Bound.ContainsKey('ErrorAction') -and -not $forwarded.Bound.ContainsKey('Route')) 'Count common parameters or selector stripping changed.'
    $forwarded = Invoke-MgExplicitAction -Route Collection -ParentId p -Ids x `
        -Headers @{ 'x-fixture' = 'action' } -AccessToken fixture-token -Verbose -ErrorAction Stop -Confirm:$false
    Assert-ExplicitTest (($forwarded.Bound.Ids -join ',') -eq 'x' -and $forwarded.Bound.Headers['x-fixture'] -eq 'action' -and $forwarded.Bound.AccessToken -eq 'fixture-token') 'Action body/header/token forwarding failed.'
    Assert-ExplicitTest ($forwarded.Bound.ContainsKey('Verbose') -and $forwarded.Bound.ContainsKey('ErrorAction') -and $forwarded.Bound.ContainsKey('Confirm') -and -not $forwarded.Bound.ContainsKey('Route')) 'Action common parameters or selector stripping changed.'
    $forwarded = Get-MgExplicitNotes -Route Nested -GroupId g -SectionGroupId s -All -Top 2 `
        -Headers @{ 'x-fixture' = 'notes' } -AccessToken fixture-token -Verbose -ErrorAction Stop
    Assert-ExplicitTest ($forwarded.Bound.SectionGroupId -eq 's' -and $forwarded.Bound.All.IsPresent -and $forwarded.Bound.Top -eq 2) 'Nested Notes IDs and list parameters were lost.'
    Assert-ExplicitTest ($forwarded.Bound.Headers['x-fixture'] -eq 'notes' -and $forwarded.Bound.AccessToken -eq 'fixture-token' -and $forwarded.Bound.ContainsKey('Verbose') -and $forwarded.Bound.ContainsKey('ErrorAction') -and -not $forwarded.Bound.ContainsKey('Route')) 'Notes inherited/common forwarding or selector stripping changed.'
    $before = $global:ExplicitRouteCalls.Count
    $attempts = $global:ExplicitRouteAttempts.Count
    $whatIf = @(Invoke-MgExplicitAction -Route Collection -ParentId p -Ids x -WhatIf)
    Assert-ExplicitTest ($whatIf.Count -eq 0 -and $global:ExplicitRouteCalls.Count -eq $before) 'WhatIf must suppress the worker action.'
    Assert-ExplicitTest ($global:ExplicitRouteAttempts.Count -eq $attempts + 1 -and $global:ExplicitRouteAttempts[-1].Bound.WhatIf.IsPresent) 'WhatIf must reach the selected worker unchanged.'
    Assert-ExplicitRejected { Invoke-MgExplicitAction -ParentId p -WhatIf -ErrorAction Stop } @('ItemId', 'missing')

    Assert-ExplicitMetadata Get-MgExplicitArticleIndicatorCount $countWorkers Route @('Nested', 'TopLevel') @('NestedId') @()
    Assert-ExplicitMetadata Get-MgExplicitHostComponentCount $componentWorkers Route @('Nested', 'TopLevel') @('NestedId') @()
    Assert-ExplicitMetadata Invoke-MgExplicitAction $actionWorkers Route @('Item', 'Collection') @('ItemId') @('ParentId')
    Assert-ExplicitMetadata Get-MgExplicitNotes $notesWorkers Route @('Root', 'Nested') @('SectionGroupId') @('GroupId')
    Assert-ExplicitMetadata Get-MgInferredNotes $inferredNotesWorkers Route @('Root', 'Nested') @('SectionGroupId') @('GroupId')
    $actionCommand = Get-Command Invoke-MgExplicitAction
    Assert-ExplicitTest ($actionCommand.Parameters.ContainsKey('WhatIf') -and $actionCommand.Parameters.ContainsKey('Confirm')) 'Action dispatcher lost SupportsShouldProcess.'
    'Explicit-selector Scalar/action/Notes dispatchers passed real binding, strict and opt-in inferred Published routes, validation, forwarding, Route-set metadata and WhatIf checks.'
}
finally {
    foreach ($name in $workerNames) { Remove-Item "Function:\global:$name" -ErrorAction SilentlyContinue }
    Remove-Variable ExplicitRouteCalls, ExplicitRouteAttempts -Scope Global -ErrorAction SilentlyContinue
    if ($module) { Remove-Module $module -ErrorAction SilentlyContinue }
    Remove-Item $FixtureRoot -Recurse -Force -ErrorAction SilentlyContinue
}
exit 0
