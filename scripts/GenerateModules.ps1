# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
# autorest --reset

# .\GenerateModules.ps1 -tags "me.Actions", "me.userActivity", "users.user"
Param(
    [string[]]$tags
)

$openAPIServiceUrl = "https://graphslice.azurewebsites.net/`$openapi?tags={0}&title=GraphServiceClient&openapiversion=3&style=Powershell"

foreach($tag in $tags)
{
    Write-Host -ForegroundColor Green Downloading $tag from ($openAPIServiceUrl -f $tag)
    wget ($openAPIServiceUrl -f $tag) -OutFile "..\descriptions\$tag.yml"
    Write-Host -ForegroundColor Green "Downloaded $tag.yml"
}

foreach($tag in $tags)
{
    $inputFileUrl = "..\descriptions\$tag.yml"
    autorest --use=@microsoft.azure/autorest.powershell@beta --powershell --input-file:$inputFileUrl --title:$tag --module-name:$tag --output-folder:..\src\$tag\$tag --add-credentials --verbose ..\config\AutoRestConfig.yaml

    # Manage generated project.
    .\ManageGeneratedModules.ps1 -tag $tag
}
