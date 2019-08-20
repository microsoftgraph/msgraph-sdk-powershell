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
$RepositoryFeedUrl = $null

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
    $RepositoryFeedUrl = (Get-PSRepository -Name MyLocalGallery).SourceLocation
    # Build, pack and publish Graph.Authentication module to specified feed..
    # This can be built indepentent of AutoRest generated modules.
    Write-Host -ForegroundColor Green "Building and packing '$RollUpModule.$AuthenticationModule' module..."
    & .\tools\BuildPackAndPublishModule.ps1 -Module $AuthenticationModule -RollUpModule $RollUpModule -RepositoryApiKey $RepositoryApiKey -RepositoryFeedUrl $RepositoryFeedUrl

    # Install module locally.
    Install-Module "$RollUpModule.$AuthenticationModule" -Repository $RepositoryName -Force
}

$GraphModules = New-Object collections.generic.list[string]
$GraphModules.Add("$RollUpModule.$AuthenticationModule")

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
            # Ensure Graph.Authentication is installed locally before running this.
            # https://stackoverflow.com/questions/46216038/how-do-i-define-requiredmodules-in-a-powershell-module-manifest-psd1.
            Write-Host -ForegroundColor Green "Building and packing '$RollUpModule.$tag' module..."
            & .\tools\BuildPackAndPublishModule.ps1 -Module $tag -RequiredModules "$RollUpModule.$AuthenticationModule" -RollUpModule $RollUpModule -RepositoryApiKey $RepositoryApiKey -RepositoryFeedUrl $RepositoryFeedUrl

            # Install module locally.
            Install-Module "$RollUpModule.$tag" -Repository $RepositoryName -Force
        }

        $GraphModules.Add("$RollUpModule.$tag")
    }
    catch {
        Write-Error $_.Exception
    }
}

if($BuildAndPack){
    Write-Host -ForegroundColor Green "Packing '$RollUpModule' module..."
    & .\tools\PackRollupModule.ps1 -RequiredModules $GraphModules -RollUpModule $RollUpModule -ApiKey $RepositoryApiKey -Repository $RepositoryName
 }
Write-Host -ForegroundColor Green "-------------Done-------------"