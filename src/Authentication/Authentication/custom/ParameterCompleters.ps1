# ------------------------------------------------------------------------------
#  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
# ------------------------------------------------------------------------------

Set-StrictMode -Version 2

. "$psscriptroot/common/Permissions.ps1"

$scopesParameterBlock = {
    param($commandName,
    $parameterName,
    $wordToCompleteScopes,
    $commandAst,
    $fakeBoundParameters
    )

    $permissions = @()
    $permissionsOAuthQuery = Permissions_GetOauthData (Permissions_GetPermissionsData)
    $permissions += $permissionsOAuthQuery.Name
    $permissions | Where-Object {
        $_ -like "$wordToCompleteScopes*"
    }
}

$environmentParameterBlock = {
    param($commandName,
    $parameterName,
    $wordToCompleteEnvironment,
    $commandAst,
    $fakeBoundParameters
    )

    $environments = Get-MgEnvironment | Select-Object -ExpandProperty Name
    $environments | Where-Object {
        $_ -like "$wordToCompleteEnvironment*"
    }
}

Register-ArgumentCompleter -CommandName Connect-MgGraph -ParameterName Scopes -ScriptBlock $scopesParameterBlock
Register-ArgumentCompleter -CommandName Connect-MgGraph -ParameterName Environment -ScriptBlock $environmentParameterBlock

Register-ArgumentCompleter -CommandName Get-MgEnvironment -ParameterName Name -ScriptBlock $environmentParameterBlock