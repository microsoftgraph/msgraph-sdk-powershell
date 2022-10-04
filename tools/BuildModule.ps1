# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
[CmdletBinding()]
Param(
    [Parameter(Mandatory = $true)] [ValidateNotNullOrEmpty()][string] $ModuleSrc,
    [Parameter(Mandatory = $true)] [ValidateNotNullOrEmpty()][string] $ModuleFullName,
    [Parameter(Mandatory = $true)] [ValidateNotNullOrEmpty()][HashTable] $ModuleMetadata,
    [Parameter(Mandatory = $true)] [ValidateNotNullOrEmpty()][string] $Version,
    [string] $Prerelease,
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
# Import scripts
. $NuspecHelperPS1
. $CSProjHelperPS1

if (-not (Test-Path -Path $BuildModulePS1)) {
    Write-Error "Build script file '$BuildModulePS1' not found for '$ModuleFullName' module."
}

# Set delay sign to true.
if ($EnableSigning) {
    Set-CSProjValues -ModuleCsProj $ModuleCsProj -ModuleVersion $Version -PreRelease $Prerelease -AssemblyOriginatorKeyFile $ModuleMetadata["assemblyOriginatorKeyFile"]
}
else {
    Set-CSProjValues -ModuleCsProj $ModuleCsProj -ModuleVersion $Version -PreRelease $Prerelease -Copyright $ModuleMetadata["copyright"]
}

if ($ModuleFullName -ne "Microsoft.Graph.Authentication") {
    # Build service modules.
    # We need to build the service modules first because AutoREST will override the manifest settings on build.
    # See https://github.com/Azure/autorest.powershell/issues/981.
    Write-Debug "Building '$ModuleFullName' module..."
    & $BuildModulePS1 -Docs -Release -ExcludeExampleTemplates:$ExcludeExampleTemplates -ExcludeNotesSection:$ExcludeNotesSection
    if ($lastexitcode -ne 0) {
        Write-Debug "Failed to build '$ModuleFullName' module."
        exit $lastexitcode
    }
}

# Lock module GUID. See https://github.com/Azure/autorest.powershell/issues/981.
$ExistingModule = Find-Module $ModuleFullName -Repository PSGallery -ErrorAction SilentlyContinue
$ModuleGuid = ($null -eq $ExistingModule) ? (New-Guid).Guid : $ExistingModule.AdditionalMetadata.GUID

[HashTable]$ModuleManifestSettings = @{
    Guid          = $ModuleGuid
    Path          = $ModuleManifest
    ModuleVersion = $Version
    IconUri       = $ModuleMetadata["iconUri"]
    ReleaseNotes  = $ModuleMetadata["releaseNotes"]
}

if ($RequiredModules.Count -gt 0) {
    $RequiredModules | ForEach-Object {
        $ModuleManifestSettings.RequiredModules += @{ ModuleName = $_.ModuleName ; ModuleVersion = $_.ModuleVersion; RequiredVersion = $_.RequiredVersion }
    }
}

if ($Prerelease) {
    $ModuleManifestSettings.Prerelease = $Prerelease
    $FullVersionNumber = "$Version-$Prerelease"
}
else {
    $FullVersionNumber = $Version
}

Write-Debug "Updating '$ModuleFullName' module manifest and nuspec..."
Update-ModuleManifest @ModuleManifestSettings
Set-NuSpecValues -NuSpecFilePath $ModuleNuspec -VersionNumber $FullVersionNumber -Dependencies $RequiredModules -IconUrl $ModuleMetadata["iconUri"] -ReleaseNotes $ReleaseNotes

if ($ModuleFullName -eq "Microsoft.Graph.Authentication") {
    # Build auth modules.
    Write-Debug "Building '$ModuleFullName' module..."
    & $BuildModulePS1 -Docs -Release -ExcludeExampleTemplates:$ExcludeExampleTemplates -ExcludeNotesSection:$ExcludeNotesSection
    if ($lastexitcode -ne 0) {
        Write-Debug "Failed to build '$ModuleFullName' module."
        exit $lastexitcode
    }
}