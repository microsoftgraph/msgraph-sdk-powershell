<#
.SYNOPSIS
Inventories module AutoRest directives for migration to WrapperGenerator configuration.

.DESCRIPTION
Reads only src/<Module>/<Module>.md and classifies each directive group. Profile-local readme
files and src/readme.graph.md are not inventoried. Operation-ID regex matches are unreviewed
candidates, not completed migrations. Reviewed mappings for suppressions and AutoRest where
selectors live in src/<Module>/wrapper/<Module>_directiveMigrationMap.json and are validated
against exact method/path/operation-ID evidence in both Kiota-compatible profiles.
An unavailable compatible profile can be explicitly excluded only while its spec is absent;
this is not an assertion that API operations are absent.
An explicit per-profile operationIdSource: Legacy disposition can bridge actual regex-matched
IDs in openApiDocs to exact compatible evidence by unique method/normalized path. Literal
compatible matching remains the default; absent legacy selectors never imply successors.
The per-operation legacyPathTranslation: UnqualifyFinalOperation opt-in additionally permits
only reviewed final-operation qualification removal or function delta/delta() spelling, guarded
by both actual operations' kind/method metadata and a unique same-parent counterpart.

The command is read-only unless -OutputPath is supplied. It never edits module configuration
or markdown files.

.PARAMETER Module
One or more module names. Omit to inventory every module with src/<Module>/<Module>.md.

.PARAMETER MappingPath
One or more reviewed mapping ledgers. Omit to discover the selected modules' ledgers. This
override is primarily exposed so the validation test can exercise failure cases.

.PARAMETER OutputPath
Optional .json or .csv output path.

.PARAMETER AsJson
Write JSON to the pipeline instead of inventory objects.

.PARAMETER FailOnUnresolved
Require every non-deferred directive to be Mapped. Both Unresolved selectors and unreviewed
Resolved candidates fail this completion gate. Deferred parameter/schema directives do not
block completion. A module with no shared directives passes without a mapping ledger.
Invalid or stale mappings always fail, even without this switch.
#>
[CmdletBinding()]
param(
    [string[]]$Module = @(),
    [string[]]$MappingPath = @(),
    [string]$OutputPath,
    [switch]$AsJson,
    [switch]$FailOnUnresolved
)

$ErrorActionPreference = 'Stop'
$repoRoot = (Resolve-Path (Join-Path $PSScriptRoot '..')).Path
$srcRoot = Join-Path $repoRoot 'src'
$specRoot = Join-Path $repoRoot 'openApiDocs_KiotaCompat'
$legacySpecRoot = Join-Path $repoRoot 'openApiDocs'

function Get-DirectiveClassification {
    param([Parameter(Mandatory)][string]$Text)

    if ($Text -match '(?m)^\s+parameter-name:' -or
        $Text -match '(?m)^\s+alias:' -or
        $Text -match '(?m)^\s+transform:') {
        return 'DeferredParameter'
    }
    if ($Text -match '(?m)^\s*-\s*where-operation-id:' -or
        $Text -match '(?m)^\s+remove:\s*\$') {
        return 'DeferredSchema'
    }
    if ($Text -match '(?m)^\s*-\s*remove-path-by-operation:') {
        return 'OperationIdSuppression'
    }
    $removes = $Text -match '(?m)^\s+remove:\s*true\s*$'
    $setsSubject = $Text -match '(?ms)^\s+set:\s*$.*?^\s+subject:'
    $setsVerb = $Text -match '(?ms)^\s+set:\s*$.*?^\s+verb:'
    if ($removes) { return 'CmdletSuppression' }
    if ($setsSubject -and $setsVerb) { return 'SubjectAndVerbRename' }
    if ($setsVerb) { return 'VerbRename' }
    if ($setsSubject) { return 'SubjectRename' }
    return 'Unclassified'
}

