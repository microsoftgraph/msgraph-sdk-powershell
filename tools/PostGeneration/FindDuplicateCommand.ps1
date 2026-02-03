# ------------------------------------------------------------------------------
#  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
# ------------------------------------------------------------------------------

# Set-StrictMode -Version 2

[CmdletBinding()]
param (
    [Parameter()]
    [string]
    $SourcePath = (Join-Path $PSScriptRoot "..\..\src\")
)

if (!(Test-Path $SourcePath)) {
    Write-Error "SourcePath is not valid or does not exist. Please ensure that $SourcePath exists then try again."
}

$psd1s = Get-ChildItem -Path $SourcePath -Filter "Microsoft.Graph.*.psd1" -Recurse | Where-Object { $_.BaseName -ne "Microsoft.Graph.Authentication" }
$allModules = Import-PowerShellDataFile $psd1s.FullName
$unique = $allModules.FunctionsToExport | Select-Object -unique
$duplicates = Compare-object -ReferenceObject $unique -DifferenceObject $allModules.FunctionsToExport

if ($duplicates.Count -gt 0) {
    Write-Host "The following functions are duplicated in the psd1 files:"
    $duplicates.InputObject | ForEach-Object {
        $duplicateCommand = $_
        Write-Host "$duplicateCommand is duplicated in:"
        Write-Host ($allModules | Where-Object { $_.FunctionsToExport -contains $duplicateCommand }).RootModule
        Write-Host "********************************"
    }
    Write-Error "Please ensure that the functions are unique and try again."
}