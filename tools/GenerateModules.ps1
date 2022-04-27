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
    [switch] $SkipVersionCheck,
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

# Set NODE max memory to 8 Gb.
$ENV:NODE_OPTIONS='--max-old-space-size=8192'
$ModulePrefix = "Microsoft.Graph"
$ScriptRoot = $PSScriptRoot
$ModulesOutputPath = Join-Path $ScriptRoot "..\src\"
$ArtifactsLocation = Join-Path $ScriptRoot "..\artifacts"
$OpenApiPath = Join-Path $ScriptRoot "..\openApiDocs"
$TemplatePath = Join-Path $ScriptRoot "\Templates\"
# PS Scripts
$ManageGeneratedModulePS1 = Join-Path $ScriptRoot ".\ManageGeneratedModule.ps1" -Resolve
$BuildModulePS1 = Join-Path $ScriptRoot ".\BuildModule.ps1" -Resolve
$TestModulePS1 = Join-Path $ScriptRoot ".\TestModule.ps1" -Resolve
$PackModulePS1 = Join-Path $ScriptRoot ".\PackModule.ps1" -Resolve
$PublishModulePS1 = Join-Path $ScriptRoot ".\PublishModule.ps1" -Resolve
$ReadModuleReadMePS1 = Join-Path $ScriptRoot ".\ReadModuleReadMe.ps1" -Resolve
$ValidateUpdatedModuleVersionPS1 = Join-Path $ScriptRoot ".\ValidateUpdatedModuleVersion.ps1" -Resolve
$CleanUpPsm1 = Join-Path $ScriptRoot "\PostGeneration\CleanUpPsm1.ps1" -Resolve
. (Join-Path $ScriptRoot "\Utilities\FileUtils.ps1")
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
$RequiredGraphModules = @()

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
    autorest --reset
}

if ($ModulesToGenerate.Count -eq 0) {
    [HashTable] $ModuleMapping = Get-Content $ModuleMappingConfigPath | ConvertFrom-Json -AsHashTable
    $ModulesToGenerate = $ModuleMapping.Keys
}

$Stopwatch = [system.diagnostics.stopwatch]::StartNew()
$ModulesToGenerate | ForEach-Object{
    $Module = $_
    $ModulePath = Join-Path $ModulesOutputPath $Module
    $ModuleConfig = Join-Path $ModulePath "\$Module.md"
    Copy-ModuleTemplate -Destination $ModuleConfig -TemplatePath (Join-Path $TemplatePath "module.md") -ModuleName $Module

    # TODO: Add -ApiVersion parameter to generate script.
    @("v1.0", "beta") | ForEach-Object {
        $ApiVersion = $_
        $OpenApiFile = Join-Path $OpenApiPath $ApiVersion "$Module.yml"
        if (-not (Test-Path $OpenApiFile)) { break }

        $ModuleName = ($ApiVersion -eq "beta" ? "Beta.$Module" : $Module)
        $ModuleFullName = "$ModulePrefix.$ModuleName"
        $ModuleProjectPath = Join-Path $ModulePath $ApiVersion

        $AutoRestModuleConfig = Join-Path $ModuleProjectPath "\readme.md"
        Copy-ModuleTemplate -Destination $AutoRestModuleConfig -TemplatePath (Join-Path $ScriptRoot "\Templates\readme$ApiVersion.md") -ModuleName $Module

        # Read specified module version from readme.
        $ModuleVersion = . $ReadModuleReadMePS1 -ReadMePath $AutoRestModuleConfig -FieldToRead "module-version"
        if ($null -eq $ModuleVersion) {
            # Module version not set in readme.md.
            Write-Error "Version number is not set on $ModuleFullName module. Please set 'module-version' in $AutoRestModuleConfig."
        }

        # Validate module version with the one on PSGallery.
        [VersionState] $VersionState = & $ValidateUpdatedModuleVersionPS1 -ModuleName "$ModuleFullName" -NextVersion $ModuleVersion -PSRepository RepositoryName -ModulePreviewNumber $ModulePreviewNumber

        if ($VersionState.Equals([VersionState]::Invalid) -and !$SkipVersionCheck) {
            Write-Warning "The specified version in $ModuleFullName module is either higher or lower than what's on $RepositoryName. Update the 'module-version' in $AutoRestModuleConfig"
        }
        elseif ($VersionState.Equals([VersionState]::EqualToFeed) -and !$SkipVersionCheck) {
            Write-Warning "$ModuleFullName module skipped. Version has not changed and is equal to what's on $RepositoryName."
        }
        elseif ($VersionState.Equals([VersionState]::Valid) -or $VersionState.Equals([VersionState]::NotOnFeed) -or $SkipVersionCheck) {
            $ModuleReleaseNotes = & $ReadModuleReadMePS1 -ReadMePath $ModuleConfig -FieldToRead "release-notes"
            if ($ModuleReleaseNotes -eq $null) {
                # Release notes not set in readme.md.
                Write-Error "Release notes not set on $ModuleFullName module. Please set 'release-notes' in $AutoRestModuleConfig."
            }

            try {
                # Generate PowerShell modules.
                Write-Host -ForegroundColor Green "Generating '$ModuleFullName' module..."
                & autorest --module-version:$ModuleVersion --service-name:$ModuleName --input-file:$OpenApiFile $AutoRestModuleConfig
                if ($LASTEXITCODE) {
                    Write-Error "AutoREST failed to generate '$ModuleName' module."
                    break;
                }
                Write-Host -ForegroundColor Green "AutoRest generated '$ModuleFullName' successfully."

                # Manage generated module.
                Write-Debug "Managing '$ModuleFullName' module..."
                & $ManageGeneratedModulePS1 -ModuleName $ModuleFullName -ModuleSrc $ModuleProjectPath -ApiVersion $ApiVersion

                if ($Build) {
                    # Build generated module.
                    if ($EnableSigning) {
                        # Sign generated module.
                        & $BuildModulePS1 -ModuleFullName $ModuleFullName -ModuleSrc $ModuleProjectPath -ModuleVersion $ModuleVersion -ModulePreviewNumber $ModulePreviewNumber -RequiredModules $RequiredGraphModules -ReleaseNotes $ModuleReleaseNotes -EnableSigning -ExcludeExampleTemplates:$ExcludeExampleTemplates -ExcludeNotesSection:$ExcludeNotesSection
                    }
                    else {
                        & $BuildModulePS1 -ModuleFullName $ModuleFullName -ModuleSrc $ModuleProjectPath -ModuleVersion $ModuleVersion -ModulePreviewNumber $ModulePreviewNumber -RequiredModules $RequiredGraphModules -ReleaseNotes $ModuleReleaseNotes -ExcludeExampleTemplates:$ExcludeExampleTemplates -ExcludeNotesSection:$ExcludeNotesSection
                    }

                    & $CleanUpPsm1 -ModuleProjectPath $ModuleProjectPath -FullyQualifiedModuleName $ModuleFullName
                }

                if ($Test) {
                    & $TestModulePS1 -ModulePath $ModuleProjectPath -ModuleName $ModuleFullName -ModuleTestsPath (Join-Path $ModuleProjectPath "test")
                }

                if ($Pack) {
                    # TODO: Update PackModule script to use new project structure.
                    # Pack generated module.
                    #. $PackModulePS1 -Module $Module -ArtifactsLocation $ArtifactsLocation -ExcludeMarkdownDocsFromNugetPackage
                }

                Write-Host -ForeGroundColor Green "Generating $ModuleName Completed"
            }
            catch {
                Write-Error $_
            }
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
