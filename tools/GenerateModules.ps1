
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
if($PSEdition -ne 'Core') {
  Write-Error 'This script requires PowerShell Core to execute. [Note] Generated cmdlets will work in both PowerShell Core or Windows PowerShell.'
}
$LastExitCode = 0
$ModulePrefix = "MG"
$GraphVersion = "v1.0"

if ($BetaGraphVersion){
    $GraphVersion = "Beta"
    $ModulePrefix = "MGB"
}

$ModulesOutputDir = Join-Path $PSScriptRoot "../src/$GraphVersion/"
$AuthenticationModule = "Microsoft.Graph.Authentication"
$OpenApiDocOutput = Join-Path $OpenApiDocOutput $GraphVersion
$ArtifactsLocation = Join-Path $PSScriptRoot "..\artifacts\$GraphVersion"

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
    try {
        # Download OpenAPI document for module.
        if(-not $UseLocalDoc)
        {
            .\tools\DownloadOpenApiDoc.ps1 -ModuleName $ModuleName -ModuleRegex $ModuleMapping[$ModuleName] -OpenApiDocOutput $OpenApiDocOutput -GraphVersion $GraphVersion
        }

        # Generate PowerShell modules.
        Write-Host -ForegroundColor Green "Generating '$ModulePrefix.$ModuleName' module..."
        $OpenApiDocPath = Join-Path $OpenApiDocOutput "" -Resolve
        AutoRest-beta --prefix:$ModulePrefix --module-version:$ModuleVersion --service-name:$ModuleName --spec-doc-repo:$OpenApiDocPath (Join-Path $ModulesOutputDir "$ModuleName/$ModuleName/readme.md") --verbose
        if ($LastExitCode -ne 0){
            Write-Error "Failed to generate '$ModuleName' module."
        }

        # Manage generated module.
        Write-Host -ForegroundColor Green "Managing '$ModulePrefix.$ModuleName' module..."
        .\tools\ManageGeneratedModule.ps1 -Module $ModuleName -ModulePrefix $ModulePrefix -GraphVersion $GraphVersion

        # Build and pack generated module.
        # Ensure Graph.Authentication is installed locally before running this.
        .\tools\BuildAndPackBinaryModule.ps1 -Module $ModuleName -ModulePrefix $ModulePrefix -GraphVersion $GraphVersion -RequiredModules $AuthenticationModule -ModuleVersion $ModuleVersion -ArtifactsLocation $ArtifactsLocation -ModulePreviewNumber $ModulePreviewNumber
    }
    catch {
        Write-Error $_.Exception
    }
}

if ($Publish) {
    # Publish generated modules.
    .\tools\PublishModule.ps1 -Modules $ModuleMapping.Keys -ModulePrefix $ModulePrefix -ArtifactsLocation $ArtifactsLocation -RepositoryName $RepositoryName -RepositoryApiKey $RepositoryApiKey
}
Write-Host -ForegroundColor Green "-------------Done-------------"
