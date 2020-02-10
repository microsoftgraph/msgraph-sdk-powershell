# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

param(
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string] $ReadMePath,
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string] $FieldToRead
) 
$ErrorActionPreference = "Stop"
$FieldValue = $null
# Read readme.md.
$ReadMeContent = Get-Content $ReadMePath -Delimiter "### Versioning"
if ($ReadMeContent.Length -eq 2) {
    # Convert versioning section to yaml.
    $VersioningSection = $ReadMeContent[1].Replace("``", "").Replace("yaml", "") | ConvertFrom-Yaml
    $FieldValue = $VersioningSection[$FieldToRead]
}
return $FieldValue
