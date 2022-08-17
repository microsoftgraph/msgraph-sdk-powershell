
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
[CmdletBinding()]
Param(
    [ValidateSet("v1.0", "beta")]
    $ApiVersion = @("v1.0", "beta"),
    [string] $RepositoryApiKey,
    [string] $RepositoryName = "PSGallery",
    [string] $ArtifactsLocation = (Join-Path $PSScriptRoot "..\artifacts\"),
    [switch] $Pack,
    [switch] $Publish
)
$ErrorActionPreference = 'Stop'
$LASTEXITCODE = 0

if ($PSEdition -ne 'Core') {
    Write-Error 'This script requires PowerShell Core to execute. [Note] Generated cmdlets will work in both PowerShell Core or Windows PowerShell.'
}

$ModuleMappingPath = Join-Path $PSScriptRoot "..\config\ModulesMapping.jsonc"
if (-not (Test-Path $ModuleMappingPath)) {
    Write-Error "Module mapping file not be found: $ModuleMappingPath."
}

$ModulePrefix = "Microsoft.Graph"
$NuspecHelperPS1 = Join-Path $PSScriptRoot ".\NuspecHelper.ps1"
$PublishModulePS1 = Join-Path $PSScriptRoot ".\PublishModule.ps1" -Resolve
$ModuleMetadataPath = Join-Path $PSScriptRoot "..\config\ModuleMetadata.json" -Resolve
$ModulesSrc = Join-Path $PSScriptRoot "..\src"
$MetaModuleModuleDir = Join-Path $ModulesSrc "Graph"
[HashTable] $ModuleMapping = Get-Content $ModuleMappingPath | ConvertFrom-Json -AsHashTable
[HashTable] $ModuleMetadata = Get-Content $ModuleMetadataPath | ConvertFrom-Json -AsHashTable
$ModuleMetadata.Remove("assemblyOriginatorKeyFile")

# Import scripts
. $NuspecHelperPS1

$RollUpModuleArtifactLocation = "$ArtifactsLocation\graph"
if (-not (Test-Path $RollUpModuleArtifactLocation)) {
    New-Item -Path $RollUpModuleArtifactLocation -Type Directory
}
else {
    Remove-Item -Path "$RollUpModuleArtifactLocation\*" -Recurse -Force
}

if (-not (Test-Path $MetaModuleModuleDir)) {
    New-Item -Path $MetaModuleModuleDir -Type Directory
}

[HashTable]$ModuleManifestSettings = @{
    CompatiblePSEditions   = "Core", "Desktop"
    PowerShellVersion      = "5.1"
    DotNetFrameworkVersion = "4.7.2"
    Author                 = $ModuleMetadata["authors"]
    CompanyName            = $ModuleMetadata["owners"]
    Copyright              = $ModuleMetadata["copyright"]
    Description            = $ModuleMetadata["description"]
    Tags                   = $ModuleMetadata["tags"]
    LicenseUri             = $ModuleMetadata["licenseUri"]
    ProjectUri             = $ModuleMetadata["projectUri"]
    IconUri                = $ModuleMetadata["iconUri"]
    ReleaseNotes           = $ModuleMetadata["releaseNotes"]
    RequiredModules        = @()
    AliasesToExport        = @()
    CmdletsToExport        = @()
    FunctionsToExport      = @()
}

# Import authentication module from src folder.
$AuthModuleManifest = Join-Path $ModulesSrc "Authentication" "Authentication" "artifacts" "Microsoft.Graph.Authentication.psd1"
$LoadedAuthModule = Import-Module $AuthModuleManifest -PassThru -ErrorAction SilentlyContinue

$ApiVersion | ForEach-Object {
    $CurrentApiVersion = $_
    $NuspecOptions = $ModuleMetadata.Clone()
    $NuspecOptions.version = $ModuleMetadata.versions[$CurrentApiVersion].version
    $NuspecOptions.prerelease = $ModuleMetadata.versions[$CurrentApiVersion].prerelease
    $NuspecOptions.Remove("versions")
    $Module = ($CurrentApiVersion -eq "beta" ? "$ModulePrefix.Beta" : $ModulePrefix)
    $RequiredGraphModules = @()
    if ($null -ne $LoadedAuthModule) {
        $RequiredGraphModules += @{ ModuleName = $LoadedAuthModule.Name ; ModuleVersion = $LoadedAuthModule.Version }
    }
    else {
        Write-Warning "Module not found in $AuthModuleManifest."
    }

    Write-Host -ForegroundColor Green "Creating '$Module' module manifest..."
    $ModuleMapping.Keys | ForEach-Object {
        $RequiredModule = $_
        $ModuleManifest = Join-Path $ModulesSrc $RequiredModule $CurrentApiVersion "$Module.$RequiredModule.psd1"
        $LoadedModule = Import-Module $ModuleManifest -PassThru -ErrorAction SilentlyContinue
        if ($null -ne $LoadedModule) {
            $RequiredGraphModules += @{ ModuleName = $LoadedModule.Name ; RequiredVersion = $LoadedModule.Version; }
        }
        else {
            Write-Warning "Module not found in $ModuleManifest."
        }
    }
    $ModuleManifestSettings.RequiredModules = $RequiredGraphModules

    if ($null -eq $NuspecOptions.version) {
        Write-Error "Version number is not set for $ModulePrefix module. Please set 'version' in $ModuleMetadataPath."
    }
    $ModuleManifestSettings.ModuleVersion = $NuspecOptions.version
    if ($NuspecOptions.prerelease) {
        $ModuleManifestSettings.Prerelease = $NuspecOptions.prerelease
    }
    $ModuleManifestSettings.Path =  Join-Path $MetaModuleModuleDir $CurrentApiVersion "$Module.psd1"
    if (Test-Path $ModuleManifestSettings.Path) {
        $Psd1 = Import-PowerShellDataFile $ModuleManifestSettings.Path
        $ModuleManifestSettings.GUID = $Psd1.GUID
    }
    else {
        $ModuleManifestSettings.GUID = (New-Guid).Guid
    }
    New-ModuleManifest @ModuleManifestSettings

    Write-Host -ForegroundColor Green "Creating '$Module' module nuspec..."
    $NuspecOptions["dependencies"] = $RequiredGraphModules
    $NuspecOptions["id"] = $Module

    $MetaModuleNuspec = Join-Path $MetaModuleModuleDir $CurrentApiVersion "$Module.nuspec"
    if (-not (Test-Path $MetaModuleNuspec)) {
        Copy-Item (Join-Path $PSScriptRoot "\Templates\$ModulePrefix.nuspec") -Destination $MetaModuleNuspec
    }

    Set-NuSpecValuesFromManifest -NuSpecFilePath $MetaModuleNuspec -Manifest $NuspecOptions

    if ($Pack) {
        Write-Host -ForegroundColor Green "Packing '$Module' module..."
        & nuget pack $MetaModuleNuspec -OutputDirectory $RollUpModuleArtifactLocation -Prop Configuration=Release
    }

    if ($LASTEXITCODE) {
        Write-Error "Failed to pack $Module module."
    }

    if ($Publish) {
        # Publish roll-up module
        & $PublishModulePS1 -Modules "Graph" -ModulePrefix $Module -ArtifactsLocation $ArtifactsLocation -RepositoryName $RepositoryName -RepositoryApiKey $RepositoryApiKey
    }
}

Write-Host -ForegroundColor Green "-------------Done-------------"