# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
param(
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string[]] $Modules,
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string] $ModuleNamespace,
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string] $ArtifactsLocation,
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string] $RepositoryName,
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string] $RepositoryApiKey
)
$ErrorActionPreference = "Stop"

$RepositoryPublishUrl = (Get-PSRepository -Name $RepositoryName).PublishLocation

foreach($Module in $Modules){
    # Get NuGet package to publish.
    $NuGetPackageRegex = "$ModuleNamespace.*(.\d+\.)(\d+\.)(\d+\.nupkg)|$ModuleNamespace.*(.\d+\.)(\d+\.)(\d+\-preview\d+\.nupkg)"
    $NuGetPackage = (Get-ChildItem "$ArtifactsLocation\$Module" | Where-Object Name -Match $NuGetPackageRegex).FullName

    if($null -eq $NuGetPackage){
        Write-Error "NuGet package for '$Module' module not found."
    }

    Write-Host -ForegroundColor Green "Publishing '$Module' module to feed..."
    nuget push $NuGetPackage -Source $RepositoryPublishUrl -ApiKey $RepositoryApiKey
    if($LastExitCode -ne 0) {
        # NuGet push failed. Check package version number.
        Write-Warning "Failed to push '$Module' package."
    }
}