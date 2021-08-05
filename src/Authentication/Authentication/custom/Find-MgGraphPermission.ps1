# ------------------------------------------------------------------------------
#  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
# ------------------------------------------------------------------------------

Set-StrictMode -Version 6.0

. "$psscriptroot/common/Permissions.ps1"

<#
.SYNOPSIS
Find permissions for authorization against Microsoft Graph
#>
function Find-MgGraphPermission {
    [cmdletbinding()]
    [OutputType('Microsoft.Graph.Custom.Permission')]
    param (
        [string] $SearchString,
        [switch] $Online
    )

    $permissionsData = Permissions_GetPermissionsData $online

    # Creating a table specifically for Oauth2permissions data
    $oauthData = @()
    $oauthData += Permissions_GetOauthData $permissionsData | Where-Object Name -like *$SearchString*
    $oauthData | Sort-Object -Property Name

    # Creating a table specifically for appRoles data
    $appRolesData = @()
    $appRolesData += Permissions_GetAppRolesData $permissionsData | Where-Object Name -like *$SearchString*
    $appRolesData | Sort-Object -Property Name
}
