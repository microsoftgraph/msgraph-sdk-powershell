# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------

Describe "The Find-MgGraphPermission Command" {

    BeforeAll {
        . (join-path $PSScriptRoot  ..\custom\Find-MgGraphPermission.ps1)
        . (Join-Path $PSScriptRoot  .\Find-MgGraphPermissionTestfile.ps1)
    }

    Context "When executing the command with empty service principal results from MS Graph"  {
        BeforeAll {

            Mock Invoke-MgGraphRequest {
                [PSCustomObject] @{
                    Value = [PSCustomObject] @{
                        oauth2PermissionScopes = @()
                        appRoles = @()
                    }
                }
            }
        }

        It 'Executes successfully with the All parameter' {
            { Find-MgGraphPermission -All | Out-Null } | Should -Not -Throw
            (_Permissions_State).isFromInvokeMgGraphRequest | Should -Be $true
            Assert-MockCalled Invoke-MgGraphRequest
            { Find-MgGraphPermission -All -Online | Out-Null } | Should -Not -Throw
        }
    }

    Context "When executing the command using a constrained set of permissions returned by MS Graph and there is a connection" {
        BeforeEach {
            _Permissions_Initialize
            Mock Invoke-MgGraphRequest {$permissionData}
        }

        It 'Executes successfully with the All parameter' {
            { Find-MgGraphPermission -All | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest
            (_Permissions_State).msGraphServicePrincipal | Should -Not -Be $null
            (_Permissions_State).isFromInvokeMgGraphRequest | Should -Be $true
            { Find-MgGraphPermission -Online | Out-Null } | Should -Not -Throw
        }

        It 'Executes successfully when the Any parameter is specified for some search criteria' {
            $result = Find-MgGraphPermission ReadWrite -PermissionType Any

            $result.length | Should -Be 4
        }

        It 'Should accept input from the pipeline as the SearchString parameter and find matches for each element in the pipeline' -Tag testing {
            { 'People.Read.All' | Find-MgGraphPermission -ErrorAction Stop } | Should -Not -Throw

            $pipelineMatches = 'People.Read.All', 'User.Read.Basic' | Find-MgGraphPermission

            $pipelineMatches.length | Should -Be 2
            $pipelineMatches[0].Name | Should -Be 'People.Read.All'
            $pipelineMatches[1].Name | Should -Be 'User.Read.Basic'
        }

        It 'Only calls Invoke-MgGraphRequest for the first invocation of Find-MgGraphPermission and is not called for subsequent invocations' {
            { Find-MgGraphPermission 'ReadWrite' | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest -Exactly 1
            { Find-MgGraphPermission 'Email' | Out-Null }
            Assert-MockCalled Invoke-MgGraphRequest -Exactly 1
        }

        It 'Calls Invoke-MgGraphRequest for the first request and then only if the Online parameter is specified' {
            Find-MgGraphPermission 'role' | Should -Not -Be $null
            Assert-MockCalled Invoke-MgGraphRequest -Exactly 1
            Find-MgGraphPermission 'user' | Should -Not -Be $null
            Assert-MockCalled Invoke-MgGraphRequest -Exactly 1
            Find-MgGraphPermission 'user' -Online | Should -Not -Be $null
            Assert-MockCalled Invoke-MgGraphRequest -Exactly 2
        }

        It "Retrieves the expected set of delegated and app-only permissions when a search string is specified" {
            { Find-MgGraphPermission 'ReadWrite' | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest
            $test = Find-MgGraphPermission 'ReadWrite'
            $test.GetType() | Should -Be 'System.Object[]'
            $test.length | Should -Be 4
            $test.PermissionType[0] | Should -Be 'Delegated'
            (_Permissions_State).msGraphServicePrincipal | Should -Not -Be $null
            (_Permissions_State).isFromInvokeMgGraphRequest | Should -Be $true
            { Find-MgGraphPermission 'ReadWrite' -Online | Out-Null } | Should -Not -Throw
            $testOnline = Find-MgGraphPermission 'ReadWrite' -Online
            $testOnline.length | Should -Be 4
        }

        It "Retrieves only delegated permissions even the PermissionType parameter is specified as Delegated when application permissions would also match the search string" {
            $allMatches = Find-MgGraphPermission ReadWrite

            $index = 0

            $delegatedPermissions = , 'RoleAssignmentSchedule.ReadWrite.Directory'
            $applicationPermissions = 'Directory.ReadWrite.All', 'Group.ReadWrite.All', 'WorkforceIntegration.ReadWrite.All'

            $allPermissions = @()
            $allPermissions += $delegatedPermissions
            $allPermissions += $applicationPermissions

            $allPermissions | ForEach-Object {
                $allMatches[$index++].Name | Should -Be $_
            }

            $delegatedMatches = Find-MgGraphPermission ReadWrite -PermissionType Delegated

            $delegatedIndex = 0

            $delegatedPermissions | ForEach-Object {
                $delegatedMatches[$delegatedIndex++].Name | Should -Be $_
            }
        }

        It "Should return null and not throw an exception if ExactMatch is specified and there is no match" {
            { Find-MgGraphPermission -ExactMatch IDontExist 2>&1 | out-null } | Should -Not -Throw
            $ErrorActionPreference = 'continue'

            Find-MgGraphPermission -ExactMatch IDontExistuser -ErrorAction Ignore | Should -Be $null
        }

        It "Should throw an exception if ExactMatch is specified and the specified SearchString cannot be found even when there is a partial match and the ErrorAction is stop" {
            $result = Find-MgGraphPermission Group

            $result.length | Should -Be 2

            $result | ForEach-Object {
                $_.Name | Should -BeLike '*group*'
            }

            { Find-MgGraphPermission -ExactMatch user -ErrorAction Stop 2>&1 | out-null } | Should -Throw

        }

        It "Should return exactly the permission specified" {
            Find-MgGraphPermission Group.read.basic |
              Select-Object -ExpandProperty Name |
              Should -Be 'Group.Read.Basic'
        }

        It "It allows the PermissionType to be specified when the All parameter is specified and returns the filtered results" {

            $delegatedPermissions = 'Group.Read.Basic', 'RoleAssignmentSchedule.ReadWrite.Directory', 'User.Read.Basic'

            $applicationPermissions = 'Directory.ReadWrite.All', 'Group.ReadWrite.All', 'People.Read.All', 'WorkforceIntegration.ReadWrite.All'

            $allPermissions = @()
            $allPermissions += $delegatedPermissions
            $allPermissions += $applicationPermissions

            $delegatedCount = $delegatedPermissions.Length
            $applicationCount = $applicationPermissions.Length

            $totalCount = $delegatedCount + $applicationCount

            $allMatches = Find-MgGraphPermission -All

            $allMatchesFromAny = Find-MgGraphPermission -All -PermissionType Any

            $delegatedMatches = Find-MgGraphPermission -All -PermissionType Delegated

            $applicationMatches = Find-MgGraphPermission -All -PermissionType Application

            $allMatches.Length | Should -Be $totalCount
            $allMatchesFromAny.Length | Should -Be $totalCount

            $index = 0

            $allPermissions | ForEach-Object {
                $allMatches[$index].Name | Should -Be $_
                $allMatchesFromAny[$index++].Name | Should -Be $_
            }

            $delegatedIndex = 0

            $delegatedPermissions | ForEach-Object {
                $delegatedMatches[$delegatedIndex++].Name | Should -Be $_
            }

            $applicationIndex = 0

            $applicationPermissions | ForEach-Object {
                $applicationMatches[$applicationIndex++].Name | Should -Be $_
            }
        }

        It "Retrieves only application  permissions even the PermissionType parameter is specified as Application when delegated permissions would also match the search string" {
            $allMatches = Find-MgGraphPermission ReadWrite

            $index = 0

            $delegatedPermissions = , 'RoleAssignmentSchedule.ReadWrite.Directory'
            $applicationPermissions = 'Directory.ReadWrite.All', 'Group.ReadWrite.All', 'WorkforceIntegration.ReadWrite.All'

            $allPermissions = @()
            $allPermissions += $delegatedPermissions
            $allPermissions += $applicationPermissions

            $allPermissions | ForEach-Object {
                $allMatches[$index++].Name | Should -Be $_
            }

            $applicationMatches = Find-MgGraphPermission ReadWrite -PermissionType Application

            $applicationIndex = 0

            $applicationPermissions | ForEach-Object {
                $applicationMatches[$applicationIndex++].Name | Should -Be $_
            }
        }

        It "Returns nothing and throws no exception if a search string is specified and there is no match" {
            { Find-MgGraphPermission 'Nigeria has the best jollof' | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest
            $test = Find-MgGraphPermission 'Nigeria has the best jollof'
            $test | Should -Be $null
            (_Permissions_State).msGraphServicePrincipal | Should -Not -Be $null
            (_Permissions_State).isFromInvokeMgGraphRequest | Should -Be $true
            { Find-MgGraphPermission 'Nigeria has the best jollof' -Online | Out-Null } | Should -Not -Throw
        }
    }

    Context "When executing the command without a connection to MS Graph" {
        BeforeEach {
            _Permissions_Initialize
            Mock Invoke-MgGraphRequest {
                Throw [System.Management.Automation.ValidationMetadataException]::new('mock connection error message')
            }
        }

        It 'Executes successfully with the All parameter' {
            { Find-MgGraphPermission -All | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest
            (_Permissions_State).msGraphServicePrincipal | Should -Not -Be $null
            (_Permissions_State).isFromInvokeMgGraphRequest | Should -Be $false
            { Find-MgGraphPermission -Online | Out-Null } | Should -Throw 'mock connection error message'
        }

        It "Retrieves the expected set of delegated and app-only permissions when a search string is specified" {
            { Find-MgGraphPermission 'ReadWrite' | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest
            $test = Find-MgGraphPermission 'mail'
            $test | Should -Not -Be $null
            $test.length | Should -Be 17
            $test.Consent[0] | Should -Be 'User'
            $test.PermissionType[-1] | Should -Be 'Application'
            $test.Id.GetType() | Should -Be 'System.Object[]'
            (_Permissions_State).msGraphServicePrincipal | Should -Not -Be $null
            (_Permissions_State).isFromInvokeMgGraphRequest | Should -Be $false
            { Find-MgGraphPermission 'ReadWrite' -Online | Out-Null } | Should -Throw 'mock connection error message'
        }

        It "Returns nothing and throws no exception if a search string is specified and there is no match" {
            { Find-MgGraphPermission 'Nigeria has the best jollof' | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest
            $test = Find-MgGraphPermission 'Nigeria has the best jollof'
            $test | Should -Be $null
            (_Permissions_State).msGraphServicePrincipal | Should -Not -Be $null
            (_Permissions_State).isFromInvokeMgGraphRequest | Should -Be $false
            { Find-MgGraphPermission 'Nigeria has the best jollof' -Online | Out-Null } | Should -Throw 'mock connection error message'
        }
    }

    Context "When executing the command after initially not having a connection to MS Graph but getting it later" {
        BeforeEach {
            _Permissions_Initialize
            Mock Invoke-MgGraphRequest {
                Throw [System.Management.Automation.ValidationMetadataException]::new('mock connection error message')
            }
        }

        It 'Executes successfully with the All parameter' {
            { Find-MgGraphPermission -All | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest
            (_Permissions_State).msGraphServicePrincipal | Should -Not -Be $null
            (_Permissions_State).isFromInvokeMgGraphRequest | Should -Be $false
            { Find-MgGraphPermission -Online | Out-Null } | Should -Throw 'mock connection error message'

            # Restoring the connection that was set to fail in the BeforeEach
            Mock Invoke-MgGraphRequest{
                $permissionData
            }

            { Find-MgGraphPermission -All | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest
            (_Permissions_State).msGraphServicePrincipal | Should -Not -Be $null
            (_Permissions_State).isFromInvokeMgGraphRequest | Should -Be $true
            { Find-MgGraphPermission -Online | Out-Null } | Should -Not -Throw

        }

        It "Retrieves the expected set of delegated and app-only permissions when a search string is specified" {
            { Find-MgGraphPermission mail | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest
            $test = Find-MgGraphPermission 'ReadWrite'
            $test | Should -Not -Be $null
            $test.length | Should -Be 225
            (_Permissions_State).msGraphServicePrincipal | Should -Not -Be $null
            (_Permissions_State).isFromInvokeMgGraphRequest | Should -Be $false
            { Find-MgGraphPermission 'ReadWrite' -Online | Out-Null } | Should -Throw 'mock connection error message'

            # Restoring the connection that was set to fail in the BeforeEach
            Mock Invoke-MgGraphRequest{
                $permissionData
            }

            { Find-MgGraphPermission mail | Out-Null } | Should -Not -Throw
            $test = Find-MgGraphPermission 'ReadWrite'
            $test | Should -Not -Be $null
            $test.length | Should -Be 4
            (_Permissions_State).msGraphServicePrincipal | Should -Not -Be $null
            (_Permissions_State).isFromInvokeMgGraphRequest | Should -Be $true
            { Find-MgGraphPermission 'Readwrite' -Online | Out-Null } | Should -Not -Throw
        }

        It "Returns nothing and throws no exception if a search string is specified and there is no match" {
            { Find-MgGraphPermission 'Nigeria has the best jollof' | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest
            $test = Find-MgGraphPermission 'Nigeria has the best jollof' | Should -Be $null
            (_Permissions_State).msGraphServicePrincipal | Should -Not -Be $null
            (_Permissions_State).isFromInvokeMgGraphRequest | Should -Be $false
            { Find-MgGraphPermission 'Nigeria has the best jollof' -Online | Out-Null } | Should -Throw 'mock connection error message'

            # Restoring the connection that was set to fail in the BeforeEach
            Mock Invoke-MgGraphRequest{
                $permissionData
            }

            { Find-MgGraphPermission 'Nigeria has the best jollof' | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest
            $test = Find-MgGraphPermission 'Nigeria has the best jollof'
            $test | Should -Be $null
            (_Permissions_State).msGraphServicePrincipal | Should -Not -Be $null
            (_Permissions_State).isFromInvokeMgGraphRequest | Should -Be $true
            { Find-MgGraphPermission 'Nigeria has the best jollof' -Online | Out-Null } | Should -Not -Throw
        }
    }

    Context "When executing the command when initially not having access to read the service prinicpal but later having access" {
        BeforeEach {
            _Permissions_Initialize
            Mock Invoke-MgGraphRequest {
                Throw [System.Net.Http.HttpRequestException]::new('mock authentication error message')
            }
        }

        It 'Executes successfully with the All parameter' {
            { Find-MgGraphPermission -All | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest
            (_Permissions_State).msGraphServicePrincipal | Should -Not -Be $null
            (_Permissions_State).isFromInvokeMgGraphRequest | Should -Be $false
            { Find-MgGraphPermission -All -Online | Out-Null } | Should -Throw 'mock authentication error message'

            # Restoring the connection that was set to fail in the BeforeEach
            Mock Invoke-MgGraphRequest{
                $permissionData
            }

            { Find-MgGraphPermission -All | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest
            (_Permissions_State).msGraphServicePrincipal | Should -Not -Be $null
            (_Permissions_State).isFromInvokeMgGraphRequest | Should -Be $true
            { Find-MgGraphPermission -All -Online | Out-Null } | Should -Not -Throw

        }

        It "Retrieves the expected set of delegated and app-only permissions when a search string is specified" {
            { Find-MgGraphPermission mail | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest
            $test = Find-MgGraphPermission 'ReadWrite'
            $test | Should -Not -Be $null
            $test.length | Should -Be 225
            (_Permissions_State).msGraphServicePrincipal | Should -Not -Be $null
            (_Permissions_State).isFromInvokeMgGraphRequest | Should -Be $false
            { Find-MgGraphPermission 'ReadWrite' -Online | Out-Null } | Should -Throw 'mock authentication error message'

            # Restoring the connection that was set to fail in the BeforeEach
            Mock Invoke-MgGraphRequest{
                $permissionData
            }

            { Find-MgGraphPermission mail | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest
            $test = Find-MgGraphPermission 'ReadWrite'
            $test | Should -Not -Be $null
            $test.length | Should -Be 4
            (_Permissions_State).msGraphServicePrincipal | Should -Not -Be $null
            (_Permissions_State).isFromInvokeMgGraphRequest | Should -Be $true
            { Find-MgGraphPermission 'ReadWrite' -Online | Out-Null } | Should -Not -Throw
        }

        It "Returns nothing and throws no exception if a search string is specified and there is no match" {
            { Find-MgGraphPermission 'Nigeria has the best jollof' | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest
            $test = Find-MgGraphPermission 'Nigeria has the best jollof' | Should -Be $null
            (_Permissions_State).msGraphServicePrincipal | Should -Not -Be $null
            (_Permissions_State).isFromInvokeMgGraphRequest | Should -Be $false
            { Find-MgGraphPermission 'Nigeria has the best jollof' -Online | Out-Null } | Should -Throw 'mock authentication error message'

            # Restoring the connection that was set to fail in the BeforeEach
            Mock Invoke-MgGraphRequest{
                $permissionData
            }

            { Find-MgGraphPermission 'Nigeria has the best jollof' | Out-Null } | Should -Not -Throw
            Assert-MockCalled Invoke-MgGraphRequest
            $test = Find-MgGraphPermission 'Nigeria has the best jollof'
            $test | Should -Be $null
            (_Permissions_State).msGraphServicePrincipal | Should -Not -Be $null
            (_Permissions_State).isFromInvokeMgGraphRequest | Should -Be $true
            { Find-MgGraphPermission 'Nigeria has the best jollof' -Online | Out-Null } | Should -Not -Throw
        }
    }
}
