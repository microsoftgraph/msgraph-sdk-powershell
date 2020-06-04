Param(
    [string] $ModuleName,
    [string] $ModuleRegex,
    [string] $OpenApiDocOutput,
    [string] $GraphVersion,
    [int] $RequestCount
)

if (-not (Test-Path $OpenApiDocOutput)) {
    New-Item -Path $OpenApiDocOutput -Type Directory
}
  
$OpenApiBaseUrl = "https://graphexplorerapi.azurewebsites.net"
$OpenApiServiceUrl = ("$OpenApiBaseUrl/`$openapi?tags={0}&title=$ModuleName&openapiversion=3&style=Powershell&graphVersion=$GraphVersion" -f $ModuleRegex)
if ($RequestCount -eq 0) {
    $OpenApiServiceUrl = "$OpenApiServiceUrl&forceRefresh=true"
}

Write-Host -ForegroundColor Green "[$RequestCount] Downloading OpenAPI doc for '$ModuleName' module: $OpenApiServiceUrl"
Invoke-WebRequest $OpenApiServiceUrl -OutFile "$OpenApiDocOutput\$ModuleName.yml"