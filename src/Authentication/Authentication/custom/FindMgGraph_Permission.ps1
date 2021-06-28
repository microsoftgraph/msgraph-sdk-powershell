# ------------------------------------------------------------------------------
#  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
# ------------------------------------------------------------------------------

Set-StrictMode -Version 2

<#
.SYNOPSIS
Find permissions for authorization against Microsoft Graph
#>
$msgraphServicePrincipal = $null

# 1. Signing into any AAD organization

# Import-Module -Force .\Microsoft.Graph.Authentication.psd1
function Connect{
    Connect-MgGraph -Scopes Directory.AccessAsUSer.All
}
function GetPermissionsData {

    # 2. Making a REST request to MS Graph
    if ($null -eq $script:msgraphServicePrincipal){
        $script:msgraphServicePrincipal = try {

            Write-Host "Getting data from web service"

            Invoke-MgGraphRequest -method GET 'https://graph.microsoft.com/v1.0/servicePrincipals?filter=appId eq ''00000003-0000-0000-c000-000000000000''' | select-object -expandproperty value

        } catch {

            Write-Host "Getting data from local file"
            Get-Content ~/datasample.json | Out-String | ConvertFrom-Json
        
        }
    }
    # 3. Parse the permisions from the serviceprincipal
    $msOauth = $msgraphServicePrincipal.oauth2PermissionScopes
    $msAppRoles = $msgraphServicePrincipal.appRoles

    @{
        oauth2 = $msOauth;
        appRoles = $msAppRoles
    }

}

# 4. Search based on user input
function Find-MgGraphPermission($search) {
    
    Connect
    $permissions = GetPermissionsData
    $permissions.oauth2 | Select-Object id, value, type, userConsentDescription | Where-Object value -like *$search* 
    $permissions.appRoles | Select-Object id, value, origin, description | Where-Object value -like *$search*

}