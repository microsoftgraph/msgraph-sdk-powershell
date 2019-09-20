# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
Param(
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string] $Module,
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string] $ArtifactsLocation,
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string] $ModuleVersion,
    [int] $ModulePreviewNumber = -1,
    [string[]] $RequiredModules
)
$ErrorActionPreference = "Stop"
if($PSEdition -ne "Core") {
  Write-Error "This script requires PowerShell Core to execute. [Note] Generated cmdlets will work in both PowerShell Core or Windows PowerShell."
}

$NuspecHelperPS1 = Join-Path $PSScriptRoot "./NuspecHelper.ps1"
$ModuleProjLocation = Join-Path $PSScriptRoot "../src/$Module/$Module"
$BuildModulePS1 = Join-Path $ModuleProjLocation "/build-module.ps1"
$PackModulePS1 = Join-Path $ModuleProjLocation "/pack-module.ps1"
$ModuleManifest = Join-Path $ModuleProjLocation "Graph.$Module.psd1"
$ModuleNuspec = Join-Path $ModuleProjLocation "Graph.$Module.nuspec"

# Import scripts
. $NuspecHelperPS1

if (-not (Test-Path -Path $BuildModulePS1)){
    Write-Error "Build script file '$BuildModulePS1' not found for '$Module' module."
}

# Build module
Write-Host -ForegroundColor Green "Building '$Module' module..."
& $BuildModulePS1 -Docs -Release
if($LastExitCode -ne 0) {
    Write-Error "Failed to build '$Module' module."
}

Write-Host -ForegroundColor Green "Updating '$Module' module manifest and nuspec..."
if($ModulePreviewNumber -ge 0){
    if($RequiredModules.Count -gt 0) {
        Update-ModuleManifest -Path $ModuleManifest -FunctionsToExport "*" -ModuleVersion $ModuleVersion -RequiredModules $RequiredModules -Prerelease "preview$ModulePreviewNumber"
    } else {
        Update-ModuleManifest -Path $ModuleManifest -FunctionsToExport "*" -ModuleVersion $ModuleVersion -Prerelease "preview$ModulePreviewNumber"
    }
    Set-NuSpecValues -NuSpecFilePath $ModuleNuspec -VersionNumber "$ModuleVersion-preview$ModulePreviewNumber" -Dependencies $RequiredModules
} else {
    if($RequiredModules.Count -gt 0) {
        Update-ModuleManifest -Path $ModuleManifest -FunctionsToExport "*" -ModuleVersion $ModuleVersion -RequiredModules $RequiredModules
    } else {
        Update-ModuleManifest -Path $ModuleManifest -FunctionsToExport "*" -ModuleVersion $ModuleVersion
    }
    Set-NuSpecValues -NuSpecFilePath $ModuleNuspec -VersionNumber $ModuleVersion -Dependencies $RequiredModules
}

# Pack module
& $PackModulePS1
if($LastExitCode -ne 0) {
    Write-Error "Failed to pack '$Module' module."
}

# Get generated .nupkg
$NuGetPackage = (Get-ChildItem (Join-Path $ModuleProjLocation "./bin") | Where-Object Name -Match ".nupkg").FullName

$ModuleArtifactLocation = "$ArtifactsLocation\$Module"
if(-not (Test-Path $ModuleArtifactLocation)) {
    New-Item -Path $ModuleArtifactLocation -Type Directory
} else {
    Remove-Item -Path "$ModuleArtifactLocation\*" -Recurse -Force
}

# Copy package to artifacts folder.
Write-Host -ForegroundColor Green "Copying '$NuGetPackage' to $ModuleArtifactLocation..."
Copy-Item -Path $NuGetPackage -Destination $ModuleArtifactLocation -Force

Write-Host -ForegroundColor Green "-------------Done-------------"