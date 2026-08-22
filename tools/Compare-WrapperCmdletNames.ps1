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
    [string]$OraclePath = (Join-Path $PSScriptRoot '..\src\Authentication\Authentication\custom\common\MgCommandMetadata.json'),
    # Machine-readable copy of every per-file disposition, so downstream tooling (the parity
    # derivation) consumes this gate's oracle join instead of re-implementing it and drifting.
    [string]$OutLedger
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

# Reads the v1.0/beta segment out of a module's kiota-lock.json ("descriptionLocation":
# "../../openApiDocs/v1.0/Mail.yml"), so the oracle join can be scoped to the ApiVersion
# the module was actually generated from instead of guessing.
# The [GraphRoute] attribute the generator stamps on every emitted cmdlet, read from the module's
# COMPILED assembly rather than from the source text. The route is the operation's identity exactly
# as the spec declares it, so the oracle join needs no reconstruction: deriving the route from the
# builder expression is lossy for a parameterized function (the member keeps the argument names but
# not the OData argument syntax) and wrong for a namespace-qualified action (kiota keeps the
# qualifier, the route does not) — which is why those two shapes could not be verified at all.
function Get-GraphRouteMap {
    param([Parameter(Mandatory)][string]$CmdletsPath, [string]$BuildConfiguration = 'Release')

    # The target-framework segment is deliberately not named: the projects declare their TFM in
    # tools/Templates/*.csproj.template, and a gate that hard-codes the folder goes silently blind
    # the day the projects retarget - it did exactly that when net10.0 became netstandard2.0.
    $binDir = Join-Path (Split-Path $CmdletsPath -Parent) "bin/$BuildConfiguration"
    if (-not (Test-Path $binDir)) { return $null }
    # Exclude the shared runtime and client assemblies, which also match the wrapper prefix:
    # the runtime dll sorts alphabetically before module names S..U, so picking "first match"
    # without this filter handed those modules an assembly with no cmdlets in it.
    $dll = Get-ChildItem -Path $binDir -Recurse -Filter 'Microsoft.Graph.Wrapper.*.dll' -File -ErrorAction SilentlyContinue |
        Where-Object { $_.Name -notlike '*.Client.dll' -and $_.Name -ne 'Microsoft.Graph.Wrapper.Runtime.dll' } |
        Select-Object -First 1
    if (-not $dll) { return $null }

    # The wrapper bins deliberately carry no kiota assemblies (PruneModuleBin in the module
    # template): at run time the installed Microsoft.Graph.Authentication serves them through
    # its AssemblyResolve hook, and this gate needs the same hook for the same reason - a cmdlet
    # property typed as the kiota Date/Time structs is a value-type field the loader resolves
    # eagerly at type load, and without the hook GetTypes() drops exactly those cmdlets from the
    # route map, silently deflating the matched count.
    Import-Module Microsoft.Graph.Authentication -ErrorAction Stop
    $assembly = [System.Reflection.Assembly]::LoadFrom($dll.FullName)
    # The cmdlet classes derive from PSCmdlet, so a host without the PowerShell SDK loaded cannot
    # realise them; the partial list the exception carries is the usable result.
    try { $types = $assembly.GetTypes() }
    catch [System.Reflection.ReflectionTypeLoadException] { $types = $_.Exception.Types | Where-Object { $_ } }

    $map = @{}
    foreach ($type in $types) {
        $attr = $type.GetCustomAttributesData() | Where-Object { $_.AttributeType.Name -eq 'GraphRouteAttribute' }
        if ($attr) {
            $map[$type.Name] = [pscustomobject]@{
                Method = [string]$attr.ConstructorArguments[0].Value
                Path   = [string]$attr.ConstructorArguments[1].Value
            }
        }
    }
    return $map
}

# The route as the oracle spells it. Two differences are systematic: the oracle drops a cast or
# namespace qualifier from a segment ("graph.room" and "microsoft.graph.security.moveAlerts" ship
# as "room" and "moveAlerts"), and it records a zero-argument function without its parentheses.
function ConvertTo-OracleJoinKey {
    param([Parameter(Mandatory)][string]$Path)

    $withoutEmptyArgs = $Path -replace '\(\)', ''
    $unqualified = ($withoutEmptyArgs -split '/' | ForEach-Object {
        if ($_ -match '^(microsoft\.)?graph\.') { ($_ -split '\.')[-1] } else { $_ }
    }) -join '/'
    ConvertTo-NormalizedOracleUri -Uri $unqualified
}

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

    # A media download is reached by two spellings — the OData /$value segment and a literal
    # /content segment — and the oracle does not always use the one the spec declares. Both are
    # tried so neither shape silently reads as "the SDK ships nothing for this route".
    $candidates = @($NormalizedUri)
    if ($NormalizedUri.Contains('$value')) { $candidates += $NormalizedUri.Replace('$value', 'content') }

    foreach ($uri in $candidates) {
        if ($ApiVersion) {
            $hit = $Index["$ApiVersion|$Method|$uri"]
            if ($hit) { return $hit }
            continue
        }
        $merged = [System.Collections.Generic.HashSet[string]]::new()
        foreach ($v in 'v1.0', 'beta') {
            $found = $Index["$v|$Method|$uri"]
            if ($found) { [void]$merged.UnionWith($found) }
        }
        if ($merged.Count -gt 0) { return $merged }
    }
    return $null
}

