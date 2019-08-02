# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

# .\scripts\GenerateModules.ps1 -tags me.message, me.messages.attachment, me.messages.extension, me.messages.multiValueLegacyExtendedProperty -useLocalOpenApiDoc
Param(
    [string[]] $tags,
    [switch] $useLocalOpenApiDoc
)

$openAPIServiceUrl = "https://graphslice.azurewebsites.net/`$openapi?tags={0}&title={0}&openapiversion=3&style=Powershell"
$openApiDocsFolder = "openApiDocs"
# Download OpenAPI docs by tags.
if(-not $useLocalOpenApiDoc)
{
    # Create openApiDocs folder
    New-Item -Name $openApiDocsFolder -ItemType Directory -Force

    foreach($tag in $tags)
    {
        Write-Host -ForegroundColor Green "Downloading $tag from " ($openAPIServiceUrl -f $tag)
        Invoke-WebRequest ($openAPIServiceUrl -f $tag) -OutFile ".\$openApiDocsFolder\$tag.yml"
        Write-Host -ForegroundColor Green "Downloaded $tag.yml"
    }
}

# Update autorest.
Invoke-Expression "autorest --reset"

# Generate PowerShell modules by tags.
foreach($tag in $tags)
{
    try {
        Invoke-Expression "autorest --title:$tag .\config\AutoRestConfig.yaml --verbose"
        
        # Manage generated module.
        .\scripts\ManageGeneratedModules.ps1 -tag $tag
    }catch{
        Write-Error "AutoRest generation exception."
    }
}