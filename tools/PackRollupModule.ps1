# Generate Graph module
# Roll-up generated modules
Param(
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string[]] $RequiredModules,
    [ValidateNotNullOrEmpty()]
    [string] $RollUpModule,
    [ValidateNotNullOrEmpty()]
    [string] $ApiKey,
    [ValidateNotNullOrEmpty()]
    [string] $Repository
)
$GraphModuleDir = Join-Path $PSScriptRoot "..\src\$RollUpModule"

try{
    # Update roll-up module "Graph"
    Write-Host -ForegroundColor Green "Updating '$RollUpModule' module..."
    Update-ModuleManifest -Path "$GraphModuleDir\$RollUpModule.psd1" -RequiredModules $RequiredModules

    # Push roll-up module to feed.
    Write-Host -ForegroundColor Green "Publishing '$RollUpModule' module..."
    Publish-Module -Path $GraphModuleDir -NuGetApiKey $ApiKey -Repository $Repository
}catch{
    Write-Error $_.Exception
}

Write-Host -ForegroundColor Green "-------------Done-------------"