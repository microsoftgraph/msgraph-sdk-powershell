
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
Param(
    [string] $RepositoryApiKey,
    [string] $RepositoryName,
    [string] $ModuleMappingConfigPath = (Join-Path $PSScriptRoot "..\config\ModulesMapping.jsonc"),
    [string] $ModuleVersion = "0.1.0",
    [int] $ModulePreviewNumber = -1,
    [switch] $BetaGraphVersion,
    [switch] $Publish
)
$ErrorActionPreference = 'Stop'

if($PSEdition -ne 'Core') {
  Write-Error 'This script requires PowerShell Core to execute. [Note] Generated cmdlets will work in both PowerShell Core or Windows PowerShell.'
}

if(-not (Test-Path $ModuleMappingConfigPath)){
    Write-Error "Module mapping file not be found: $ModuleMappingConfigPath."
}

$LastExitCode = 0
$ModulePrefix = "MG"
$GraphVersion = "v1.0"
if($BetaGraphVersion){
    $ModulePrefix = "MGB"
    $GraphVersion = "Beta"
}
$NuspecHelperPS1 = Join-Path $PSScriptRoot ".\NuspecHelper.ps1"
$PublishModulePS1 = Join-Path $PSScriptRoot ".\PublishModule.ps1" -Resolve

$ArtifactsLocation = Join-Path $PSScriptRoot "..\artifacts\$GraphVersion\"
$GraphModuleLocation = Join-Path $PSScriptRoot "..\src\$GraphVersion\Graph\Graph"
$RollUpModuleNuspec = Join-Path $GraphModuleLocation ".\$ModulePrefix"
$RequiredGraphModules = New-Object collections.generic.list[string]
[HashTable] $ModuleMapping = Get-Content $ModuleMappingConfigPath | ConvertFrom-Json -AsHashTable
[HashTable] $NuspecMetadata = Get-Content (Join-Path $PSScriptRoot "..\config\ModuleMetadata.json") | ConvertFrom-Json -AsHashTable

# Import scripts
. $NuspecHelperPS1

$RollUpModuleArtifactLocation = "$ArtifactsLocation\Graph"
if(-not (Test-Path $RollUpModuleArtifactLocation)) {
    New-Item -Path $RollUpModuleArtifactLocation -Type Directory
} else {
    Remove-Item -Path "$RollUpModuleArtifactLocation\*" -Recurse -Force
}

if(-not (Test-Path $GraphModuleLocation)) {
    New-Item -Path $GraphModuleLocation -Type Directory
}

# Add auth module as a dependency.
$RequiredGraphModules.Add("Microsoft.Graph.Authentication")
Install-Module "Microsoft.Graph.Authentication" -Repository $RepositoryName -AllowPrerelease -Force

foreach($RequiredModule in $ModuleMapping.Keys){
    # Install module locally in order to specify it as a dependency of the roll-up module down the generation pipeline.
    # https://stackoverflow.com/questions/46216038/how-do-i-define-requiredmodules-in-a-powershell-module-manifest-psd1.
    Install-Module "$ModulePrefix.$RequiredModule" -Repository $RepositoryName -AllowPrerelease -Force
    $RequiredGraphModules.Add("$ModulePrefix.$RequiredModule")
}

[HashTable]$ModuleManifestSettings = @{
    Path = "$GraphModuleLocation\$ModulePrefix.psd1"
    GUID = if ($BetaGraphVersion) { "1C7813EF-88D8-4A52-BE2C-E914E4331E7B" } else { "585dcd71-ed77-4087-884b-7e41936961c2" }
    CompatiblePSEditions = "Core", "Desktop"
    PowerShellVersion = "5.1"
    DotNetFrameworkVersion = "4.7.2"
    ModuleVersion = $ModuleVersion
    RequiredModules = $RequiredGraphModules
    Author = $NuspecMetadata["authors"]
    CompanyName = $NuspecMetadata["owners"]
    Copyright = $NuspecMetadata["copyright"]
    Description = $NuspecMetadata["description"]
    Tags = $NuspecMetadata["tags"]
    LicenseUri = $NuspecMetadata["licenseUri"]
    ProjectUri = $NuspecMetadata["projectUri"]
    IconUri = $NuspecMetadata["iconUri"]
    # ReleaseNotes = $NuspecMetadata["releaseNotes"]
}

Write-Host -ForegroundColor Green "Creating '$ModulePrefix' module manifest and nuspec..."
if($ModulePreviewNumber -ge 0){
    # Prerelease is only supported in PowerShell 7 (preview) and above.
    $ModuleManifestSettings["Prerelease"] = "preview$ModulePreviewNumber"
    $NuspecMetadata["version"] = "$ModuleVersion-preview$ModulePreviewNumber"
} else {
    $NuspecMetadata["version"] = $ModuleVersion
}
$NuspecMetadata["dependencies"] = $RequiredGraphModules
$NuspecMetadata["id"] = $ModulePrefix

New-ModuleManifest @ModuleManifestSettings

& nuget spec $RollUpModuleNuspec -Force
Set-NuSpecValuesFromManifest -NuSpecFilePath "$RollUpModuleNuspec.nuspec" -Manifest $NuspecMetadata

Write-Host -ForegroundColor Green "Packing '$ModulePrefix' module..."
& nuget pack "$RollUpModuleNuspec.nuspec" -OutputDirectory $RollUpModuleArtifactLocation -Prop Configuration=Release

if($LastExitCode -ne 0){
    Write-Error "Failed to pack $ModulePrefix module."
}

if ($Publish)
{
    # Publish roll-up module
    & $PublishModulePS1 -Modules "Graph" -ModulePrefix $ModulePrefix -ArtifactsLocation $ArtifactsLocation -RepositoryName $RepositoryName -RepositoryApiKey $RepositoryApiKey
}

Write-Host -ForegroundColor Green "-------------Done-------------"