# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
[CmdletBinding()]
Param(
  [string] $RepositoryName = "PSGallery",
  [string] $RepositoryApiKey,
  [string] $ArtifactsLocation = (Join-Path $PSScriptRoot "..\artifacts\"),
  [switch] $Build,
  [switch] $Pack,
  [switch] $Publish,
  [switch] $EnableSigning,
  [switch] $BuildWhenEqual,
  [switch] $Test,
  [switch] $Run
)
$ErrorActionPreference = 'Stop'
$LASTEXITCODE = 0

if ($PSEdition -ne 'Core') {
  Write-Error 'This script requires PowerShell Core to execute. [Note] Generated cmdlets will work in both PowerShell Core or Windows PowerShell.'
}

$ModulePrefix = "Microsoft.Graph"
$ModuleName = "Authentication"
$ModuleFullName = "$ModulePrefix.$ModuleName"
$BuildModulePS1 = Join-Path $PSScriptRoot ".\BuildModule.ps1" -Resolve
$PackModulePS1 = Join-Path $PSScriptRoot ".\PackModule.ps1" -Resolve
$PublishModulePS1 = Join-Path $PSScriptRoot ".\PublishModule.ps1" -Resolve
$AuthSrcPath = Join-Path $PSScriptRoot "..\src\Authentication\"
$AuthModulePath = Join-Path $AuthSrcPath "Authentication" -Resolve
$TestModulePS1 = Join-Path $PSScriptRoot ".\TestModule.ps1" -Resolve
$RunModulePS1 = Join-Path $AuthModulePath ".\run-module.ps1" -Resolve
$ModuleMetadataPath = Join-Path $PSScriptRoot "..\config\ModuleMetadata.json"
[HashTable] $ModuleMetadata = Get-Content $ModuleMetadataPath | ConvertFrom-Json -AsHashTable

if ($null -eq $ModuleMetadata.versions.authentication.version) {
  Write-Error "Version number is not set for $ModuleFullName module. Please set authentication version in $ModuleMetadataPath."
}

# Build and pack generated module.
if ($Build -or $Run) {
  & $BuildModulePS1 -ModuleFullName $ModuleFullName -ModuleSrc $AuthModulePath -EnableSigning:$EnableSigning -Version $ModuleMetadata.versions.authentication.version -Prerelease $ModuleMetadata.versions.authentication.prerelease -ModuleMetadata $ModuleMetadata.Clone()
}

if ($Test) {
  & $TestModulePS1 -ModulePath (Join-Path $AuthModulePath "artifacts" ) -ModuleName "$ModuleFullName" -ModuleTestsPath (Join-Path $AuthModulePath "test")
}

if ($Pack -or $Run) {
  & $PackModulePS1 -ModuleFullName $ModuleFullName -ModuleSrc $AuthModulePath -Module $ModuleName -ArtifactsLocation $ArtifactsLocation
}

if ($Run) {
  & $RunModulePS1 -ModuleName "$ModuleFullName" -ArtifactLocation $ArtifactsLocation
}

if ($Publish) {
  & $PublishModulePS1 -Modules $ModuleName -ModulePrefix $ModulePrefix -ArtifactsLocation $ArtifactsLocation -RepositoryName $RepositoryName -RepositoryApiKey $RepositoryApiKey
}
