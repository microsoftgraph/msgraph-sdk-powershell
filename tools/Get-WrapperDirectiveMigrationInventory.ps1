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
$profiles = @('v1.0', 'beta')
$specCache = @{}

function Get-SpecFingerprint([string]$Path) {
    [Convert]::ToHexString([Security.Cryptography.SHA256]::HashData(
        [Text.Encoding]::UTF8.GetBytes([IO.File]::ReadAllText($Path).Replace("`r`n", "`n")))).ToLowerInvariant()
}

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

function ConvertFrom-SpecScalar([string]$Scalar, [string]$Location) {
    if ($Scalar.StartsWith("'")) {
        if ($Scalar -notmatch "^'(?<value>(?:[^']|'')*)'$") { throw "Invalid single-quoted YAML scalar at ${Location}: $Scalar" }
        return $Matches.value.Replace("''", "'")
    }
    if ($Scalar.StartsWith('"')) {
        if ($Scalar -notmatch '^"(?<value>(?:[^"\\]|\\.)*)"$') { throw "Invalid double-quoted YAML scalar at ${Location}: $Scalar" }
        $value = $Matches.value
        $escapes = [hashtable]::new([StringComparer]::Ordinal)
        foreach ($pair in @{ '0' = "`0"; 'a' = "`a"; 'b' = "`b"; 't' = "`t"; 'n' = "`n"; 'v' = "`v"; 'f' = "`f"; 'r' = "`r"
            'e' = [string][char]27; ' ' = ' '; '"' = '"'; '/' = '/'; '\' = '\'; '_' = [string][char]0xA0 }.GetEnumerator()) { $escapes[$pair.Key] = $pair.Value }
        $escapes['N'] = [string][char]0x85; $escapes['L'] = [string][char]0x2028; $escapes['P'] = [string][char]0x2029
        return [regex]::Replace($value, '\\(?<escape>x[0-9a-fA-F]{2}|u[0-9a-fA-F]{4}|U[0-9a-fA-F]{8}|.)', {
            param($match)
            $escape = $match.Groups['escape'].Value
            if ($escape.Length -gt 1) { return [char]::ConvertFromUtf32([Convert]::ToInt32($escape.Substring(1), 16)) }
            if (-not $escapes.ContainsKey($escape)) { throw "Unsupported YAML escape '\$escape' at $Location" }
            $escapes[$escape]
        })
    }
    if (-not $Scalar -or $Scalar[0] -in @('|', '>', '&', '*', '[', '{')) { throw "Unsupported YAML scalar at ${Location}: $Scalar" }
    ($Scalar -replace '\s+#.*$', '').TrimEnd()
}

function Get-OperationRouteKey($Operation) {
    $method = "$($Operation.Method)".ToUpperInvariant()
    "$method $([regex]::Replace("$($Operation.Path)", '\{[^}]*\}', '{}'))"
}

function Get-Spec([string]$ModuleName, [string]$Profile, [switch]$AutoRest) {
    $relative = if ($AutoRest) { "openApiDocs\$Profile\$ModuleName.yml" } else { "openApiDocs_KiotaCompat\$Profile\$ModuleName.yml" }
    if ($specCache.ContainsKey($relative)) { return $specCache[$relative] }
    $path = Join-Path $repoRoot $relative
    $operations = [Collections.Generic.List[object]]::new()
    $exists = Test-Path -LiteralPath $path -PathType Leaf
    if ($exists) {
        $inPaths = $false
        $currentPath = $null
        $currentMethod = $null
        $currentOperation = $null
        $operationType = ''
        $identities = [Collections.Generic.HashSet[string]]::new([StringComparer]::Ordinal)
        $lineNumber = 0
        foreach ($line in Get-Content -LiteralPath $path) {
            $lineNumber++
            if ($line -match '^\s*(#.*)?$') { continue }
            $boundary = $line -match '^\S|^  \S|^    \S'
            if ($boundary -and $currentMethod) { throw "Operation has no operationId at ${relative}:${lineNumber}: $currentMethod $currentPath" }
            if ($boundary) { $currentOperation = $null; $operationType = '' }
            if ($line -match '^\S') {
                $inPaths = $line -match '^paths:\s*(#.*)?$'
                $currentPath = $null
                continue
            }
            if (-not $inPaths) { continue }
            if ($line -match '^  \S') {
                $currentPath = $null
                if ($line -notmatch '^  (?<key>''(?:[^'']|'''')*''|"(?:[^"\\]|\\.)*"|/.*?):\s*(?:#.*)?$') {
                    throw "Unsupported or malformed YAML path key at ${relative}:${lineNumber}: $line"
                }
                $currentPath = ConvertFrom-SpecScalar $Matches.key "${relative}:${lineNumber}"
                if (-not $currentPath.StartsWith('/')) { throw "Invalid OpenAPI path at ${relative}:${lineNumber}: $currentPath" }
            } elseif ($currentPath -and $line -match '^    (?<key>''(?:[^'']|'''')*''|"(?:[^"\\]|\\.)*"|[^\s:]+):(?<value>.*)$') {
                $value = $Matches.value
                $field = ConvertFrom-SpecScalar $Matches.key "${relative}:${lineNumber}"
                if ($field -in @('get', 'post', 'put', 'patch', 'delete', 'head', 'options', 'trace')) {
                    if ($value -notmatch '^\s*(?:#.*)?$') { throw "Unsupported inline operation at ${relative}:${lineNumber}: $line" }
                    $currentMethod = $field.ToUpperInvariant()
                } elseif ($field -eq '$ref') {
                    throw "Referenced path item requires explicit inventory support at ${relative}:${lineNumber}."
                }
            } elseif ($currentPath -and $currentMethod -and $line -match '^      operationId:\s*(?<id>.+?)\s*$') {
                $idScalar = $Matches.id -replace '(?<=(?:''|"))\s+#.*$', ''
                $operationId = ConvertFrom-SpecScalar $idScalar "${relative}:${lineNumber}"
                if (-not $operationId -or -not $identities.Add("$currentMethod $currentPath")) { throw "Empty operationId or duplicate operation at ${relative}:${lineNumber}: $currentMethod $currentPath" }
                $currentOperation = [pscustomobject]@{ Method = $currentMethod; Path = $currentPath; OperationId = $operationId; OperationType = $operationType }
                $operations.Add($currentOperation)
                $currentMethod = $null
            } elseif (($currentOperation -or $currentMethod) -and $line -match '^      x-ms-docs-operation-type:\s*(?<kind>.+?)\s*$') {
                $operationType = ConvertFrom-SpecScalar $Matches.kind "${relative}:${lineNumber}"
                if ($currentOperation) { $currentOperation.OperationType = $operationType }
            }
        }
        if ($currentMethod) { throw "Operation has no operationId at end of ${relative}: $currentMethod $currentPath" }
    }
    $routeIndex = [Collections.Generic.Dictionary[string, object]]::new([StringComparer]::Ordinal)
    foreach ($operation in $operations) {
        $key = Get-OperationRouteKey $operation
        if (-not $routeIndex.ContainsKey($key)) { $routeIndex[$key] = [Collections.Generic.List[object]]::new() }
        $routeIndex[$key].Add($operation)
    }
    $specCache[$relative] = [pscustomobject]@{
        Path = $relative; Exists = $exists
        # Git checkouts may use CRLF or LF; review identity must not depend on the host.
        Sha256 = if ($exists) { Get-SpecFingerprint $path } else { '' }
        Operations = @($operations)
        RouteIndex = $routeIndex
    }
    $specCache[$relative]
}

function Get-OperationIdPattern($Directive) {
    if ($Directive.Classification -eq 'OperationIdSuppression') {
        return ([regex]::Match($Directive.Text, '(?m)remove-path-by-operation:\s*(?<pattern>.+?)\s*$')).Groups['pattern'].Value.Trim("'", '"')
    }
    # These literal markers were embedded in old operation IDs. This is source review
    # evidence, not an attempt to simulate AutoRest's generated subject/variant engine.
    if ($Directive.Classification -eq 'SubjectRename') {
        $compact = ($Directive.Text -replace '\s+', ' ').Trim()
        foreach ($pair in @{ B = 'By'; W = 'With'; A = 'At'; F = 'For'; O = 'Of'; R = 'Or' }.GetEnumerator()) {
            $marker = "Graph$($pair.Key)Pre"
            if ($compact -ceq ('- where: subject: ^(\w*[a-z])' + $marker + '(\w*)$ set: subject: $1' + $pair.Value + '$2')) { return $marker }
        }
    }
}

function Get-EquivalentOperations($Operation, $Spec) {
    $key = Get-OperationRouteKey $Operation
    if ($Spec.RouteIndex.ContainsKey($key)) { @($Spec.RouteIndex[$key]) }
    $callPattern = if ($Operation.OperationType -ceq 'action' -and $Operation.Method -ceq 'POST') {
        '/microsoft\.graph\.([A-Za-z_][A-Za-z0-9_]*)$'
    } elseif ($Operation.OperationType -ceq 'function' -and $Operation.Method -ceq 'GET') {
        '/microsoft\.graph\.([A-Za-z_][A-Za-z0-9_]*\(.*\))$'
    }
    if ($callPattern -and $Operation.Path -cmatch $callPattern) {
        $unqualifiedPath = $Operation.Path -creplace $callPattern, '/$1'
        $key = Get-OperationRouteKey @{ Method = $Operation.Method; Path = $unqualifiedPath }
        if ($Spec.RouteIndex.ContainsKey($key)) {
            @($Spec.RouteIndex[$key] | Where-Object { $_.OperationType -ceq $Operation.OperationType })
        }
    }
}

function Test-SameOperations([object[]]$Left, [object[]]$Right) {
    ((@(Format-Operations $Left) -join "`n") -ceq (@(Format-Operations $Right) -join "`n"))
}

function Format-Operations([object[]]$Operations) {
    @($Operations | Sort-Object Path, Method -CaseSensitive | ForEach-Object { "$($_.Method) $($_.Path) [$($_.OperationId)]" })
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
            $sourceSpecs = @{}
            $sourceCandidates = @{ 'v1.0' = @(); 'beta' = @() }
            $equivalentCandidates = @{ 'v1.0' = @(); 'beta' = @() }
            $selectorError = ''
            $pattern = Get-OperationIdPattern $directive
            if ($null -ne $pattern) {
                try {
                    $regex = [regex]::new(($pattern -replace '\\_', '_'), [Text.RegularExpressions.RegexOptions]::IgnoreCase -bor [Text.RegularExpressions.RegexOptions]::Multiline)
                } catch {
                    $selectorError = "Operation-ID expression requires manual review: $($_.Exception.Message)"
                    $notes = $selectorError
                }
                if (-not $selectorError) {
                    foreach ($profile in $sources[$source]) {
                        $candidateMatches[$profile] = @($specs[$profile].Operations | Where-Object { $regex.IsMatch($_.OperationId) })
                        $sourceSpecs[$profile] = Get-Spec $moduleName $profile -AutoRest
                        $sourceCandidates[$profile] = @($sourceSpecs[$profile].Operations | Where-Object { $regex.IsMatch($_.OperationId) })
                        $equivalentCandidates[$profile] = @($sourceCandidates[$profile] | ForEach-Object {
                            Get-EquivalentOperations $_ $specs[$profile]
                        })
                    }
                    $profileMatches = $candidateMatches.Clone()
                    foreach ($profile in $sources[$source]) {
                        $profileMatches[$profile] = @($profileMatches[$profile] + $equivalentCandidates[$profile] |
                            Sort-Object Method, Path, OperationId -CaseSensitive -Unique)
                    }
                    if ($profileMatches['v1.0'].Count + $profileMatches.beta.Count) {
                        $status = 'Resolved'; $implementation = 'Candidate'
                        $notes = 'Current-ID and equivalent legacy-source routes are candidates, not reviewed migration coverage.'
                    }
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
                    if (@($expectedOperations | Group-Object method, path -CaseSensitive | Where-Object Count -gt 1).Count) { $errors.Add("$profile contains duplicate operation mappings") }
                    if ($sources[$source] -notcontains $profile) {
                        if ($profileMap.notApplicable -ne $true -or $expectedOperations.Count -or $profileMap.absenceExpected) { $errors.Add("$profile must declare notApplicable for a profile-local source") }
                        continue
                    }
                    if ($profileMap.notApplicable) { $errors.Add("$profile source applies; cannot declare notApplicable") }
                    if (-not $spec.Exists) { $errors.Add("$profile specification missing: $($spec.Path)"); continue }
                    if ($profileMap.specPath -and "$($profileMap.specPath)".Replace('/', '\') -cne $spec.Path) { $errors.Add("$profile specPath changed") }
                    if ($profileMap.specSha256 -and $profileMap.specSha256 -cne $spec.Sha256) { $errors.Add("$profile specification fingerprint changed") }
                    if (($FailOnUnresolved -or $profileMap.absenceExpected) -and (-not $profileMap.specPath -or -not $profileMap.specSha256)) { $errors.Add("$profile requires actual specPath and specSha256") }
                    $sourceSpecMap = $profileMap.sourceSpec
                    $matchedOriginals = @($sourceCandidates[$profile] | Where-Object {
                            $original = $_
                            @($candidateMatches[$profile] | Where-Object {
                                $_.Method -ceq $original.Method -and $_.Path -ceq $original.Path -and $_.OperationId -ceq $original.OperationId
                            }).Count -eq 1
                        })
                    $requiresTranslation = $null -ne $pattern -and (
                        $directive.Classification -ne 'OperationIdSuppression' -or -not $candidateMatches[$profile].Count -or
                        -not (Test-SameOperations $sourceCandidates[$profile] $matchedOriginals))
                    if ($requiresTranslation -and -not $sourceSpecMap -and
                        ($FailOnUnresolved -or $equivalentCandidates[$profile].Count)) {
                        $errors.Add("$profile requires reviewed sourceSpec translation; zero current-ID matches do not prove API absence")
                    }
                    foreach ($expected in $expectedOperations) {
                        $found = @($spec.Operations | Where-Object { $_.Method -ceq "$($expected.method)".ToUpperInvariant() -and $_.Path -ceq "$($expected.path)" })
                        if ($found.Count -ne 1) { $errors.Add("$profile $($expected.method) $($expected.path) matched $($found.Count) operations"); continue }
                        if (($FailOnUnresolved -or $expected.operationId -or $sourceSpecMap) -and $found[0].OperationId -cne "$($expected.operationId)") { $errors.Add("$profile operationId missing or changed: $($expected.path)") }
                        $profileMatches[$profile] += $found[0]
                    }
                    if ($expectedOperations.Count -and $profileMap.absenceExpected) { $errors.Add("$profile cannot map operations and declare absence") }
                    if (-not $expectedOperations.Count -and ($profileMap.absenceExpected -ne $true -or -not "$($profileMap.absenceEvidence)".Trim())) { $errors.Add("$profile empty mapping requires reviewed absenceExpected and absenceEvidence") }
                    foreach ($absent in @($profileMap.absentOperations | Where-Object { $null -ne $_ })) {
                        if (-not $absent.method -or -not $absent.path -or -not $absent.operationId) { $errors.Add("$profile absent operation requires method/path/operationId"); continue }
                        if (@($spec.Operations | Where-Object { ($_.Method -eq $absent.method -and $_.Path -ceq $absent.path) -or $_.OperationId -ceq $absent.operationId }).Count) { $errors.Add("$profile reviewed absent operation is present: $($absent.path)") }
                    }
                    if ($sourceSpecMap) {
                        if ($null -eq $pattern) { $errors.Add("$profile sourceSpec translation is supported only for operation-ID suppressions and literal preposition renames"); continue }
                        $originalSpec = $sourceSpecs[$profile]
                        if (-not $originalSpec.Exists) { $errors.Add("$profile original specification missing: $($originalSpec.Path)"); continue }
                        if ("$($sourceSpecMap.specPath)".Replace('/', '\') -cne $originalSpec.Path -or $sourceSpecMap.specSha256 -cne $originalSpec.Sha256) {
                            $errors.Add("$profile original specification identity missing or changed")
                        }
                        if ($mapping.reviewed -ne $true -or $mapping.sourceSha256 -cne $directive.SourceSha256 -or
                            $profileMap.specSha256 -cne $spec.Sha256 -or "$($profileMap.specPath)".Replace('/', '\') -cne $spec.Path) {
                            $errors.Add("$profile translation requires reviewed source and current specification fingerprints")
                        }
                        $originals = @($sourceSpecMap.operations | Where-Object { $null -ne $_ })
                        if ($sourceSpecMap.operations -isnot [array]) { $errors.Add("$profile sourceSpec requires an explicit operations list, including when empty") }
                        if ($profileMap.operations -isnot [array]) { $errors.Add("$profile translation requires an explicit target operations list, including when empty") }
                        if (-not (Test-SameOperations $sourceCandidates[$profile] $originals)) {
                            $errors.Add("$profile sourceSpec operations must cover exactly the original selector candidates")
                        }
                        $translated = [Collections.Generic.List[object]]::new()
                        foreach ($original in $sourceCandidates[$profile]) {
                            $equivalents = @(Get-EquivalentOperations $original $spec)
                            $absences = @($profileMap.absentOperations | Where-Object {
                                $_.method -ceq $original.Method -and $_.path -ceq $original.Path -and $_.operationId -ceq $original.OperationId
                            })
                            if ($equivalents.Count -gt 1) { $errors.Add("$profile ambiguous equivalent route for $($original.Method) $($original.Path)") }
                            elseif ($equivalents.Count -eq 1) {
                                $translated.Add($equivalents[0])
                                if ($absences.Count) { $errors.Add("$profile false source absence: equivalent route still exists for $($original.OperationId)") }
                            } elseif ($absences.Count -ne 1 -or -not "$($absences[0].absenceEvidence)".Trim()) {
                                $errors.Add("$profile removed source operation requires exact absentOperations identity and absenceEvidence: $($original.OperationId)")
                            }
                        }
                        foreach ($absent in @($profileMap.absentOperations | Where-Object { $null -ne $_ })) {
                            if (@($sourceCandidates[$profile] | Where-Object {
                                $_.Method -ceq $absent.method -and $_.Path -ceq $absent.path -and $_.OperationId -ceq $absent.operationId
                            }).Count -ne 1) { $errors.Add("$profile absentOperations must identify original selector candidates") }
                        }
                        $required = @(@($translated) + $candidateMatches[$profile] | Sort-Object Method, Path, OperationId -CaseSensitive -Unique)
                        if (-not (Test-SameOperations $required $profileMatches[$profile])) {
                            $errors.Add("$profile translated mapping must cover exactly equivalent method/path targets and current selector matches")
                        }
                    } elseif ($directive.Classification -eq 'OperationIdSuppression') {
                        if (-not (Test-SameOperations $candidateMatches[$profile] $profileMatches[$profile])) { $errors.Add("$profile mapping does not cover exactly the operation-ID selector matches") }
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
                V1SourceSpecPath = $sourceSpecs['v1.0'].Path; V1SourceSpecSha256 = $sourceSpecs['v1.0'].Sha256
                BetaSourceSpecPath = $sourceSpecs.beta.Path; BetaSourceSpecSha256 = $sourceSpecs.beta.Sha256
                V1SourceOperations = @(Format-Operations $sourceCandidates['v1.0'])
                BetaSourceOperations = @(Format-Operations $sourceCandidates.beta)
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
                V1SourceSpecPath, V1SourceSpecSha256, BetaSourceSpecPath, BetaSourceSpecSha256,
                @{ Name = 'V1SourceOperations'; Expression = { $_.V1SourceOperations -join '; ' } },
                @{ Name = 'BetaSourceOperations'; Expression = { $_.BetaSourceOperations -join '; ' } },
                @{ Name = 'V1Operations'; Expression = { $_.V1Operations -join '; ' } },
                @{ Name = 'BetaOperations'; Expression = { $_.BetaOperations -join '; ' } }, Notes, Directive |
                Export-Csv -LiteralPath $OutputPath -NoTypeInformation
        }
        default { throw 'OutputPath must end in .json or .csv.' }
    }
} elseif ($AsJson) { ConvertTo-Json -InputObject @($rows) -Depth 8 }
else { $rows }
