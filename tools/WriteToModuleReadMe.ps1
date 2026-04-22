# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
[CmdletBinding()]
param(
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string] $ReadMePath,
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string] $FieldName,
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string] $NewFieldValue
) 
$ErrorActionPreference = "Stop"

function ConvertFrom-SimpleYaml {
    param([string]$Yaml)
    $result = @{}
    $Yaml -split "`n" | ForEach-Object {
        if ($_.Trim() -match '^([^:]+):\s*(.*)$') {
            $result[$Matches[1].Trim()] = $Matches[2].Trim()
        }
    }
    return $result
}

# Read readme.md.
$ReadMeContent = Get-Content $ReadMePath -Delimiter "### Versioning"
if ($ReadMeContent.Length -eq 2) {
    # Convert versioning section to yaml.
    $UpdatedVersionSection = "### Versioning" + $ReadMeContent[1]
    $VersioningSection = $ReadMeContent[1].Replace("``", "").Replace("yaml", "") | ConvertFrom-SimpleYaml
    $FieldValue = $VersioningSection[$FieldName]
    $RegexPattern = "$FieldName`:\s*$FieldValue"
    $UpdatedVersionSection = $UpdatedVersionSection -replace $RegexPattern, "$FieldName`: $NewFieldValue"
    
    $ReadMeContent[0] = $ReadMeContent[0].Trim()
    $ReadMeContent[1] = $UpdatedVersionSection.Trim()
    Set-Content -Path $ReadMePath -Value $ReadMeContent
}
