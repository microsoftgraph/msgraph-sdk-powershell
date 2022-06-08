# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
[CmdletBinding()]
param(
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string[]] $Modules,
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string] $ModulePrefix,
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string] $ArtifactsLocation,
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string] $RepositoryName,
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string] $RepositoryApiKey
)
$LASTEXITCODE = $null
$ErrorActionPreference = "Stop"

$RepositoryPublishUrl = (Get-PSRepository -Name $RepositoryName).SourceLocation

$Modules | ForEach-Object {
    $Module = $_
    # Get NuGet package to publish.
    $NuGetPackageRegex = "$ModulePrefix.*(.\d+\.)(\d+\.)(\d+\.nupkg)|$ModulePrefix.*(.\d+\.)(\d+\.)(\d+\-preview\d+\.nupkg)"
    $NuGetPackage = (Get-ChildItem "$ArtifactsLocation\$Module" | Where-Object Name -Match $NuGetPackageRegex).FullName

    if($null -eq $NuGetPackage){
        Write-Error "NuGet package for '$Module' module not found."
    }

    Write-Host -ForegroundColor Green "Publishing '$Module' module to feed..."
    nuget push $NuGetPackage -Source $RepositoryPublishUrl -ApiKey $RepositoryApiKey
    if($LASTEXITCODE) {
        # NuGet push failed. Check package version number.
        Write-Warning "Failed to push '$Module' package."
    }
}