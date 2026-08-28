<#
.SYNOPSIS
Runs every wrapper-generator gate and reports each one by name, population and result.

.DESCRIPTION
"Fully verified" is only meaningful if the gate set is written down and executable. Before this
script it lived in whoever's memory ran the gates last, and a gate that was never run was
indistinguishable from one that passed.

Three rules the runner enforces on itself:

  * Every gate reports the POPULATION it examined. A gate that examined nothing cannot pass -
    an empty run is the same false clean bill of health as a broken assertion.
  * A gate that could not run is NOT-RUN, never PASS. The overall verdict is then INCOMPLETE
    (exit 2), which is distinct from a real failure (exit 1).
  * The validation block at the end is generated from what actually ran. Copy it into a commit
    message or PR body instead of writing the numbers by hand.

Gate order matters: the generator is built first, then the corpus is generated and compiled, and
the remaining gates read that output.

.PARAMETER CorpusRoot
Root of the committed wrapper corpus, whose modules live at
<CorpusRoot>/<Module>/wrapper/<ApiVersion>/. Default: <repo>/src - the same root
Compare-WrapperOperationInventory.ps1 walks. Build-WrapperModule.ps1 writes there and nowhere
else, so this is a root to READ, not a destination to choose.

.PARAMETER ApiVersion
Which generated API version the gates read. Default: v1.0.

.PARAMETER Configuration
Build configuration for the gates that compile and read build output. Default: Release. The
runtime gate is not one of them - it validates the packed module, and refuses a package older
than the project that produced it.

.PARAMETER InventoryBaseline
CSV captured from a PREVIOUS generator, for the operation-inventory diff. Without it that gate
reports NOT-RUN: comparing a tree against itself proves nothing.

.PARAMETER SkipBuild
Reuse the modules already under -CorpusRoot instead of regenerating. Faster, but the result then
describes whatever is on disk; the runtime gate's staleness check is what stops that being a lie.

.EXAMPLE
.\tools\Invoke-WrapperGates.ps1

.EXAMPLE
.\tools\Invoke-WrapperGates.ps1 -InventoryBaseline before.csv
#>
[CmdletBinding()]
param(
    [string]$CorpusRoot,
    [ValidateSet('v1.0', 'beta')]
    [string]$ApiVersion = 'v1.0',
    [string]$Configuration = 'Release',
    [string]$InventoryBaseline,
    [switch]$SkipBuild
)

$ErrorActionPreference = 'Stop'
$repoRoot = (Resolve-Path (Join-Path $PSScriptRoot '..')).Path
if (-not $CorpusRoot) { $CorpusRoot = Join-Path $repoRoot 'src' }

# Every gate reads modules from the same place and by the same shape, so a layout change lands
# in one helper rather than in four globs that can drift apart - which is exactly how this
# runner came to be pointing at a directory nothing had written to since the corpus moved.
function Get-ModuleCmdletDirs {
    Get-ChildItem $CorpusRoot -Directory -ErrorAction SilentlyContinue | ForEach-Object {
        $c = Join-Path $_.FullName "wrapper\$ApiVersion\Cmdlets"
        if (Test-Path $c) { [pscustomobject]@{ Module = $_.Name; Cmdlets = $c } }
    }
}

$results = [System.Collections.Generic.List[object]]::new()

function Add-Gate {
    param(
        [Parameter(Mandatory)][string]$Name,
        [Parameter(Mandatory)][string]$Proves,
        [Parameter(Mandatory)][scriptblock]$Body
    )
    Write-Host "-> $Name" -ForegroundColor Cyan
    $r = try { & $Body } catch {
        [pscustomobject]@{ Status = 'FAIL'; Population = 'errored'; Detail = $_.Exception.Message }
    }
    $colour = switch ($r.Status) { 'PASS' { 'Green' } 'FAIL' { 'Yellow' } default { 'DarkYellow' } }
    Write-Host ("   {0}  {1}" -f $r.Status, $r.Population) -ForegroundColor $colour
    if ($r.Detail) { Write-Host "   $($r.Detail)" -ForegroundColor DarkGray }
    $results.Add([pscustomobject]@{
        Gate = $Name; Proves = $Proves; Status = $r.Status; Population = $r.Population; Detail = $r.Detail })
}

