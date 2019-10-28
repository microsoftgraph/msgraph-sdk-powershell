# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
Param(
    [string] $RepositoryName,
    [string] $RepositoryApiKey,
    [string] $ModuleVersion = "0.1.0",
    [int] $ModulePreviewNumber = -1,
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

& $BuildAndPackBinaryModulePS1 -Module "Authentication" -ModuleNamespace "Microsoft.Graph" -ArtifactsLocation $ArtifactsLocation -ModuleVersion $ModuleVersion -ModulePreviewNumber $ModulePreviewNumber

if ($Publish) {
    & $PublishModulePS1 -Modules "Authentication" -ModuleNamespace "Microsoft.Graph" -ArtifactsLocation $ArtifactsLocation -RepositoryName $RepositoryName -RepositoryApiKey $RepositoryApiKey
}