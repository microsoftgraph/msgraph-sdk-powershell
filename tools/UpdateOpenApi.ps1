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
$Stopwatch = [system.diagnostics.stopwatch]::StartNew()
[HashTable] $ModuleMapping = Get-Content $ModuleMappingConfigPath | ConvertFrom-Json -AsHashTable
# $ModuleMapping.Keys | ForEach-Object -Begin { $RequestCount = 0 } -End { Write-Host -ForeGroundColor Green "Requests: $RequestCount" } -Process {
#     $ModuleName = $_
#     $ForceRefresh = $false
#     # Check whether ForceRefresh is required, Only required for the First Request.
#     if ($RequestCount -eq 0) {
#         $ForceRefresh = $true
#     }

#     try {
#         # Download OpenAPI document for module.
#         & $DownloadOpenApiDocPS1 -ModuleName $ModuleName -ModuleRegex $ModuleMapping[$ModuleName] -OpenApiDocOutput $OpenApiDocOutput -GraphVersion $GraphVersion -ForceRefresh:$ForceRefresh -RequestCount $RequestCount
#     }
#     catch {
#         Write-Error $_.Exception
#     }
#     $RequestCount++
# }
$stopwatch.Stop()
Write-Host -ForegroundColor Green "Downloaded $GraphVersion OpenAPI files in '$($Stopwatch.Elapsed.TotalMinutes)` minutes."

# Tweak OperationIds to address known AutoREST.PowerShell limitations.
$Stopwatch.Restart()
Get-ChildItem -Path $OpenApiDocOutput | ForEach-Object {
    $FilePath = $_.FullName
    $FileContent = Get-Content -Path $FilePath | ConvertFrom-Yaml -Ordered
    $Modified = $false
    # Modify '/$ref' operationId (*ByRef) to byPass -> https://github.com/Azure/autorest.powershell/issues/795.
    $FileContent.paths.Keys -like "*`$ref" | ForEach-Object {
        $Modified = $true
        $Path = $_
        $ActionPattern = [Regex]::new("(_[A-Z][a-z]+)", "Compiled")
        foreach ($Method in $FileContent.paths[$Path].GetEnumerator()) {
            $OperationId = $FileContent.paths[$Path][$Method.Name].operationId.Replace("ByRef", "")
            $Match = $ActionPattern.Match($OperationId)
            if ($Match -ne $null -and $Match.Success) {
                $FileContent.paths[$Path][$Method.Name].operationId = ($OperationId -replace $Match.Value, "$($Match.Value)GraphRef")
            }
        }
        if ($Modified) { $FileContent | ConvertTo-Yaml -OutFile $FilePath -Force }
    }
}
$stopwatch.Stop()
Write-Host -ForegroundColor Green "Tweaked $GraphVersion OpenAPI files in '$($Stopwatch.Elapsed.TotalMinutes)` minutes."
Write-Host -ForegroundColor Green "-------------Done-------------"