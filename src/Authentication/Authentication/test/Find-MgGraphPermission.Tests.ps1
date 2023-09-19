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
# MIIoLQYJKoZIhvcNAQcCoIIoHjCCKBoCAQExDzANBglghkgBZQMEAgEFADB5Bgor
# BgEEAYI3AgEEoGswaTA0BgorBgEEAYI3AgEeMCYCAwEAAAQQH8w7YFlLCE63JNLG
# KX7zUQIBAAIBAAIBAAIBAAIBADAxMA0GCWCGSAFlAwQCAQUABCAwhUBqrgqma/bN
# MwOU6DtY2UodNr14VBryNruB7IRDi6CCDXYwggX0MIID3KADAgECAhMzAAADTrU8
# esGEb+srAAAAAANOMA0GCSqGSIb3DQEBCwUAMH4xCzAJBgNVBAYTAlVTMRMwEQYD
# VQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVNaWNy
# b3NvZnQgQ29ycG9yYXRpb24xKDAmBgNVBAMTH01pY3Jvc29mdCBDb2RlIFNpZ25p
# bmcgUENBIDIwMTEwHhcNMjMwMzE2MTg0MzI5WhcNMjQwMzE0MTg0MzI5WjB0MQsw
# CQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMHUmVkbW9u
# ZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMR4wHAYDVQQDExVNaWNy
# b3NvZnQgQ29ycG9yYXRpb24wggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIB
# AQDdCKiNI6IBFWuvJUmf6WdOJqZmIwYs5G7AJD5UbcL6tsC+EBPDbr36pFGo1bsU
# p53nRyFYnncoMg8FK0d8jLlw0lgexDDr7gicf2zOBFWqfv/nSLwzJFNP5W03DF/1
# 1oZ12rSFqGlm+O46cRjTDFBpMRCZZGddZlRBjivby0eI1VgTD1TvAdfBYQe82fhm
# WQkYR/lWmAK+vW/1+bO7jHaxXTNCxLIBW07F8PBjUcwFxxyfbe2mHB4h1L4U0Ofa
# +HX/aREQ7SqYZz59sXM2ySOfvYyIjnqSO80NGBaz5DvzIG88J0+BNhOu2jl6Dfcq
# jYQs1H/PMSQIK6E7lXDXSpXzAgMBAAGjggFzMIIBbzAfBgNVHSUEGDAWBgorBgEE
# AYI3TAgBBggrBgEFBQcDAzAdBgNVHQ4EFgQUnMc7Zn/ukKBsBiWkwdNfsN5pdwAw
# RQYDVR0RBD4wPKQ6MDgxHjAcBgNVBAsTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjEW
# MBQGA1UEBRMNMjMwMDEyKzUwMDUxNjAfBgNVHSMEGDAWgBRIbmTlUAXTgqoXNzci
# tW2oynUClTBUBgNVHR8ETTBLMEmgR6BFhkNodHRwOi8vd3d3Lm1pY3Jvc29mdC5j
# b20vcGtpb3BzL2NybC9NaWNDb2RTaWdQQ0EyMDExXzIwMTEtMDctMDguY3JsMGEG
# CCsGAQUFBwEBBFUwUzBRBggrBgEFBQcwAoZFaHR0cDovL3d3dy5taWNyb3NvZnQu
# Y29tL3BraW9wcy9jZXJ0cy9NaWNDb2RTaWdQQ0EyMDExXzIwMTEtMDctMDguY3J0
# MAwGA1UdEwEB/wQCMAAwDQYJKoZIhvcNAQELBQADggIBAD21v9pHoLdBSNlFAjmk
# mx4XxOZAPsVxxXbDyQv1+kGDe9XpgBnT1lXnx7JDpFMKBwAyIwdInmvhK9pGBa31
# TyeL3p7R2s0L8SABPPRJHAEk4NHpBXxHjm4TKjezAbSqqbgsy10Y7KApy+9UrKa2
# kGmsuASsk95PVm5vem7OmTs42vm0BJUU+JPQLg8Y/sdj3TtSfLYYZAaJwTAIgi7d
# hzn5hatLo7Dhz+4T+MrFd+6LUa2U3zr97QwzDthx+RP9/RZnur4inzSQsG5DCVIM
# pA1l2NWEA3KAca0tI2l6hQNYsaKL1kefdfHCrPxEry8onJjyGGv9YKoLv6AOO7Oh
# JEmbQlz/xksYG2N/JSOJ+QqYpGTEuYFYVWain7He6jgb41JbpOGKDdE/b+V2q/gX
# UgFe2gdwTpCDsvh8SMRoq1/BNXcr7iTAU38Vgr83iVtPYmFhZOVM0ULp/kKTVoir
# IpP2KCxT4OekOctt8grYnhJ16QMjmMv5o53hjNFXOxigkQWYzUO+6w50g0FAeFa8
# 5ugCCB6lXEk21FFB1FdIHpjSQf+LP/W2OV/HfhC3uTPgKbRtXo83TZYEudooyZ/A
# Vu08sibZ3MkGOJORLERNwKm2G7oqdOv4Qj8Z0JrGgMzj46NFKAxkLSpE5oHQYP1H
# tPx1lPfD7iNSbJsP6LiUHXH1MIIHejCCBWKgAwIBAgIKYQ6Q0gAAAAAAAzANBgkq
# hkiG9w0BAQsFADCBiDELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24x
# EDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlv
# bjEyMDAGA1UEAxMpTWljcm9zb2Z0IFJvb3QgQ2VydGlmaWNhdGUgQXV0aG9yaXR5
# IDIwMTEwHhcNMTEwNzA4MjA1OTA5WhcNMjYwNzA4MjEwOTA5WjB+MQswCQYDVQQG
# EwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMHUmVkbW9uZDEeMBwG
# A1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMSgwJgYDVQQDEx9NaWNyb3NvZnQg
# Q29kZSBTaWduaW5nIFBDQSAyMDExMIICIjANBgkqhkiG9w0BAQEFAAOCAg8AMIIC
# CgKCAgEAq/D6chAcLq3YbqqCEE00uvK2WCGfQhsqa+laUKq4BjgaBEm6f8MMHt03
# a8YS2AvwOMKZBrDIOdUBFDFC04kNeWSHfpRgJGyvnkmc6Whe0t+bU7IKLMOv2akr
# rnoJr9eWWcpgGgXpZnboMlImEi/nqwhQz7NEt13YxC4Ddato88tt8zpcoRb0Rrrg
# OGSsbmQ1eKagYw8t00CT+OPeBw3VXHmlSSnnDb6gE3e+lD3v++MrWhAfTVYoonpy
# 4BI6t0le2O3tQ5GD2Xuye4Yb2T6xjF3oiU+EGvKhL1nkkDstrjNYxbc+/jLTswM9
# sbKvkjh+0p2ALPVOVpEhNSXDOW5kf1O6nA+tGSOEy/S6A4aN91/w0FK/jJSHvMAh
# dCVfGCi2zCcoOCWYOUo2z3yxkq4cI6epZuxhH2rhKEmdX4jiJV3TIUs+UsS1Vz8k
# A/DRelsv1SPjcF0PUUZ3s/gA4bysAoJf28AVs70b1FVL5zmhD+kjSbwYuER8ReTB
# w3J64HLnJN+/RpnF78IcV9uDjexNSTCnq47f7Fufr/zdsGbiwZeBe+3W7UvnSSmn
# Eyimp31ngOaKYnhfsi+E11ecXL93KCjx7W3DKI8sj0A3T8HhhUSJxAlMxdSlQy90
# lfdu+HggWCwTXWCVmj5PM4TasIgX3p5O9JawvEagbJjS4NaIjAsCAwEAAaOCAe0w
# ggHpMBAGCSsGAQQBgjcVAQQDAgEAMB0GA1UdDgQWBBRIbmTlUAXTgqoXNzcitW2o
# ynUClTAZBgkrBgEEAYI3FAIEDB4KAFMAdQBiAEMAQTALBgNVHQ8EBAMCAYYwDwYD
# VR0TAQH/BAUwAwEB/zAfBgNVHSMEGDAWgBRyLToCMZBDuRQFTuHqp8cx0SOJNDBa
# BgNVHR8EUzBRME+gTaBLhklodHRwOi8vY3JsLm1pY3Jvc29mdC5jb20vcGtpL2Ny
# bC9wcm9kdWN0cy9NaWNSb29DZXJBdXQyMDExXzIwMTFfMDNfMjIuY3JsMF4GCCsG
# AQUFBwEBBFIwUDBOBggrBgEFBQcwAoZCaHR0cDovL3d3dy5taWNyb3NvZnQuY29t
# L3BraS9jZXJ0cy9NaWNSb29DZXJBdXQyMDExXzIwMTFfMDNfMjIuY3J0MIGfBgNV
# HSAEgZcwgZQwgZEGCSsGAQQBgjcuAzCBgzA/BggrBgEFBQcCARYzaHR0cDovL3d3
# dy5taWNyb3NvZnQuY29tL3BraW9wcy9kb2NzL3ByaW1hcnljcHMuaHRtMEAGCCsG
# AQUFBwICMDQeMiAdAEwAZQBnAGEAbABfAHAAbwBsAGkAYwB5AF8AcwB0AGEAdABl
# AG0AZQBuAHQALiAdMA0GCSqGSIb3DQEBCwUAA4ICAQBn8oalmOBUeRou09h0ZyKb
# C5YR4WOSmUKWfdJ5DJDBZV8uLD74w3LRbYP+vj/oCso7v0epo/Np22O/IjWll11l
# hJB9i0ZQVdgMknzSGksc8zxCi1LQsP1r4z4HLimb5j0bpdS1HXeUOeLpZMlEPXh6
# I/MTfaaQdION9MsmAkYqwooQu6SpBQyb7Wj6aC6VoCo/KmtYSWMfCWluWpiW5IP0
# wI/zRive/DvQvTXvbiWu5a8n7dDd8w6vmSiXmE0OPQvyCInWH8MyGOLwxS3OW560
# STkKxgrCxq2u5bLZ2xWIUUVYODJxJxp/sfQn+N4sOiBpmLJZiWhub6e3dMNABQam
# ASooPoI/E01mC8CzTfXhj38cbxV9Rad25UAqZaPDXVJihsMdYzaXht/a8/jyFqGa
# J+HNpZfQ7l1jQeNbB5yHPgZ3BtEGsXUfFL5hYbXw3MYbBL7fQccOKO7eZS/sl/ah
# XJbYANahRr1Z85elCUtIEJmAH9AAKcWxm6U/RXceNcbSoqKfenoi+kiVH6v7RyOA
# 9Z74v2u3S5fi63V4GuzqN5l5GEv/1rMjaHXmr/r8i+sLgOppO6/8MO0ETI7f33Vt
# Y5E90Z1WTk+/gFcioXgRMiF670EKsT/7qMykXcGhiJtXcVZOSEXAQsmbdlsKgEhr
# /Xmfwb1tbWrJUnMTDXpQzTGCGg0wghoJAgEBMIGVMH4xCzAJBgNVBAYTAlVTMRMw
# EQYDVQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVN
# aWNyb3NvZnQgQ29ycG9yYXRpb24xKDAmBgNVBAMTH01pY3Jvc29mdCBDb2RlIFNp
# Z25pbmcgUENBIDIwMTECEzMAAANOtTx6wYRv6ysAAAAAA04wDQYJYIZIAWUDBAIB
# BQCgga4wGQYJKoZIhvcNAQkDMQwGCisGAQQBgjcCAQQwHAYKKwYBBAGCNwIBCzEO
# MAwGCisGAQQBgjcCARUwLwYJKoZIhvcNAQkEMSIEIF6k90aWVvtSN41hmyBQ1rI3
# PQvntBRNsEdWp+DzXkCuMEIGCisGAQQBgjcCAQwxNDAyoBSAEgBNAGkAYwByAG8A
# cwBvAGYAdKEagBhodHRwOi8vd3d3Lm1pY3Jvc29mdC5jb20wDQYJKoZIhvcNAQEB
# BQAEggEAMF+KuLW9geFEzAwLKv3eZEjdW1K+9WkjvOrjMqoyqDYR90D5T/GbU0Xx
# wnZbQNeOKP4LxYUx+Pqqgu+rPkMPJLAbfeOQvL2X9DK+7Y7JLQHfp8Xp04bHlmVX
# AnjUM5KCT/VJN2ZMV+EmK5+y8z2AGxBEo/lhWJ1QNeP4ODXPwpAKlVEdQRBUpMLO
# JzMFaVbQC2vOST8Tk7aHnzGr40IMFEgjDB3D+9mZBp/CNyQSu5j8Djz9/zbVsu2c
# H5xTZRxCVB5nTSyji0pTiVsHi5/PlpPQszPQrgKMilSEUSGzJgH6zq8RNZSy05fP
# 1kdgfZ/JeJYUiZ8Q38grcHE2fhF6Y6GCF5cwgheTBgorBgEEAYI3AwMBMYIXgzCC
# F38GCSqGSIb3DQEHAqCCF3AwghdsAgEDMQ8wDQYJYIZIAWUDBAIBBQAwggFSBgsq
# hkiG9w0BCRABBKCCAUEEggE9MIIBOQIBAQYKKwYBBAGEWQoDATAxMA0GCWCGSAFl
# AwQCAQUABCBwk9SK+mp3LkX9kT1giORai3TJGNqhDx06mnPe28NE3gIGZQPV4J9l
# GBMyMDIzMDkxOTEyMTkwNS4zNzJaMASAAgH0oIHRpIHOMIHLMQswCQYDVQQGEwJV
# UzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMHUmVkbW9uZDEeMBwGA1UE
# ChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMSUwIwYDVQQLExxNaWNyb3NvZnQgQW1l
# cmljYSBPcGVyYXRpb25zMScwJQYDVQQLEx5uU2hpZWxkIFRTUyBFU046QTQwMC0w
# NUUwLUQ5NDcxJTAjBgNVBAMTHE1pY3Jvc29mdCBUaW1lLVN0YW1wIFNlcnZpY2Wg
# ghHtMIIHIDCCBQigAwIBAgITMwAAAdYnaf9yLVbIrgABAAAB1jANBgkqhkiG9w0B
# AQsFADB8MQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UE
# BxMHUmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMSYwJAYD
# VQQDEx1NaWNyb3NvZnQgVGltZS1TdGFtcCBQQ0EgMjAxMDAeFw0yMzA1MjUxOTEy
# MzRaFw0yNDAyMDExOTEyMzRaMIHLMQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2Fz
# aGluZ3RvbjEQMA4GA1UEBxMHUmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENv
# cnBvcmF0aW9uMSUwIwYDVQQLExxNaWNyb3NvZnQgQW1lcmljYSBPcGVyYXRpb25z
# MScwJQYDVQQLEx5uU2hpZWxkIFRTUyBFU046QTQwMC0wNUUwLUQ5NDcxJTAjBgNV
# BAMTHE1pY3Jvc29mdCBUaW1lLVN0YW1wIFNlcnZpY2UwggIiMA0GCSqGSIb3DQEB
# AQUAA4ICDwAwggIKAoICAQDPLM2Om8r5u3fcbDEOXydJtbkW5U34KFaftC+8QyNq
# plMIzSTC1ToE0zcweQCvPIfpYtyPB3jt6fPRprvhwCksUw9p0OfmZzWPDvkt40BU
# Stu813QlrloRdplLz2xpk29jIOZ4+rBbKaZkBPZ4R4LXQhkkHne0Y/Yh85ZqMMRa
# MWkBM6nUwV5aDiwXqdE9Jyl0i1aWYbCqzwBRdN7CTlAJxrJ47ov3uf/lFg9hnVQc
# qQYgRrRFpDNFMOP0gwz5Nj6a24GZncFEGRmKwImL+5KWPnVgvadJSRp6ZqrYV3Fm
# bBmZtsF0hSlVjLQO8nxelGV7TvqIISIsv2bQMgUBVEz8wHFyU3863gHj8BCbEpJz
# m75fLJsL3P66lJUNRN7CRsfNEbHdX/d6jopVOFwF7ommTQjpU37A/7YR0wJDTt6Z
# sXU+j/wYlo9b22t1qUthqjRs32oGf2TRTCoQWLhJe3cAIYRlla/gEKlbuDDsG392
# 6y4EMHFxTjsjrcZEbDWwjB3wrp11Dyg1QKcDyLUs2anBolvQwJTN0mMOuXO8tBz2
# 0ng/+Xw+4w+W9PMkvW1faYi435VjKRZsHfxIPjIzZ0wf4FibmVPJHZ+aTxGsVJPx
# ydChvvGCf4fe8XfYY9P5lbn9ScKc4adTd44GCrBlJ/JOsoA4OvNHY6W+XcKVcIIG
# WwIDAQABo4IBSTCCAUUwHQYDVR0OBBYEFGGaVDY7TQBiMCKg2+j/zRTcYsZOMB8G
# A1UdIwQYMBaAFJ+nFV0AXmJdg/Tl0mWnG1M1GelyMF8GA1UdHwRYMFYwVKBSoFCG
# Tmh0dHA6Ly93d3cubWljcm9zb2Z0LmNvbS9wa2lvcHMvY3JsL01pY3Jvc29mdCUy
# MFRpbWUtU3RhbXAlMjBQQ0ElMjAyMDEwKDEpLmNybDBsBggrBgEFBQcBAQRgMF4w
# XAYIKwYBBQUHMAKGUGh0dHA6Ly93d3cubWljcm9zb2Z0LmNvbS9wa2lvcHMvY2Vy
# dHMvTWljcm9zb2Z0JTIwVGltZS1TdGFtcCUyMFBDQSUyMDIwMTAoMSkuY3J0MAwG
# A1UdEwEB/wQCMAAwFgYDVR0lAQH/BAwwCgYIKwYBBQUHAwgwDgYDVR0PAQH/BAQD
# AgeAMA0GCSqGSIb3DQEBCwUAA4ICAQDUv+RjNidwJxSbMk1IvS8LfxNM8VaVhpxR
# 1SkW+FRY6AKkn2s3On29nGEVlatblIv1qVTKkrUxLYMZ0z+RA6mmfXue2Y7/YBbz
# M5kUeUgU2y1Mmbin6xadT9DzECeE7E4+3k2DmZxuV+GLFYQsqkDbe8oy7+3BSiU2
# 9qyZAYT9vRDALPUC5ZwyoPkNfKbqjl3VgFTqIubEQr56M0YdMWlqCqq0yVln9mPb
# hHHzXHOjaQsurohHCf7VT8ct79po34Fd8XcsqmyhdKBy1jdyknrik+F3vEl/90qa
# on5N8KTZoGtOFlaJFPnZ2DqQtb2WWkfuAoGWrGSA43Myl7+PYbUsri/NrMvAd9Z+
# J9FlqsMwXQFxAB7ujJi4hP8BH8j6qkmy4uulU5SSQa6XkElcaKQYSpJcSjkjyTDI
# Opf6LZBTaFx6eeoqDZ0lURhiRqO+1yo8uXO89e6kgBeC8t1WN5ITqXnjocYgDvyF
# pptsUDgnRUiI1M/Ql/O299VktMkIL72i6Qd4BBsrj3Z+iLEnKP9epUwosP1m3N2v
# 9yhXQ1HiusJl63IfXIyfBJaWvQDgU3Jk4eIZSr/2KIj4ptXt496CRiHTi011kcwD
# pdjQLAQiCvoj1puyhfwVf2G5ZwBptIXivNRba34KkD5oqmEoF1yRFQ84iDsf/giy
# n/XIT7YY/zCCB3EwggVZoAMCAQICEzMAAAAVxedrngKbSZkAAAAAABUwDQYJKoZI
# hvcNAQELBQAwgYgxCzAJBgNVBAYTAlVTMRMwEQYDVQQIEwpXYXNoaW5ndG9uMRAw
# DgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVNaWNyb3NvZnQgQ29ycG9yYXRpb24x
# MjAwBgNVBAMTKU1pY3Jvc29mdCBSb290IENlcnRpZmljYXRlIEF1dGhvcml0eSAy
# MDEwMB4XDTIxMDkzMDE4MjIyNVoXDTMwMDkzMDE4MzIyNVowfDELMAkGA1UEBhMC
# VVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNV
# BAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjEmMCQGA1UEAxMdTWljcm9zb2Z0IFRp
# bWUtU3RhbXAgUENBIDIwMTAwggIiMA0GCSqGSIb3DQEBAQUAA4ICDwAwggIKAoIC
# AQDk4aZM57RyIQt5osvXJHm9DtWC0/3unAcH0qlsTnXIyjVX9gF/bErg4r25Phdg
# M/9cT8dm95VTcVrifkpa/rg2Z4VGIwy1jRPPdzLAEBjoYH1qUoNEt6aORmsHFPPF
# dvWGUNzBRMhxXFExN6AKOG6N7dcP2CZTfDlhAnrEqv1yaa8dq6z2Nr41JmTamDu6
# GnszrYBbfowQHJ1S/rboYiXcag/PXfT+jlPP1uyFVk3v3byNpOORj7I5LFGc6XBp
# Dco2LXCOMcg1KL3jtIckw+DJj361VI/c+gVVmG1oO5pGve2krnopN6zL64NF50Zu
# yjLVwIYwXE8s4mKyzbnijYjklqwBSru+cakXW2dg3viSkR4dPf0gz3N9QZpGdc3E
# XzTdEonW/aUgfX782Z5F37ZyL9t9X4C626p+Nuw2TPYrbqgSUei/BQOj0XOmTTd0
# lBw0gg/wEPK3Rxjtp+iZfD9M269ewvPV2HM9Q07BMzlMjgK8QmguEOqEUUbi0b1q
# GFphAXPKZ6Je1yh2AuIzGHLXpyDwwvoSCtdjbwzJNmSLW6CmgyFdXzB0kZSU2LlQ
# +QuJYfM2BjUYhEfb3BvR/bLUHMVr9lxSUV0S2yW6r1AFemzFER1y7435UsSFF5PA
# PBXbGjfHCBUYP3irRbb1Hode2o+eFnJpxq57t7c+auIurQIDAQABo4IB3TCCAdkw
# EgYJKwYBBAGCNxUBBAUCAwEAATAjBgkrBgEEAYI3FQIEFgQUKqdS/mTEmr6CkTxG
# NSnPEP8vBO4wHQYDVR0OBBYEFJ+nFV0AXmJdg/Tl0mWnG1M1GelyMFwGA1UdIARV
# MFMwUQYMKwYBBAGCN0yDfQEBMEEwPwYIKwYBBQUHAgEWM2h0dHA6Ly93d3cubWlj
# cm9zb2Z0LmNvbS9wa2lvcHMvRG9jcy9SZXBvc2l0b3J5Lmh0bTATBgNVHSUEDDAK
# BggrBgEFBQcDCDAZBgkrBgEEAYI3FAIEDB4KAFMAdQBiAEMAQTALBgNVHQ8EBAMC
# AYYwDwYDVR0TAQH/BAUwAwEB/zAfBgNVHSMEGDAWgBTV9lbLj+iiXGJo0T2UkFvX
# zpoYxDBWBgNVHR8ETzBNMEugSaBHhkVodHRwOi8vY3JsLm1pY3Jvc29mdC5jb20v
# cGtpL2NybC9wcm9kdWN0cy9NaWNSb29DZXJBdXRfMjAxMC0wNi0yMy5jcmwwWgYI
# KwYBBQUHAQEETjBMMEoGCCsGAQUFBzAChj5odHRwOi8vd3d3Lm1pY3Jvc29mdC5j
# b20vcGtpL2NlcnRzL01pY1Jvb0NlckF1dF8yMDEwLTA2LTIzLmNydDANBgkqhkiG
# 9w0BAQsFAAOCAgEAnVV9/Cqt4SwfZwExJFvhnnJL/Klv6lwUtj5OR2R4sQaTlz0x
# M7U518JxNj/aZGx80HU5bbsPMeTCj/ts0aGUGCLu6WZnOlNN3Zi6th542DYunKmC
# VgADsAW+iehp4LoJ7nvfam++Kctu2D9IdQHZGN5tggz1bSNU5HhTdSRXud2f8449
# xvNo32X2pFaq95W2KFUn0CS9QKC/GbYSEhFdPSfgQJY4rPf5KYnDvBewVIVCs/wM
# nosZiefwC2qBwoEZQhlSdYo2wh3DYXMuLGt7bj8sCXgU6ZGyqVvfSaN0DLzskYDS
# PeZKPmY7T7uG+jIa2Zb0j/aRAfbOxnT99kxybxCrdTDFNLB62FD+CljdQDzHVG2d
# Y3RILLFORy3BFARxv2T5JL5zbcqOCb2zAVdJVGTZc9d/HltEAY5aGZFrDZ+kKNxn
# GSgkujhLmm77IVRrakURR6nxt67I6IleT53S0Ex2tVdUCbFpAUR+fKFhbHP+Crvs
# QWY9af3LwUFJfn6Tvsv4O+S3Fb+0zj6lMVGEvL8CwYKiexcdFYmNcP7ntdAoGokL
# jzbaukz5m/8K6TT4JDVnK+ANuOaMmdbhIurwJ0I9JZTmdHRbatGePu1+oDEzfbzL
# 6Xu/OHBE0ZDxyKs6ijoIYn/ZcGNTTY3ugm2lBRDBcQZqELQdVTNYs6FwZvKhggNQ
# MIICOAIBATCB+aGB0aSBzjCByzELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldhc2hp
# bmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jw
# b3JhdGlvbjElMCMGA1UECxMcTWljcm9zb2Z0IEFtZXJpY2EgT3BlcmF0aW9uczEn
# MCUGA1UECxMeblNoaWVsZCBUU1MgRVNOOkE0MDAtMDVFMC1EOTQ3MSUwIwYDVQQD
# ExxNaWNyb3NvZnQgVGltZS1TdGFtcCBTZXJ2aWNloiMKAQEwBwYFKw4DAhoDFQD5
# r3DVRpAGQo9sTLUHeBC87NpK+qCBgzCBgKR+MHwxCzAJBgNVBAYTAlVTMRMwEQYD
# VQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVNaWNy
# b3NvZnQgQ29ycG9yYXRpb24xJjAkBgNVBAMTHU1pY3Jvc29mdCBUaW1lLVN0YW1w
# IFBDQSAyMDEwMA0GCSqGSIb3DQEBCwUAAgUA6LOZ6zAiGA8yMDIzMDkxOTAzNTQx
# OVoYDzIwMjMwOTIwMDM1NDE5WjB3MD0GCisGAQQBhFkKBAExLzAtMAoCBQDos5nr
# AgEAMAoCAQACAhrPAgH/MAcCAQACAhLcMAoCBQDotOtrAgEAMDYGCisGAQQBhFkK
# BAIxKDAmMAwGCisGAQQBhFkKAwKgCjAIAgEAAgMHoSChCjAIAgEAAgMBhqAwDQYJ
# KoZIhvcNAQELBQADggEBAISwRXM1Lh+zAtEX3eKrVKnBe5QgjwV2LaFg2kb4AI6y
# OwBQlZhSXABCkrQFZ/5j/jkAx6BPZ2eDJ1DAcnnGbsBnEWcdNL1ebBSDSSF53JH/
# 6UsxSE/nJz0ukY8skzLlge8+wL36A5vP8AgGX4H+QdUc86R3YZxevTXISX1K28/Y
# OukCenP3Pt8zVQwkAKcHcg2aN8d9i/qTeRCEYgQsl7Cm4rWdd59LFr2N0ur5EaxJ
# JRYav3rBD5QXKnUTwQHtwsuZ1v6ZagPht9nP5VPCBLuMBszu2EPGZSWhpQT9bUMt
# k72cITfFODlG3lNr3SJdfPLTcGUCOZplQjLsFgI3jQAxggQNMIIECQIBATCBkzB8
# MQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMHUmVk
# bW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMSYwJAYDVQQDEx1N
# aWNyb3NvZnQgVGltZS1TdGFtcCBQQ0EgMjAxMAITMwAAAdYnaf9yLVbIrgABAAAB
# 1jANBglghkgBZQMEAgEFAKCCAUowGgYJKoZIhvcNAQkDMQ0GCyqGSIb3DQEJEAEE
# MC8GCSqGSIb3DQEJBDEiBCC3TbJSS6D4uY0xd8rzRvBwMG6NLwRpXZyE7TkRrwEQ
# ZDCB+gYLKoZIhvcNAQkQAi8xgeowgecwgeQwgb0EINbLTQ1XeNM+EBinOEJMjZd0
# jMNDur+AK+O8P12j5ST8MIGYMIGApH4wfDELMAkGA1UEBhMCVVMxEzARBgNVBAgT
# Cldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29m
# dCBDb3Jwb3JhdGlvbjEmMCQGA1UEAxMdTWljcm9zb2Z0IFRpbWUtU3RhbXAgUENB
# IDIwMTACEzMAAAHWJ2n/ci1WyK4AAQAAAdYwIgQg7Adewd6mJbt045fPeHJQv3DE
# 1kR2DWVU0jJHv3qJnhAwDQYJKoZIhvcNAQELBQAEggIAY1zghDvv8zb72mfAFFGF
# SHuSM9L6d7Hbzf2zFfOkKnhAXunUj9Oh78GjOPEUk0IcCjCkA+UEbK+hp/Rg+DBy
# Xwaj1+l2RFrF5MRMzOqhCGTL6CPUirzmm2rx8LvaHbkv/nK+0GBgYdBI20W18SnL
# 0bnj+WZ5fSDtsbEKxmtVRgzz+J7U3miBUPzJ3h8uc+ZalFmx4F82Zp18yVlDkq9N
# LcOnL29RqpkxBKiYD+wrd5rGIcwUx5gW8+Xh6E3hbecMM4SqYchBKGNfvRYQOOAf
# i64ltZCNWzLGYAPD8gDJS4HOOsHPlcsOjVerbdWLkcbzZ+v8WH3JdhbEu3tRljgv
# JclI9b/rTU67tMV26nnCUhUuGqKR4PfGJ4FDZlXrrEEyjwBLXfgvWhYZQ4Y2+RG9
# PRTm3Gk1k+Eq03QE1xXWAANtzVUK8nMCSOsA4fu1AkXIuAvHwGzfZSKB2HZZG1IV
# ppPk6F5HdR4n35D0berEWzKrEGB0C19IJ/jg2JSu+ugAELFo+pHfMB1W27J/ps1y
# B5GVqW0aG1xEL2a7ycHLoomejaqYV+0jC9xZr00/Alx4iQaK+tzuqAWr60GFZN1m
# ntgG+Gd2VoHjkYsaBS8EPdyZ768XwrchuBPoy4Wbmxi6Yk70EpYpnOu0gm92Tyd/
# vCXflvJ2jZFCxWPgl1tRw6E=
# SIG # End signature block
