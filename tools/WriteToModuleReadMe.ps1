# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

param(
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string] $ReadMePath,
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string] $FieldName,
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string] $NewFieldValue
) 
$ErrorActionPreference = "Stop"
# Read readme.md.
$ReadMeContent = Get-Content $ReadMePath -Delimiter "### Versioning"
if ($ReadMeContent.Length -eq 2) {
    # Convert versioning section to yaml.
    $UpdatedVersionSection = "### Versioning" + $ReadMeContent[1]
    $VersioningSection = $ReadMeContent[1].Replace("``", "").Replace("yaml", "") | ConvertFrom-Yaml
    $FieldValue = $VersioningSection[$FieldName]
    $RegexPattern = "$FieldName`:\s*$FieldValue"
    $UpdatedVersionSection = $UpdatedVersionSection -replace $RegexPattern, "$FieldName`: $NewFieldValue"
    
    $ReadMeContent[0] = $ReadMeContent[0].Trim()
    $ReadMeContent[1] = $UpdatedVersionSection.Trim()
    Set-Content -Path $ReadMePath -Value $ReadMeContent
}