function Get-ModuleDirectives {
    param([Parameter(Mandatory)][string]$ModuleName)

    $path = Join-Path (Join-Path $srcRoot $ModuleName) "$ModuleName.md"
    if (-not (Test-Path $path)) { throw "Module directive file not found: $path" }
    $lines = @(Get-Content $path)
    $directiveLine = -1
    for ($i = 0; $i -lt $lines.Count; $i++) {
        if ($lines[$i] -match '^\s*directive:\s*$') { $directiveLine = $i; break }
    }
    if ($directiveLine -lt 0) { return @() }

    $entries = [System.Collections.Generic.List[object]]::new()
    $current = [System.Collections.Generic.List[string]]::new()
    $currentLine = 0
    $index = 0
    for ($i = $directiveLine + 1; $i -lt $lines.Count; $i++) {
        if ($lines[$i] -match '^```\s*$') { break }
        if ($lines[$i] -match '^\s*#') { continue }
        if ($lines[$i] -match '^\s{2}-\s+') {
            if ($current.Count -gt 0) {
                $index++
                $text = $current -join [Environment]::NewLine
                $entries.Add([pscustomobject]@{
                    Module = $ModuleName
                    DirectiveIndex = $index
                    DirectiveLine = $currentLine
                    Classification = Get-DirectiveClassification $text
                    Text = $text
                })
                $current.Clear()
            }
            $currentLine = $i + 1
        }
        if ($currentLine -gt 0) { $current.Add($lines[$i]) }
    }
    if ($current.Count -gt 0) {
        $index++
        $text = $current -join [Environment]::NewLine
        $entries.Add([pscustomobject]@{
            Module = $ModuleName
            DirectiveIndex = $index
            DirectiveLine = $currentLine
            Classification = Get-DirectiveClassification $text
            Text = $text
        })
    }
    return $entries
}

