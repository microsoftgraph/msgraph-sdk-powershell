Param(
    [string] $ModuleName,
    [string] $ModuleRegex,
    [string] $OpenApiDocOutput,
    [string] $GraphVersion
)

$OpenApiDocOutput = Join-Path -Path $OpenApiDocOutput -ChildPath $GraphVersion
if(-not (Test-Path $OpenApiDocOutput)) {
    New-Item -Path $OpenApiDocOutput -Type Directory
}

$OpenApiBaseUrl = "https://graphslice.azurewebsites.net"
$OpenApiServiceUrl = ("$OpenApiBaseUrl/`$openapi?tags={0}&title=$ModuleName&openapiversion=3&style=Powershell&graphVersion=$GraphVersion" -f $ModuleRegex)

Write-Host -ForegroundColor Green "Downloading OpenAPI doc for '$ModuleName' module: $OpenApiServiceUrl"
Invoke-WebRequest $OpenApiServiceUrl -OutFile "$OpenApiDocOutput\$ModuleName.yml"