<#
.SYNOPSIS
Checks real directive sources/Compliance absences and source-aware ledger failure cases.
#>
[CmdletBinding()]
param()
$ErrorActionPreference = 'Stop'
$tool = Join-Path $PSScriptRoot 'Get-WrapperDirectiveMigrationInventory.ps1'
$repo = (Resolve-Path (Join-Path $PSScriptRoot '..')).Path
$before = & git -C $repo status --porcelain
function Assert-Fails([scriptblock]$Action, [string]$Pattern) {
    try { & $Action | Out-Null } catch {
        if ($_.Exception.Message -notmatch $Pattern) { throw }
        return
    }
    throw "Expected failure matching '$Pattern'."
}
function Get-FixtureSpecHash([string]$Path) {
    [Convert]::ToHexString([Security.Cryptography.SHA256]::HashData(
        [Text.Encoding]::UTF8.GetBytes([IO.File]::ReadAllText($Path).Replace("`r`n", "`n")))).ToLowerInvariant()
}
$all = @(& $tool)
$configured = Get-Content (Join-Path $repo 'config\ModulesMapping.jsonc') -Raw | ConvertFrom-Json -AsHashtable
if (@($all.Module | Sort-Object -Unique).Count -ne $configured.Count) { throw 'Inventory must include every configured module.' }
if ($all.Module -contains 'DeviceManagement.Actions') { throw 'Dormant unconfigured modules must not be inventoried.' }
foreach ($name in @('BackupRestore', 'BusinessScenario', 'ConfigurationManagement')) {
    if (-not @($all | Where-Object { $_.Module -eq $name -and $_.SourcePath -eq 'src\readme.graph.md' }).Count) { throw "$name is missing shared directives." }
}
$compliance = @($all | Where-Object { $_.Module -eq 'Compliance' -and $_.SourcePath -eq 'src\Compliance\Compliance.md' })
if ($compliance.Count -ne 2 -or @($compliance | Where-Object { $_.Status -ne 'Mapped' -or $_.Implementation -ne 'ReviewedAbsence' -or $_.V1Operations.Count -or $_.BetaOperations.Count }).Count) {
    throw 'Compliance must record true reviewed absences, not stale generated coverage.'
}
foreach ($classification in @('DeferredParameter', 'DeferredCmdletAlias', 'DeferredTransform', 'DeferredSchema', 'DeferredFormatting', 'NoEffectSelector')) {
    if (-not @($all | Where-Object Classification -eq $classification).Count) { throw "Missing classification: $classification" }
}
$betaLocal = @($all | Where-Object { $_.Module -eq 'Bookings' -and $_.SourcePath -eq 'src\Bookings\beta\readme.md' })
if ($betaLocal.Count -ne 3 -or @($betaLocal | Where-Object { $_.Profiles.Count -ne 1 -or $_.Profiles[0] -ne 'beta' }).Count) { throw 'Profile-local sources must not leak across profiles.' }
if (-not @($all | Where-Object { $_.Module -eq 'Calendar' -and $_.Implementation -eq 'Candidate' }).Count) { throw 'Real operation-ID matches should remain candidates.' }
Assert-Fails { & $tool -Module Compliance -FailOnUnresolved } 'unresolved or unreviewed'
Assert-Fails { & $tool -Module DeviceManagement.Actions } 'not configured'

