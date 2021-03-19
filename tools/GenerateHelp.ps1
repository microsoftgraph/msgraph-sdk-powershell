
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
Param(
    $ModulesToGenerate = @(),
    [string] $ModuleMappingConfigPath = (Join-Path $PSScriptRoot "..\config\ModulesMapping.jsonc")
)
Install-Module PlatyPS -Force
Import-Module PlatyPS -Force -Scope Global

$ErrorActionPreference = 'Stop'
$LASTEXITCODE = $null
if ($PSEdition -ne 'Core') {
    Write-Error 'This script requires PowerShell Core to execute. [Note] Generated cmdlets will work in both PowerShell Core or Windows PowerShell.'
}

if (-not (Test-Path $ModuleMappingConfigPath)) {
    Write-Error "Module mapping file not be found: $ModuleMappingConfigPath."
}
if ($ModulesToGenerate.Count -eq 0) {
    [HashTable] $ModuleMapping = Get-Content $ModuleMappingConfigPath | ConvertFrom-Json -AsHashTable
    $ModulesToGenerate = $ModuleMapping.Keys
}

$ModulePrefix = "Microsoft.Graph"
Import-Module ".\src\Authentication\Authentication\Microsoft.Graph.Authentication.psd1" -Force -Scope Global
$ModulesToGenerate | ForEach-Object {
    $ModuleName = $_
    $modulePath = ".\src\$ModuleName\$ModuleName\$ModulePrefix.$ModuleName.psd1"
    Write-Host "Current Module Path $modulePath"
    Import-Module $modulePath -Force -Scope Global
    #Handle Beta
    $betaModuleDocs = ".\src\$RequiredModule\$RequiredModule\docs\v1.0-beta\"
    if(Test-Path $betaModuleDocs){
        Select-MgProfile beta
        Update-MarkdownHelpModule -Path $betaModuleDocs -RefreshModulePage -AlphabeticParamsOrder -ExcludeDontShow
    }

    #Handle v1.0
    $v1ModuleDocs = ".\src\$RequiredModule\$RequiredModule\docs\v1.0\"
    if (Test-Path $v1ModuleDocs) {
        Select-MgProfile v1.0
        Update-MarkdownHelpModule -Path $v1ModuleDocs -RefreshModulePage -AlphabeticParamsOrder -ExcludeDontShow
    }

    #Add Updated docs to current commit
    git add $betaModuleDocs
    git add $v1ModuleDocs        
}

Write-Host -ForegroundColor Green "-------------Done-------------"