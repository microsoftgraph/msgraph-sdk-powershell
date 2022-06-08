# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
[CmdletBinding()]
Param(
    $ModulesToGenerate = @(),
    [ValidateSet("v1.0", "beta")]
    $ApiVersionToGenerate = @("v1.0", "beta"),
    [string] $RepositoryName = "PSGallery",
    [int] $ModulePreviewNumber = -1,
    [switch] $SkipGeneration = $false,
    [switch] $Build,
    [switch] $Test,
    [switch] $Pack,
    [switch] $EnableSigning,
    [switch] $ExcludeExampleTemplates,
    [switch] $ExcludeNotesSection,
    [switch] $Isolated
)
$ErrorActionPreference = 'Stop'
$MaxMemorySize = 32768

if ($PSEdition -ne 'Core') {
    Write-Error 'This script requires PowerShell Core to execute. [Note] Generated cmdlets will work in both PowerShell Core or Windows PowerShell.'
}

if (-not $Isolated) {
    Write-Debug 'Creating isolated process...'
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
$ENV:NODE_OPTIONS = "--max-old-space-size=$MaxMemorySize"
$ModulePrefix = "Microsoft.Graph"
$ScriptRoot = $PSScriptRoot
$ModulesOutputPath = Join-Path $ScriptRoot "..\src\"
$ArtifactsLocation = Join-Path $ScriptRoot "..\artifacts"
$OpenApiPath = Join-Path $ScriptRoot "..\openApiDocs"
$TemplatePath = Join-Path $ScriptRoot "\Templates\"
$ModuleMappingConfigPath = (Join-Path $PSScriptRoot "..\config\ModulesMapping.jsonc")
# PS Scripts
$ManageGeneratedModulePS1 = Join-Path $ScriptRoot ".\ManageGeneratedModule.ps1" -Resolve
$BuildModulePS1 = Join-Path $ScriptRoot ".\BuildModule.ps1" -Resolve
$TestModulePS1 = Join-Path $ScriptRoot ".\TestModule.ps1" -Resolve
$PackModulePS1 = Join-Path $ScriptRoot ".\PackModule.ps1" -Resolve
$ReadModuleReadMePS1 = Join-Path $ScriptRoot ".\ReadModuleReadMe.ps1" -Resolve
$CleanUpPsm1 = Join-Path $ScriptRoot "\PostGeneration\CleanUpPsm1.ps1" -Resolve
. (Join-Path $ScriptRoot "\Utilities\FileUtils.ps1")
if (-not (Test-Path $ArtifactsLocation)) {
    New-Item -Path $ArtifactsLocation -Type Directory | Out-Null
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
Write-Debug "Auth Module: $($ExistingAuthModule.Name), $($ExistingAuthModule.Version)"
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

if ($ModulesToGenerate.Count -eq 0) {
    [HashTable] $ModuleMapping = Get-Content $ModuleMappingConfigPath | ConvertFrom-Json -AsHashTable
    $ModulesToGenerate = $ModuleMapping.Keys
}

$Stopwatch = [system.diagnostics.stopwatch]::StartNew()
$ModulesToGenerate | ForEach-Object {
    $Module = $_
    Write-Host -ForegroundColor Green "-------------'$Module'-------------"
    $ModulePath = Join-Path $ModulesOutputPath $Module
    $ModuleConfig = Join-Path $ModulePath "\$Module.md"
    Copy-ModuleTemplate -Destination $ModuleConfig -TemplatePath (Join-Path $TemplatePath "module.md") -ModuleName $Module

    $ModuleReleaseNotes = & $ReadModuleReadMePS1 -ReadMePath $ModuleConfig -FieldToRead "release-notes"
    if ($ModuleReleaseNotes -eq $null) {
        # Release notes not set in readme.md.
        Write-Error "Release notes not set on $ModuleFullName module. Please set 'release-notes' in $AutoRestModuleConfig."
    }

    $ApiVersionToGenerate | ForEach-Object {
        $ApiVersion = $_
        $OpenApiFile = Join-Path $OpenApiPath $ApiVersion "$Module.yml"
        if (Test-Path $OpenApiFile) {
            Write-Host -ForegroundColor Green "-------------[$ApiVersion]-------------"
            $NamespacePrefix = ($ApiVersion -eq "beta" ? "$ModulePrefix.Beta" : $ModulePrefix)
            # $ModuleName = ($ApiVersion -eq "beta" ? "Beta.$Module" : $Module)
            $ModuleFullName = "$NamespacePrefix.$Module"
            $ModuleProjectPath = Join-Path $ModulePath $ApiVersion

            $AutoRestModuleConfig = Join-Path $ModuleProjectPath "\readme.md"
            Copy-ModuleTemplate -Destination $AutoRestModuleConfig -TemplatePath (Join-Path $ScriptRoot "\Templates\readme$ApiVersion.md") -ModuleName $Module

            # Read specified module version from readme.
            $ModuleVersion = . $ReadModuleReadMePS1 -ReadMePath $AutoRestModuleConfig -FieldToRead "module-version"
            if ($null -eq $ModuleVersion) {
                # Module version not set in readme.md.
                Write-Error "Version number is not set on $ModuleFullName module. Please set 'module-version' in $AutoRestModuleConfig."
            }

            if ($SkipGeneration) {
                Write-Warning "Skipping generation of '$ModuleFullName - $ApiVersion' module."
            }
            else {
                npx autorest --max-memory-size=$MaxMemorySize --module-version:$ModuleVersion --module-name:$ModuleFullName --service-name:$Module --input-file:$OpenApiFile $AutoRestModuleConfig
                if ($LastExitCode -ne 0) {
                    Write-Host -ForegroundColor Red "AutoREST failed to generate '$ModuleFullName' module."
                    exit $LastExitCode
                }
                Write-Debug "AutoRest generated '$ModuleFullName' successfully."

                # Manage generated module.
                Write-Debug "Managing '$ModuleFullName' module..."
                & $ManageGeneratedModulePS1 -ModuleName $ModuleFullName -ModuleSrc $ModuleProjectPath -NamespacePrefix $NamespacePrefix
            }

            if ($Build) {
                # Build generated module.
                if ($EnableSigning) {
                    & $BuildModulePS1 -ModuleFullName $ModuleFullName -ModuleSrc $ModuleProjectPath -ModuleVersion $ModuleVersion -ModulePreviewNumber $ModulePreviewNumber -RequiredModules $RequiredGraphModules -ReleaseNotes $ModuleReleaseNotes -EnableSigning -ExcludeExampleTemplates:$ExcludeExampleTemplates -ExcludeNotesSection:$ExcludeNotesSection
                }
                else {
                    & $BuildModulePS1 -ModuleFullName $ModuleFullName -ModuleSrc $ModuleProjectPath -ModuleVersion $ModuleVersion -ModulePreviewNumber $ModulePreviewNumber -RequiredModules $RequiredGraphModules -ReleaseNotes $ModuleReleaseNotes -ExcludeExampleTemplates:$ExcludeExampleTemplates -ExcludeNotesSection:$ExcludeNotesSection
                }
                & $CleanUpPsm1 -ModuleProjectPath $ModuleProjectPath -FullyQualifiedModuleName $ModuleFullName
                if ($LastExitCode -ne 0) {
                    Write-Host -ForegroundColor Red "Failed to build '$ModuleFullName' module."
                    exit $LastExitCode
                }
            }

            if ($Test) {
                & $TestModulePS1 -ModulePath $ModuleProjectPath -ModuleName $ModuleFullName -ModuleTestsPath (Join-Path $ModuleProjectPath "test")
            }

            if ($Pack) {
                & $PackModulePS1 -ModuleFullName $ModuleFullName -ModuleSrc $ModuleProjectPath -Module $Module -ArtifactsLocation $ArtifactsLocation -ExcludeMarkdownDocsFromNugetPackage
            }
        }
    }
}
$stopwatch.Stop()
Write-Host -ForegroundColor Green "Generated SDK in '$($Stopwatch.Elapsed.TotalMinutes)' minutes."
