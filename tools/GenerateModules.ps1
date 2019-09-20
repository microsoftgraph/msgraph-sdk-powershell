
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
Param(
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string[]] $Tags,
    [string] $ModuleVersion = "0.1.0",
    [int] $ModulePreviewNumber = -1,
    [string] $OpenApiBaseUrl = "https://graphslice.azurewebsites.net",
    [string] $DocOutputFolder = (Join-Path $PSScriptRoot "..\openApiDocs"),
    [switch] $UpdateAutoRest,
    [switch] $UseLocalDoc,
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
$AutoRestConfigYML = Join-Path $PSScriptRoot "..\config\AutoRestConfig.yml" -Resolve
$BuildAndPackBinaryModulePS1 = Join-Path $PSScriptRoot ".\BuildAndPackBinaryModule.ps1" -Resolve
$PublishModulePS1 = Join-Path $PSScriptRoot ".\PublishModule.ps1" -Resolve
$ManageGeneratedModulePS1 = Join-Path $PSScriptRoot ".\ManageGeneratedModule.ps1" -Resolve
$DownloadOpenAPIDocPS1 = Join-Path $PSScriptRoot ".\DownloadOpenAPIDoc.ps1" -Resolve

if(-not (Test-Path $DocOutputFolder)) {
    New-Item -Path $DocOutputFolder -Type Directory
}
$DocOutputFolder =  Join-Path $DocOutputFolder "" -Resolve

if(-not (Test-Path $ArtifactsLocation)) {
    New-Item -Path $ArtifactsLocation -Type Directory
}

# Install module locally in order to specify it as a dependency for other modules down the generation pipeline.
# https://stackoverflow.com/questions/46216038/how-do-i-define-requiredmodules-in-a-powershell-module-manifest-psd1.
Install-Module "$RollUpModule.Authentication" -Repository $RepositoryName -Force
$RequiredModules = "$RollUpModule.Authentication"

if($UpdateAutoRest) {
    # Update Autorest.
    & autorest-beta --reset
}

foreach($Tag in $Tags)
{
    try {
        if(-not $UseLocalDoc)
        {
            # Download OpenAPI docs by tags.
            & $DownloadOpenAPIDocPS1 -Tag $Tag -OutputFolder $DocOutputFolder -OpenApiBaseUrl $OpenApiBaseUrl
        }

        # Generate PowerShell modules.
        Write-Host -ForegroundColor Green "Generating '$RollUpModule.$Tag' module..."
        & autorest-beta --title:$Tag --docOutputFolder:$DocOutputFolder --rollUpModule:$RollUpModule $AutoRestConfigYML --verbose
        if($LastExitCode -ne 0){
            Write-Error "Failed to generate '$Tag' module."
        }

        # Manage generated module.
        Write-Host -ForegroundColor Green "Managing '$RollUpModule.$Tag' module..."
        & $ManageGeneratedModulePS1 -Module $Tag

        # Build and pack generated module.
        # Ensure Graph.Authentication is installed locally before running this.
        & $BuildAndPackBinaryModulePS1 -Module $Tag -RequiredModules $RequiredModules -ModuleVersion $ModuleVersion -ArtifactsLocation $ArtifactsLocation -ModulePreviewNumber $ModulePreviewNumber
    }
    catch {
        Write-Error $_.Exception
    }
}

if ($Publish) {
    # Publish generated modules.
    & $PublishModulePS1 -Modules $Tags -ArtifactsLocation $ArtifactsLocation -RepositoryName $RepositoryName -RepositoryApiKey $RepositoryApiKey
}
Write-Host -ForegroundColor Green "-------------Done-------------"
