# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
[CmdletBinding()]
param(
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string] $RepositoryName,
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string] $RepositoryApiKey,
    [string] $ArtifactsLocation = (Join-Path $PSScriptRoot "..\msgraph-tools-migration")
)
$LASTEXITCODE = $null
$ErrorActionPreference = "Stop"

$RepositoryPublishUrl = (Get-PSRepository -Name $RepositoryName).SourceLocation
$NuGetPackageRegex = "Microsoft.Graph.Migration.Tool.*.nupkg"
$NuGetPackage = (Get-ChildItem "$ArtifactsLocation" | Where-Object Name -Match $NuGetPackageRegex).FullName
Write-Host -ForegroundColor Green "Publishing migration tool to feed... $NuGetPackage"
nuget push $NuGetPackage -Source $RepositoryPublishUrl -ApiKey $RepositoryApiKey
if($LASTEXITCODE) {
    # NuGet push failed. Check package version number.
    Write-Warning "Failed to push '$Module' package."
}
