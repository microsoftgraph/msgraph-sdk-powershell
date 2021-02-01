# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
Param(
    [string] $VersionNumber,
    [string] $ReleaseNotes = "See https://aka.ms/GraphPowerShell-Release."
)

$ModuleMetadataPath = Join-Path $PSScriptRoot "..\config\ModuleMetadata.json" -Resolve
$ModuleContent = (Get-Content $ModuleMetadataPath -Raw | ConvertFrom-Json)

# Update meta-module
$ModuleContent.Version = $VersionNumber
$ModuleContent.ReleaseNotes = $ReleaseNotes

Set-Content -Value (ConvertTo-Json $ModuleContent) -Path $ModuleMetadataPath
