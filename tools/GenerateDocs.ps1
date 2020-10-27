# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

param (
    [string] $ModuleMappingConfigPath = (Join-Path $PSScriptRoot "..\config\ModulesMapping.jsonc"),
    [string] $RepositoryName = "PSGallery",
    [string] $OutputFolder = (Join-Path $PSScriptRoot "..\docs\")
)
# if ($PSEdition -ne 'Core') {
#     Write-Error 'This script requires PowerShell Core to execute. [Note] Generated cmdlets will work in both PowerShell Core or Windows PowerShell.'
# }
#Install Dependency Modules
if (!(Get-Module -Name powershell-yaml -ListAvailable)) {
    Install-Module powershell-yaml -Force   
}
if (!(Get-Module -Name platyps -ListAvailable)) {
    Install-Module platyps -Force   
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

if (!(Get-Module -Name $ExistingAuthModule.Name -ListAvailable)) {
    Install-Module $ExistingAuthModule.Name -Repository $RepositoryName -Force -AllowClobber -AllowPrerelease:$AllowPreRelease
}
Import-Module $ExistingAuthModule.Name -Force
$AuthModuleDirectory = Join-Path $OutputFolder $ExistingAuthModule.Name
if (-not (Test-Path $AuthModuleDirectory)) {
    New-Item -Path $AuthModuleDirectory -Type Directory -Force

    $parameters = @{
        Module                = $ExistingAuthModule.Name
        OutputFolder          = $AuthModuleDirectory
        AlphabeticParamsOrder = $true
        WithModulePage        = $true
        ExcludeDontShow       = $true
    }

    New-MarkdownHelp @parameters
    New-MarkdownAboutHelp -OutputFolder $AuthModuleDirectory -AboutName $ExistingAuthModule.Name
}
else {
    $logFile = $ExistingAuthModule.Name
    $logsPath = Join-Path $PSScriptRoot "..\logs\$logFile.txt"
    Write-Host "Logs Path: $logsPath"
    $parameters = @{
        Path                  = $AuthModuleDirectory
        RefreshModulePage     = $true
        AlphabeticParamsOrder = $true
        UpdateInputOutput     = $true
        ExcludeDontShow       = $true
        LogPath               = $logsPath
    }
    Update-MarkdownHelpModule @parameters
}       

[HashTable] $ModuleMapping = Get-Content $ModuleMappingConfigPath | ConvertFrom-Json -AsHashtable

$ModuleMapping.Keys | ForEach-Object -ThrottleLimit $ModuleMapping.Keys.Count -Parallel {
    $ModuleName = $_
    $ExistingWorkloadModule = Find-Module "Microsoft.Graph.$ModuleName" -Repository $Using:RepositoryName -AllowPrerelease:$Using:AllowPreRelease
    Write-Warning "$ModuleName $ExistingWorkloadModule"
    if (!(Get-Module -Name $ExistingWorkloadModule.Name -ListAvailable)) {
        Install-Module $ExistingWorkloadModule.Name -Repository $Using:RepositoryName -Force -AllowClobber -AllowPrerelease:$Using:AllowPreRelease
    }
    Import-Module $ExistingWorkloadModule.Name -Force
    $ExistingWorkloadModulePath = Join-Path $Using:OutputFolder $ExistingWorkloadModule.Name
    if (-not (Test-Path $ExistingWorkloadModulePath)) {
        New-Item -Path $ExistingWorkloadModulePath -Type Directory -Force
        $parameters = @{
            Module                = $ExistingWorkloadModule.Name
            OutputFolder          = $ExistingWorkloadModulePath
            AlphabeticParamsOrder = $true
            WithModulePage        = $true
            ExcludeDontShow       = $true
        }
        New-MarkdownHelp @parameters
        New-MarkdownAboutHelp -OutputFolder $ExistingWorkloadModulePath -AboutName $ExistingWorkloadModule.Name
    }
    else {
        $logFile = $ExistingWorkloadModule.Name
        $logsPath = Join-Path $Using:PSScriptRoot "..\logs\$logFile.txt"
        $parameters = @{
            Path                  = $ExistingWorkloadModulePath
            RefreshModulePage     = $true
            AlphabeticParamsOrder = $true
            UpdateInputOutput     = $true
            ExcludeDontShow       = $true
            LogPath               = $logsPath
        }
        Update-MarkdownHelpModule @parameters
    }
}