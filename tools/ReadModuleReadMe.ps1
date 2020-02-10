# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

param(
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string] $ReadMePath,
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string] $FieldToRead
) 
$ErrorActionPreference = "Stop"
# Default module version
$FieldValue = $null
$ReadMeContent = Get-Content $ReadMePath -Delimiter "### Versioning"
if ($ReadMeContent.Length -eq 2) {
    $VersioningSection = $ReadMeContent[1].Replace("``", "").Replace("yaml", "") | ConvertFrom-Yaml

    if ($null -ne $VersioningSection[$FieldToRead]){
        $FieldValue = $VersioningSection[$FieldToRead]
    }
}
return $FieldValue
