<#
.SYNOPSIS
Validates reviewed directive mappings and the completion gate using isolated fixtures.

.DESCRIPTION
Copies the inventory tool and preserved Compliance pilot inputs into a temporary repository
layout. Exact fixture specifications exercise valid and stale evidence independently of live
API pruning. Also checks read-only live deferred and empty-module inventory.
This is not a claim that every live module ledger passes; audit those modules separately.
#>
[CmdletBinding()]
param()

$ErrorActionPreference = 'Stop'
$repoRoot = (Resolve-Path (Join-Path $PSScriptRoot '..')).Path
$tool = Join-Path $PSScriptRoot 'Get-WrapperDirectiveMigrationInventory.ps1'
$mapping = Join-Path $repoRoot 'src\Compliance\wrapper\Compliance_directiveMigrationMap.json'
$before = & git -c core.longpaths=true -C $repoRoot status --porcelain
$fixtureRoot = Join-Path ([IO.Path]::GetTempPath()) "directive-inventory-$([guid]::NewGuid())"
$fixtureTool = Join-Path $fixtureRoot 'tools\Get-WrapperDirectiveMigrationInventory.ps1'

function Write-FixtureFile {
    param([string]$Path, [string]$Content)
    $fullPath = Join-Path $fixtureRoot $Path
    $null = New-Item (Split-Path $fullPath -Parent) -ItemType Directory -Force
    Set-Content $fullPath $Content
}

function Assert-Failure {
    param([scriptblock]$Action, [string]$Pattern)
    $failed = $false
    try {
        & $Action | Out-Null
    }
    catch {
        if ($_.Exception.Message -notmatch $Pattern) { throw }
        $failed = $true
    }
    if (-not $failed) { throw "Expected failure matching '$Pattern'." }
}

