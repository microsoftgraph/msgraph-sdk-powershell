# ------------------------------------------------------------------------------
#  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
# ------------------------------------------------------------------------------

Set-StrictMode -Version 2

<#
.SYNOPSIS
Find permissions for authorization against Microsoft Graph
#>

. "$psscriptroot/common/Permissions.ps1"

# Signing into any AAD organization

# Import-Module -Force .\Microsoft.Graph.Authentication.psd1

function Find-MgGraphPermission($search) {
    
    GetOauthData | Where-Object Name -like *$search* 
    GetAppRolesData | Where-Object Name -like *$search*

}
