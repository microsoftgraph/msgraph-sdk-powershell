# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
[CmdletBinding()]
Param(
    [string] $ModuleMappingConfigPath = (Join-Path $PSScriptRoot "..\config\ModulesMapping.jsonc"),
    [string] $OpenApiDocOutput = (Join-Path $PSScriptRoot "..\openApiDocs"),
    [switch] $BetaGraphVersion,
    [switch] $SkipForceRefresh
)

$ErrorActionPreference = 'Stop'
$LASTEXITCODE = $null
if ($PSEdition -ne 'Core') {
    Write-Error 'This script requires PowerShell Core to execute. [Note] Generated cmdlets will work in both PowerShell Core or Windows PowerShell.'
}

if (!(Get-Module powershell-yaml -ListAvailable)) {
    # Install Powershell-yaml
    Install-Module powershell-yaml -Force
}

$GraphVersion = "v1.0"
if ($BetaGraphVersion) {
    $GraphVersion = "beta"
}

$OpenApiDocOutput = Join-Path $OpenApiDocOutput $GraphVersion

# Load PS Scripts
$DownloadOpenApiDocPS1 = Join-Path $PSScriptRoot ".\DownloadOpenApiDoc.ps1" -Resolve
$TweakOpenApiPs1 = Join-Path $PSScriptRoot ".\TweakOpenApi.ps1" -Resolve

if (-not (Test-Path $ModuleMappingConfigPath)) {
    Write-Error "Module mapping file not be found: $ModuleMappingConfigPath."
}
$v1Excludes = @("WindowsUpdates")
$betaExcludes = @("DeviceManagement.Administration", "Mail", "ManagedTenants")
$Stopwatch = [system.diagnostics.stopwatch]::StartNew()
[HashTable] $ModuleMapping = Get-Content $ModuleMappingConfigPath | ConvertFrom-Json -AsHashTable
$ModuleMapping.Keys | ForEach-Object -Begin { $RequestCount = 0 } -End { Write-Debug "Requests: $RequestCount" } -Process {
    $ModuleName = $_
    if (-not ($v1Excludes -contains $ModuleName -and $GraphVersion -eq "v1.0")) {
        $ForceRefresh = $false
        # Check whether ForceRefresh is required, Only required for the First Request.
        if ($RequestCount -eq 0 -and $SkipForceRefresh -eq $false) {
            $ForceRefresh = $true
        }

        try {
            # Omit beta version of DeviceManagement.Administration module for further troubleshooting
            if (-not($betaExcludes -contains $ModuleName -and $GraphVersion -eq "beta")) {
                # Download OpenAPI document for module.
                & $DownloadOpenApiDocPS1 -ModuleName $ModuleName -ModuleRegex $ModuleMapping[$ModuleName] -OpenApiDocOutput $OpenApiDocOutput -GraphVersion $GraphVersion -ForceRefresh:$ForceRefresh -RequestCount $RequestCount -SingularizeOperationIds
            }
        }
        catch {
            Write-Error $_.Exception
        }
        $RequestCount++
    }
}
$stopwatch.Stop()
Write-Debug "Downloaded $GraphVersion OpenAPI files in '$($Stopwatch.Elapsed.TotalMinutes)` minutes."

# Tweak OperationIds to address known AutoREST.PowerShell limitations.
. $TweakOpenApiPs1 -OpenAPIFilesPath $OpenApiDocOutput
Write-Host -ForegroundColor Green "-------------Done-------------"
