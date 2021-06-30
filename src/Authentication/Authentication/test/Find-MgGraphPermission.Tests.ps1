# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------
Describe "the Find-MgGraphPermission Command" {
    BeforeAll{
        . (join-path $PSScriptRoot  ..\custom\FindMgGraph_Permission.ps1)
    }

    Context "when executing the command" {
        It 'Executes successfully with no parameters' {
            Connect-MgGraph
            { Find-MgGraphPermission | Out-Null } | Should -Throw
        }

    }

    Context "does not have access to MgGraph" {
        It 'Executes successfully with no parameters' {
            { Find-MgGraphPermission mail| Out-Null } | Should -Throw
        }

    }

}