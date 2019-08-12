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
    [switch] $UpdateAutoRest,
    [switch] $UseLocalDoc,
    [switch] $BuildAndPack
)

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

foreach($tag in $Tags)
{
    if(-not $UseLocalDoc)
    {
        # Download OpenAPI docs by tags.
        try {
            & .\tools\DownloadOpenAPIDoc.ps1 -Tag $tag -OutputFolder $DocOutputFolder -OpenApiBaseUrl $OpenApiBaseUrl
        }
        catch {
            Write-Error $_.Exception
            continue
        }
    }

    # Generate PowerShell modules by tags.
    & autorest --title:$tag --docOutputFolder:$DocOutputFolder .\config\AutoRestConfig.yaml --verbose
    if($LastExitCode -ne 0){
        Write-Error "Failed to generate '$tag' module."
        continue
    }

    # Manage generated module.
    & .\tools\ManageGeneratedModule.ps1 -Module $tag

    if($BuildAndPack){
        # Build generated module.
        & .\tools\BuildAndPackModule.ps1 -Module $tag -RequiredModules "Graph.Authentication"

        # Build and pack Graph.Authentication module.
        & .\tools\BuildAndPackModule.ps1 -Module "Authentication"
    }
}