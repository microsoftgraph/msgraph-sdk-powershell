# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
<#
.DESCRIPTION
Builds and packs generated module into nuget packages for distribution. The generated packages are moved to '{repo}\bin' by default for easy access.

.PARAMETER Module
The name of the module to build and pack.

.PARAMETER OutputFolder
The output folder to move the generated nuget packages to. This defaults to '{repo}\bin'.
#>
Param(
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string] $Module,
    [string] $OutputFolder
)

$ModuleDir = "./src/$Module/$Module"
$BuildModulePS1 = Join-Path $moduleDir "/build-module.ps1"

if([string]::IsNullOrEmpty($OutputFolder)) {
    $OutputFolder = "./bin/"
}

if (-not (Test-Path -Path $BuildModulePS1)){
    Write-Host -ForegroundColor Red "Build script file '$BuildModulePS1' not found for $Module module."
}

try {
    # Build and pack module
    . $BuildModulePS1 -Pack -Test -Docs -Release
    if($LastExitCode -ne 0) {
        # Build and pack failed. Don't attempt to move nuget package.
        return
    }

    # Get generated .nupkg
    $NugetPackage = (Get-ChildItem (Join-Path $ModuleDir "./bin") | Where Name -Match ".nupkg").FullName

    if(-not (Test-Path $OutputFolder)) {
        # Create bin folder.
        New-Item -Path $OutputFolder -Type Directory
    }

    # Copy package to root bin.
    Move-Item -Path $NugetPackage -Destination $OutputFolder -Force
    Write-Host -ForegroundColor Green "Moved '$NugetPackage' to '$OutputFolder'."
}
catch{
    Write-Error $_.Exception
}