								 
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
[CmdletBinding()]
Param(
    $ModulesToGenerate = @(),
    [string] $ModuleMappingConfigPath = (Join-Path $PSScriptRoot "..\config\ModulesMapping.jsonc")
)
# Install PlatyPS
if (!(Get-Module -Name PlatyPS -ListAvailable)) {
    Install-Module PlatyPS -Force
}
Import-Module PlatyPS -Force -Scope Global

# Errors in PlatyPS validation.
$ErrorActionPreference = 'Continue'
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
Import-Module (Join-Path $PSScriptRoot "..\src\Authentication\Authentication\artifacts\Microsoft.Graph.Authentication.psd1") -Force -Scope Global

$ModulesToGenerate | ForEach-Object {
    $ModuleName = $_
    $modulePath = Join-Path $PSScriptRoot "..\src\$ModuleName\$ModuleName\$ModulePrefix.$ModuleName.psd1"
    Write-Host "Current Module Path $modulePath"
    #Handle Beta docs and examples
    $betaModuleDocs = Join-Path $PSScriptRoot "..\src\$ModuleName\$ModuleName\docs\v1.0-beta"
    $betaModuleExamples = Join-Path $PSScriptRoot "..\src\$ModuleName\$ModuleName\examples\v1.0-beta"
    Write-Host $betaModuleDocs
    if (Test-Path $betaModuleDocs) {
        git add $betaModuleDocs
        git add $betaModuleExamples
    }
    else {
        Write-Warning "Beta Docs for $ModuleName not Found"
    }

    #Handle v1.0 docs and examples
    $v1ModuleDocs = Join-Path $PSScriptRoot "..\src\$ModuleName\$ModuleName\docs\v1.0"
    $v1ModuleExamples = Join-Path $PSScriptRoot "..\src\$ModuleName\$ModuleName\examples\v1.0"
    Write-Host $v1ModuleDocs
    if (Test-Path $v1ModuleDocs) {
        Write-Host $v1ModuleDocs
        git add $v1ModuleDocs
        git add $v1ModuleExamples
    }
    else {
        Write-Warning "v1.0 Docs for $ModuleName not Found"
    }
    git status
    git commit -m "Docs Generation for $ModuleName [run ci]"
}

Write-Host -ForegroundColor Green "-------------Done-------------"