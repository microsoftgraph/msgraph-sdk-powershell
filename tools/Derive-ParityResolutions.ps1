<#
.SYNOPSIS
Derives naming-parity resolutions (renames and suppressions) for the WHOLE generated surface
from the published-command oracle, and validates the checked-in files against a fresh
derivation.

.DESCRIPTION
The rule-based approach to the residual parity mismatches was measured and rejected: the
largest candidate rule (drop "IdentityGovernance") fixed 297 names and broke 417, because the
published SDK's naming is not rule-based. The published surface itself is the only authority,
so - like the collision pipeline in Derive-CollisionResolutions.ps1 - the resolutions are
DERIVED from MgCommandMetadata.json per operation and reviewed as data.

Input is the parity gate's own ledger (Compare-WrapperCmdletNames.ps1 -OutLedger), so this
script reuses the gate's oracle join instead of re-implementing it; the two cannot drift.

Per ledger row, exactly one action:

  matched / corrected     no entry - the name is already right (or deliberately corrected)
  mismatch, same verb     rename - entry carries the published noun
  no-oracle, name unshipped  suppress - the published SDK pruned the operation
  everything else         defer - reported, NO entry emitted:
      mismatch where the published verb differs (a noun rename cannot fix a verb),
      no-oracle where our name ships from a DIFFERENT uri (cross-path; curated only),
      ambiguous oracle rows, and GET list/item pairs whose published nouns diverge
      (renaming one side would break pairing).

Anything conflicting (one method+uri deriving two actions) is a hard failure.

Output (deterministic: sorted, no timestamps):
  tools/WrapperGenerator/data/parity-renames.<ApiVersion>.json
  tools/WrapperGenerator/data/parity-suppressions.<ApiVersion>.json
  tools/WrapperGenerator/data/parity-resolution-ledger.<ApiVersion>.csv   (evidence)

.PARAMETER Validate
Re-derive and byte-compare against the checked-in data files instead of writing them.

.EXAMPLE
.\tools\Derive-ParityResolutions.ps1
.EXAMPLE
.\tools\Derive-ParityResolutions.ps1 -Validate
#>
[CmdletBinding()]
param(
    # The committed corpus root. Modules live at <root>/<Module>/wrapper/<ApiVersion>/Cmdlets,
    # the same shape Compare-WrapperOperationInventory.ps1 walks from -Path src.
    [string]$GeneratedRoot = "$PSScriptRoot\..\src",
    [string]$OraclePath = "$PSScriptRoot\..\src\Authentication\Authentication\custom\common\MgCommandMetadata.json",
    [string]$OutDir = "$PSScriptRoot\WrapperGenerator\data",
    [ValidateSet('v1.0', 'beta')]
    [string]$ApiVersion = 'v1.0',
    [switch]$Validate,
    # Sweep the generated tree and OVERWRITE the frozen input ledger. Only valid against a tree
    # generated with the derived data DISABLED (--no-collision-data): sweeping a tree that
    # already has the renames applied re-derives "nothing to fix" and destroys the data - which
    # is precisely what happened when capture was the default mode.
    [switch]$CaptureInput
)
$ErrorActionPreference = 'Stop'

# The frozen derivation input, like the collision pipeline's collision-inventory snapshot: the
# parity gate's ledger captured from a tree generated with the derived data DISABLED
# (--no-collision-data). It must be checked in, because once the data is embedded the live tree
# has the renames applied and re-deriving from it would validate the data against itself.
$inputLedgerPath = Join-Path $OutDir "parity-input-ledger.$ApiVersion.csv"

