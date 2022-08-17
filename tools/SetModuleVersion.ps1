# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
[CmdletBinding()]
Param(
    [string] $Version,
    [string] $Prerelease,
    [switch] $SetAuthModule,
    [switch] $SetBetaModule,
    [switch] $SetV1Module
)
$ModuleMetadataPath = Join-Path $PSScriptRoot "..\config\ModuleMetadata.json"
# $ModuleMetadata = [ordered]@{}
$ModuleMetadata = Get-Content $ModuleMetadataPath | ConvertFrom-Json

if ($SetAuthModule) {
    $ModuleMetadata.versions.authentication.version = $Version
    $ModuleMetadata.versions.authentication.prerelease = $Prerelease
}

if ($SetBetaModule) {
    $ModuleMetadata.versions.beta.version = $Version
    $ModuleMetadata.versions.beta.prerelease = $Prerelease
}

if ($SetV1Module) {
    $ModuleMetadata.versions.'v1.0'.version = $Version
    $ModuleMetadata.versions.'v1.0'.prerelease = $Prerelease
}

$ModuleMetadata | ConvertTo-Json -Depth 5 | Out-File $ModuleMetadataPath -Encoding utf8