# ------------------------------------------------------------------------------
#  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
# ------------------------------------------------------------------------------

Set-StrictMode -Version 6.0

$Permissions_msGraphApplicationId = '00000003-0000-0000-c000-000000000000'

# Entry point to the state of the Permissions 'class'
$_permissions = $null

# These '_'-prefixed functions are provided for tests to simulate the initial state of the class
# as well as providing visibility into its state for deeper validations

function _Permissions_Initialize {
    # Testing note: Pester alters runtime behavior so that variables defined at script
    # scope do not actually show up at script scope via 'script:' at runtime (!), so
    # we'll just use the Get-Variable command to explicitly obtain the variable object for it
    $permissionsVariable = Get-Variable _permissions

    # This structure models the state of the permissions class
    $permissionsVariable.Value = [PSCustomObject] @{
        msGraphPermissionsRequestUri = "https://graph.microsoft.com/v1.0/servicePrincipals?`$filter=appId eq '$Permissions_msGraphApplicationId'"
        msGraphServicePrincipal = $null
        isFromInvokeMgGraphRequest = $false
    }
}

function _Permissions_State {
    $_permissions
}

function Permissions_GetPermissionsData([bool] $online) {
    # Make a REST request to MS Graph to get the permissions data from the Microsoft Graph service principal
    if ( $online -or ! $_permissions.msGraphServicePrincipal -or ! $_permissions.isFromInvokeMgGraphRequest ) {
        try {
            $restResult = Invoke-MgGraphRequest -method GET $_permissions.msGraphPermissionsRequestUri

            if ( $restResult ) {
                $_permissions.msGraphServicePrincipal = $restResult | Select-Object -ExpandProperty value
                $_permissions.isFromInvokeMgGraphRequest = $true
            }
        } catch [System.Management.Automation.ValidationMetadataException], [System.Net.Http.HttpRequestException] {
            # We can't get the data from MS Graph, so just use a local static (possibly stale) copy
            $_permissions.msGraphServicePrincipal = Get-Content $PSScriptRoot/MSGraphServicePrincipalPermissions.json | Out-String | ConvertFrom-Json
            if ( $online ) {
                throw
            }
        }
    }

    # Filter out the unwanted fields and leave only the appRoleAssignments and
    # oauth2PermissionScope objects
    $_permissions.msGraphServicePrincipal | Select-Object oauth2PermissionScopes, appRoles
}

function Permissions_GetOauthData( [PSCustomObject] $permissionsData ) {
    foreach ( $oauth2grant in $permissionsData.oauth2PermissionScopes ) {
        $description = If ($oauth2grant.type -eq 'Admin') {
            $oauth2grant.adminConsentDescription
        } elseif ($oauth2grant.type -eq 'User') {
            $oauth2grant.userConsentDescription
        }

        $entry = [ordered] @{
            Id = $oauth2grant.id
            PermissionType = 'Delegated'
            Consent = $oauth2grant.type
            Name = $oauth2grant.value
            Description = $description
        }

        $permissions = [PSCustomObject] $entry
        $permissions.PSTypeNames.Insert(0, 'Microsoft.Graph.Custom.Permission')
        $permissions
    }
}

function Permissions_GetAppRolesData( [PSCustomObject] $permissionsData ) {
    foreach ( $appRole in $permissionsData.appRoles ) {

        $consent = if ($appRole.origin -eq 'Application') {
            'Admin'
        } elseif ($appRole.origin -eq 'Delegated') {
            'User'
        }

        $entry = [ordered] @{
            Id = $appRole.id
            PermissionType = 'Application'
            Consent = $consent
            Name = $appRole.value
            Description = $appRole.description
        }

        $permissions = [PSCustomObject] $entry
        $permissions.PSTypeNames.Insert(0, 'Microsoft.Graph.Custom.Permission')
        $permissions
    }
}

_Permissions_Initialize
