# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

<#
.SYNOPSIS
    Configures .npmrc files to use a private Azure Artifacts npm feed.

.DESCRIPTION
    Creates .npmrc files at the repository root and in the Rush config directory
    to redirect npm and Rush package installations to a private feed. This is
    used in CI pipelines where network isolation rules block the public npm registry.

.PARAMETER SourcesDirectory
    The root directory of the repository. Defaults to the current directory.

.PARAMETER Registry
    The private npm registry URL.
#>
param(
    [Parameter()]
    [string]$SourcesDirectory = (Get-Location).Path,

    [Parameter()]
    [string]$Registry = "https://microsoftgraph.pkgs.visualstudio.com/0985d294-5762-4bc2-a565-161ef349ca3e/_packaging/PowerShell_V2_Build/npm/registry/"
)

$npmrcContent = "registry=$Registry`nalways-auth=true"

# Create .npmrc at repo root for global npm installs (autorest, rush)
$rootNpmrc = Join-Path $SourcesDirectory ".npmrc"
Set-Content -Path $rootNpmrc -Value $npmrcContent -NoNewline
Write-Host "Created $rootNpmrc"

# Overwrite Rush .npmrc to use private feed for rush install
$rushNpmrc = Join-Path $SourcesDirectory "autorest.powershell/common/config/rush/.npmrc"
Set-Content -Path $rushNpmrc -Value $npmrcContent -NoNewline
Write-Host "Updated $rushNpmrc"

# Create NuGet.config to redirect dotnet restore to the private feed
# Normalize the registry URL and validate the expected suffix before transforming
$normalizedRegistry = $Registry.TrimEnd('/')
$npmSuffix = "/npm/registry"
if (-not $normalizedRegistry.EndsWith($npmSuffix)) {
    throw "Cannot derive NuGet feed URL: Registry '$Registry' does not end with '$npmSuffix'. Pass an explicit Azure Artifacts npm registry URL using the -Registry parameter."
}
$nugetFeed = $normalizedRegistry.Substring(0, $normalizedRegistry.Length - $npmSuffix.Length) + "/nuget/v3/index.json"
$nugetConfig = @"
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <clear />
    <add key="PowerShell_V2_Build" value="$nugetFeed" />
  </packageSources>
</configuration>
"@
$nugetConfigPath = Join-Path $SourcesDirectory "NuGet.config"
Set-Content -Path $nugetConfigPath -Value $nugetConfig -NoNewline
Write-Host "Created $nugetConfigPath"
