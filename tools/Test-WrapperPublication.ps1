<#
.SYNOPSIS
Runs the fresh dual-profile generation/compilation gate required before a module PR.
.DESCRIPTION
Uses Build-WrapperModule without inner-loop shortcuts. Missing Kiota-compatible inputs,
NO-CMDLETS, failed/skipped stages and stale/missing artifacts cannot authorize publication.
This gate does not replace reviewed directive inventory, regression tests or parity review.
.PARAMETER Module
Exactly one configured module. Both v1.0 and beta are always required.
.PARAMETER ResultPath
Optional persistent JSON evidence. Build logs and per-profile results are written beside it.
#>
[CmdletBinding()]
param(
    [string]$Module,
    [string]$Configuration = 'Release',
    [string]$ResultPath
)

$ErrorActionPreference = 'Stop'
$repoRoot = (Resolve-Path (Join-Path $PSScriptRoot '..')).Path

function Test-WrapperPublicationSourcePath([string]$Path) {
    $Path -notmatch '[/\\](bin|obj)[/\\]'
}

function Assert-WrapperPublicationResult {
    param(
        [Parameter(Mandatory)][object[]]$Results,
        [Parameter(Mandatory)][string]$ModuleName,
        [Parameter(Mandatory)][string]$RepositoryRoot,
        [string]$BuildConfiguration = 'Release'
    )
    if ($Results.Count -ne 2) { throw 'Publication requires exactly two profile results.' }
    $targetFramework = "$(([xml](Get-Content (Join-Path $RepositoryRoot 'tools\Templates\WrapperModule.csproj.template') -Raw)).Project.PropertyGroup.TargetFramework)".Trim()
    if (-not $targetFramework) { throw 'Publication module template has no TargetFramework.' }
    foreach ($profile in @('v1.0', 'beta')) {
        $matches = @($Results | Where-Object { $_.Module -ceq $ModuleName -and $_.ApiVersion -ceq $profile })
        if ($matches.Count -ne 1) { throw "Publication requires one $ModuleName/$profile result." }
        $r = $matches[0]
        if ($r.Status -cne 'OK' -or $r.CmdletCount -le 0 -or $r.EmittedCmdletCount -le 0) {
            throw "$ModuleName/$profile did not emit and compile cmdlets: $($r.Status) $($r.FailedAt) $($r.Error)"
        }
        if ($r.CmdletCount -ne $r.EmittedCmdletCount) { throw "$ModuleName/$profile emitted/compiled cmdlet counts disagree." }
        if ($r.StrictPublication -ne $true -or $r.KiotaGenerated -ne $true -or
            $r.WrapperGenerated -ne $true -or $r.Compiled -ne $true) {
            throw "$ModuleName/$profile skipped required full generation/compilation."
        }
        $specPath = Join-Path $RepositoryRoot "openApiDocs_KiotaCompat\$profile\$ModuleName.yml"
        if (-not (Test-Path -LiteralPath $specPath -PathType Leaf)) { throw "Missing specification: $specPath" }
        if ($r.SpecPath -cne $specPath -or $r.SpecSha256 -ne (Get-FileHash -LiteralPath $specPath -Algorithm SHA256).Hash) {
            throw "$ModuleName/$profile specification identity changed or used a fallback."
        }
        $started = ([DateTime]$r.StartedUtc).ToUniversalTime()
        $finished = ([DateTime]$r.FinishedUtc).ToUniversalTime()
        if ($finished -lt $started) { throw "$ModuleName/$profile has invalid run timestamps." }
        $root = Join-Path $RepositoryRoot "src\$ModuleName\wrapper\$profile"
        $moduleAssembly = "Microsoft.Graph.Wrapper.$ModuleName"
        $bin = Join-Path $root "bin\$BuildConfiguration\$targetFramework"
        $expected = @{
            ClientPath = Join-Path $root 'Client\ApiClient.cs'
            CmdletsPath = Join-Path $root 'Cmdlets'
            AssemblyPath = Join-Path $bin "$moduleAssembly.dll"
            ClientAssemblyPath = Join-Path $bin "$moduleAssembly.Client.dll"
            Psd1 = Join-Path $bin "$moduleAssembly.psd1"
        }
        foreach ($property in $expected.Keys) {
            if ($r.$property -cne $expected[$property]) { throw "$ModuleName/$profile unexpected $property path." }
        }
        $files = @($expected.ClientPath, $expected.AssemblyPath, $expected.ClientAssemblyPath, $expected.Psd1,
            (Join-Path $root 'Client\kiota-lock.json'), (Join-Path $root 'Cmdlets\kiota-lock.json'),
            (Join-Path $root 'Client\Client.csproj'), (Join-Path $root "$moduleAssembly.csproj"))
        $emitted = @(Get-ChildItem -LiteralPath $expected.CmdletsPath -Filter '*.g.cs' -File |
            Where-Object Name -ne 'Shared.g.cs')
        if ($emitted.Count -ne $r.EmittedCmdletCount) { throw "$ModuleName/$profile emitted count changed." }
        $files += @($emitted.FullName)
        $files += @(Get-ChildItem -LiteralPath (Join-Path $root 'Client') -Filter '*.cs' -File -Recurse |
            Where-Object { Test-WrapperPublicationSourcePath $_.FullName } | ForEach-Object FullName)
        foreach ($path in $files) {
            if (-not (Test-Path -LiteralPath $path -PathType Leaf)) { throw "Missing publication artifact: $path" }
            $file = Get-Item -LiteralPath $path
            if ($file.Length -eq 0 -or $file.LastWriteTimeUtc -lt $started -or $file.LastWriteTimeUtc -gt $finished) {
                throw "Stale, empty or modified publication artifact: $path"
            }
        }
        $manifest = Import-PowerShellDataFile -LiteralPath $expected.Psd1
        if ($manifest.RootModule -cne "$moduleAssembly.dll" -or @($manifest.CmdletsToExport).Count -ne $r.CmdletCount -or
            @($manifest.CmdletsToExport | Where-Object { $_ -match '[*?]' }).Count) {
            throw "$ModuleName/$profile manifest does not describe the compiled cmdlets."
        }
    }
}