if (-not $CaptureInput) {
    if (-not (Test-Path $inputLedgerPath)) {
        Write-Error "frozen input ledger missing: $inputLedgerPath. Capture it with -CaptureInput against a --no-collision-data tree."
        exit 1
    }
    $rows = @(Import-Csv $inputLedgerPath | Where-Object { $_.ApiVersion -eq $ApiVersion })
}
else {
    # ---- 1. collect the gate's ledger over every module -------------------------------------
    $moduleDirs = @(Get-ChildItem $GeneratedRoot -Directory | ForEach-Object {
            $c = Join-Path $_.FullName "wrapper\$ApiVersion\Cmdlets"
            if ((Test-Path $c) -and @(Get-ChildItem $c -Filter *.g.cs -File | Where-Object Name -ne 'Shared.g.cs')) { $c }
        })
    if (-not $moduleDirs) { Write-Error "no generated cmdlet folders under $GeneratedRoot"; exit 1 }

    $rows = [System.Collections.Generic.List[object]]::new()
    $tmp = Join-Path ([System.IO.Path]::GetTempPath()) "parity-ledger-$PID.csv"
    foreach ($d in $moduleDirs) {
        & "$PSScriptRoot\Compare-WrapperCmdletNames.ps1" -GeneratedPath $d -OraclePath $OraclePath -OutLedger $tmp *> $null
        foreach ($r in Import-Csv $tmp) { $rows.Add($r) }
    }
    Remove-Item $tmp -ErrorAction SilentlyContinue
    $rows = @($rows | Where-Object { $_.ApiVersion -eq $ApiVersion })
    if ($rows.Count -eq 0) { Write-Error "ledger produced no $ApiVersion rows; wrong tree?"; exit 1 }
    $rows | Export-Csv $inputLedgerPath -NoTypeInformation
}

# ---- 2. oracle name set (for the cross-path test) and list/item noun map -------------------
$oracle = Get-Content $OraclePath -Raw | ConvertFrom-Json
$shippedNames = [System.Collections.Generic.HashSet[string]]::new([System.StringComparer]::Ordinal)
foreach ($e in $oracle) { if ($e.ApiVersion -eq $ApiVersion) { [void]$shippedNames.Add($e.Command) } }

# ---- 3. derive one action per METHOD+URI ----------------------------------------------------
function NounOf([string]$command) { ($command -split '-', 2)[1] -replace '^Mg', '' }

function VerbOf([string]$command) { ($command -split '-', 2)[0] }

$byKey = @{}
foreach ($r in $rows) {
    # A dispatcher issues no request of its own; its published name is decided by the _List/_Get
    # pair it forwards to, which carry the same noun and are resolved on their own rows.
    #
    # 'cast' and 'parameterized-function' are rows the gate can no longer produce: it now reads
    # each route from the [GraphRoute] attribute in the compiled assembly, so those shapes arrive
    # as ordinary matched/mismatch/no-oracle rows. They are still skipped because the FROZEN input
    # ledger predates that change and carries 1,121 and 466 of them respectively; dropping the skip
    # makes this script fail on the checked-in data. They disappear from the data on the next
    # -CaptureInput sweep, and the skip can go with them.
    if ($r.Disposition -in 'dispatcher', 'cast', 'parameterized-function') { continue }
    $key = "$($r.Method) $($r.Uri)"
    $action, $noun, $verb, $evidence = switch ($r.Disposition) {
        'matched'   { 'keep', $null, $null, $r.OracleCommands }
        'corrected' { 'keep', $null, $null, "deliberate correction; oracle ships $($r.OracleCommands)" }
        'ambiguous' { 'defer-ambiguous', $null, $null, $r.OracleCommands }
        'mismatch'  {
            # The published verb travels with the noun. An action's verb is the SDK's own choice
            # per operation (sendMail ships Send-, checkMemberGroups Confirm-), so a rename that
            # carried only the noun would leave every one of those a mismatch - and would collide
            # the pairs that differ by verb alone (applyHold/removeHold both ship ...Hold).
            $oc = ($r.OracleCommands -split ';')[0]
            $ocVerb = VerbOf $oc
            'rename', (NounOf $oc), $(if ($ocVerb -cne (VerbOf $r.Command)) { $ocVerb } else { $null }), $oc
        }
        'no-oracle' {
            if ($shippedNames.Contains($r.Command)) { 'defer-crosspath', $null, $null, "$($r.Command) ships from a different uri" }
            else { 'suppress', $null, $null, "no oracle row for $key and '$($r.Command)' unshipped" }
        }
        # The gate found no [GraphRoute] on the compiled cmdlet, so there is no route to resolve
        # against. Deriving anything here would be guessing; a stale build is the usual cause.
        'no-route'  { Write-Error "no [GraphRoute] metadata for '$($r.Command)' ($($r.File)) - rebuild the module before deriving"; exit 1 }
        default     { Write-Error "unknown disposition '$($r.Disposition)'"; exit 1 }
    }
    if ($byKey.ContainsKey($key)) {
        $prev = $byKey[$key]
        # The same operation appears in several modules (crosspath spec duplication) and as
        # both a worker and its own file; identical decisions collapse, conflicts are fatal.
        if ($prev.Action -ne $action -or $prev.Noun -ne $noun -or $prev.Verb -ne $verb) {
            Write-Error "conflicting derivations for $key : $($prev.Action)/$($prev.Verb)/$($prev.Noun) vs $action/$verb/$noun"
            exit 1
        }
        continue
    }
    $byKey[$key] = [pscustomobject]@{
        Method = $r.Method; Uri = $r.Uri; Action = $action; Noun = $noun; Verb = $verb
        OurCommand = $r.Command; Evidence = $evidence
    }
}

