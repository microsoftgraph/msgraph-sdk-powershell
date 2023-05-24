# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
Param(
    [string] $ArtifactsLocation = (Join-Path $PSScriptRoot "..\msgraph-tools-migration")
)

$ModuleNuspec = Join-Path $ArtifactsLocation "Microsoft.Graph.Migration.Tool.nuspec"
if (-not (Test-Path $ModuleNuspec -PathType Leaf)) {
    Write-Error "Nuspec file not found: $ModuleNuspec."
}
Nuget pack $ModuleNuspec -OutputDirectory $ArtifactsLocation