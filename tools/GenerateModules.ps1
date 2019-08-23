# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
<#
.DESCRIPTION
Create OpenAPI based PowerShell modules.

.PARAMETER Tags
The name of the resources/tags located in https://github.com/microsoftgraph/msgraph-openapi-introspection. This name is used to form your module name using the format 'Graph.{ModuleName}'.

.PARAMETER OpenApiBaseUrl
The base url to Graph slice API where the OpenAPI is to be downloaded from.

.PARAMETER DocOutputFolder
The root directory where output is produced.

.PARAMETER UpdateAutoRest
Indicates that we should update AutoRest before generating module(s).

.PARAMETER UseLocalDoc
Indicates that we should use a local copy of OpenAPI document.

.PARAMETER BuildAndPack
Indicates that we should build and pack generated module. This will output a nupkg in '{repo}\bin'.
#>
Param(
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string[]] $Tags,
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string] $RepositoryApiKey,
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string] $RepositoryName,
    [string] $OpenApiBaseUrl,
    [string] $DocOutputFolder,
    [switch] $UpdateAutoRest,
    [switch] $UseLocalDoc,
    [switch] $BuildAndPack
)
$ErrorActionPreference = 'Stop'

if($PSEdition -ne 'Core') {
  Write-Error 'This script requires PowerShell Core to execute. [Note] Generated cmdlets will work in both PowerShell Core or Windows PowerShell.'
}

$AuthenticationModule = "Authentication"
$RollUpModule = "Graph"
$ArtifactsLocation = ".\artifacts\"
$RepositoryFeedUrl = (Get-PSRepository -Name $RepositoryName).SourceLocation

if ([string]::IsNullOrEmpty($OpenApiBaseUrl)) {
    $OpenApiBaseUrl = "https://graphslice.azurewebsites.net"
}

if([string]::IsNullOrEmpty($DocOutputFolder)){
    $DocOutputFolder = ".\openApiDocs"
}

if($UpdateAutoRest) {
    # Update Autorest.
    & autorest --reset
}

if($BuildAndPack){
    # Clean artifacts folder before copying package.
    Remove-Item -Path "$ArtifactsLocation/*" -Recurse

    # Build, pack and publish Graph.Authentication module to specified feed..
    # This can be built independent of AutoRest generated modules. 
    & .\tools\BuildAndPackBinaryModule.ps1 -Module $AuthenticationModule -ArtifactsLocation $ArtifactsLocation

    & .\tools\PublishBinaryModule.ps1 -ModuleName "$RollUpModule.$AuthenticationModule" -ArtifactsLocation $ArtifactsLocation -RepositoryFeedUrl $RepositoryFeedUrl -RepositoryApiKey $RepositoryApiKey
}

# Install module locally in order to specify it as a dependency for other modules down the generation pipeline.
# https://stackoverflow.com/questions/46216038/how-do-i-define-requiredmodules-in-a-powershell-module-manifest-psd1.
Install-Module "$RollUpModule.$AuthenticationModule" -Repository $RepositoryName -Force

$RequiredGraphModules = New-Object collections.generic.list[string]

foreach($tag in $Tags)
{
    try {
        if(-not $UseLocalDoc)
        {
            # Download OpenAPI docs by tags.
            Write-Host -ForegroundColor Green "Downloading OpenAPI doc for '$RollUpModule.$tag' module..."
            & .\tools\DownloadOpenAPIDoc.ps1 -Tag $tag -OutputFolder $DocOutputFolder -OpenApiBaseUrl $OpenApiBaseUrl
        }

        # Generate PowerShell modules by tags.
        Write-Host -ForegroundColor Green "Generating '$RollUpModule.$tag' module..."
        & autorest --title:$tag --docOutputFolder:$DocOutputFolder --rollUpModule:$RollUpModule .\config\AutoRestConfig.yaml --verbose
        if($LastExitCode -ne 0){
            Write-Error "Failed to generate '$tag' module."
        }

        # Manage generated module.
        Write-Host -ForegroundColor Green "Managing '$RollUpModule.$tag' module..."
        & .\tools\ManageGeneratedModule.ps1 -Module $tag

        if($BuildAndPack){
            # Build and pack generated module.
            Write-Host -ForegroundColor Green "Building and packing '$RollUpModule.$tag' module..."
            # Ensure Graph.Authentication is installed locally before running this.
            & .\tools\BuildAndPackBinaryModule.ps1 -Module $tag -RequiredModules "$RollUpModule.$AuthenticationModule" -ArtifactsLocation $ArtifactsLocation
        }

        $RequiredGraphModules.Add("$RollUpModule.$tag")
    }
    catch {
        Write-Error $_.Exception
    }
}

if($BuildAndPack){
    # Publish generated modules.
    Write-Host -ForegroundColor Green "Publishing generated modules..."
    foreach($generatedModule in $Tags){
        # Publish module.
        & .\tools\PublishBinaryModule.ps1 -ModuleName "$RollUpModule.$generatedModule" -ArtifactsLocation $ArtifactsLocation -RepositoryFeedUrl $RepositoryFeedUrl -RepositoryApiKey $RepositoryApiKey

        # Install module locally in order to specify it as a dependency of the roll-up module down the generation pipeline.
        # https://stackoverflow.com/questions/46216038/how-do-i-define-requiredmodules-in-a-powershell-module-manifest-psd1.
        Install-Module "$RollUpModule.$generatedModule" -Repository $RepositoryName -Force
    }

    # Build and pack roll-up module.
    Write-Host -ForegroundColor Green "Packing '$RollUpModule' module..."
    $RequiredGraphModules.Add("$RollUpModule.$AuthenticationModule")
    & .\tools\PackAndPublishRollUpModule.ps1 -RequiredModules $RequiredGraphModules -RollUpModule $RollUpModule -RepositoryApiKey $RepositoryApiKey -RepositoryName $RepositoryName
 }

Write-Host -ForegroundColor Green "-------------Done-------------"