# ---- 4. GET list/item pairs whose published nouns diverge cannot be renamed safely ----------
foreach ($e in @($byKey.Values | Where-Object { $_.Method -eq 'GET' -and $_.Action -eq 'rename' })) {
    $partnerKey = if ($e.Uri.EndsWith('/{param}')) { "GET $($e.Uri.Substring(0, $e.Uri.Length - 8))" } else { "GET $($e.Uri)/{param}" }
    if (-not $byKey.ContainsKey($partnerKey)) { continue }
    $p = $byKey[$partnerKey]
    $pNoun = if ($p.Action -eq 'rename') { $p.Noun } elseif ($p.Action -eq 'keep') { NounOf $p.OurCommand } else { $null }
    if ($null -ne $pNoun -and $pNoun -ne $e.Noun) {
        $e.Action = 'defer-pair-divergence'; $e.Evidence = "partner $partnerKey resolves to noun '$pNoun'"
        $e.Noun = $null
        if ($p.Action -eq 'rename') { $p.Action = 'defer-pair-divergence'; $p.Noun = $null }
    }
}

# ---- 4b. two route families converging on one cmdlet name --------------------------------
# The published SDK sometimes serves ONE command surface from a DIFFERENT uri family than the
# spec's obvious one: Get-MgTeamChannelMember ships its rows from /allMembers, and /members
# ships nothing. Every generating route contributes a file under its FINAL noun - including
# deferred routes, which keep their old noun - so if two families converge on one (method,
# noun) the generator writes the same file twice and fails loudly.
#
# Resolution is derivable when exactly one side ships: a family whose routes are all
# defer-crosspath ships nothing (that is what the disposition means), and the sibling family's
# rename tells us where its name actually ships - so the unshipped family is suppressed with
# that evidence. If BOTH families have oracle rows, no side can be picked mechanically: the
# renames are deferred and the mismatch stays visible for curated review.
# List/item pairs share a noun BY DESIGN, so the item uri collapses onto its list uri first.
$familyGroups = @($byKey.Values |
        Where-Object { $_.Action -in 'keep', 'rename', 'defer-crosspath' } |
        Group-Object {
            # The key is the emitted FILE's identity - verb plus noun - and deliberately not the
            # HTTP method. Two routes collide whenever they resolve to the same command name,
            # even across methods: the published SDK ships Update-MgChatInstalledApp for the
            # POST .../upgrade action and no PATCH cmdlet at all, so the action's rename lands on
            # the name our PATCH route would otherwise keep. Including the verb still separates
            # the pairs that differ only by verb (applyHold -> Add-...Hold, removeHold ->
            # Remove-...Hold), which do not collide.
            $noun = if ($_.Action -eq 'rename') { $_.Noun } else { NounOf $_.OurCommand }
            $verb = if ($_.Action -eq 'rename' -and $_.Verb) { $_.Verb } else { VerbOf $_.OurCommand }
            "$verb|$noun"
        })
