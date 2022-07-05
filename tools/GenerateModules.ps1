﻿# Copyright (c) Microsoft Corporation. All rights reserved.
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
    [switch] $SkipVersionCheck,
    [switch] $SkipGeneration,
    [switch] $ExcludeExampleTemplates,
    [switch] $ExcludeNotesSection,
    [switch] $Isolated
)
enum VersionState {
    Invalid
    Valid
    EqualToFeed
    NotOnFeed
}
$Error.Clear()
$ErrorActionPreference = 'Stop'

if ($PSEdition -ne 'Core') {
    Write-Error 'This script requires PowerShell Core to execute. [Note] Generated cmdlets will work in both PowerShell Core or Windows PowerShell.'
}

if (-not $Isolated) {
    Write-Host -ForegroundColor Green 'Creating isolated process...'
    $pwsh = [System.Diagnostics.Process]::GetCurrentProcess().Path
    & "$pwsh" -NonInteractive -NoLogo -NoProfile -File $MyInvocation.MyCommand.Path @PSBoundParameters -Isolated
    return
}

# Module import.
Import-Module PowerShellGet

# Install Powershell-yaml
if (!(Get-Module -Name powershell-yaml -ListAvailable)) {
    Install-Module powershell-yaml -Repository PSGallery -Scope CurrentUser -Force
}

# Set NODE max heap size to 32 Gb. This is assuming the VM has this memory.
$ENV:NODE_OPTIONS='--max-old-space-size=32768'
$ModulePrefix = "Microsoft.Graph"
$ScriptRoot = $PSScriptRoot
$ModulesOutputDir = Join-Path $ScriptRoot "..\src\"
$ArtifactsLocation = Join-Path $ScriptRoot "..\artifacts"
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

if (!$SkipGeneration)
{
    # Build AutoREST.PowerShell submodule.
    Set-Location (Join-Path $ScriptRoot "../autorest.powershell")
    rush update
    rush build
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

$NumberOfCores = ((Get-ComputerInfo -Property CsProcessors).CsProcessors.NumberOfCores)[0]
Write-Host -ForegroundColor Green "Using '$NumberOfCores' cores in parallel."

$Stopwatch = [system.diagnostics.stopwatch]::StartNew()
$ModulesToGenerate | ForEach-Object -ThrottleLimit $NumberOfCores -Parallel {
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

    # Test to see if a module's profile exists.
    $ProfileReadmePath = Join-Path -Path $Using:ScriptRoot "..\profiles\$ModuleName\readme.md"
    if (!(Test-Path -Path $ProfileReadmePath)) {
        Write-Warning "[Generation skipped] : Module '$ModuleName' not found at $ProfileReadmePath."
        break
    }

    # Copy AutoRest readme.md config is none exists.
    if (-not (Test-Path "$ModuleProjectDir\readme.md")) {
        New-Item -Path $ModuleProjectDir -Type Directory -Force
        Copy-Item (Join-Path $Using:ScriptRoot "\Templates\readme.md") -Destination $ModuleProjectDir
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
            if (!$using:SkipGeneration)
            {
                & autorest --module-version:$ModuleVersion --service-name:$ModuleName --version:"3.0.6306" $ModuleLevelReadMePath --verbose
                if ($LASTEXITCODE) {
                    Write-Error "AutoREST failed to generate '$ModuleName' module."
                    break;
                }
                Write-Host -ForegroundColor Green "AutoRest generated '$FullyQualifiedModuleName' successfully."
            }

            # Manage generated module.
            Write-Host -ForegroundColor Green "Managing '$FullyQualifiedModuleName' module..."
            & $Using:ManageGeneratedModulePS1 -Module $ModuleName -ModulePrefix $Using:ModulePrefix

            if ($Using:Build) {
                # Build generated module.
                if ($Using:EnableSigning) {
                    # Sign generated module.
                    & $Using:BuildModulePS1 -Module $ModuleName -ModulePrefix $Using:ModulePrefix -ModuleVersion $ModuleVersion -ModulePreviewNumber $Using:ModulePreviewNumber -RequiredModules $Using:RequiredGraphModules -ReleaseNotes $ModuleReleaseNotes -EnableSigning -ExcludeExampleTemplates:$Using:ExcludeExampleTemplates -ExcludeNotesSection:$Using:ExcludeNotesSection
                }
                else {
                    & $Using:BuildModulePS1 -Module $ModuleName -ModulePrefix $Using:ModulePrefix -ModuleVersion $ModuleVersion -ModulePreviewNumber $Using:ModulePreviewNumber -RequiredModules $Using:RequiredGraphModules -ReleaseNotes $ModuleReleaseNotes -ExcludeExampleTemplates:$Using:ExcludeExampleTemplates -ExcludeNotesSection:$Using:ExcludeNotesSection
                }

                # Get profiles for generated modules.
                $ModuleExportsPath = Join-Path $ModuleProjectDir "\exports"
                $Profiles = Get-ChildItem -Path $ModuleExportsPath -Directory | % { $_.Name }

                # Update module manifest.
                $ExistingServiceModule = Find-Module $FullyQualifiedModuleName -Repository PSGallery -ErrorAction SilentlyContinue
                $ModuleGuid = ($null -eq $ExistingServiceModule) ? (New-Guid).Guid : $ExistingServiceModule.AdditionalMetadata.GUID
                [HashTable]$PrivateData = @{ Profiles = $Profiles }
                Update-ModuleManifest -Path (Join-Path $ModuleProjectDir "$FullyQualifiedModuleName.psd1") -PrivateData $PrivateData -Guid $ModuleGuid

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
            }

            if ($Using:Test) {
                & $Using:TestModulePS1 -ModulePath $ModuleProjectDir -ModuleName $FullyQualifiedModuleName -ModuleTestsPath (Join-Path $ModuleProjectDir "test")
            }

            if ($Using:Pack) {
                # Pack generated module.
                . $Using:PackModulePS1 -Module $ModuleName -ArtifactsLocation $Using:ArtifactsLocation -ExcludeMarkdownDocsFromNugetPackage
            }

            Write-Host -ForeGroundColor Green "Generating $ModuleName Completed"
        }
        catch {
            Write-Error $_
        }
    }
}
$stopwatch.Stop()

if ($Error.Count -ge 1) {
    # Write generation errors to pipeline.
    $Error
    Write-Error "The SDK failed to build due to $($Error.Count) errors listed above in '$($Stopwatch.Elapsed.TotalMinutes)` minutes." -ErrorAction "Stop"
}
Write-Host -ForegroundColor Green "Generated SDK in '$($Stopwatch.Elapsed.TotalMinutes)` minutes."

if ($Publish) {
    # Publish generated modules.
    & $PublishModulePS1 -Modules $ModuleMapping.Keys -ModulePrefix $ModulePrefix -ArtifactsLocation $ArtifactsLocation -RepositoryName $RepositoryName -RepositoryApiKey $RepositoryApiKey
}

Write-Host -ForegroundColor Green "-------------Done-------------"
