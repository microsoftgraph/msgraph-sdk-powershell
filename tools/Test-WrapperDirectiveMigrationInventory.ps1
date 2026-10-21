<#
.SYNOPSIS
Validates reviewed directive mappings and the completion gate using isolated fixtures.

.DESCRIPTION
Copies the inventory tool and preserved Compliance pilot inputs into a temporary repository
layout. Exact fixture specifications exercise valid and stale evidence independently of live
API pruning. Also checks read-only live candidate, deferred, and empty-module inventory.
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

    $applications = @((& $tool -Module Applications -AsJson | Out-String) | ConvertFrom-Json)
    if (@($applications | Where-Object Status -eq 'Deferred').Count -lt 1 -or
        @($applications | Where-Object Status -eq 'Unresolved').Count -lt 1) {
        throw 'Live Applications must retain deferred and unresolved shared directives.'
    }
    $calendar = @(& $tool -Module Calendar)
    if (@($calendar | Where-Object { $_.Status -eq 'Resolved' -and $_.Implementation -eq 'Candidate' }).Count -lt 1) {
        throw 'Live Calendar operation-ID matches must remain candidates without reviewed evidence.'
    }
    Assert-Failure { & $tool -Module Calendar -FailOnUnresolved } 'lack reviewed mappings'
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
