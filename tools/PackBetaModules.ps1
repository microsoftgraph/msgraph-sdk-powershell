# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

Param(
    [string] $WorkingDirectory = $PSScriptRoot,
    [string] $ArtifactsLocation = (Join-Path $PSScriptRoot "..\artifacts")
)

$ModuleMappingConfigPath = (Join-Path $WorkingDirectory "..\config\ModulesMapping.jsonc")
        [HashTable] $ModuleMapping = Get-Content $ModuleMappingConfigPath | ConvertFrom-Json -AsHashTable
        $ModuleMapping.Keys | ForEach-Object {
            $ModuleName = $_
            $ModuleProjectDir = (Join-Path $WorkingDirectory "\src\$ModuleName\$ModuleName")
            & $WorkingDirectory/PackModule.ps1 -Module $ModuleName -ArtifactsLocation $ArtifactsLocation\
        }