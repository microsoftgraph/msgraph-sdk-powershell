# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

param(
    [Parameter(Mandatory = $true)][ValidateNotNullOrEmpty()][string] $ReadMePath
) 
$ErrorActionPreference = "Stop"
# Default module version
$ModuleVersion = $null
$ReadMeContent = Get-Content $ReadMePath -Delimiter "### Versioning"
if ($ReadMeContent.Length -eq 2) {
    $VersioningSection = $ReadMeContent[1].Replace(" ", "")
    
    if ($VersioningSection -match "module-version:\d*.\d*.\d*") {
        $ModuleVersionSection = $Matches[0].Split(":")
        $ModuleVersion = $ModuleVersionSection[1]
    }
}
return $ModuleVersion
