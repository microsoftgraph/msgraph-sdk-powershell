# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
param([string] $ModulePath, [string] $ModuleName, [switch]$Isolated)
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

Import-Module -Name Pester
Import-Module -Name $modulePsd1.FullName

$testFolder = Join-Path $ModulePath 'test'
$PesterConfiguration = [PesterConfiguration]::Default
$PesterConfiguration.Run.Path =  $testFolder
$PesterConfiguration.Run.Exit =  $true
$PesterConfiguration.CodeCoverage.Enabled  =  $true
$PesterConfiguration.TestResult.Enabled = $true
$PesterConfiguration.TestResult.OutputPath = (Join-Path $testFolder "$moduleName-TestResults.xml")
  
try {
    Invoke-Pester -Configuration $PesterConfiguration
}
catch {
    throw $_
}

Write-Host -ForegroundColor Green '-------------Done-------------'