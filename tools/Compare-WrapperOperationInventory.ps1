<#
.SYNOPSIS
Captures, and compares, the set of operations the generator turns into cmdlets.

.DESCRIPTION
A change meant to affect only cmdlet PARAMETERS must not change which OPERATIONS generate.
Comparing filenames alone cannot show that: two operations could exchange ownership of a
cmdlet name and leave the same set of files behind. This records the full identity of each
emitted cmdlet - module, verb, noun, request path (the kiota builder chain, which is the
operation's path) and file - and diffs two snapshots on that tuple.

Use -Baseline to record the current state before a change, then -Compare afterwards.

.EXAMPLE
.\tools\Compare-WrapperOperationInventory.ps1 -Path artifacts\wrapper-modules -Baseline before.csv
.EXAMPLE
.\tools\Compare-WrapperOperationInventory.ps1 -Path artifacts\wrapper-modules -Baseline before.csv -Compare after.csv
#>
[CmdletBinding()]
param(
    [Parameter(Mandatory)]
    [string]$Path,
    [Parameter(Mandatory)]
    [string]$Baseline,
    [string]$Compare,
    [switch]$AllowSameGenerator
)

$ErrorActionPreference = 'Stop'

# The comparison answers "did the generator change which operations become cmdlets", which it can
# only answer if the generator actually changed between the two captures. A baseline taken from the
# same generator build reports "unchanged" no matter what, so the stamp is recorded alongside it and
# checked on compare. -AllowSameGenerator is for the legitimate case: proving regeneration is
# deterministic, where an identical generator is the point.
function Get-GeneratorStamp {
    # Code AND embedded data: the derived naming data changes which operations generate without
    # touching a .cs file, so a code-only stamp would call a data-driven change "same generator".
    $sources = @(Get-ChildItem -Path (Join-Path $PSScriptRoot 'WrapperGenerator') -Recurse -File -Include *.cs, *.json -ErrorAction SilentlyContinue |
        Where-Object { $_.FullName -notmatch '\\(bin|obj)\\' })
    if (-not $sources) { return 'unknown' }
    ($sources | Sort-Object LastWriteTimeUtc -Descending | Select-Object -First 1).LastWriteTimeUtc.ToString('o')
}

$cmdletAttrPattern = '\[Cmdlet\(Verbs\w+\.(\w+),\s*"((?:\\.|[^"\\])*)"'
$builderPattern = 'client\.([A-Za-z0-9_\[\]\.]+?)\.(?:Get|Post|Patch|Delete|Put)Async'

# Finds every Cmdlets folder under the root at any depth and takes the module name from the
# first segment below it, so the artifacts layout (<Module>/src/Cmdlets) and the committed one
# (<Module>/<ApiVersion>/wrapper/Cmdlets) can be compared against each other.
function Get-Inventory([string]$root) {
    $rootFull = (Resolve-Path $root).Path
    $rows = [System.Collections.Generic.List[object]]::new()
    foreach ($cmdletsDir in (Get-ChildItem $rootFull -Directory -Recurse -Filter 'Cmdlets')) {
        $relative = $cmdletsDir.FullName.Substring($rootFull.Length).TrimStart('\', '/')
        $module = ($relative -split '[\\/]')[0]
        foreach ($file in Get-ChildItem $cmdletsDir.FullName -Filter '*.g.cs' -File) {
            if ($file.Name -eq 'Shared.g.cs') { continue }
            $text = Get-Content $file.FullName -Raw
            $m = [regex]::Match($text, $cmdletAttrPattern)
            if (-not $m.Success) { continue }
            $b = [regex]::Match($text, $builderPattern)
            $rows.Add([pscustomobject]@{
                    Module      = $module
                    Cmdlet      = "$($m.Groups[1].Value)-$([regex]::Unescape($m.Groups[2].Value))"
                    Verb        = $m.Groups[1].Value
                    RequestPath = if ($b.Success) { $b.Groups[1].Value } else { '(dispatcher)' }
                    File        = $file.Name
                })
        }
    }
    return $rows | Sort-Object Module, File
}

$inventory = Get-Inventory $Path
# An empty inventory means the path or layout is wrong. Left unchecked it compares nothing
# against nothing and reports "unchanged" - a pass that proves the opposite of what it claims.
if ($inventory.Count -eq 0) {
    Write-Error "No cmdlets found under '$Path'. Expected <Module>/src/Cmdlets or <Module>/<ApiVersion>/wrapper/Cmdlets."
    exit 2
}

$stampFile = "$Baseline.generator"

if (-not $Compare) {
    $inventory | Export-Csv $Baseline -NoTypeInformation
    Set-Content -Path $stampFile -Value (Get-GeneratorStamp) -NoNewline
    "baseline: $($inventory.Count) cmdlets -> $Baseline"
    exit 0
}

$inventory | Export-Csv $Compare -NoTypeInformation
$before = Import-Csv $Baseline
$after = Import-Csv $Compare

$nowStamp = Get-GeneratorStamp
if (Test-Path $stampFile) {
    $thenStamp = (Get-Content $stampFile -Raw).Trim()
    if ($thenStamp -eq $nowStamp -and -not $AllowSameGenerator) {
        Write-Host "FAILED: the baseline was captured from this same generator ($nowStamp)." -ForegroundColor Red
        Write-Host "        'unchanged' would be guaranteed, so the comparison proves nothing." -ForegroundColor Red
        Write-Host "        Capture the baseline before changing the generator, or pass -AllowSameGenerator" -ForegroundColor Red
        Write-Host "        if an identical generator is deliberate (a determinism check)." -ForegroundColor Red
        exit 2
    }
}
else {
    Write-Warning "No generator stamp beside '$Baseline'; cannot tell whether it predates this generator."
}

# Identity is the whole tuple, so an operation swapping which cmdlet/file it owns shows up as
# one removal plus one addition rather than as no change at all.
function Key($r) { "{0}|{1}|{2}|{3}" -f $r.Module, $r.Cmdlet, $r.RequestPath, $r.File }
# Filled by Add, and built inline rather than in a helper function, for two separate reasons:
# the HashSet(IEnumerable<string>) constructor is ambiguous against
# HashSet(IEqualityComparer<string>) when a side is empty, and returning a set FROM a function
# makes PowerShell enumerate it back into an Object[] - whose Contains is a linear scan, turning
# this comparison into ~n^2 string compares over ~10k identities.
$beforeKeys = [System.Collections.Generic.HashSet[string]]::new()
foreach ($r in $before) { [void]$beforeKeys.Add((Key $r)) }
$afterKeys = [System.Collections.Generic.HashSet[string]]::new()
foreach ($r in $after) { [void]$afterKeys.Add((Key $r)) }

$added = @($afterKeys | Where-Object { -not $beforeKeys.Contains($_) })
$removed = @($beforeKeys | Where-Object { -not $afterKeys.Contains($_) })

"before: $($before.Count) cmdlets"
"after:  $($after.Count) cmdlets"
"added:   $($added.Count)"
"removed: $($removed.Count)"
if ($added) { ""; "ADDED:"; $added | Select-Object -First 25 | ForEach-Object { "  $_" } }
if ($removed) { ""; "REMOVED:"; $removed | Select-Object -First 25 | ForEach-Object { "  $_" } }

if ($added.Count -eq 0 -and $removed.Count -eq 0) {
    ""; "operation inventory unchanged."
    exit 0
}
exit 1
