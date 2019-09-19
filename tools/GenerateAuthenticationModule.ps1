# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
Param(
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string] $RepositoryName,
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string] $RepositoryApiKey,
    [string] $ModuleVersion = "0.1.0",
    [switch] $DoNotPublish
)
$ErrorActionPreference = 'Stop'

if($PSEdition -ne 'Core') {
  Write-Error 'This script requires PowerShell Core to execute. [Note] Generated cmdlets will work in both PowerShell Core or Windows PowerShell.'
}

$BuildAndPackBinaryModulePS1 = Join-Path $PSScriptRoot ".\BuildAndPackBinaryModule.ps1" -Resolve
$PublishModulePS1 = Join-Path $PSScriptRoot ".\PublishModule.ps1" -Resolve
$ArtifactsLocation = Join-Path $PSScriptRoot "..\artifacts\"

# Build, pack and publish Graph.Authentication module to specified feed..
# This can be built independent of AutoRest generated modules. 
& $BuildAndPackBinaryModulePS1 -Module "Authentication" -ArtifactsLocation $ArtifactsLocation -ModuleVersion $ModuleVersion

if (-not $DoNotPublish) {
    & $PublishModulePS1 -Module "Authentication" -ArtifactsLocation $ArtifactsLocation -RepositoryName $RepositoryName -RepositoryApiKey $RepositoryApiKey
}