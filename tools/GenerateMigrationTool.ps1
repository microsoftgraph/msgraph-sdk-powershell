$NuspecGenerator= Join-Path $PSScriptRoot "..\msgraph-tools-migration\GenerateNuspec.ps1"
[string] $ArtifactsLocation = (Join-Path $PSScriptRoot "..\msgraph-tools-migration")
# Import scripts
. $NuspecGenerator
Generate-NuspecFile
Move-Item "Microsoft.Graph.Migration.Tool.nuspec" -Destination $ArtifactsLocation -Force