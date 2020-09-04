# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
Param(
    [string] $RepositoryApiKey,
    [string] $RepositoryName = "PSGallery",
    [int] $ModulePreviewNumber = -1,
    [string] $ModuleMappingConfigPath = (Join-Path $PSScriptRoot "..\config\ModulesMapping.jsonc"),
    [switch] $UpdateAutoRest,
    [switch] $Build,
    [switch] $Pack,
    [switch] $Publish,
    [switch] $EnableSigning,
    [switch] $SkipVersionCheck
)
enum VersionState {
    Invalid
    Valid
    EqualToFeed
    NotOnFeed
}
$ErrorActionPreference = 'Continue'
if ($PSEdition -ne 'Core') {
    Write-Error 'This script requires PowerShell Core to execute. [Note] Generated cmdlets will work in both PowerShell Core or Windows PowerShell.'
}
# Install Powershell-yaml
if (!(Get-Module -Name powershell-yaml -ListAvailable)) {
    Install-Module powershell-yaml -Force   
}

$ModulePrefix = "Microsoft.Graph"
$ModulesOutputDir = Join-Path $PSScriptRoot "..\src\"
$ArtifactsLocation = Join-Path $PSScriptRoot "..\artifacts"
$RequiredGraphModules = @()
# PS Scripts
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
$ExistingAuthModule = Find-Module "Microsoft.Graph.Authentication" -Repository $RepositoryName
if (!(Get-Module -Name $ExistingAuthModule.Name -ListAvailable)) {
    Install-Module $ExistingAuthModule.Name -Repository $RepositoryName -AllowPrerelease -Force
}
$RequiredGraphModules += @{ ModuleName = $ExistingAuthModule.Name ; ModuleVersion = $ExistingAuthModule.Version }
if ($UpdateAutoRest) {
    # Update AutoRest.
    & autorest --reset
}
[HashTable] $ModuleMapping = Get-Content $ModuleMappingConfigPath | ConvertFrom-Json -AsHashTable
$RequestCount = 0
$ModuleMapping.Keys | ForEach-Object -ThrottleLimit 24 -Parallel {
    enum VersionState {
        Invalid
        Valid
        EqualToFeed
        NotOnFeed
    }
    
    $ModuleName = $_
    Write-Warning "Generating $ModuleName"
    $ModuleProjectDir = Join-Path $Using:ModulesOutputDir "$ModuleName\$ModuleName"

    # Copy AutoRest readme.md config is none exists.
    if (-not (Test-Path "$ModuleProjectDir\readme.md")) {
        New-Item -Path $ModuleProjectDir -Type Directory -Force
        Copy-Item (Join-Path $PSScriptRoot "\Templates\readme.md") -Destination $ModuleProjectDir
    }

    $ModuleLevelReadMePath = Join-Path $ModuleProjectDir "\readme.md" -Resolve

    # Read specified module version from readme.
    $ModuleVersion = & $Using:ReadModuleReadMePS1 -ReadMePath $ModuleLevelReadMePath -FieldToRead "module-version"
    if ($ModuleVersion -eq $null) {
        # Module version not set in readme.md.
        Write-Error "Version number is not set on $Using:ModulePrefix.$ModuleName module. Please set 'module-version' in $ModuleLevelReadMePath."
    }

    # Validate module version with the one on PSGallery.
    [VersionState] $VersionState = & $Using:ValidateUpdatedModuleVersionPS1 -ModuleName "$Using:ModulePrefix.$ModuleName" -NextVersion $ModuleVersion

    if ($VersionState.Equals([VersionState]::Invalid) -and !$Using:SkipVersionCheck) {
        Write-Warning "The specified version in $Using:ModulePrefix.$ModuleName module is either higher or lower than what's on $Using:RepositoryName. Update the 'module-version' in $ModuleLevelReadMePath"
    }
    elseif ($VersionState.Equals([VersionState]::EqualToFeed) -and !$SkipVersionCheck) {
        Write-Warning "$Using:ModulePrefix.$ModuleName module skipped. Version has not changed and is equal to what's on $Using:RepositoryName."
    }
    elseif ($VersionState.Equals([VersionState]::Valid) -or $VersionState.Equals([VersionState]::NotOnFeed) -or $Using:SkipVersionCheck) {
        # Read release notes from readme.
        $ModuleReleaseNotes = & $Using:ReadModuleReadMePS1 -ReadMePath $ModuleLevelReadMePath -FieldToRead "release-notes"
        if ($ModuleReleaseNotes -eq $null) {
            # Release notes not set in readme.md.
            Write-Error "Release notes not set on $Using:ModulePrefix.$ModuleName module. Please set 'release-notes' in $ModuleLevelReadMePath."
        }

        try {
            # Generate PowerShell modules.
            Write-Host -ForegroundColor Green "Generating '$Using:ModulePrefix.$ModuleName' module..."
            & autorest --module-version:$ModuleVersion --service-name:$ModuleName $ModuleLevelReadMePath --verbose
            if ($LASTEXITCODE) {
                Write-Error "Failed to generate '$ModuleName' module."
            }
            Write-Host -ForegroundColor Green "AutoRest generated '$Using:ModulePrefix.$ModuleName' successfully."

            # Manage generated module.
            Write-Host -ForegroundColor Green "Managing '$Using:ModulePrefix.$ModuleName' module..."
            & $Using:ManageGeneratedModulePS1 -Module $ModuleName -ModulePrefix $Using:ModulePrefix

            if ($Using:Build) {
                # Build generated module.
                if ($Using:EnableSigning) {
                    # Sign generated module.
                    & $Using:BuildModulePS1 -Module $ModuleName -ModulePrefix $Using:ModulePrefix -ModuleVersion $ModuleVersion -ModulePreviewNumber $Using:ModulePreviewNumber -RequiredModules $Using:RequiredGraphModules -ReleaseNotes $ModuleReleaseNotes -EnableSigning
                }
                else {
                    & $Using:BuildModulePS1 -Module $ModuleName -ModulePrefix $Using:ModulePrefix -ModuleVersion $ModuleVersion -ModulePreviewNumber $Using:ModulePreviewNumber -RequiredModules $Using:RequiredGraphModules -ReleaseNotes $ModuleReleaseNotes
                }

                # Get profiles for generated modules.
                $ModuleExportsPath = Join-Path $ModuleProjectDir "\exports"
                $Profiles = Get-ChildItem -Path $ModuleExportsPath -Directory | %{ $_.Name}

                # Update module manifest wiht profiles.
                $ModuleManifestPath = Join-Path $ModuleProjectDir "$Using:ModulePrefix.$ModuleName.psd1"
                [HashTable]$PrivateData = @{ Profiles = $Profiles }
                Update-ModuleManifest -Path $ModuleManifestPath -PrivateData $PrivateData

                # Update module psm1 with Graph session profile name.
                $ModulePsm1 = Join-Path $ModuleProjectDir "/$Using:ModulePrefix.$ModuleName.psm1"
                (Get-Content -Path $ModulePsm1) | ForEach-Object{
                    $_
                    if ($_ -match '\$instance = \[Microsoft.Graph.PowerShell.Module\]::Instance') {
                        '  $instance.ProfileName = [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.SelectedProfile'
                    }
                } | Set-Content $ModulePsm1

                # Address AutoREST bug where it looks for exports in the wrong directory.
                $InternalModulePsm1 = Join-Path $ModuleProjectDir "/internal/$Using:ModulePrefix.$ModuleName.internal.psm1"
                (Get-Content -Path $InternalModulePsm1) | ForEach-Object{
                    $_
                    if ($_ -match '\$exportsPath = \$PSScriptRoot') {
                        '  $exportsPath = Join-Path $PSScriptRoot "../exports"'
                    }
                } | Set-Content $InternalModulePsm1
                
                if ($LASTEXITCODE) {
                    Write-Error "Failed to build '$ModuleName' module."
                }
            }

            if ($Using:Pack) {
                # Pack generated module.
                & $Using:PackModulePS1 -Module $ModuleName -ArtifactsLocation $Using:ArtifactsLocation
            }
        }
        catch {
            Write-Error $_.Exception
        }
        #$Using:RequestCount=$Using:RequestCount+1
        Write-Warning "Generating $ModuleName Completed"
    }
}

Write-Host -ForeGroundColor Green "Requests: $RequestCount"
if ($Publish) {
    # Publish generated modules.
    & $PublishModulePS1 -Modules $ModuleMapping.Keys -ModulePrefix $ModulePrefix -ArtifactsLocation $ArtifactsLocation -RepositoryName $RepositoryName -RepositoryApiKey $RepositoryApiKey
}

Write-Host -ForegroundColor Green "-------------Done-------------"
