<#
.SYNOPSIS
Inventories effective AutoRest directives for configured WrapperGenerator modules.
.DESCRIPTION
Reads shared, module-local and profile-local directive sources without editing them.
Reviewed source-aware ledgers live in src\<Module>\wrapper\<Module>_directiveMigrationMap.json.
Legacy ledgers without sourcePath still refer to src\<Module>\<Module>.md.
.PARAMETER Module
Configured modules to inventory. Defaults to config\ModulesMapping.jsonc, not source directories.
.PARAMETER MappingPath
Optional ledger override, primarily for testing.
.PARAMETER FailOnUnresolved
Require reviewed, fingerprinted coverage of every non-deferred directive, including candidates.
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
$profiles = @('v1.0', 'beta')

function Get-TextFingerprint([string]$Text) {
    $normalized = (($Text -split '\r?\n' | ForEach-Object { $_.TrimEnd() } |
        Where-Object { $_.Trim() -and $_ -notmatch '^\s*#' }) -join "`n").Trim()
    [Convert]::ToHexString([Security.Cryptography.SHA256]::HashData(
        [Text.Encoding]::UTF8.GetBytes($normalized))).ToLowerInvariant()
}

function Get-DirectiveClassification([string]$Text) {
    if ($Text -match '(?m)^\s+parameter-name:') { return 'DeferredParameter' }
    if ($Text -match '(?m)^\s+(format-table|format-list):') { return 'DeferredFormatting' }
    if ($Text -match '(?m)^\s*-\s*(where-operation-id|no-inline):' -or
        $Text -match '(?m)^\s+(?:-\s+)?(from:.*openapi|remove:\s*\$)') { return 'DeferredSchema' }
    if ($Text -match '(?m)^\s*-\s*remove-path-by-operation:') { return 'OperationIdSuppression' }
    if ($Text -match '(?m)^\s+transform:') { return 'DeferredTransform' }
    if ($Text -match '(?m)^\s+remove:\s*true\s*$') { return 'CmdletSuppression' }
    $subject = $Text -match '(?ms)^\s+set:\s*$.*?^\s+subject:'
    $verb = $Text -match '(?ms)^\s+set:\s*$.*?^\s+verb:'
    if ($subject -and $verb) { return 'SubjectAndVerbRename' }
    if ($verb) { return 'VerbRename' }
    if ($subject) { return 'SubjectRename' }
    if ($Text -match '(?m)^\s+alias:') { return 'DeferredCmdletAlias' }
    if ($Text -match '(?m)^\s*-\s*where:') { return 'NoEffectSelector' }
    return 'Unclassified'
}

function Get-SourceDirectives([string]$Path) {
    $lines = @(Get-Content -LiteralPath $Path)
    $current = [Collections.Generic.List[string]]::new()
    $entries = [Collections.Generic.List[object]]::new()
    $inYaml = $false
    $inDirectives = $false
    $index = 0
    $lineNumber = 0
    for ($i = 0; $i -le $lines.Count; $i++) {
        $line = if ($i -lt $lines.Count) { $lines[$i] } else { '```' }
        if ($line -match '^\s*#') { continue }
        $boundary = $line -match '^```' -or ($inDirectives -and $line -match '^\S') -or
            ($inDirectives -and $line -match '^\s{2}-\s+')
        if ($boundary -and $current.Count) {
            $text = $current -join "`n"
            $entries.Add([pscustomobject]@{
                DirectiveIndex = ++$index; DirectiveLine = $lineNumber
                Classification = Get-DirectiveClassification $text
                SourceSha256 = Get-TextFingerprint $text; Text = $text
            })
            $current.Clear()
        }
        if ($line -match '^```\s*ya?ml') { $inYaml = $true; continue }
        if ($line -match '^```') { $inYaml = $false; $inDirectives = $false; continue }
        if (-not $inYaml) { continue }
        if ($line -match '^directive:\s*$') { $inDirectives = $true; continue }
        if ($line -match '^\S') { $inDirectives = $false }
        if (-not $inDirectives -or $line -match '^\s*#') { continue }
        if ($line -match '^\s{2}-\s+') { $lineNumber = $i + 1 }
        if ($current.Count -or $line -match '^\s{2}-\s+') { $current.Add($line) }
    }
    return $entries
}