function Get-SpecOperations {
    param(
        [Parameter(Mandatory)][string]$ModuleName,
        [Parameter(Mandatory)][string]$Profile,
        [string]$Root = $specRoot
    )

    $path = Join-Path (Join-Path $Root $Profile) "$ModuleName.yml"
    if (-not (Test-Path $path)) { return @() }
    $operations = [System.Collections.Generic.List[object]]::new()
    $currentPath = $null
    $currentMethod = $null
    $currentOperation = $null
    $currentOperationType = ''
    foreach ($line in Get-Content $path) {
        if ($line -match "^\s{2}(?:'(?<single>/.*)'|`"(?<double>/.*)`"|(?<plain>/.*)):\s*$") {
            $currentPath = if ($Matches.ContainsKey('single')) {
                # YAML single-quoted keys escape a literal quote by doubling it.
                $Matches.single.Replace("''", "'")
            }
            elseif ($Matches.ContainsKey('double')) { $Matches.double }
            else { $Matches.plain }
            $currentMethod = $null
            $currentOperation = $null
            $currentOperationType = ''
            continue
        }
        if ($currentPath -and $line -match '^\s{4}(?<method>get|post|put|patch|delete|head|options|trace):\s*$') {
            $currentMethod = $Matches.method.ToUpperInvariant()
            $currentOperation = $null
            $currentOperationType = ''
            continue
        }
        if (($currentMethod -or $currentOperation) -and $line -match '^\s{6}x-ms-docs-operation-type:\s*(?<kind>.+?)\s*$') {
            $currentOperationType = $Matches.kind.Trim("'", '"')
            if ($currentOperation) { $currentOperation.OperationType = $currentOperationType }
            continue
        }
        if ($currentPath -and $currentMethod -and $line -match '^\s{6}operationId:\s*(?<id>.+?)\s*$') {
            $currentOperation = [pscustomobject]@{
                Method = $currentMethod
                Path = $currentPath
                OperationId = $Matches.id.Trim("'", '"')
                OperationType = $currentOperationType
            }
            $operations.Add($currentOperation)
            $currentMethod = $null
        }
    }
    return $operations
}

function Format-Operations {
    param([object[]]$Operations)
    return @($Operations | Sort-Object Path, Method | ForEach-Object {
        "$($_.Method) $($_.Path) [$($_.OperationId)]"
    })
}

function Get-OperationIdRegex {
    param([Parameter(Mandatory)][string]$Text)

    $match = [regex]::Match($Text, '(?m)remove-path-by-operation:\s*(?<pattern>.+?)\s*$')
    if (-not $match.Success) { throw [ArgumentException]::new('Could not read remove-path-by-operation pattern.') }
    # AutoRest's JavaScript regex accepts the identity escape \_; .NET does not.
    $pattern = $match.Groups['pattern'].Value.Trim("'", '"') -replace '\\_', '_'
    return [regex]::new($pattern)
}

function Get-NormalizedOperationKey {
    param([string]$Method, [string]$Path)

    $normalizedPath = [regex]::Replace($Path, '\{[^}]*\}', '{}').TrimEnd('/').ToLowerInvariant()
    return "$($Method.ToUpperInvariant()) $normalizedPath"
}

function Get-FinalOperationKey {
    param([string]$Method, [string]$Path)

    $possiblePath = $Path -creplace '/microsoft\.graph\.([a-zA-Z_][a-zA-Z0-9_]*(?:\(.*\))?)/?$', '/$1'
    return Get-NormalizedOperationKey $Method ($possiblePath -replace '\(\)$', '')
}

function Test-FinalOperationTranslation {
    param([object]$LegacyOperation, [object]$CompatibleOperation)

    $kind = $LegacyOperation.OperationType
    if ($kind -cnotin @('action', 'function') -or $kind -cne $CompatibleOperation.OperationType) {
        return 'both actual operations must declare the same action/function kind'
    }
    $requiredMethod = if ($kind -ceq 'action') { 'POST' } else { 'GET' }
    if ($LegacyOperation.Method -cne $requiredMethod -or $CompatibleOperation.Method -cne $requiredMethod) {
        return "$kind translation requires HTTP $requiredMethod on both operations"
    }
    $oldPath = $LegacyOperation.Path.TrimEnd('/')
    $newPath = $CompatibleOperation.Path.TrimEnd('/')
    $oldSplit = $oldPath.LastIndexOf('/')
    $newSplit = $newPath.LastIndexOf('/')
    if ((Get-NormalizedOperationKey $requiredMethod $oldPath.Substring(0, $oldSplit)) -cne
        (Get-NormalizedOperationKey $requiredMethod $newPath.Substring(0, $newSplit))) {
        return 'final-operation translation requires the same normalized parent'
    }
    $oldTerminal = [regex]::Replace($oldPath.Substring($oldSplit + 1), '\{[^}]*\}', '{}')
    $newTerminal = [regex]::Replace($newPath.Substring($newSplit + 1), '\{[^}]*\}', '{}')
    $qualified = [regex]::Match($oldTerminal, '^microsoft\.graph\.(?<bare>[a-zA-Z_][a-zA-Z0-9_]*(?:\(.*\))?)$')
    if ($qualified.Success) {
        $bare = $qualified.Groups['bare'].Value
        if ($bare -ceq $newTerminal -or
            ($kind -ceq 'function' -and ($bare -creplace '\(\)$', '') -ceq ($newTerminal -creplace '\(\)$', ''))) {
            return
        }
    }
    elseif ($kind -ceq 'function' -and
        (($oldTerminal -ceq 'delta' -and $newTerminal -ceq 'delta()') -or
         ($oldTerminal -ceq 'delta()' -and $newTerminal -ceq 'delta'))) {
        return
    }
    return 'only exact final microsoft.graph. qualification removal or function delta/delta() equivalence is supported'
}

function New-OperationLookup {
    param([object[]]$Operations, [switch]$FinalOperation)

    $lookup = [System.Collections.Generic.Dictionary[string, System.Collections.Generic.List[object]]]::new([StringComparer]::Ordinal)
    foreach ($operation in $Operations) {
        $key = if ($FinalOperation) { Get-FinalOperationKey $operation.Method $operation.Path }
        else { Get-NormalizedOperationKey $operation.Method $operation.Path }
        if (-not $lookup.ContainsKey($key)) {
            $lookup[$key] = [System.Collections.Generic.List[object]]::new()
        }
        $lookup[$key].Add($operation)
    }
    return ,$lookup
}

function Test-LegacyOperationTranslation {
    param(
        [object]$Directive,
        [object]$ProfileMap,
        [string]$ModuleName,
        [string]$Profile,
        [object[]]$CompatibleOperations
    )

    if ($Directive.Classification -ne 'OperationIdSuppression') {
        return "$Profile legacy translation is only supported for OperationIdSuppression"
    }
    if ([string]::IsNullOrWhiteSpace($ProfileMap.notes)) {
        "$Profile legacy translation notes are required"
    }
    if ($ProfileMap.absenceExpected -cne $false) {
        "$Profile legacy translation requires absenceExpected: false, not an API-absence claim"
    }
    $legacyPath = Join-Path (Join-Path $legacySpecRoot $Profile) "$ModuleName.yml"
    $compatiblePath = Join-Path (Join-Path $specRoot $Profile) "$ModuleName.yml"
    if (-not (Test-Path $legacyPath) -or -not (Test-Path $compatiblePath)) {
        return "$Profile legacy translation requires both same-module/profile legacy and compatible specs"
    }
    try {
        $regex = Get-OperationIdRegex $Directive.Text
    }
    catch [ArgumentException] {
        return "$Profile legacy operation-ID regex cannot be validated: $($_.Exception.Message)"
    }
    $legacyOperations = @(Get-SpecOperations -ModuleName $ModuleName -Profile $Profile -Root $legacySpecRoot)
    $sourceMatches = @($legacyOperations | Where-Object { $regex.IsMatch($_.OperationId) })
    if ($sourceMatches.Count -eq 0) {
        return "$Profile original operation-ID regex matches no legacy operations; successors cannot be inferred"
    }
    $legacyLookup = New-OperationLookup $legacyOperations
    $compatibleLookup = New-OperationLookup $CompatibleOperations
    $finalOperationLookup = New-OperationLookup $CompatibleOperations -FinalOperation
    $sourceKeys = [System.Collections.Generic.HashSet[string]]::new([StringComparer]::Ordinal)
    foreach ($operation in $sourceMatches) {
        [void]$sourceKeys.Add("$($operation.Method) $($operation.Path) [$($operation.OperationId)]")
    }
    $reviewedKeys = [System.Collections.Generic.HashSet[string]]::new([StringComparer]::Ordinal)
    $removed = @()
    if ($ProfileMap.PSObject.Properties['removedLegacyOperations']) {
        if ($ProfileMap.removedLegacyOperations -isnot [array]) {
            "$Profile removedLegacyOperations must be an explicit array"
        }
        else { $removed = $ProfileMap.removedLegacyOperations }
    }
    $evidence = @(
        foreach ($operation in $ProfileMap.operations) {
            [pscustomobject]@{
                Method = "$($operation.method)".ToUpperInvariant()
                Path = "$($operation.legacyPath)"
                OperationId = "$($operation.legacyOperationId)"
                CompatiblePath = "$($operation.path)"
                Translation = $operation.PSObject.Properties['legacyPathTranslation']
                Removed = $false
                Notes = ''
            }
        }
        foreach ($operation in $removed) {
            [pscustomobject]@{
                Method = "$($operation.method)".ToUpperInvariant()
                Path = "$($operation.path)"
                OperationId = "$($operation.operationId)"
                CompatiblePath = ''
                Translation = $operation.PSObject.Properties['legacyPathTranslation']
                Removed = $true
                Notes = "$($operation.notes)"
            }
        }
    )
    foreach ($expected in $evidence) {
        $key = "$($expected.Method) $($expected.Path) [$($expected.OperationId)]"
        if (-not $reviewedKeys.Add($key)) {
            "$Profile duplicate legacy evidence '$key'"
        }
        if (-not $sourceKeys.Contains($key)) {
            "$Profile legacy evidence '$key' is not an exact original regex match"
        }
        $normalizedKey = Get-NormalizedOperationKey $expected.Method $expected.Path
        $oldMatches = @()
        if ($legacyLookup.ContainsKey($normalizedKey)) { $oldMatches = $legacyLookup[$normalizedKey].ToArray() }
        if ($oldMatches.Count -ne 1) {
            "$Profile legacy method/normalized path '$normalizedKey' matched $($oldMatches.Count) operations; bridge must be unique"
        }
        $usesFinalTranslation = $expected.Translation -and $expected.Translation.Value -ceq 'UnqualifyFinalOperation'
        if ($expected.Translation -and (-not $usesFinalTranslation -or $expected.Removed)) {
            "$Profile legacyPathTranslation must be 'UnqualifyFinalOperation' on a surviving operation"
        }
        $currentKey = if ($usesFinalTranslation) { Get-FinalOperationKey $expected.Method $expected.Path } else { $normalizedKey }
        $lookup = if ($usesFinalTranslation) { $finalOperationLookup } else { $compatibleLookup }
        $currentMatches = @()
        if ($lookup.ContainsKey($currentKey)) { $currentMatches = $lookup[$currentKey].ToArray() }
        if ($expected.Removed) {
            if ([string]::IsNullOrWhiteSpace($expected.Notes)) {
                "$Profile removed legacy operation '$key' requires review notes"
            }
            if ($currentMatches.Count -ne 0) {
                "$Profile removed legacy operation '$key' still has $($currentMatches.Count) compatible method/normalized-path matches"
            }
            # Potential converter counterparts block removal even without the translation opt-in.
            $possibleKey = Get-FinalOperationKey $expected.Method $expected.Path
            $possibleSuccessors = @()
            if ($finalOperationLookup.ContainsKey($possibleKey)) { $possibleSuccessors = $finalOperationLookup[$possibleKey].ToArray() }
            if ($currentMatches.Count -eq 0 -and $possibleSuccessors.Count -gt 0) {
                "$Profile cannot verify removal of '$key': a qualified/bare or empty-argument compatible counterpart needs reviewed path translation"
            }
        }
        else {
            if ([string]::IsNullOrWhiteSpace($expected.Path) -or [string]::IsNullOrWhiteSpace($expected.OperationId)) {
                "$Profile legacyPath and legacyOperationId evidence are required"
            }
            if ($usesFinalTranslation) {
                if ($currentMatches.Count -eq 1 -and $currentMatches[0].Path -cne $expected.CompatiblePath) {
                    "$Profile legacy path translation must select the exact unique compatible counterpart for '$key'"
                }
                if ($oldMatches.Count -eq 1 -and $currentMatches.Count -eq 1) {
                    foreach ($issue in @(Test-FinalOperationTranslation $oldMatches[0] $currentMatches[0])) {
                        "$Profile legacy path translation for '$key': $issue"
                    }
                }
            }
            elseif ((Get-NormalizedOperationKey $expected.Method $expected.CompatiblePath) -cne $normalizedKey) {
                "$Profile legacy and compatible method/normalized path must be identical for '$key'"
            }
            if ($currentMatches.Count -ne 1) {
                "$Profile compatible method/normalized path '$normalizedKey' matched $($currentMatches.Count) operations; bridge must be unique"
            }
        }
    }
    if (-not $reviewedKeys.SetEquals($sourceKeys)) {
        "$Profile legacy evidence must account for the complete original regex match set ($($sourceMatches.Count) operations)"
    }
}

if (-not $Module -or $Module.Count -eq 0) {
    $Module = @(Get-ChildItem $srcRoot -Directory | Where-Object {
        Test-Path (Join-Path $_.FullName "$($_.Name).md")
    } | Select-Object -ExpandProperty Name | Sort-Object)
}
if (-not $MappingPath -or $MappingPath.Count -eq 0) {
    $MappingPath = @($Module | ForEach-Object {
        Join-Path (Join-Path (Join-Path $srcRoot $_) 'wrapper') "$($_)_directiveMigrationMap.json"
    } | Where-Object { Test-Path $_ })
}

$mappingByKey = @{}
foreach ($ledgerPath in $MappingPath) {
    if (-not (Test-Path $ledgerPath)) { throw "Directive mapping ledger not found: $ledgerPath" }
    $mappingDocument = Get-Content $ledgerPath -Raw | ConvertFrom-Json
    foreach ($mapping in @($mappingDocument.mappings)) {
        $key = "$($mapping.module)|$($mapping.directiveIndex)"
        if ($mappingByKey.ContainsKey($key)) {
            throw "Duplicate directive mapping '$key' in $ledgerPath."
        }
        $mappingByKey[$key] = $mapping
    }
}

$rows = [System.Collections.Generic.List[object]]::new()
$usedMappings = [System.Collections.Generic.HashSet[string]]::new()
foreach ($moduleName in $Module) {
    $configurationPath = Join-Path (Join-Path (Join-Path $srcRoot $moduleName) 'wrapper') "$($moduleName)_cmdletConfigurations.cs"
    $configurationEntryCount = if (Test-Path $configurationPath) {
        ([regex]::Matches((Get-Content $configurationPath -Raw), 'new\(OverrideKind\.')).Count
    }
    else {
        0
    }
    $operationsByProfile = @{
        'v1.0' = @(Get-SpecOperations -ModuleName $moduleName -Profile 'v1.0')
        'beta' = @(Get-SpecOperations -ModuleName $moduleName -Profile 'beta')
    }
    foreach ($directive in @(Get-ModuleDirectives $moduleName)) {
        $key = "$moduleName|$($directive.DirectiveIndex)"
        $mapping = $mappingByKey[$key]
        $profileMatches = @{ 'v1.0' = @(); 'beta' = @() }
        $implementation = ''
        $notes = ''
        $status = 'Unresolved'

        if ($directive.Classification -like 'Deferred*') {
            $status = 'Deferred'
            $implementation = 'AutoRest'
            $notes = if ($directive.Classification -eq 'DeferredParameter') {
                'Parameter aliases and transforms are outside the cmdlet-surface migration.'
            }
            else {
                'Schema/response directives are outside the cmdlet-surface migration.'
            }
        }
        elseif ($mapping) {
            [void]$usedMappings.Add($key)
            $implementation = "$($mapping.implementation)"
            $notes = "$($mapping.notes)"
            $missing = [System.Collections.Generic.List[string]]::new()
            if ("$($mapping.classification)" -cne $directive.Classification) {
                $missing.Add("classification changed from '$($mapping.classification)' to '$($directive.Classification)'")
            }
            if ([string]::IsNullOrWhiteSpace($mapping.sourceContains)) {
                $missing.Add('sourceContains evidence is required')
            }
            elseif (-not $directive.Text.Contains("$($mapping.sourceContains)", [StringComparison]::Ordinal)) {
                $missing.Add("source directive no longer contains '$($mapping.sourceContains)'")
            }
            if ([string]::IsNullOrWhiteSpace($implementation)) {
                $missing.Add('implementation disposition is required')
            }
            foreach ($profileName in $mapping.profiles.PSObject.Properties.Name) {
                if ($profileName -cnotin @('v1.0', 'beta')) {
                    $missing.Add("unsupported profile '$profileName'")
                }
            }
            foreach ($profile in @('v1.0', 'beta')) {
                $profileMap = $mapping.profiles.$profile
                if ($null -eq $profileMap) {
                    $missing.Add("$profile mapping declaration")
                    continue
                }
                if ($profileMap.operations -isnot [array]) {
                    $missing.Add("$profile operations must be an explicit array")
                    continue
                }
                $usesLegacyIds = $profileMap.operationIdSource -ceq 'Legacy'
                if ($profileMap.PSObject.Properties['operationIdSource'] -and -not $usesLegacyIds) {
                    $missing.Add("$profile operationIdSource must be 'Legacy' when supplied")
                }
                if (-not $usesLegacyIds -and (
                    $profileMap.PSObject.Properties['removedLegacyOperations'] -or
                    @($profileMap.operations | Where-Object {
                        $_.PSObject.Properties['legacyPath'] -or $_.PSObject.Properties['legacyOperationId'] -or
                        $_.PSObject.Properties['legacyPathTranslation']
                    }).Count -gt 0)) {
                    $missing.Add("$profile legacy evidence requires explicit operationIdSource: Legacy")
                }
                if ($profileMap.PSObject.Properties['excluded'] -and $profileMap.excluded -isnot [bool]) {
                    $missing.Add("$profile excluded must be a boolean")
                }
                if ($profileMap.excluded -is [bool] -and $profileMap.excluded) {
                    if ($usesLegacyIds) {
                        $missing.Add("$profile cannot combine exclusion with legacy translation")
                    }
                    $specPath = Join-Path (Join-Path $specRoot $profile) "$moduleName.yml"
                    if (Test-Path $specPath) {
                        $missing.Add("$profile cannot be excluded because its compatible spec exists")
                    }
                    if ($profileMap.operations.Count -ne 0) {
                        $missing.Add("$profile excluded profile must not declare operations")
                    }
                    if ($profileMap.PSObject.Properties['absenceExpected']) {
                        $missing.Add("$profile excluded profile must not declare absenceExpected")
                    }
                    if ([string]::IsNullOrWhiteSpace($profileMap.notes)) {
                        $missing.Add("$profile exclusion notes are required")
                    }
                    $notes = "$notes $profile excluded: $($profileMap.notes)".Trim()
                    continue
                }
                if ($profileMap.absenceExpected -isnot [bool]) {
                    $missing.Add("$profile absenceExpected must be an explicit boolean")
                }
                if ($profileMap.operations.Count -gt 0 -and $profileMap.absenceExpected) {
                    $missing.Add("$profile declares operations and absenceExpected")
                }
                $reviewedOperations = [System.Collections.Generic.HashSet[string]]::new([StringComparer]::Ordinal)
                foreach ($expected in $profileMap.operations) {
                    $method = "$($expected.method)".ToUpperInvariant()
                    $operationKey = "$method $($expected.path)"
                    if (-not $reviewedOperations.Add($operationKey)) {
                        $missing.Add("$profile duplicate operation '$operationKey'")
                    }
                    if ([string]::IsNullOrWhiteSpace($expected.operationId)) {
                        $missing.Add("$profile $operationKey operationId evidence is required")
                    }
                    $matches = @($operationsByProfile[$profile] | Where-Object {
                        $_.Method -ceq $method -and
                        $_.Path -ceq "$($expected.path)"
                    })
                    if ($matches.Count -ne 1) {
                        $missing.Add("$profile $($expected.method) $($expected.path) matched $($matches.Count) operations")
                    }
                    else {
                        if ($matches[0].OperationId -cne "$($expected.operationId)") {
                            $missing.Add("$profile $($expected.method) $($expected.path) operationId changed from '$($expected.operationId)' to '$($matches[0].OperationId)'")
                        }
                        $profileMatches[$profile] += $matches[0]
                    }
                }
                if (@($profileMap.operations).Count -eq 0 -and -not $profileMap.absenceExpected -and -not $usesLegacyIds) {
                    $missing.Add("$profile has no operations and is not marked absenceExpected")
                }
                if ($usesLegacyIds) {
                    foreach ($issue in @(Test-LegacyOperationTranslation -Directive $directive -ProfileMap $profileMap `
                        -ModuleName $moduleName -Profile $profile -CompatibleOperations $operationsByProfile[$profile])) {
                        $missing.Add($issue)
                    }
                    $notes = "$notes $profile reviewed legacy operation-ID translation: $($profileMap.notes)".Trim()
                }
                elseif ($directive.Classification -eq 'OperationIdSuppression') {
                    try {
                        $regex = Get-OperationIdRegex $directive.Text
                        $candidates = @($operationsByProfile[$profile] | Where-Object { $regex.IsMatch($_.OperationId) })
                        $candidateKeys = @($candidates | ForEach-Object { "$($_.Method) $($_.Path)" })
                        if (-not $reviewedOperations.SetEquals([string[]]$candidateKeys)) {
                            $missing.Add("$profile evidence must cover exactly the operation-ID regex matches")
                        }
                    }
                    catch [ArgumentException] {
                        $missing.Add("operation-ID regex cannot be validated: $($_.Exception.Message)")
                    }
                }
            }
            if ($missing.Count -eq 0) {
                $status = 'Mapped'
            }
            else {
                $status = 'Invalid'
                $notes = (@($notes) + @($missing)) -join ' '
            }
        }
        elseif ($directive.Classification -eq 'OperationIdSuppression') {
            try {
                $regex = Get-OperationIdRegex $directive.Text
                foreach ($profile in @('v1.0', 'beta')) {
                    $profileMatches[$profile] = @($operationsByProfile[$profile] |
                        Where-Object { $regex.IsMatch($_.OperationId) })
                }
                if ($profileMatches['v1.0'].Count + $profileMatches.beta.Count -gt 0) {
                    $status = 'Resolved'
                    $implementation = 'Candidate'
                    $notes = 'Operation-ID regex matches are candidates; reviewed mapping evidence is required.'
                }
            }
            catch [ArgumentException] {
                $notes = "AutoRest operation-ID regular expression requires manual review: $($_.Exception.Message)"
            }
        }

        $summary = ($directive.Text -replace '\s+', ' ').Trim()
        $coverage = if ($status -eq 'Mapped') {
            if ($implementation -eq 'StructuralNaming') { 'StructuralNaming' } else { 'ReviewedConfiguration' }
        }
        elseif ($configurationEntryCount -gt 0) {
            'ModuleHasUnreviewedConfiguration'
        }
        else {
            'None'
        }
        $rows.Add([pscustomobject]@{
            Module = $moduleName
            DirectiveIndex = $directive.DirectiveIndex
            DirectiveLine = $directive.DirectiveLine
            Classification = $directive.Classification
            Status = $status
            Implementation = $implementation
            ExistingCoverage = $coverage
            ModuleConfigurationEntries = $configurationEntryCount
            V1Operations = @(Format-Operations $profileMatches['v1.0'])
            BetaOperations = @(Format-Operations $profileMatches.beta)
            Notes = $notes
            Directive = $summary
        })
    }
}

