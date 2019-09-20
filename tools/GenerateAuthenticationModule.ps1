# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
Param(
    [string] $ModuleVersion = "0.1.0",
    [string] $RepositoryName,
    [string] $RepositoryApiKey,
    [switch] $Publish
)
$ErrorActionPreference = 'Stop'
if($PSEdition -ne 'Core') {
  Write-Error 'This script requires PowerShell Core to execute. [Note] Generated cmdlets will work in both PowerShell Core or Windows PowerShell.'
}
$LastExitCode = 0
$BuildAndPackBinaryModulePS1 = Join-Path $PSScriptRoot ".\BuildAndPackBinaryModule.ps1" -Resolve
$PublishModulePS1 = Join-Path $PSScriptRoot ".\PublishModule.ps1" -Resolve
$ArtifactsLocation = Join-Path $PSScriptRoot "..\artifacts\"

& $BuildAndPackBinaryModulePS1 -Module "Authentication" -ArtifactsLocation $ArtifactsLocation -ModuleVersion $ModuleVersion

if ($Publish) {
    & $PublishModulePS1 -Modules "Authentication" -ArtifactsLocation $ArtifactsLocation -RepositoryName $RepositoryName -RepositoryApiKey $RepositoryApiKey
}