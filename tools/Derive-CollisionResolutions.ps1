<#
.SYNOPSIS
Derives the wrapper generator's collision-resolution data files from the published-command
oracle, and validates the checked-in files against a fresh derivation.

.DESCRIPTION
Input is a collision inventory: the exact lines the generator prints when it fails loudly on
cmdlet file collisions (one "Module :: File: 'Verb-Noun [Builder]' collides with
already-written 'Verb-Noun [Builder]'" per line), captured from a generation run with no
collision resolutions applied.

For every route that appears in the inventory, the script asks the oracle
(MgCommandMetadata.json, filtered to -ApiVersion) what the published SDK ships for that
method + URI, and derives exactly one action:

  keep      the route ships under the same name the generator produces - no entry emitted
  suppress  the route ships nothing - the published SDK pruned it
  rename    the route ships under a different noun - entry carries the published noun

Anything else is a hard failure:
  - an inventory line that does not parse,
  - the same route deriving two different actions from different lines,
  - a cross-path merge (both routes ship the SAME command from DIFFERENT URIs - the
    generator cannot represent that yet) that no curated NamingOverrides entry resolves.

Output is two deterministic JSON files (sorted, no timestamps) so renames review separately
from suppressions:

  tools/WrapperGenerator/data/collision-suppressions.<ApiVersion>.json
  tools/WrapperGenerator/data/collision-renames.<ApiVersion>.json

plus an operation-level ledger of every inventory route -> action -> evidence:

  <inventory folder>/collision-resolution-ledger.<ApiVersion>.csv

.PARAMETER Validate
Re-derive and byte-compare against the checked-in data files instead of writing them.
Exits 1 on any difference, so drift between oracle, inventory, and data cannot land silently.

.EXAMPLE
.\tools\Derive-CollisionResolutions.ps1
.EXAMPLE
.\tools\Derive-CollisionResolutions.ps1 -Validate
#>
[CmdletBinding()]
param(
    # The checked-in inventory snapshot: every collision line from a full-module generation
    # run with the derived data disabled (WrapperGenerator --no-collision-data). Re-capture it
    # with that flag whenever specs or naming rules change, then re-derive.
    [string]$InventoryPath,
    [string]$OraclePath = "$PSScriptRoot\..\src\Authentication\Authentication\custom\common\MgCommandMetadata.json",
    [string]$OutDir = "$PSScriptRoot\WrapperGenerator\data",
    [string]$LedgerPath,
    [ValidateSet('v1.0', 'beta')]
    [string]$ApiVersion = 'v1.0',
    [switch]$Validate
)
if (-not $InventoryPath) { $InventoryPath = "$PSScriptRoot\WrapperGenerator\data\collision-inventory.$ApiVersion.txt" }
# Checked in alongside the inventory (NOT artifacts/, which is gitignored) so it ships as
# reviewable evidence in the PR diff. It is regenerated on every run but NOT compared by
# -Validate — only the two collision-*.json files are the enforced contract; this CSV is the
# human-readable "why" behind them, kept in sync by convention, not by the drift gate.
if (-not $LedgerPath) { $LedgerPath = "$PSScriptRoot\WrapperGenerator\data\collision-resolution-ledger.$ApiVersion.csv" }

$ErrorActionPreference = 'Stop'

# ---- parse the inventory -------------------------------------------------------------------
$lineRx = "^(?<mod>[^:]+?) :: (?<file>\S+): '(?<verb>[A-Za-z]+)-(?<noun>[A-Za-z0-9]+) \[(?<lost>[^\]]*(?:\[[^\]]*\][^\]]*)*)\]' collides with already-written '(?<verb2>[A-Za-z]+)-(?<noun2>[A-Za-z0-9]+) \[(?<kept>[^\]]*(?:\[[^\]]*\][^\]]*)*)\]'$"
$verbToMethod = @{ Get = 'GET'; New = 'POST'; Update = 'PATCH'; Set = 'PUT'; Remove = 'DELETE'; Invoke = 'POST' }

# The generator reports each colliding operation's route already normalized (lowercase, every
# parameter erased to {}), so a route is taken from the inventory rather than reconstructed
# from a builder expression. Reconstruction cannot round-trip a function (the builder member
# spells the argument NAMES but not the OData argument syntax) or a namespace-qualified action
# (kiota keeps the "microsoft.graph.security." qualifier that the route does not carry), and a
# route rebuilt wrongly would be resolved against the wrong oracle row.
function ConvertTo-UriSkeleton([string]$route) {
    if ($route -notmatch '^/') { return $null }
    $route
}

$lines = @(Get-Content $InventoryPath | Where-Object { $_.Trim() })
$parsed = @()
$unparsed = @()
foreach ($l in $lines) {
    if ($l -match $lineRx) {
        $lost = ConvertTo-UriSkeleton $Matches.lost
        $kept = ConvertTo-UriSkeleton $Matches.kept
        if (-not $lost -or -not $kept) { $unparsed += $l; continue }
        $parsed += [pscustomobject]@{
            Module = $Matches.mod.Trim(); Method = $verbToMethod[$Matches.verb]
            OurName = "$($Matches.verb)-$($Matches.noun)"; Lost = $lost; Kept = $kept
        }
    }
    else { $unparsed += $l }
}
if ($unparsed) {
    $unparsed | ForEach-Object { Write-Error -ErrorAction Continue "unparsed inventory line: $_" }
    throw "$($unparsed.Count) inventory line(s) did not parse; refusing to derive from a partial inventory."
}
Write-Host "inventory: $($parsed.Count) collision lines"

# ---- oracle lookup: METHOD + skeleton -> published commands --------------------------------
# Normalized exactly as NamingOverrides.NormalizePath normalizes a spec path, so an oracle row
# and a generated route are the same string for the same operation. Erasing EVERY {...} matters
# for functions, whose arguments carry placeholders inside the segment
# ("allowedCalendarSharingRoles(User='{User}')").
function ConvertTo-OracleSkeleton([string]$uri) {
    ($uri -replace '\{[^}]*\}', '{}').TrimEnd('/').ToLowerInvariant()
}

# The shipped inventory records an action's route unqualified ("…/custodians/{}/applyhold")
# while the spec qualifies it with the namespace that declares the action
# ("…/custodians/{}/microsoft.graph.security.applyhold"). They are the same operation, so a
# route that finds no oracle row is retried without the qualifier before being called unshipped
# — otherwise these actions would derive as "suppress" and prune cmdlets the SDK does ship.
function Get-UnqualifiedRoute([string]$skel) {
    $i = $skel.LastIndexOf('/')
    if ($i -lt 0) { return $null }
    $last = $skel.Substring($i + 1)
    $dot = $last.LastIndexOf('.')
    if ($dot -lt 0) { return $null }
    $skel.Substring(0, $i + 1) + $last.Substring($dot + 1)
}

$oracle = @{}
foreach ($e in (Get-Content $OraclePath -Raw | ConvertFrom-Json)) {
    if ($e.ApiVersion -ne $ApiVersion) { continue }
    $k = "$($e.Method) $(ConvertTo-OracleSkeleton $e.Uri)"
    if (-not $oracle.ContainsKey($k)) { $oracle[$k] = [System.Collections.Generic.SortedSet[string]]::new() }
    [void]$oracle[$k].Add($e.Command)
}

# Every published command for a route, qualifier-insensitively.
function Get-ShippedCommands([string]$method, [string]$skel) {
    $k = "$method $skel"
    if ($oracle.ContainsKey($k)) { return @($oracle[$k]) }
    $bare = Get-UnqualifiedRoute $skel
    if ($bare -and $oracle.ContainsKey("$method $bare")) { return @($oracle["$method $bare"]) }
    @()
}

# ---- derive one action per route ------------------------------------------------------------
# Route identity is (method, skeleton). Every inventory line contributes both of its routes.
$routes = @{}
function Add-Route($module, $method, $skel, $ourName, $counterpartSkel) {
    $key = "$method $skel"
    if (-not $routes.ContainsKey($key)) {
        $routes[$key] = [pscustomobject]@{
            Method = $method; Uri = $skel; OurName = $ourName
            Modules = [System.Collections.Generic.SortedSet[string]]::new()
            Counterparts = [System.Collections.Generic.SortedSet[string]]::new()
        }
    }
    $r = $routes[$key]
    if ($r.OurName -cne $ourName) {
        throw "ambiguous: route '$key' produces both '$($r.OurName)' and '$ourName' in the inventory."
    }
    [void]$r.Modules.Add($module)
    [void]$r.Counterparts.Add($counterpartSkel)
}
foreach ($p in $parsed) {
    Add-Route $p.Module $p.Method $p.Lost $p.OurName $p.Kept
    Add-Route $p.Module $p.Method $p.Kept $p.OurName $p.Lost
}
Write-Host "routes contested: $($routes.Count)"

# Pass 1 - tentative action per route, straight from the oracle:
#   ships nothing        -> suppress
#   ships under our name -> keep (subject to the cross-path pass below)
#   ships renamed        -> rename to the published noun
$failures = @()
foreach ($key in ($routes.Keys | Sort-Object)) {
    $r = $routes[$key]
    $ships = @(Get-ShippedCommands $r.Method $r.Uri)
    # The comma operator keeps a single-element array an array through Add-Member's binder.
    $r | Add-Member ShipsAs (, $ships)
    $action =
    if ($ships.Count -eq 0) { 'suppress' }
    elseif ($ships -ccontains $r.OurName) { 'keep' }
    else {
        $shippedNouns = @($ships | ForEach-Object { ($_ -split '-', 2)[1] -replace '^Mg', '' } | Sort-Object -Unique)
        if ($shippedNouns.Count -ne 1) {
            $failures += "ambiguous rename: $key ships as [$($ships -join ', ')] - more than one target noun."
        }
        # The published verb travels with the noun. Two actions on one resource routinely share
        # a noun and differ only by verb (applyHold ships Add-…Hold, removeHold Remove-…Hold),
        # so a noun-only rename would give both the same name and collide.
        $shippedVerbs = @($ships | ForEach-Object { ($_ -split '-', 2)[0] } | Sort-Object -Unique)
        if ($shippedVerbs.Count -ne 1) {
            $failures += "ambiguous rename: $key ships as [$($ships -join ', ')] - more than one target verb."
        }
        elseif ($shippedVerbs[0] -cne ($r.OurName -split '-', 2)[0]) {
            $r | Add-Member Verb $shippedVerbs[0]
        }
        'rename'
    }
    $r | Add-Member Action $action
}

# Pass 2 - cross-path merges. The published SDK serves ONE command from several URIs as
# parameter-set variants (Get-MgSiteTermStoreSetChild covers /children, /children/{},
# /children/{}/children, /children/{}/children/{}). The wrapper cannot express that yet, so
# among same-command keep-routes only the shallowest list/item pair survives: the route with
# the fewest path parameters (tie: shortest, then ordinal - fully deterministic) plus its
# trailing-id partner. Deeper twins are suppressed and marked deferred; they come back when
# cross-path parameter sets land (tracked in the operation-shapes issue).
foreach ($group in ($routes.Values | Where-Object { $_.Action -eq 'keep' } |
        Group-Object { "$($_.Method) $($_.OurName)" } | Where-Object Count -gt 1)) {
    $anchor = $group.Group | Sort-Object `
        @{e = { ([regex]::Matches($_.Uri, '\{\}')).Count } }, @{e = { $_.Uri.Length } }, @{e = { $_.Uri } } |
        Select-Object -First 1
    foreach ($r in $group.Group) {
        if ($r.Uri -cne $anchor.Uri -and $r.Uri -cne "$($anchor.Uri)/{}") { $r.Action = 'suppress-deferred' }
    }
}

if ($failures) {
    $failures | ForEach-Object { Write-Error -ErrorAction Continue $_ }
    throw "$($failures.Count) route(s) unclassified or ambiguous; refusing to emit a partial derivation."
}

$suppressions = @(); $renames = @(); $ledger = @()
foreach ($key in ($routes.Keys | Sort-Object)) {
    $r = $routes[$key]
    $counterpartShips = @($r.Counterparts | ForEach-Object { $ck = "$($r.Method) $_"
            if ($oracle.ContainsKey($ck)) { @($oracle[$ck]) } else { @() } } | Sort-Object -Unique)
    $entry = [ordered]@{
        apiVersion = $ApiVersion; modules = @($r.Modules); method = $r.Method; uri = $r.Uri
        action = if ($r.Action -eq 'suppress-deferred') { 'suppress' } else { $r.Action }
        evidence = [ordered]@{
            shipsAs = @($r.ShipsAs); counterpartUris = @($r.Counterparts); counterpartShipsAs = $counterpartShips
        }
    }
    if ($r.Action -eq 'suppress-deferred') { $entry.deferredCrossPathMerge = $true }
    if ($r.Action -eq 'rename') {
        $entry.replacementNoun = (@($r.ShipsAs)[0] -split '-', 2)[1] -replace '^Mg', ''
        # Emitted only where the published verb differs from the one the generator derives, so
        # the data stays the diff against structural naming rather than a full restatement of it.
        if ($r.PSObject.Properties['Verb']) { $entry.replacementVerb = $r.Verb }
    }
    switch ($entry.action) {
        'suppress' { $suppressions += [pscustomobject]$entry }
        'rename'   { $renames += [pscustomobject]$entry }
    }
    $ledger += [pscustomobject]@{
        Method = $r.Method; Uri = $r.Uri; Modules = ($r.Modules -join ';'); OurName = $r.OurName
        Action = $r.Action; ShipsAs = ($r.ShipsAs -join ';'); CounterpartUris = ($r.Counterparts -join ';')
        CounterpartShipsAs = ($counterpartShips -join ';')
    }
}

# ---- write or validate ----------------------------------------------------------------------
$jsonOpts = [System.Text.Json.JsonSerializerOptions]::new()
$jsonOpts.WriteIndented = $true
function ToJson($obj) {
    # ConvertTo-Json reorders nothing, but normalize newlines so the byte-compare is stable.
    (($obj | ConvertTo-Json -Depth 6) -replace "`r`n", "`n") + "`n"
}
$targets = @(
    @{ Path = Join-Path $OutDir "collision-suppressions.$ApiVersion.json"; Content = ToJson $suppressions },
    @{ Path = Join-Path $OutDir "collision-renames.$ApiVersion.json"; Content = ToJson $renames }
)
if ($Validate) {
    $drift = @()
    foreach ($t in $targets) {
        if (-not (Test-Path $t.Path)) { $drift += "missing: $($t.Path)"; continue }
        $existing = (Get-Content $t.Path -Raw) -replace "`r`n", "`n"
        if ($existing -cne $t.Content) { $drift += "differs from fresh derivation: $($t.Path)" }
    }
    if ($drift) {
        $drift | ForEach-Object { Write-Error -ErrorAction Continue $_ }
        exit 1
    }
    Write-Host "validation OK: $($suppressions.Count) suppressions + $($renames.Count) renames match the checked-in files."
    exit 0
}

New-Item -ItemType Directory -Force $OutDir | Out-Null
foreach ($t in $targets) { [System.IO.File]::WriteAllText($t.Path, $t.Content) }
New-Item -ItemType Directory -Force (Split-Path $LedgerPath) | Out-Null
$ledger | Sort-Object Method, Uri | Export-Csv $LedgerPath -NoTypeInformation
Write-Host "wrote $($suppressions.Count) suppressions, $($renames.Count) renames, ledger of $($ledger.Count) routes -> $LedgerPath"
