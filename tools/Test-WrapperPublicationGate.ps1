<#
.SYNOPSIS
Focused publication evidence contract tests; fixture files are not real build evidence.
#>
[CmdletBinding()]
param()
$ErrorActionPreference = 'Stop'
. (Join-Path $PSScriptRoot 'Test-WrapperPublication.ps1')
$fixture = Join-Path ([IO.Path]::GetTempPath()) "publication-gate-$([guid]::NewGuid())"
function Assert-Rejected([scriptblock]$Action, [string]$Pattern) {
    try { & $Action | Out-Null } catch {
        if ($_.Exception.Message -notmatch $Pattern) { throw }
        return
    }
    throw "Expected publication failure matching '$Pattern'."
}
try {
    New-Item -ItemType Directory -Path (Join-Path $fixture 'tools\Templates') -Force | Out-Null
    '<Project><PropertyGroup><TargetFramework>netstandard2.0</TargetFramework></PropertyGroup></Project>' |
        Set-Content (Join-Path $fixture 'tools\Templates\WrapperModule.csproj.template')
    $results = @()
    foreach ($profile in @('v1.0', 'beta')) {
        $root = Join-Path $fixture "src\Widget\wrapper\$profile"
        $bin = Join-Path $root 'bin\Release\netstandard2.0'
        $specPath = Join-Path $fixture "openApiDocs_KiotaCompat\$profile\Widget.yml"
        foreach ($dir in @((Split-Path $specPath), $bin, (Join-Path $root 'Client'), (Join-Path $root 'Cmdlets'))) {
            New-Item -ItemType Directory -Path $dir -Force | Out-Null
        }
        'fixture spec' | Set-Content $specPath
        $r = [pscustomobject]@{
            Module = 'Widget'; ApiVersion = $profile; Status = 'OK'; CmdletCount = 1; EmittedCmdletCount = 1
            StrictPublication = $true; KiotaGenerated = $true; WrapperGenerated = $true; Compiled = $true
            SpecPath = $specPath; SpecSha256 = (Get-FileHash $specPath).Hash
            StartedUtc = [DateTime]::UtcNow.AddSeconds(-5).ToString('o'); FinishedUtc = ''
            ClientPath = Join-Path $root 'Client\ApiClient.cs'; CmdletsPath = Join-Path $root 'Cmdlets'
            AssemblyPath = Join-Path $bin 'Microsoft.Graph.Wrapper.Widget.dll'
            ClientAssemblyPath = Join-Path $bin 'Microsoft.Graph.Wrapper.Widget.Client.dll'
            Psd1 = Join-Path $bin 'Microsoft.Graph.Wrapper.Widget.psd1'
        }
        foreach ($path in @($r.ClientPath, $r.AssemblyPath, $r.ClientAssemblyPath,
            (Join-Path $root 'Client\kiota-lock.json'), (Join-Path $root 'Cmdlets\kiota-lock.json'),
            (Join-Path $root 'Client\Client.csproj'), (Join-Path $root 'Microsoft.Graph.Wrapper.Widget.csproj'),
            (Join-Path $root 'Client\Model.cs'),
            (Join-Path $root 'Cmdlets\GetMgWidget.g.cs'))) { 'fixture artifact' | Set-Content $path }
        "@{ RootModule = 'Microsoft.Graph.Wrapper.Widget.dll'; CmdletsToExport = @('Get-MgWidget') }" | Set-Content $r.Psd1
        $r.FinishedUtc = [DateTime]::UtcNow.AddMinutes(5).ToString('o')
        $results += $r
    }
    # ConvertFrom-Json materializes ISO dates as DateTime on current PowerShell versions.
    $results = @(ConvertTo-Json -InputObject $results -Depth 8 | ConvertFrom-Json)
    function Assert-Pair { Assert-WrapperPublicationResult -Results $results -ModuleName Widget -RepositoryRoot $fixture }
    Assert-Pair
    Assert-Rejected { Assert-WrapperPublicationResult -Results @($results[0]) -ModuleName Widget -RepositoryRoot $fixture } 'exactly two'
    $r = $results[1]
    foreach ($status in @('NO-CMDLETS', 'FAILED', 'SKIPPED')) {
        $r.Status = $status
        Assert-Rejected { Assert-Pair } 'did not emit and compile'
    }
    $r.Status = 'OK'
    $r.ApiVersion = 'v1.0'; Assert-Rejected { Assert-Pair } 'one Widget/v1.0'; $r.ApiVersion = 'beta'
    foreach ($flag in @('StrictPublication', 'KiotaGenerated', 'WrapperGenerated', 'Compiled')) {
        $r.$flag = $false; Assert-Rejected { Assert-Pair } 'skipped required'; $r.$flag = $true
    }
    $r.CmdletCount = 0; Assert-Rejected { Assert-Pair } 'did not emit'; $r.CmdletCount = 1
    $r.EmittedCmdletCount = 0; Assert-Rejected { Assert-Pair } 'did not emit'; $r.EmittedCmdletCount = 1
    $r.EmittedCmdletCount = 2; Assert-Rejected { Assert-Pair } 'counts disagree'; $r.EmittedCmdletCount = 1
    $r.CmdletCount = 2; Assert-Rejected { Assert-Pair } 'counts disagree'; $r.CmdletCount = 1
    $extra = Join-Path $r.CmdletsPath 'GetMgExtra.g.cs'
    'extra cmdlet' | Set-Content $extra
    Assert-Rejected { Assert-Pair } 'count changed'
    Remove-Item -LiteralPath $extra
    $originalSpec = $r.SpecPath
    $r.SpecPath = $r.SpecPath.Replace('openApiDocs_KiotaCompat', 'openApiDocs')
    Assert-Rejected { Assert-Pair } 'fallback'; $r.SpecPath = $originalSpec
    $hash = $r.SpecSha256; $r.SpecSha256 = 'stale'; Assert-Rejected { Assert-Pair } 'identity changed'; $r.SpecSha256 = $hash
    $originalAssembly = $r.AssemblyPath
    $r.AssemblyPath += '.wrong'; Assert-Rejected { Assert-Pair } 'unexpected AssemblyPath'; $r.AssemblyPath = $originalAssembly
    foreach ($path in @($r.ClientPath, $r.AssemblyPath, $r.ClientAssemblyPath, $r.Psd1,
        (Join-Path (Split-Path $r.ClientPath) 'Model.cs'),
        (Join-Path $r.CmdletsPath 'GetMgWidget.g.cs'))) {
        $oldTime = (Get-Item -LiteralPath $path).LastWriteTimeUtc
        (Get-Item -LiteralPath $path).LastWriteTimeUtc = [DateTime]::UtcNow.AddDays(-1)
        Assert-Rejected { Assert-Pair } 'Stale'
        (Get-Item -LiteralPath $path).LastWriteTimeUtc = $oldTime
    }
    $oldManifest = Get-Content $r.Psd1 -Raw
    "@{RootModule='Microsoft.Graph.Wrapper.Widget.dll';CmdletsToExport=@('*')}" | Set-Content $r.Psd1
    Assert-Rejected { Assert-Pair } 'manifest does not describe'
    $oldManifest | Set-Content $r.Psd1
    Remove-Item -LiteralPath $r.ClientAssemblyPath
    Assert-Rejected { Assert-Pair } 'Missing publication artifact'
    Remove-Item -LiteralPath $originalSpec
    Assert-Rejected { Assert-Pair } 'Missing specification'
    Assert-Rejected { & (Join-Path $PSScriptRoot 'Build-WrapperModule.ps1') -Module Widget -StrictPublication -SkipKiota } 'requires full Kiota'
    Assert-Rejected { & (Join-Path $PSScriptRoot 'Build-WrapperModule.ps1') -Module Widget -StrictPublication -GenerateOnly } 'requires full Kiota'
    Assert-Rejected { & (Join-Path $PSScriptRoot 'Build-WrapperModule.ps1') -Module Widget -StrictPublication -NoCollisionData } 'requires full Kiota'
    # Real builder preflight must not use the existing raw SchemaExtensions input as fallback.
    $missingSpecResult = Join-Path $fixture 'missing-spec.json'
    & pwsh -NoProfile -NonInteractive -File (Join-Path $PSScriptRoot 'Build-WrapperModule.ps1') `
        -Module SchemaExtensions -SpecRoot $fixture -StrictPublication -ResultPath $missingSpecResult *> (Join-Path $fixture 'missing-spec.log')
    if ($LASTEXITCODE -eq 0) { throw 'Strict build accepted missing Kiota-compatible input.' }
    $missing = @(Get-Content $missingSpecResult -Raw | ConvertFrom-Json)
    if ($missing.Count -ne 1 -or $missing[0].Status -ne 'FAILED' -or $missing[0].FailedAt -ne 'spec') { throw 'Missing input must produce failed spec evidence.' }
} finally {
    if (Test-Path -LiteralPath $fixture) { Remove-Item -LiteralPath $fixture -Recurse -Force }
}
Write-Host 'PASS: dual-profile publication rejects failed/empty/skipped/stale/fallback evidence and accepts a complete fresh pair.'
