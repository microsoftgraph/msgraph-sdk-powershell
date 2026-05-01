# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
[CmdletBinding()]
param(
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string] $ReadMePath,
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string] $FieldToRead
) 
$ErrorActionPreference = "Stop"
. "$PSScriptRoot\utilities\utils.ps1"

$FieldValue = $null
# Read readme.md.
$ReadMeContent = Get-Content $ReadMePath -Delimiter "### Versioning"
if ($ReadMeContent.Length -eq 2) {
    # Convert versioning section to yaml.
    $VersioningSection = $ReadMeContent[1].Replace("``", "").Replace("yaml", "") | ConvertFrom-SimpleYaml
    $FieldValue = $VersioningSection[$FieldToRead]
}
return $FieldValue
