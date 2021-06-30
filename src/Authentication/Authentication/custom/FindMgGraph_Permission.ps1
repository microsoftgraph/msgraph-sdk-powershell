# ------------------------------------------------------------------------------
#  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
# ------------------------------------------------------------------------------

Set-StrictMode -Version 2

<#
.SYNOPSIS
Find permissions for authorization against Microsoft Graph
#>

# Import-Module -Force .\Microsoft.Graph.Authentication.psd1

# Setting a empty entity to store the imported data
$msgraphServicePrincipal = $null

function GetPermissionsData {

    # Making a REST request to MS Graph both locally and through the web service
    if ($null -eq $script:msgraphServicePrincipal){
        $script:msgraphServicePrincipal = try {

            Write-Host "Getting data from web service"
            Invoke-MgGraphRequest -method GET 'https://graph.microsoft.com/v1.0/servicePrincipals?filter=appId eq ''00000003-0000-0000-c000-000000000000''' | select-object -expandproperty value

        } catch {

            Write-Host "Getting data from local file"
            Get-Content ~/datasample.json | Out-String | ConvertFrom-Json
        
        }
    }
    # Parse the permisions from the serviceprincipal
    $msOauth = $msgraphServicePrincipal.oauth2PermissionScopes
    $msAppRoles = $msgraphServicePrincipal.appRoles

    # make sure the parsed permissions are exported properly
    @{
        oauth2 = $msOauth;
        appRoles = $msAppRoles
    }

}

# Search based on user input
function GetOauthData {

    $permissions = GetPermissionsData
    $msOauth = $permissions.oauth2
    
    ForEach ($oauth2grant in $msOauth) {

        $description = $null

        $description = If ($oauth2grant.type -eq "Admin") { 
        
            $description = $oauth2grant.adminConsentDescription
        
        } elseif ($oauth2grant.type -eq "User") {
        
            $description = $oauth2grant.userConsentDescription
        
        }
        
        $entry = [ordered] @{
            
            "Id" = $oauth2grant.id
            "PermissionType" = $oauth2grant.type
            "Name" = $oauth2grant.value
            "Description" = $description
        
        }

        [PSCustomObject] $entry

    }
}

function GetAppRolesData {
    
    $permissions = GetPermissionsData
    $msAppRoles = $permissions.appRoles 
    
    ForEach ($oauth2grant in $msAppRoles) {

        $entry = [ordered] @{
            "Id" = $oauth2grant.id
            "PermissionType" = $oauth2grant.origin
            "Name" = $oauth2grant.value
            "Description" = $oauth2grant.description
        }
        [PSCustomObject] $entry

    }
}

function Find-MgGraphPermission($search) {
    
    GetOauthData | Where-Object Name -like *$search* 
    GetAppRolesData | Where-Object Name -like *$search*

}