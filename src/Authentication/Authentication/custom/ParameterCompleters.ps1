# ------------------------------------------------------------------------------
#  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
# ------------------------------------------------------------------------------

Set-StrictMode -Version 2

. "$psscriptroot/common/Permissions.ps1"

$scriptblock = {
    param($commandName,
    $parameterName,
    $wordToComplete,
    $commandAst,
    $fakeBoundParameters
    )

    $permissions = @()
    $permissionsData = Permissions_GetPermissionsData
    $permissionsOAuthQuery = Permissions_GetOauthData $permissionsData
    $permissionsAppRolesQuery = Permissions_GetAppRolesData $permissionsData
    $permissions += $permissionsOAuthQuery.Name
    $permissions += $permissionsAppRolesQuery.Name
    $permissions | Where-Object {
        $_ -like "$wordToComplete*"
    } | ForEach-Object {
        $_
    }
}

$params = @{
    CommandName = 'Find-MgGraphPermission'
    ParameterName = 'SearchString'
    ScriptBlock = $scriptBlock
}

Register-ArgumentCompleter @params