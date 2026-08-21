<#
.SYNOPSIS
Captures, and compares, the set of operations the generator turns into cmdlets.

.DESCRIPTION
A change meant to affect only cmdlet PARAMETERS must not change which OPERATIONS generate.
Comparing filenames alone cannot show that: two operations could exchange ownership of a
cmdlet name and leave the same set of files behind. This records the full identity of each
emitted cmdlet - module, verb, noun, request path (the kiota builder chain, which is the
operation's path) and file - and diffs two snapshots on that tuple.

Use -Baseline to record the current state before a change, then -Compare afterwards. The
generator that produced a baseline is stamped beside it, because a baseline captured from the
same generator it is compared against reports "unchanged" whatever the change was.

.EXAMPLE
.\tools\Compare-WrapperOperationInventory.ps1 -Baseline before.csv
.EXAMPLE
.\tools\Compare-WrapperOperationInventory.ps1 -Baseline before.csv -Compare after.csv
#>
[CmdletBinding()]
param(
    [string]$Path,
    [Parameter(Mandatory)]
    [string]$Baseline,
    [string]$Compare,
    [switch]$AllowSameGenerator
)

$ErrorActionPreference = 'Stop'
$repoRoot = (Resolve-Path (Join-Path $PSScriptRoot '..')).Path
if (-not $Path) { $Path = Join-Path $repoRoot 'src' }

# Content-addressed, never timestamps: a fresh clone rewrites every mtime while the generator is
# byte-identical, and touching a file changes an mtime while the generator is not. Either way a
# timestamp answers "same generator?" wrongly, and this guard is only worth having if its answer
# is exact.
function Get-GeneratorStamp {
    $generatorRoot = Join-Path $PSScriptRoot 'WrapperGenerator'
    # Everything that compiles into the generator: code, the embedded collision data (.json), and
    # the project file that decides which data is embedded at all. A code-only stamp would call a
    # data-driven change "same generator". Docs and the derivation ledgers are excluded - they do
    # not reach the output.
    $sources = @(Get-ChildItem -Path $generatorRoot -Recurse -File -Include *.cs, *.json, *.csproj |
        Where-Object { $_.FullName -notmatch '[\\/](bin|obj)[\\/]' })
    if (-not $sources) { return 'unknown' }

    $sha = [System.Security.Cryptography.SHA256]::Create()
    try {
        # The path is hashed with the content: moving a rule from one file to another changes what
        # generates while leaving the set of bytes identical.
        $perFile = foreach ($file in $sources) {
            $relative = $file.FullName.Substring($generatorRoot.Length).TrimStart('\', '/').Replace('\', '/')
            # CRLF is normalized away: with core.autocrlf one commit has two different byte streams
            # depending on where it was checked out, and the generator behaves the same either way.
            $text = [IO.File]::ReadAllText($file.FullName) -replace "`r`n", "`n"
            $content = [BitConverter]::ToString($sha.ComputeHash([Text.Encoding]::UTF8.GetBytes($text))).Replace('-', '')
            "$relative $content"
        }
        # Sorted by relative path so the stamp does not depend on enumeration order.
        $manifest = (($perFile | Sort-Object) -join "`n")
        return 'sha256:' + [BitConverter]::ToString($sha.ComputeHash([Text.Encoding]::UTF8.GetBytes($manifest))).Replace('-', '')
    }
    finally { $sha.Dispose() }
}

$cmdletAttrPattern = '\[Cmdlet\(Verbs\w+\.(\w+),\s*"((?:\\.|[^"\\])*)"'
$builderPattern = 'client\.([A-Za-z0-9_\[\]\.]+?)\.(?:Get|Post|Patch|Delete|Put)Async'

# Finds every Cmdlets folder under the root at any depth and takes the module name from the first
# segment below it, so -Path src yields <Module> from src/<Module>/wrapper/<ApiVersion>/Cmdlets and
# a baseline stays comparable if the nesting below the module folder ever changes.
# AutoRest owns Cmdlets folders under src as well (src/<Module>/<ApiVersion>/generated/cmdlets, and
# the runtime's BuildTime/Cmdlets); only *.g.cs is read, and none of theirs carries that extension.
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
    # -ErrorAction Continue, not the script's Stop default: a terminating error exits 1, which is
    # the code for a real inventory difference. This is a bad path, and callers have to tell those
    # apart.
    Write-Error "No cmdlets found under '$Path'. Expected <Module>/wrapper/<ApiVersion>/Cmdlets." -ErrorAction Continue
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
        Write-Host "FAILED: the baseline was captured from this same generator." -ForegroundColor Red
        Write-Host "        $nowStamp" -ForegroundColor Red
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
