# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
Param(
    [string] $RepositoryName,
    [string] $RepositoryApiKey,
    [string] $ModuleVersion = "0.1.0",
    [string] $ArtifactsLocation = (Join-Path $PSScriptRoot "..\artifacts\"),
    [int] $ModulePreviewNumber = -1,
    [switch] $Build,
    [switch] $Pack,
    [switch] $Publish,
    [switch] $EnableSigning
)
$ErrorActionPreference = 'Stop'
$LastExitCode = 0
if($PSEdition -ne 'Core') {
  Write-Error 'This script requires PowerShell Core to execute. [Note] Generated cmdlets will work in both PowerShell Core or Windows PowerShell.'
}

$ModulePrefix = "Microsoft.Graph"
$ModuleName = "Authentication"
$BuildModulePS1 = Join-Path $PSScriptRoot ".\BuildModule.ps1" -Resolve
$PackModulePS1 = Join-Path $PSScriptRoot ".\PackModule.ps1" -Resolve
$PublishModulePS1 = Join-Path $PSScriptRoot ".\PublishModule.ps1" -Resolve

# Build and pack generated module.
if ($Build) {
  if($EnableSigning){
    & $BuildModulePS1 -Module $ModuleName -ModulePrefix $ModulePrefix -ModuleVersion $ModuleVersion -ModulePreviewNumber $ModulePreviewNumber -EnableSigning
  } else {
    & $BuildModulePS1 -Module $ModuleName -ModulePrefix $ModulePrefix -ModuleVersion $ModuleVersion -ModulePreviewNumber $ModulePreviewNumber
  }
}

if ($Pack) {
  & $PackModulePS1 -Module $ModuleName -ArtifactsLocation $ArtifactsLocation
}

if ($Publish) {
  & $PublishModulePS1 -Modules $ModuleName -ModulePrefix $ModulePrefix -ArtifactsLocation $ArtifactsLocation -RepositoryName $RepositoryName -RepositoryApiKey $RepositoryApiKey
}