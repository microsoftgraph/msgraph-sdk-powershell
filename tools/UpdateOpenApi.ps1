# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
Param(
    [string] $ModuleMappingConfigPath = (Join-Path $PSScriptRoot "..\config\ModulesMapping.jsonc"),
    [string] $OpenApiDocOutput = (Join-Path $PSScriptRoot "..\openApiDocs"),
    [switch] $BetaGraphVersion
)

$ErrorActionPreference = 'Stop'
$LASTEXITCODE = $null
if ($PSEdition -ne 'Core') {
    Write-Error 'This script requires PowerShell Core to execute. [Note] Generated cmdlets will work in both PowerShell Core or Windows PowerShell.'
}
# Install Powershell-yaml
Install-Module powershell-yaml -Force

$GraphVersion = "v1.0"
if ($BetaGraphVersion) {
    $GraphVersion = "beta"
}

$OpenApiDocOutput = Join-Path $OpenApiDocOutput $GraphVersion

# PS Scripts
$DownloadOpenApiDocPS1 = Join-Path $PSScriptRoot ".\DownloadOpenApiDoc.ps1" -Resolve

if (-not (Test-Path $ModuleMappingConfigPath)) {
    Write-Error "Module mapping file not be found: $ModuleMappingConfigPath."
}

[HashTable] $ModuleMapping = Get-Content $ModuleMappingConfigPath | ConvertFrom-Json -AsHashTable
$ModuleMapping.Keys | ForEach-Object -Begin { $RequestCount = 0 } -End { Write-Host -ForeGroundColor Green "Requests: $RequestCount" } -Process {
    $ModuleName = $_
    try {
        # Download OpenAPI document for module.
        & $DownloadOpenApiDocPS1 -ModuleName $ModuleName -ModuleRegex $ModuleMapping[$ModuleName] -OpenApiDocOutput $OpenApiDocOutput -GraphVersion $GraphVersion -RequestCount $RequestCount
    }
    catch {
        Write-Error $_.Exception
    }
    $RequestCount = $RequestCount + 1
}


Write-Host -ForegroundColor Green "-------------Done-------------"