# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

[CmdletBinding()]
Param(
    [switch] $BumpV1Module,
    [switch] $BumpBetaModule,
    [switch] $BumpAuthModule,
    [string] $Repository = "PSGallery"
)
$ErrorActionPreference = "Stop"

. $PSScriptRoot\SetModuleVersion.ps1

# Calculate and bump v1.0 module version
if ($BumpV1Module.IsPresent) {
    $v1Module = Find-Module "Microsoft.Graph" -Repository $Repository -AllowPrerelease
    $newV1Version = Invoke-BumpMinorOrPreReleaseVersion -FullVersion $v1Module.Version
    Write-Debug "Bumping Microsoft.Graph to $newV1Version"
    Set-ModuleVersion -SetV1Module -Version $newV1Version[0] -Prerelease $newV1Version[1]
}

# Calculate and bump beta module version
if ($BumpBetaModule.IsPresent) {
    $betaModule = Find-Module "Microsoft.Graph.Beta" -Repository $Repository -AllowPrerelease
    $newBetaVersion = Invoke-BumpMinorOrPreReleaseVersion -FullVersion $betaModule.Version
    Write-Debug "Bumping Microsoft.Graph.Beta to $newBetaVersion"
    Set-ModuleVersion -SetBetaModule -Version $newBetaVersion[0] -Prerelease $newBetaVersion[1]
}

# Calculate and bump auth module version
if ($BumpAuthModule.IsPresent) {
    $authModule = Find-Module "Microsoft.Graph.Authentication" -Repository $Repository -AllowPrerelease
    $newAuthVersion = Invoke-BumpMinorOrPreReleaseVersion -FullVersion $authModule.Version
    Write-Debug "Bumping Microsoft.Graph.Authentication to $newAuthVersion"
    Set-ModuleVersion -SetAuthModule -Version $newAuthVersion[0] -Prerelease $newAuthVersion[1]
}
