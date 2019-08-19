# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
<#
.DESCRIPTION
Builds and packs generated module into nuget packages for distribution. The generated packages are moved to '{repo}\bin' by default for easy access.

.PARAMETER Module
The name of the module to build and pack.

.PARAMETER OutputFolder
The output folder to move the generated nuget packages to. This defaults to '{repo}\artifacts'.
#>
Param(
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string] $Module,
    [ValidateNotNullOrEmpty()]
    [string] $FeedUrl,
    [ValidateNotNullOrEmpty()]
    [string] $FeedApiKey,
    [string] $OutputFolder,
    [string[]] $RequiredModules,
    [Switch] $SkipBuild
)

$ModuleDir = "./src/$Module/$Module"
$BuildModulePS1 = Join-Path $moduleDir "/build-module.ps1"
$PackModulePS1 = Join-Path $moduleDir "/pack-module.ps1"

if([string]::IsNullOrEmpty($OutputFolder)) {
    $OutputFolder = "./artifacts/"
}

if(-not $SkipBuild){
    if (-not (Test-Path -Path $BuildModulePS1)){
        Write-Error "Build script file '$BuildModulePS1' not found for $Module module."
        return
    }

    # Build module
    & $BuildModulePS1 -Test -Docs -Release
    if($LastExitCode -ne 0) {
        # Build failed, don't pack the module.
        Write-Error "Failed to build $Module."
        return
    }
}

if($RequiredModules.Count -gt 0) {
    # Add required modules.
    try{
        Update-ModuleManifest -Path (Join-Path $ModuleDir "Graph.$Module.psd1") -FunctionsToExport "*" -RequiredModules $RequiredModules
    } catch {
        Write-Error $_.Exception
        return
    }
}

# Pack module
& $PackModulePS1

if($LastExitCode -ne 0) {
    # Pack failed, don't attempt to move nuget package.
    Write-Error "Failed to pack $Module."
    return
}

# Get generated .nupkg
$NugetPackage = (Get-ChildItem (Join-Path $ModuleDir "./bin") | Where-Object Name -Match ".nupkg").FullName

if(-not (Test-Path $OutputFolder)) {
    # Create artifacts folder.
    New-Item -Path $OutputFolder -Type Directory
}

# Copy package to feed.
Write-Host -ForegroundColor Green "nuget push $NugetPackage -Source $FeedUrl -apikey $FeedApiKey"
nuget push $NugetPackage -Source $FeedUrl -apikey $FeedApiKey

# Copy package to artifacts folder.
Move-Item -Path $NugetPackage -Destination $OutputFolder -Force
Write-Host -ForegroundColor Green "Moved '$NugetPackage' to '$OutputFolder'."