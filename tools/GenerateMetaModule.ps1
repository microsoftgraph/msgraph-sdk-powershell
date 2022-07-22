
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
[CmdletBinding()]
Param(
    [ValidateSet("v1.0", "beta")]
    $ApiVersion = @("v1.0", "beta"),
    [string] $RepositoryApiKey,
    [string] $RepositoryName = "PSGallery",
    [string] $ArtifactsLocation = (Join-Path $PSScriptRoot "..\artifacts\"),
    [string] $ModuleMappingConfigPath = (Join-Path $PSScriptRoot "..\config\ModulesMapping.jsonc"),
    [int] $ModulePreviewNumber = -1,
    [switch] $Pack,
    [switch] $Publish
)
enum VersionState {
    Invalid
    Valid
    EqualToFeed
    NotOnFeed
}
$ErrorActionPreference = 'Stop'
$LASTEXITCODE = $null
if ($PSEdition -ne 'Core') {
    Write-Error 'This script requires PowerShell Core to execute. [Note] Generated cmdlets will work in both PowerShell Core or Windows PowerShell.'
}

if (-not (Test-Path $ModuleMappingConfigPath)) {
    Write-Error "Module mapping file not be found: $ModuleMappingConfigPath."
}

$ModulePrefix = "Microsoft.Graph"
$NuspecHelperPS1 = Join-Path $PSScriptRoot ".\NuspecHelper.ps1"
$PublishModulePS1 = Join-Path $PSScriptRoot ".\PublishModule.ps1" -Resolve
$ValidateUpdatedModuleVersionPS1 = Join-Path $PSScriptRoot ".\ValidateUpdatedModuleVersion.ps1" -Resolve
$ModuleMetadataJson = Join-Path $PSScriptRoot "..\config\ModuleMetadata.json" -Resolve
$ModulesSrc = Join-Path $PSScriptRoot "..\src"
$MetaModuleModuleDir = Join-Path $ModulesSrc "Graph"
[HashTable] $ModuleMapping = Get-Content $ModuleMappingConfigPath | ConvertFrom-Json -AsHashTable
[HashTable] $NuspecMetadata = Get-Content $ModuleMetadataJson | ConvertFrom-Json -AsHashTable
$NuspecMetadata.Remove("assemblyOriginatorKeyFile")

# Import scripts
. $NuspecHelperPS1

if ($null -eq $NuspecMetadata["version"]) {
    # Module version not set in module manifest (psd1).
    Write-Error "Version number is not set on $ModulePrefix module. Please set 'version' in $ModuleMetadataJson."
}
  
# Validate module version with the one on PSGallery.
[VersionState]$VersionState = & $ValidateUpdatedModuleVersionPS1 -ModuleName $ModulePrefix -NextVersion $NuspecMetadata["version"]

if ($VersionState.Equals([VersionState]::Invalid)) {
    Write-Warning "The specified version in $ModulePrefix module is either higher or lower than what's on $RepositoryName. Update 'version' in $ModuleMetadataJson."
}
elseif ($VersionState.Equals([VersionState]::EqualToFeed)) {
    Write-Warning "$ModulePrefix module skipped. Version has not changed and is equal to what's on $RepositoryName."
}
elseif ($VersionState.Equals([VersionState]::Valid) -or $VersionState.Equals([VersionState]::NotOnFeed)) {
    $NuspecMetadata["version"] = $VersionState.Equals([VersionState]::NotOnFeed) ? "0.1.1" : $NuspecMetadata["version"]

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
    $AllowPreRelease = $true
    if ($ModulePreviewNumber -eq -1) {
        $AllowPreRelease = $false
    }

    [HashTable]$ModuleManifestSettings = @{
        CompatiblePSEditions   = "Core", "Desktop"
        PowerShellVersion      = "5.1"
        DotNetFrameworkVersion = "4.7.2"
        ModuleVersion          = $NuspecMetadata["version"]
        Author                 = $NuspecMetadata["authors"]
        CompanyName            = $NuspecMetadata["owners"]
        Copyright              = $NuspecMetadata["copyright"]
        Description            = $NuspecMetadata["description"]
        Tags                   = $NuspecMetadata["tags"]
        LicenseUri             = $NuspecMetadata["licenseUri"]
        ProjectUri             = $NuspecMetadata["projectUri"]
        IconUri                = $NuspecMetadata["iconUri"]
        ReleaseNotes           = $NuspecMetadata["releaseNotes"]
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
        $NuspecOptions = $NuspecMetadata.Clone()
        $Module = ($CurrentApiVersion -eq "beta" ? "$ModulePrefix.Beta" : $ModulePrefix)
        $RequiredGraphModules = @()
        if ($null -ne $LoadedAuthModule) {
            # TODO: Handle pre release modules.
            # $RequiredGraphModules += @{ ModuleName = $LoadedAuthModule.Name ; RequiredVersion = $LoadedAuthModule.Version; Prerelease = $LoadedAuthModule.Prerelease }
            $RequiredGraphModules += @{ ModuleName = $LoadedAuthModule.Name ; RequiredVersion = $LoadedAuthModule.Version }
        } else {
            Write-Warning "Module not found in $AuthModuleManifest."
        }

        $ModuleMapping.Keys | ForEach-Object {
            $RequiredModule = $_
            # Import module from src folder.
            $ModuleManifest = Join-Path $ModulesSrc $RequiredModule $CurrentApiVersion "$Module.$RequiredModule.psd1"
            $LoadedModule = Import-Module $ModuleManifest -PassThru -ErrorAction SilentlyContinue
            if ($null -ne $LoadedModule) {
                # TODO: Handle pre release modules.
                # $RequiredGraphModules += @{ ModuleName = $LoadedModule.Name ; RequiredVersion = $LoadedModule.Version; Prerelease = $LoadedModule.Prerelease }
                $RequiredGraphModules += @{ ModuleName = $LoadedModule.Name ; RequiredVersion = $LoadedModule.Version }
            } else {
                Write-Warning "Module not found in $ModuleManifest."
            }
        }

        $ModuleManifestSettings.Path = "$MetaModuleModuleDir\$CurrentApiVersion\$Module.psd1"
        $ModuleManifestSettings.RequiredModules = $RequiredGraphModules

        Write-Host -ForegroundColor Green "Creating '$Module' module manifest and nuspec..."
        if ($ModulePreviewNumber -ge 0) {
            # Prerelease is only supported in PowerShell 7 (preview) and above.
            $ModuleManifestSettings["Prerelease"] = "preview$ModulePreviewNumber"
            $NuspecOptions["version"] = $NuspecOptions["version"] + "-preview$ModulePreviewNumber"
        }
        $NuspecOptions["dependencies"] = $RequiredGraphModules
        $NuspecOptions["id"] = $Module

        # Write-Output $NuspecOptions
        New-ModuleManifest @ModuleManifestSettings

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
}

Write-Host -ForegroundColor Green "-------------Done-------------"