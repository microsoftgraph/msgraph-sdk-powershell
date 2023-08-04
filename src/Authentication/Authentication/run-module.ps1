# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

Param(
    [Parameter(Mandatory = $true)] [ValidateNotNullOrEmpty()][string] $ModuleName,
    [Parameter(Mandatory = $true)] [ValidateNotNullOrEmpty()][string] $ArtifactLocation
)

$NugetPackage = Get-ChildItem -Path $ArtifactLocation -Filter "$ModuleName*.nupkg" -Recurse
if ($null -eq $NugetPackage) {
    throw "$ModuleName module artifact not found in '$ArtifactLocation'."
}

$DestinationFolder = "$($NugetPackage.DirectoryName)\$($NugetPackage.BaseName)"
$ModuleManifest = "$DestinationFolder\$ModuleName.psd1"

Write-Host -ForegroundColor Green "Unblocking nuget package $($NugetPackage.FullName) ..."
Unblock-File -Path $NugetPackage.FullName

Write-Host -ForegroundColor Green "Renaming nuget package to zip ..."
Rename-Item -Path $NugetPackage.FullName -NewName "$DestinationFolder.zip"

Write-Host -ForegroundColor Green "Extracting zip to $DestinationFolder ..."
Expand-Archive -Path "$DestinationFolder.zip" -DestinationPath $DestinationFolder

Write-Host -ForegroundColor Green "Importing $ModuleName module from $ModuleManifest ..."
Import-Module $ModuleManifest

Write-Host -ForegroundColor Green "-------------Done-------------"