$unusedMappings = @($mappingByKey.GetEnumerator() | Where-Object {
    $Module -contains $_.Value.module -and -not $usedMappings.Contains($_.Key)
})
if ($unusedMappings.Count -gt 0) {
    throw "Mapping ledger entries do not match a directive: $($unusedMappings.Key -join ', ')"
}

$invalid = @($rows | Where-Object Status -eq 'Invalid')
if ($invalid.Count -gt 0) {
    $details = $invalid | ForEach-Object { "$($_.Module) directive $($_.DirectiveIndex): $($_.Notes)" }
    throw "Invalid directive migration mapping(s):`n$($details -join [Environment]::NewLine)"
}
if ($FailOnUnresolved) {
    $unresolved = @($rows | Where-Object { $_.Status -notin @('Mapped', 'Deferred') })
    if ($unresolved.Count -gt 0) {
        throw "$($unresolved.Count) non-deferred directive(s) lack reviewed mappings (Unresolved or Resolved candidates)."
    }
}

if ($OutputPath) {
    $parent = Split-Path $OutputPath -Parent
    if ($parent -and -not (Test-Path $parent)) { throw "Output directory does not exist: $parent" }
    switch ([IO.Path]::GetExtension($OutputPath).ToLowerInvariant()) {
        '.json' { $rows | ConvertTo-Json -Depth 6 | Set-Content $OutputPath }
        '.csv' {
            $rows | Select-Object Module, DirectiveIndex, DirectiveLine, Classification, Status,
                Implementation, ExistingCoverage, ModuleConfigurationEntries,
                @{ Name = 'V1Operations'; Expression = { $_.V1Operations -join '; ' } },
                @{ Name = 'BetaOperations'; Expression = { $_.BetaOperations -join '; ' } },
                Notes, Directive |
                Export-Csv $OutputPath -NoTypeInformation
        }
        default { throw 'OutputPath must end in .json or .csv.' }
    }
}
elseif ($AsJson) {
    $rows | ConvertTo-Json -Depth 6
}
else {
    $rows
}
