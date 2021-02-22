# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
Param(
    [Parameter(Mandatory = $true)] [ValidateNotNullOrEmpty()][string] $Module,
    [Parameter(Mandatory = $true)] [ValidateNotNullOrEmpty()][string] $ArtifactsLocation,
    [string] $ModulePrefix="Microsoft.Graph",
    [switch] $ExcludeMarkdownDocsFromNugetPackage
)
$NuspecHelperPS1 = Join-Path $PSScriptRoot "./NuspecHelper.ps1"
# Import scripts
. $NuspecHelperPS1

$LASTEXITCODE = $null
$ErrorActionPreference = "Stop"
if($PSEdition -ne "Core") {
  Write-Error "This script requires PowerShell Core to execute. [Note] Generated cmdlets will work in both PowerShell Core or Windows PowerShell."
}

$ModuleProjLocation = Join-Path $PSScriptRoot "../src/$Module/$Module"
$ModuleNuspec = Join-Path $ModuleProjLocation "$ModulePrefix.$Module.nuspec"
$PackModulePS1 = Join-Path $ModuleProjLocation "/pack-module.ps1"

if (Test-Path $PackModulePS1) {
    #Remove MarkDown Docs From Nuget Package
    if ($ExcludeMarkdownDocsFromNugetPackage) {
        Write-Information "Removing MarkDownDocs from Nuget Package..."
        Remove-MarkdownDocsElement -NuSpecFilePath $ModuleNuspec
    }
    # Pack module
    & $PackModulePS1
    if($LASTEXITCODE) {
        Write-Error "Failed to pack '$Module' module."
    }

    # Get generated .nupkg
    $NuGetPackage = (Get-ChildItem (Join-Path $ModuleProjLocation "./bin") | Where-Object Name -Match ".nupkg").FullName

    $ModuleArtifactLocation = "$ArtifactsLocation\$Module"
    if(-not (Test-Path $ModuleArtifactLocation)) {
        New-Item -Path $ModuleArtifactLocation -Type Directory
    } else {
        Remove-Item -Path "$ModuleArtifactLocation\*" -Recurse -Force
    }

    # Copy package to artifacts folder.
    Write-Host -ForegroundColor Green "Copying '$NuGetPackage' to $ModuleArtifactLocation..."
    Copy-Item -Path $NuGetPackage -Destination $ModuleArtifactLocation -Force

    Write-Host -ForegroundColor Green "-------------Done-------------"
}