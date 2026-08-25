<#
.SYNOPSIS
Regenerates parity derivation data from an isolated unresolved wrapper corpus.

.DESCRIPTION
Snapshots all current tracked changes, including the index, into a temporary detached Git
worktree. Every configured wrapper module is regenerated there with collision/parity data
disabled, then Derive-ParityResolutions.ps1 captures and derives the four parity data files.
The active source tree is never used as generation output, and no data is published until the
complete generation and derivation both succeed.

.PARAMETER ApiVersion
API version to capture. Default: v1.0.

.PARAMETER Configuration
Build configuration used by the generator and module compilation. Default: Release.

.PARAMETER OutDir
Destination for the validated parity data. Default: tools/WrapperGenerator/data.

.EXAMPLE
.\tools\Update-WrapperParityData.ps1
#>
[CmdletBinding()]
param(
    [ValidateSet('v1.0', 'beta')]
    [string]$ApiVersion = 'v1.0',
    [string]$Configuration = 'Release',
    [string]$OutDir
)

$ErrorActionPreference = 'Stop'
$repoRoot = (Resolve-Path (Join-Path $PSScriptRoot '..')).Path
if (-not $OutDir) { $OutDir = Join-Path $PSScriptRoot 'WrapperGenerator\data' }

$snapshot = (& git -C $repoRoot stash create 'isolated wrapper parity capture').Trim()
if ($LASTEXITCODE -ne 0) { throw 'git stash create failed while snapshotting the current tracked state.' }
if (-not $snapshot) { $snapshot = (& git -C $repoRoot rev-parse HEAD).Trim() }
if ($LASTEXITCODE -ne 0 -or -not $snapshot) { throw 'Could not resolve a Git snapshot for parity capture.' }

$captureRoot = Join-Path ([System.IO.Path]::GetTempPath()) "wrapper-parity-capture-$PID"
$captureData = Join-Path $captureRoot 'capture-data'
$worktreeAdded = $false

try {
    $worktreeOutput = & git -C $repoRoot worktree add --detach $captureRoot $snapshot 2>&1
    if ($LASTEXITCODE -ne 0) { throw "Could not create isolated capture worktree: $($worktreeOutput -join ' ')" }
    $worktreeAdded = $true

    $buildScript = Join-Path $captureRoot 'tools\Build-WrapperModule.ps1'
    & pwsh -NoProfile -File $buildScript -ApiVersion $ApiVersion -Configuration $Configuration -SkipKiota -NoCollisionData -GenerateOnly
    if ($LASTEXITCODE -ne 0) { throw "Raw wrapper corpus generation failed with exit code $LASTEXITCODE." }

    New-Item -ItemType Directory -Path $captureData | Out-Null
    $deriveScript = Join-Path $captureRoot 'tools\Derive-ParityResolutions.ps1'
    & pwsh -NoProfile -File $deriveScript `
        -GeneratedRoot (Join-Path $captureRoot 'src') `
        -OraclePath (Join-Path $captureRoot 'src\Authentication\Authentication\custom\common\MgCommandMetadata.json') `
        -OutDir $captureData `
        -ApiVersion $ApiVersion `
        -CaptureInput
    if ($LASTEXITCODE -ne 0) { throw "Parity derivation failed with exit code $LASTEXITCODE." }

    $outputs = @(
        "parity-input-ledger.$ApiVersion.csv"
        "parity-renames.$ApiVersion.json"
        "parity-suppressions.$ApiVersion.json"
        "parity-resolution-ledger.$ApiVersion.csv"
    )
    $missing = @($outputs | Where-Object { -not (Test-Path (Join-Path $captureData $_)) })
    if ($missing) { throw "Parity derivation did not produce: $($missing -join ', ')" }

    New-Item -ItemType Directory -Path $OutDir -Force | Out-Null
    foreach ($name in $outputs) {
        Copy-Item -LiteralPath (Join-Path $captureData $name) -Destination (Join-Path $OutDir $name) -Force
    }
    Write-Host "Published $($outputs.Count) parity data files from isolated snapshot $($snapshot.Substring(0, 12))." -ForegroundColor Green
}
finally {
    if ($worktreeAdded) { & git -C $repoRoot worktree remove --force $captureRoot 2>$null | Out-Null }
    if (Test-Path $captureRoot) { Remove-Item $captureRoot -Recurse -Force -ErrorAction SilentlyContinue }
}