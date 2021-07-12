
# ------------------------------------------------------------------------------
#  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
# ------------------------------------------------------------------------------

Set-StrictMode -Version 2

function Find-MgGraphCommand {
    [OutputType([System.Management.Automation.PSCustomObject])]
    [CmdletBinding(DefaultParameterSetName = 'FindByUrl', PositionalBinding = $false)]
    param (
        [Parameter(ParameterSetName = "FindByUrl", Mandatory = $true)]
        [string]$Url,

        [Parameter(ParameterSetName = "FindByUrl")]
        [ValidateSet("GET", "POST", "PUT", "PATCH", "DELETE")]
        [string]$Method = "GET",

        [Parameter(ParameterSetName = "FindByUrl")]
        [Parameter(ParameterSetName = "FindByCommand")]
        [Alias("Profile")]
        [string]$ApiVersion,

        [Parameter(ParameterSetName = "FindByCommand", Mandatory = $true)]
        [string]$Command
    )

    begin {

    }

    process {
        $MgCommandMetadataFile = (Join-Path $PSScriptRoot "..\..\..\..\assets\MgCommandMetadata.json")
        if (!(Test-Path $MgCommandMetadataFile)) {
            Write-Error "MgCommandMetadata file not found."
        }
        $MgCommandMetadata = Get-Content -path $MgCommandMetadataFile | ConvertFrom-Json -AsHashtable
        $Result = [System.Collections.ArrayList]@()
        if ($PSCmdlet.ParameterSetName -eq "FindByUrl") {
            #TODO: Trim trailing "/" in URLs.
            #TODO: Tokenize URLs with integers by replacing the substring that has the integers with {id}, e.g, /users/289ee2a5-9450-4837-aa87-6bd8d8e72891 -> users/{id}
            if ($Url -match "https:\/\/graph.microsoft.com\/(v1.0|beta)(\/.*)(\?(.*))?") {
                $ApiVersion = $matches[1]
                $ResourceSegement = $matches[2]
                # TODO: Handle query parameters.
                $QueryParameters = $matches[3]
                $RegexResourceSegement = "^$($ResourceSegement -Replace '(?<={)(.*?)(?=})', '(\w*-\w*|\w*)')$"
            }
            else {
                Write-Error "The provided URL doesn't match the expected URL format. Please ensure that the URL is formated as https://graph.microsoft.com/{api-version}/{resource}."
            }
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
                Write-Error "URL '$Method $Url' in $ApiVersion is not valid or is not currently supported by the SDK. Please file an issue here https://aka.ms/msgraph-ps-bug for this to be added."
            }
        }
        else {
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

        Write-Output $Result
    }

    end {

    }
}

# TEST DATA
# .\FindMgCommand.ps1 -Command "Get-MgUser" -ApiVersion "beta"

# .\FindMgCommand.ps1 -Url "https://graph.microsoft.com/v1.0/users/{id}/microsoft.graph.exportPersonalData" -Method "POST"
# .\FindMgCommand.ps1 -Url "https://graph.microsoft.com/beta/identityGovernance/entitlementManagement/accessPackageCatalogs" -Method POST
# .\FindMgCommand.ps1 -Url "https://graph.microsoft.com/v1.0/users" -Method GET
# .\FindMgCommand.ps1 -Url https://graph.microsoft.com/beta/identityGovernance/entitlementManagement/accessPackageAssignmentResourceRoles/{id} -Method GET
# .\FindMgCommand.ps1 -Url https://graph.microsoft.com/beta/identityGovernance/entitlementManagement/accessPackageCatalogs -Method POST


# .\FindMgCommand.ps1 -Url "https://graph.microsoft.com/v1.0/users?$select=displayName,id&$filter=identities/any(c:c/issuerAssignedId eq 'j.smith@yahoo.com' and c/issuer eq 'contoso.onmicrosoft.com')" -Method GET