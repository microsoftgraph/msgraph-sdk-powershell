# ------------------------------------------------------------------------------
#  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
# ------------------------------------------------------------------------------
Set-StrictMode -Version 6.0

# Models the state of the permissions 'class'. Pester alters runtime behavior
# so that variables defined at script scope do not actually show up at script
# scope via 'script:' at runtime (!), so we'll just wrap those variables
# in one that does not require the modifier. This is actually a better way
# to encapuslate class (or even instance) state anyway.
$_permissions = [PSCustomObject] @{
    msGraphServicePrincipal = $null
    isFromInvokeMgGraphRequest = $false
}

# These '_' functions are provided for tests to simulate the initial state of the class
# as well as providing visibility into its state for deeper validations
function _Permissions_Initialize {
    $_permissions.msGraphServicePrincipal = $null
    $_permissions.isFromInvokeMgGraphRequest = $false
}

function _Permissions_State {
    $_permissions
}

function Permissions_GetPermissionsData {
    param (
        [bool] $online
    )

    $requestError = $null
    
    # 2. Making a REST request to MS Graph

    if ($online -or !$_permissions.msGraphServicePrincipal -or !$_permissions.isFromInvokeMgGraphRequest) {
        try {
            $result = Invoke-MgGraphRequest -method GET 'https://graph.microsoft.com/v1.0/servicePrincipals?filter=appId eq ''00000003-0000-0000-c000-000000000000'''

            if ($result) {
                $_permissions.msGraphServicePrincipal = $result | select-object -expandproperty value
                $_permissions.isFromInvokeMgGraphRequest = $true
            }
        } catch [System.Management.Automation.ValidationMetadataException] {
            $requestError = $_
            $_permissions.msGraphServicePrincipal = Get-Content $PSScriptRoot/MSGraphServicePrincipalPermissions.json | Out-String | ConvertFrom-Json
            $_permissions.isFromInvokeMgGraphRequest = $false
        } catch [System.Net.Http.HttpRequestException] {
            $requestError = $_
            $_permissions.msGraphServicePrincipal = Get-Content $PSScriptRoot/MSGraphServicePrincipalPermissions.json | Out-String | ConvertFrom-Json
            $_permissions.isFromInvokeMgGraphRequest = $false
        }
    }

    if ($requestError -and $online) {
        Write-Error $requestError -ErrorAction Stop
    }

    # 3. Parse the permisions from the serviceprincipal
    $msOauth = $_permissions.msGraphServicePrincipal.oauth2PermissionScopes
    $msAppRoles = $_permissions.msGraphServicePrincipal.appRoles

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
    
    $permissions = Permissions_GetPermissionsData $online
    $msOauth = $permissions.oauth2
    
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
    
    $permissions = Permissions_GetPermissionsData $online
    $msAppRoles = $permissions.appRoles
    
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