function Get-EffectiveSources([string]$ModuleName) {
    $sources = [ordered]@{}
    function Add-Source([string]$Path, [string]$Profile) {
        if (-not (Test-Path -LiteralPath $Path -PathType Leaf)) { throw "Directive source not found: $Path" }
        $fullPath = (Resolve-Path -LiteralPath $Path).Path
        $relative = [IO.Path]::GetRelativePath($repoRoot, $fullPath).Replace('/', '\')
        if ($relative.StartsWith('..')) { throw "Directive source is outside repository: $Path" }
        if ($sources.Contains($relative)) {
            if ($sources[$relative] -notcontains $Profile) { $sources[$relative] += $Profile }
            else { return }
        } else { $sources[$relative] = @($Profile) }
        $inRequire = $false
        $inYaml = $false
        foreach ($line in Get-Content -LiteralPath $fullPath) {
            if ($line -match '^```\s*ya?ml') { $inYaml = $true; continue }
            if ($line -match '^```') { $inYaml = $false; $inRequire = $false; continue }
            if (-not $inYaml) { continue }
            if ($line -match '^require:\s*$') { $inRequire = $true; continue }
            if ($line -match '^\S') { $inRequire = $false }
            if ($inRequire -and $line -match '^\s+-\s+[''"]?\$\(this-folder\)(?<path>[^''"]+?\.md)[''"]?\s*$') {
                Add-Source (Join-Path (Split-Path $fullPath) $Matches.path.TrimStart('/', '\').Replace('/', '\')) $Profile
            } elseif ($inRequire -and $line -match '^\s+-\s+') {
                throw "Unsupported require in ${relative}: $line"
            }
        }
    }
    foreach ($profile in $profiles) {
        # Shared configuration also applies to newer modules without a module markdown file.
        Add-Source (Join-Path $srcRoot 'readme.graph.md') $profile
        $local = Join-Path $srcRoot "$ModuleName\$ModuleName.md"
        if (Test-Path -LiteralPath $local) { Add-Source $local $profile }
        $profileSource = Join-Path $srcRoot "$ModuleName\$profile\readme.md"
        if (Test-Path -LiteralPath $profileSource) { Add-Source $profileSource $profile }
    }
    return $sources
}

function Get-Spec([string]$ModuleName, [string]$Profile) {
    $relative = "openApiDocs_KiotaCompat\$Profile\$ModuleName.yml"
    $path = Join-Path $repoRoot $relative
    $operations = [Collections.Generic.List[object]]::new()
    $exists = Test-Path -LiteralPath $path -PathType Leaf
    if ($exists) {
        $currentPath = $null
        $currentMethod = $null
        foreach ($line in Get-Content -LiteralPath $path) {
            if ($line -match "^\s{2}['`"]?(?<path>/[^'`"]+)['`"]?:\s*$") {
                $currentPath = $Matches.path; $currentMethod = $null
            } elseif ($currentPath -and $line -match '^\s{4}(?<method>get|post|put|patch|delete|head|options|trace):\s*$') {
                $currentMethod = $Matches.method.ToUpperInvariant()
            } elseif ($currentPath -and $currentMethod -and $line -match '^\s{6}operationId:\s*(?<id>.+?)\s*$') {
                $operations.Add([pscustomobject]@{ Method = $currentMethod; Path = $currentPath; OperationId = $Matches.id.Trim("'", '"') })
                $currentMethod = $null
            }
        }
    }
    [pscustomobject]@{
        Path = $relative; Exists = $exists
        # Git checkouts may use CRLF or LF; review identity must not depend on the host.
        Sha256 = if ($exists) {
            [Convert]::ToHexString([Security.Cryptography.SHA256]::HashData(
                [Text.Encoding]::UTF8.GetBytes([IO.File]::ReadAllText($path).Replace("`r`n", "`n")))).ToLowerInvariant()
        } else { '' }
        Operations = @($operations)
    }
}

function Format-Operations([object[]]$Operations) {
    @($Operations | Sort-Object Path, Method | ForEach-Object { "$($_.Method) $($_.Path) [$($_.OperationId)]" })
}

$configured = Get-Content (Join-Path $repoRoot 'config\ModulesMapping.jsonc') -Raw | ConvertFrom-Json -AsHashtable
if (-not $Module.Count) { $Module = @($configured.Keys | Sort-Object) }
foreach ($name in $Module) {
    if (-not $configured.ContainsKey($name)) { throw "Module is not configured: $name" }
}
if (-not $MappingPath.Count) {
    $MappingPath = @($Module | ForEach-Object {
        Join-Path $srcRoot "$_\wrapper\$($_)_directiveMigrationMap.json"
    } | Where-Object { Test-Path -LiteralPath $_ })
}
$mappingByKey = @{}
foreach ($ledgerPath in $MappingPath) {
    $document = Get-Content -LiteralPath $ledgerPath -Raw | ConvertFrom-Json
    foreach ($mapping in @($document.mappings)) {
        $source = if ($mapping.sourcePath) { "$($mapping.sourcePath)".Replace('/', '\') } else { "src\$($mapping.module)\$($mapping.module).md" }
        $key = "$($mapping.module)|$source|$($mapping.directiveIndex)"
        if ($mappingByKey.ContainsKey($key)) { throw "Duplicate directive mapping '$key' in $ledgerPath." }
        $mappingByKey[$key] = $mapping
    }
}

$rows = [Collections.Generic.List[object]]::new()
$usedMappings = [Collections.Generic.HashSet[string]]::new()
foreach ($moduleName in $Module) {
    $configurationPath = Join-Path $srcRoot "$moduleName\wrapper\$($moduleName)_cmdletConfigurations.cs"
    $configurationEntryCount = if (Test-Path -LiteralPath $configurationPath) {
        ([regex]::Matches((Get-Content $configurationPath -Raw), 'new\(OverrideKind\.')).Count
    } else { 0 }
    $specs = @{}
    foreach ($profile in $profiles) { $specs[$profile] = Get-Spec $moduleName $profile }
    $sources = Get-EffectiveSources $moduleName
    foreach ($source in $sources.Keys) {
        foreach ($directive in @(Get-SourceDirectives (Join-Path $repoRoot $source))) {
            $key = "$moduleName|$source|$($directive.DirectiveIndex)"
            $mapping = $mappingByKey[$key]
            $profileMatches = @{ 'v1.0' = @(); 'beta' = @() }
            $implementation = ''
            $notes = ''
            $status = 'Unresolved'
            $candidateMatches = @{ 'v1.0' = @(); 'beta' = @() }
            $selectorError = ''
            if ($directive.Classification -eq 'OperationIdSuppression') {
                $pattern = ([regex]::Match($directive.Text, '(?m)remove-path-by-operation:\s*(?<pattern>.+?)\s*$')).Groups['pattern'].Value.Trim("'", '"')
                try {
                    $regex = [regex]::new(($pattern -replace '\\_', '_'), [Text.RegularExpressions.RegexOptions]::IgnoreCase -bor [Text.RegularExpressions.RegexOptions]::Multiline)
                    foreach ($profile in $sources[$source]) {
                        $candidateMatches[$profile] = @($specs[$profile].Operations | Where-Object { $regex.IsMatch($_.OperationId) })
                    }
                    $profileMatches = $candidateMatches.Clone()
                    if ($profileMatches['v1.0'].Count + $profileMatches.beta.Count) {
                        $status = 'Resolved'; $implementation = 'Candidate'
                        $notes = 'Operation-ID matches are candidates, not reviewed migration coverage.'
                    }
                } catch {
                    $selectorError = "Operation-ID expression requires manual review: $($_.Exception.Message)"
                    $notes = $selectorError
                }
            }
            if ($directive.Classification -like 'Deferred*') {
                $status = 'Deferred'; $implementation = 'AutoRest'
                $notes = 'Outside the cmdlet rename/suppression migration; keep active in AutoRest.'
            } elseif ($mapping) {
                [void]$usedMappings.Add($key)
                $implementation = "$($mapping.implementation)"
                $notes = "$($mapping.notes)"
                $errors = [Collections.Generic.List[string]]::new()
                if ($selectorError) { $errors.Add($selectorError) }
                if ($mapping.classification -and $mapping.classification -cne $directive.Classification) { $errors.Add('classification changed') }
                if ($mapping.sourceContains -and -not $directive.Text.Contains("$($mapping.sourceContains)", [StringComparison]::Ordinal)) { $errors.Add('sourceContains changed') }
                if ($mapping.sourceSha256 -and $mapping.sourceSha256 -cne $directive.SourceSha256) { $errors.Add('source fingerprint changed') }
                if ($FailOnUnresolved -and (-not $mapping.sourceSha256 -or $mapping.reviewed -ne $true)) { $errors.Add('strict completion requires sourceSha256 and reviewed: true') }
                if ($FailOnUnresolved -and -not $mapping.classification) { $errors.Add('strict completion requires classification') }
                if ($implementation -notin @('CmdletConfigurator', 'StructuralNaming', 'ReviewedAbsence', 'NoEffect')) { $errors.Add('unreviewed/unknown implementation') }
                if (-not $notes.Trim()) { $errors.Add('review notes are required') }
                if ($directive.Classification -in @('NoEffectSelector', 'Unclassified') -and $implementation -ne 'NoEffect') { $errors.Add('incomplete selector needs explicit NoEffect disposition') }
                $profileMatches = @{ 'v1.0' = @(); 'beta' = @() }
                foreach ($profile in $profiles) {
                    $profileMap = $mapping.profiles.$profile
                    $spec = $specs[$profile]
                    if ($null -eq $profileMap) { $errors.Add("$profile mapping declaration missing"); continue }
                    $expectedOperations = @($profileMap.operations | Where-Object { $null -ne $_ })
                    if (@($expectedOperations | Group-Object method, path | Where-Object Count -gt 1).Count) { $errors.Add("$profile contains duplicate operation mappings") }
                    if ($sources[$source] -notcontains $profile) {
                        if ($profileMap.notApplicable -ne $true -or $expectedOperations.Count -or $profileMap.absenceExpected) { $errors.Add("$profile must declare notApplicable for a profile-local source") }
                        continue
                    }
                    if ($profileMap.notApplicable) { $errors.Add("$profile source applies; cannot declare notApplicable") }
                    if (-not $spec.Exists) { $errors.Add("$profile specification missing: $($spec.Path)"); continue }
                    if ($profileMap.specPath -and "$($profileMap.specPath)".Replace('/', '\') -cne $spec.Path) { $errors.Add("$profile specPath changed") }
                    if ($profileMap.specSha256 -and $profileMap.specSha256 -cne $spec.Sha256) { $errors.Add("$profile specification fingerprint changed") }
                    if (($FailOnUnresolved -or $profileMap.absenceExpected) -and (-not $profileMap.specPath -or -not $profileMap.specSha256)) { $errors.Add("$profile requires actual specPath and specSha256") }
                    foreach ($expected in $expectedOperations) {
                        $found = @($spec.Operations | Where-Object { $_.Method -ceq "$($expected.method)".ToUpperInvariant() -and $_.Path -ceq "$($expected.path)" })
                        if ($found.Count -ne 1) { $errors.Add("$profile $($expected.method) $($expected.path) matched $($found.Count) operations"); continue }
                        if (($FailOnUnresolved -or $expected.operationId) -and $found[0].OperationId -cne "$($expected.operationId)") { $errors.Add("$profile operationId missing or changed: $($expected.path)") }
                        $profileMatches[$profile] += $found[0]
                    }
                    if ($expectedOperations.Count -and $profileMap.absenceExpected) { $errors.Add("$profile cannot map operations and declare absence") }
                    if (-not $expectedOperations.Count -and ($profileMap.absenceExpected -ne $true -or -not "$($profileMap.absenceEvidence)".Trim())) { $errors.Add("$profile empty mapping requires reviewed absenceExpected and absenceEvidence") }
                    foreach ($absent in @($profileMap.absentOperations | Where-Object { $null -ne $_ })) {
                        if (-not $absent.method -or -not $absent.path -or -not $absent.operationId) { $errors.Add("$profile absent operation requires method/path/operationId"); continue }
                        if (@($spec.Operations | Where-Object { ($_.Method -eq $absent.method -and $_.Path -ceq $absent.path) -or $_.OperationId -ceq $absent.operationId }).Count) { $errors.Add("$profile reviewed absent operation is present: $($absent.path)") }
                    }
                    if ($directive.Classification -eq 'OperationIdSuppression') {
                        $actual = @(Format-Operations $candidateMatches[$profile])
                        $reviewed = @(Format-Operations $profileMatches[$profile])
                        if (($actual -join "`n") -cne ($reviewed -join "`n")) { $errors.Add("$profile mapping does not cover exactly the operation-ID selector matches") }
                    }
                }
                if ($implementation -in @('ReviewedAbsence', 'NoEffect') -and ($profileMatches['v1.0'].Count + $profileMatches.beta.Count)) { $errors.Add("$implementation cannot claim operation coverage") }
                $status = if ($errors.Count) { 'Invalid' } else { 'Mapped' }
                if ($errors.Count) { $notes = (@($notes) + @($errors)) -join '; ' }
            }
            $rows.Add([pscustomobject]@{
                Module = $moduleName; SourcePath = $source; Profiles = @($sources[$source])
                DirectiveIndex = $directive.DirectiveIndex; DirectiveLine = $directive.DirectiveLine
                SourceSha256 = $directive.SourceSha256; Classification = $directive.Classification
                Status = $status; Implementation = $implementation
                ExistingCoverage = if ($status -eq 'Mapped') { $implementation } elseif ($configurationEntryCount) { 'ModuleHasUnreviewedConfiguration' } else { 'None' }
                ModuleConfigurationEntries = $configurationEntryCount
                V1SpecPath = $specs['v1.0'].Path; V1SpecSha256 = $specs['v1.0'].Sha256
                BetaSpecPath = $specs.beta.Path; BetaSpecSha256 = $specs.beta.Sha256
                V1Operations = @(Format-Operations $profileMatches['v1.0'])
                BetaOperations = @(Format-Operations $profileMatches.beta)
                Notes = $notes; Directive = ($directive.Text -replace '\s+', ' ').Trim()
            })
        }
    }
}
$unused = @($mappingByKey.GetEnumerator() | Where-Object { $Module -contains $_.Value.module -and -not $usedMappings.Contains($_.Key) })
if ($unused.Count) { throw "Mapping ledger entries do not match a directive: $($unused.Key -join ', ')" }
$invalid = @($rows | Where-Object Status -eq 'Invalid')
if ($invalid.Count) { throw "Invalid directive migration mapping(s):`n$(($invalid | ForEach-Object { "$($_.Module) $($_.SourcePath) directive $($_.DirectiveIndex): $($_.Notes)" }) -join "`n")" }
if ($FailOnUnresolved) {
    $incomplete = @($rows | Where-Object { $_.Status -notin @('Mapped', 'Deferred') })
    if ($incomplete.Count) { throw "$($incomplete.Count) non-deferred directive(s) remain unresolved or unreviewed candidates." }
}
if ($OutputPath) {
    $parent = Split-Path $OutputPath -Parent
    if ($parent -and -not (Test-Path -LiteralPath $parent)) { throw "Output directory does not exist: $parent" }
    switch ([IO.Path]::GetExtension($OutputPath).ToLowerInvariant()) {
        '.json' { ConvertTo-Json -InputObject @($rows) -Depth 8 | Set-Content -LiteralPath $OutputPath }
        '.csv' {
            $rows | Select-Object Module, SourcePath, DirectiveIndex, DirectiveLine, SourceSha256,
                @{ Name = 'Profiles'; Expression = { $_.Profiles -join '; ' } },
                Classification, Status, Implementation, ExistingCoverage, ModuleConfigurationEntries,
                V1SpecPath, V1SpecSha256, BetaSpecPath, BetaSpecSha256,
                @{ Name = 'V1Operations'; Expression = { $_.V1Operations -join '; ' } },
                @{ Name = 'BetaOperations'; Expression = { $_.BetaOperations -join '; ' } }, Notes, Directive |
                Export-Csv -LiteralPath $OutputPath -NoTypeInformation
        }
        default { throw 'OutputPath must end in .json or .csv.' }
    }
} elseif ($AsJson) { ConvertTo-Json -InputObject @($rows) -Depth 8 }
else { $rows }
