# ------------------------------------------------------------------------------
#  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
# ------------------------------------------------------------------------------

Set-StrictMode -Version 2
function Find-MgGraphCommand {
    [OutputType([Microsoft.Graph.PowerShell.Authentication.Models.IGraphCommand])]
    [CmdletBinding(DefaultParameterSetName = 'FindByUri', PositionalBinding = $false)]
    param (
        [Parameter(ParameterSetName = "FindByUri", Mandatory = $true)]
        [string]$Uri,

        [Parameter(ParameterSetName = "FindByUri")]
        [ValidateSet("GET", "POST", "PUT", "PATCH", "DELETE")]
        [string]$Method,

        [Parameter(ParameterSetName = "FindByUri")]
        [Parameter(ParameterSetName = "FindByCommand")]
        [ValidateSet("v1.0", "beta")]
        [Alias("Profile")]
        [string]$ApiVersion,

        [Parameter(ParameterSetName = "FindByCommand", Mandatory = $true)]
        [string]$Command
    )

    begin {
        # Import ulility scripts.
        . "$PSScriptRoot/common/Json.ps1" | Out-Null

        $MgCommandMetadataFile = (Join-Path $PSScriptRoot "./common/MgCommandMetadata.json")
        if (!(Test-Path $MgCommandMetadataFile)) {
            throw "MgCommandMetadata file not found at $MgCommandMetadataFile."
        }

        # Read content of metadata file and cache in session object.
        if ($null -ne [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance -and
            $null -ne [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.MgCommandMetadata) {
            Write-Debug "Reading MgCommandMetadata from session object."
        }
        else {
            Write-Debug "Reading MgCommandMetadata from file path - $MgCommandMetadataFile."
            [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.MgCommandMetadata = Json_ConvertJsonToHashtable $MgCommandMetadataFile
        }

        $GraphHostURL = "https://graph.microsoft.com/"
        switch ($PSCmdlet.ParameterSetName) {
            "FindByUri" {
                Write-Debug "Received URI: $Uri."
                $Uri = $Uri.TrimStart("/", "\").TrimEnd("/", "\")
                $Uri = [System.Uri]::UnescapeDataString($Uri)
                $GraphUri = $null
                if (![System.Uri]::TryCreate($Uri, "RelativeOrAbsolute", [ref]$GraphUri) -and ($null -eq $GraphUri)) {
                    throw "The provided URI doesn't match the expected URI format. Please ensure the URI is formated as 'https://graph.microsoft.com/{api-version}/{resource}'."
                }

                # Use API version in URI if -ApiVersion is not provided.
                if ([System.String]::IsNullOrWhiteSpace($ApiVersion) -and ($GraphUri.OriginalString -match "(v1.0|beta)\/")) {
                    $ApiVersion = $Matches[1]
                }

                if (!$GraphUri.IsAbsoluteUri) {
                    # Add schema and host.
                    $UriBuilder = New-Object System.UriBuilder -ArgumentList $GraphHostURL
                    if ($Uri.StartsWith("v1.0") -or $Uri.StartsWith("beta")) {
                        $UriBuilder.Path = $Uri
                    }
                    else {
                        if ([System.String]::IsNullOrWhiteSpace($ApiVersion)) { $CurrentAPIVersion = (Get-MgProfile).Name } else { $CurrentAPIVersion = $ApiVersion }
                        $UriBuilder.Path = "$CurrentAPIVersion/$Uri"
                    }
                    $GraphUri = New-Object -TypeName Uri -ArgumentList ([System.Uri]::UnescapeDataString($UriBuilder.Uri))
                }
                Write-Debug "Resolved URI: $GraphUri."

                $SanitizedUri = $GraphUri.GetComponents([System.UriComponents]::SchemeAndServer, [System.UriFormat]::SafeUnescaped)
                for ($i = 0 ; $i -lt $GraphUri.Segments.length; $i++) {
                    # Segment contains an integer/id and is not API version.
                    if ($GraphUri.Segments[$i] -match "[^v1.0|beta]\d") {
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
                    $ResourceSegement = $matches[2]
                    $RegexResourceSegement = "^$($ResourceSegement -Replace '(?<={)(.*?)(?=})', '(\w*-\w*|\w*)')$"
                }
                else {
                    throw "The provided URI doesn't match the expected URI format. Please ensure the URI is formated as 'https://graph.microsoft.com/{api-version}/{resource}'."
                }
            }
        }
    }

    process {
        $Result = @()
        try {
            switch ($PSCmdlet.ParameterSetName) {
                "FindByUri" {
                    Write-Debug "Matching URI: $RegexResourceSegement"
                    Write-Debug "Matching Method: $Method"
                    Write-Debug "Matching ApiVersion: $ApiVersion"
                    [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.MgCommandMetadata | ForEach-Object {
                        if ($_.Method -match $Method -and
                            $_.ApiVersion -match $ApiVersion -and
                            $_.Uri -match $RegexResourceSegement) {
                            $Result += [Microsoft.Graph.PowerShell.Authentication.Models.GraphCommand]$_
                        }
                    }
                    if ($Result.Count -lt 1) {
                        Write-Error "URI '$Method $GraphUri' in $ApiVersion is not valid or is not currently supported by the SDK. Ensure the URI is formated correctly and try again."
                    }
                }
                "FindByCommand" {
                    Write-Debug "Matching Command: $Command"
                    Write-Debug "Matching ApiVersion: $ApiVersion"
                    [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.MgCommandMetadata | ForEach-Object {
                        if ($_.ApiVersion -match $ApiVersion -and
                            $_.Command -match "^$Command$") {
                            $Result += [Microsoft.Graph.PowerShell.Authentication.Models.GraphCommand]$_
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
        return $Result | Sort-Object @{Expression = "APIVersion"; Descending = $True }, @{Expression = "Command"; Descending = $False }
    }
}