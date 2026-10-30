# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
#
# Kiota-compatible variant of DownloadOpenApiDoc.ps1.
#
# Instead of the PowerShell conversion profile, this slices the Kiota base
# document (fileName=openapi, which has OpenApiConvertSettings.EnableDiscriminatorValue = true
# and preserves AnyOf/OneOf + discriminators) using style=Plain. When requested,
# only operation IDs are copied from a PowerShell-styled view of the same source.
[CmdletBinding()]
Param(
    [string] $ModuleName,
    [string] $ModuleRegex,
    [string] $OpenApiDocOutput,
    [string] $GraphVersion,
    [switch] $ForceRefresh,
    [switch] $SingularizeOperationIds,
    # The bulk refresh prunes the complete profile once, retaining a single aggregate report.
    [Parameter(DontShow)]
    [switch] $DeferPruning,
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
$Downloaded = $false
while (-not $Completed) {
    try {
        $requestUrl = $OpenApiServiceUrl
        $outputPath = Join-Path $OpenApiDocOutput "$ModuleName.yml"
        Invoke-WebRequest $OpenApiServiceUrl -OutFile $outputPath -ErrorAction Stop
        if ($SingularizeOperationIds.IsPresent) {
            # Plain ignores singularizeOperationIds; use PowerShell styling only as an ID reference.
            $operationIdServiceUrl = $OpenApiServiceUrl.Replace('style=Plain', 'style=Powershell')
            $operationIdServiceUrl += '&singularizeOperationIds=true&format=json'
            $requestUrl = $operationIdServiceUrl
            $operationIdDocument = (Invoke-WebRequest $operationIdServiceUrl -ErrorAction Stop).Content |
                ConvertFrom-Json -AsHashtable
            & (Join-Path $PSScriptRoot 'Utilities\Set-OpenApiOperationIds.ps1') `
                -OpenApiFilePath $outputPath -OperationIdDocument $operationIdDocument
        }
        $Downloaded = $true
        $Completed = $true
    }
    catch {
        $Exception = $_.Exception
        switch ($Exception.Response.StatusCode.value__) {
            { @(429, 503, 504) -contains $_ } {
                if ($Retrycount -ge $Retries) {
                    Write-Warning "Request to $requestUrl failed the maximum number of $Retrycount times."
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

                    Write-Warning "Request to $requestUrl failed. Retrying in $DelayInSeconds seconds."
                    Start-Sleep $DelayInSeconds
                    $Retrycount++
                }
            }
            404 {
                if ($requestUrl -ne $OpenApiServiceUrl) {
                    Write-Warning "Operation-ID reference request to $requestUrl returned 404."
                    throw
                }
                Write-Warning "Request to $requestUrl returned 404. Download will be skipped."
                $Completed = $true
            }
            default {
                # Get HTTP error message from DevX api, Re-throw error to be handled Upstream
                $ErrorMessage = $Exception.Message
                Write-Warning "[$RequestCount] Request to $requestUrl for $ModuleName failed with error message: $ErrorMessage"
                throw
            }
        }
    }
}

if ($Downloaded -and -not $DeferPruning) {
    & (Join-Path $PSScriptRoot 'Remove-ExpiredDeprecatedOpenApiOperations.ps1') `
        -OpenApiFilesPath $outputPath
}