try {
    $null = New-Item (Split-Path $fixtureTool -Parent) -ItemType Directory -Force
    Copy-Item $tool $fixtureTool
    Write-FixtureFile 'src\Compliance\Compliance.md' (Get-Content (Join-Path $repoRoot 'src\Compliance\Compliance.md') -Raw)
    Write-FixtureFile 'src\Compliance\wrapper\Compliance_directiveMigrationMap.json' (Get-Content $mapping -Raw)
    Write-FixtureFile 'src\Compliance\wrapper\Compliance_cmdletConfigurations.cs' (Get-Content (Join-Path $repoRoot 'src\Compliance\wrapper\Compliance_cmdletConfigurations.cs') -Raw)
    Write-FixtureFile 'openApiDocs_KiotaCompat\beta\Compliance.yml' @'
openapi: 3.0.4
paths:
  '/compliance/ediscovery/cases/{case-id}/noncustodialDataSources/{noncustodialDataSource-id}/dataSource':
    get:
      operationId: compliance.ediscovery.cases.noncustodialDataSources.GetDataSource
    patch:
      operationId: compliance.ediscovery.cases.noncustodialDataSources.UpdateDataSource
    delete:
      operationId: compliance.ediscovery.cases.noncustodialDataSources.DeleteDataSource
'@
    $compliance = @(& $fixtureTool -Module Compliance -FailOnUnresolved)
    if ($compliance.Count -ne 2 -or @($compliance | Where-Object Status -ne 'Mapped').Count -ne 0) {
        throw 'Both preserved Compliance pilot directives must be Mapped with valid evidence.'
    }
    $suppression = $compliance | Where-Object DirectiveIndex -eq 1
    if (@($suppression.BetaOperations | Where-Object { $_ -cmatch '^PATCH ' }).Count -ne 1 -or
        @($suppression.BetaOperations | Where-Object { $_ -cmatch '^DELETE ' }).Count -ne 1 -or
        @($suppression.V1Operations).Count -ne 0) {
        throw 'Compliance directive 1 must map only the beta PATCH and DELETE.'
    }
    $rename = $compliance | Where-Object DirectiveIndex -eq 2
    if ($rename.Implementation -ne 'StructuralNaming' -or
        @($rename.BetaOperations | Where-Object { $_ -cmatch '^GET ' }).Count -ne 1) {
        throw 'Compliance directive 2 must map to one structurally named beta GET.'
    }
    $stalePilot = Get-Content $mapping -Raw | ConvertFrom-Json
    $stalePilot.mappings[0].profiles.beta.operations[0].operationId = 'stale_UpdateDataSource'
    $stalePilotPath = Join-Path $fixtureRoot 'stale-compliance.json'
    $stalePilot | ConvertTo-Json -Depth 10 | Set-Content $stalePilotPath
    Assert-Failure { & $fixtureTool -Module Compliance -MappingPath $stalePilotPath } 'operationId changed'

    Write-FixtureFile 'src\Suppression\Suppression.md' @'
``` yaml
directive:
  - remove-path-by-operation: ^fixture\_(Update|Delete)Item$
```
'@
    $spec = @'
openapi: 3.0.4
paths:
  '/items/{item-id}':
    patch:
      operationId: fixture_UpdateItem
    delete:
      operationId: fixture_DeleteItem
    get:
      operationId: fixture_GetItem
'@
    Write-FixtureFile 'openApiDocs_KiotaCompat\v1.0\Suppression.yml' $spec
    Write-FixtureFile 'openApiDocs_KiotaCompat\beta\Suppression.yml' ($spec.Replace('/items/', '/beta/items/'))
    $candidate = @(& $fixtureTool -Module Suppression)
    if ($candidate.Count -ne 1 -or $candidate[0].Status -ne 'Resolved' -or
        $candidate[0].Implementation -ne 'Candidate' -or
        $candidate[0].V1Operations.Count -ne 2 -or $candidate[0].BetaOperations.Count -ne 2) {
        throw 'Operation-ID regex matches, including JavaScript identity escapes, must remain candidates.'
    }
    Assert-Failure { & $fixtureTool -Module Suppression -FailOnUnresolved } 'lack reviewed mappings'

    $reviewed = @'
{
  "mappings": [{
    "module": "Suppression",
    "directiveIndex": 1,
    "classification": "OperationIdSuppression",
    "sourceContains": "remove-path-by-operation: ^fixture\\_(Update|Delete)Item$",
    "implementation": "CmdletConfigurator",
    "notes": "Reviewed suppression of item PATCH and DELETE, not GET.",
    "profiles": {
      "v1.0": {
        "absenceExpected": false,
        "operations": [
          { "method": "PATCH", "path": "/items/{item-id}", "operationId": "fixture_UpdateItem" },
          { "method": "DELETE", "path": "/items/{item-id}", "operationId": "fixture_DeleteItem" }
        ]
      },
      "beta": {
        "absenceExpected": false,
        "operations": [
          { "method": "PATCH", "path": "/beta/items/{item-id}", "operationId": "fixture_UpdateItem" },
          { "method": "DELETE", "path": "/beta/items/{item-id}", "operationId": "fixture_DeleteItem" }
        ]
      }
    }
  }]
}
'@
    $testMapping = Join-Path $fixtureRoot 'reviewed.json'
    Set-Content $testMapping $reviewed
    $mapped = @(& $fixtureTool -Module Suppression -MappingPath $testMapping -FailOnUnresolved)
    if ($mapped.Count -ne 1 -or $mapped[0].Status -ne 'Mapped' -or
        $mapped[0].Implementation -ne 'CmdletConfigurator' -or
        $mapped[0].ExistingCoverage -ne 'ReviewedConfiguration' -or
        $mapped[0].V1Operations.Count -ne 2 -or $mapped[0].BetaOperations.Count -ne 2) {
        throw 'Reviewed operation-ID evidence must use the shared mapping path, not remain unused or Candidate.'
    }

    $cases = @(
        @{ Mutate = { param($d) $d.mappings[0].classification = 'SubjectRename' }; Pattern = 'classification changed' }
        @{ Mutate = { param($d) $d.mappings[0].PSObject.Properties.Remove('classification') }; Pattern = 'classification changed' }
        @{ Mutate = { param($d) $d.mappings[0].sourceContains = 'stale directive text' }; Pattern = 'source directive no longer contains' }
        @{ Mutate = { param($d) $d.mappings[0].sourceContains = '' }; Pattern = 'sourceContains evidence is required' }
        @{ Mutate = { param($d) $d.mappings[0].implementation = '' }; Pattern = 'implementation disposition is required' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.PSObject.Properties.Remove('beta') }; Pattern = 'beta mapping declaration' }
        @{ Mutate = { param($d) $d.mappings[0].profiles | Add-Member 'v2.0' ([pscustomobject]@{}) }; Pattern = 'unsupported profile' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.beta.operations[0].method = 'PUT' }; Pattern = 'matched 0 operations' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.beta.operations[0].path = '/Items/{item-id}' }; Pattern = 'matched 0 operations' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.beta.operations[0].path = '/items/{item-id}' }; Pattern = 'matched 0 operations' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.beta.operations[0].operationId = 'fixture_updateItem' }; Pattern = 'operationId changed' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.beta.operations[0].PSObject.Properties.Remove('operationId') }; Pattern = 'operationId evidence is required' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.beta.operations = @($d.mappings[0].profiles.beta.operations[0]) }; Pattern = 'cover exactly' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.beta.operations = @() }; Pattern = 'not marked absenceExpected' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.beta.PSObject.Properties.Remove('operations') }; Pattern = 'operations must be an explicit array' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.beta.absenceExpected = 'false' }; Pattern = 'absenceExpected must be an explicit boolean' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.beta.absenceExpected = $true }; Pattern = 'declares operations and absenceExpected' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.beta.operations = @(); $d.mappings[0].profiles.beta.absenceExpected = $true }; Pattern = 'cover exactly' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.beta.operations[0].method = 'GET'; $d.mappings[0].profiles.beta.operations[0].operationId = 'fixture_GetItem' }; Pattern = 'cover exactly' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.beta.operations += $d.mappings[0].profiles.beta.operations[0] }; Pattern = 'duplicate operation' }
        @{ Mutate = { param($d) $d.mappings += $d.mappings[0] }; Pattern = 'Duplicate directive mapping' }
        @{ Mutate = { param($d) $d.mappings[0].directiveIndex = 99 }; Pattern = 'entries do not match a directive' }
    )
    foreach ($case in $cases) {
        $document = $reviewed | ConvertFrom-Json
        & $case.Mutate $document
        $document | ConvertTo-Json -Depth 10 | Set-Content $testMapping
        Assert-Failure { & $fixtureTool -Module Suppression -MappingPath $testMapping } $case.Pattern
    }

    $exclusion = $reviewed | ConvertFrom-Json
    $exclusion.mappings[0].profiles.beta = [pscustomobject]@{
        excluded = $true
        operations = @()
        notes = 'Missing compatible spec; no API-operation absence assertion.'
    }
    $exclusion | ConvertTo-Json -Depth 10 | Set-Content $testMapping
    Assert-Failure { & $fixtureTool -Module Suppression -MappingPath $testMapping } 'compatible spec exists'
    Remove-Item (Join-Path $fixtureRoot 'openApiDocs_KiotaCompat\beta\Suppression.yml')
    $excluded = @(& $fixtureTool -Module Suppression -MappingPath $testMapping -FailOnUnresolved)
    if ($excluded[0].Status -ne 'Mapped' -or $excluded[0].BetaOperations.Count -ne 0 -or
        $excluded[0].Notes -notmatch 'beta excluded: Missing compatible spec') {
        throw 'Explicit missing-spec exclusion must pass without asserting API-operation absence and remain visible in inventory.'
    }
    $exclusionCases = @(
        @{ Mutate = { param($d) $d.mappings[0].profiles.beta.operations = @($d.mappings[0].profiles.'v1.0'.operations[0]) }; Pattern = 'must not declare operations' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.beta | Add-Member absenceExpected $true }; Pattern = 'must not declare absenceExpected' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.beta | Add-Member absenceExpected $false }; Pattern = 'must not declare absenceExpected' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.beta | Add-Member absenceExpected $null }; Pattern = 'must not declare absenceExpected' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.beta.notes = '' }; Pattern = 'exclusion notes are required' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.beta.excluded = 'true' }; Pattern = 'excluded must be a boolean' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.beta.excluded = $null }; Pattern = 'excluded must be a boolean' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.beta.operations = $null }; Pattern = 'operations must be an explicit array' }
    )
    $exclusionJson = $exclusion | ConvertTo-Json -Depth 10
    foreach ($case in $exclusionCases) {
        $document = $exclusionJson | ConvertFrom-Json
        & $case.Mutate $document
        $document | ConvertTo-Json -Depth 10 | Set-Content $testMapping
        Assert-Failure { & $fixtureTool -Module Suppression -MappingPath $testMapping } $case.Pattern
    }
    Write-FixtureFile 'openApiDocs_KiotaCompat\beta\Suppression.yml' ($spec.Replace('/items/', '/beta/items/'))

    $document = $reviewed | ConvertFrom-Json
    $document.mappings[0].profiles.'v1.0'.operations = @()
    $document.mappings[0].profiles.'v1.0'.absenceExpected = $true
    $document | ConvertTo-Json -Depth 10 | Set-Content $testMapping
    Write-FixtureFile 'openApiDocs_KiotaCompat\v1.0\Suppression.yml' "openapi: 3.0.4`npaths: {}"
    $absent = @(& $fixtureTool -Module Suppression -MappingPath $testMapping -FailOnUnresolved)
    if ($absent[0].Status -ne 'Mapped' -or $absent[0].V1Operations.Count -ne 0) {
        throw 'Reviewed absent-profile evidence must pass when no operations match that profile.'
    }
    Write-FixtureFile 'openApiDocs_KiotaCompat\beta\Suppression.yml' "openapi: 3.0.4`npaths: {}"
    Assert-Failure { & $fixtureTool -Module Suppression -MappingPath $testMapping } 'matched 0 operations'
    $noMatches = @(& $fixtureTool -Module Suppression)
    if ($noMatches[0].Status -ne 'Unresolved') { throw 'An unmatched regex alone is not an absence audit.' }
    Assert-Failure { & $fixtureTool -Module Suppression -FailOnUnresolved } 'lack reviewed mappings'
    $document.mappings[0].profiles.beta.operations = @()
    $document.mappings[0].profiles.beta.absenceExpected = $true
    $document | ConvertTo-Json -Depth 10 | Set-Content $testMapping
    $absent = @(& $fixtureTool -Module Suppression -MappingPath $testMapping -FailOnUnresolved)
    if ($absent[0].Status -ne 'Mapped' -or $absent[0].BetaOperations.Count -ne 0) {
        throw 'Reviewed absence in both profiles must not require invented operations or configuration.'
    }
    Write-FixtureFile 'src\Suppression\Suppression.md' "directive:`n  - remove-path-by-operation: ["
    $invalidRegex = @(& $fixtureTool -Module Suppression)
    if ($invalidRegex[0].Status -ne 'Unresolved' -or $invalidRegex[0].Notes -notmatch 'requires manual review') {
        throw 'Unsupported regex syntax must remain unresolved with a visible review reason.'
    }
    Assert-Failure { & $fixtureTool -Module Suppression -MappingPath $testMapping } 'regex cannot be validated'

    Write-FixtureFile 'src\QuotedFunction\QuotedFunction.md' @'