foreach ($g in $familyGroups) {
    $byFamily = $g.Group | Group-Object { $_.Uri -replace '/\{param\}$', '' }
    if (@($byFamily).Count -le 1) { continue }

    # Families that ship nothing (all defer-crosspath) are suppressed; their name lives in a
    # sibling family. Only families with real oracle rows remain in contention afterwards.
    $shipping = [System.Collections.Generic.List[object]]::new()
    foreach ($fam in $byFamily) {
        if (@($fam.Group | Where-Object Action -ne 'defer-crosspath').Count -eq 0) {
            foreach ($e in $fam.Group) {
                $e.Action = 'suppress'
                $e.Evidence = "no oracle row; '$($e.OurCommand)' ships from sibling family (see rename entries for this noun)"
            }
        }
        else { $shipping.Add($fam) }
    }
    if (@($shipping).Count -le 1) { continue }

    # Both-ship merge: no mechanical winner.
    foreach ($e in @($shipping | ForEach-Object Group | Where-Object Action -eq 'rename')) {
        $e.Action = 'defer-crosspath-merge'
        $e.Evidence = "renaming to '$($e.Noun)' collides with a sibling family that also ships"
        $e.Noun = $null
    }
}

# ---- 5. emit --------------------------------------------------------------------------------
$all = @($byKey.Values | Sort-Object Method, Uri)
$renames = @($all | Where-Object Action -eq 'rename')
$suppressions = @($all | Where-Object Action -eq 'suppress')
$deferred = @($all | Where-Object { $_.Action -like 'defer-*' })

function ToJson($entries, $action) {
    # Uri is lowercased to the generator's NormalizePath form ({param} -> {}).
    $list = @($entries | ForEach-Object {
            $o = [ordered]@{
                apiVersion = $ApiVersion; method = $_.Method
                uri = ($_.Uri -replace '\{param\}', '{}').ToLowerInvariant()
                action = $action
                evidence = [ordered]@{ ourCommand = $_.OurCommand; oracle = $_.Evidence }
            }
            if ($action -eq 'rename') {
                $o.replacementNoun = $_.Noun
                # Emitted only where the published verb differs from the one the generator
                # derives, so the data stays the diff against the structural rules.
                if ($_.Verb) { $o.replacementVerb = $_.Verb }
            }
            [pscustomobject]$o
        })
    ConvertTo-Json $list -Depth 4
}

# A fresh capture that finds nothing to fix while non-trivial data is already checked in is
# the signature of sweeping a tree that has the data APPLIED - deriving from it would erase
# the very entries that cleaned the tree up.
if ($CaptureInput -and $renames.Count -eq 0 -and $suppressions.Count -eq 0) {
    Write-Error ("capture produced 0 renames and 0 suppressions - the swept tree looks like it was " +
        "generated WITH the parity data applied. Regenerate with --no-collision-data first.")
    exit 1
}

$renamesJson = ToJson $renames 'rename'
$suppressionsJson = ToJson $suppressions 'suppress'
$renamesPath = Join-Path $OutDir "parity-renames.$ApiVersion.json"
$suppressionsPath = Join-Path $OutDir "parity-suppressions.$ApiVersion.json"

"ledger rows ($ApiVersion)   : $($rows.Count)"
"distinct method+uri         : $($byKey.Count)"
"  keep                      : $(@($all | Where-Object Action -eq 'keep').Count)"
"  rename                    : $($renames.Count)"
"  suppress                  : $($suppressions.Count)"
"  deferred (no entry)       : $($deferred.Count)"
$deferred | Group-Object Action | ForEach-Object { "    $($_.Name): $($_.Count)" }

if ($Validate) {
    $drift = @()
    if (-not (Test-Path $renamesPath) -or (Get-Content $renamesPath -Raw) -ne $renamesJson) { $drift += $renamesPath }
    if (-not (Test-Path $suppressionsPath) -or (Get-Content $suppressionsPath -Raw) -ne $suppressionsJson) { $drift += $suppressionsPath }
    if ($drift) { Write-Error "checked-in parity data drifted from a fresh derivation: $($drift -join ', ')"; exit 1 }
    'validation OK: checked-in parity data matches a fresh derivation.'
    exit 0
}

Set-Content -Path $renamesPath -Value $renamesJson -NoNewline
Set-Content -Path $suppressionsPath -Value $suppressionsJson -NoNewline
$all | Select-Object Method, Uri, Action, Noun, OurCommand, Evidence |
    Export-Csv (Join-Path $OutDir "parity-resolution-ledger.$ApiVersion.csv") -NoTypeInformation
"wrote $renamesPath"
"wrote $suppressionsPath"
"wrote $(Join-Path $OutDir "parity-resolution-ledger.$ApiVersion.csv")"
