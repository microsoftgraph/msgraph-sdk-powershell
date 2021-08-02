# ------------------------------------------------------------------------------
#  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
# ------------------------------------------------------------------------------
Set-StrictMode -Version 6.0

$permissions_MsGraphServicePrincipal = $null

function isFromMgGraphRequest {
    $permissions_fromInvokeMgGraphRequest
}
function Permissions_GetPermissionsData {
    param (
        [bool] $online
    )

    #$permissions_MsGraphServicePrincipal = $null
    $requestError = $null
    #$permissions_FromInvokeMgGraphRequest = $false

    # 2. Making a REST request to MS Graph

    if (($null -eq $permissions_MsGraphServicePrincipal) -or ($null -ne $permissions_MsGraphServicePrincipal -and $permissions_FromInvokeMgGraphRequest -eq $false)) {
        $permissions_MsGraphServicePrincipal = try {

            # Write-Host "Getting data from web service"
            $result = Invoke-MgGraphRequest -method GET 'https://graph.microsoft.com/v1.0/servicePrincipals?filter=appId eq ''00000003-0000-0000-c000-000000000000''' 
            
            if ($null -ne $result) {
                $result | select-object -expandproperty value 
                $permissions_FromInvokeMgGraphRequest = $true
            }

        } catch [System.Management.Automation.ValidationMetadataException] {

            $requestError = $_
            Get-Content $PSScriptRoot/MSGraphServicePrincipalPermissions.json | Out-String | ConvertFrom-Json
            $permissions_FromInvokeMgGraphRequest = $false
        
        } catch [System.Net.Http.HttpRequestException] {

            $requestError = $_
            Get-Content $PSScriptRoot/MSGraphServicePrincipalPermissions.json | Out-String | ConvertFrom-Json
            $permissions_FromInvokeMgGraphRequest = $false
        
        }
    } elseif ($fromInvokeMgGraphRequest -eq $true) {
        $permissions_MsGraphServicePrincipal
    }

    if ($requestError -and $online) {
        Write-Error $requestError -ErrorAction Stop
    }
    
    # 3. Parse the permisions from the serviceprincipal
    $msOauth = $permissions_MsGraphServicePrincipal.oauth2PermissionScopes
    $msAppRoles = $permissions_MsGraphServicePrincipal.appRoles

    # make sure the parsed permissions are exported properly
    @{
        oauth2 = $msOauth;
        appRoles = $msAppRoles
    }

}

# Search based on user input
function Permissions_GetOauthData {
    param (
        [bool] $online
    )
    
    if ($online){

        $permissions = Permissions_GetPermissionsData $online
        $msOauth = $permissions.oauth2

    } else {

        $permissions = Permissions_GetPermissionsData
        $msOauth = $permissions.oauth2
        
    }
    
    ForEach ($oauth2grant in $msOauth) {

        $description = If ($oauth2grant.type -eq "Admin") { 
        
            $oauth2grant.adminConsentDescription
        
        } elseif ($oauth2grant.type -eq "User") {
        
            $oauth2grant.userConsentDescription
        
        }
        
        $entry = [ordered] @{
            "Id" = $oauth2grant.id
            "PermissionType" = 'Delegated'
            "Consent" = $oauth2grant.type
            "Name" = $oauth2grant.value
            "Description" = $description
        }
        $permissions = [PSCustomObject] $entry
        $permissions.PSTypeNames.Insert(0, 'Microsoft.Graph.Custom.Permission')
        $permissions

    }
}

function Permissions_GetAppRolesData {
    param (
        [bool] $online
    )
    
    if ($online){

        $permissions = Permissions_GetPermissionsData $online
        $msAppRoles = $permissions.appRoles

    } else {

        $permissions = Permissions_GetPermissionsData
        $msAppRoles = $permissions.appRoles

    } 
    
    ForEach ($approle in $msAppRoles) {

        $consent = If ($approle.origin -eq "Application") { 
            "Admin"
        } elseif ($approle.origin -eq "Delegated") {
            "User"
        }

        $entry = [ordered] @{
            "Id" = $approle.id
            "PermissionType" = 'Application'
            "Consent" = $consent
            "Name" = $approle.value
            "Description" = $approle.description
        }
        $permissions = [PSCustomObject] $entry
        $permissions.PSTypeNames.Insert(0, 'Microsoft.Graph.Custom.Permission')
        $permissions
    }
}
