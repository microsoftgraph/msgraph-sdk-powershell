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
    [string] $OpenApiBaseUrl,
    [string] $DocOutputFolder,
    [ValidateNotNullOrEmpty()]
    [string] $FeedApiKey,
    [ValidateNotNullOrEmpty()]
    [string] $RepositoryName,
    [switch] $UpdateAutoRest,
    [switch] $UseLocalDoc,
    [switch] $BuildAndPack,
    [switch]$Isolated
)
# $ErrorActionPreference = 'Stop'

if($PSEdition -ne 'Core') {
  Write-Error 'This script requires PowerShell Core to execute. [Note] Generated cmdlets will work in both PowerShell Core or Windows PowerShell.'
}

if(-not $Isolated){
    Write-Host -ForegroundColor Green 'Creating isolated process...'
    $pwsh = [System.Diagnostics.Process]::GetCurrentProcess().Path
    & "$pwsh" -NonInteractive -NoLogo -NoProfile -File $MyInvocation.MyCommand.Path @PSBoundParameters -Isolated
}

$AuthenticationModule = "Authentication"
$RollUpModule = "Graph"
$SourceLocation = $null

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
    $SourceLocation = (Get-PSRepository -Name MyLocalGallery).SourceLocation
    # Build and pack Graph.Authentication module.
    # This can be built indepentent of AutoRest generated modules.
    & .\tools\BuildAndPackModule.ps1 -Module $AuthenticationModule -FeedApiKey $FeedApiKey -FeedUrl $SourceLocation

    # Install module locally.
    Install-Module "$RollUpModule.$AuthenticationModule" -Repository $RepositoryName -Force
}

$GraphModules = [System.Collections.ArrayList]@()
$GraphModules.Add("$RollUpModule.$AuthenticationModule")

foreach($tag in $Tags)
{
    try {
        if(-not $UseLocalDoc)
        {
            # Download OpenAPI docs by tags.
            & .\tools\DownloadOpenAPIDoc.ps1 -Tag $tag -OutputFolder $DocOutputFolder -OpenApiBaseUrl $OpenApiBaseUrl        
        }

        # Generate PowerShell modules by tags.
        & autorest --title:$tag --docOutputFolder:$DocOutputFolder .\config\AutoRestConfig.yaml --verbose
        if($LastExitCode -ne 0){
            Write-Error "Failed to generate '$tag' module."
        }

        # Manage generated module.
        & .\tools\ManageGeneratedModule.ps1 -Module $tag

        if($BuildAndPack){
            # Build and pack generated module.
            # Ensure Graph.Authentication is installed locally before running this.
            # https://stackoverflow.com/questions/46216038/how-do-i-define-requiredmodules-in-a-powershell-module-manifest-psd1.
            & .\tools\BuildAndPackModule.ps1 -Module $tag -RequiredModules "$RollUpModule.$AuthenticationModule" -FeedApiKey $FeedApiKey -FeedUrl $SourceLocation

            # Install module locally.
            Install-Module "$RollUpModule.$tag" -Repository $RepositoryName -Force
        }

        $GraphModules.Add("$RollUpModule.$tag")
    }
    catch {
        Write-Error $_.Exception
        continue
    }
}

if($BuildAndPack){
   .\tools\PackRollupModule.ps1 -Modules $GraphModules -RollUpModule $RollUpModule -ApiKey $FeedApiKey -Repository $RepositoryName
}
