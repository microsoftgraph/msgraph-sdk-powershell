# ------------------------------------------------------------------------------
#  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
# ------------------------------------------------------------------------------
Update-FormatData -PrependPath .\src\Authentication\Authentication\Microsoft.Graph.Authentication.format.ps1xml

$permissionsPulledFromMgGraphRequest = $null

function Permissions_GetPermissionsData {

    $permissions_MsGraphServicePrincipal = $null

    # 2. Making a REST request to MS Graph
    if ($null -eq $permissions_MsGraphServicePrincipal){
        $script:permissions_MsGraphServicePrincipal = try {

            # Write-Host "Getting data from web service"
            $result = Invoke-MgGraphRequest -method GET 'https://graph.microsoft.com/v1.0/servicePrincipals?filter=appId eq ''00000003-0000-0000-c000-000000000000''' 
            
            if ($null -ne $result) {
                $result | select-object -expandproperty value 
            }

        } catch [System.Management.Automation.ValidationMetadataException] {

            # Write-Host "Getting data from local file"
            Get-Content $PSScriptRoot/MSGraphServicePrincipalPermissions.json | Out-String | ConvertFrom-Json
        
        } catch [System.Net.Http.HttpRequestException] {

            # Write-Host "Getting data from local file"
            Get-Content $PSScriptRoot/MSGraphServicePrincipalPermissions.json | Out-String | ConvertFrom-Json
        
        }
    }
    
    # 3. Parse the permisions from the serviceprincipal
    $msOauth = $script:permissions_MsGraphServicePrincipal.oauth2PermissionScopes
    $msAppRoles = $script:permissions_MsGraphServicePrincipal.appRoles

    # make sure the parsed permissions are exported properly
    @{
        oauth2 = $msOauth;
        appRoles = $msAppRoles
    }

}

# Search based on user input
function Permissions_GetOauthData {

    $permissions = Permissions_GetPermissionsData
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
    
    $permissions = Permissions_GetPermissionsData
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
