# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
Param(
    [string] $RepositoryApiKey,
    [string] $RepositoryName = "PSGallery",
    [int] $ModulePreviewNumber = -1,
    [string] $ModuleMappingConfigPath = (Join-Path $PSScriptRoot "..\config\ModulesMapping.jsonc"),
    [string] $OpenApiDocOutput = (Join-Path $PSScriptRoot "..\openApiDocs"),
    [switch] $BetaGraphVersion,
    [switch] $UpdateAutoRest,
    [switch] $UseLocalDoc,
    [switch] $Build,
    [switch] $Pack,
    [switch] $Publish,
    [switch] $EnableSigning
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
# Install Powershell-yaml
Install-Module powershell-yaml -Force

$GraphVersion = "v1.0"
if ($BetaGraphVersion) {
    $GraphVersion = "Beta"
}
$ModulePrefix = "Microsoft.Graph"
$ModulesOutputDir = Join-Path $PSScriptRoot "..\src\$GraphVersion\"
$AuthenticationModule = "Microsoft.Graph.Authentication"
$OpenApiDocOutput = Join-Path $OpenApiDocOutput $GraphVersion
$ArtifactsLocation = Join-Path $PSScriptRoot "..\artifacts\$GraphVersion"

# PS Scripts
$DownloadOpenApiDocPS1 = Join-Path $PSScriptRoot ".\DownloadOpenApiDoc.ps1" -Resolve
$ManageGeneratedModulePS1 = Join-Path $PSScriptRoot ".\ManageGeneratedModule.ps1" -Resolve
$BuildModulePS1 = Join-Path $PSScriptRoot ".\BuildModule.ps1" -Resolve
$PackModulePS1 = Join-Path $PSScriptRoot ".\PackModule.ps1" -Resolve
$PublishModulePS1 = Join-Path $PSScriptRoot ".\PublishModule.ps1" -Resolve
$ReadModuleReadMePS1 = Join-Path $PSScriptRoot ".\ReadModuleReadMe.ps1" -Resolve
$ValidateUpdatedModuleVersionPS1 = Join-Path $PSScriptRoot ".\ValidateUpdatedModuleVersion.ps1" -Resolve

if (-not (Test-Path $ArtifactsLocation)) {
    New-Item -Path $ArtifactsLocation -Type Directory
}

if (-not (Test-Path $ModuleMappingConfigPath)) {
    Write-Error "Module mapping file not be found: $ModuleMappingConfigPath."
}

# Install module locally in order to specify it as a dependency for other modules down the generation pipeline.
# https://stackoverflow.com/questions/46216038/how-do-i-define-requiredmodules-in-a-powershell-module-manifest-psd1.
Install-Module $AuthenticationModule -Repository $RepositoryName -AllowPrerelease -Force
if ($UpdateAutoRest) {
    # Update AutoRest.
    & AutoRest-beta --reset
}

[HashTable] $ModuleMapping = Get-Content $ModuleMappingConfigPath | ConvertFrom-Json -AsHashTable
$ModuleMapping.Keys | ForEach-Object {
    $ModuleName = $_
    $ModuleProjectDir = Join-Path $ModulesOutputDir "$ModuleName\$ModuleName"

    # Copy AutoRest readme.md config is none exists.
    if (-not (Test-Path "$ModuleProjectDir\readme.md")) {
        New-Item -Path $ModuleProjectDir -Type Directory -Force
        Copy-Item (Join-Path $PSScriptRoot "\Templates\readme.md") -Destination $ModuleProjectDir
    }

    $ModuleLevelReadMePath = Join-Path $ModuleProjectDir "\readme.md" -Resolve

    # Read specified module version from readme.
    $ModuleVersion = & $ReadModuleReadMePS1 -ReadMePath $ModuleLevelReadMePath -FieldToRead "module-version"
    if ($ModuleVersion -eq $null) {
        # Module version not set in readme.md.
        Write-Error "Version number is not set on $ModulePrefix.$ModuleName module. Please set 'module-version' in $ModuleLevelReadMePath."
    }

    # Validate module version with the one on PSGallery.
    [VersionState]$VersionState = & $ValidateUpdatedModuleVersionPS1 -ModuleName "$ModulePrefix.$ModuleName" -NextVersion $ModuleVersion

    if ($VersionState.Equals([VersionState]::Invalid)) {
        Write-Error "The specified version in $ModulePrefix.$ModuleName module is either higher or lower than what's on $RepositoryName. Update the 'module-version' in $ModuleLevelReadMePath"
    }
    elseif ($VersionState.Equals([VersionState]::EqualToFeed)) {
        Write-Warning "$ModulePrefix.$ModuleName module skipped. Version has not changed and is equal to what's on $RepositoryName."
    }
    elseif ($VersionState.Equals([VersionState]::Valid) -or $VersionState.Equals([VersionState]::NotOnFeed)) {
        # Read release notes from readme.
        $ModuleReleaseNotes = & $ReadModuleReadMePS1 -ReadMePath $ModuleLevelReadMePath -FieldToRead "release-notes"
        if ($ModuleReleaseNotes -eq $null) {
            # Release notes not set in readme.md.
            Write-Error "Release notes not set on $ModulePrefix.$ModuleName module. Please set 'release-notes' in $ModuleLevelReadMePath."
        }

        try {
            if (-not $UseLocalDoc) {
                # Download OpenAPI document for module.
                & $DownloadOpenApiDocPS1 -ModuleName $ModuleName -ModuleRegex $ModuleMapping[$ModuleName] -OpenApiDocOutput $OpenApiDocOutput -GraphVersion $GraphVersion
            }

            # Generate PowerShell modules.
            Write-Host -ForegroundColor Green "Generating '$ModulePrefix.$ModuleName' module..."
            $OpenApiDocPath = Join-Path $OpenApiDocOutput "" -Resolve

            & AutoRest --module-version:$ModuleVersion --service-name:$ModuleName --spec-doc-repo:$OpenApiDocPath $ModuleLevelReadMePath --verbose
            if ($LASTEXITCODE) {
                Write-Error "Failed to generate '$ModuleName' module."
            }
            Write-Host -ForegroundColor Green "AutoRest generated '$ModulePrefix.$ModuleName' successfully 😊."

            # Manage generated module.
            Write-Host -ForegroundColor Green "Managing '$ModulePrefix.$ModuleName' module..."
            & $ManageGeneratedModulePS1 -Module $ModuleName -ModulePrefix $ModulePrefix -GraphVersion $GraphVersion

            if ($Build) {
                # Build generated module.
                if ($EnableSigning) {
                    # Sign generated module.
                    & $BuildModulePS1 -Module $ModuleName -ModulePrefix $ModulePrefix -GraphVersion $GraphVersion -ModuleVersion $ModuleVersion -ModulePreviewNumber $ModulePreviewNumber -RequiredModules $AuthenticationModule -ReleaseNotes $ModuleReleaseNotes -EnableSigning
                }
                else {
                    & $BuildModulePS1 -Module $ModuleName -ModulePrefix $ModulePrefix -GraphVersion $GraphVersion -ModuleVersion $ModuleVersion -ModulePreviewNumber $ModulePreviewNumber -RequiredModules $AuthenticationModule -ReleaseNotes $ModuleReleaseNotes
                }
            }

            if ($Pack) {
                # Pack generated module.
                & $PackModulePS1 -Module $ModuleName -GraphVersion $GraphVersion -ArtifactsLocation $ArtifactsLocation
            }
        }
        catch {
            Write-Error $_.Exception
        }
    }
}

if ($Publish) {
    # Publish generated modules.
    & $PublishModulePS1 -Modules $ModuleMapping.Keys -ModulePrefix $ModulePrefix -ArtifactsLocation $ArtifactsLocation -RepositoryName $RepositoryName -RepositoryApiKey $RepositoryApiKey
}

Write-Host -ForegroundColor Green "-------------Done-------------"
