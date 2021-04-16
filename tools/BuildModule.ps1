# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
Param(
    [Parameter(Mandatory = $true)] [ValidateNotNullOrEmpty()][string] $Module,
    [Parameter(Mandatory = $true)] [ValidateNotNullOrEmpty()][string] $ModulePrefix,
    [Parameter(Mandatory = $true)] [ValidateNotNullOrEmpty()][string] $ModuleVersion,
    [Parameter(Mandatory = $true)] [ValidateNotNullOrEmpty()][string[]] $ReleaseNotes,
    [int] $ModulePreviewNumber = -1,
    [hashtable[]] $RequiredModules,
    [switch] $EnableSigning
)
$ErrorActionPreference = "Stop"
$LASTEXITCODE = $null
if ($PSEdition -ne "Core") {
    Write-Error "This script requires PowerShell Core to execute. [Note] Generated cmdlets will work in both PowerShell Core or Windows PowerShell."
}

$NuspecHelperPS1 = Join-Path $PSScriptRoot "./NuspecHelper.ps1"
$CSProjHelperPS1 = Join-Path $PSScriptRoot "./CSProjHelper.ps1"
$ModuleProjLocation = Join-Path $PSScriptRoot "../src/$Module/$Module"
$BuildModulePS1 = Join-Path $ModuleProjLocation "/build-module.ps1"
$ModuleCsProj = Join-Path $ModuleProjLocation "$ModulePrefix.$Module.csproj"
$ModuleManifest = Join-Path $ModuleProjLocation "$ModulePrefix.$Module.psd1"
$ModuleNuspec = Join-Path $ModuleProjLocation "$ModulePrefix.$Module.nuspec"
[HashTable] $NuspecMetadata = Get-Content (Join-Path $PSScriptRoot "..\config\ModuleMetadata.json") | ConvertFrom-Json -AsHashTable

# Import scripts
. $NuspecHelperPS1
. $CSProjHelperPS1

if (-not (Test-Path -Path $BuildModulePS1)) {
    Write-Error "Build script file '$BuildModulePS1' not found for '$Module' module."
}

# Set delay sign to true.
if ($EnableSigning) {
    Set-CSProjValues -ModuleCsProj $ModuleCsProj -ModuleVersion $ModuleVersion -AssemblyOriginatorKeyFile $NuspecMetadata["assemblyOriginatorKeyFile"]
}
else {
    Set-CSProjValues -ModuleCsProj $ModuleCsProj -ModuleVersion $ModuleVersion -Copyright $NuspecMetadata["copyright"]
}

# Build module
Write-Host -ForegroundColor Green "Building '$Module' module..."
& $BuildModulePS1 -Docs -Release
if ($LASTEXITCODE) {
    Write-Error "Failed to build '$Module' module."
}

[HashTable]$ModuleManifestSettings = @{
    Path          = $ModuleManifest
    ModuleVersion = $ModuleVersion
    IconUri       = $NuspecMetadata["iconUri"]
    ReleaseNotes  = $ReleaseNotes
}
$FullVersionNumber = $ModuleVersion

if ($ModulePreviewNumber -ge 0) {
    if ($RequiredModules.Count -gt 0) {
        # Prerelease is only supported in PowerShell 7 (preview) and above.
        $ModuleManifestSettings["RequiredModules"] = $RequiredModules
        $ModuleManifestSettings["Prerelease"] = "preview$ModulePreviewNumber"
    }
    else {
        $ModuleManifestSettings["Prerelease"] = "preview$ModulePreviewNumber"
    }
    $FullVersionNumber = "$ModuleVersion-preview$ModulePreviewNumber"
}
else {
    if ($RequiredModules.Count -gt 0) {
        $ModuleManifestSettings["RequiredModules"] = $RequiredModules
    }
}

Write-Host -ForegroundColor Green "Updating '$Module' module manifest and nuspec..."
Update-ModuleManifest @ModuleManifestSettings
Set-NuSpecValues -NuSpecFilePath $ModuleNuspec -VersionNumber $FullVersionNumber -Dependencies $RequiredModules -IconUrl $NuspecMetadata["iconUri"] -ReleaseNotes $ReleaseNotes

Write-Host -ForegroundColor Green "-------------Done-------------"