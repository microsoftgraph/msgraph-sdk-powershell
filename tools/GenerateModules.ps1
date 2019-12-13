# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
Param(
    [string] $RepositoryApiKey,
    [string] $RepositoryName,
    [string] $ModuleVersion = "0.1.1",
    [int] $ModulePreviewNumber = -1,
    [string] $ModuleMappingConfigPath = (Join-Path $PSScriptRoot "..\config\ModulesMapping.jsonc"),
    [string] $OpenApiDocOutput = (Join-Path $PSScriptRoot "..\openApiDocs"),
    [switch] $BetaGraphVersion,
    [switch] $UpdateAutoRest,
    [switch] $UseLocalDoc,
    [switch] $Publish
)
$ErrorActionPreference = 'Stop'
$LastExitCode = 0
if($PSEdition -ne 'Core') {
  Write-Error 'This script requires PowerShell Core to execute. [Note] Generated cmdlets will work in both PowerShell Core or Windows PowerShell.'
}

$GraphVersion = "v1.0"
if ($BetaGraphVersion){
    $GraphVersion = "Beta"
}
$ModulePrefix = "Microsoft.Graph"
$ModulesOutputDir = Join-Path $PSScriptRoot "../src/$GraphVersion/"
$AuthenticationModule = "Microsoft.Graph.Authentication"
$OpenApiDocOutput = Join-Path $OpenApiDocOutput $GraphVersion
$ArtifactsLocation = Join-Path $PSScriptRoot "..\artifacts\$GraphVersion"

# PS Scripts
$DownloadOpenApiDocPS1 = Join-Path $PSScriptRoot ".\DownloadOpenApiDoc.ps1" -Resolve
$BuildAndPackBinaryModulePS1 = Join-Path $PSScriptRoot ".\BuildAndPackBinaryModule.ps1" -Resolve
$ManageGeneratedModulePS1 = Join-Path $PSScriptRoot ".\ManageGeneratedModule.ps1" -Resolve
$PublishModulePS1 = Join-Path $PSScriptRoot ".\PublishModule.ps1" -Resolve

if(-not (Test-Path $ArtifactsLocation)) {
    New-Item -Path $ArtifactsLocation -Type Directory
}

if(-not (Test-Path $ModuleMappingConfigPath)){
    Write-Error "Module mapping file not be found: $ModuleMappingConfigPath."
}

# Install module locally in order to specify it as a dependency for other modules down the generation pipeline.
# https://stackoverflow.com/questions/46216038/how-do-i-define-requiredmodules-in-a-powershell-module-manifest-psd1.
Install-Module $AuthenticationModule -Repository $RepositoryName -AllowPrerelease -Force

if($UpdateAutoRest) {
    # Update AutoRest.
    & AutoRest-beta --reset
}

[HashTable] $ModuleMapping = Get-Content $ModuleMappingConfigPath | ConvertFrom-Json -AsHashTable
$ModuleMapping.Keys | ForEach-Object {
    $ModuleName = $_
    $ModuleProjectDir = (Join-Path $ModulesOutputDir "$ModuleName/$ModuleName")

    try {
        # Download OpenAPI document for module.
        if(-not $UseLocalDoc)
        {
            . $DownloadOpenApiDocPS1 -ModuleName $ModuleName -ModuleRegex $ModuleMapping[$ModuleName] -OpenApiDocOutput $OpenApiDocOutput -GraphVersion $GraphVersion
        }

        # Copy AutoRest readme.md config is none exists.
        if(-not (Test-Path "$ModuleProjectDir/readme.md")) {
            New-Item -Path $ModuleProjectDir -Type Directory -Force
            Copy-Item (Join-Path $PSScriptRoot "\Templates\readme.md") -Destination $ModuleProjectDir
        }

        # Generate PowerShell modules.
        Write-Host -ForegroundColor Green "Generating '$ModulePrefix.$ModuleName' module..."
        $OpenApiDocPath = Join-Path $OpenApiDocOutput "" -Resolve
        AutoRest-beta --module-version:$ModuleVersion --service-name:$ModuleName --spec-doc-repo:$OpenApiDocPath "$ModuleProjectDir/readme.md" --verbose
        if ($LastExitCode -ne 0){
            Write-Error "Failed to generate '$ModuleName' module."
        }

        # Manage generated module.
        Write-Host -ForegroundColor Green "Managing '$ModulePrefix.$ModuleName' module..."
        . $ManageGeneratedModulePS1 -Module $ModuleName -ModulePrefix $ModulePrefix -GraphVersion $GraphVersion

        # Build and pack generated module.
        # Ensure Graph.Authentication is installed locally before running this.
        . $BuildAndPackBinaryModulePS1 -Module $ModuleName -ModulePrefix $ModulePrefix -GraphVersion $GraphVersion -RequiredModules $AuthenticationModule -ModuleVersion $ModuleVersion -ArtifactsLocation $ArtifactsLocation -ModulePreviewNumber $ModulePreviewNumber
    }
    catch {
        Write-Error $_.Exception
    }
}

if ($Publish) {
    # Publish generated modules.
    . $PublishModulePS1 -Modules $ModuleMapping.Keys -ModulePrefix $ModulePrefix -ArtifactsLocation $ArtifactsLocation -RepositoryName $RepositoryName -RepositoryApiKey $RepositoryApiKey
}

Write-Host -ForegroundColor Green "-------------Done-------------"
