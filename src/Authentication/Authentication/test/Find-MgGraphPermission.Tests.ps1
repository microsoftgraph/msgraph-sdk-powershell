# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------
Describe "the Find-MgGraphPermission Command" {

    BeforeAll {
        . (join-path $PSScriptRoot  ..\custom\Find-MgGraphPermission.ps1)
    }

    Context "when executing the command" {
        BeforeAll {
            Mock Invoke-MgGraphRequest {

                [PSCustomObject] @{
                    Value = [PSCustomObject] @{
                        Oauth2PermissionScopes=@();
                        AppRoles=@()
                    }
                }
            }
        }

        It 'Executes successfully with no parameters' {
            { Find-MgGraphPermission | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest
        }

    }

}