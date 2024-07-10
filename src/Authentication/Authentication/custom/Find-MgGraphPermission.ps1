# ------------------------------------------------------------------------------
#  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
# ------------------------------------------------------------------------------

Set-StrictMode -Version 2

. "$psscriptroot/common/Permissions.ps1"

# Register the output type of Find-MgGraphPermission so that
# auto-completion works for commands such as Select-Object
'Id', 'Consent', 'Name', 'Description', 'PermissionType' | ForEach-Object {
    $typeParameters = @{
        TypeName = 'Microsoft.Graph.Custom.Permission'
        MemberType = 'NoteProperty'
        MemberName = $_
        Value = $null
    }

    Update-typedata @typeParameters -force
}
function Find-MgGraphPermission {
    [cmdletbinding(positionalbinding=$false, HelpUri = 'https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/find-mggraphpermission')]
    [OutputType('Microsoft.Graph.Custom.Permission')]
    param (
        [parameter(ParameterSetName='Search', position=0, ValueFromPipeline=$true, Mandatory=$true, HelpMessage='The search string to use to find permissions')]
        [String] $SearchString,

        [parameter(ParameterSetName='Search', HelpMessage='Search for permissions that exactly match the specified name')]
        [Switch] $ExactMatch,

        [parameter(ParameterSetName='PermissionType', HelpMessage='The type of permissions to search for', Mandatory=$false)]
        [ValidateSet('Any', 'Delegated', 'Application')]
        [String] $PermissionType = 'Any',
        
        [parameter(ParameterSetName='Online', HelpMessage='Search for permissions in the online service', Mandatory=$false)]
        [Switch] $Online,

        [parameter(ParameterSetname='All', HelpMessage='Return all permissions', Mandatory=$false)]
        [Switch] $All
    )

    begin {

        $filter = if ( $All.IsPresent ) {
            { $true }
        } elseif ( $ExactMatch.IsPresent ) {
            { $_.Name -eq $SearchString }
        } else {
            { $_.Name -like "*$SearchString*" }
        }

        $permissionsData = Permissions_GetPermissionsData $online
    }

    process {
        $permissions = @()

        if ( $PermissionType -in 'Any', 'Delegated' ) {
            $permissions += Permissions_GetOauthData $permissionsData |
              Where-Object $filter |
              Sort-Object Name
        }

        if ( $PermissionType -in 'Any', 'Application' ) {
            $permissions += Permissions_GetAppRolesData $permissionsData |
              Where-Object $filter |
              Sort-Object Name
        }

        if ( ! $permissions -and $ExactMatch.IsPresent ) {
            Write-Error "No results were found that exactly matched the specified permission '$SearchString'"
        }

        $permissions
    }

    end {
    }
}