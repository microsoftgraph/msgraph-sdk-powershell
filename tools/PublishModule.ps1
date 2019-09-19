# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
param(
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string] $Module,
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string] $ArtifactsLocation,
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string] $RepositoryName,
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string] $RepositoryApiKey
)
$ErrorActionPreference = "Stop"

$RollUpModule = "Graph"
$RepositoryPublishUrl = (Get-PSRepository -Name $RepositoryName).PublishLocation

# Get NuGet package to publish.
$NuGetPackageRegex = "$RollUpModule.*(.\d+\.)(\d+\.)(\d+\.nupkg)"
$NuGetPackage = (Get-ChildItem "$ArtifactsLocation\$Module" | Where-Object Name -Match $NuGetPackageRegex).FullName

if($null -eq $NuGetPackage){
    Write-Error "NuGet package for '$Module' module not found."
}

# Copy package to feed.
Write-Host -ForegroundColor Green "Publishing '$Module' module to feed..."
nuget push $NuGetPackage -Source $RepositoryPublishUrl -ApiKey $RepositoryApiKey
if($LastExitCode -ne 0) {
    # NuGet push failed. Check package version number.
    Write-Warning "Failed to push '$Module' package."
}