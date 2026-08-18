<#
.SYNOPSIS
Parity gate for the WrapperGenerator cmdlet generator.

.DESCRIPTION
See tools/WrapperGenerator/README.md ("How a cmdlet name is built" and "Build, run, test").

For every generated *.g.cs cmdlet file, reconstructs the HTTP method and URI from the
client.<BuilderExpression>.<Method>Async( call chain (CmdletEmitter.cs's templates; the
chain shape comes from CmdletNaming.BuildBuilderExpression), joins it against the
Method+Uri -> Command inventory in MgCommandMetadata.json, and reports whether the
emitted [Cmdlet(...)] name matches what the oracle says the published SDK calls that
operation.

A small set of published names are known AutoRest defects the generator deliberately
corrects instead of reproducing (tools/WrapperGenerator/docs/edge-cases/naming-edge-cases.md
is the catalog). Those are matched against the $deliberateCorrections table below and
reported as [CORRECTED] rather than [MISMATCH]; they do not fail the gate.

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
        # Kiota cast builder members (MicrosoftGraphUser, or GraphUser from the KiotaCompat
        # specs' "graph.user" form) cannot be translated back to the oracle's URI spelling
        # ("microsoft.graph.user"), so cast chains are unparseable here and get reported as
        # skipped at the call site until cast endpoints are supported end to end.
        if ($prop -match '^(MicrosoftGraph|Graph)[A-Z]') { return $null }
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

# Published names the generator deliberately corrects instead of reproducing. Each entry maps
# the shipped (wrong) command to the corrected one the generator emits, and must have a matching
# entry in tools/WrapperGenerator/docs/edge-cases/naming-edge-cases.md and a pinned naming test.
# The gate reports these as [CORRECTED] instead of [MISMATCH] and does not fail on them.
$deliberateCorrections = @{
    # AutoRest inflected the trailing /whois segment to "Whoi"; the other 28 whois-family
    # cmdlets (whoisRecords, whoisHistoryRecords) all keep "Whois".
    'Get-MgSecurityThreatIntelligenceHostWhoi'     = 'Get-MgSecurityThreatIntelligenceHostWhois'
    'Get-MgBetaSecurityThreatIntelligenceHostWhoi' = 'Get-MgBetaSecurityThreatIntelligenceHostWhois'
    # AutoRest truncated /places/{id}/checkIns at the preposition (the #912 defect class):
    # shipped ...PlaceCheck, while Get-MgPlaceCheckInCount keeps "In" intact.
    'Get-MgPlaceCheck'        = 'Get-MgPlaceCheckIn'
    'New-MgPlaceCheck'        = 'New-MgPlaceCheckIn'
    'Update-MgPlaceCheck'     = 'Update-MgPlaceCheckIn'
    'Remove-MgPlaceCheck'     = 'Remove-MgPlaceCheckIn'
    'Get-MgBetaPlaceCheck'    = 'Get-MgBetaPlaceCheckIn'
    'New-MgBetaPlaceCheck'    = 'New-MgBetaPlaceCheckIn'
    'Update-MgBetaPlaceCheck' = 'Update-MgBetaPlaceCheckIn'
    'Remove-MgBetaPlaceCheck' = 'Remove-MgBetaPlaceCheckIn'
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

# The emitter escapes spec-derived nouns for C# string literals (CmdletEmitter.EscapeLiteral),
# so the pattern accepts escaped sequences and the noun is unescaped after matching.
$cmdletAttrPattern = '\[Cmdlet\(Verbs\w+\.(\w+),\s*"((?:\\.|[^"\\])*)"'
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
$totalUnparseable = 0
$totalCorrected = 0

foreach ($module in $modules | Sort-Object Name) {
    $files = Get-ChildItem -Path $module.Path -Filter '*.g.cs' -File | Sort-Object Name
    $apiVersion = Get-ModuleApiVersion -ModulePath $module.Path
    $moduleJoinable = 0
    $moduleMatched = 0
    $moduleDispatchers = 0
    $moduleUnparseable = 0
    $moduleCorrected = 0
    $moduleSkips = @()
    $moduleCorrections = @()
    $moduleProblems = @()

    foreach ($file in $files) {
        $content = Get-Content -Path $file.FullName -Raw

        $attrMatch = [regex]::Match($content, $cmdletAttrPattern)
        if (-not $attrMatch.Success) {
            continue # not a cmdlet file (Shared.g.cs)
        }
        $verb = $attrMatch.Groups[1].Value
        $generatedNoun = [regex]::Unescape($attrMatch.Groups[2].Value)
        $publishedNoun = $generatedNoun -replace '_(List|Get)$', ''
        $generatedCommand = "$verb-$generatedNoun"
        $expectedCommand = "$verb-$publishedNoun"

        $callMatch = [regex]::Match($content, $callChainPattern)
        if (-not $callMatch.Success) {
            # Only a real dispatcher (forwards via InvokeScript) legitimately has no Graph
            # call. Anything else with no reconstructable call is a malformed emission and
            # must fail the gate instead of hiding in the dispatcher bucket.
            if ($content -match 'InvokeCommand\.InvokeScript') {
                $moduleDispatchers++
                continue # dispatcher: delegates to internal cmdlets, nothing to reconstruct here
            }
            $moduleJoinable++
            $moduleProblems += "  [NO CALL] $($file.Name): contains no reconstructable Graph call and is not a dispatcher - likely a malformed emission."
            continue
        }

        $builderExpr = $callMatch.Groups[1].Value
        $method = $callMatch.Groups[2].Value.ToUpperInvariant()
        $normalizedUri = ConvertTo-NormalizedGeneratedUri -BuilderExpression $builderExpr

        if (-not $normalizedUri) {
            # Known-unsupported shapes (OData cast chains) are reported but excluded from the
            # match ratio and do not fail the gate, mirroring how dispatchers are handled.
            $moduleUnparseable++
            $moduleSkips += "  [UNPARSEABLE] $($file.Name): builder expression '$builderExpr' contains an OData cast segment - cast endpoints aren't generated end to end yet, so there is nothing to verify."
            continue
        }

        $moduleJoinable++

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
            $oracleCommand = $candidates | Select-Object -First 1
            if ($deliberateCorrections[$oracleCommand] -eq $expectedCommand) {
                $moduleCorrected++
                $moduleCorrections += "  [CORRECTED] $($file.Name): oracle ships '$oracleCommand'; generator deliberately emits '$expectedCommand' (see tools/WrapperGenerator/docs/edge-cases/naming-edge-cases.md)."
            }
            else {
                $moduleProblems += "  [MISMATCH] $($file.Name): generated '$expectedCommand', oracle says '$oracleCommand' for $method $normalizedUri."
            }
        }
    }

    $status = if ($moduleJoinable -eq 0) { 'n/a' } else { "$moduleMatched of $moduleJoinable" }
    $dispatcherNote = if ($moduleDispatchers -gt 0) { " (+$moduleDispatchers dispatcher cmdlet(s), no direct call to verify)" } else { '' }
    $castNote = if ($moduleUnparseable -gt 0) { " (+$moduleUnparseable cast cmdlet(s) skipped, not generated end to end yet)" } else { '' }
    $correctedNote = if ($moduleCorrected -gt 0) { " (+$moduleCorrected deliberately corrected name(s))" } else { '' }
    $versionNote = if ($apiVersion) { " [$apiVersion]" } else { ' [ApiVersion unknown - searched all versions]' }
    Write-Host "$($module.Name)$($versionNote): $status cmdlets match the oracle$dispatcherNote$castNote$correctedNote"
    foreach ($line in $moduleSkips) { Write-Host $line -ForegroundColor DarkYellow }
    foreach ($line in $moduleCorrections) { Write-Host $line -ForegroundColor DarkCyan }
    foreach ($line in $moduleProblems) { Write-Host $line -ForegroundColor Yellow }

    $totalJoinable += $moduleJoinable
    $totalMatched += $moduleMatched
    $totalMismatches += $moduleProblems.Count
    $totalDispatchers += $moduleDispatchers
    $totalUnparseable += $moduleUnparseable
    $totalCorrected += $moduleCorrected
}

Write-Host ''
Write-Host "TOTAL: $totalMatched of $totalJoinable cmdlets match the oracle across $($modules.Count) module(s) (+$totalDispatchers dispatcher cmdlet(s) skipped, +$totalUnparseable cast cmdlet(s) skipped, +$totalCorrected deliberately corrected)."

if ($totalMismatches -gt 0) {
    exit 1
}
exit 0
