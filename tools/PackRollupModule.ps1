# Generate Graph module
# Roll-up generated modules
Param(
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string[]] $Modules,
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
    Write-Host -ForegroundColor Green "Executing Update-ModuleManifest -Path $GraphModuleDir -RequiredModules $Modules..."
    Update-ModuleManifest -Path "$GraphModuleDir\$RollUpModule.psd1" -RequiredModules $Modules

    # Push roll-up module to feed.
    Write-Host -ForegroundColor Green "Executing Publish-Module -Path $GraphModuleDir -NuGetApiKey $ApiKey -Repository $Repository..."
    Publish-Module -Path $GraphModuleDir -NuGetApiKey $ApiKey -Repository $Repository
}catch{
    Write-Error $_.Exception
}