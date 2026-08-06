<#
.SYNOPSIS
Smoke-tests built wrapper modules the way a user would: Import-Module, inventory the
cmdlets, exercise a dispatcher without a Graph session.

.DESCRIPTION
Each module is tested in a CHILD pwsh process — a fresh process per module, because
assemblies cannot be unloaded and Import-Module silently no-ops when a same-name module is
already loaded. Checks, per module:

  1. Import-Module <psd1> succeeds            - the user's first experience
  2. exported cmdlet count == manifest count  - nothing silently dropped at load
  3. no orphan workers                        - every *_Get/*_List worker has its public
                                                dispatcher exported alongside it
  4. one dispatcher invoked with dummy ids and no Graph session:
       PASS = NoGraphSession error (the call flowed dispatcher -> worker -> auth path)
       FAIL = CommandNotFound (dispatcher->worker forwarding broken: the manifest
              visibility trap) or any other unexpected error id

Modules with no paired list+item GETs have no dispatcher; check 4 reports n/a for them.

.PARAMETER Module
One or more module names previously built by Build-WrapperModule.ps1.

.PARAMETER OutputRoot
Root folder the modules were built into. Default: <repo>/artifacts/wrapper-modules.

.PARAMETER Configuration
Build configuration used. Default: Debug.

.EXAMPLE
.\tools\Test-WrapperModule.ps1 -Module Mail
#>
[CmdletBinding()]
param(
    [Parameter(Mandatory)]
    [string[]]$Module,
    [string]$OutputRoot,
    [string]$Configuration = 'Debug'
)

$ErrorActionPreference = 'Stop'

$repoRoot = (Resolve-Path (Join-Path $PSScriptRoot '..')).Path
if (-not $OutputRoot) { $OutputRoot = Join-Path $repoRoot 'artifacts\wrapper-modules' }

function Test-OneModule {
    param([string]$Name)

    $moduleName = "Microsoft.Graph.Wrapper.$Name"
    $psd1 = Join-Path $OutputRoot "$Name\src\bin\$Configuration\net10.0\$moduleName.psd1"
    $result = [pscustomobject]@{
        Module = $Name; Pass = $false; Exported = 0; ManifestCount = 0
        OrphanWorkers = 0; Dispatcher = ''; ErrorId = ''; Detail = ''
    }

    if (-not (Test-Path $psd1)) {
        $result.Detail = "not built: $psd1 missing (run Build-WrapperModule.ps1 first)"
        return $result
    }
    $result.ManifestCount = (Import-PowerShellDataFile -Path $psd1).CmdletsToExport.Count

    # The child prints exactly one JSON line; everything else it may write is noise.
    $inner = @"
`$ErrorActionPreference = 'Stop'
Import-Module '$psd1'
`$cmds = Get-Command -Module '$moduleName'
`$workers = @(`$cmds | Where-Object Name -match '_(Get|List)$')
`$orphans = @(`$workers | Where-Object { `$cmds.Name -notcontains (`$_.Name -replace '_(Get|List)$', '') })
`$dispatcher = `$cmds | Where-Object { `$_.Name -like 'Get-*' -and `$cmds.Name -contains "`$(`$_.Name)_List" } | Select-Object -First 1
`$errorId = 'N/A'
if (`$dispatcher) {
    `$defaultSet = `$dispatcher.ParameterSets | Where-Object IsDefault | Select-Object -First 1
    `$splat = @{}
    foreach (`$p in (`$defaultSet.Parameters | Where-Object { `$_.IsMandatory -and `$_.ParameterType -eq [string] })) {
        `$splat[`$p.Name] = 'smoke-test'
    }
    try {
        & `$dispatcher @splat -ErrorAction Stop | Out-Null
        `$errorId = 'NO-ERROR'
    }
    catch {
        `$errorId = `$_.FullyQualifiedErrorId
    }
}
[pscustomobject]@{
    Exported = `$cmds.Count
    OrphanWorkers = `$orphans.Count
    Dispatcher = if (`$dispatcher) { `$dispatcher.Name } else { '' }
    ErrorId = `$errorId
} | ConvertTo-Json -Compress
"@

    $encoded = [Convert]::ToBase64String([Text.Encoding]::Unicode.GetBytes($inner))
    $output = & pwsh -NoProfile -NonInteractive -EncodedCommand $encoded 2>&1
    if ($LASTEXITCODE -ne 0) {
        $result.Detail = "Import-Module failed: $(($output | Select-Object -Last 2) -join ' | ')"
        return $result
    }

    $json = $output | Where-Object { $_ -match '^\{' } | Select-Object -Last 1
    if (-not $json) { $result.Detail = 'child produced no result'; return $result }
    $r = $json | ConvertFrom-Json

    $result.Exported = $r.Exported
    $result.OrphanWorkers = $r.OrphanWorkers
    $result.Dispatcher = $r.Dispatcher
    $result.ErrorId = $r.ErrorId

    if ($r.Exported -ne $result.ManifestCount) {
        $result.Detail = "exported $($r.Exported) != manifest $($result.ManifestCount)"
    }
    elseif ($r.OrphanWorkers -gt 0) {
        $result.Detail = "$($r.OrphanWorkers) worker(s) without their dispatcher"
    }
    elseif ($r.ErrorId -notin @('N/A') -and $r.ErrorId -notlike 'NoGraphSession*') {
        $result.Detail = if ($r.ErrorId -like '*CommandNotFound*') {
            "dispatcher->worker forwarding broken (manifest visibility trap): $($r.ErrorId)"
        } else {
            "unexpected error id: $($r.ErrorId)"
        }
    }
    else {
        $result.Pass = $true
    }
    return $result
}

$results = foreach ($name in $Module) {
    Write-Host "=== $name ===" -ForegroundColor Cyan
    $r = Test-OneModule -Name $name
    if ($r.Pass) {
        Write-Host "  PASS: $($r.Exported) cmdlets; dispatcher $($r.Dispatcher) -> $($r.ErrorId)" -ForegroundColor Green
    }
    else {
        Write-Host "  FAIL: $($r.Detail)" -ForegroundColor Yellow
    }
    $r
}

Write-Host ''
$results | Format-Table Module, Pass, Exported, ManifestCount, OrphanWorkers, Dispatcher, ErrorId -AutoSize | Out-Host

if ($results.Pass -contains $false) { exit 1 }
exit 0