function Get-WrapperPublicationInputFingerprint([string]$ModuleName) {
    $paths = @(
        Get-ChildItem (Join-Path $repoRoot 'tools\WrapperGenerator') -File -Recurse |
            Where-Object { Test-WrapperPublicationSourcePath $_.FullName }
        Get-ChildItem (Join-Path $repoRoot 'src') -Filter '*_cmdletConfigurations.cs' -File -Recurse |
            Where-Object { Test-WrapperPublicationSourcePath $_.FullName }
        Get-ChildItem (Join-Path $repoRoot 'src\GraphWrapperRuntime\Runtime') -File -Recurse |
            Where-Object { Test-WrapperPublicationSourcePath $_.FullName }
        Get-ChildItem (Join-Path $repoRoot 'src\Authentication\Authentication') -File -Recurse |
            Where-Object { Test-WrapperPublicationSourcePath $_.FullName }
        Get-ChildItem (Join-Path $repoRoot 'src\Authentication\Authentication.Core') -File -Recurse |
            Where-Object { Test-WrapperPublicationSourcePath $_.FullName }
        Get-Item (Join-Path $repoRoot 'tools\Build-WrapperModule.ps1'), (Join-Path $repoRoot 'tools\Test-WrapperPublication.ps1'),
            (Join-Path $repoRoot 'tools\Templates\WrapperClient.csproj.template'),
            (Join-Path $repoRoot 'tools\Templates\WrapperModule.csproj.template'),
            (Join-Path $repoRoot 'Repo.props'),
            (Join-Path $repoRoot 'config\ModulesMapping.jsonc'), (Join-Path $repoRoot 'config\ModuleMetadata.json'),
            (Join-Path $repoRoot "openApiDocs_KiotaCompat\v1.0\$ModuleName.yml"),
            (Join-Path $repoRoot "openApiDocs_KiotaCompat\beta\$ModuleName.yml")
    )
    $identity = ($paths | Sort-Object FullName -Unique | ForEach-Object {
        "$([IO.Path]::GetRelativePath($repoRoot, $_.FullName)) $((Get-FileHash -LiteralPath $_.FullName -Algorithm SHA256).Hash)"
    }) -join "`n"
    [Convert]::ToHexString([Security.Cryptography.SHA256]::HashData([Text.Encoding]::UTF8.GetBytes($identity)))
}

