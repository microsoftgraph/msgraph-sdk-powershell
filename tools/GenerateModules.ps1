
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
    [switch] $UseLocalDoc
)
$ErrorActionPreference = 'Stop'

if($PSEdition -ne 'Core') {
  Write-Error 'This script requires PowerShell Core to execute. [Note] Generated cmdlets will work in both PowerShell Core or Windows PowerShell.'
}

$AuthenticationModule = "Authentication"
$RollUpModule = "Graph"
$ArtifactsLocation = Join-Path $PSScriptRoot "..\artifacts\"
$BuildAndPackBinaryModulePS1 = Join-Path $PSScriptRoot ".\BuildAndPackBinaryModule.ps1" -Resolve
$PublishBinaryModulePS1 = Join-Path $PSScriptRoot ".\PublishBinaryModule.ps1" -Resolve
$PackAndPublishRollUpModulePS1 = Join-Path $PSScriptRoot ".\PackAndPublishRollUpModule.ps1" -Resolve
$ManageGeneratedModulePS1 = Join-Path $PSScriptRoot ".\ManageGeneratedModule.ps1" -Resolve
$DownloadOpenAPIDocPS1 = Join-Path $PSScriptRoot ".\DownloadOpenAPIDoc.ps1" -Resolve
$AutoRestConfigYML = Join-Path $PSScriptRoot "..\config\AutoRestConfig.yml" -Resolve

$RepositoryFeedUrl = (Get-PSRepository -Name $RepositoryName).SourceLocation

if ([string]::IsNullOrEmpty($OpenApiBaseUrl)) {
    $OpenApiBaseUrl = "https://graphslice.azurewebsites.net"
}

if([string]::IsNullOrEmpty($DocOutputFolder)){
    $DocOutputFolder =  Join-Path $PSScriptRoot "..\openApiDocs"  -Resolve
}

if($UpdateAutoRest) {
    # Update Autorest.
    & autorest --reset
}

# Clean artifacts folder before copying package.
Remove-Item -Path "$ArtifactsLocation\*" -Recurse -Force

$ExistingAuthModule = Find-Module "$RollUpModule.$AuthenticationModule" -Repository $RepositoryName -ErrorAction SilentlyContinue

if($ExistingAuthModule -eq $null){
    # Build, pack and publish Graph.Authentication module to specified feed..
    # This can be built independent of AutoRest generated modules. 
    & $BuildAndPackBinaryModulePS1 -Module $AuthenticationModule -ArtifactsLocation $ArtifactsLocation

    & $PublishBinaryModulePS1 -ModuleName "$RollUpModule.$AuthenticationModule" -ArtifactsLocation $ArtifactsLocation -RepositoryFeedUrl $RepositoryFeedUrl -RepositoryApiKey $RepositoryApiKey
}

# Install module locally in order to specify it as a dependency for other modules down the generation pipeline.
# https://stackoverflow.com/questions/46216038/how-do-i-define-requiredmodules-in-a-powershell-module-manifest-psd1.
Install-Module "$RollUpModule.$AuthenticationModule" -Repository $RepositoryName -Force

$RequiredGraphModules = New-Object collections.generic.list[string]

foreach($tag in $Tags)
{
    try {
        if(-not $UseLocalDoc)
        {
            # Download OpenAPI docs by tags.
            Write-Host -ForegroundColor Green "Downloading OpenAPI doc for '$RollUpModule.$tag' module..."
            & $DownloadOpenAPIDocPS1 -Tag $tag -OutputFolder $DocOutputFolder -OpenApiBaseUrl $OpenApiBaseUrl
        }

        # Generate PowerShell modules by tags.
        Write-Host -ForegroundColor Green "Generating '$RollUpModule.$tag' module..."
        & autorest --title:$tag --docOutputFolder:$DocOutputFolder --rollUpModule:$RollUpModule $AutoRestConfigYML --verbose
        if($LastExitCode -ne 0){
            Write-Error "Failed to generate '$tag' module."
        }

        # Manage generated module.
        Write-Host -ForegroundColor Green "Managing '$RollUpModule.$tag' module..."
        & $ManageGeneratedModulePS1 -Module $tag

        # Build and pack generated module.
        Write-Host -ForegroundColor Green "Building and packing '$RollUpModule.$tag' module..."
        # Ensure Graph.Authentication is installed locally before running this.
        & $BuildAndPackBinaryModulePS1 -Module $tag -RequiredModules "$RollUpModule.$AuthenticationModule" -ArtifactsLocation $ArtifactsLocation

        $RequiredGraphModules.Add("$RollUpModule.$tag")
    }
    catch {
        Write-Error $_.Exception
    }
}

# Publish generated modules.
Write-Host -ForegroundColor Green "Publishing generated modules..."
foreach($generatedModule in $Tags){
    # Publish module.
    & $PublishBinaryModulePS1 -ModuleName "$RollUpModule.$generatedModule" -ArtifactsLocation $ArtifactsLocation -RepositoryFeedUrl $RepositoryFeedUrl -RepositoryApiKey $RepositoryApiKey

    # Install module locally in order to specify it as a dependency of the roll-up module down the generation pipeline.
    # https://stackoverflow.com/questions/46216038/how-do-i-define-requiredmodules-in-a-powershell-module-manifest-psd1.
    Install-Module "$RollUpModule.$generatedModule" -Repository $RepositoryName -Force
}

# Build and pack roll-up module.
Write-Host -ForegroundColor Green "Packing '$RollUpModule' module..."
$RequiredGraphModules.Add("$RollUpModule.$AuthenticationModule")
& $PackAndPublishRollUpModulePS1 -RequiredModules $RequiredGraphModules -RollUpModule $RollUpModule -RepositoryApiKey $RepositoryApiKey -RepositoryName $RepositoryName

Write-Host -ForegroundColor Green "-------------Done-------------"