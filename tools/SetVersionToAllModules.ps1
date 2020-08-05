# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
Param(
    [string] $VersionNumber,
    [string] $ReleaseNotes = "See https://aka.ms/GraphPowerShell-Release."
)
$WriteToModuleReadMe = Join-Path $PSScriptRoot ".\WriteToModuleReadMe.ps1" -Resolve
$SrcPath =  Join-Path $PSScriptRoot "..\src\*\*"
# Get all module readme.md
Get-Item "$SrcPath\readme.md" | ForEach-Object {
    # Set readme values.
    & $WriteToModuleReadMe -ReadMePath $_.FullName -FieldName "module-version" -NewFieldValue $VersionNumber
    & $WriteToModuleReadMe -ReadMePath $_.FullName -FieldName "release-notes" -NewFieldValue $ReleaseNotes
}