# --- 1. generator builds ------------------------------------------------------------------
Add-Gate 'generator-build' 'the generator itself compiles' {
    $o = & dotnet build (Join-Path $repoRoot 'tools\WrapperGenerator\WrapperGenerator.csproj') -c $Configuration --nologo -v quiet *>&1 | Out-String
    $errors = [regex]::Match($o, '(\d+) Error\(s\)').Groups[1].Value
    $warns = [regex]::Match($o, '(\d+) Warning\(s\)').Groups[1].Value
    [pscustomobject]@{
        Status = if ($errors -eq '0') { 'PASS' } else { 'FAIL' }
        Population = "$warns warnings, $errors errors"
        Detail = ''
    }
}

# --- 2. unit tests ------------------------------------------------------------------------
Add-Gate 'unit-tests' 'classification and emission rules' {
    $o = & dotnet test (Join-Path $repoRoot 'tools\WrapperGenerator.Tests\WrapperGenerator.Tests.csproj') -c $Configuration --nologo -v minimal *>&1 | Out-String
    $m = [regex]::Match($o, 'Failed:\s+(\d+),\s+Passed:\s+(\d+)')
    if (-not $m.Success) { return [pscustomobject]@{ Status = 'FAIL'; Population = 'no test summary'; Detail = '' } }
    $failed = [int]$m.Groups[1].Value; $passed = [int]$m.Groups[2].Value
    [pscustomobject]@{
        # Zero tests passing is not a pass.
        Status = if ($failed -eq 0 -and $passed -gt 0) { 'PASS' } else { 'FAIL' }
        Population = "$passed passed, $failed failed"
        Detail = ''
    }
}

# --- 3. generate + compile + pack every module ---------------------------------------------
Add-Gate 'module-compile' 'emitted CLR types match the generated kiota members' {
    if ($SkipBuild) {
        return [pscustomobject]@{ Status = 'NOT-RUN'; Population = '-SkipBuild'; Detail = 'reusing modules already on disk' }
    }
    $mods = @(Get-ModuleCmdletDirs | Select-Object -ExpandProperty Module)
    if (-not $mods) { return [pscustomobject]@{ Status = 'FAIL'; Population = 'no modules'; Detail = "no <Module>/wrapper/$ApiVersion/Cmdlets under $CorpusRoot" } }
    $o = & (Join-Path $PSScriptRoot 'Build-WrapperModule.ps1') -Module $mods -ApiVersion $ApiVersion -Configuration $Configuration -SkipKiota -Pack *>&1 | Out-String
    # The summary table goes through Out-Host, which writes to the console directly and cannot
    # be captured - counting its rows here silently yields zero. The per-module "OK: n cmdlets
    # -> ...psd1" lines are Write-Host (stream 6), which *>&1 does capture, so count those.
    $ok = [regex]::Matches($o, '(?m)OK: \d+ cmdlets ->').Count
    $noCmdlets = [regex]::Matches($o, 'no cmdlets emitted').Count
    $otherFail = [regex]::Matches($o, '(?m)FAILED at (?!manifest)').Count
    [pscustomobject]@{
        Status = if ($ok -gt 0 -and $otherFail -eq 0) { 'PASS' } else { 'FAIL' }
        Population = "$ok built, $noCmdlets emitted no cmdlets"
        Detail = if ($otherFail) { "$otherFail module(s) failed for reasons other than emitting nothing" } else { '' }
    }
}

