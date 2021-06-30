# ------------------------------------------------------------------------------
#  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
# ------------------------------------------------------------------------------

Set-StrictMode -Version 2

<#
.SYNOPSIS
Find permissions for authorization against Microsoft Graph
#>

. "$psscriptroot/common/Permissions.ps1"

# 1. Signing into any AAD organization

# Import-Module -Force .\Microsoft.Graph.Authentication.psd1

# Setting a empty entity to store the imported data
$msgraphServicePrincipal = $null

function GetPermissionsData {

    # 2. Making a REST request to MS Graph
    if ($null -eq $script:Permissions_MsGraphServicePrincipal){
        $script:Permissions_MsGraphServicePrincipal = try {

            Write-Host "Getting data from web service"
            Invoke-MgGraphRequest -method GET 'https://graph.microsoft.com/v1.0/servicePrincipals?filter=appId eq ''00000003-0000-0000-c000-000000000000''' | select-object -expandproperty value

        } catch {

            Write-Host "Getting data from local file"
            Get-Content ~/datasample.json | Out-String | ConvertFrom-Json
        
        }
    }
    # 3. Parse the permisions from the serviceprincipal
    $msOauth = $script:Permissions_MsGraphServicePrincipal.oauth2PermissionScopes
    $msAppRoles = $script:Permissions_MsGraphServicePrincipal.appRoles

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