$fixture = Join-Path ([IO.Path]::GetTempPath()) "directive-inventory-$([guid]::NewGuid())"
try {
    foreach ($dir in @('tools', 'config', 'src\Widget\wrapper', 'src\Widget\beta', 'openApiDocs_KiotaCompat\v1.0', 'openApiDocs_KiotaCompat\beta')) {
        New-Item -ItemType Directory -Path (Join-Path $fixture $dir) -Force | Out-Null
    }
    Copy-Item -LiteralPath $tool -Destination (Join-Path $fixture 'tools')
    $fixtureTool = Join-Path $fixture 'tools\Get-WrapperDirectiveMigrationInventory.ps1'
    '{"Widget":{}}' | Set-Content (Join-Path $fixture 'config\ModulesMapping.jsonc')
    @'
``` yaml
directive:
  - where:
      verb: Get
      subject: Widget
```
'@ | Set-Content (Join-Path $fixture 'src\readme.graph.md')
    @'
``` yaml
directive:
  - remove-path-by-operation: ^WIDGETS_DELETE$
  - where:
      parameter-name: Name
    set:
      alias: DisplayName
  - where:
      subject: Widget
    set:
      alias: Get-WidgetAlias
```
'@ | Set-Content (Join-Path $fixture 'src\Widget\Widget.md')
    @'
``` yaml
directive:
  - where:
      subject: Widget
    remove: true
```
'@ | Set-Content (Join-Path $fixture 'src\Widget\beta\readme.md')
    $spec = @'
openapi: 3.0.0
paths:
  /widgets/{widget-id}:
    delete:
      operationId: Widgets_Delete
    get:
      operationId: Widgets_Get
  /widgets/{widget-id}/neighbor:
    delete:
      operationId: Widgets_DeleteNeighbor
'@
    foreach ($profile in @('v1.0', 'beta')) { $spec | Set-Content (Join-Path $fixture "openApiDocs_KiotaCompat\$profile\Widget.yml") }
    $ledger = Join-Path $fixture 'src\Widget\wrapper\Widget_directiveMigrationMap.json'
    $rows = @(& $fixtureTool)
    $operation = $rows | Where-Object Classification -eq 'OperationIdSuppression'
    if ($operation.Status -ne 'Resolved' -or $operation.V1Operations.Count -ne 1 -or $operation.BetaOperations.Count -ne 1) { throw 'Operation-ID resolution must honor AutoRest case-insensitive matching without selecting neighbors.' }
    Assert-Fails { & $fixtureTool -FailOnUnresolved } 'unreviewed candidates'
    $maps = @()
    foreach ($row in $rows | Where-Object Status -ne 'Deferred') {
        $profileMap = @{}
        foreach ($profile in @('v1.0', 'beta')) {
            $applicable = $row.Profiles -contains $profile
            $profileMap[$profile] = if (-not $applicable) { @{ notApplicable = $true; operations = @() } }
            else {
                @{
                    specPath = "openApiDocs_KiotaCompat\$profile\Widget.yml"
                    specSha256 = Get-FixtureSpecHash (Join-Path $fixture "openApiDocs_KiotaCompat\$profile\Widget.yml")
                    absenceExpected = $row.Classification -eq 'NoEffectSelector'
                    absenceEvidence = 'Synthetic selector intentionally has no set/remove action.'
                    operations = if ($row.Classification -eq 'NoEffectSelector') { @() } else {
                        @(@{ method = 'DELETE'; path = '/widgets/{widget-id}'; operationId = 'Widgets_Delete' })
                    }
                }
            }
        }
        $maps += @{
            module = 'Widget'; sourcePath = $row.SourcePath; directiveIndex = $row.DirectiveIndex
            sourceSha256 = $row.SourceSha256; classification = $row.Classification; reviewed = $true
            implementation = if ($row.Classification -eq 'NoEffectSelector') { 'NoEffect' } else { 'CmdletConfigurator' }
            notes = 'Synthetic reviewed fixture; production mappings need real directive evidence and regression tests.'
            profiles = $profileMap
        }
    }
    $document = @{ mappings = $maps }
    function Save-Ledger { $document | ConvertTo-Json -Depth 12 | Set-Content -LiteralPath $ledger }
    Save-Ledger
    $complete = @(& $fixtureTool -FailOnUnresolved)
    if (@($complete | Where-Object { $_.Status -notin @('Mapped', 'Deferred') }).Count) { throw 'Reviewed fixture should complete.' }
    $fixtureSpec = Join-Path $fixture 'openApiDocs_KiotaCompat\beta\Widget.yml'
    $specText = [IO.File]::ReadAllText($fixtureSpec).Replace("`r`n", "`n")
    [IO.File]::WriteAllText($fixtureSpec, $specText.Replace("`n", "`r`n"))
    & $fixtureTool -FailOnUnresolved | Out-Null
    [IO.File]::WriteAllText($fixtureSpec, $specText)
    & $fixtureTool -FailOnUnresolved | Out-Null
    $opMap = $maps | Where-Object classification -eq 'OperationIdSuppression'
    # Missing sourcePath retains the old module-local ledger identity.
    $savedSource = $opMap.sourcePath
    $opMap.Remove('sourcePath'); Save-Ledger
    & $fixtureTool -FailOnUnresolved | Out-Null
    $opMap.sourcePath = $savedSource
    $opMap.reviewed = $false; Save-Ledger
    Assert-Fails { & $fixtureTool -FailOnUnresolved } 'reviewed: true'
    $opMap.reviewed = $true
    $savedHash = $opMap.sourceSha256
    $opMap.Remove('sourceSha256'); Save-Ledger
    Assert-Fails { & $fixtureTool -FailOnUnresolved } 'sourceSha256'
    $opMap.sourceSha256 = $savedHash
    $savedClassification = $opMap.classification
    $opMap.Remove('classification'); Save-Ledger
    Assert-Fails { & $fixtureTool -FailOnUnresolved } 'requires classification'
    $opMap.classification = $savedClassification
    @($opMap.profiles.beta.operations)[0].operationId = 'Wrong'; Save-Ledger
    Assert-Fails { & $fixtureTool } 'operationId missing or changed'
    @($opMap.profiles.beta.operations)[0].operationId = 'Widgets_Delete'
    $opMap.profiles.beta.specSha256 = 'stale'; Save-Ledger
    Assert-Fails { & $fixtureTool } 'specification fingerprint changed'
    $opMap.profiles.beta.specSha256 = Get-FixtureSpecHash (Join-Path $fixture 'openApiDocs_KiotaCompat\beta\Widget.yml')
    $savedOps = $opMap.profiles.beta.operations
    $opMap.profiles.beta.operations = @(); $opMap.profiles.beta.absenceExpected = $true; Save-Ledger
    Assert-Fails { & $fixtureTool } 'exactly the operation-ID selector'
    $opMap.profiles.beta.operations = $savedOps; $opMap.profiles.beta.absenceExpected = $false
    $opMap.profiles.beta.operations = @($savedOps) + @($savedOps); Save-Ledger
    Assert-Fails { & $fixtureTool } 'duplicate operation mappings'
    $opMap.profiles.beta.operations = $savedOps
    $betaMap = $maps | Where-Object sourcePath -eq 'src\Widget\beta\readme.md'
    $betaMap.profiles.'v1.0'.notApplicable = $false; Save-Ledger
    Assert-Fails { & $fixtureTool } 'notApplicable'
    $betaMap.profiles.'v1.0'.notApplicable = $true
    $noEffect = $maps | Where-Object implementation -eq 'NoEffect'
    $noEffect.implementation = 'StructuralNaming'; Save-Ledger
    Assert-Fails { & $fixtureTool } 'NoEffect disposition'
    $noEffect.implementation = 'NoEffect'
    $noEffect.profiles.beta.absentOperations = @(@{ method = 'DELETE'; path = '/widgets/{widget-id}'; operationId = 'Widgets_Delete' }); Save-Ledger
    Assert-Fails { & $fixtureTool } 'absent operation is present'
    $noEffect.profiles.beta.Remove('absentOperations')
    $document.mappings += $opMap; Save-Ledger
    Assert-Fails { & $fixtureTool } 'Duplicate directive mapping'
    $document.mappings = $maps; Save-Ledger
    Add-Content (Join-Path $fixture 'src\Widget\Widget.md') "`n"
    & $fixtureTool -FailOnUnresolved | Out-Null
    $source = Join-Path $fixture 'src\Widget\Widget.md'
    (Get-Content $source -Raw).Replace('^WIDGETS_DELETE$', '^WIDGETS_GET$') | Set-Content $source
    Assert-Fails { & $fixtureTool } 'source fingerprint changed'
    (Get-Content $source -Raw).Replace('^WIDGETS_GET$', '^WIDGETS_DELETE$') | Set-Content $source
    (Get-Content $source -Raw).Replace('^WIDGETS_DELETE$', '[') | Set-Content $source
    Assert-Fails { & $fixtureTool } 'Operation-ID expression requires manual review'
    (Get-Content $source -Raw).Replace('operation: [', 'operation: ^WIDGETS_DELETE$') | Set-Content $source
    Remove-Item -LiteralPath (Join-Path $fixture 'openApiDocs_KiotaCompat\beta\Widget.yml')
    Assert-Fails { & $fixtureTool } 'specification missing'
} finally {
    if (Test-Path -LiteralPath $fixture) { Remove-Item -LiteralPath $fixture -Recurse -Force }
}
& (Join-Path $PSScriptRoot 'Test-WrapperDirectiveSourceTranslation.ps1')
$after = & git -C $repo status --porcelain
if (($before -join "`n") -ne ($after -join "`n")) { throw 'Read-only inventory changed the worktree.' }
Write-Host 'PASS: configured roster, effective sources, classifications, reviewed mappings, strict completion and current Compliance absences.'