# The emitter escapes spec-derived nouns for C# string literals (CmdletEmitter.EscapeLiteral),
# so the pattern accepts escaped sequences and the noun is unescaped after matching.
$cmdletAttrPattern = '\[Cmdlet\(Verbs\w+\.(\w+),\s*"((?:\\.|[^"\\])*)"'

$modules = @(Get-WrapperModuleFolders -Root $GeneratedPath)
if ($modules.Count -eq 0) {
    Write-Error "No *.g.cs files found under $GeneratedPath"
    exit 1
}

$ledger = [System.Collections.Generic.List[object]]::new()
function Add-LedgerRow {
    param($Module, $File, $ApiVersion, $Command, $Method, $Uri, $Disposition, $OracleCommands)
    $ledger.Add([pscustomobject]@{
        Module = $Module; File = $File; ApiVersion = $ApiVersion; Command = $Command
        Method = $Method; Uri = $Uri; Disposition = $Disposition
        OracleCommands = (@($OracleCommands) -join ';')
    })
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

    # Ground truth comes from the compiled assembly. Without it there is nothing to verify against,
    # and a gate that quietly falls back to guessing the route is how 1,585 cmdlets came to pass by
    # never being examined — so this fails loudly instead.
    $routeMap = Get-GraphRouteMap -CmdletsPath $module.Path
    if (-not $routeMap -or $routeMap.Count -eq 0) {
        Write-Error "No compiled assembly with [GraphRoute] metadata for '$($module.Name)'. Build the module before running the parity gate."
        exit 1
    }
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

        # A dispatcher issues no request of its own; it forwards to the _List/_Get pair, whose
        # names carry the same published noun and are verified in their own right.
        if ($content -match 'InvokeCommand\.InvokeScript') {
            $moduleDispatchers++
            Add-LedgerRow $module.Name $file.Name $apiVersion $expectedCommand '' '' 'dispatcher' @()
            continue
        }

        $route = $routeMap[(($file.Name -replace '\.g\.cs$', '') + 'Command')]
        if (-not $route) {
            $moduleJoinable++
            $moduleProblems += "  [NO ROUTE] $($file.Name): the compiled assembly carries no [GraphRoute] for this cmdlet - it was not emitted by this generator, or the build is stale."
            Add-LedgerRow $module.Name $file.Name $apiVersion $expectedCommand '' '' 'no-route' @()
            continue
        }

        $method = $route.Method.ToUpperInvariant()
        $normalizedUri = ConvertTo-OracleJoinKey -Path $route.Path

        $moduleJoinable++

        $candidates = Find-OracleCommands -Index $oracleIndex -ApiVersion $apiVersion -Method $method -NormalizedUri $normalizedUri

        if (-not $candidates -or $candidates.Count -eq 0) {
            $moduleProblems += "  [NO ORACLE ENTRY] $($file.Name): '$generatedCommand' -> reconstructed $method $normalizedUri, no oracle row for that Method+URI."
            Add-LedgerRow $module.Name $file.Name $apiVersion $expectedCommand $method $normalizedUri 'no-oracle' @()
        }
        elseif ($candidates.Count -gt 1) {
            $moduleProblems += "  [AMBIGUOUS] $($file.Name): $method $normalizedUri matches multiple oracle commands: $($candidates -join ', ')."
            Add-LedgerRow $module.Name $file.Name $apiVersion $expectedCommand $method $normalizedUri 'ambiguous' $candidates
        }
        elseif ($candidates.Contains($expectedCommand)) {
            $moduleMatched++
            Add-LedgerRow $module.Name $file.Name $apiVersion $expectedCommand $method $normalizedUri 'matched' $candidates
        }
        else {
            $oracleCommand = $candidates | Select-Object -First 1
            if ($deliberateCorrections[$oracleCommand] -eq $expectedCommand) {
                $moduleCorrected++
                $moduleCorrections += "  [CORRECTED] $($file.Name): oracle ships '$oracleCommand'; generator deliberately emits '$expectedCommand' (see tools/WrapperGenerator/docs/edge-cases/naming-edge-cases.md)."
                Add-LedgerRow $module.Name $file.Name $apiVersion $expectedCommand $method $normalizedUri 'corrected' $candidates
            }
            else {
                $moduleProblems += "  [MISMATCH] $($file.Name): generated '$expectedCommand', oracle says '$oracleCommand' for $method $normalizedUri."
                Add-LedgerRow $module.Name $file.Name $apiVersion $expectedCommand $method $normalizedUri 'mismatch' $candidates
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

if ($OutLedger) {
    $ledger | Export-Csv -Path $OutLedger -NoTypeInformation
    Write-Host "ledger: $($ledger.Count) row(s) -> $OutLedger"
}

if ($totalMismatches -gt 0) {
    exit 1
}

# Only mismatches failed above, so a run that joined nothing reported "0 of 0" and exited clean -
# a pass earned by comparing no cmdlet to no oracle entry. That is indistinguishable from success
# in CI, and it is the shape a wrong -GeneratedPath or an empty output tree produces.
if ($totalJoinable -eq 0) {
    Write-Host "FAILED: no generated cmdlet could be joined to the oracle, so nothing was verified." -ForegroundColor Red
    Write-Host "        Check -GeneratedPath points at a folder of emitted *.g.cs cmdlets." -ForegroundColor Red
    exit 1
}
exit 0
