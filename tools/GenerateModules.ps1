# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
Param(
    $ModulesToGenerate = @(),
    [string] $RepositoryApiKey,
    [string] $RepositoryName = "PSGallery",
    [int] $ModulePreviewNumber = -1,
    [string] $ModuleMappingConfigPath = (Join-Path $PSScriptRoot "..\config\ModulesMapping.jsonc"),
    [switch] $UpdateAutoRest,
    [switch] $Build,
    [switch] $Test,
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
$TestModulePS1 = Join-Path $PSScriptRoot ".\TestModule.ps1" -Resolve
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

$AllowPreRelease = $true
if ($ModulePreviewNumber -eq -1) {
    $AllowPreRelease = $false
}
# Install module locally in order to specify it as a dependency for other modules down the generation pipeline.
# https://stackoverflow.com/questions/46216038/how-do-i-define-requiredmodules-in-a-powershell-module-manifest-psd1.
$ExistingAuthModule = Find-Module "Microsoft.Graph.Authentication" -Repository $RepositoryName -AllowPrerelease:$AllowPreRelease
Write-Host -ForegroundColor Green "Auth Module: $($ExistingAuthModule.Name), $($ExistingAuthModule.Version)"
if (!(Get-Module -Name $ExistingAuthModule.Name -ListAvailable)) {
    Install-Module $ExistingAuthModule.Name -Repository $RepositoryName -Force -AllowClobber -AllowPrerelease:$AllowPreRelease
}
if ($ExistingAuthModule.Version -like '*preview*' ) {
    $version = $ExistingAuthModule.Version.Remove($ExistingAuthModule.Version.IndexOf('-'))
    Write-Warning "Required Version:  $ModulePrefix.$RequiredModule Version: $version"
    $RequiredGraphModules += @{ ModuleName = $ExistingAuthModule.Name ; ModuleVersion = $version }
}
else {
    $RequiredGraphModules += @{ ModuleName = $ExistingAuthModule.Name ; ModuleVersion = $ExistingAuthModule.Version }
}

if ($UpdateAutoRest) {
    # Update AutoRest.
    & autorest --reset
}

if ($ModulesToGenerate.Count -eq 0) {
    [HashTable] $ModuleMapping = Get-Content $ModuleMappingConfigPath | ConvertFrom-Json -AsHashTable
    $ModulesToGenerate = $ModuleMapping.Keys
}

$ModulesToGenerate | ForEach-Object -ThrottleLimit $ModulesToGenerate.Count -Parallel {
    enum VersionState {
        Invalid
        Valid
        EqualToFeed
        NotOnFeed
    }
    
    $ModuleName = $_
    $FullyQualifiedModuleName = "$using:ModulePrefix.$ModuleName"
    Write-Host -ForegroundColor Green "Generating '$FullyQualifiedModuleName' module..."
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
        Write-Error "Version number is not set on $FullyQualifiedModuleName module. Please set 'module-version' in $ModuleLevelReadMePath."
    }

    # Validate module version with the one on PSGallery.
    [VersionState] $VersionState = & $Using:ValidateUpdatedModuleVersionPS1 -ModuleName "$FullyQualifiedModuleName" -NextVersion $ModuleVersion -PSRepository RepositoryName -ModulePreviewNumber $ModulePreviewNumber

    if ($VersionState.Equals([VersionState]::Invalid) -and !$Using:SkipVersionCheck) {
        Write-Warning "The specified version in $FullyQualifiedModuleName module is either higher or lower than what's on $Using:RepositoryName. Update the 'module-version' in $ModuleLevelReadMePath"
    }
    elseif ($VersionState.Equals([VersionState]::EqualToFeed) -and !$SkipVersionCheck) {
        Write-Warning "$FullyQualifiedModuleName module skipped. Version has not changed and is equal to what's on $Using:RepositoryName."
    }
    elseif ($VersionState.Equals([VersionState]::Valid) -or $VersionState.Equals([VersionState]::NotOnFeed) -or $Using:SkipVersionCheck) {
        # Read release notes from readme.
        $ModuleReleaseNotes = & $Using:ReadModuleReadMePS1 -ReadMePath $ModuleLevelReadMePath -FieldToRead "release-notes"
        if ($ModuleReleaseNotes -eq $null) {
            # Release notes not set in readme.md.
            Write-Error "Release notes not set on $FullyQualifiedModuleName module. Please set 'release-notes' in $ModuleLevelReadMePath."
        }

        try {
            # Generate PowerShell modules.
            & autorest --module-version:$ModuleVersion --service-name:$ModuleName $ModuleLevelReadMePath --version:"3.0.6306" --verbose
            if ($LASTEXITCODE) {
                Write-Error "Failed to generate '$ModuleName' module."
            }
            Write-Host -ForegroundColor Green "AutoRest generated '$FullyQualifiedModuleName' successfully."

            # Manage generated module.
            Write-Host -ForegroundColor Green "Managing '$FullyQualifiedModuleName' module..."
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
                $Profiles = Get-ChildItem -Path $ModuleExportsPath -Directory | % { $_.Name }

                # Update module manifest wiht profiles.
                $ModuleManifestPath = Join-Path $ModuleProjectDir "$FullyQualifiedModuleName.psd1"
                [HashTable]$PrivateData = @{ Profiles = $Profiles }
                Update-ModuleManifest -Path $ModuleManifestPath -PrivateData $PrivateData

                # Update module psm1 with Graph session profile name.
                $ModulePsm1 = Join-Path $ModuleProjectDir "/$FullyQualifiedModuleName.psm1"
                (Get-Content -Path $ModulePsm1) | ForEach-Object {
                    if ($_ -match '\$instance = \[Microsoft.Graph.PowerShell.Module\]::Instance') {
                        # Update main psm1 with Graph session profile name and module name.
                        $_
                        '  $instance.ProfileName = [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.SelectedProfile'
                    }
                    else {
                        # Rename all Azure instances in psm1 to `Microsoft Graph`.
                        $updatedLine = $_ -replace 'Azure', 'Microsoft Graph'
                        # Replace all 'instance.Name' declarations with fully qualified module name.
                        $updatedLine = $updatedLine -replace '\$\(\$instance.Name\)', "$FullyQualifiedModuleName"
                        # Replace Write-Information with Write-Debug
                        $updatedLine = $updatedLine -replace 'Write\-Information', 'Write-Debug'
                        $updatedLine
                    }
                } | Set-Content $ModulePsm1

                # Address AutoREST bug where it looks for exports in the wrong directory.
                $InternalModulePsm1 = Join-Path $ModuleProjectDir "/internal/$FullyQualifiedModuleName.internal.psm1"
                (Get-Content -Path $InternalModulePsm1) | ForEach-Object {
                    $updatedLine = $_
                    # Address AutoREST bug where it looks for exports in the wrong directory.
                    if ($_ -match '\$exportsPath = \$PSScriptRoot') {
                        $updatedLine = '  $exportsPath = Join-Path $PSScriptRoot "../exports"'
                    }
                    
                    # Remove duplicate instance.Name declarations in internal.psm1
                    # Main .psm1 already handles this.
                    if ($_ -match '\$\(\$instance.Name\)') {
                        $updatedLine = ""
                    }
                    $updatedLine
                } | Set-Content $InternalModulePsm1
                
                if ($LASTEXITCODE) {
                    Write-Error "Failed to build '$ModuleName' module."
                }
            }

            if ($Using:Test) {
                & $Using:TestModulePS1 -ModulePath $ModuleProjectDir -ModuleName $FullyQualifiedModuleName
            }

            if ($Using:Pack) {
                # Pack generated module.
                . $Using:PackModulePS1 -Module $ModuleName -ArtifactsLocation $Using:ArtifactsLocation
            }
        }
        catch {
            throw $_
        }
        Write-Host -ForeGroundColor Green "Generating $ModuleName Completed"
    }
}

if ($Publish) {
    # Publish generated modules.
    & $PublishModulePS1 -Modules $ModuleMapping.Keys -ModulePrefix $ModulePrefix -ArtifactsLocation $ArtifactsLocation -RepositoryName $RepositoryName -RepositoryApiKey $RepositoryApiKey
}

Write-Host -ForegroundColor Green "-------------Done-------------"
