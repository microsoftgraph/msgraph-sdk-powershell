
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
Param(
    [string] $RepositoryApiKey,
    [string] $RepositoryName,
    [string] $ModuleMappingConfigPath = (Join-Path $PSScriptRoot "..\config\ModulesMapping.jsonc"),
    [string] $OpenApiBaseUrl = "https://graphslice.azurewebsites.net",
    [string] $DocOutputFolder = (Join-Path $PSScriptRoot "..\openApiDocs"),
    [string] $ModuleVersion = "0.1.0",
    [int] $ModulePreviewNumber = -1,
    [switch] $BetaGraphVersion,
    [switch] $UpdateAutoRest,
    [switch] $UseLocalDoc,
    [switch] $Publish
)
$ErrorActionPreference = 'Stop'
if($PSEdition -ne 'Core') {
  Write-Error 'This script requires PowerShell Core to execute. [Note] Generated cmdlets will work in both PowerShell Core or Windows PowerShell.'
}
$LastExitCode = 0
$ModuleNamespace = "Microsoft.Graph"
$ModulePrefix = "MG"
$GraphVersion = "v1.0"
if($BetaGraphVersion){
    $ModuleNamespace += ".Beta"
    $GraphVersion = "Beta"
    $ModulePrefix = "MGB"
}
# We will overwrite it for now.
$ModulesOutputDir = Join-Path $PSScriptRoot "../src/$GraphVersion/"
$AuthenticationModule = "Microsoft.Graph.Authentication"
$ArtifactsLocation = Join-Path $PSScriptRoot "..\artifacts\"
$BuildAndPackBinaryModulePS1 = Join-Path $PSScriptRoot ".\BuildAndPackBinaryModule.ps1" -Resolve
$PublishModulePS1 = Join-Path $PSScriptRoot ".\PublishModule.ps1" -Resolve
$ManageGeneratedModulePS1 = Join-Path $PSScriptRoot ".\ManageGeneratedModule.ps1" -Resolve

$DocOutputFolder = Join-Path $DocOutputFolder $GraphVersion
if(-not (Test-Path $DocOutputFolder)) {
    New-Item -Path $DocOutputFolder -Type Directory
}
$DocOutputFolder =  Join-Path $DocOutputFolder "" -Resolve

$ArtifactsLocation = Join-Path $ArtifactsLocation $GraphVersion
if(-not (Test-Path $ArtifactsLocation)) {
    New-Item -Path $ArtifactsLocation -Type Directory
}

if(-not (Test-Path $ModuleMappingConfigPath)){
    Write-Error "Module mapping file not be found: $ModuleMappingConfigPath."
}

# Install module locally in order to specify it as a dependency for other modules down the generation pipeline.
# https://stackoverflow.com/questions/46216038/how-do-i-define-requiredmodules-in-a-powershell-module-manifest-psd1.
Install-Module $AuthenticationModule -Repository $RepositoryName -AllowPrerelease -Force
$RequiredModules = $AuthenticationModule

if($UpdateAutoRest) {
    # Update AutoRest.
    & AutoRest-beta --reset
}

[HashTable] $ModuleMapping = Get-Content $ModuleMappingConfigPath | ConvertFrom-Json -AsHashTable
foreach($ModuleName in $ModuleMapping.Keys)
{
    try {
        if(-not $UseLocalDoc)
        {
            $OpenApiServiceUrl = ("$OpenApiBaseUrl/`$openapi?tags={0}&title=$ModuleName&openapiversion=3&style=Powershell&graphVersion=$GraphVersion" -f $ModuleMapping[$ModuleName])

            Write-Host -ForegroundColor Green "Downloading OpenAPI doc for '$ModuleName' module: $OpenApiServiceUrl"
            Invoke-WebRequest $OpenApiServiceUrl -OutFile "$DocOutputFolder\$ModuleName.yml"
        }

        # Generate PowerShell modules.
        Write-Host -ForegroundColor Green "Generating '$ModuleNamespace.$ModuleName' module..."
        & AutoRest-beta --prefix:$ModulePrefix --service-name:$ModuleName --spec-doc-repo:$DocOutputFolder (Join-Path $ModulesOutputDir "$ModuleName/$ModuleName/readme.md") --verbose

        if($LastExitCode -ne 0){
            Write-Error "Failed to generate '$ModuleName' module."
        }

        # Manage generated module.
        Write-Host -ForegroundColor Green "Managing '$ModuleNamespace.$ModuleName' module..."
        & $ManageGeneratedModulePS1 -Module $ModuleName -ModuleNamespace $ModulePrefix -GraphVersion $GraphVersion

        # Build and pack generated module.
        # Ensure Graph.Authentication is installed locally before running this.
        & $BuildAndPackBinaryModulePS1 -Module $ModuleName -ModuleNamespace $ModulePrefix -GraphVersion $GraphVersion -RequiredModules $RequiredModules -ModuleVersion $ModuleVersion -ArtifactsLocation $ArtifactsLocation -ModulePreviewNumber $ModulePreviewNumber
    }
    catch {
        Write-Error $_.Exception
    }
}

if ($Publish) {
    # Publish generated modules.
    & $PublishModulePS1 -Modules $ModuleMapping.Keys -ModuleNamespace $ModuleNamespace -ArtifactsLocation $ArtifactsLocation -RepositoryName $RepositoryName -RepositoryApiKey $RepositoryApiKey
}
Write-Host -ForegroundColor Green "-------------Done-------------"
