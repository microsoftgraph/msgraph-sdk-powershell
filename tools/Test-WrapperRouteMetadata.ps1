<#
.SYNOPSIS
Checks multi-route parity and operation coverage against a small compiled fixture.
#>
[CmdletBinding()]
param()

$ErrorActionPreference = 'Stop'
$repoRoot = (Resolve-Path (Join-Path $PSScriptRoot '..')).Path
$fixtureRoot = Join-Path $repoRoot ".wrapper-route-tests-$PID-$([guid]::NewGuid().ToString('N'))"

function Assert-RouteTest([bool]$Condition, [string]$Message) {
    if (-not $Condition) { throw $Message }
}

try {
    $cmdlets = Join-Path $fixtureRoot 'Fixture\wrapper\v1.0\Cmdlets'
    $bin = Join-Path $fixtureRoot 'Fixture\wrapper\v1.0\bin\Release\fixture'
    $null = New-Item $cmdlets, $bin -ItemType Directory -Force
    '{"descriptionLocation":"openApiDocs/v1.0/Fixture.yml"}' |
        Set-Content (Join-Path $cmdlets 'kiota-lock.json')

    $sources = [ordered]@{
        GetMgThing = @'
    [GraphRoute("GET", "/things", ParameterSetName = "RootList")]
    [GraphRoute("GET", "/things/{thing-id}", ParameterSetName = "RootGet")]
    [GraphRoute("GET", "/parents/{parent-id}/things", ParameterSetName = "ParentList")]
    [GraphRoute("GET", "/parents/{parent-id}/things/{thing-id}", ParameterSetName = "ParentGet")]
    [Cmdlet(VerbsCommon.Get, "MgThing")]
    public sealed class GetMgThingCommand { /* InvokeCommand.InvokeScript */ }
'@
        GetMgThing_Route0 = @'
    [GraphRoute("GET", "/things")]
    [Cmdlet(VerbsCommon.Get, "MgThing_Route0")]
    public sealed class GetMgThing_Route0Command { }
'@
        GetMgThing_Route1 = @'
    [GraphRoute("GET", "/things/{thing-id}")]
    [Cmdlet(VerbsCommon.Get, "MgThing_Route1")]
    public sealed class GetMgThing_Route1Command { }
'@
        GetMgThing_Route2 = @'
    [GraphRoute("GET", "/parents/{parent-id}/things")]
    [Cmdlet(VerbsCommon.Get, "MgThing_Route2")]
    public sealed class GetMgThing_Route2Command { }
'@
        GetMgThing_Route3 = @'
    [GraphRoute("GET", "/parents/{parent-id}/things/{thing-id}")]
    [Cmdlet(VerbsCommon.Get, "MgThing_Route3")]
    public sealed class GetMgThing_Route3Command { }
'@
        GetMgThingCount = @'
    [GraphRoute("GET", "/things/$count", ParameterSetName = "RootScalar")]
    [GraphRoute("GET", "/parents/{parent-id}/things/$count", ParameterSetName = "ParentScalar")]
    [Cmdlet(VerbsCommon.Get, "MgThingCount")]
    public sealed class GetMgThingCountCommand { /* InvokeCommand.InvokeScript */ }
'@
        GetMgThingCount_Route0 = @'
    [GraphRoute("GET", "/things/$count")]
    [Cmdlet(VerbsCommon.Get, "MgThingCount_Route0")]
    public sealed class GetMgThingCount_Route0Command { }
'@
        GetMgThingCount_Route1 = @'
    [GraphRoute("GET", "/parents/{parent-id}/things/$count")]
    [Cmdlet(VerbsCommon.Get, "MgThingCount_Route1")]
    public sealed class GetMgThingCount_Route1Command { }
'@
        GetMgLegacy = @'
    [Cmdlet(VerbsCommon.Get, "MgLegacy")]
    public sealed class GetMgLegacyCommand { /* InvokeCommand.InvokeScript */ }
'@
        GetMgLegacy_List = @'
    [GraphRoute("GET", "/legacy")]
    [Cmdlet(VerbsCommon.Get, "MgLegacy_List")]
    public sealed class GetMgLegacy_ListCommand { }
'@
        GetMgLegacy_Get = @'
    [GraphRoute("GET", "/legacy/{legacy-id}")]
    [Cmdlet(VerbsCommon.Get, "MgLegacy_Get")]
    public sealed class GetMgLegacy_GetCommand { }
'@
    }
    $mutations = @(
        @{ Verb = 'New'; Method = 'POST'; Suffix = ''; Shape = 'New' }
        @{ Verb = 'Update'; Method = 'PATCH'; Suffix = '/{thing-id}'; Shape = 'Update' }
        @{ Verb = 'Set'; Method = 'PUT'; Suffix = '/{thing-id}'; Shape = 'Set' }
        @{ Verb = 'Remove'; Method = 'DELETE'; Suffix = '/{thing-id}'; Shape = 'Remove' }
        @{ Verb = 'Invoke'; Method = 'POST'; Suffix = '/publish'; Shape = 'Action'; NounSuffix = 'Publish' }
        @{ Verb = 'Invoke'; Method = 'POST'; Suffix = '/apply'; Shape = 'Action'; NounSuffix = 'Apply' }
    )
    foreach ($mutation in $mutations) {
        $stem = "$($mutation.Verb)MgThing$($mutation.NounSuffix)"
        $command = "$($mutation.Verb)-MgThing$($mutation.NounSuffix)"
        $root = "/things$($mutation.Suffix)"
        $parent = "/parents/{parent-id}/things$($mutation.Suffix)"
        $mutation.Command = $command
        $mutation.Root = $root
        $mutation.Parent = $parent
        $verbsClass = if ($mutation.Verb -eq 'Update') { 'VerbsData' } elseif ($mutation.Verb -eq 'Invoke') { 'VerbsLifecycle' } else { 'VerbsCommon' }
        $sources[$stem] = @"
    [GraphRoute("$($mutation.Method)", "$root", ParameterSetName = "Root$($mutation.Shape)")]
    [GraphRoute("$($mutation.Method)", "$parent", ParameterSetName = "Parent$($mutation.Shape)")]
    [Cmdlet($verbsClass.$($mutation.Verb), "MgThing$($mutation.NounSuffix)")]
    public sealed class ${stem}Command { /* InvokeCommand.InvokeScript */ }
"@
        for ($i = 0; $i -lt 2; $i++) {
            $worker = "${stem}_Route$i"
            $path = @($root, $parent)[$i]
            $sources[$worker] = @"
    [GraphRoute("$($mutation.Method)", "$path")]
    [Cmdlet($verbsClass.$($mutation.Verb), "MgThing$($mutation.NounSuffix)_Route$i")]
    public sealed class ${worker}Command { }
"@
        }
    }
    $compiledSource = Get-Content (Join-Path $repoRoot 'src\GraphWrapperRuntime\Runtime\GraphRouteAttribute.cs') -Raw
    foreach ($name in $sources.Keys) {
        $declaration = $sources[$name].Replace('Command {', 'Command : PSCmdlet {')
        $text = "namespace RouteMetadataFixture {`nusing System.Management.Automation;`nusing Microsoft.Graph.Wrapper.Runtime;`n$declaration`n}"
        Set-Content (Join-Path $cmdlets "$name.g.cs") $text
        $compiledSource += "`n$text"
    }
    $compiledAssembly = Join-Path $bin 'Microsoft.Graph.Wrapper.RouteFixture.dll'
    Add-Type -TypeDefinition $compiledSource -OutputAssembly $compiledAssembly

    $oraclePath = Join-Path $fixtureRoot 'oracle.json'
    @(
        @{ ApiVersion = 'v1.0'; Method = 'GET'; Uri = '/things'; Command = 'Get-MgThing' }
        @{ ApiVersion = 'v1.0'; Method = 'GET'; Uri = '/things/{thing-id}'; Command = 'Get-MgThing' }
        @{ ApiVersion = 'v1.0'; Method = 'GET'; Uri = '/things/$count'; Command = 'Get-MgThingCount' }
        @{ ApiVersion = 'v1.0'; Method = 'GET'; Uri = '/legacy'; Command = 'Get-MgLegacy' }
        @{ ApiVersion = 'v1.0'; Method = 'GET'; Uri = '/legacy/{legacy-id}'; Command = 'Get-MgLegacy' }
        foreach ($mutation in $mutations) {
            @{ ApiVersion = 'v1.0'; Method = $mutation.Method; Uri = $mutation.Root; Command = $mutation.Command }
        }
    ) | ConvertTo-Json | Set-Content $oraclePath
    $ledgerPath = Join-Path $fixtureRoot 'ledger.csv'
    $gateOutput = & pwsh -NoProfile -File "$PSScriptRoot\Compare-WrapperCmdletNames.ps1" `
        -GeneratedPath $cmdlets -OraclePath $oraclePath -OutLedger $ledgerPath 2>&1
    Assert-RouteTest ($LASTEXITCODE -eq 1) "Missing secondary oracle routes must remain visible: $gateOutput"
    $rows = @(Import-Csv $ledgerPath)
    Assert-RouteTest ($rows.Count -eq 39) "Expected every public and worker route plus the legacy dispatcher, got $($rows.Count): $gateOutput"
    Assert-RouteTest (@($rows | Where-Object Disposition -eq 'matched').Count -eq 20) 'Primary and legacy routes must match the oracle.'
    Assert-RouteTest (@($rows | Where-Object Disposition -eq 'no-oracle').Count -eq 18) 'Secondary public and worker routes were lost.'
    Assert-RouteTest (@($rows | Where-Object Disposition -eq 'dispatcher').Count -eq 1) 'Only the legacy dispatcher should be skipped.'
    Assert-RouteTest (@($rows | Where-Object Command -match '_Route|_List|_Get').Count -eq 0) 'Workers were not mapped to their public commands.'
    Assert-RouteTest (@($rows | Where-Object { $_.Command -eq 'Get-MgThing' -and $_.RouteCount -ne '4' }).Count -eq 0) 'Workers must retain the public route count.'
    Assert-RouteTest (@($rows | Where-Object ParameterSetName -eq 'ParentList').Count -eq 1) 'Route parameter set metadata was lost.'
    Assert-RouteTest (@($rows | Where-Object { $_.Command -eq 'Get-MgThingCount' -and $_.ParameterSetName -in 'RootScalar', 'ParentScalar' }).Count -eq 2) 'Count route parameter-set metadata was lost.'
    foreach ($mutation in $mutations) {
        $publicRows = @($rows | Where-Object { $_.Command -eq $mutation.Command -and $_.ParameterSetName })
        Assert-RouteTest ($publicRows.Count -eq 2 -and @($publicRows | Where-Object Method -eq $mutation.Method).Count -eq 2) "Mutation method/route metadata was lost: $($mutation.Command)."
    }

    # Multi-route groups never infer suppression from an absent oracle row, even when another
    # family renames to this command. Unrelated single routes retain their historical policy.
    $deriveRows = @($rows) + @([pscustomobject]@{
        ApiVersion = 'v1.0'; Method = 'GET'; Uri = '/renamed'; Command = 'Get-MgOldThing'
        Disposition = 'mismatch'; OracleCommands = 'Get-MgThing'; RouteCount = 1
    }, [pscustomobject]@{
        ApiVersion = 'v1.0'; Method = 'GET'; Uri = '/singleRoute'; Command = 'Get-MgUnshippedSingle'
        Disposition = 'no-oracle'; OracleCommands = ''; RouteCount = 1
    })
    $deriveRows | Export-Csv (Join-Path $fixtureRoot 'parity-input-ledger.v1.0.csv') -NoTypeInformation
    $deriveOutput = & pwsh -NoProfile -File "$PSScriptRoot\Derive-ParityResolutions.ps1" `
        -OraclePath $oraclePath -OutDir $fixtureRoot 2>&1
    Assert-RouteTest ($LASTEXITCODE -eq 0) "Derivation failed: $deriveOutput"
    $suppressions = @(Get-Content (Join-Path $fixtureRoot 'parity-suppressions.v1.0.json') -Raw | ConvertFrom-Json)
    Assert-RouteTest ($suppressions.Count -eq 1 -and $suppressions[0].evidence.ourCommand -eq 'Get-MgUnshippedSingle') 'Only the unshipped single route should retain historical suppression.'
    $resolutions = @(Import-Csv (Join-Path $fixtureRoot 'parity-resolution-ledger.v1.0.csv'))
    Assert-RouteTest (@($resolutions | Where-Object Action -eq 'defer-no-oracle').Count -eq 9) 'Expected every distinct secondary route to be explicitly deferred.'

    $completeOracle = @(Get-Content $oraclePath -Raw | ConvertFrom-Json) + @(
        @{ ApiVersion = 'v1.0'; Method = 'GET'; Uri = '/parents/{id}/things'; Command = 'Get-MgThing' }
        @{ ApiVersion = 'v1.0'; Method = 'GET'; Uri = '/parents/{id}/things/{id}'; Command = 'Get-MgThing' }
        @{ ApiVersion = 'v1.0'; Method = 'GET'; Uri = '/parents/{id}/things/$count'; Command = 'Get-MgThingCount' }
        foreach ($mutation in $mutations) {
            @{ ApiVersion = 'v1.0'; Method = $mutation.Method; Uri = $mutation.Parent; Command = $mutation.Command }
        }
    )
    $completeOracle | ConvertTo-Json | Set-Content $oraclePath
    $completeOutput = & pwsh -NoProfile -File "$PSScriptRoot\Compare-WrapperCmdletNames.ps1" `
        -GeneratedPath $cmdlets -OraclePath $oraclePath -OutLedger $ledgerPath 2>&1
    Assert-RouteTest ($LASTEXITCODE -eq 0) "Every route should match when the oracle contains the alternatives: $completeOutput"
    Assert-RouteTest (@(Import-Csv $ledgerPath | Where-Object Disposition -eq 'matched').Count -eq 38) 'A complete oracle must verify every route.'

    $baseline = Join-Path $fixtureRoot 'inventory.csv'
    $inventoryOutput = & pwsh -NoProfile -File "$PSScriptRoot\Compare-WrapperOperationInventory.ps1" `
        -Path $fixtureRoot -Baseline $baseline 2>&1
    Assert-RouteTest ($LASTEXITCODE -eq 0) "Inventory failed: $inventoryOutput"
    $inventory = @(Import-Csv $baseline)
    Assert-RouteTest ($inventory.Count -eq 39) 'Operation inventory lost dispatcher routes.'
    Assert-RouteTest (@($inventory | Where-Object { $_.File -eq 'GetMgThing.g.cs' -and $_.RequestPath -like '/parents/*' }).Count -eq 2) 'Inventory lost nested routes.'

    $manifestOutput = & pwsh -NoProfile -File "$PSScriptRoot\New-WrapperOutputManifest.ps1" `
        -GeneratedRoot $fixtureRoot -OutDir $fixtureRoot 2>&1
    Assert-RouteTest ($LASTEXITCODE -eq 0) "Output manifest failed: $manifestOutput"
    $manifest = @(Import-Csv (Join-Path $fixtureRoot 'WrapperCmdlets-V1.0.csv'))
    Assert-RouteTest (@($manifest | Where-Object IsWorker -eq 'True').Count -eq 20) 'Manifest misclassified route workers as public commands.'
    $publicGet = $manifest | Where-Object Cmdlet -eq 'Get-MgThing'
    Assert-RouteTest ($publicGet.RequestPath -eq 'GET /things;GET /things/{thing-id};GET /parents/{parent-id}/things;GET /parents/{parent-id}/things/{thing-id}') 'Manifest lost a dispatcher route.'
    $summary = Import-Csv (Join-Path $fixtureRoot 'WrapperCmdlets-V1.0-Summary.csv')
    Assert-RouteTest ($summary.Cmdlets -eq '9' -and $summary.WorkerFiles -eq '20') 'Manifest counts must count commands, not route rows.'
    foreach ($mutation in $mutations) {
        $public = @($manifest | Where-Object Cmdlet -eq $mutation.Command)
        Assert-RouteTest ($public.Count -eq 1 -and $public[0].RequestPath -ceq "$($mutation.Method) $($mutation.Root);$($mutation.Method) $($mutation.Parent)") "Manifest lost mutation routes: $($mutation.Command)."
    }

    $moduleTestAst = [System.Management.Automation.Language.Parser]::ParseFile(
        (Join-Path $PSScriptRoot 'Test-WrapperModule.ps1'), [ref]$null, [ref]$null)
    $inventoryFunction = $moduleTestAst.Find({
        param($node)
        $node -is [System.Management.Automation.Language.FunctionDefinitionAst] -and $node.Name -eq 'Get-WrapperDispatchInventory'
    }, $false)
    . ([scriptblock]::Create($inventoryFunction.Extent.Text))
    $commands = @($manifest | ForEach-Object { [pscustomobject]@{ Name = $_.Cmdlet } })
    $dispatchInventory = Get-WrapperDispatchInventory $commands
    Assert-RouteTest ($dispatchInventory.Workers.Count -eq 20 -and $dispatchInventory.Orphans.Count -eq 0) 'Runtime gate lost route workers or invented orphans.'
    Assert-RouteTest ($dispatchInventory.Dispatcher.Name -in 'Get-MgThing', 'Get-MgLegacy') 'Runtime gate failed to find a public GET dispatcher.'
    $routesOnly = @($commands | Where-Object Name -notlike '*Legacy*')
    Assert-RouteTest ((Get-WrapperDispatchInventory $routesOnly).Dispatcher.Name -eq 'Get-MgThing') 'Runtime gate requires obsolete _List workers to find a new dispatcher.'
    $withOrphan = @($commands) + @([pscustomobject]@{ Name = 'Get-MgMissing_Route0' })
    Assert-RouteTest ((Get-WrapperDispatchInventory $withOrphan).Orphans.Count -eq 1) 'Runtime gate ignored an orphan route worker.'
    $legacyOnly = @($commands | Where-Object Name -like '*Legacy*')
    Assert-RouteTest ((Get-WrapperDispatchInventory $legacyOnly).Dispatcher.Name -eq 'Get-MgLegacy') 'Runtime gate broke legacy paired GET detection.'
    $mutationOnly = @($commands | Where-Object Name -notlike 'Get-*')
    Assert-RouteTest ((Get-WrapperDispatchInventory $mutationOnly).Dispatcher.Name -in $mutations.Command) 'Runtime gate requires GET to find a mutation dispatcher.'
    $mutationOrphan = @($mutationOnly) + @([pscustomobject]@{ Name = 'Remove-MgMissing_Route0' })
    Assert-RouteTest ((Get-WrapperDispatchInventory $mutationOrphan).Orphans.Count -eq 1) 'Runtime gate ignored an orphan mutation worker.'

    $buildAst = [System.Management.Automation.Language.Parser]::ParseFile(
        (Join-Path $PSScriptRoot 'Build-WrapperModule.ps1'), [ref]$null, [ref]$null)
    $discoveryFunction = $buildAst.Find({
        param($node)
        $node -is [System.Management.Automation.Language.FunctionDefinitionAst] -and $node.Name -eq 'Get-CompiledCmdletNames'
    }, $false)
    . ([scriptblock]::Create($discoveryFunction.Extent.Text))
    $exports = @(Get-CompiledCmdletNames -AssemblyPath $compiledAssembly)
    Assert-RouteTest ($exports.Count -eq 29) 'Build manifest discovery lost compiled commands.'
    Assert-RouteTest (@($exports | Where-Object { $_ -match '_Route\d+$' }).Count -eq 18) 'Build manifest discovery hid route workers.'

    $dispatcherFile = Join-Path $cmdlets 'GetMgThing.g.cs'
    (Get-Content $dispatcherFile -Raw).Replace('/parents/{parent-id}/things', '/otherParents/{parent-id}/things') |
        Set-Content $dispatcherFile
    $comparisonOutput = & pwsh -NoProfile -File "$PSScriptRoot\Compare-WrapperOperationInventory.ps1" `
        -Path $fixtureRoot -Baseline $baseline -Compare (Join-Path $fixtureRoot 'after.csv') -AllowSameGenerator 2>&1
    Assert-RouteTest ($LASTEXITCODE -eq 1) "Changing only a secondary route must change the coverage inventory: $comparisonOutput"

    # A stale assembly must not turn a new metadata-bearing dispatcher into a legacy skip, nor
    # quietly discard another route when several attributes were already compiled.
    $legacyFile = Join-Path $cmdlets 'GetMgLegacy.g.cs'
    (Get-Content $legacyFile -Raw).Replace('[Cmdlet(', '[GraphRoute("GET", "/legacy")] [Cmdlet(') |
        Set-Content $legacyFile
    (Get-Content $dispatcherFile -Raw).Replace('[Cmdlet(', '[GraphRoute("GET", "/thirdRoute")] [Cmdlet(') |
        Set-Content $dispatcherFile
    $staleOutput = & pwsh -NoProfile -File "$PSScriptRoot\Compare-WrapperCmdletNames.ps1" `
        -GeneratedPath $cmdlets -OraclePath $oraclePath -OutLedger $ledgerPath 2>&1
    Assert-RouteTest ($LASTEXITCODE -eq 1) "Stale route metadata must fail: $staleOutput"
    $staleRows = @(Import-Csv $ledgerPath)
    Assert-RouteTest (@($staleRows | Where-Object Disposition -eq 'no-route').Count -eq 2) 'Stale dispatchers silently lost route metadata.'
    'Multi-route metadata, parity, derivation and coverage checks passed.'
}
finally {
    Remove-Item $fixtureRoot -Recurse -Force -ErrorAction SilentlyContinue
}
exit 0