directive:
  - where:
      subject: FixtureResolve
    set:
      subject: ReviewedFixtureResolve
'@
    Write-FixtureFile 'openApiDocs_KiotaCompat\v1.0\QuotedFunction.yml' @'
openapi: 3.0.4
paths:
  '/fixtures/{fixture-id}/resolve(Input=''{Input}'')':
    get:
      operationId: fixture_Resolve
'@
    Write-FixtureFile 'openApiDocs_KiotaCompat\beta\QuotedFunction.yml' @'
openapi: 3.0.4
paths:
  "/fixtures/{fixture-id}/resolve(Input='{Input}')":
    get:
      operationId: fixture_Resolve
'@
    $functionMapping = [pscustomobject]@{
        module = 'QuotedFunction'
        directiveIndex = 1
        classification = 'SubjectRename'
        sourceContains = 'subject: ReviewedFixtureResolve'
        implementation = 'CmdletConfigurator'
        profiles = [pscustomobject]@{}
    }
    foreach ($profile in @('v1.0', 'beta')) {
        $functionMapping.profiles | Add-Member $profile ([pscustomobject]@{
            absenceExpected = $false
            operations = @([pscustomobject]@{
                method = 'GET'
                path = "/fixtures/{fixture-id}/resolve(Input='{Input}')"
                operationId = 'fixture_Resolve'
            })
        })
    }
    @{ mappings = @($functionMapping) } | ConvertTo-Json -Depth 10 | Set-Content $testMapping
    $quoted = @(& $fixtureTool -Module QuotedFunction -MappingPath $testMapping -FailOnUnresolved)
    if ($quoted[0].Status -ne 'Mapped' -or
        $quoted[0].V1Operations[0] -cne "GET /fixtures/{fixture-id}/resolve(Input='{Input}') [fixture_Resolve]" -or
        $quoted[0].BetaOperations[0] -cne $quoted[0].V1Operations[0]) {
        throw 'Quoted YAML function keys must resolve exact unescaped method/path/operation-ID evidence.'
    }

    Write-FixtureFile 'src\LegacyBridge\LegacyBridge.md' @'
