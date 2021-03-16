# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
param([string] $ModulePath, [string] $ModuleName, [string] $ModuleTestsPath, [switch]$Isolated)
$ErrorActionPreference = 'Stop'

# Install Pester
if (!(Get-Module -Name Pester -ListAvailable)) {
    Install-Module -Name Pester -Force -SkipPublisherCheck
}

if(-not $Isolated) {
  Write-Host -ForegroundColor Green 'Creating isolated process...'
  $pwsh = [System.Diagnostics.Process]::GetCurrentProcess().Path
  & "$pwsh" -NonInteractive -NoLogo -NoProfile -File $MyInvocation.MyCommand.Path @PSBoundParameters -Isolated
  return
}

$modulePsd1 = Get-Item -Path (Join-Path $ModulePath "./$ModuleName.psd1")
$LocalLoadEnvPS1 = Join-Path $PSScriptRoot 'Tests/loadEnv.ps1'
$AuthModulePSd1 = Join-Path $PSScriptRoot "../src/Authentication/Authentication/artifacts/Microsoft.Graph.Authentication.psd1"

# Import required modules.
Import-Module -Name Pester
Import-Module $AuthModulePSd1
Import-Module -Name $modulePsd1.FullName

# Replace AutoREST loadEnv.ps1 with our local scipt.
Copy-Item -Path $LocalLoadEnvPS1 -Destination $ModuleTestsPath

$PesterConfiguration = [PesterConfiguration]::Default
$PesterConfiguration.Run.Path =  $ModuleTestsPath
$PesterConfiguration.Run.Exit =  $true
$PesterConfiguration.CodeCoverage.Enabled  =  $true
$PesterConfiguration.TestResult.Enabled = $true
$PesterConfiguration.TestResult.OutputPath = (Join-Path $ModuleTestsPath "$moduleName-TestResults.xml")
  
try {
    Invoke-Pester -Configuration $PesterConfiguration
}
catch {
    throw $_
}

Write-Host -ForegroundColor Green '-------------Done-------------'