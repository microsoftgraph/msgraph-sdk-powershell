# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

<#
.SYNOPSIS
    Detects changes in OpenAPI documentation files and outputs the list of affected modules.

.DESCRIPTION
    This script performs a git diff to identify which OpenAPI YAML files have changed,
    extracts the module names and versions from the file paths, and outputs a space-separated
    list of modules that need to be regenerated.

.PARAMETER OutputVariable
    The name of the Azure DevOps pipeline variable to set with the results.
    Default is "ModuleGenerationList".

.EXAMPLE
    .\OpenApiDocDiff.ps1
    Detects changes and sets the ModuleGenerationList pipeline variable.

.EXAMPLE
    .\OpenApiDocDiff.ps1 -OutputVariable "ChangedModules"
    Detects changes and sets the ChangedModules pipeline variable.
#>

[CmdletBinding()]
param(
    [Parameter(Mandatory = $false)]
    [string] $OutputVariable = "ModuleGenerationList"
)

# Get the list of changed files from git
$diff = git diff --name-only
$ModulesWithChanges = @{}

# Parse each changed file path
$diff | ForEach-Object {
    # Match OpenAPI docs paths: openApiDocs/(v1.0|beta)/{ModuleName}.yml
    if ($_ -match 'openApiDocs\/(v1.0|beta)\/(.*)\.yml') {
        $version = if ($matches[1] -eq 'v1.0') { 'v1.0' } else { 'beta' }
        $moduleName = "$($matches[2])_$version"

        # Add to hashtable if not already present
        if (!$ModulesWithChanges.ContainsKey($moduleName)) {
            $ModulesWithChanges.Add($moduleName, $matches[1])
        }
    }
}

# Convert hashtable keys to space-separated string
$ModuleNames = $ModulesWithChanges.Keys

Write-Host "Modules with changes: $ModuleNames"

# Set the pipeline variable for current job
Write-Host "##vso[task.setvariable variable=$OutputVariable;isOutput=false]$ModuleNames"
# Set the pipeline variable as output for subsequent jobs
Write-Host "##vso[task.setvariable variable=$OutputVariable;isOutput=true]$ModuleNames"
