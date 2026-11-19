# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

<#
.SYNOPSIS
    Creates a JSON matrix for Azure DevOps parallel module generation.

.DESCRIPTION
    This script takes a space-separated list of module names and converts them into a JSON matrix
    for use with Azure DevOps matrix strategy. If a module name doesn't include a version suffix,
    it creates entries for both v1.0 and beta versions.

.PARAMETER ModuleNames
    Space-separated string of module names. Can include version suffixes (e.g., "Users_v1.0") or not (e.g., "Users").
    If no version suffix is provided, both v1.0 and beta entries will be created.

.PARAMETER OutputVariable
    The name of the Azure DevOps output variable to set. If not provided, the JSON is written to the pipeline.

.EXAMPLE
    .\CreateGenerationMatrix.ps1 -ModuleNames "Users Groups"
    Creates matrix with Users_v1.0, Users_beta, Groups_v1.0, Groups_beta

.EXAMPLE
    .\CreateGenerationMatrix.ps1 -ModuleNames "Users_v1.0 Groups_beta"
    Creates matrix with only Users_v1.0 and Groups_beta
#>

[CmdletBinding()]
param(
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string] $ModuleNames,

    [Parameter(Mandatory = $false)]
    [string] $OutputVariable = "matrixJson"
)

Write-Host "ModulesToUpdate: $ModuleNames"

# Split the input string into an array
$testDataArray = $ModuleNames -split ' '
$jsonOutput = @{}

foreach ($item in $testDataArray) {
    # Skip empty entries
    if ([string]::IsNullOrWhiteSpace($item)) {
        continue
    }

    if ($item -notmatch '_') {
        # If '_' is not present, create two versions: v1.0 and beta
        $jsonOutput["${item}_v1.0"] = @{
            moduleVersion = 'v1.0'
            moduleName    = $item
        }
        $jsonOutput["${item}_beta"] = @{
            moduleVersion = 'beta'
            moduleName    = $item
        }
    }
    else {
        # Split on '_' to get name and version
        $name, $version = $item -split '_'
        $jsonOutput[$item] = @{
            moduleVersion = $version
            moduleName    = $name
        }
    }
}

# Convert to compressed JSON
$result = $jsonOutput | ConvertTo-Json -Compress

Write-Host "Generated matrix JSON:"
Write-Host $result

# Set Azure DevOps output variable
Write-Host "##vso[task.setvariable variable=$OutputVariable;isOutput=true]$result"