# --- 4. naming parity, over the whole corpus -----------------------------------------------
Add-Gate 'naming-parity' 'generated cmdlet names match the published SDK inventory' {
    # Module discovery in the parity gate only looks one level down, so pointing it at the root
    # would silently examine nothing. Each module is passed explicitly and the totals summed.
    # A module that emitted no cmdlets has nothing to compare; the parity script errors on an
    # empty folder, which would otherwise be tallied as a naming failure it is not.
    $empty = [System.Collections.Generic.List[string]]::new()
    $dirs = @(Get-ModuleCmdletDirs | ForEach-Object {
        if (-not @(Get-ChildItem $_.Cmdlets -Filter *.g.cs -File | Where-Object Name -ne 'Shared.g.cs')) {
            $empty.Add($_.Module); return
        }
        $_
    })
    if (-not $dirs) { return [pscustomobject]@{ Status = 'FAIL'; Population = 'no cmdlet folders'; Detail = '' } }
    $matched = 0; $joinable = 0; $failing = [System.Collections.Generic.List[string]]::new()
    # The module name travels WITH its path rather than being reconstructed by counting
    # Split-Path levels: that count was silently wrong the moment the layout gained a level,
    # and reported every module as "wrapper".
    foreach ($entry in $dirs) {
        $o = & (Join-Path $PSScriptRoot 'Compare-WrapperCmdletNames.ps1') -GeneratedPath $entry.Cmdlets *>&1 | Out-String
        $code = $LASTEXITCODE
        $m = [regex]::Match($o, 'TOTAL:\s+(\d+) of (\d+)')
        if ($m.Success) { $matched += [int]$m.Groups[1].Value; $joinable += [int]$m.Groups[2].Value }
        if ($code -ne 0) { $failing.Add($entry.Module) }
    }
    $emptyNote = if ($empty.Count) { "; $($empty.Count) module(s) emitted no cmdlets and were not compared: $($empty -join ', ')" } else { '' }
    [pscustomobject]@{
        Status = if ($failing.Count -eq 0 -and $joinable -gt 0) { 'PASS' } else { 'FAIL' }
        Population = "$matched of $joinable names match, across $($dirs.Count) module(s)"
        Detail = $(if ($failing.Count) { "non-matching in: $($failing -join ', ')" } else { '' }) + $emptyNote
    }
}

# --- 5. omission oracle --------------------------------------------------------------------
Add-Gate 'omission-oracle' 'every settable kiota body member is bound or cited' {
    $o = & (Join-Path $PSScriptRoot 'Test-BodyBindingCoverage.ps1') *>&1 | Out-String
    $code = $LASTEXITCODE
    $cmdlets = [regex]::Match($o, 'cmdlets examined\s*:\s*(\d+)').Groups[1].Value
    $members = [regex]::Match($o, 'model members\s*:\s*(\d+)').Groups[1].Value
    $bound = [regex]::Match($o, 'bound by a param\s*:\s*(\d+)').Groups[1].Value
    $fails = [regex]::Match($o, 'failures\s*:\s*(\d+)').Groups[1].Value
    [pscustomobject]@{
        Status = if ($code -eq 0 -and [int]$cmdlets -gt 0) { 'PASS' } else { 'FAIL' }
        Population = "$cmdlets cmdlets, $members members, $bound bound, $fails failures"
        Detail = ''
    }
}

# --- 6. coverage sweep (measurement, not an independent gate) -------------------------------
Add-Gate 'coverage-sweep' 'what the classifier itself reports as unbound' {
    $o = & (Join-Path $PSScriptRoot 'Measure-BodyPropertyCoverage.ps1') *>&1 | Out-String
    $code = $LASTEXITCODE
    $m = [regex]::Match($o, '(?m)^\s*total\s+(\d+)\s+(\d+)\s*$')
    $unbound = if ($m.Success) { $m.Groups[1].Value } else { [regex]::Matches($o, 'unbound: (\d+)') | Measure-Object { $_ } | Select-Object -ExpandProperty Count }
    [pscustomobject]@{
        Status = if ($code -eq 0) { 'PASS' } else { 'FAIL' }
        Population = "exit $code"
        Detail = 'reads the generator''s own diagnostics - a measurement instrument, not an independent gate'
    }
}

# --- 7. runtime binding ---------------------------------------------------------------------
Add-Gate 'runtime-binding' 'PowerShell converts each bound shape at runtime' {
    # The target framework is not named here: the module projects declare it in their template,
    # and a hard-coded folder went silently blind the day that value changed.
    $mods = @(Get-ModuleCmdletDirs | Where-Object {
        $bin = Join-Path (Split-Path $_.Cmdlets -Parent) "bin\$Configuration"
        (Test-Path $bin) -and @(Get-ChildItem $bin -Recurse -Filter 'Microsoft.Graph.Wrapper.*.psd1' -File -ErrorAction SilentlyContinue)
    } | Select-Object -ExpandProperty Module | Sort-Object -Unique)
    if (-not $mods) { return [pscustomobject]@{ Status = 'FAIL'; Population = 'no manifests'; Detail = 'nothing built to test' } }
    # No -Configuration: this gate validates the PACKED module, not build output, and
    # Test-WrapperModule.ps1 has no such parameter - passing it threw before the call ran.
    # Staleness is that script's own concern; it refuses a package older than its project.
    $o = & (Join-Path $PSScriptRoot 'Test-WrapperModule.ps1') -Module $mods -ApiVersion $ApiVersion *>&1 | Out-String
    $code = $LASTEXITCODE
    $pass = [regex]::Matches($o, '(?m)^\s+PASS: ').Count
    $fail = [regex]::Matches($o, '(?m)^\s+FAIL: ').Count
    $untyped = [regex]::Matches($o, 'untyped OK\(\d+\)').Count
    [pscustomobject]@{
        Status = if ($code -eq 0 -and $pass -eq $mods.Count) { 'PASS' } else { 'FAIL' }
        Population = "$pass of $($mods.Count) modules, $untyped with untyped conversions verified"
        Detail = if ($fail) { "$fail module(s) failed" } else { '' }
    }
}