directive:
  - remove-path-by-operation: ^legacy_.*Widget$
'@
    $legacySpec = @'
openapi: 3.0.4
paths:
  '/widgets/{old-id}':
    get:
      operationId: legacy_GetWidget
    patch:
      operationId: legacy_UpdateWidget
  '/retired/{old-id}':
    delete:
      operationId: legacy_DeleteWidget
  /unselected:
    get:
      operationId: unrelated_GetOther
'@
    $currentSpec = @'
openapi: 3.0.4
paths:
  '/widgets/{widget-id}':
    get:
      operationId: widgets.GetWidget
    patch:
      operationId: widgets.UpdateWidget
  /unselected:
    get:
      operationId: widgets.GetOther
  '/different/{widget-id}':
    get:
      operationId: widgets.GetDifferent
'@
    Write-FixtureFile 'openApiDocs\v1.0\LegacyBridge.yml' $legacySpec
    Write-FixtureFile 'openApiDocs_KiotaCompat\v1.0\LegacyBridge.yml' $currentSpec
    $legacyMapping = @'
{
  "mappings": [{
    "module": "LegacyBridge",
    "directiveIndex": 1,
    "classification": "OperationIdSuppression",
    "sourceContains": "remove-path-by-operation: ^legacy_.*Widget$",
    "implementation": "CmdletConfigurator",
    "profiles": {
      "v1.0": {
        "operationIdSource": "Legacy",
        "notes": "Reviewed exact old/new IDs and method/path bridges; one old operation was pruned.",
        "absenceExpected": false,
        "operations": [
          { "method": "GET", "path": "/widgets/{widget-id}", "operationId": "widgets.GetWidget", "legacyPath": "/widgets/{old-id}", "legacyOperationId": "legacy_GetWidget" },
          { "method": "PATCH", "path": "/widgets/{widget-id}", "operationId": "widgets.UpdateWidget", "legacyPath": "/widgets/{old-id}", "legacyOperationId": "legacy_UpdateWidget" }
        ],
        "removedLegacyOperations": [
          { "method": "DELETE", "path": "/retired/{old-id}", "operationId": "legacy_DeleteWidget", "notes": "Actual old route has no compatible method/normalized-path counterpart." }
        ]
      },
      "beta": {
        "excluded": true,
        "operations": [],
        "notes": "No compatible beta spec; not an API-absence claim."
      }
    }
  }]
}
'@
    Set-Content $testMapping $legacyMapping
    $bridged = @(& $fixtureTool -Module LegacyBridge -MappingPath $testMapping -FailOnUnresolved)
    if ($bridged[0].Status -ne 'Mapped' -or $bridged[0].V1Operations.Count -ne 2 -or
        $bridged[0].BetaOperations.Count -ne 0 -or
        $bridged[0].Notes -notmatch 'reviewed legacy operation-ID translation') {
        throw 'Reviewed complete legacy-ID bridges must map surviving compatible operations and retain exclusion notes.'
    }
    $literal = @(& $fixtureTool -Module LegacyBridge)
    if ($literal[0].Status -ne 'Unresolved') {
        throw 'Legacy specs must never cause automatic compatible regex resolution or inferred successors.'
    }
    $bridgeCases = @(
        @{ Mutate = { param($d) $d.mappings[0].profiles.'v1.0'.PSObject.Properties.Remove('operationIdSource') }; Pattern = 'requires explicit operationIdSource' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.'v1.0'.operationIdSource = 'legacy' }; Pattern = "operationIdSource must be 'Legacy'" }
        @{ Mutate = { param($d) $d.mappings[0].profiles.'v1.0'.notes = '' }; Pattern = 'legacy translation notes are required' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.'v1.0'.absenceExpected = $true }; Pattern = 'requires absenceExpected: false' }
        @{ Mutate = { param($d) $d.mappings[0].classification = 'SubjectRename' }; Pattern = 'classification changed|only supported for OperationIdSuppression' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.'v1.0'.operations = @($d.mappings[0].profiles.'v1.0'.operations[0]) }; Pattern = 'complete original regex match set' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.'v1.0'.PSObject.Properties.Remove('removedLegacyOperations') }; Pattern = 'complete original regex match set' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.'v1.0'.operations[0].legacyOperationId = 'legacy_getWidget' }; Pattern = 'not an exact original regex match' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.'v1.0'.operations[0].legacyPath = '/Widgets/{old-id}' }; Pattern = 'not an exact original regex match' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.'v1.0'.operations[0].PSObject.Properties.Remove('legacyOperationId') }; Pattern = 'legacyPath and legacyOperationId evidence are required' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.'v1.0'.operations[0].PSObject.Properties.Remove('legacyPath') }; Pattern = 'legacyPath and legacyOperationId evidence are required' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.'v1.0'.operations[0].method = 'POST' }; Pattern = 'matched 0 operations' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.'v1.0'.operations[0].path = '/different/{widget-id}'; $d.mappings[0].profiles.'v1.0'.operations[0].operationId = 'widgets.GetDifferent' }; Pattern = 'method/normalized path must be identical' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.'v1.0'.operations[0].legacyPath = '/unselected'; $d.mappings[0].profiles.'v1.0'.operations[0].legacyOperationId = 'unrelated_GetOther' }; Pattern = 'not an exact original regex match' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.'v1.0'.operations[0].operationId = 'stale.GetWidget' }; Pattern = 'operationId changed' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.'v1.0'.operations += $d.mappings[0].profiles.'v1.0'.operations[0] }; Pattern = 'duplicate legacy evidence' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.'v1.0'.removedLegacyOperations[0].notes = '' }; Pattern = 'requires review notes' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.'v1.0'.removedLegacyOperations[0].operationId = 'unrelated_GetOther' }; Pattern = 'not an exact original regex match' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.'v1.0'.removedLegacyOperations = $null }; Pattern = 'removedLegacyOperations must be an explicit array' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.'v1.0'.removedLegacyOperations += [pscustomobject]@{method='GET';path='/widgets/{old-id}';operationId='legacy_GetWidget';notes='False removal claim'} }; Pattern = 'still has 1 compatible' }
        @{ Mutate = { param($d) $d.mappings[0].profiles.beta | Add-Member operationIdSource 'Legacy' }; Pattern = 'cannot combine exclusion with legacy translation' }
    )
    foreach ($case in $bridgeCases) {
        $document = $legacyMapping | ConvertFrom-Json
        & $case.Mutate $document
        $document | ConvertTo-Json -Depth 10 | Set-Content $testMapping
        Assert-Failure { & $fixtureTool -Module LegacyBridge -MappingPath $testMapping } $case.Pattern
    }
    Set-Content $testMapping $legacyMapping
    Write-FixtureFile 'openApiDocs\v1.0\LegacyBridge.yml' ($legacySpec -replace 'legacy_', 'changed_')
    Assert-Failure { & $fixtureTool -Module LegacyBridge -MappingPath $testMapping } 'matches no legacy operations'
    Write-FixtureFile 'openApiDocs\v1.0\LegacyBridge.yml' ($legacySpec + @'

  '/widgets/{ambiguous-id}':
    get:
      operationId: unrelated_Ambiguous
'@)
    Assert-Failure { & $fixtureTool -Module LegacyBridge -MappingPath $testMapping } 'legacy method/normalized path .* matched 2 operations'
    Write-FixtureFile 'openApiDocs\v1.0\LegacyBridge.yml' $legacySpec
    Write-FixtureFile 'openApiDocs_KiotaCompat\v1.0\LegacyBridge.yml' ($currentSpec + @'

  '/widgets/{ambiguous-id}':
    get:
      operationId: widgets.Ambiguous
'@)
    Assert-Failure { & $fixtureTool -Module LegacyBridge -MappingPath $testMapping } 'compatible method/normalized path .* matched 2 operations'
    Write-FixtureFile 'openApiDocs_KiotaCompat\v1.0\LegacyBridge.yml' $currentSpec
    Remove-Item (Join-Path $fixtureRoot 'openApiDocs\v1.0\LegacyBridge.yml')
    Assert-Failure { & $fixtureTool -Module LegacyBridge -MappingPath $testMapping } 'requires both same-module/profile'
    Write-FixtureFile 'openApiDocs\v1.0\LegacyBridge.yml' $legacySpec
    Remove-Item (Join-Path $fixtureRoot 'openApiDocs_KiotaCompat\v1.0\LegacyBridge.yml')
    Assert-Failure { & $fixtureTool -Module LegacyBridge -MappingPath $testMapping } 'requires both same-module/profile'
    Write-FixtureFile 'openApiDocs_KiotaCompat\v1.0\LegacyBridge.yml' "openapi: 3.0.4`npaths: {}"
    $document = $legacyMapping | ConvertFrom-Json
    foreach ($operation in $document.mappings[0].profiles.'v1.0'.operations) {
        $document.mappings[0].profiles.'v1.0'.removedLegacyOperations += [pscustomobject]@{
            method = $operation.method
            path = $operation.legacyPath
            operationId = $operation.legacyOperationId
            notes = 'Reviewed old operation has no current compatible method/path.'
        }
    }
    $document.mappings[0].profiles.'v1.0'.operations = @()
    $document | ConvertTo-Json -Depth 10 | Set-Content $testMapping
    $removedOnly = @(& $fixtureTool -Module LegacyBridge -MappingPath $testMapping -FailOnUnresolved)
    if ($removedOnly[0].Status -ne 'Mapped' -or $removedOnly[0].V1Operations.Count -ne 0) {
        throw 'An entirely pruned, fully evidenced legacy match set needs no invented compatible operations.'
    }
    foreach ($case in @(
        @{ OldPath = '/widgets/{old-id}/microsoft.graph.refresh'; NewPath = '/widgets/{widget-id}/refresh'; Method = 'POST' }
        @{ OldPath = '/widgets/{old-id}/delta'; NewPath = '/widgets/{widget-id}/delta()'; Method = 'GET' }
    )) {
        Write-FixtureFile 'openApiDocs\v1.0\LegacyBridge.yml' ($legacySpec + "`n  '$($case.OldPath)':`n    $($case.Method.ToLowerInvariant()):`n      operationId: legacy_ConvertedWidget")
        Write-FixtureFile 'openApiDocs_KiotaCompat\v1.0\LegacyBridge.yml' ($currentSpec + "`n  '$($case.NewPath)':`n    $($case.Method.ToLowerInvariant()):`n      operationId: widgets.Converted")
        $document = $legacyMapping | ConvertFrom-Json
        $document.mappings[0].profiles.'v1.0'.removedLegacyOperations += [pscustomobject]@{
            method = $case.Method
            path = $case.OldPath
            operationId = 'legacy_ConvertedWidget'
            notes = 'False removal claim must not hide a known converter path change.'
        }
        $document | ConvertTo-Json -Depth 10 | Set-Content $testMapping
        Assert-Failure { & $fixtureTool -Module LegacyBridge -MappingPath $testMapping } 'cannot verify removal.*reviewed path translation'
    }

    $finalCases = @(
        @{ Old = '/widgets/{old-id}/microsoft.graph.refresh'; New = '/widgets/{widget-id}/refresh'; Method = 'POST'; OldKind = 'action'; NewKind = 'action' }
        @{ Old = '/widgets/{old-id}/microsoft.graph.delta'; New = '/widgets/{widget-id}/delta()'; Method = 'GET'; OldKind = 'function'; NewKind = 'function' }
        @{ Old = '/widgets/{old-id}/microsoft.graph.delta()'; New = '/widgets/{widget-id}/delta'; Method = 'GET'; OldKind = 'function'; NewKind = 'function' }
        @{ Old = '/widgets/{old-id}/delta'; New = '/widgets/{widget-id}/delta()'; Method = 'GET'; OldKind = 'function'; NewKind = 'function' }
        @{ Old = '/widgets/{old-id}/delta()'; New = '/widgets/{widget-id}/delta'; Method = 'GET'; OldKind = 'function'; NewKind = 'function' }
        @{ Old = "/widgets/{old-id}/microsoft.graph.resolve(Input='{old-input}')"; New = "/widgets/{widget-id}/resolve(Input='{input}')"; Method = 'GET'; OldKind = 'function'; NewKind = 'function' }
        @{ Old = '/widgets/{old-id}/microsoft.graph.refresh'; New = '/widgets/{widget-id}/refresh'; Method = 'POST'; OldKind = ''; NewKind = 'action'; Error = 'both actual operations must declare the same action/function kind' }
        @{ Old = '/widgets/{old-id}/microsoft.graph.refresh'; New = '/widgets/{widget-id}/refresh'; Method = 'POST'; OldKind = 'action'; NewKind = ''; Error = 'both actual operations must declare the same action/function kind' }
        @{ Old = '/widgets/{old-id}/microsoft.graph.refresh'; New = '/widgets/{widget-id}/refresh'; Method = 'POST'; OldKind = 'action'; NewKind = 'function'; Error = 'both actual operations must declare the same action/function kind' }
        @{ Old = '/widgets/{old-id}/microsoft.graph.user'; New = '/widgets/{widget-id}/user'; Method = 'GET'; OldKind = 'operation'; NewKind = 'operation'; Error = 'both actual operations must declare the same action/function kind' }
        @{ Old = '/widgets/{old-id}/microsoft.graph.refresh'; New = '/widgets/{widget-id}/refresh'; Method = 'GET'; OldKind = 'action'; NewKind = 'action'; Error = 'action translation requires HTTP POST' }
        @{ Old = '/widgets/{old-id}/microsoft.graph.delta'; New = '/widgets/{widget-id}/delta()'; Method = 'POST'; OldKind = 'function'; NewKind = 'function'; Error = 'function translation requires HTTP GET' }
        @{ Old = '/widgets/{old-id}/microsoft.graph.refresh'; New = '/other/{widget-id}/refresh'; Method = 'POST'; OldKind = 'action'; NewKind = 'action'; Error = 'matched 0 operations|exact unique compatible counterpart' }
        @{ Old = '/widgets/{old-id}/microsoft.graph.refresh'; New = '/widgets/{widget-id}/renamed'; Method = 'POST'; OldKind = 'action'; NewKind = 'action'; Error = 'matched 0 operations' }
        @{ Old = '/widgets/{old-id}/microsoft.graph.refresh'; New = '/widgets/{widget-id}/refresh()'; Method = 'POST'; OldKind = 'action'; NewKind = 'action'; Error = 'only exact final' }
        @{ Old = '/widgets/{old-id}/resolve'; New = '/widgets/{widget-id}/resolve()'; Method = 'GET'; OldKind = 'function'; NewKind = 'function'; Error = 'only exact final' }
        @{ Old = "/widgets/{old-id}/microsoft.graph.delta(token='{token}')"; New = '/widgets/{widget-id}/delta()'; Method = 'GET'; OldKind = 'function'; NewKind = 'function'; Error = 'matched 0 operations' }
        @{ Old = '/widgets/{old-id}/microsoft.graph.group/refresh'; New = '/widgets/{widget-id}/group/refresh'; Method = 'POST'; OldKind = 'action'; NewKind = 'action'; Error = 'matched 0 operations' }
    )
    foreach ($case in $finalCases) {
        $oldMetadata = if ($case.OldKind) { "`n      x-ms-docs-operation-type: $($case.OldKind)" } else { '' }
        $newMetadata = if ($case.NewKind) { "`n      x-ms-docs-operation-type: $($case.NewKind)" } else { '' }
        # Cover operation metadata both before and after operationId.
        Write-FixtureFile 'openApiDocs\v1.0\LegacyBridge.yml' ("openapi: 3.0.4`npaths:`n  `"$($case.Old)`":`n    $($case.Method.ToLowerInvariant()):$oldMetadata`n      operationId: legacy_ConvertedWidget")
        Write-FixtureFile 'openApiDocs_KiotaCompat\v1.0\LegacyBridge.yml' ("openapi: 3.0.4`npaths:`n  `"$($case.New)`":`n    $($case.Method.ToLowerInvariant()):`n      operationId: widgets.Converted$newMetadata")
        $document = $legacyMapping | ConvertFrom-Json
        $document.mappings[0].profiles.'v1.0'.removedLegacyOperations = @()
        $document.mappings[0].profiles.'v1.0'.operations = @([pscustomobject]@{
            method = $case.Method
            path = $case.New
            operationId = 'widgets.Converted'
            legacyPath = $case.Old
            legacyOperationId = 'legacy_ConvertedWidget'
            legacyPathTranslation = 'UnqualifyFinalOperation'
        })
        $document | ConvertTo-Json -Depth 10 | Set-Content $testMapping
        if ($case.Error) {
            Assert-Failure { & $fixtureTool -Module LegacyBridge -MappingPath $testMapping } $case.Error
        }
        else {
            $translated = @(& $fixtureTool -Module LegacyBridge -MappingPath $testMapping -FailOnUnresolved)
            if ($translated[0].Status -ne 'Mapped' -or $translated[0].V1Operations.Count -ne 1) {
                throw 'Explicit kind-guarded final-operation translation must preserve the exact current operation.'
            }
            $document.mappings[0].profiles.'v1.0'.operations[0].PSObject.Properties.Remove('legacyPathTranslation')
            $document | ConvertTo-Json -Depth 10 | Set-Content $testMapping
            Assert-Failure { & $fixtureTool -Module LegacyBridge -MappingPath $testMapping } 'method/normalized path must be identical'
        }
    }
    # A target may not substitute a different valid operation for the unique converted route.
    Write-FixtureFile 'openApiDocs\v1.0\LegacyBridge.yml' @'
openapi: 3.0.4
paths:
  '/widgets/{old-id}/microsoft.graph.refresh':
    post:
      operationId: legacy_ConvertedWidget
      x-ms-docs-operation-type: action
'@
    $finalCurrentSpec = @'
openapi: 3.0.4
paths:
  '/widgets/{widget-id}/refresh':
    post:
      operationId: widgets.Converted
      x-ms-docs-operation-type: action
  '/other/{widget-id}/refresh':
    post:
      operationId: other.Refresh
      x-ms-docs-operation-type: action
'@
    Write-FixtureFile 'openApiDocs_KiotaCompat\v1.0\LegacyBridge.yml' $finalCurrentSpec
    $document = $legacyMapping | ConvertFrom-Json
    $document.mappings[0].profiles.'v1.0'.removedLegacyOperations = @()
    $document.mappings[0].profiles.'v1.0'.operations = @([pscustomobject]@{
        method = 'POST'
        path = '/other/{widget-id}/refresh'
        operationId = 'other.Refresh'
        legacyPath = '/widgets/{old-id}/microsoft.graph.refresh'
        legacyOperationId = 'legacy_ConvertedWidget'
        legacyPathTranslation = 'UnqualifyFinalOperation'
    })
    $document | ConvertTo-Json -Depth 10 | Set-Content $testMapping
    Assert-Failure { & $fixtureTool -Module LegacyBridge -MappingPath $testMapping } 'exact unique compatible counterpart'
    $document.mappings[0].profiles.'v1.0'.operations[0].path = '/widgets/{widget-id}/refresh'
    $document.mappings[0].profiles.'v1.0'.operations[0].operationId = 'widgets.Converted'
    $document | ConvertTo-Json -Depth 10 | Set-Content $testMapping
    Write-FixtureFile 'openApiDocs_KiotaCompat\v1.0\LegacyBridge.yml' ($finalCurrentSpec + @'

  '/widgets/{ambiguous-id}/refresh':
    post:
      operationId: widgets.AmbiguousRefresh
      x-ms-docs-operation-type: action
'@)
    Assert-Failure { & $fixtureTool -Module LegacyBridge -MappingPath $testMapping } 'matched 2 operations'
    Write-FixtureFile 'openApiDocs_KiotaCompat\v1.0\LegacyBridge.yml' $finalCurrentSpec
    $document.mappings[0].profiles.'v1.0'.operations[0].legacyPathTranslation = 'GenericAlias'
    $document | ConvertTo-Json -Depth 10 | Set-Content $testMapping
    Assert-Failure { & $fixtureTool -Module LegacyBridge -MappingPath $testMapping } "legacyPathTranslation must be 'UnqualifyFinalOperation'"

    Write-FixtureFile 'src\Deferred\Deferred.md' @'
``` yaml
directive:
  - where:
      parameter-name: Id
    set:
      alias: ItemId
  - where-operation-id: fixture_GetItem
    remove: $.responses.200
```
'@
    $deferred = @(& $fixtureTool -Module Deferred -FailOnUnresolved)
    if ($deferred.Count -ne 2 -or @($deferred | Where-Object Status -ne 'Deferred').Count -ne 0) {
        throw 'Deferred parameter and schema directives must not block cmdlet completion.'
    }
    # A where selector still needs review even when it has unrelated module configuration.
    Remove-Item (Join-Path $fixtureRoot 'src\Compliance\wrapper\Compliance_directiveMigrationMap.json')
    $unresolved = @(& $fixtureTool -Module Compliance)
    if (@($unresolved | Where-Object Status -eq 'Unresolved').Count -ne 2) {
        throw 'Unreviewed where selectors must remain Unresolved.'
    }
    Assert-Failure { & $fixtureTool -Module Compliance -FailOnUnresolved } 'lack reviewed mappings'

    Write-FixtureFile 'src\Audit\Audit.md' '# No shared directives'
    Write-FixtureFile 'src\Empty\Empty.md' "`````` yaml`ndirective:`n``````"
    Write-FixtureFile 'src\Audit\beta\readme.md' "directive:`n  - remove-path-by-operation: ignored"
    Write-FixtureFile 'src\Audit\v1.0\readme.md' "directive:`n  - remove-path-by-operation: ignored"
    Write-FixtureFile 'src\readme.graph.md' "directive:`n  - remove-path-by-operation: ignored"
    if (@(& $fixtureTool -Module Audit,Empty -FailOnUnresolved).Count -ne 0) {
        throw 'No shared directives is an empty passing audit, regardless of profile-local or global directives.'
    }
    $document.mappings[0].module = 'Audit'
    $document | ConvertTo-Json -Depth 10 | Set-Content $testMapping
    Assert-Failure { & $fixtureTool -Module Audit -MappingPath $testMapping -FailOnUnresolved } 'entries do not match a directive'

    Write-FixtureFile 'src\Applications\Applications.md' @'
directive:
  - where:
      verb: Get
      subject: UnreviewedFixture
    remove: true
  - where:
      parameter-name: Id
    set:
      alias: FixtureId
'@
    $applications = @((& $fixtureTool -Module Applications -AsJson | Out-String) | ConvertFrom-Json)
    if (@($applications | Where-Object Status -eq 'Deferred').Count -lt 1 -or
        @($applications | Where-Object Status -eq 'Unresolved').Count -lt 1) {
        throw 'An unreviewed fixture must expose deferred and unresolved shared directives.'
    }
    Assert-Failure { & $fixtureTool -Module Applications -FailOnUnresolved } 'lack reviewed mappings'
    $schemaDirective = @(& $tool -Module Identity.SignIns) | Where-Object Classification -eq 'DeferredSchema'
    if (@($schemaDirective).Count -ne 1 -or $schemaDirective.Status -ne 'Deferred') {
        throw 'Live schema/response directives must remain deferred.'
    }
    if (@(& $tool -Module Search -FailOnUnresolved).Count -ne 0) {
        throw 'A live module without shared directives must pass without fake mapping entries.'
    }
}
finally {
    if (Test-Path $fixtureRoot) { Remove-Item $fixtureRoot -Recurse -Force }
}

$after = & git -c core.longpaths=true -C $repoRoot status --porcelain
if (($before -join "`n") -ne ($after -join "`n")) {
    throw 'Inventory without -OutputPath must not modify the worktree.'
}

Write-Host 'PASS: isolated reviewed-mapping/completion tests and read-only live inventory checks (not a live Compliance ledger audit).'
