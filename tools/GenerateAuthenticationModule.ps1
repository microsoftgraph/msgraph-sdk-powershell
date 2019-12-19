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
$LastExitCode = 0
if($PSEdition -ne 'Core') {
  Write-Error 'This script requires PowerShell Core to execute. [Note] Generated cmdlets will work in both PowerShell Core or Windows PowerShell.'
}

$ModulePrefix = "Microsoft.Graph.Beta"
$ArtifactsLocation = Join-Path $PSScriptRoot "..\artifacts\"

.\tools\BuildAndPackBinaryModule.ps1 -Module "Authentication" -ModulePrefix $ModulePrefix -ArtifactsLocation $ArtifactsLocation -ModuleVersion $ModuleVersion -ModulePreviewNumber $ModulePreviewNumber

if ($Publish) {
    .\tools\PublishModule.ps1 -Modules "Authentication" -ModulePrefix $ModulePrefix -ArtifactsLocation $ArtifactsLocation -RepositoryName $RepositoryName -RepositoryApiKey $RepositoryApiKey
}