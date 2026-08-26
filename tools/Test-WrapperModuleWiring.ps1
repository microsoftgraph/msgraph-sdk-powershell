# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
<#
.SYNOPSIS
Proves that the set of wrapper modules configured, owned in source, built, packed and importable
are all the same set - and names every module that differs.

.DESCRIPTION
Validation must not grade its own output. A build script that reports "35 modules built" is
reporting how many times it succeeded, which says nothing about how many it should have
attempted. This compares populations observed at seven independent points and fails on any
member that appears in one and not another:

  1. configured     config/ModulesMapping.jsonc with a doc under openApiDocs/<ApiVersion>
  2. client-source  src/<Module>/<ApiVersion>/wrapper/Client/ApiClient.cs exists
  3. cmdlet-source  .../wrapper/Cmdlets/*.g.cs exists
  4. project        .../wrapper/<ModuleName>.csproj exists AND its import chain evaluates
  5. compiled       .../wrapper/bin/<Configuration>/<TargetFramework>/<ModuleName>.dll exists
  6. packaged       <ArtifactsLocation>/<Module>/<ModuleName>.<version>.nupkg carries the
                    manifest and the assembly
  7. imported       Import-Module of the built manifest succeeds and exports cmdlets

Sets 2-7 are compared against the EXPECTED population, not against each other's leftovers, so a
module missing everywhere is still reported once per stage rather than vanishing.

The expected population is derived in two stages, and neither stage is a list anyone maintains.
Stage one is set 1. Stage two removes the modules for which the generator emits no cmdlets:
those produce no assembly and no package, so requiring one would fail forever. Membership of
that second set is MEASURED by running the generator for each configured module that has no
cmdlet source and checking that it really does emit nothing. A module that turns out to emit
cmdlets is a failure - it should have been generated - so the exemption cannot outlive the
generator gap that caused it.

Two portability checks run alongside, because output that builds here and not on a clean clone
passes every population comparison above:

  * no committed file under wrapper/ is excluded by a gitignore rule (the Kiota client derives
    directory names from Graph URL paths, and segments like Publish/, Log/ and BackupRestore/
    collide with the Visual Studio ignore rules)
  * no committed file under wrapper/ records an absolute path

Exit codes: 0 all populations agree, 1 a comparison failed, 2 the run could not be completed.

.PARAMETER ApiVersion
v1.0 (default) or beta.

.PARAMETER Configuration
Build configuration whose output to inspect. Default: Release.

.PARAMETER SkipPackaging
Skip set 6. Use only when packages were deliberately not produced; the run then reports
INCOMPLETE rather than success.

.PARAMETER SkipImport
Skip set 7 the same way.

.EXAMPLE
.\tools\Test-WrapperModuleWiring.ps1

.EXAMPLE
.\tools\Test-WrapperModuleWiring.ps1 -Configuration Debug -SkipPackaging
#>
[CmdletBinding()]
param(
    [ValidateSet('v1.0', 'beta')]
    [string]$ApiVersion = 'v1.0',
    [string]$Configuration = 'Release',
    [string]$ArtifactsLocation,
    [string]$ModuleMappingConfigPath,
    [string]$ModuleMetadataPath,
    [string]$WrapperPropsPath,
    [switch]$SkipPackaging,
    [switch]$SkipImport
)

$ErrorActionPreference = 'Stop'

# Fail closed. A validator that dies partway through has proved nothing, and the shell will
# happily report success for a script that stopped before printing a verdict - which is the one
# outcome indistinguishable from a clean run. Any unhandled error exits INCOMPLETE instead.
trap {
    Write-Host ''
    Write-Host "VERDICT: INCOMPLETE - the run did not finish: $($_.Exception.Message)" -ForegroundColor Red
    Write-Host "         at $($_.InvocationInfo.ScriptName):$($_.InvocationInfo.ScriptLineNumber)" -ForegroundColor DarkGray
    exit 2
}

$repoRoot = (Resolve-Path (Join-Path $PSScriptRoot '..')).Path
if (-not $ArtifactsLocation) { $ArtifactsLocation = Join-Path $repoRoot 'artifacts' }
if (-not $ModuleMappingConfigPath) { $ModuleMappingConfigPath = Join-Path $repoRoot 'config\ModulesMapping.jsonc' }
if (-not $ModuleMetadataPath) { $ModuleMetadataPath = Join-Path $repoRoot 'config\ModuleMetadata.json' }
if (-not $WrapperPropsPath) { $WrapperPropsPath = Join-Path $repoRoot 'config\Wrapper.Build.props' }

. (Join-Path $PSScriptRoot 'Utilities\WrapperModuleSet.ps1')

$targetFramework = Get-WrapperTargetFramework -WrapperPropsPath $WrapperPropsPath
[HashTable]$moduleMetadata = Get-Content $ModuleMetadataPath -Raw | ConvertFrom-Json -AsHashTable
$versionEntry = $moduleMetadata.versions[$ApiVersion]
$fullVersion = if ($versionEntry.prerelease) { "$($versionEntry.version)-$($versionEntry.prerelease)" } else { $versionEntry.version }

$checks = [System.Collections.Generic.List[object]]::new()
function Add-Check {
    param(
        [Parameter(Mandatory)][string]$Name,
        [Parameter(Mandatory)][string]$Status,
        [Parameter(Mandatory)][string]$Population,
        [string]$Detail = ''
    )
    $colour = switch ($Status) { 'PASS' { 'Green' } 'FAIL' { 'Red' } default { 'DarkYellow' } }
    Write-Host ("-> {0,-16} {1,-9} {2}" -f $Name, $Status, $Population) -ForegroundColor $colour
    if ($Detail) { Write-Host "   $Detail" -ForegroundColor DarkGray }
    $checks.Add([pscustomobject]@{ Check = $Name; Status = $Status; Population = $Population; Detail = $Detail })
}

# Compares an observed population against the expected one and reports BOTH directions. Only
# reporting what is missing hides a module that was built but should not have been.
function Compare-Population {
    param(
        [Parameter(Mandatory)][string]$Name,
        [Parameter(Mandatory)][AllowEmptyCollection()][string[]]$Expected,
        [Parameter(Mandatory)][AllowEmptyCollection()][string[]]$Observed
    )
    $missing = @($Expected | Where-Object { $Observed -notcontains $_ })
    $extra = @($Observed | Where-Object { $Expected -notcontains $_ })
    $detail = @(
        if ($missing.Count) { "missing ($($missing.Count)): $($missing -join ', ')" }
        if ($extra.Count) { "extra ($($extra.Count)): $($extra -join ', ')" }
    ) -join '; '
    Add-Check -Name $Name -Status $(if ($missing.Count -eq 0 -and $extra.Count -eq 0) { 'PASS' } else { 'FAIL' }) `
        -Population "$($Observed.Count) of $($Expected.Count) expected" -Detail $detail
}

function Get-WrapperDir { param([string]$Name) Get-WrapperModuleSourcePath -RepoRoot $repoRoot -Module $Name -ApiVersion $ApiVersion }

Write-Host "Wrapper module wiring, $ApiVersion, $Configuration ($targetFramework)" -ForegroundColor Cyan
Write-Host ''

# --- 1. configured -----------------------------------------------------------------------
$configured = @(Get-WrapperModuleSet -ApiVersion $ApiVersion -ModuleMappingConfigPath $ModuleMappingConfigPath -RepoRoot $repoRoot)
Add-Check -Name 'configured' -Status 'PASS' -Population "$($configured.Count) modules" `
    -Detail "derived from $(Split-Path $ModuleMappingConfigPath -Leaf) intersected with openApiDocs/$ApiVersion"

# Every module that owns a wrapper tree, observed from the filesystem rather than by filtering
# the configured list. A tree belonging to a module that should not have one - a leftover from a
# module that stopped producing cmdlets, or one never in the mapping - is invisible to a scan
# that only looks up names it already expects.
$onDisk = @(Get-ChildItem (Join-Path $repoRoot 'src') -Directory |
        ForEach-Object { $_.Name } |
        Where-Object { Test-Path (Get-WrapperDir $_) } |
        Sort-Object)

# --- 3. cmdlet-source, measured first because it defines the expected population -----------
$cmdletSource = @($onDisk | Where-Object {
        $c = Join-Path (Get-WrapperDir $_) 'Cmdlets'
        (Test-Path $c) -and @(Get-ChildItem $c -Filter '*.g.cs' -File -ErrorAction SilentlyContinue |
            Where-Object Name -ne 'Shared.g.cs').Count -gt 0
    })

# --- 2b. why is anything missing? measure it, never assert it -----------------------------
# Each configured module with no cmdlet source is generated into a temp folder. Emitting
# nothing confirms a generator gap and the module is excused from every later population.
# Emitting something means the module was simply never generated into src/, which is a wiring
# failure and fails the run.
$noCmdlets = [System.Collections.Generic.List[string]]::new()
$ungenerated = [System.Collections.Generic.List[string]]::new()
$unmeasured = [System.Collections.Generic.List[string]]::new()
$candidates = @($configured | Where-Object { $cmdletSource -notcontains $_ })
if ($candidates.Count -gt 0) {
    Write-Host "   measuring $($candidates.Count) module(s) with no cmdlet source..." -ForegroundColor DarkGray
    $specRoot = Join-Path $repoRoot 'openApiDocs_KiotaCompat'
    $generator = Join-Path $repoRoot 'tools\WrapperGenerator'
    foreach ($name in $candidates) {
        $spec = Join-Path $specRoot "$ApiVersion\$name.yml"
        if (-not (Test-Path $spec)) { $spec = Join-Path $repoRoot "openApiDocs\$ApiVersion\$name.yml" }
        if (-not (Test-Path $spec)) { $unmeasured.Add("$name (no spec)"); continue }
        $probe = Join-Path ([System.IO.Path]::GetTempPath()) "wrapper-wiring-probe-$name"
        Remove-Item $probe -Recurse -Force -ErrorAction SilentlyContinue
        & dotnet run --project $generator -c Release -- -d $spec -o $probe -n "Microsoft.Graph.PowerShell.$name.Client" --api-version $ApiVersion *>&1 | Out-Null
        if ($LASTEXITCODE -ne 0) { $unmeasured.Add("$name (generator exit $LASTEXITCODE)"); continue }
        $emitted = @(Get-ChildItem $probe -Filter '*.g.cs' -File -ErrorAction SilentlyContinue | Where-Object Name -ne 'Shared.g.cs')
        if ($emitted.Count -eq 0) { $noCmdlets.Add($name) } else { $ungenerated.Add("$name ($($emitted.Count) cmdlets)") }
        Remove-Item $probe -Recurse -Force -ErrorAction SilentlyContinue
    }
}

if ($unmeasured.Count) {
    Add-Check -Name 'empty-modules' -Status 'NOT-RUN' -Population "$($unmeasured.Count) unmeasured" `
        -Detail "cannot tell whether these are generator gaps or wiring gaps: $($unmeasured -join ', ')"
}
elseif ($ungenerated.Count) {
    Add-Check -Name 'empty-modules' -Status 'FAIL' -Population "$($ungenerated.Count) not generated" `
        -Detail "these emit cmdlets but have no source under src/: $($ungenerated -join ', ')"
}
else {
    Add-Check -Name 'empty-modules' -Status 'PASS' -Population "$($noCmdlets.Count) emit no cmdlets" `
        -Detail $(if ($noCmdlets.Count) { "excused, measured this run: $($noCmdlets -join ', ')" } else { 'every configured module emits cmdlets' })
}

$expected = @($configured | Where-Object { $noCmdlets -notcontains $_ })
Write-Host ''
Write-Host "expected population: $($expected.Count) of $($configured.Count) configured" -ForegroundColor Cyan
Write-Host ''

Compare-Population -Name 'cmdlet-source' -Expected $expected -Observed $cmdletSource

# Any wrapper tree at all that is not expected is a leftover, even if it holds no cmdlets - it
# is committed source nothing references.
Compare-Population -Name 'source-trees' -Expected $expected -Observed $onDisk

# --- 2. client-source ---------------------------------------------------------------------
$clientSource = @($onDisk | Where-Object { Test-Path (Join-Path (Get-WrapperDir $_) 'Client\ApiClient.cs') })
Compare-Population -Name 'client-source' -Expected $expected -Observed $clientSource

# --- 4. project ---------------------------------------------------------------------------
# Existence of the file is not enough: the project imports Repo.props by upward search and
# config/Wrapper.Build.props through it, and a broken chain fails only at build time. Asking
# MSBuild to evaluate the project and hand back AssemblyName proves the chain resolves.
$projectOwned = [System.Collections.Generic.List[string]]::new()
$projectBroken = [System.Collections.Generic.List[string]]::new()
foreach ($name in $onDisk) {
    $csproj = Join-Path (Get-WrapperDir $name) "$(Get-WrapperModuleName -Module $name).csproj"
    if (-not (Test-Path $csproj)) { continue }
    $evaluated = & dotnet msbuild $csproj -nologo -getProperty:AssemblyName -getProperty:TargetFramework 2>&1 | Out-String
    if ($LASTEXITCODE -ne 0) { $projectBroken.Add("$name (evaluation failed)"); continue }
    if ($evaluated -notmatch [regex]::Escape((Get-WrapperModuleName -Module $name))) { $projectBroken.Add("$name (unexpected AssemblyName)"); continue }
    if ($evaluated -notmatch [regex]::Escape($targetFramework)) { $projectBroken.Add("$name (framework is not $targetFramework)"); continue }
    $projectOwned.Add($name)
}
Compare-Population -Name 'project' -Expected $expected -Observed $projectOwned
if ($projectBroken.Count) {
    Add-Check -Name 'project-imports' -Status 'FAIL' -Population "$($projectBroken.Count) broken" -Detail ($projectBroken -join ', ')
}

# --- 5. compiled --------------------------------------------------------------------------
$compiled = @($onDisk | Where-Object {
        Test-Path (Join-Path (Get-WrapperDir $_) "bin\$Configuration\$targetFramework\$(Get-WrapperModuleName -Module $_).dll")
    })
Compare-Population -Name 'compiled' -Expected $expected -Observed $compiled

# --- 6. packaged --------------------------------------------------------------------------
if ($SkipPackaging) {
    Add-Check -Name 'packaged' -Status 'NOT-RUN' -Population '-SkipPackaging' -Detail 'packages were not inspected'
}
else {
    Add-Type -AssemblyName System.IO.Compression.FileSystem
    $packaged = [System.Collections.Generic.List[string]]::new()
    $badPackage = [System.Collections.Generic.List[string]]::new()
    # Observed by scanning the artifacts tree, so a package produced for a module that should
    # not ship is reported as extra rather than skipped over.
    $packagedCandidates = @(Get-ChildItem $ArtifactsLocation -Directory -ErrorAction SilentlyContinue |
            Where-Object { Get-ChildItem $_.FullName -Filter 'Microsoft.Graph.Wrapper.*.nupkg' -File -ErrorAction SilentlyContinue } |
            ForEach-Object { $_.Name })
    foreach ($name in $packagedCandidates) {
        $moduleName = Get-WrapperModuleName -Module $name
        $nupkg = Join-Path $ArtifactsLocation "$name\$moduleName.$fullVersion.nupkg"
        if (-not (Test-Path $nupkg)) { $badPackage.Add("$name (no $moduleName.$fullVersion.nupkg)"); continue }
        # A package that exists but carries no manifest or no assembly installs as an empty
        # module, so presence of the file is not the assertion - its contents are.
        $zip = [System.IO.Compression.ZipFile]::OpenRead($nupkg)
        try {
            $names = @($zip.Entries.FullName)
            $hasPsd1 = @($names | Where-Object { $_ -eq "$moduleName.psd1" }).Count -gt 0
            $hasDll = @($names | Where-Object { $_ -eq "$moduleName.dll" }).Count -gt 0
            if ($hasPsd1 -and $hasDll) { $packaged.Add($name) }
            else { $badPackage.Add("$name (psd1=$hasPsd1 dll=$hasDll)") }
        }
        finally { $zip.Dispose() }
    }
    Compare-Population -Name 'packaged' -Expected $expected -Observed $packaged
    if ($badPackage.Count) {
        Add-Check -Name 'package-contents' -Status 'FAIL' -Population "$($badPackage.Count) incomplete" -Detail ($badPackage -join ', ')
    }
}

# --- 7. imported --------------------------------------------------------------------------
if ($SkipImport) {
    Add-Check -Name 'imported' -Status 'NOT-RUN' -Population '-SkipImport' -Detail 'modules were not imported'
}
else {
    # A fresh child process per module: assemblies cannot be unloaded, and Import-Module silently
    # no-ops when a same-name module is already loaded, so importing them all in this process
    # would report a pass for modules it never actually loaded.
    $importResults = $onDisk | ForEach-Object -Parallel {
        $name = $_
        $moduleName = "Microsoft.Graph.Wrapper.$name"
        $psd1 = Join-Path $using:repoRoot "src\$name\$using:ApiVersion\wrapper\bin\$using:Configuration\$using:targetFramework\$moduleName.psd1"
        if (-not (Test-Path $psd1)) { return @{ Module = $name; Ok = $false; Exported = 0; Error = 'no manifest' } }
        # Single-quoted here-string: the child's own $-expressions must survive being built here,
        # so nothing in the template is expanded until pwsh runs it. Substitution is by token
        # rather than -f, because the template's own try/catch braces are not format placeholders.
        $template = @'
$ErrorActionPreference = 'Stop'
try {
    Import-Module '__PSD1__' -ErrorAction Stop
    $count = @(Get-Command -Module '__MODULE__' -CommandType Cmdlet).Count
    Write-Output "EXPORTED=$count"
}
catch {
    Write-Output "ERROR=$($_.Exception.Message)"
}
'@
        $childScript = $template.Replace('__PSD1__', $psd1).Replace('__MODULE__', $moduleName)
        $encoded = [Convert]::ToBase64String([System.Text.Encoding]::Unicode.GetBytes($childScript))
        $out = & pwsh -NonInteractive -NoLogo -NoProfile -EncodedCommand $encoded 2>&1 | Out-String
        $m = [regex]::Match($out, 'EXPORTED=(\d+)')
        if ($m.Success -and [int]$m.Groups[1].Value -gt 0) { return @{ Module = $name; Ok = $true; Exported = [int]$m.Groups[1].Value; Error = '' } }
        $e = [regex]::Match($out, 'ERROR=(.*)')
        return @{ Module = $name; Ok = $false; Exported = 0; Error = if ($e.Success) { $e.Groups[1].Value.Trim() } else { ($out.Trim() -split "`n")[0] } }
    } -ThrottleLimit ([int][math]::Max(1, [math]::Min(4, [System.Environment]::ProcessorCount / 2)))

    $imported = @($importResults | Where-Object { $_.Ok } | ForEach-Object { $_.Module })
    $importFailed = @($importResults | Where-Object { -not $_.Ok } | ForEach-Object { "$($_.Module): $($_.Error)" })
    Compare-Population -Name 'imported' -Expected $expected -Observed $imported
    $totalExported = ($importResults | Where-Object { $_.Ok } | Measure-Object -Property Exported -Sum).Sum
    Add-Check -Name 'exported-cmdlets' -Status $(if ($importFailed.Count -eq 0 -and $totalExported -gt 0) { 'PASS' } else { 'FAIL' }) `
        -Population "$totalExported cmdlets across $($imported.Count) module(s)" `
        -Detail $(if ($importFailed.Count) { ($importFailed -join '; ') } else { '' })
}

# --- public command collisions across modules ----------------------------------------------
# Two modules exporting the same command name make it ambiguous once both are imported, and no
# per-module gate can see it: the generator reads one spec at a time and the compile gate only
# ever looks inside one assembly. Workers are excluded - they are internal dispatch targets,
# already namespaced by the dispatcher that calls them.
$publicByName = @{}
foreach ($name in $cmdletSource) {
    $dir = Join-Path (Get-WrapperDir $name) 'Cmdlets'
    foreach ($file in Get-ChildItem $dir -Filter '*.g.cs' -File -ErrorAction SilentlyContinue) {
        if ($file.Name -eq 'Shared.g.cs' -or $file.Name -match '_(Get|List)\.g\.cs$') { continue }
        $m = [regex]::Match((Get-Content $file.FullName -Raw), '\[Cmdlet\(Verbs\w+\.(\w+),\s*"((?:\\.|[^"\\])*)"')
        if (-not $m.Success) { continue }
        $cmdlet = "$($m.Groups[1].Value)-$([regex]::Unescape($m.Groups[2].Value))"
        if (-not $publicByName.ContainsKey($cmdlet)) { $publicByName[$cmdlet] = [System.Collections.Generic.HashSet[string]]::new() }
        [void]$publicByName[$cmdlet].Add($name)
    }
}
$collisions = @($publicByName.GetEnumerator() | Where-Object { $_.Value.Count -gt 1 } | Sort-Object Key)
Add-Check -Name 'no-collisions' -Status $(if ($collisions.Count -eq 0) { 'PASS' } else { 'FAIL' }) `
    -Population "$($collisions.Count) command(s) exported by more than one module, of $($publicByName.Count) public" `
    -Detail $(if ($collisions.Count) {
        (($collisions | Select-Object -First 5 | ForEach-Object { "$($_.Key) [$(($_.Value | Sort-Object) -join ', ')]" }) -join '; ') +
        $(if ($collisions.Count -gt 5) { "; and $($collisions.Count - 5) more" } else { '' })
    } else { '' })

# --- portability: nothing committed may be unreachable on a clean clone --------------------
# git check-ignore reports negation matches too, so a pattern beginning with ! is a rule that
# RE-INCLUDES the file and must not be counted as an exclusion.
$ignoredSource = @()
$absolutePaths = @()
if (Get-Command git -ErrorAction SilentlyContinue) {
    foreach ($name in $onDisk) {
        $dir = Get-WrapperDir $name
        if (-not (Test-Path $dir)) { continue }
        $files = @(Get-ChildItem $dir -Recurse -File -Include '*.cs', '*.csproj', '*.json' -ErrorAction SilentlyContinue |
            Where-Object { $_.FullName -notmatch '\\(bin|obj)\\' })
        if (-not $files) { continue }
        $checked = $files.FullName | & git -C $repoRoot check-ignore -v --stdin 2>$null
        foreach ($line in $checked) {
            $pattern = ($line -split "`t")[0]
            if ($pattern -and $pattern -notmatch ':!') { $ignoredSource += ($line -split "`t")[1] }
        }
        foreach ($json in ($files | Where-Object Extension -eq '.json')) {
            if ((Get-Content $json.FullName -Raw) -match '[A-Za-z]:\\\\|[A-Za-z]:/') { $absolutePaths += $json.FullName.Substring($repoRoot.Length + 1) }
        }
    }
    Add-Check -Name 'not-ignored' -Status $(if ($ignoredSource.Count -eq 0) { 'PASS' } else { 'FAIL' }) `
        -Population "$($ignoredSource.Count) committed source file(s) excluded by gitignore" `
        -Detail $(if ($ignoredSource.Count) { ($ignoredSource | Select-Object -First 5) -join ', ' } else { '' })
    Add-Check -Name 'portable-paths' -Status $(if ($absolutePaths.Count -eq 0) { 'PASS' } else { 'FAIL' }) `
        -Population "$($absolutePaths.Count) file(s) recording an absolute path" `
        -Detail $(if ($absolutePaths.Count) { ($absolutePaths | Select-Object -First 5) -join ', ' } else { '' })
}
else {
    Add-Check -Name 'not-ignored' -Status 'NOT-RUN' -Population 'git unavailable' -Detail ''
    Add-Check -Name 'portable-paths' -Status 'NOT-RUN' -Population 'git unavailable' -Detail ''
}

# --- report --------------------------------------------------------------------------------
Write-Host ''
$checks | Format-Table Check, Status, Population -AutoSize | Out-Host

$failed = @($checks | Where-Object Status -eq 'FAIL')
$notRun = @($checks | Where-Object Status -eq 'NOT-RUN')

Write-Host '=== validation block (generated from the run above) ===' -ForegroundColor Cyan
Write-Host "Wrapper module wiring ($ApiVersion, $Configuration):"
foreach ($c in $checks) {
    $tag = switch ($c.Status) { 'PASS' { '' } 'FAIL' { ' [FAILED]' } default { ' [NOT RUN]' } }
    Write-Host ("- {0}: {1}{2}" -f $c.Check, $c.Population, $tag)
}
Write-Host ''

if ($failed.Count) {
    Write-Host "VERDICT: FAILED - $($failed.Count) check(s): $(($failed.Check) -join ', ')" -ForegroundColor Red
    exit 1
}
if ($notRun.Count) {
    Write-Host "VERDICT: INCOMPLETE - $($notRun.Count) check(s) did not run: $(($notRun.Check) -join ', ')" -ForegroundColor DarkYellow
    exit 2
}
Write-Host "VERDICT: all $($checks.Count) checks passed; $($expected.Count) of $($configured.Count) configured modules wired end to end." -ForegroundColor Green
exit 0
