# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
Param(
    [string] $VersionNumber,
    [string] $ReleaseNotes = "See https://aka.ms/GraphPowerShell-Release.",
    [string[]] $Modules = $null,
    [switch] $SetAuthModule
)
$WriteToModuleReadMe = Join-Path $PSScriptRoot ".\WriteToModuleReadMe.ps1" -Resolve

if ($SetAuthModule) {
    $authModulePSd1 = Join-Path $PSScriptRoot "..\src\Authentication\Authentication\Microsoft.Graph.Authentication.psd1"
    Update-ModuleManifest -Path $authModulePSd1 -ModuleVersion $VersionNumber
}

$ModulesReadme = @()
if ($null -ne $Modules) {
    $Modules | ForEach-Object {
        $ReadMePath = Join-Path $PSScriptRoot "..\src\$_\$_\readme.md"
        $ModulesReadme += Get-Item $ReadMePath
    }
} else {
    $ReadMePath = Join-Path $PSScriptRoot "..\src\*\*\readme.md"
    # Get all module readme.md
    $ModulesReadme = Get-Item $ReadMePath
}
$ModulesReadme | ForEach-Object {
    # Set readme values.
    & $WriteToModuleReadMe -ReadMePath $_.FullName -FieldName "module-version" -NewFieldValue $VersionNumber
    & $WriteToModuleReadMe -ReadMePath $_.FullName -FieldName "release-notes" -NewFieldValue $ReleaseNotes
}
