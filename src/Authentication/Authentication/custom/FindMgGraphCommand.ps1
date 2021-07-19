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
            Write-Error "MgCommandMetadata file not found."
        }
        $MgCommandMetadata = Get-Content -path $MgCommandMetadataFile | ConvertFrom-Json -AsHashtable

        $CurrentAPIVersion = (Get-MgProfile).Name ?? "v1.0"
        $CurrentGraphEndpoint = ([Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.Environment)?.GraphEndpoint ?? "https://graph.microsoft.com/"

        switch ($PSCmdlet.ParameterSetName) {
            "FindByUrl" {
                $Uri = $Uri.TrimStart("/").TrimEnd("/")
                $GraphUri = $null
                if (![System.Uri]::TryCreate($Uri, "RelativeOrAbsolute", [ref]$GraphUri) -and ($null -eq $GraphUri)) {
                    Write-Error "The provided URI doesn't match the expected URI format. Please ensure that the URI is formated as https://graph.microsoft.com/{api-version}/{resource}."
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
                    $GraphUri = $UriBuilder.Uri
                }

                Write-Debug "Resolved URI: $($GraphUri.ToString())"
                $SanitizedUri = $GraphUri.GetComponents([System.UriComponents]::SchemeAndServer, [System.UriFormat]::SafeUnescaped)
                $GraphUri.Segments | ForEach-Object {
                    $i = $GraphUri.Segments.IndexOf($_);
                    if ($_ -match "[^v1.0|beta]\d") {
                        # Segment contains an integer and is not API version (v1.0 or beta).
                        # $Uri = New-Object uri -ArgumentList "https://graph.ms/v1.0/users/fe9ee2a5-9450-4837-aa87-6bd8d8e72891/me"
                        # $uri.Segments | %{ if ($_ -match "[^v1.0|beta]\d") {$i = $Uri.Segments.IndexOf($_); $uri.Segments[$i] = "{id}";}
                        #TODO: Tokenize URLs with integers by replacing the substring that has the integers with {id}, e.g, /users/289ee2a5-9450-4837-aa87-6bd8d8e72891 -> users/{id}
                        $SanitizedUri += "{id}/"
                    }
                    else {
                        $SanitizedUri += $GraphUri.Segments[$i]
                    }
                }
                $SanitizedUri = $SanitizedUri.TrimEnd("/")
                if ($SanitizedUri -match "https:\/\/$($GraphUri.Host)\/(v1.0|beta)(\/.*)(\?(.*))?") {
                    $ApiVersion = $ApiVersion ?? $matches[1]
                    $ResourceSegement = $matches[2]
                    # TODO: Handle query parameters.
                    $QueryParameters = $matches[3]
                    $RegexResourceSegement = "^$($ResourceSegement -Replace '(?<={)(.*?)(?=})', '(\w*-\w*|\w*)')$"
                }
                else {
                    Write-Error "The provided URL doesn't match the expected URL format. Please ensure that the URL is formated as https://graph.microsoft.com/{api-version}/{resource}."
                }
            }
            "FindByCommand" {
                $ApiVersion = $ApiVersion ?? $CurrentAPIVersion
            }
        }
    }

    process {
        $Result = [System.Collections.ArrayList]@()
        switch ($PSCmdlet.ParameterSetName) {
            "FindByUrl" {
                Write-Host "REGEX: $RegexResourceSegement" -ForegroundColor yellow
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
                    Write-Error "URL '$Method $GraphUri' in $ApiVersion is not valid or is not currently supported by the SDK. Please file an issue here https://aka.ms/msgraph-ps-bug for this to be added."
                }
            }
            "FindByCommand" {
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
                        $CommandPath.Command -eq $Command) {
                        $null = $Result.Add($CommandPath)
                    }
                }

                if ($Result.Count -lt 1) {
                    Write-Error "‘$Command’ is not a valid Microsoft Graph PowerShell command. Please check the name and try again."
                }
            }
        }
        Write-Output $Result
    }

    end {

    }
}

# TEST DATA
# Find-MgGraphCommand -Command "Get-MgUser" -ApiVersion "beta"

# Find-MgGraphCommand -Uri "https://graph.microsoft.com/v1.0/users/{id}/microsoft.graph.exportPersonalData" -Method "POST"
# Find-MgGraphCommand -Uri "https://graph.microsoft.com/beta/identityGovernance/entitlementManagement/accessPackageCatalogs" -Method POST
# Find-MgGraphCommand -Uri "https://graph.microsoft.com/v1.0/users" -Method GET
# Find-MgGraphCommand -Uri "https://graph.microsoft.com/beta/identityGovernance/entitlementManagement/accessPackageAssignmentResourceRoles/{id}" -Method GET
# Find-MgGraphCommand -Uri "https://graph.microsoft.com/beta/identityGovernance/entitlementManagement/accessPackageCatalogs" -Method POST


# Find-MgGraphCommand -Uri "https://graph.microsoft.com/v1.0/users?$select=displayName,id&$filter=identities/any(c:c/issuerAssignedId eq 'j.smith@yahoo.com' and c/issuer eq 'contoso.onmicrosoft.com')" -Method GET