# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------

Describe "The Find-MgGraphPermission Command" {

    BeforeAll {
        . (join-path $PSScriptRoot  ..\custom\Find-MgGraphPermission.ps1)
        . (Join-Path $PSScriptRoot  .\Find-MgGraphPermissionTestfile.ps1)
    }

    Context "When executing the command with empty service principal results from MS Graph" {
        BeforeAll {

            Mock Invoke-MgGraphRequest {
                [PSCustomObject] @{
                    Value = [PSCustomObject] @{
                        oauth2PermissionScopes = @()
                        appRoles               = @()
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
            Mock Invoke-MgGraphRequest { $permissionData }
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
            $ErrorActionPreference = 'continue'
            { Find-MgGraphPermission -ExactMatch IDontExist 2>&1 | out-null } | Should -Not -Throw

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
                Throw [Microsoft.Graph.PowerShell.AuthenticationException]::new('mock connection error message')
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
            Mock Invoke-MgGraphRequest {
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
            Mock Invoke-MgGraphRequest {
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
            Mock Invoke-MgGraphRequest {
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
            Mock Invoke-MgGraphRequest {
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
            Mock Invoke-MgGraphRequest {
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
            Mock Invoke-MgGraphRequest {
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

# SIG # Begin signature block
# MIInzgYJKoZIhvcNAQcCoIInvzCCJ7sCAQExDzANBglghkgBZQMEAgEFADB5Bgor
# BgEEAYI3AgEEoGswaTA0BgorBgEEAYI3AgEeMCYCAwEAAAQQH8w7YFlLCE63JNLG
# KX7zUQIBAAIBAAIBAAIBAAIBADAxMA0GCWCGSAFlAwQCAQUABCAwhUBqrgqma/bN
# MwOU6DtY2UodNr14VBryNruB7IRDi6CCDYUwggYDMIID66ADAgECAhMzAAADri01
# UchTj1UdAAAAAAOuMA0GCSqGSIb3DQEBCwUAMH4xCzAJBgNVBAYTAlVTMRMwEQYD
# VQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVNaWNy
# b3NvZnQgQ29ycG9yYXRpb24xKDAmBgNVBAMTH01pY3Jvc29mdCBDb2RlIFNpZ25p
# bmcgUENBIDIwMTEwHhcNMjMxMTE2MTkwODU5WhcNMjQxMTE0MTkwODU5WjB0MQsw
# CQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMHUmVkbW9u
# ZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMR4wHAYDVQQDExVNaWNy
# b3NvZnQgQ29ycG9yYXRpb24wggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIB
# AQD0IPymNjfDEKg+YyE6SjDvJwKW1+pieqTjAY0CnOHZ1Nj5irGjNZPMlQ4HfxXG
# yAVCZcEWE4x2sZgam872R1s0+TAelOtbqFmoW4suJHAYoTHhkznNVKpscm5fZ899
# QnReZv5WtWwbD8HAFXbPPStW2JKCqPcZ54Y6wbuWV9bKtKPImqbkMcTejTgEAj82
# 6GQc6/Th66Koka8cUIvz59e/IP04DGrh9wkq2jIFvQ8EDegw1B4KyJTIs76+hmpV
# M5SwBZjRs3liOQrierkNVo11WuujB3kBf2CbPoP9MlOyyezqkMIbTRj4OHeKlamd
# WaSFhwHLJRIQpfc8sLwOSIBBAgMBAAGjggGCMIIBfjAfBgNVHSUEGDAWBgorBgEE
# AYI3TAgBBggrBgEFBQcDAzAdBgNVHQ4EFgQUhx/vdKmXhwc4WiWXbsf0I53h8T8w
# VAYDVR0RBE0wS6RJMEcxLTArBgNVBAsTJE1pY3Jvc29mdCBJcmVsYW5kIE9wZXJh
# dGlvbnMgTGltaXRlZDEWMBQGA1UEBRMNMjMwMDEyKzUwMTgzNjAfBgNVHSMEGDAW
# gBRIbmTlUAXTgqoXNzcitW2oynUClTBUBgNVHR8ETTBLMEmgR6BFhkNodHRwOi8v
# d3d3Lm1pY3Jvc29mdC5jb20vcGtpb3BzL2NybC9NaWNDb2RTaWdQQ0EyMDExXzIw
# MTEtMDctMDguY3JsMGEGCCsGAQUFBwEBBFUwUzBRBggrBgEFBQcwAoZFaHR0cDov
# L3d3dy5taWNyb3NvZnQuY29tL3BraW9wcy9jZXJ0cy9NaWNDb2RTaWdQQ0EyMDEx
# XzIwMTEtMDctMDguY3J0MAwGA1UdEwEB/wQCMAAwDQYJKoZIhvcNAQELBQADggIB
# AGrJYDUS7s8o0yNprGXRXuAnRcHKxSjFmW4wclcUTYsQZkhnbMwthWM6cAYb/h2W
# 5GNKtlmj/y/CThe3y/o0EH2h+jwfU/9eJ0fK1ZO/2WD0xi777qU+a7l8KjMPdwjY
# 0tk9bYEGEZfYPRHy1AGPQVuZlG4i5ymJDsMrcIcqV8pxzsw/yk/O4y/nlOjHz4oV
# APU0br5t9tgD8E08GSDi3I6H57Ftod9w26h0MlQiOr10Xqhr5iPLS7SlQwj8HW37
# ybqsmjQpKhmWul6xiXSNGGm36GarHy4Q1egYlxhlUnk3ZKSr3QtWIo1GGL03hT57
# xzjL25fKiZQX/q+II8nuG5M0Qmjvl6Egltr4hZ3e3FQRzRHfLoNPq3ELpxbWdH8t
# Nuj0j/x9Crnfwbki8n57mJKI5JVWRWTSLmbTcDDLkTZlJLg9V1BIJwXGY3i2kR9i
# 5HsADL8YlW0gMWVSlKB1eiSlK6LmFi0rVH16dde+j5T/EaQtFz6qngN7d1lvO7uk
# 6rtX+MLKG4LDRsQgBTi6sIYiKntMjoYFHMPvI/OMUip5ljtLitVbkFGfagSqmbxK
# 7rJMhC8wiTzHanBg1Rrbff1niBbnFbbV4UDmYumjs1FIpFCazk6AADXxoKCo5TsO
# zSHqr9gHgGYQC2hMyX9MGLIpowYCURx3L7kUiGbOiMwaMIIHejCCBWKgAwIBAgIK
# YQ6Q0gAAAAAAAzANBgkqhkiG9w0BAQsFADCBiDELMAkGA1UEBhMCVVMxEzARBgNV
# BAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jv
# c29mdCBDb3Jwb3JhdGlvbjEyMDAGA1UEAxMpTWljcm9zb2Z0IFJvb3QgQ2VydGlm
# aWNhdGUgQXV0aG9yaXR5IDIwMTEwHhcNMTEwNzA4MjA1OTA5WhcNMjYwNzA4MjEw
# OTA5WjB+MQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UE
# BxMHUmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMSgwJgYD
# VQQDEx9NaWNyb3NvZnQgQ29kZSBTaWduaW5nIFBDQSAyMDExMIICIjANBgkqhkiG
# 9w0BAQEFAAOCAg8AMIICCgKCAgEAq/D6chAcLq3YbqqCEE00uvK2WCGfQhsqa+la
# UKq4BjgaBEm6f8MMHt03a8YS2AvwOMKZBrDIOdUBFDFC04kNeWSHfpRgJGyvnkmc
# 6Whe0t+bU7IKLMOv2akrrnoJr9eWWcpgGgXpZnboMlImEi/nqwhQz7NEt13YxC4D
# dato88tt8zpcoRb0RrrgOGSsbmQ1eKagYw8t00CT+OPeBw3VXHmlSSnnDb6gE3e+
# lD3v++MrWhAfTVYoonpy4BI6t0le2O3tQ5GD2Xuye4Yb2T6xjF3oiU+EGvKhL1nk
# kDstrjNYxbc+/jLTswM9sbKvkjh+0p2ALPVOVpEhNSXDOW5kf1O6nA+tGSOEy/S6
# A4aN91/w0FK/jJSHvMAhdCVfGCi2zCcoOCWYOUo2z3yxkq4cI6epZuxhH2rhKEmd
# X4jiJV3TIUs+UsS1Vz8kA/DRelsv1SPjcF0PUUZ3s/gA4bysAoJf28AVs70b1FVL
# 5zmhD+kjSbwYuER8ReTBw3J64HLnJN+/RpnF78IcV9uDjexNSTCnq47f7Fufr/zd
# sGbiwZeBe+3W7UvnSSmnEyimp31ngOaKYnhfsi+E11ecXL93KCjx7W3DKI8sj0A3
# T8HhhUSJxAlMxdSlQy90lfdu+HggWCwTXWCVmj5PM4TasIgX3p5O9JawvEagbJjS
# 4NaIjAsCAwEAAaOCAe0wggHpMBAGCSsGAQQBgjcVAQQDAgEAMB0GA1UdDgQWBBRI
# bmTlUAXTgqoXNzcitW2oynUClTAZBgkrBgEEAYI3FAIEDB4KAFMAdQBiAEMAQTAL
# BgNVHQ8EBAMCAYYwDwYDVR0TAQH/BAUwAwEB/zAfBgNVHSMEGDAWgBRyLToCMZBD
# uRQFTuHqp8cx0SOJNDBaBgNVHR8EUzBRME+gTaBLhklodHRwOi8vY3JsLm1pY3Jv
# c29mdC5jb20vcGtpL2NybC9wcm9kdWN0cy9NaWNSb29DZXJBdXQyMDExXzIwMTFf
# MDNfMjIuY3JsMF4GCCsGAQUFBwEBBFIwUDBOBggrBgEFBQcwAoZCaHR0cDovL3d3
# dy5taWNyb3NvZnQuY29tL3BraS9jZXJ0cy9NaWNSb29DZXJBdXQyMDExXzIwMTFf
# MDNfMjIuY3J0MIGfBgNVHSAEgZcwgZQwgZEGCSsGAQQBgjcuAzCBgzA/BggrBgEF
# BQcCARYzaHR0cDovL3d3dy5taWNyb3NvZnQuY29tL3BraW9wcy9kb2NzL3ByaW1h
# cnljcHMuaHRtMEAGCCsGAQUFBwICMDQeMiAdAEwAZQBnAGEAbABfAHAAbwBsAGkA
# YwB5AF8AcwB0AGEAdABlAG0AZQBuAHQALiAdMA0GCSqGSIb3DQEBCwUAA4ICAQBn
# 8oalmOBUeRou09h0ZyKbC5YR4WOSmUKWfdJ5DJDBZV8uLD74w3LRbYP+vj/oCso7
# v0epo/Np22O/IjWll11lhJB9i0ZQVdgMknzSGksc8zxCi1LQsP1r4z4HLimb5j0b
# pdS1HXeUOeLpZMlEPXh6I/MTfaaQdION9MsmAkYqwooQu6SpBQyb7Wj6aC6VoCo/
# KmtYSWMfCWluWpiW5IP0wI/zRive/DvQvTXvbiWu5a8n7dDd8w6vmSiXmE0OPQvy
# CInWH8MyGOLwxS3OW560STkKxgrCxq2u5bLZ2xWIUUVYODJxJxp/sfQn+N4sOiBp
# mLJZiWhub6e3dMNABQamASooPoI/E01mC8CzTfXhj38cbxV9Rad25UAqZaPDXVJi
# hsMdYzaXht/a8/jyFqGaJ+HNpZfQ7l1jQeNbB5yHPgZ3BtEGsXUfFL5hYbXw3MYb
# BL7fQccOKO7eZS/sl/ahXJbYANahRr1Z85elCUtIEJmAH9AAKcWxm6U/RXceNcbS
# oqKfenoi+kiVH6v7RyOA9Z74v2u3S5fi63V4GuzqN5l5GEv/1rMjaHXmr/r8i+sL
# gOppO6/8MO0ETI7f33VtY5E90Z1WTk+/gFcioXgRMiF670EKsT/7qMykXcGhiJtX
# cVZOSEXAQsmbdlsKgEhr/Xmfwb1tbWrJUnMTDXpQzTGCGZ8wghmbAgEBMIGVMH4x
# CzAJBgNVBAYTAlVTMRMwEQYDVQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRt
# b25kMR4wHAYDVQQKExVNaWNyb3NvZnQgQ29ycG9yYXRpb24xKDAmBgNVBAMTH01p
# Y3Jvc29mdCBDb2RlIFNpZ25pbmcgUENBIDIwMTECEzMAAAOuLTVRyFOPVR0AAAAA
# A64wDQYJYIZIAWUDBAIBBQCgga4wGQYJKoZIhvcNAQkDMQwGCisGAQQBgjcCAQQw
# HAYKKwYBBAGCNwIBCzEOMAwGCisGAQQBgjcCARUwLwYJKoZIhvcNAQkEMSIEIF6k
# 90aWVvtSN41hmyBQ1rI3PQvntBRNsEdWp+DzXkCuMEIGCisGAQQBgjcCAQwxNDAy
# oBSAEgBNAGkAYwByAG8AcwBvAGYAdKEagBhodHRwOi8vd3d3Lm1pY3Jvc29mdC5j
# b20wDQYJKoZIhvcNAQEBBQAEggEA3aIjDCAdadb8McP1xOETrchdaC4bLfMgGFLT
# 1VCeus+bC05gRhzRhWR/5KJSUIgDnSAm2hPNiLWJrauJBpyk5EAXptzKN1CBCyO1
# emzFrDz/w4dUA/oZ2L0SxOUfZyJ4mWd4qETwK5di7l4L7KAI8g6fkLhpfPwr3TsY
# heKoVS8DT3QePzAKgdzuqgwqpEXGcC1VJWAcY6FZsfr7ZyisXCH+qH0UiiLN1xYK
# jCRzUsjVRJVgsEb5FFPNIGsHnmZ/JfxYuuw5Bb66ybjaeVZU4+uGFhvqAXCOfY+Y
# fJoCxJp2EP/v8Llc0SAoEcJVUMiM/Ly8IAda9FKPOfhwsmc3BaGCFykwghclBgor
# BgEEAYI3AwMBMYIXFTCCFxEGCSqGSIb3DQEHAqCCFwIwghb+AgEDMQ8wDQYJYIZI
# AWUDBAIBBQAwggFZBgsqhkiG9w0BCRABBKCCAUgEggFEMIIBQAIBAQYKKwYBBAGE
# WQoDATAxMA0GCWCGSAFlAwQCAQUABCBpxNWWJtLfegmfAv8Dr9Vu+NL0HjeLUl9d
# AY8WR+48LQIGZbqiWfLRGBMyMDI0MDIxNjA5NTMxMi4zMTZaMASAAgH0oIHYpIHV
# MIHSMQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMH
# UmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMS0wKwYDVQQL
# EyRNaWNyb3NvZnQgSXJlbGFuZCBPcGVyYXRpb25zIExpbWl0ZWQxJjAkBgNVBAsT
# HVRoYWxlcyBUU1MgRVNOOjE3OUUtNEJCMC04MjQ2MSUwIwYDVQQDExxNaWNyb3Nv
# ZnQgVGltZS1TdGFtcCBTZXJ2aWNloIIReDCCBycwggUPoAMCAQICEzMAAAHg1Pwf
# ExUffl0AAQAAAeAwDQYJKoZIhvcNAQELBQAwfDELMAkGA1UEBhMCVVMxEzARBgNV
# BAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jv
# c29mdCBDb3Jwb3JhdGlvbjEmMCQGA1UEAxMdTWljcm9zb2Z0IFRpbWUtU3RhbXAg
# UENBIDIwMTAwHhcNMjMxMDEyMTkwNzE5WhcNMjUwMTEwMTkwNzE5WjCB0jELMAkG
# A1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQx
# HjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjEtMCsGA1UECxMkTWljcm9z
# b2Z0IElyZWxhbmQgT3BlcmF0aW9ucyBMaW1pdGVkMSYwJAYDVQQLEx1UaGFsZXMg
# VFNTIEVTTjoxNzlFLTRCQjAtODI0NjElMCMGA1UEAxMcTWljcm9zb2Z0IFRpbWUt
# U3RhbXAgU2VydmljZTCCAiIwDQYJKoZIhvcNAQEBBQADggIPADCCAgoCggIBAKyH
# nPOhxbvRATnGjb/6fuBhh3ZLzotAxAgdLaZ/zkRFUdeSKzyNt3tqorMK7GDvcXdK
# s+qIMUbvenlH+w53ssPa6rYP760ZuFrABrfserf0kFayNXVzwT7jarJOEjnFMBp+
# yi+uwQ2TnJuxczceG5FDHrII6sF6F879lP6ydY0BBZkZ9t39e/svNRieA5gUnv/Y
# cM/bIMY/QYmd9F0B+ebFYi+PH4AkXahNkFgK85OIaRrDGvhnxOa/5zGL7Oiii7+J
# 9/QHkdJGlfnRfbQ3QXM/5/umBOKG4JoFY1niZ5RVH5PT0+uCjwcqhTbnvUtfK+N+
# yB2b9rEZvp2Tv4ZwYzEd9A9VsYMuZiCSbaFMk77LwVbklpnw4aHWJXJkEYmJvxRb
# cThE8FQyOoVkSuKc5OWZ2+WM/j50oblA0tCU53AauvUOZRoQBh89nHK+m5pOXKXd
# YMJ+ceuLYF8h5y/cXLQMOmqLJz5l7MLqGwU0zHV+MEO8L1Fo2zEEQ4iL4BX8YknK
# XonHGQacSCaLZot2kyJVRsFSxn0PlPvHVp0YdsCMzdeiw9jAZ7K9s1WxsZGEBrK/
# obipX6uxjEpyUA9mbVPljlb3R4MWI0E2xI/NM6F4Ac8Ceax3YWLT+aWCZeqiIMLx
# yyWZg+i1KY8ZEzMeNTKCEI5wF1wxqr6T1/MQo+8tAgMBAAGjggFJMIIBRTAdBgNV
# HQ4EFgQUcF4XP26dV+8SusoA1XXQ2TDSmdIwHwYDVR0jBBgwFoAUn6cVXQBeYl2D
# 9OXSZacbUzUZ6XIwXwYDVR0fBFgwVjBUoFKgUIZOaHR0cDovL3d3dy5taWNyb3Nv
# ZnQuY29tL3BraW9wcy9jcmwvTWljcm9zb2Z0JTIwVGltZS1TdGFtcCUyMFBDQSUy
# MDIwMTAoMSkuY3JsMGwGCCsGAQUFBwEBBGAwXjBcBggrBgEFBQcwAoZQaHR0cDov
# L3d3dy5taWNyb3NvZnQuY29tL3BraW9wcy9jZXJ0cy9NaWNyb3NvZnQlMjBUaW1l
# LVN0YW1wJTIwUENBJTIwMjAxMCgxKS5jcnQwDAYDVR0TAQH/BAIwADAWBgNVHSUB
# Af8EDDAKBggrBgEFBQcDCDAOBgNVHQ8BAf8EBAMCB4AwDQYJKoZIhvcNAQELBQAD
# ggIBAMATzg6R/A0ldO7MqGxD1VJji5yVA1hHb0Hc0Yjtv7WkxQ8iwfflulX5Us64
# tD3+3NT1JkphWzaAWf2wKdAw35RxtQG1iON3HEZ0X23nde4Kg/Wfbx5rEHkZ9bzK
# nR/2N5A16+w/1pbwJzdfRcnJT3cLyawr/kYjMWd63OP0Glq70ua4WUE/Po5pU7rQ
# RbWEoQozY24hAqOcwuRcm6Cb0JBeTOCeRBntEKgjKep4pRaQt7b9vusT97WeJcfa
# VosmmPtsZsawgnpIjbBa55tHfuk0vDkZtbIXjU4mr5dns9dnanBdBS2PY3N3hIfC
# PEOszquwHLkfkFZ/9bxw8/eRJldtoukHo16afE/AqP/smmGJh5ZR0pmgW6QcX+61
# rdi5kDJTzCFaoMyYzUS0SEbyrDZ/p2KOuKAYNngljiOlllct0uJVz2agfczGjjsK
# i2AS1WaXvOhgZNmGw42SFB1qaloa8Kaux9Q2HHLE8gee/5rgOnx9zSbfVUc7IcRN
# odq6R7v+Rz+P6XKtOgyCqW/+rhPmp/n7Fq2BGTRkcy//hmS32p6qyglr2K4OoJDJ
# XxFs6lwc8D86qlUeGjUyo7hVy5VvyA+y0mGnEAuA85tsOcUPlzwWF5sv+B5fz35O
# W3X4Spk5SiNulnLFRPM5XCsSHqvcbC8R3qwj2w1evPhZxDuNMIIHcTCCBVmgAwIB
# AgITMwAAABXF52ueAptJmQAAAAAAFTANBgkqhkiG9w0BAQsFADCBiDELMAkGA1UE
# BhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAc
# BgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjEyMDAGA1UEAxMpTWljcm9zb2Z0
# IFJvb3QgQ2VydGlmaWNhdGUgQXV0aG9yaXR5IDIwMTAwHhcNMjEwOTMwMTgyMjI1
# WhcNMzAwOTMwMTgzMjI1WjB8MQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGlu
# Z3RvbjEQMA4GA1UEBxMHUmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBv
# cmF0aW9uMSYwJAYDVQQDEx1NaWNyb3NvZnQgVGltZS1TdGFtcCBQQ0EgMjAxMDCC
# AiIwDQYJKoZIhvcNAQEBBQADggIPADCCAgoCggIBAOThpkzntHIhC3miy9ckeb0O
# 1YLT/e6cBwfSqWxOdcjKNVf2AX9sSuDivbk+F2Az/1xPx2b3lVNxWuJ+Slr+uDZn
# hUYjDLWNE893MsAQGOhgfWpSg0S3po5GawcU88V29YZQ3MFEyHFcUTE3oAo4bo3t
# 1w/YJlN8OWECesSq/XJprx2rrPY2vjUmZNqYO7oaezOtgFt+jBAcnVL+tuhiJdxq
# D89d9P6OU8/W7IVWTe/dvI2k45GPsjksUZzpcGkNyjYtcI4xyDUoveO0hyTD4MmP
# frVUj9z6BVWYbWg7mka97aSueik3rMvrg0XnRm7KMtXAhjBcTyziYrLNueKNiOSW
# rAFKu75xqRdbZ2De+JKRHh09/SDPc31BmkZ1zcRfNN0Sidb9pSB9fvzZnkXftnIv
# 231fgLrbqn427DZM9ituqBJR6L8FA6PRc6ZNN3SUHDSCD/AQ8rdHGO2n6Jl8P0zb
# r17C89XYcz1DTsEzOUyOArxCaC4Q6oRRRuLRvWoYWmEBc8pnol7XKHYC4jMYcten
# IPDC+hIK12NvDMk2ZItboKaDIV1fMHSRlJTYuVD5C4lh8zYGNRiER9vcG9H9stQc
# xWv2XFJRXRLbJbqvUAV6bMURHXLvjflSxIUXk8A8FdsaN8cIFRg/eKtFtvUeh17a
# j54WcmnGrnu3tz5q4i6tAgMBAAGjggHdMIIB2TASBgkrBgEEAYI3FQEEBQIDAQAB
# MCMGCSsGAQQBgjcVAgQWBBQqp1L+ZMSavoKRPEY1Kc8Q/y8E7jAdBgNVHQ4EFgQU
# n6cVXQBeYl2D9OXSZacbUzUZ6XIwXAYDVR0gBFUwUzBRBgwrBgEEAYI3TIN9AQEw
# QTA/BggrBgEFBQcCARYzaHR0cDovL3d3dy5taWNyb3NvZnQuY29tL3BraW9wcy9E
# b2NzL1JlcG9zaXRvcnkuaHRtMBMGA1UdJQQMMAoGCCsGAQUFBwMIMBkGCSsGAQQB
# gjcUAgQMHgoAUwB1AGIAQwBBMAsGA1UdDwQEAwIBhjAPBgNVHRMBAf8EBTADAQH/
# MB8GA1UdIwQYMBaAFNX2VsuP6KJcYmjRPZSQW9fOmhjEMFYGA1UdHwRPME0wS6BJ
# oEeGRWh0dHA6Ly9jcmwubWljcm9zb2Z0LmNvbS9wa2kvY3JsL3Byb2R1Y3RzL01p
# Y1Jvb0NlckF1dF8yMDEwLTA2LTIzLmNybDBaBggrBgEFBQcBAQROMEwwSgYIKwYB
# BQUHMAKGPmh0dHA6Ly93d3cubWljcm9zb2Z0LmNvbS9wa2kvY2VydHMvTWljUm9v
# Q2VyQXV0XzIwMTAtMDYtMjMuY3J0MA0GCSqGSIb3DQEBCwUAA4ICAQCdVX38Kq3h
# LB9nATEkW+Geckv8qW/qXBS2Pk5HZHixBpOXPTEztTnXwnE2P9pkbHzQdTltuw8x
# 5MKP+2zRoZQYIu7pZmc6U03dmLq2HnjYNi6cqYJWAAOwBb6J6Gngugnue99qb74p
# y27YP0h1AdkY3m2CDPVtI1TkeFN1JFe53Z/zjj3G82jfZfakVqr3lbYoVSfQJL1A
# oL8ZthISEV09J+BAljis9/kpicO8F7BUhUKz/AyeixmJ5/ALaoHCgRlCGVJ1ijbC
# HcNhcy4sa3tuPywJeBTpkbKpW99Jo3QMvOyRgNI95ko+ZjtPu4b6MhrZlvSP9pEB
# 9s7GdP32THJvEKt1MMU0sHrYUP4KWN1APMdUbZ1jdEgssU5HLcEUBHG/ZPkkvnNt
# yo4JvbMBV0lUZNlz138eW0QBjloZkWsNn6Qo3GcZKCS6OEuabvshVGtqRRFHqfG3
# rsjoiV5PndLQTHa1V1QJsWkBRH58oWFsc/4Ku+xBZj1p/cvBQUl+fpO+y/g75LcV
# v7TOPqUxUYS8vwLBgqJ7Fx0ViY1w/ue10CgaiQuPNtq6TPmb/wrpNPgkNWcr4A24
# 5oyZ1uEi6vAnQj0llOZ0dFtq0Z4+7X6gMTN9vMvpe784cETRkPHIqzqKOghif9lw
# Y1NNje6CbaUFEMFxBmoQtB1VM1izoXBm8qGCAtQwggI9AgEBMIIBAKGB2KSB1TCB
# 0jELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1Jl
# ZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjEtMCsGA1UECxMk
# TWljcm9zb2Z0IElyZWxhbmQgT3BlcmF0aW9ucyBMaW1pdGVkMSYwJAYDVQQLEx1U
# aGFsZXMgVFNTIEVTTjoxNzlFLTRCQjAtODI0NjElMCMGA1UEAxMcTWljcm9zb2Z0
# IFRpbWUtU3RhbXAgU2VydmljZaIjCgEBMAcGBSsOAwIaAxUAbfPR1fBX6HxYfyPx
# 8zYzJU5fIQyggYMwgYCkfjB8MQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGlu
# Z3RvbjEQMA4GA1UEBxMHUmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBv
# cmF0aW9uMSYwJAYDVQQDEx1NaWNyb3NvZnQgVGltZS1TdGFtcCBQQ0EgMjAxMDAN
# BgkqhkiG9w0BAQUFAAIFAOl5jrwwIhgPMjAyNDAyMTYxNTM1MjRaGA8yMDI0MDIx
# NzE1MzUyNFowdDA6BgorBgEEAYRZCgQBMSwwKjAKAgUA6XmOvAIBADAHAgEAAgIY
# uDAHAgEAAgISNjAKAgUA6XrgPAIBADA2BgorBgEEAYRZCgQCMSgwJjAMBgorBgEE
# AYRZCgMCoAowCAIBAAIDB6EgoQowCAIBAAIDAYagMA0GCSqGSIb3DQEBBQUAA4GB
# ADEQCmvhWcjA7PsjpXb2ToNdAoZwauQeFOd7nzT4LbUPhCVS3bOhTe8L5Tjvhuuf
# IXGL5uhZGTBl3hMHDWvlrwCreB+aUTZv1i+V1bh9o6Xur2k4ekCG0NT5wxkLRwTg
# 6Zr8md554ypB/bIzjTNGTl5k0ol1DB5QBgSRZ83x9MyKMYIEDTCCBAkCAQEwgZMw
# fDELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1Jl
# ZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjEmMCQGA1UEAxMd
# TWljcm9zb2Z0IFRpbWUtU3RhbXAgUENBIDIwMTACEzMAAAHg1PwfExUffl0AAQAA
# AeAwDQYJYIZIAWUDBAIBBQCgggFKMBoGCSqGSIb3DQEJAzENBgsqhkiG9w0BCRAB
# BDAvBgkqhkiG9w0BCQQxIgQg8wYhmVTQn8oijLEhnejulNEPARrwNhPAHRIsZGiR
# Jz0wgfoGCyqGSIb3DQEJEAIvMYHqMIHnMIHkMIG9BCDj7lK/8jnlbTjPvc77DCCS
# b4TZApY9nJm5whsK/2kKwTCBmDCBgKR+MHwxCzAJBgNVBAYTAlVTMRMwEQYDVQQI
# EwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVNaWNyb3Nv
# ZnQgQ29ycG9yYXRpb24xJjAkBgNVBAMTHU1pY3Jvc29mdCBUaW1lLVN0YW1wIFBD
# QSAyMDEwAhMzAAAB4NT8HxMVH35dAAEAAAHgMCIEILA9bRZ9J/PSUGKtGhElk44P
# e4hJwdupke3GEOZ3UfjAMA0GCSqGSIb3DQEBCwUABIICAJvNOZLxa717NNiLle+x
# OGSCgoIIxeYDayb4FBhStK/ER3GCFdxw0w6qGbNKwL5p5KFvMkrYADVMIMqwAdLV
# 7OHMr1kTcvB21x1FtxZuUlNYioqS7AI4PXCWyfn53JB53da5aUldkJvcoQTisfgg
# yq43c9oaBOwKzlYSluHWk8z0i2DR5BMdpbrOD8XYq0ZgtoAmSkBWIeYnMvGQzRqu
# Pb4dB+lEIkN0cXwE4dRPFJePeKyecKGwzJUefpMQMVgBShJPEZg+eANMPmgfxHI7
# mrT5TrtJQkNdFzZihEu9vnlQXJ6P3820jRNrXZd1XiyiXiNdDrZmdz6H6gIpaWvR
# g88r3lzxp89+GzTI6MT/2S9VWLTDEwQrkrJGGkDNEo91VTTr7gYi+nJNIW9s7/pD
# 4L7KlAbqkY0fIQflObEa/giW7+QB+k/tUkdQ2nE/i1SJKG4uYXdzw7Tk/dZbjOs6
# lvNacvMGsnmUvD4ig7MAqzD5JwxS5ip/9jpf8ugIARRGK3TKf4MEgpXuNVqjg3Ig
# rV8m3ykZad8RkM/5TB8KhgYFAZTMh+Qy5mUD2d0IXGEU3TzD+5pJTB/Ct49wWsc9
# QfL4LR04cjS053QiCmf5q8c3EgayCfcTImjlqFDpj63ySkb9y5wDDSeleQhdLsxZ
# /kkET2imKPAYw9C/6V6Tvzir
# SIG # End signature block
