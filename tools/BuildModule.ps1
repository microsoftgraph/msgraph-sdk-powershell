# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
[CmdletBinding()]
Param(
    [Parameter(Mandatory = $true)] [ValidateNotNullOrEmpty()][string] $ModuleSrc,
    [Parameter(Mandatory = $true)] [ValidateNotNullOrEmpty()][string] $ModuleFullName,
    [Parameter(Mandatory = $true)] [ValidateNotNullOrEmpty()][string] $ModuleVersion,
    [Parameter(Mandatory = $true)] [ValidateNotNullOrEmpty()][string[]] $ReleaseNotes,
    [int] $ModulePreviewNumber = -1,
    [hashtable[]] $RequiredModules,
    [switch] $EnableSigning,
    [switch] $ExcludeExampleTemplates,
    [switch] $ExcludeNotesSection
)
$ErrorActionPreference = "Stop"
if ($PSEdition -ne "Core") {
    Write-Error "This script requires PowerShell Core to execute. [Note] Generated cmdlets will work in both PowerShell Core or Windows PowerShell."
}

$NuspecHelperPS1 = Join-Path $PSScriptRoot "./NuspecHelper.ps1"
$CSProjHelperPS1 = Join-Path $PSScriptRoot "./CSProjHelper.ps1"
$BuildModulePS1 = Join-Path $ModuleSrc "/build-module.ps1"
$ModuleCsProj = Join-Path $ModuleSrc "$ModuleFullName.csproj"
$ModuleManifest = Join-Path $ModuleSrc "$ModuleFullName.psd1"
$ModuleNuspec = Join-Path $ModuleSrc "$ModuleFullName.nuspec"
[HashTable] $ModuleMetadata = Get-Content (Join-Path $PSScriptRoot "..\config\ModuleMetadata.json") | ConvertFrom-Json -AsHashTable
# Import scripts
. $NuspecHelperPS1
. $CSProjHelperPS1

if (-not (Test-Path -Path $BuildModulePS1)) {
    Write-Error "Build script file '$BuildModulePS1' not found for '$ModuleFullName' module."
}

# TODO: Enable preview versions in CSproj.
# Set delay sign to true.
if ($EnableSigning) {
    Set-CSProjValues -ModuleCsProj $ModuleCsProj -ModuleVersion $ModuleMetadata["version"] -PreRelease $ModuleMetadata["prerelease"] -AssemblyOriginatorKeyFile $ModuleMetadata["assemblyOriginatorKeyFile"]
}
else {
    Set-CSProjValues -ModuleCsProj $ModuleCsProj -ModuleVersion $ModuleMetadata["version"] -PreRelease $ModuleMetadata["prerelease"] -Copyright $ModuleMetadata["copyright"]
}

# Build module
Write-Debug "Building '$ModuleFullName' module..."
& $BuildModulePS1 -Docs -Release -ExcludeExampleTemplates:$ExcludeExampleTemplates -ExcludeNotesSection:$ExcludeNotesSection
if ($lastexitcode -ne 0) {
    Write-Debug "Failed to build '$ModuleFullName' module."
    exit $lastexitcode
}

[HashTable]$ModuleManifestSettings = @{
    Path          = $ModuleManifest
    ModuleVersion = $ModuleMetadata["version"]
    IconUri       = $ModuleMetadata["iconUri"]
    ReleaseNotes  = $ReleaseNotes
}

if ($ModuleMetadata["prerelease"]) {
    $ModuleManifestSettings.Prerelease = $ModuleMetadata["prerelease"]
}
if ($RequiredModules.Count -gt 0) {
    $ModuleManifestSettings["RequiredModules"] = $RequiredModules
}

# TODO: Refactor this line to use Set-NuSpecValuesFromManifest. Rename to ModuleVersion after refactor.
if ($ModuleMetadata["prerelease"]) {
    $FullVersionNumber = "$($ModuleMetadata["version"])-$($ModuleMetadata["prerelease"])"
} else {
    $FullVersionNumber = $ModuleMetadata["version"]
}

Write-Debug "Updating '$ModuleFullName' module manifest and nuspec..."
Update-ModuleManifest @ModuleManifestSettings
Set-NuSpecValues -NuSpecFilePath $ModuleNuspec -VersionNumber $FullVersionNumber -Dependencies $RequiredModules -IconUrl $ModuleMetadata["iconUri"] -ReleaseNotes $ReleaseNotes
