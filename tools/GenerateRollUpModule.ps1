
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
Param(
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string[]] $RequiredModules,
    [string] $ModuleVersion = "0.1.0",
    [int] $ModulePreviewNumber = -1,
    [string] $RepositoryApiKey,
    [string] $RepositoryName,
    [switch] $Publish
)
$ErrorActionPreference = 'Stop'
if($PSEdition -ne 'Core') {
  Write-Error 'This script requires PowerShell Core to execute. [Note] Generated cmdlets will work in both PowerShell Core or Windows PowerShell.'
}
$LastExitCode = 0
$RollUpModule = "Graph"
$ArtifactsLocation = Join-Path $PSScriptRoot "..\artifacts\"
$GraphModuleLocation = Join-Path $PSScriptRoot "..\src\$RollUpModule\$RollUpModule"
$NuspecHelperPS1 = Join-Path $PSScriptRoot ".\NuspecHelper.ps1"
$PublishModulePS1 = Join-Path $PSScriptRoot ".\PublishModule.ps1" -Resolve
$RollUpModuleNuspec = Join-Path $GraphModuleLocation ".\$RollUpModule.nuspec" -Resolve
$RequiredGraphModules = New-Object collections.generic.list[string]

# Import scripts
. $NuspecHelperPS1

$RollUpModuleArtifactLocation = "$ArtifactsLocation\$RollUpModule"
if(-not (Test-Path $RollUpModuleArtifactLocation)) {
    New-Item -Path $RollUpModuleArtifactLocation -Type Directory
} else {
    Remove-Item -Path "$RollUpModuleArtifactLocation\*" -Recurse -Force
}

foreach($RequiredModule in $RequiredModules){
    # Install module locally in order to specify it as a dependency of the roll-up module down the generation pipeline.
    # https://stackoverflow.com/questions/46216038/how-do-i-define-requiredmodules-in-a-powershell-module-manifest-psd1.
    Install-Module "$RollUpModule.$RequiredModule" -Repository $RepositoryName -Force
    $RequiredGraphModules.Add("$RollUpModule.$RequiredModule")
}

Write-Host -ForegroundColor Green "Updating '$RollUpModule' module manifest and nuspec..."
if($ModulePreviewNumber -ge 0){
    Update-ModuleManifest -Path "$GraphModuleLocation\$RollUpModule.psd1" -RequiredModules $RequiredGraphModules -ModuleVersion $ModuleVersion -Prerelease "preview$ModulePreviewNumber"
    Set-NuSpecValues -NuSpecFilePath $RollUpModuleNuspec -Dependencies $RequiredGraphModules -VersionNumber "$ModuleVersion-preview$ModulePreviewNumber"
} else {
    Update-ModuleManifest -Path "$GraphModuleLocation\$RollUpModule.psd1" -RequiredModules $RequiredGraphModules -ModuleVersion $ModuleVersion
    Set-NuSpecValues -NuSpecFilePath $RollUpModuleNuspec -Dependencies $RequiredGraphModules -VersionNumber $ModuleVersion
}

Write-Host -ForegroundColor Green "Packing '$RollUpModule' module..."
nuget pack $RollUpModuleNuspec -OutputDirectory $RollUpModuleArtifactLocation -Prop Configuration=Release
if($LastExitCode -ne 0){
    Write-Error "Failed to pack $RollUpModule module."
}

if ($Publish)
{
    # Publish roll-up module
    & $PublishModulePS1 -Modules $RollUpModule -ArtifactsLocation $ArtifactsLocation -RepositoryName $RepositoryName -RepositoryApiKey $RepositoryApiKey
}

Write-Host -ForegroundColor Green "-------------Done-------------"