# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
[CmdletBinding()]
param([string] $ModulePath, [string] $ModuleName, [string] $ModuleTestsPath, [switch]$Isolated)
$ErrorActionPreference = 'Stop'

# Install Pester
# CFSClean: install tooling modules from the private feed (PowerShell Gallery upstream).
. (Join-Path $PSScriptRoot 'Get-CfsFeedCredential.ps1')
$__cfsCred = Get-CfsFeedCredential
if ($null -ne $__cfsCred) { $PSDefaultParameterValues['Install-Module:Credential'] = $__cfsCred }
if (!(Get-Module -Name Pester -ListAvailable)) {
    Install-Module -Name Pester -Repository (Get-CfsFeedName) -Force -SkipPublisherCheck
}

if(-not $Isolated) {
  Write-Debug 'Creating isolated process...'
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

# Replace AutoREST loadEnv.ps1 with our local script.
Copy-Item -Path $LocalLoadEnvPS1 -Destination $ModuleTestsPath

$PesterConfiguration = [PesterConfiguration]::Default
$PesterConfiguration.Run.Path =  $ModuleTestsPath
$PesterConfiguration.Run.PassThru =  $true
$PesterConfiguration.CodeCoverage.Enabled  =  $true
$PesterConfiguration.TestResult.Enabled = $true
$PesterConfiguration.TestResult.OutputPath = (Join-Path $ModuleTestsPath "$moduleName-TestResults.xml")

$TestResults = Invoke-Pester -Configuration $PesterConfiguration
If (($TestResults.FailedCount + $TestResults.FailedBlocksCount + $TestResults.FailedContainersCount) -gt 0) { Write-Error "Pester run failed: $($TestResults.FailedCount) failed test(s), $($TestResults.FailedBlocksCount) failed block(s), $($TestResults.FailedContainersCount) failed container(s), of $($TestResults.TotalCount) total tests" }
