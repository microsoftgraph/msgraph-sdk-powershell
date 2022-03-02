# ------------------------------------------------------------------------------
#  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
# ------------------------------------------------------------------------------

Set-StrictMode -Version 2

. "$psscriptroot/common/Permissions.ps1"

$scopesParameterBlock = {
    param($commandName,
    $parameterName,
    $wordToComplete,
    $commandAst,
    $fakeBoundParameters
    )

    $permissions = @()
    $permissionsData = Permissions_GetPermissionsData
    $permissionsOAuthQuery = Permissions_GetOauthData $permissionsData
    $permissions += $permissionsOAuthQuery.Name
    $permissions | Where-Object {
        $_ -like "$wordToComplete*"
    }
}

Register-ArgumentCompleter -CommandName Connect-MgGraph -ParameterName Scopes -ScriptBlock $scopesParameterBlock