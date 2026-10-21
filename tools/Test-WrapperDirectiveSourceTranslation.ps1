<#
.SYNOPSIS
Checks YAML operation identities and explicitly reviewed legacy-to-current selector evidence.
#>
[CmdletBinding()]
param()
$ErrorActionPreference = 'Stop'
$tool = Join-Path $PSScriptRoot 'Get-WrapperDirectiveMigrationInventory.ps1'
$fixture = Join-Path ([IO.Path]::GetTempPath()) "directive-translation-$([guid]::NewGuid())"
function Assert-TranslationFailure([scriptblock]$Action, [string]$Pattern) {
    try { & $Action | Out-Null } catch {
        if ($_.Exception.Message -notmatch $Pattern) { throw }
        return
    }
    throw "Expected inventory failure matching '$Pattern'."
}
function ConvertFrom-OperationSummary([string[]]$Values) {
    foreach ($value in $Values) {
        if ($value -notmatch '^(?<method>\S+) (?<path>.+) \[(?<id>[^]]+)\]$') { throw "Invalid operation summary: $value" }
        @{ method = $Matches.method; path = $Matches.path; operationId = $Matches.id }
    }
}
function New-TranslationMapping($Row) {
    $profileMaps = @{}
    foreach ($profile in @('v1.0', 'beta')) {
        $prefix = if ($profile -eq 'v1.0') { 'V1' } else { 'Beta' }
        $targets = @(ConvertFrom-OperationSummary $Row."$($prefix)Operations")
        $profileMaps[$profile] = @{
            specPath = $Row."$($prefix)SpecPath"; specSha256 = $Row."$($prefix)SpecSha256"
            operations = $targets; absenceExpected = $targets.Count -eq 0
            absenceEvidence = 'Reviewed original selector and current equivalent routes; see pinned sourceSpec.'
            sourceSpec = @{
                specPath = $Row."$($prefix)SourceSpecPath"; specSha256 = $Row."$($prefix)SourceSpecSha256"
                operations = @(ConvertFrom-OperationSummary $Row."$($prefix)SourceOperations")
            }
        }
    }
    @{
        module = $Row.Module; sourcePath = $Row.SourcePath; directiveIndex = $Row.DirectiveIndex
        classification = $Row.Classification; sourceSha256 = $Row.SourceSha256; reviewed = $true
        implementation = 'CmdletConfigurator'; notes = 'Reviewed source selector identities and exact equivalent current routes.'
        profiles = $profileMaps
    }
}
try {
    foreach ($dir in @('tools', 'config', 'src\Widget\wrapper', 'openApiDocs_KiotaCompat\v1.0',
        'openApiDocs_KiotaCompat\beta', 'openApiDocs\v1.0', 'openApiDocs\beta')) {
        New-Item -ItemType Directory -Path (Join-Path $fixture $dir) -Force | Out-Null
    }
    Copy-Item -LiteralPath $tool -Destination (Join-Path $fixture 'tools')
    $fixtureTool = Join-Path $fixture 'tools\Get-WrapperDirectiveMigrationInventory.ps1'
    $localSource = Join-Path $fixture 'src\Widget\Widget.md'
    $sharedSource = Join-Path $fixture 'src\readme.graph.md'
    $betaSpec = Join-Path $fixture 'openApiDocs_KiotaCompat\beta\Widget.yml'
    $ledger = Join-Path $fixture 'src\Widget\wrapper\Widget_directiveMigrationMap.json'
    '{"Widget":{}}' | Set-Content (Join-Path $fixture 'config\ModulesMapping.jsonc')
    '# no shared directives' | Set-Content $sharedSource
    @'
``` yaml
directive:
  - remove-path-by-operation: ^Shape_
```
'@ | Set-Content $localSource
    $shapeSpec = @'
openapi: 3.0.0
paths:
  /users/{user-id}/devices/usageRights/$count:
    get:
      operationId: Shape_Count
  '/users/{user-id}/devices(deviceId=''{deviceId}'')':
    'get':
      operationId: 'Shape_AlternateGet'
    "patch":
      operationId: "Shape_AlternatePatch" # quoted scalar comment
    delete:
      operationId: Shape_AlternateDelete
  "/users/{user-id}/devices(deviceId='{deviceId}')/double\u002Dquoted":
    get:
      operationId: Shape_Double
  /users/{user-id}/devices(deviceId='{deviceId}')/plain: # plain scalar comment
    get:
      operationId: Shape_Plain
  /neighbors/after:
    get:
      operationId: Shape_After
  /case:
    get:
      operationId: Shape_case
  /Case:
    get:
      operationId: Shape_Case
components:
  /not-a-path:
    get:
      operationId: Shape_NotAnOperation
'@
    foreach ($profile in @('v1.0', 'beta')) { $shapeSpec | Set-Content (Join-Path $fixture "openApiDocs_KiotaCompat\$profile\Widget.yml") }
    $shapes = @(& $fixtureTool)[0]
    if ($shapes.BetaOperations.Count -ne 9) { throw 'Every supported YAML-key operation must be inventoried once, within paths only, preserving case-distinct routes and IDs.' }
    $alternate = @($shapes.BetaOperations | Where-Object { $_ -like "*[[]Shape_Alternate*" })
    if ($alternate.Count -ne 3 -or @($alternate | Where-Object { -not $_.Contains("/users/{user-id}/devices(deviceId='{deviceId}') [") }).Count) { throw 'Single-quoted doubled apostrophes must decode to the real alternate-key route.' }
    if (@($shapes.BetaOperations | Where-Object { $_ -like '*usageRights/$count*' }).Count -ne 1 -or
        @($shapes.BetaOperations | Where-Object { $_.Contains("/double-quoted [Shape_Double]") }).Count -ne 1 -or
        @($shapes.BetaOperations | Where-Object { $_.Contains("/plain [Shape_Plain]") }).Count -ne 1 -or
        @($shapes.BetaOperations | Where-Object { $_.Contains("/neighbors/after [Shape_After]") }).Count -ne 1) { throw 'Quoted/unquoted paths must not leak operations onto previous/next routes.' }
    foreach ($badSpec in @(
        $shapeSpec.Replace("deviceId=''{deviceId}'')':", "deviceId='{deviceId}')':"),
        $shapeSpec.Replace('/double\u002Dquoted', '/double\qquoted'),
        $shapeSpec.Replace('operationId: Shape_Count', 'summary: missing operation identity'),
        $shapeSpec.Replace('    get:', '    get: { operationId: Shape_Inline }'),
        $shapeSpec.Replace("  /neighbors/after:", "  /neighbors/after:`n    get:`n      operationId: Duplicate`n  /neighbors/after:")
    )) {
        $badSpec | Set-Content $betaSpec
        Assert-TranslationFailure { & $fixtureTool } 'YAML|no operationId|duplicate operation|Unsupported inline operation'
    }

    @'
``` yaml
directive:
  - where:
      subject: ^(\w*[a-z])GraphBPre(\w*)$
    set:
      subject: $1By$2
```
'@ | Set-Content $sharedSource
    @'
``` yaml
directive:
  - remove-path-by-operation: ^user.device_DeleteRegisteredOwnerGraphBPreRef$|^user.device_DeleteRegisteredUserGraphBPreRef$
```
'@ | Set-Content $localSource
    $stableSpec = @'
openapi: 3.0.0
paths:
  /users/{user-id}/devices:
    get:
      operationId: users.ListDevices
'@
    $originalSpec = @'
openapi: 3.0.0
paths:
  /users/{user-id}/devices/{device-id}/registeredOwners/$ref:
    get:
      operationId: user.device_ListRegisteredOwnerGraphBPreRef
    post:
      operationId: user.device_CreateRegisteredOwnerGraphBPreRef
    delete:
      operationId: user.device_DeleteRegisteredOwnerGraphBPreRef
  /users/{user-id}/devices/{device-id}/registeredOwners/{directoryObject-id}/$ref:
    delete:
      operationId: user.device.registeredOwner_DeleteDirectoryObjectGraphBPreRef
  /users/{user-id}/devices/{device-id}/registeredUsers/$ref:
    delete:
      operationId: user.device_DeleteRegisteredUserGraphBPreRef
  '/users/{user-id}/devices(deviceId=''{deviceId}'')':
    get:
      operationId: user.device_GetGraphBPreDeviceId
    patch:
      operationId: user.device_UpdateGraphBPreDeviceId
    delete:
      operationId: user.device_DeleteGraphBPreDeviceId
  /users/{user-id}/retired:
    delete:
      operationId: user_DeleteGoneGraphBPre
'@
    $currentSpec = $originalSpec.Replace('user.device_ListRegisteredOwnerGraphBPreRef', 'users.devices.ListRefRegisteredOwners').
        Replace('user.device_CreateRegisteredOwnerGraphBPreRef', 'users.devices.CreateRefRegisteredOwners').
        Replace('user.device_DeleteRegisteredOwnerGraphBPreRef', 'users.devices.DeleteRefRegisteredOwners').
        Replace('user.device.registeredOwner_DeleteDirectoryObjectGraphBPreRef', 'users.devices.registeredOwners.DeleteRefDirectoryObject').
        Replace('user.device_DeleteRegisteredUserGraphBPreRef', 'users.devices.DeleteRefRegisteredUsers').
        Replace('user.device_GetGraphBPreDeviceId', 'users.devices.GetByDeviceId').
        Replace('user.device_UpdateGraphBPreDeviceId', 'users.devices.UpdateByDeviceId').
        Replace('user.device_DeleteGraphBPreDeviceId', 'users.devices.DeleteByDeviceId')
    $currentSpec = $currentSpec.Substring(0, $currentSpec.IndexOf('  /users/{user-id}/retired:'))
    $stableSpec | Set-Content (Join-Path $fixture 'openApiDocs\v1.0\Widget.yml')
    $stableSpec | Set-Content (Join-Path $fixture 'openApiDocs_KiotaCompat\v1.0\Widget.yml')
    $originalSpec | Set-Content (Join-Path $fixture 'openApiDocs\beta\Widget.yml')
    $currentSpec | Set-Content $betaSpec
    $rows = @(& $fixtureTool)
    $maps = @($rows | ForEach-Object { New-TranslationMapping $_ })
    $rename = $maps | Where-Object classification -eq 'SubjectRename'
    $suppression = $maps | Where-Object classification -eq 'OperationIdSuppression'
    $removed = @{ method = 'DELETE'; path = '/users/{user-id}/retired'; operationId = 'user_DeleteGoneGraphBPre'
        absenceEvidence = 'Exact selected source route has no equivalent current HTTP method/path.' }
    $rename.profiles.beta.absentOperations = @($removed)
    $document = @{ mappings = $maps }
    function Save-TranslationLedger { ConvertTo-Json -InputObject $document -Depth 15 | Set-Content -LiteralPath $ledger }
    Save-TranslationLedger
    $complete = @(& $fixtureTool -FailOnUnresolved)
    if (@($complete | Where-Object Status -ne 'Mapped').Count -or
        $complete[0].BetaOperations.Count -ne 8 -or $complete[1].BetaOperations.Count -ne 2) { throw 'Complete reviewed source translation must map all and only equivalent operations.' }

    $goodJson = ConvertTo-Json -InputObject $document -Depth 15
    function Assert-MutatedTranslation([scriptblock]$Mutation, [string]$Pattern) {
        $script:document = $goodJson | ConvertFrom-Json -AsHashtable
        & $Mutation $script:document.mappings
        Save-TranslationLedger
        Assert-TranslationFailure { & $fixtureTool -FailOnUnresolved } $Pattern
    }
    Assert-MutatedTranslation { param($m) $m[1].profiles.beta.sourceSpec.specSha256 = 'changed' } 'original specification identity'
    Assert-MutatedTranslation { param($m) $m[1].profiles.beta.sourceSpec.specPath = 'openApiDocs\beta\Other.yml' } 'original specification identity'
    Assert-MutatedTranslation { param($m) $m[1].profiles.beta.sourceSpec.operations[0].operationId = 'Not_Selected' } 'exactly the original selector'
    Assert-MutatedTranslation { param($m) $m[1].profiles.beta.sourceSpec.operations = @($m[1].profiles.beta.sourceSpec.operations[0]) } 'exactly the original selector'
    Assert-MutatedTranslation { param($m) $m[1].profiles.beta.sourceSpec.operations += @($m[1].profiles.beta.sourceSpec.operations[0]) } 'exactly the original selector'
    Assert-MutatedTranslation { param($m) $m[1].profiles.beta.operations = @($m[1].profiles.beta.operations[0]) } 'exactly equivalent method/path'
    Assert-MutatedTranslation { param($m) $m[1].profiles.beta.operations += @($m[1].profiles.beta.operations[0]) } 'duplicate operation mappings'
    Assert-MutatedTranslation { param($m) $m[1].profiles.beta.operations[0].operationId = 'Wrong_Current_Id' } 'operationId missing or changed'
    Assert-MutatedTranslation { param($m) $m[1].profiles.beta.operations[0].Remove('operationId') } 'operationId missing or changed'
    Assert-MutatedTranslation { param($m) $m[1].reviewed = $false } 'reviewed'
    Assert-MutatedTranslation { param($m) $m[1].profiles.'v1.0'.sourceSpec.Remove('operations') } 'explicit operations list'
    Assert-MutatedTranslation { param($m) $m[1].profiles.'v1.0'.sourceSpec.operations = $null } 'explicit operations list'
    Assert-MutatedTranslation { param($m) $m[1].profiles.'v1.0'.Remove('operations') } 'explicit target operations list'
    Assert-MutatedTranslation { param($m) $m[1].profiles.beta.Remove('sourceSpec') } 'requires reviewed sourceSpec'
    Assert-MutatedTranslation { param($m) $m[1].profiles.beta.operations = @(); $m[1].profiles.beta.absenceExpected = $true } 'exactly equivalent method/path'
    Assert-MutatedTranslation { param($m) $m[1].profiles.beta.absentOperations = @($m[1].profiles.beta.sourceSpec.operations[0]) } 'false source absence'
    Assert-MutatedTranslation { param($m) $m[0].profiles.beta.Remove('absentOperations') } 'removed source operation requires'
    Assert-MutatedTranslation { param($m) $m[0].profiles.beta.absentOperations[0].Remove('absenceEvidence') } 'removed source operation requires'
    Assert-MutatedTranslation { param($m) $m[1].profiles.beta.operations[0] = $m[0].profiles.beta.operations[0] } 'exactly equivalent method/path'

    $document = $goodJson | ConvertFrom-Json -AsHashtable
    $emptyLedger = Join-Path $fixture 'empty.json'
    '{"mappings":[]}' | Set-Content $emptyLedger
    $stableSpec | Set-Content $betaSpec
    $absentRows = @(& $fixtureTool -MappingPath $emptyLedger)
    foreach ($map in $document.mappings) {
        $row = $absentRows | Where-Object SourcePath -eq $map.sourcePath
        $map.implementation = 'ReviewedAbsence'
        $map.profiles.beta.specSha256 = $row.BetaSpecSha256
        $map.profiles.beta.operations = @()
        $map.profiles.beta.absenceExpected = $true
        $map.profiles.beta.absentOperations = @($map.profiles.beta.sourceSpec.operations | ForEach-Object {
            $_.absenceEvidence = 'Selected source HTTP method/path is removed from this current specification.'
            $_
        })
    }
    Save-TranslationLedger
    & $fixtureTool -FailOnUnresolved | Out-Null

    # Parameter spellings can change, but fixed route components/methods cannot.
    $document = $goodJson | ConvertFrom-Json -AsHashtable
    $renamedParameters = $currentSpec.Replace('{device-id}', '{id}')
    $renamedParameters | Set-Content $betaSpec
    $freshRows = @(& $fixtureTool -MappingPath $emptyLedger)
    foreach ($map in $document.mappings) {
        $row = $freshRows | Where-Object SourcePath -eq $map.sourcePath
        $map.profiles.beta.specSha256 = $row.BetaSpecSha256
        $map.profiles.beta.operations = @(ConvertFrom-OperationSummary $row.BetaOperations)
    }
    Save-TranslationLedger
    & $fixtureTool -FailOnUnresolved | Out-Null
    $ambiguousSpec = $renamedParameters + @'
  /users/{uid}/devices/{did}/registeredOwners/$ref:
    delete:
      operationId: Ambiguous_DeleteRef
'@
    $ambiguousSpec | Set-Content $betaSpec
    Assert-TranslationFailure { & $fixtureTool -FailOnUnresolved } 'ambiguous equivalent route'

    '# no shared directives' | Set-Content $sharedSource
    @'
``` yaml
directive:
  - remove-path-by-operation: ^subscription_(reauthorize|getVapidPublicKey)$|^directoryObject_getGraphBPreId$|^Legacy_
```
'@ | Set-Content $localSource
    $qualifiedSpec = @'
openapi: 3.0.0
paths:
  /subscriptions/{subscription-id}/microsoft.graph.reauthorize:
    post:
      operationId: subscription_reauthorize
      x-ms-docs-operation-type: action
  /subscriptions/microsoft.graph.getVapidPublicKey():
    get:
      x-ms-docs-operation-type: function
      operationId: subscription_getVapidPublicKey
  /directoryObjects/microsoft.graph.getByIds:
    post:
      operationId: directoryObject_getGraphBPreId
      x-ms-docs-operation-type: action
  /typecast/microsoft.graph.user:
    get:
      operationId: Legacy_TypeCast
      x-ms-docs-operation-type: operation
  /navigation/microsoft.graph.call:
    post:
      operationId: Legacy_Navigation
      x-ms-docs-operation-type: operation
  /functions/microsoft.graph.oldName():
    get:
      operationId: Legacy_DifferentName
      x-ms-docs-operation-type: function
  /functions/microsoft.graph.call()/after:
    get:
      operationId: Legacy_Intermediate
      x-ms-docs-operation-type: function
'@
    $unqualifiedSpec = $qualifiedSpec.Replace('microsoft.graph.', '').
        Replace('subscription_reauthorize', 'subscriptions.subscription.reauthorize').
        Replace('subscription_getVapidPublicKey', 'subscriptions.getVapidPublicKey').
        Replace('directoryObject_getGraphBPreId', 'directoryObjects.getByIds').
        Replace('Legacy_', 'Current_').Replace('oldName()', 'otherName()')
    foreach ($profile in @('v1.0', 'beta')) {
        $qualifiedSpec | Set-Content (Join-Path $fixture "openApiDocs\$profile\Widget.yml")
        $unqualifiedSpec | Set-Content (Join-Path $fixture "openApiDocs_KiotaCompat\$profile\Widget.yml")
    }
    $callRow = @(& $fixtureTool -MappingPath $emptyLedger)[0]
    if ($callRow.BetaOperations.Count -ne 3) { throw 'Only proven terminal action/function namespace spellings may normalize; type casts, navigation, intermediate calls, and different names must not.' }
    $callMap = New-TranslationMapping $callRow
    foreach ($profile in @('v1.0', 'beta')) {
        $callMap.profiles[$profile].absentOperations = @($callMap.profiles[$profile].sourceSpec.operations |
            Where-Object operationId -like 'Legacy_*' | ForEach-Object {
                $_.absenceEvidence = 'No exact or proven qualified-call equivalent; unrelated current neighbor is not the selected source route.'
                $_
            })
    }
    $document = @{ mappings = @($callMap) }
    Save-TranslationLedger
    & $fixtureTool -FailOnUnresolved | Out-Null
    $callsJson = ConvertTo-Json -InputObject $document -Depth 15
    foreach ($badCallSpec in @(
        $unqualifiedSpec.Replace('x-ms-docs-operation-type: action', 'x-ms-docs-operation-type: function'),
        $unqualifiedSpec.Replace('x-ms-docs-operation-type: function', 'summary: missing function evidence')
    )) {
        $badCallSpec | Set-Content $betaSpec
        $document = $callsJson | ConvertFrom-Json -AsHashtable
        $fresh = @(& $fixtureTool -MappingPath $emptyLedger)[0]
        $document.mappings[0].profiles.beta.specSha256 = $fresh.BetaSpecSha256
        Save-TranslationLedger
        Assert-TranslationFailure { & $fixtureTool -FailOnUnresolved } 'removed source operation requires|exactly equivalent method/path'
    }
    $unqualifiedSpec | Set-Content $betaSpec
    $document = $callsJson | ConvertFrom-Json -AsHashtable
    $document.mappings[0].profiles.beta.operations = @()
    $document.mappings[0].profiles.beta.absenceExpected = $true
    Save-TranslationLedger
    Assert-TranslationFailure { & $fixtureTool -FailOnUnresolved } 'exactly equivalent method/path'

    @'
``` yaml
directive:
  - where:
      subject: ^(\w*[a-z])GraphOPre(\w*)$
    set:
      subject: $1Of$2
```
'@ | Set-Content $sharedSource
    '# no local directives' | Set-Content $localSource
    $castSource = @'
openapi: 3.0.0
paths:
  /objects/{object-id}/microsoft.graph.group:
    get:
      operationId: user_GetMemberGraphOPreAsGroup
    patch:
      operationId: user_UpdateMemberGraphOPreAsGroup
  /objects/microsoft.graph.group:
    get:
      operationId: user_ListMemberGraphOPreAsGroup
components:
  schemas:
    microsoft.graph.group:
      type: object
    microsoft.graph.administrativeUnit:
      type: object
'@
    $castCurrent = $castSource.Replace('/microsoft.graph.group:', '/graph.group:').
        Replace('user_GetMemberGraphOPreAsGroup', 'users.GetMemberOf.AsGroup').
        Replace('user_UpdateMemberGraphOPreAsGroup', 'users.UpdateMemberOf.AsGroup').
        Replace('user_ListMemberGraphOPreAsGroup', 'users.ListMemberOf.AsGroup')
    foreach ($profile in @('v1.0', 'beta')) {
        $castSource | Set-Content (Join-Path $fixture "openApiDocs\$profile\Widget.yml")
        $castCurrent | Set-Content (Join-Path $fixture "openApiDocs_KiotaCompat\$profile\Widget.yml")
    }
    $castRow = @(& $fixtureTool -MappingPath $emptyLedger)[0]
    if ($castRow.BetaSourceOperations.Count -ne 3 -or $castRow.BetaOperations.Count -ne 3) { throw 'Proven same-type terminal cast aliases must preserve item/collection routes and methods.' }
    $document = @{ mappings = @((New-TranslationMapping $castRow)) }
    Save-TranslationLedger
    & $fixtureTool -FailOnUnresolved | Out-Null
    $castsJson = ConvertTo-Json -InputObject $document -Depth 15
    foreach ($badCastSpec in @(
        $castCurrent.Replace('/graph.group:', '/graph.administrativeUnit:'),
        $castCurrent.Replace('    get:', '    delete:'),
        $castCurrent.Replace('    microsoft.graph.group:', '    microsoft.graph.Group:'),
        $castCurrent.Replace('  schemas:', '  responses:'),
        $castCurrent.Replace('/graph.group:', '/graph.Group:'),
        $castCurrent.Replace('/graph.group:', '/other.group:')
    )) {
        $badCastSpec | Set-Content $betaSpec
        $document = $castsJson | ConvertFrom-Json -AsHashtable
        $fresh = @(& $fixtureTool -MappingPath $emptyLedger)[0]
        $document.mappings[0].profiles.beta.specSha256 = $fresh.BetaSpecSha256
        Save-TranslationLedger
        Assert-TranslationFailure { & $fixtureTool -FailOnUnresolved } 'matched 0 operations|removed source operation requires|exactly equivalent method/path'
    }
    $castCurrent | Set-Content $betaSpec
    $document = $castsJson | ConvertFrom-Json -AsHashtable
    $document.mappings[0].profiles.beta.operations = @()
    $document.mappings[0].profiles.beta.absenceExpected = $true
    Save-TranslationLedger
    Assert-TranslationFailure { & $fixtureTool -FailOnUnresolved } 'exactly equivalent method/path'

    # Pin the real corpus, including all eleven inherited beta GraphBPre operations.
    $crossRows = @(& $tool -Module CrossDeviceExperiences -MappingPath $emptyLedger)
    $crossSuppression = $crossRows | Where-Object Classification -eq 'OperationIdSuppression'
    $crossRename = $crossRows | Where-Object { $_.SourcePath -eq 'src\readme.graph.md' -and $_.DirectiveIndex -eq 18 }
    if ($crossSuppression.BetaSourceOperations.Count -ne 2 -or $crossSuppression.BetaOperations.Count -ne 2 -or
        $crossRename.BetaSourceOperations.Count -ne 11 -or $crossRename.BetaOperations.Count -ne 11 -or
        @($crossRename.BetaOperations | Where-Object { $_.Contains("/devices(deviceId='{deviceId}') [") }).Count -ne 3) {
        throw 'Actual CrossDevice source suppressions and alternate-key rename targets must be retained without misattribution.'
    }
    $document = @{ mappings = @((New-TranslationMapping $crossSuppression), (New-TranslationMapping $crossRename)) }
    $realLedger = Join-Path $fixture 'real.json'
    ConvertTo-Json -InputObject $document -Depth 15 | Set-Content $realLedger
    $mapped = @(& $tool -Module CrossDeviceExperiences -MappingPath $realLedger)
    if (@($mapped | Where-Object Status -eq 'Mapped').Count -ne 2) { throw 'Real CrossDevice translations must accept truthful source/target identities.' }
    $crossCasts = $crossRows | Where-Object { $_.SourcePath -eq 'src\readme.graph.md' -and $_.DirectiveIndex -eq 22 }
    if ($crossCasts.V1SourceOperations.Count -or $crossCasts.BetaSourceOperations.Count -ne 12 -or
        $crossCasts.BetaOperations.Count -ne 12 -or @($crossCasts.BetaOperations | Where-Object { $_ -cmatch '/graph\.(group|administrativeUnit) \[' }).Count -ne 8) {
        throw 'Actual GraphOPre must retain all twelve beta targets, including eight proven same-type cast aliases.'
    }
    $castDocument = @{ mappings = @((New-TranslationMapping $crossCasts)) }
    ConvertTo-Json -InputObject $castDocument -Depth 15 | Set-Content $realLedger
    & $tool -Module CrossDeviceExperiences -MappingPath $realLedger | Out-Null
    $document.mappings[0].profiles.beta.Remove('sourceSpec')
    $document.mappings[0].profiles.beta.operations = @()
    $document.mappings[0].profiles.beta.absenceExpected = $true
    ConvertTo-Json -InputObject $document -Depth 15 | Set-Content $realLedger
    Assert-TranslationFailure { & $tool -Module CrossDeviceExperiences -MappingPath $realLedger } 'zero current-ID matches do not prove API absence'

    $peopleRows = @(& $tool -Module People -MappingPath $emptyLedger)
    $people = @($peopleRows | Where-Object { $_.SourcePath -eq 'src\People\People.md' -and $_.Classification -eq 'OperationIdSuppression' })
    if ($people.Count -ne 1 -or $people[0].V1SourceOperations.Count -or $people[0].BetaSourceOperations.Count -ne 3 -or
        $people[0].BetaOperations.Count -ne 3 -or @($people[0].BetaOperations | Where-Object { -not $_.Contains('/analytics [') }).Count) {
        throw 'Legacy People analytics selector must map three existing beta routes, not activityStatistics neighbors or false absence.'
    }
    $document = @{ mappings = @((New-TranslationMapping $people[0])) }
    ConvertTo-Json -InputObject $document -Depth 15 | Set-Content $realLedger
    & $tool -Module People -MappingPath $realLedger | Out-Null
    $document.mappings[0].profiles.beta.operations = @()
    $document.mappings[0].profiles.beta.absenceExpected = $true
    ConvertTo-Json -InputObject $document -Depth 15 | Set-Content $realLedger
    Assert-TranslationFailure { & $tool -Module People -MappingPath $realLedger } 'exactly equivalent method/path'

    $directory = @(& $tool -Module DirectoryObjects -MappingPath $emptyLedger) |
        Where-Object { $_.SourcePath -eq 'src\readme.graph.md' -and $_.DirectiveIndex -eq 18 }
    if (-not ($directory.V1Operations -ccontains 'POST /directoryObjects/getByIds [directoryObjects.getByIds]') -or
        -not ($directory.BetaOperations -ccontains 'POST /directoryObjects/getByIds [directoryObjects.getByIds]')) {
        throw 'Actual DirectoryObjects GraphBPre action must retain its namespace-equivalent getByIds target in both profiles.'
    }
    $backup = @(& $tool -Module BackupRestore -MappingPath $emptyLedger)
    $backupBy = $backup | Where-Object { $_.SourcePath -eq 'src\readme.graph.md' -and $_.DirectiveIndex -eq 18 }
    $backupFor = $backup | Where-Object { $_.SourcePath -eq 'src\readme.graph.md' -and $_.DirectiveIndex -eq 21 }
    if ($backupFor.V1SourceOperations.Count -ne 46 -or $backupFor.BetaSourceOperations.Count -ne 52 -or
        -not ($backupBy.BetaOperations -ccontains "GET /solutions/backupRestore/reports/getStatisticsByPolicy(policyId='{policyId}') [solutions.backupRestore.reports.getStatisticsByPolicy]")) {
        throw 'Actual BackupRestore GraphFPre operations and quoted namespace-qualified GraphBPre function must be inventoried without false absence.'
    }
} finally {
    if (Test-Path -LiteralPath $fixture) { Remove-Item -LiteralPath $fixture -Recurse -Force }
}
Write-Host 'PASS: YAML scalar paths, complete reviewed source-spec translations, proven qualified calls, exact targets, and truthful absence evidence.'
