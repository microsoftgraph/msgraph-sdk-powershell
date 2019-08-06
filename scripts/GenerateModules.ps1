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
    # Update autorest.
    Invoke-Expression "autorest --reset"
}

foreach($tag in $Tags)
{
    try {
        if(-not $UseLocalDoc)
        {
            # Download OpenAPI docs by tags.
            .\scripts\DownloadOpenAPIDoc.ps1 -Tag $tag -OutputFolder $DocOutputFolder -OpenApiBaseUrl $OpenApiBaseUrl
        }

        # Generate PowerShell modules by tags.
        Invoke-Expression "autorest --title:$tag --docOutputFolder:$DocOutputFolder .\config\AutoRestConfig.yaml --verbose"

        if($LastExitCode -ne 0){
            Write-Error "Failed to generate '$tag' module."
            continue
        }
        
        # Manage generated module.
        .\scripts\ManageGeneratedModule.ps1 -Module $tag
        
        if($BuildAndPack){
            # Build generated module.
            .\scripts\BuildAndPackGeneratedModule.ps1 -Module $tag
        }
    } catch{
        Write-Error -Exception $_.Exception -Message "AutoRest generation exception."
    }
}