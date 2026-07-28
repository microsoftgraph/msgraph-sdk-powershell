<#
.SYNOPSIS
Parity gate for kiota's PowerShellWrapper generator.

.DESCRIPTION
See the kiota repo: src/Kiota.Builder/PowerShellWrapper/README.md, sections 4 and 6.

For every generated *.g.cs cmdlet file, reconstructs the HTTP method and URI from the
client.<BuilderExpression>.<Method>Async( call chain (CmdletEmitter.cs's templates; the
chain shape comes from CmdletNaming.BuildBuilderExpression), joins it against the
Method+Uri -> Command inventory in MgCommandMetadata.json, and reports whether the
emitted [Cmdlet(...)] name matches what the oracle says the published SDK calls that
operation.

Dispatcher cmdlets (the paired-GET public cmdlet that only forwards to its internal
_List/_Get siblings via InvokeCommand.InvokeScript - see CmdletEmitter.EmitGetDispatcher)
contain no direct Graph call, so there is nothing to reconstruct from their source; they
are reported separately per module and excluded from the match ratio. Their two internal
siblings do carry real calls and are what actually gets checked against the oracle.

Path parameter names are not exactly recoverable from the generated C#: CmdletNaming
.ExtractPathParamNames PascalCases each hyphen-chunk of a raw "{some-id}" segment and
concatenates with no separator kept, so e.g. "conditionalAccessPolicy-id" and a
hypothetical "conditionalAccess-policy-id" would both produce the indexer name
"ConditionalAccessPolicyId" - the hyphen position inside a multi-word param name is lost.
Fixed path segments do not have this problem (BuildBuilderExpression only ever uppercases
the first character of a whole segment, which is exactly reversible). So this script
compares fixed segments exactly and normalizes every path parameter, on both the
generated and the oracle side, to a single "{param}" placeholder before joining.

The oracle carries both v1.0 and beta rows, and many operations have the identical
Method+URI in both (only the Command prefix differs: Get-MgUserMessage vs
Get-MgBetaUserMessage) - joining on Method+URI alone is ambiguous. Each module's
kiota-lock.json (written next to its *.g.cs files) records the descriptionLocation the
module was generated from, e.g. "../../openApiDocs/v1.0/Mail.yml"; this script reads the
v1.0/beta segment out of that path and scopes the oracle lookup to just that ApiVersion.
A module folder with no kiota-lock.json (or an unrecognized descriptionLocation) falls
back to searching every ApiVersion and reports a real ambiguity if more than one distinct
command turns up.

.PARAMETER GeneratedPath
A folder of generated *.g.cs files for one module, or a folder containing one
subfolder per module (each with its own *.g.cs files) - e.g. the repo's generated/.

.PARAMETER OraclePath
Path to MgCommandMetadata.json.

.EXAMPLE
.\tools\Compare-WrapperCmdletNames.ps1
.\tools\Compare-WrapperCmdletNames.ps1 -GeneratedPath generated\Mail
#>
[CmdletBinding()]
param(
    [string]$GeneratedPath = (Join-Path $PSScriptRoot '..\generated'),
    [string]$OraclePath = (Join-Path $PSScriptRoot '..\src\Authentication\Authentication\custom\common\MgCommandMetadata.json')
)

$ErrorActionPreference = 'Stop'

if (-not (Test-Path $GeneratedPath)) {
    Write-Error "Generated path not found: $GeneratedPath"
    exit 1
}
if (-not (Test-Path $OraclePath)) {
    Write-Error "Oracle file not found: $OraclePath"
    exit 1
}

# One folder full of *.g.cs directly, or one folder per module. Handles both so the script
# works whether -GeneratedPath points at generated/ or at generated/Mail directly.
function Get-WrapperModuleFolders {
    param([string]$Root)

    $rootItem = Get-Item -Path $Root
    $direct = Get-ChildItem -Path $rootItem.FullName -Filter '*.g.cs' -File -ErrorAction SilentlyContinue
    if ($direct) {
        return @([pscustomobject]@{ Name = $rootItem.Name; Path = $rootItem.FullName })
    }

    Get-ChildItem -Path $rootItem.FullName -Directory -ErrorAction SilentlyContinue | ForEach-Object {
        if (Get-ChildItem -Path $_.FullName -Filter '*.g.cs' -File -ErrorAction SilentlyContinue) {
            [pscustomobject]@{ Name = $_.Name; Path = $_.FullName }
        }
    }
}

function ConvertTo-NormalizedOracleUri {
    param([string]$Uri)
    $parts = $Uri.Trim('/') -split '/'
    $norm = foreach ($p in $parts) {
        if ($p -match '^\{.*\}$') { '{param}' } else { $p }
    }
    '/' + ($norm -join '/')
}

function ConvertTo-NormalizedGeneratedUri {
    param([string]$BuilderExpression)
    $segments = @()
    foreach ($token in ($BuilderExpression -split '\.')) {
        if ($token -notmatch '^([A-Za-z0-9]+)(\[([A-Za-z0-9]+)\])?$') {
            return $null
        }
        $prop = $Matches[1]
        $segments += ($prop.Substring(0, 1).ToLowerInvariant() + $prop.Substring(1))
        if ($Matches[3]) { $segments += '{param}' }
    }
    '/' + ($segments -join '/')
}

# Reads the v1.0/beta segment out of a module's kiota-lock.json ("descriptionLocation":
# "../../openApiDocs/v1.0/Mail.yml"), so the oracle join can be scoped to the ApiVersion
# the module was actually generated from instead of guessing.
function Get-ModuleApiVersion {
    param([string]$ModulePath)
    $lockPath = Join-Path $ModulePath 'kiota-lock.json'
    if (-not (Test-Path $lockPath)) { return $null }
    $loc = (Get-Content -Path $lockPath -Raw | ConvertFrom-Json).descriptionLocation
    if (-not $loc) { return $null }
    if ($loc -match '(^|[\\/])v1\.0([\\/]|$)') { return 'v1.0' }
    if ($loc -match '(^|[\\/])beta([\\/]|$)') { return 'beta' }
    return $null
}

Write-Host "Loading oracle from $OraclePath ..."
$oracle = Get-Content -Path $OraclePath -Raw | ConvertFrom-Json

$oracleIndex = @{}
foreach ($entry in $oracle) {
    if (-not $entry.Method -or -not $entry.Uri -or -not $entry.Command -or -not $entry.ApiVersion) { continue }
    $key = "$($entry.ApiVersion)|$($entry.Method)|$(ConvertTo-NormalizedOracleUri $entry.Uri)"
    if (-not $oracleIndex.ContainsKey($key)) {
        $oracleIndex[$key] = [System.Collections.Generic.HashSet[string]]::new()
    }
    [void]$oracleIndex[$key].Add($entry.Command)
}
Write-Host "Indexed $($oracle.Count) oracle entries into $($oracleIndex.Count) ApiVersion+Method+URI keys."
Write-Host ''

# Looks up one Method+URI, scoped to $ApiVersion when known; falls back to searching every
# ApiVersion (and merging what turns up) when the module's own version couldn't be
# determined, so an unresolvable version shows up as a real ambiguity, not a false match.
function Find-OracleCommands {
    param([hashtable]$Index, [string]$ApiVersion, [string]$Method, [string]$NormalizedUri)
    if ($ApiVersion) {
        return $Index["$ApiVersion|$Method|$NormalizedUri"]
    }
    $merged = [System.Collections.Generic.HashSet[string]]::new()
    foreach ($v in 'v1.0', 'beta') {
        $found = $Index["$v|$Method|$NormalizedUri"]
        if ($found) { [void]$merged.UnionWith($found) }
    }
    if ($merged.Count -eq 0) { return $null }
    return $merged
}

$cmdletAttrPattern = '\[Cmdlet\(Verbs\w+\.(\w+),\s*"([^"]+)"'
$callChainPattern = 'client\.([A-Za-z0-9_.\[\]]+)\.(Get|Post|Patch|Put|Delete)Async\('

$modules = @(Get-WrapperModuleFolders -Root $GeneratedPath)
if ($modules.Count -eq 0) {
    Write-Error "No *.g.cs files found under $GeneratedPath"
    exit 1
}

$totalJoinable = 0
$totalMatched = 0
$totalMismatches = 0
$totalDispatchers = 0

foreach ($module in $modules | Sort-Object Name) {
    $files = Get-ChildItem -Path $module.Path -Filter '*.g.cs' -File | Sort-Object Name
    $apiVersion = Get-ModuleApiVersion -ModulePath $module.Path
    $moduleJoinable = 0
    $moduleMatched = 0
    $moduleDispatchers = 0
    $moduleProblems = @()

    foreach ($file in $files) {
        $content = Get-Content -Path $file.FullName -Raw

        $attrMatch = [regex]::Match($content, $cmdletAttrPattern)
        if (-not $attrMatch.Success) {
            continue # not a cmdlet file (Shared.g.cs)
        }
        $verb = $attrMatch.Groups[1].Value
        $generatedNoun = $attrMatch.Groups[2].Value
        $publishedNoun = $generatedNoun -replace '_(List|Get)$', ''
        $generatedCommand = "$verb-$generatedNoun"
        $expectedCommand = "$verb-$publishedNoun"

        $callMatch = [regex]::Match($content, $callChainPattern)
        if (-not $callMatch.Success) {
            $moduleDispatchers++
            continue # dispatcher: delegates to internal cmdlets, nothing to reconstruct here
        }

        $builderExpr = $callMatch.Groups[1].Value
        $method = $callMatch.Groups[2].Value.ToUpperInvariant()
        $normalizedUri = ConvertTo-NormalizedGeneratedUri -BuilderExpression $builderExpr

        $moduleJoinable++

        if (-not $normalizedUri) {
            $moduleProblems += "  [UNPARSEABLE] $($file.Name): builder expression '$builderExpr' has a segment this script doesn't recognize (e.g. an OData cast segment - see README section 7, cast endpoints aren't generated yet)."
            continue
        }

        $candidates = Find-OracleCommands -Index $oracleIndex -ApiVersion $apiVersion -Method $method -NormalizedUri $normalizedUri

        if (-not $candidates -or $candidates.Count -eq 0) {
            $moduleProblems += "  [NO ORACLE ENTRY] $($file.Name): '$generatedCommand' -> reconstructed $method $normalizedUri, no oracle row for that Method+URI."
        }
        elseif ($candidates.Count -gt 1) {
            $moduleProblems += "  [AMBIGUOUS] $($file.Name): $method $normalizedUri matches multiple oracle commands: $($candidates -join ', ')."
        }
        elseif ($candidates.Contains($expectedCommand)) {
            $moduleMatched++
        }
        else {
            $moduleProblems += "  [MISMATCH] $($file.Name): generated '$expectedCommand', oracle says '$($candidates | Select-Object -First 1)' for $method $normalizedUri."
        }
    }

    $status = if ($moduleJoinable -eq 0) { 'n/a' } else { "$moduleMatched of $moduleJoinable" }
    $dispatcherNote = if ($moduleDispatchers -gt 0) { " (+$moduleDispatchers dispatcher cmdlet(s), no direct call to verify)" } else { '' }
    $versionNote = if ($apiVersion) { " [$apiVersion]" } else { ' [ApiVersion unknown - searched all versions]' }
    Write-Host "$($module.Name)$($versionNote): $status cmdlets match the oracle$dispatcherNote"
    foreach ($line in $moduleProblems) { Write-Host $line -ForegroundColor Yellow }

    $totalJoinable += $moduleJoinable
    $totalMatched += $moduleMatched
    $totalMismatches += $moduleProblems.Count
    $totalDispatchers += $moduleDispatchers
}

Write-Host ''
Write-Host "TOTAL: $totalMatched of $totalJoinable cmdlets match the oracle across $($modules.Count) module(s) (+$totalDispatchers dispatcher cmdlet(s) skipped)."

if ($totalMismatches -gt 0) {
    exit 1
}
exit 0
