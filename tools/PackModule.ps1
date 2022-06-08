# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
[CmdletBinding()]
Param(
    [Parameter(Mandatory = $true)] [ValidateNotNullOrEmpty()][string] $Module,
    [Parameter(Mandatory = $true)] [ValidateNotNullOrEmpty()][string] $ModuleFullName,
    [Parameter(Mandatory = $true)] [ValidateNotNullOrEmpty()][string] $ModuleSrc,
    [Parameter(Mandatory = $true)] [ValidateNotNullOrEmpty()][string] $ArtifactsLocation,
    [switch] $ExcludeMarkdownDocsFromNugetPackage
)
$NuspecHelperPS1 = Join-Path $PSScriptRoot "./NuspecHelper.ps1"
# Import scripts
. $NuspecHelperPS1

$LastExitCode = $null
$ErrorActionPreference = "Stop"
if ($PSEdition -ne "Core") {
    Write-Error "This script requires PowerShell Core to execute. [Note] Generated cmdlets will work in both PowerShell Core or Windows PowerShell."
}

$ModuleNuspec = Join-Path $ModuleSrc "$ModuleFullName.nuspec"
$PackModulePS1 = Join-Path $ModuleSrc "/pack-module.ps1"

if (Test-Path $PackModulePS1) {
    # Remove MarkDown Docs From Nuget Package
    if ($ExcludeMarkdownDocsFromNugetPackage) {
        Write-Information "Removing MarkDownDocs from Nuget Package..."
        Remove-MarkdownDocsElement -NuSpecFilePath $ModuleNuspec
    }
    # Pack module
    & $PackModulePS1
    if ($LastExitCode) {
        Write-Error "Failed to pack '$ModuleFullName' module."
    }

    # Get generated .nupkg
    $NuGetPackage = (Get-ChildItem (Join-Path $ModuleSrc "./bin") -Recurse | Where-Object Name -Match ".nupkg").FullName

    $ModuleArtifactLocation = Join-Path $ArtifactsLocation $Module
    if (-not (Test-Path $ModuleArtifactLocation)) {
        New-Item -Path $ModuleArtifactLocation -Type Directory
    }

    # Copy package to artifacts folder.
    Write-Host -ForegroundColor Green "Copying '$NuGetPackage' to $ModuleArtifactLocation..."
    Copy-Item -Path $NuGetPackage -Destination $ModuleArtifactLocation -Force
}