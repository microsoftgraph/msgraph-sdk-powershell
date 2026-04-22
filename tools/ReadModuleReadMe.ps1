# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
[CmdletBinding()]
param(
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string] $ReadMePath,
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string] $FieldToRead
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

$FieldValue = $null
# Read readme.md.
$ReadMeContent = Get-Content $ReadMePath -Delimiter "### Versioning"
if ($ReadMeContent.Length -eq 2) {
    # Convert versioning section to yaml.
    $VersioningSection = $ReadMeContent[1].Replace("``", "").Replace("yaml", "") | ConvertFrom-SimpleYaml
    $FieldValue = $VersioningSection[$FieldToRead]
}
return $FieldValue
