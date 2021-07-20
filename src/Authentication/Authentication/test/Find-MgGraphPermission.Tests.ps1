# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------
Describe "the Find-MgGraphPermission Command" {

    BeforeAll {
        . (join-path $PSScriptRoot  ..\custom\Find-MgGraphPermission.ps1)
        . (Join-Path $PSScriptRoot  .\Find-MgGraphPermissionTestfile.ps1)
    }

    Context "When executing the command with empty service principal results from MS Graph" {
        BeforeAll {
            Mock Invoke-MgGraphRequest {

                [PSCustomObject] @{
                    Value = [PSCustomObject] @{
                        Oauth2PermissionScopes = @()
                        AppRoles = @()
                    }
                }
            }
        }

        It 'Executes successfully with no parameters' {
            { Find-MgGraphPermission | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest
        }
    }

    Context "When executing the command using a constrained set of permissions returned by MS Graph" {
        BeforeAll {
            Mock Invoke-MgGraphRequest {$permissionData}
        }

        It 'Executes successfully with no parameters' {
            { Find-MgGraphPermission | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest
        }

        It "Retrieves the expected set of delegated and app-only permissions when a search string is specified" {
            { Find-MgGraphPermission mail | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest
        }

        It "Returns nothing and throws no exception if a search string is specified and there is no match" {
            { Find-MgGraphPermission 'Microsoft is the greatest company' | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest
        }
    }

    Context "When executing the command without a connection to MS Graph" {
        BeforeAll {
            Mock Invoke-MgGraphRequest {

                Throw [System.Management.Automation.ValidationMetadataException]::new('mock connection error message')

            }
        }

        It 'Executes successfully with no parameters' {
            { Find-MgGraphPermission | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest
        }

        It "Retrieves the expected set of delegated and app-only permissions when a search string is specified" {
            { Find-MgGraphPermission mail | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest
        }

        It "Returns nothing and throws no exception if a search string is specified and there is no match" {
            { Find-MgGraphPermission 'Microsoft is the greatest company' | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest
        }
    }

    Context "When executing the command after initially not having a connection to MS Graph but getting it later" {

        BeforeEach {
            Mock Invoke-MgGraphRequest {

                Throw [System.Management.Automation.ValidationMetadataException]::new('mock connection error message')

            }
        }

        It 'Executes successfully with no parameters' {
            { Find-MgGraphPermission | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest

            Mock Invoke-MgGraphRequest{
                $permissionData
            }

            { Find-MgGraphPermission | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest

        }

        It "Retrieves the expected set of delegated and app-only permissions when a search string is specified" {
            { Find-MgGraphPermission mail | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest

            Mock Invoke-MgGraphRequest{
                $permissionData
            }

            { Find-MgGraphPermission mail | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest
        }

        It "Returns nothing and throws no exception if a search string is specified and there is no match" {
            { Find-MgGraphPermission 'Microsoft is the greatest company' | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest

            Mock Invoke-MgGraphRequest{
                $permissionData
            }

            { Find-MgGraphPermission 'Microsoft is the greatest company' | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest
        }
    }

    Context "When executing the command when initially not having access to read the service prinicpal but later having access" {

        BeforeEach {
            Mock Invoke-MgGraphRequest {

                Throw [System.Management.Automation.ValidationMetadataException]::new('mock connection error message')

            }
        }

        It 'Executes successfully with no parameters' {
            { Find-MgGraphPermission | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest

            Mock Invoke-MgGraphRequest{
                $permissionData
            }

            { Find-MgGraphPermission | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest

        }

        It "Retrieves the expected set of delegated and app-only permissions when a search string is specified" {
            { Find-MgGraphPermission mail | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest

            Mock Invoke-MgGraphRequest{
                $permissionData
            }

            { Find-MgGraphPermission mail | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest
        }

        It "Returns nothing and throws no exception if a search string is specified and there is no match" {
            { Find-MgGraphPermission 'Microsoft is the greatest company' | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest

            Mock Invoke-MgGraphRequest{
                $permissionData
            }

            { Find-MgGraphPermission 'Microsoft is the greatest company' | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest
        }
    }
}
