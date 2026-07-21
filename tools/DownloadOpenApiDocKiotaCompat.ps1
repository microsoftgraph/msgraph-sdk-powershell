# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
#
# Kiota-compatible variant of DownloadOpenApiDoc.ps1.
#
# Instead of the PowerShell conversion profile, this slices the Kiota base
# document (fileName=openapi, which has OpenApiConvertSettings.EnableDiscriminatorValue = true
# and preserves AnyOf/OneOf + discriminators) and applies no PowerShell styling (style=Plain),
# producing per-module OpenAPI docs suitable for Kiota SDK generation.
[CmdletBinding()]
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

$OpenApiBaseUrl = "https://graph-devx-api.microsoft.com"
$OpenApiServiceUrl = ("$OpenApiBaseUrl/`$openapi?tags={0}&title=$ModuleName&openapiversion=3&style=Plain&fileName=openapi&graphVersion=$GraphVersion" -f $ModuleRegex)
if ($ForceRefresh.IsPresent) {
    $OpenApiServiceUrl = "$OpenApiServiceUrl&forceRefresh=true"
}
Write-Debug "[$RequestCount] Downloading Kiota-compatible OpenAPI doc for '$ModuleName' module: $OpenApiServiceUrl"
$Retries = 3
$Delay = 3
$Retrycount = 0
$Completed = $false
while (-not $Completed) {
    try {
        Invoke-WebRequest $OpenApiServiceUrl -OutFile "$OpenApiDocOutput\$ModuleName.yml"
        $Completed = $true
    }
    catch {
        $Exception = $_.Exception
        switch ($Exception.Response.StatusCode.value__) {
            { @(429, 503, 504) -contains $_ } {
                if ($Retrycount -ge $Retries) {
                    Write-Warning "Request to $OpenApiServiceUrl failed the maximum number of $Retrycount times."
                    throw
                }
                else {
                    [ref]$RetryAfterHeader = $null
                    if ($Exception.Response.Headers.TryGetValues("Retry-After", $RetryAfterHeader)) {
                        # Use Retry-After response header
                        $DelayInSeconds = $RetryAfterHeader.Value
                    }
                    else {
                        # Use exponential backoff
                        $mPow = [math]::Pow(2, $Retrycount)
                        $DelayInSeconds = $mPow * $Delay
                    }

                    Write-Warning "Request to $OpenApiServiceUrl failed. Retrying in $DelayInSeconds seconds."
                    Start-Sleep $DelayInSeconds
                    $Retrycount++
                }
            }
            404 {
                Write-Warning "Request to $OpenApiServiceUrl returned 404. Download will be skipped."
                $Completed = $true
            }
            default {
                # Get HTTP error message from DevX api, Re-throw error to be handled Upstream
                $ErrorMessage = $Exception.Message
                Write-Warning "[$RequestCount] Request for $ModuleName failed with error message: $ErrorMessage"
                throw
            }
        }
    }
}