# --- 8. operation inventory -----------------------------------------------------------------
Add-Gate 'operation-inventory' 'a parameter change did not alter which operations generate' {
    if (-not $InventoryBaseline) {
        return [pscustomobject]@{ Status = 'NOT-RUN'; Population = 'no baseline supplied'
            Detail = 'pass -InventoryBaseline from a PREVIOUS generator; same-tree comparison is tautological' }
    }
    if (-not (Test-Path $InventoryBaseline)) {
        return [pscustomobject]@{ Status = 'FAIL'; Population = 'baseline missing'; Detail = $InventoryBaseline }
    }
    # An unstamped baseline has unverifiable provenance: the compare script only WARNS, and this
    # runner captures that warning, so without this check the result would look fully verified.
    if (-not (Test-Path "$InventoryBaseline.generator")) {
        return [pscustomobject]@{ Status = 'NOT-RUN'; Population = 'baseline unstamped'
            Detail = "no $([System.IO.Path]::GetFileName($InventoryBaseline)).generator stamp - cannot prove the baseline predates this generator" }
    }
    $after = Join-Path ([System.IO.Path]::GetTempPath()) "wrapper-inventory-after.csv"
    $o = & (Join-Path $PSScriptRoot 'Compare-WrapperOperationInventory.ps1') -Path $CorpusRoot -Baseline $InventoryBaseline -Compare $after *>&1 | Out-String
    $code = $LASTEXITCODE
    $added = [regex]::Match($o, 'added:\s+(\d+)').Groups[1].Value
    $removed = [regex]::Match($o, 'removed:\s+(\d+)').Groups[1].Value
    [pscustomobject]@{
        Status = if ($code -eq 0) { 'PASS' } elseif ($code -eq 2) { 'NOT-RUN' } else { 'FAIL' }
        Population = if ($added -or $removed) { "$added added, $removed removed" } else { "exit $code" }
        Detail = if ($code -eq 2) { 'baseline came from this same generator' } else { '' }
    }
}

# --- report ----------------------------------------------------------------------------------
Write-Host ''
$results | Format-Table Gate, Status, Population -AutoSize | Out-Host

$failed = @($results | Where-Object Status -eq 'FAIL')
$notRun = @($results | Where-Object Status -eq 'NOT-RUN')

Write-Host '=== validation block (generated from the run above) ===' -ForegroundColor Cyan
Write-Host 'Validation:'
foreach ($r in $results) {
    $tag = switch ($r.Status) { 'PASS' { '' } 'FAIL' { ' [FAILED]' } default { ' [NOT RUN]' } }
    Write-Host ("- {0}: {1}{2}" -f $r.Gate, $r.Population, $tag)
}
Write-Host ''

if ($failed.Count) {
    Write-Host "VERDICT: FAILED - $($failed.Count) gate(s): $(($failed.Gate) -join ', ')" -ForegroundColor Red
    exit 1
}
if ($notRun.Count) {
    Write-Host "VERDICT: INCOMPLETE - $($notRun.Count) gate(s) did not run: $(($notRun.Gate) -join ', ')" -ForegroundColor DarkYellow
    Write-Host "         Not a pass. Supply what they need, or say plainly that they were not run." -ForegroundColor DarkYellow
    exit 2
}
Write-Host "VERDICT: all $($results.Count) gates passed." -ForegroundColor Green
exit 0
