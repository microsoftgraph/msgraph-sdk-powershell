<#
.SYNOPSIS
Inventories module AutoRest directives for migration to WrapperGenerator configuration.

.DESCRIPTION
Reads src/<Module>/<Module>.md and classifies each directive group. Operation-ID suppressions
are resolved directly against the v1.0 and beta Kiota-compatible OpenAPI documents. AutoRest
subject/variant selectors cannot be translated safely from text alone, so reviewed mappings
live beside each module configuration in src/<Module>/wrapper/<Module>_directiveMigrationMap.json.

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
Exit with an error when any non-deferred directive remains unresolved.
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
        [Parameter(Mandatory)][string]$Profile
    )

    $path = Join-Path (Join-Path $specRoot $Profile) "$ModuleName.yml"
    if (-not (Test-Path $path)) { return @() }
    $operations = [System.Collections.Generic.List[object]]::new()
    $currentPath = $null
    $currentMethod = $null
    foreach ($line in Get-Content $path) {
        if ($line -match "^\s{2}['`"]?(?<path>/[^'`"]+)['`"]?:\s*$") {
            $currentPath = $Matches.path
            $currentMethod = $null
            continue
        }
        if ($currentPath -and $line -match '^\s{4}(?<method>get|post|put|patch|delete|head|options|trace):\s*$') {
            $currentMethod = $Matches.method.ToUpperInvariant()
            continue
        }
        if ($currentPath -and $currentMethod -and $line -match '^\s{6}operationId:\s*(?<id>.+?)\s*$') {
            $operations.Add([pscustomobject]@{
                Method = $currentMethod
                Path = $currentPath
                OperationId = $Matches.id.Trim("'", '"')
            })
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
        elseif ($directive.Classification -eq 'OperationIdSuppression') {
            $match = [regex]::Match($directive.Text, '(?m)remove-path-by-operation:\s*(?<pattern>.+?)\s*$')
            if (-not $match.Success) {
                $status = 'Invalid'
                $notes = 'Could not read remove-path-by-operation pattern.'
            }
            else {
                $pattern = $match.Groups['pattern'].Value.Trim("'", '"')
                try {
                    # AutoRest evaluates JavaScript regular expressions, where an identity escape
                    # such as \_ is accepted. .NET rejects it even though it means the same as _.
                    $dotNetPattern = $pattern -replace '\\_', '_'
                    $regex = [regex]::new($dotNetPattern)
                    foreach ($profile in @('v1.0', 'beta')) {
                        $profileMatches[$profile] = @($operationsByProfile[$profile] |
                            Where-Object { $regex.IsMatch($_.OperationId) })
                    }
                    if ($profileMatches['v1.0'].Count + $profileMatches.beta.Count -gt 0) {
                        $status = 'Resolved'
                        $implementation = 'Candidate'
                        $notes = if ($dotNetPattern -ne $pattern) {
                            'Resolved directly after normalizing JavaScript identity escapes for .NET.'
                        }
                        else {
                            'Resolved directly from the operation-ID regular expression.'
                        }
                    }
                }
                catch {
                    $status = 'Unresolved'
                    $notes = "AutoRest operation-ID regular expression requires manual review: $($_.Exception.Message)"
                }
            }
        }
        elseif ($mapping) {
            [void]$usedMappings.Add($key)
            $implementation = "$($mapping.implementation)"
            $notes = "$($mapping.notes)"
            $missing = [System.Collections.Generic.List[string]]::new()
            if ($mapping.classification -and
                "$($mapping.classification)" -ne $directive.Classification) {
                $missing.Add("classification changed from '$($mapping.classification)' to '$($directive.Classification)'")
            }
            if ($mapping.sourceContains -and
                -not $directive.Text.Contains("$($mapping.sourceContains)", [StringComparison]::Ordinal)) {
                $missing.Add("source directive no longer contains '$($mapping.sourceContains)'")
            }
            foreach ($profile in @('v1.0', 'beta')) {
                $profileMap = $mapping.profiles.$profile
                if ($null -eq $profileMap) {
                    $missing.Add("$profile mapping declaration")
                    continue
                }
                foreach ($expected in @($profileMap.operations)) {
                    $matches = @($operationsByProfile[$profile] | Where-Object {
                        $_.Method -eq "$($expected.method)".ToUpperInvariant() -and
                        $_.Path -eq "$($expected.path)"
                    })
                    if ($matches.Count -ne 1) {
                        $missing.Add("$profile $($expected.method) $($expected.path) matched $($matches.Count) operations")
                    }
                    else {
                        if ($expected.operationId -and $matches[0].OperationId -ne "$($expected.operationId)") {
                            $missing.Add("$profile $($expected.method) $($expected.path) operationId changed from '$($expected.operationId)' to '$($matches[0].OperationId)'")
                        }
                        $profileMatches[$profile] += $matches[0]
                    }
                }
                if (@($profileMap.operations).Count -eq 0 -and -not $profileMap.absenceExpected) {
                    $missing.Add("$profile has no operations and is not marked absenceExpected")
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
    $unresolved = @($rows | Where-Object Status -eq 'Unresolved')
    if ($unresolved.Count -gt 0) {
        throw "$($unresolved.Count) non-deferred directive(s) remain unresolved."
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
