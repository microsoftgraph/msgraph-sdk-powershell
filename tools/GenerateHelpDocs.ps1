# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

param (
    [string] $ModuleMappingConfigPath = (Join-Path $PSScriptRoot "..\config\ModulesMapping.jsonc"),
    [string] $RepositoryName = "PSGallery",
    [string] $ModulePreviewNumber = -1
)
    if ($PSEdition -ne 'Core') {
        Write-Error 'This script requires PowerShell Core to execute. [Note] Generated cmdlets will work in both PowerShell Core or Windows PowerShell.'
    }
    $GenerateHelpDocsForModules = Join-Path $PSScriptRoot ".\GenerateHelpDocsForModules.ps1" -Resolve
    #Install Dependency Modules
    if (!(Get-Module -Name powershell-yaml -ListAvailable)) {
        Install-Module powershell-yaml -Force -Scope CurrentUser
    }
    if (!(Get-Module -Name platyps -ListAvailable)) {
        Install-Module platyps -Force -Scope CurrentUser
    }
    Import-Module platyps
    $ModulePrefix = "Microsoft.Graph"

    $AllowPreRelease = $true
    if ($ModulePreviewNumber -eq -1) {
        $AllowPreRelease = $false
    }
    # Install module locally in order to specify it as a dependency for other modules down the generation pipeline.
    # https://stackoverflow.com/questions/46216038/how-do-i-define-requiredmodules-in-a-powershell-module-manifest-psd1.
    $ExistingAuthModule = Find-Module "Microsoft.Graph.Authentication" -Repository $RepositoryName -AllowPrerelease:$AllowPreRelease
    Write-Warning "Auth Module: $ExistingAuthModule"
    Uninstall-Module $ExistingAuthModule.Name -Force -AllVersions -ErrorAction Continue
    Remove-Module  $ExistingAuthModule.Name -Force -ErrorAction Continue
    Install-Module $ExistingAuthModule.Name -Repository $RepositoryName -Force -AllowClobber -AllowPrerelease:$AllowPreRelease -Scope CurrentUser
    Import-Module $ExistingAuthModule.Name -Force -Scope Global
    $AuthModuleHelpDirectory = ".\src\Authentication\Authentication\help"
    if (-not (Test-Path (Join-Path $AuthModuleHelpDirectory "*"))) {
        New-Item -Path $AuthModuleHelpDirectory -Type Directory -Force

        $parameters = @{
            Module                = $ExistingAuthModule.Name
            OutputFolder          = $AuthModuleHelpDirectory
            AlphabeticParamsOrder = $true
            WithModulePage        = $true
            ExcludeDontShow       = $true
        }

        New-MarkdownHelp @parameters
        New-MarkdownAboutHelp -OutputFolder $AuthModuleHelpDirectory -AboutName $ExistingAuthModule.Name
    }
    else {
        $logFile = $ExistingAuthModule.Name
        $logsPath = Join-Path $PSScriptRoot "..\logs\$logFile.txt"
        Write-Host "Logs Path: $logsPath"
        $parameters = @{
            Path                  = $AuthModuleHelpDirectory
            RefreshModulePage     = $true
            AlphabeticParamsOrder = $true
            UpdateInputOutput     = $true
            ExcludeDontShow       = $true
            LogPath               = $logsPath
        }
        Update-MarkdownHelpModule @parameters
    }    

& $GenerateHelpDocsForModules -ModuleMappingConfigPath $ModuleMappingConfigPath -RepositoryName $RepositoryName -AllowPreRelease:$AllowPreRelease