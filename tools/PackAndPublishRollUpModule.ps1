# Generate Graph module
# Roll-up generated modules
Param(
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string] $RollUpModule,
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string[]] $RequiredModules,
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string] $RepositoryApiKey,
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string] $RepositoryName
)
$GraphModuleDir = Join-Path $PSScriptRoot "..\src\$RollUpModule"

try{
    # Update roll-up module "Graph"
    Write-Host -ForegroundColor Green "Updating '$RollUpModule' module..."
    Update-ModuleManifest -Path "$GraphModuleDir\$RollUpModule.psd1" -RequiredModules $RequiredModules

    # Push roll-up module to feed.
    Write-Host -ForegroundColor Green "Publishing '$RollUpModule' module..."
    Publish-Module -Path $GraphModuleDir -NuGetApiKey $RepositoryApiKey -Repository $RepositoryName
}catch{
    Write-Error $_.Exception
}

Write-Host -ForegroundColor Green "-------------Done-------------"