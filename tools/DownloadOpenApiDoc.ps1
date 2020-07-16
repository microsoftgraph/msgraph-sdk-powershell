Param(
    [string] $ModuleName,
    [string] $ModuleRegex,
    [string] $OpenApiDocOutput,
    [string] $GraphVersion,
    [switch] $ForceRefresh,
    [int] $RequestCount = 1
)

if (-not (Test-Path $OpenApiDocOutput)) {
    New-Item -Path $OpenApiDocOutput -Type Directory
}
  
$OpenApiBaseUrl = "https://graphexplorerapi.azurewebsites.net"
$OpenApiServiceUrl = ("$OpenApiBaseUrl/`$openapi?tags={0}&title=$ModuleName&openapiversion=3&style=Powershell&graphVersion=$GraphVersion" -f $ModuleRegex)
if ($ForceRefresh.IsPresent) {
    $OpenApiServiceUrl = "$OpenApiServiceUrl&forceRefresh=true"
}
Write-Host -ForegroundColor Green "[$RequestCount] Downloading OpenAPI doc for '$ModuleName' module: $OpenApiServiceUrl"
try {
    Invoke-WebRequest $OpenApiServiceUrl -OutFile "$OpenApiDocOutput\$ModuleName.yml"
}
catch {
    # Get the Http Error Message from DevX Api, Rethrow Error to be handled Upstream
    $ErrorMessage = $_.Exception.Message
    Write-Host -ForegroundColor Red "[$RequestCount] Request Failed for $ModuleName Error Message: $ErrorMessage"
    throw
}