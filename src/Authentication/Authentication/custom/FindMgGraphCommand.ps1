
# ------------------------------------------------------------------------------
#  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
# ------------------------------------------------------------------------------

Set-StrictMode -Version 2

function Find-MgGraphCommand {
    [OutputType([System.Management.Automation.PSCustomObject])]
    [CmdletBinding(DefaultParameterSetName = 'FindByUrl', PositionalBinding=$false)]
    param (
        [Parameter(ParameterSetName = "FindByUrl", Mandatory = $true)]
        [string]
        $Url,

        [Parameter(ParameterSetName = "FindByUrl", Mandatory = $true)]
        [ValidateSet("GET", "POST", "PUT", "PATCH", "DELETE")]
        [string]
        $Method = "GET",

        [Parameter(ParameterSetName = "FindByUrl")]
        [Parameter(ParameterSetName = "FindByCommand")]
        [Alias("Profile")]
        [string]
        $ApiVersion,

        [Parameter(ParameterSetName = "FindByCommand", Mandatory = $true)]
        [string]
        $Command
    )

    $MgCommandMetadataFile = (Join-Path $PSScriptRoot "..\..\..\..\assets\MgCommandMetadata.json")
    if (!(Test-Path $MgCommandMetadataFile)) {
        Write-Error "MgCommandMetadata file not found."
    }
    $MgCommandMetadata = Get-Content -path $MgCommandMetadataFile | ConvertFrom-Json -AsHashtable
    $FindMatch = [System.Collections.ArrayList]@()
    if ($PSCmdlet.ParameterSetName -eq "FindByUrl") {
        if ($Url -match "https:\/\/graph.microsoft.com\/(v1.0|beta)(\/.*)(\?(.*))?") {
            $ApiVersion = $matches[1]
            $ResourceSegement = $matches[2]
            # TODO: Handle query parameters.
            $QueryParameters = $matches[3]
            $RegexResourceSegement = "^$($ResourceSegement -Replace '(?<={)(.*?)(?=})', '.*')$"
        }
        else {
            Write-Error "The provided URL doesn't match the expected URL format. Please ensure that the URL is formated as https://graph.microsoft.com/{api-version}/{resource}."
        }
        Write-Host "REGEX: $RegexResourceSegement" -ForegroundColor yellow

        $MgCommandMetadata.GetEnumerator() | ForEach-Object {
            $CommandPath = $_.Value
            if ($CommandPath.Method -eq $Method -and
                $CommandPath.ApiVersion -eq $ApiVersion -and
                $CommandPath.Url -match $RegexResourceSegement) {
                $null = $FindMatch.Add($CommandPath)
            }
        }
    }
    else {
        $MgCommandMetadata.GetEnumerator() | ForEach-Object {
            $CommandPath = $_.Value
            if ($CommandPath.ApiVersion -eq $ApiVersion -and
                $CommandPath.Command -eq $Command) {
                $null = $FindMatch.Add($CommandPath)
            }
        }
    }

    if ($FindMatch.Count -ge 1) {
        Write-Host "Command: $($FindMatch[0].Command)" -ForegroundColor green
        Write-Host "Module: Microsoft.Graph.$($FindMatch[0].Module)" -ForegroundColor green
        Write-Host "Profile: $($FindMatch[0].ApiVersion)" -ForegroundColor green
        Write-Host "Returns: $($FindMatch[0].OutputType)" -ForegroundColor green
        Write-Host "Url: $($FindMatch[0].Url)" -ForegroundColor green
    }
    else {
        Write-Warning "Command not found!"
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