# Dot-sourcing exposes the artifact assertion to the focused fixture tests without running builds.
if ($MyInvocation.InvocationName -eq '.') { return }
if (-not $Module) { throw 'Specify exactly one -Module for dual-profile publication validation.' }
$configured = Get-Content (Join-Path $repoRoot 'config\ModulesMapping.jsonc') -Raw | ConvertFrom-Json -AsHashtable
if (-not $configured.ContainsKey($Module)) { throw "Module is not configured: $Module" }
foreach ($profile in @('v1.0', 'beta')) {
    $spec = Join-Path $repoRoot "openApiDocs_KiotaCompat\$profile\$Module.yml"
    if (-not (Test-Path -LiteralPath $spec -PathType Leaf)) { throw "Missing required Kiota-compatible specification: $spec" }
}
$temporary = -not $ResultPath
if ($temporary) { $ResultPath = Join-Path ([IO.Path]::GetTempPath()) "wrapper-publication-$([guid]::NewGuid()).json" }
$ResultPath = [IO.Path]::GetFullPath($ResultPath)
$inputFingerprint = Get-WrapperPublicationInputFingerprint $Module
$results = @()
$failures = @()
try {
    foreach ($profile in @('v1.0', 'beta')) {
        $profileResult = "$ResultPath.$profile.json"
        $logPath = "$ResultPath.$profile.log"
        if (Test-Path -LiteralPath $profileResult) { Remove-Item -LiteralPath $profileResult -Force }
        & pwsh -NoProfile -NonInteractive -File (Join-Path $PSScriptRoot 'Build-WrapperModule.ps1') `
            -Module $Module -ApiVersion $profile -Configuration $Configuration -StrictPublication -ResultPath $profileResult *> $logPath
        $exitCode = $LASTEXITCODE
        if (Test-Path -LiteralPath $profileResult) { $results += @(Get-Content -LiteralPath $profileResult -Raw | ConvertFrom-Json) }
        if ($exitCode -ne 0) { $failures += "$profile exited $exitCode (see $logPath)" }
    }
    if ($inputFingerprint -cne (Get-WrapperPublicationInputFingerprint $Module)) { $failures += 'Generation/build inputs changed during the dual-profile run.' }
    try { Assert-WrapperPublicationResult -Results $results -ModuleName $Module -RepositoryRoot $repoRoot -BuildConfiguration $Configuration }
    catch { $failures += $_.Exception.Message }
    [pscustomobject]@{
        Module = $Module; Status = if ($failures.Count) { 'FAILED' } else { 'OK' }
        InputFingerprint = $inputFingerprint; Results = $results; Errors = $failures
    } | ConvertTo-Json -Depth 8 | Set-Content -LiteralPath $ResultPath
    if ($failures.Count) { throw "Dual-profile publication validation failed: $($failures -join '; ')" }
    Write-Host "PASS: $Module full v1.0 and beta generation/compilation; fresh cmdlets, assemblies and manifests."
    $results
} finally {
    if ($temporary) {
        foreach ($path in @($ResultPath, "$ResultPath.v1.0.json", "$ResultPath.beta.json", "$ResultPath.v1.0.log", "$ResultPath.beta.log")) {
            if (Test-Path -LiteralPath $path) {
                if ($path.EndsWith('.log')) { Get-Content -LiteralPath $path -Tail 10 | Write-Host }
                Remove-Item -LiteralPath $path -Force
            }
        }
    }
}
