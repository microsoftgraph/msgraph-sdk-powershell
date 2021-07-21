# ------------------------------------------------------------------------------
#  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
# ------------------------------------------------------------------------------

Set-StrictMode -Version 2

function Find-MgGraphCommand {
    [OutputType([System.Management.Automation.PSCustomObject])]
    [CmdletBinding(DefaultParameterSetName = 'FindByUrl', PositionalBinding = $false)]
    param (
        [Parameter(ParameterSetName = "FindByUrl", Mandatory = $true)]
        [string]$Uri,

        [Parameter(ParameterSetName = "FindByUrl")]
        [ValidateSet("GET", "POST", "PUT", "PATCH", "DELETE")]
        [string]$Method = "GET",

        [Parameter(ParameterSetName = "FindByUrl")]
        [Parameter(ParameterSetName = "FindByCommand")]
        [ValidateSet("v1.0", "beta")]
        [Alias("Profile")]
        [string]$ApiVersion,

        [Parameter(ParameterSetName = "FindByCommand", Mandatory = $true)]
        [string]$Command
    )

    begin {
        # Read content of metadata file.
        $MgCommandMetadataFile = (Join-Path $PSScriptRoot "..\..\..\..\assets\MgCommandMetadata.json")
        if (!(Test-Path $MgCommandMetadataFile)) {
            throw "MgCommandMetadata file not found at $MgCommandMetadataFile."
        }

        # Read and cache MgCommandMetadata in session object.
        if ($null -ne [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance?.MgCommandMetadata) {
            Write-Debug "Reading MgCommandMetadata from session object."
            $MgCommandMetadata = [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.MgCommandMetadata
        }
        else {
            try {
                Write-Debug "Reading MgCommandMetadata from file path - $MgCommandMetadataFile."
                $FileProvider = [Microsoft.Graph.PowerShell.Authentication.Common.ProtectedFileProvider]::CreateFileProvider($MgCommandMetadataFile, [Microsoft.Graph.PowerShell.Authentication.Common.FileProtection]::SharedRead)
                $MgCommandMetadata = $FileProvider.CreateReader().ReadToEnd() | ConvertFrom-Json -AsHashtable
                [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.MgCommandMetadata = $MgCommandMetadata
            }
            finally {
                $FileProvider.Dispose()
            }
        }

        $CurrentAPIVersion = (Get-MgProfile).Name ?? "v1.0"
        $CurrentGraphEndpoint = ([Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.Environment)?.GraphEndpoint ?? "https://graph.microsoft.com/"

        switch ($PSCmdlet.ParameterSetName) {
            "FindByUrl" {
                Write-Debug "Received URI: $Uri."
                $Uri = $Uri.TrimStart("/").TrimEnd("/")
                $Uri = [System.Uri]::UnescapeDataString($Uri)
                $GraphUri = $null
                if (![System.Uri]::TryCreate($Uri, "RelativeOrAbsolute", [ref]$GraphUri) -and ($null -eq $GraphUri)) {
                    throw "The provided URI doesn't match the expected URI format. Please ensure that the URI is formated as https://graph.microsoft.com/{api-version}/{resource}."
                }

                if (!$GraphUri.IsAbsoluteUri) {
                    # Add schema and host.
                    $UriBuilder = New-Object System.UriBuilder -ArgumentList $CurrentGraphEndpoint
                    if ($Uri.StartsWith("v1.0") -or $Uri.StartsWith("beta")) {
                        $UriBuilder.Path = $Uri
                    }
                    else {
                        $UriBuilder.Path = "$CurrentAPIVersion/$Uri"
                    }
                    $GraphUri = New-Object -TypeName Uri -ArgumentList ([System.Uri]::UnescapeDataString($UriBuilder.Uri))
                }

                Write-Debug "Resolved URI: $GraphUri."
                $SanitizedUri = $GraphUri.GetComponents([System.UriComponents]::SchemeAndServer, [System.UriFormat]::SafeUnescaped)
                $GraphUri.Segments | ForEach-Object {
                    $i = $GraphUri.Segments.IndexOf($_)
                    # Segment contains an integer/id and is not API version.
                    if ($_ -match "[^v1.0|beta]\d") {
                        # Substitute integers/ids with {id} tokens, e.g, /users/289ee2a5-9450-4837-aa87-6bd8d8e72891 -> users/{id}.
                        $SanitizedUri += "{id}/"
                    }
                    else {
                        $SanitizedUri += $GraphUri.Segments[$i]
                    }
                }
                $SanitizedUri = $SanitizedUri.TrimEnd("/")
                Write-Debug "Sanitized URI: $SanitizedUri."
                if ($SanitizedUri -match "https:\/\/$($GraphUri.Host)\/(v1.0|beta)(\/.*)(\?(.*))?") {
                    $ApiVersion = [System.String]::IsNullOrWhiteSpace($ApiVersion) ? $matches[1] : $ApiVersion
                    $ResourceSegement = $matches[2]
                    $RegexResourceSegement = "^$($ResourceSegement -Replace '(?<={)(.*?)(?=})', '(\w*-\w*|\w*)')$"
                }
                else {
                    Write-Error "The provided URL doesn't match the expected URL format. Please ensure that the URL is formated as https://graph.microsoft.com/{api-version}/{resource}."
                }
            }
            "FindByCommand" {
                $ApiVersion = [System.String]::IsNullOrWhiteSpace($ApiVersion) ? $CurrentAPIVersion : $ApiVersion
            }
        }
    }

    process {
        $Result = [System.Collections.ArrayList]@()
        try {
            switch ($PSCmdlet.ParameterSetName) {
                "FindByUrl" {
                    Write-Debug "Matching URI: $RegexResourceSegement"
                    Write-Debug "Matching Method: $Method"
                    Write-Debug "Matching ApiVersion: $ApiVersion"
                    $MgCommandMetadata.GetEnumerator() | ForEach-Object {
                        $CommandPath = [PSCustomObject]@{
                            Command    = $_.Value.Command
                            Variants   = $_.Value.Variants
                            URL        = $_.Value.Url
                            Method     = $_.Value.Method
                            APIVersion = $_.Value.ApiVersion
                            OutputType = $_.Value.OutputType
                        }
                        if ($CommandPath.Method -eq $Method -and
                            $CommandPath.ApiVersion -eq $ApiVersion -and
                            $CommandPath.Url -match $RegexResourceSegement) {
                            $null = $Result.Add($CommandPath)
                        }
                    }
                    if ($Result.Count -lt 1) {
                        Write-Error "URL '$Method $GraphUri' in $ApiVersion is not valid or is not currently supported by the SDK. Ensure the URI is formated correctly and try again."
                    }
                }
                "FindByCommand" {
                    Write-Debug "Matching Command: $Command"
                    Write-Debug "Matching ApiVersion: $ApiVersion"
                    $MgCommandMetadata.GetEnumerator() | ForEach-Object {
                        $CommandPath = [PSCustomObject]@{
                            Command    = $_.Value.Command
                            Variants   = $_.Value.Variants
                            URL        = $_.Value.Url
                            Method     = $_.Value.Method
                            APIVersion = $_.Value.ApiVersion
                            OutputType = $_.Value.OutputType
                        }
                        if ($CommandPath.ApiVersion -eq $ApiVersion -and
                            $CommandPath.Command -match "^$Command$") {
                            $null = $Result.Add($CommandPath)
                        }
                    }

                    if ($Result.Count -lt 1) {
                        Write-Error "'$Command' is not a valid Microsoft Graph PowerShell command. Please check the name and try again."
                    }
                }
            }
        }
        catch {
            Write-Error $_.Exception
        }
        Write-Output $Result
    }

    end {

    }
}