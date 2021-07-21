# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------

Describe "Find-MgGraphCommand Command" {
    BeforeAll {
        . (join-path $PSScriptRoot  ..\custom\Find-MgGraphCommand.ps1)
    }

    Context "FindByUri" {
        It 'Should find command using only mandatory parameters' {
            {
                $MgCommand = Find-MgGraphCommand -Uri "/users"
                $MgCommand | Should -HaveCount 1
                $MgCommand.Method | Should -Be "GET"
                $MgCommand.APIVersion | Should -Be "v1.0"
                $MgCommand.Variants | Should -Contain "List1"
                $MgCommand.URL | Should -Be "/users"
                $MgCommand.Command | Should -Be "Get-MgUser"
            } | Should -Not -Throw
        }
        It 'Should find beta command using tokenized key segments' {
            {
                $ResourceUri = "/users/{user-id}/microsoft.graph.exportPersonalData"
                $Uri = "https://graph.microsoft.com/v1.0$ResourceUri"
                $MgCommand = Find-MgGraphCommand -Uri $Uri -Method POST -APIVersion beta
                $MgCommand | Should -HaveCount 1
                $MgCommand.Method | Should -Be "POST"
                $MgCommand.APIVersion | Should -Be "beta" # -APIVersion takes precedence.
                $MgCommand.Variants | Should -Contain "Export1"
                $MgCommand.URL | Should -Be $ResourceUri
                $MgCommand.Command | Should -Be "Export-MgUserPersonalData"
            } | Should -Not -Throw
        }
        It 'Should find v1.0 command using actual id in key segments' {
            {
                $ExpectedResourceUri = "/identityGovernance/entitlementManagement/accessPackageAssignmentResourceRoles/{accessPackageAssignmentResourceRole-id}"
                $Uri = "/identityGovernance/entitlementManagement/accessPackageAssignmentResourceRoles/fe9ee2a5-9450-4837-aa87-6bd8d8e72891"
                $MgCommand = Find-MgGraphCommand -Uri $Uri -Method GET -ApiVersion beta
                $MgCommand | Should -HaveCount 1
                $MgCommand.Method | Should -Be "GET"
                $MgCommand.APIVersion | Should -Be "beta"
                $MgCommand.Variants | Should -Contain "Get"
                $MgCommand.URL | Should -Be $ExpectedResourceUri
                $MgCommand.Command | Should -Be "Get-MgEntitlementManagementAccessPackageAssignmentResourceRole"
            } | Should -Not -Throw
        }
        It 'Should find command using URL with query parameters' {
            {
                $Uri = "beta/users?`$select=displayName&`$filter=identities/any(c:c/issuerAssignedId eq 'j.smith@yahoo.com')"
                $MgCommand = Find-MgGraphCommand -Uri $Uri -Method GET
                $MgCommand | Should -HaveCount 1
                $MgCommand.Method | Should -Be "GET"
                $MgCommand.APIVersion | Should -Be "beta"
                $MgCommand.Variants | Should -Contain "List"
                $MgCommand.URL | Should -Be "/users"
                $MgCommand.Command | Should -Be "Get-MgUser"
            } | Should -Not -Throw
        }
        It 'Should find command using escaped URL' {
            {
                $Uri = "/servicePrincipals/n0t3v@l1d3/endpoints%3F=select=id"
                $MgCommand = Find-MgGraphCommand -Uri $Uri -Method POST
                $MgCommand | Should -HaveCount 1
                $MgCommand.Method | Should -Be "POST"
                $MgCommand.APIVersion | Should -Be "v1.0"
                $MgCommand.Variants | Should -Contain "Create1"
                $MgCommand.URL | Should -Be "/servicePrincipals/{servicePrincipal-id}/endpoints"
                $MgCommand.Command | Should -Be "New-MgServicePrincipalEndpoint"
            } | Should -Not -Throw
        }
        It 'Should throw an error when URI is inavid' {
            $ExpectedErrorMessage = "*is not valid or is not currently supported by the SDK*"
            { Find-MgGraphCommand -Uri "invalidURL" -Method GET -ErrorAction Stop | Out-Null } | Should -Throw -ExpectedMessage $ExpectedErrorMessage
        }
    }

    Context "FindByCommand" {
        It 'Should find command using only mandatory parameters' {
            {
                $MgCommand = Find-MgGraphCommand -Command "Get-MgUser"
                $MgCommand | Should -HaveCount 2 # /users and /users/{id}.
                $MgCommand[0].Method | Should -Be "GET"
                $MgCommand[0].APIVersion | Should -Be "v1.0"
                $MgCommand[0].Command | Should -Be "Get-MgUser"
            } | Should -Not -Throw
        }
        Context "FindByCommand" {
            It 'Should find command using all parameters' {
                {
                    $MgCommand = Find-MgGraphCommand -Command "Invoke-MgAcceptGroupCalendarEvent" -Profile beta
                    $MgCommand | Should -HaveCount 1
                    $MgCommand.Method | Should -Be "POST"
                    $MgCommand.APIVersion | Should -Be "beta"
                    $MgCommand.Command | Should -Be "Invoke-MgAcceptGroupCalendarEvent"
                    $MgCommand.URL | Should -Be "/groups/{group-id}/calendar/events/{event-id}/microsoft.graph.accept"
                } | Should -Not -Throw
            }
            It 'Should find command using regex' {
                {
                    $MgCommand = Find-MgGraphCommand -Command "New-MgApplication.*" -ApiVersion v1.0
                    $MgCommand.Count | Should -BeGreaterThan 1
                    $MgCommand[0].Method | Should -Be "POST"
                    $MgCommand[0].APIVersion | Should -Be "v1.0"
                    $MgCommand[0].Command | Should -BeLike "New-MgApplication*"
                } | Should -Not -Throw
            }
            It 'Should throw an error when command name is inavid' {
                $ExpectedErrorMessage = "*'New-MgInvalid' is not a valid Microsoft Graph PowerShell command.*"
                { Find-MgGraphCommand -Command "New-MgInvalid" -ErrorAction Stop | Out-Null } | Should -Throw -ExpectedMessage $ExpectedErrorMessage }
        }
    }
}