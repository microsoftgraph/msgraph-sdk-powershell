# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
<#
.DESCRIPTION
Downloads OpenAPI documents for offline access.

.PARAMETER Tag
The name of the tag to download it's corresponding OpenAPI document. The complete list of tags are located in https://github.com/microsoftgraph/msgraph-openapi-introspection.

.PARAMETER OutputFolder
The root directory where the downloaded OpenAPI is saved.

.PARAMETER OpenApiBaseUrl
The base url to Graph slice API where the OpenAPI is to be downloaded from.
#>
Param(
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string] $Tag,
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string] $OutputFolder,
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string] $OpenApiBaseUrl
)

$OpenApiServiceUrl = ("$OpenApiBaseUrl/`$openapi?tags={0}&openapiversion=3&style=Powershell" -f $Tag)

if(-not (Test-Path $OutputFolder)){
    # Create openApiDocs folder.
    New-Item -Name $OutputFolder -ItemType Directory -Force
}

Write-Host -ForegroundColor Green "Downloading '$Tag' from $OpenApiServiceUrl."

# Download OpenAPI docs by tags.
Invoke-WebRequest $OpenApiServiceUrl -OutFile "$OutputFolder\$Tag.yml"

Write-Host -ForegroundColor Green "Downloaded '$OutputFolder\$Tag.yml'."