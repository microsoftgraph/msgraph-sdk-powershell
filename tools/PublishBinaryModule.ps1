param(
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string] $ModuleName,
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string] $ArtifactsLocation,
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string] $RepositoryFeedUrl,
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [string] $RepositoryApiKey
)
$ErrorActionPreference = "Stop"

if(-not (Test-Path $ArtifactsLocation)) {
    # Artifacts location not found.
    Write-Error "Artifacts location '$ArtifactsLocation' not found."
}
# Get nuget package to publish.
$NugetPackage = (Get-ChildItem $ArtifactsLocation | Where-Object Name -Match "$ModuleName(.\d+\.)(\d+\.)(\d+\.nupkg)").FullName

if($NugetPackage -eq $null){
    Write-Error "Nuget package for '$ModuleName' module not found."
}

# Copy package to feed.
Write-Host -ForegroundColor Green "Publishing '$ModuleName' module to feed..."
Write-Host "Executing: nuget push $NugetPackage -Source $RepositoryFeedUrl -Apikey $RepositoryApiKey"
nuget push $NugetPackage -Source $RepositoryFeedUrl -Apikey $RepositoryApiKey

if($LastExitCode -ne 0) {
    # nuget push failed. Check package version number.
    Write-Warning "Failed to push '$ModuleName' package. Ensure a module name with the same version number doesn't already exists."
}