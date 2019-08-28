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
    [string] $ArtifactsLocation
    # [string] $RepositoryApiKey,
    # [Parameter(Mandatory = $true)]
    # [ValidateNotNullOrEmpty()]
    # [string] $RepositoryName
)
$GraphModuleDir = Join-Path $PSScriptRoot "..\src\$RollUpModule\$RollUpModule"
$RollUpModuleNuspec = Join-Path $GraphModuleDir ".\$RollUpModule.nuspec" -Resolve

try{
    # Update roll-up module "Graph"
    Write-Host -ForegroundColor Green "Updating '$RollUpModule' module..."
    Update-ModuleManifest -Path "$GraphModuleDir\$RollUpModule.psd1" -RequiredModules $RequiredModules

    # Pack module to bin
    nuget pack $RollUpModuleNuspec -OutputDirectory (Join-Path $GraphModuleDir ".\bin")

    # Get generated .nupkg
    $NugetPackage = (Get-ChildItem (Join-Path $GraphModuleDir "./bin") | Where-Object Name -Match ".nupkg").FullName

    # Copy package to artifacts folder.
    Write-Host -ForegroundColor Green "Copying '$RollUpModule' module to $ArtifactsLocation..."
    Copy-Item -Path $NugetPackage -Destination $ArtifactsLocation -Force
}catch{
    Write-Error $_.Exception
}

Write-Host -ForegroundColor Green "-------------Done-------------"