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
                $MgCommand | Should -HaveCount 4
                $MgCommand.Command | Select-Object -Unique | should -HaveCount 4
                $MgCommand.Method | Select-Object -Unique | should -HaveCount 2
                $MgCommand.APIVersion | Select-Object -Unique | should -HaveCount 2
                $MgCommand.Variants | Select-Object -Unique | should -HaveCount 3
                $MgCommand.URI | Select-Object -Unique | Should -Be "/users"
                $MgCommand.Command | Select-Object -Unique | Should -BeIn @("New-MgUser", "Get-MgUser", "New-MgBetaUser", "Get-MgBetaUser")
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
                $MgCommand.Variants | Should -Contain "Export"
                $MgCommand.URI | Should -Be "/users/{user-id}/exportPersonalData"
                $MgCommand.Command | Should -Be "Export-MgBetaUserPersonalData"
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
                $MgCommand.URI | Should -Be $ExpectedResourceUri
                $MgCommand.Command | Should -Be "Get-MgBetaEntitlementManagementAccessPackageAssignmentResourceRole"
            } | Should -Not -Throw
        }

        It 'Should find command using URI with query parameters' {
            {
                $Uri = "beta/users?`$select=displayName&`$filter=identities/any(c:c/issuerAssignedId eq 'j.smith@yahoo.com')"
                $MgCommand = Find-MgGraphCommand -Uri $Uri -Method GET -ApiVersion beta
                $MgCommand | Should -HaveCount 1
                $MgCommand.Method | Should -Be "GET"
                $MgCommand.APIVersion | Should -Be "beta"
                $MgCommand.Variants | Should -Contain "List"
                $MgCommand.URI | Should -Be "/users"
                $MgCommand.Command | Should -Be "Get-MgBetaUser"
            } | Should -Not -Throw
        }
        It 'Should find command using escaped URI' {
            {
                $Uri = "/servicePrincipals/n0t3v@l1d3/endpoints%3F=select=id"
                $MgCommand = Find-MgGraphCommand -Uri $Uri -Method POST
                $MgCommand | Should -HaveCount 2
                $MgCommand.Method | Select-Object -Unique | Should -Be "POST"
                $MgCommand.APIVersion | Should -BeIn @("v1.0", "beta")
                $MgCommand.Variants | Should -Contain "Create"
                $MgCommand.URI | Select-Object -Unique | Should -Be "/servicePrincipals/{servicePrincipal-id}/endpoints"
                $MgCommand.Command | Select-Object -Unique | Should -BeIn @("New-MgServicePrincipalEndpoint", "New-MgBetaServicePrincipalEndpoint")
            } | Should -Not -Throw
        }
        It 'Should find command using regex' {
            {
                $Uri = "/users/{id}/calendars/.*"
                $MgCommand = Find-MgGraphCommand -Uri $Uri -Method POST -ApiVersion beta
                $MgCommand.Count | Should -BeGreaterThan 1
                $MgCommand.Method | Select-Object -Unique | Should -Be "POST"
                $MgCommand.APIVersion | Select-Object -Unique | Should -Be "beta"
                $MgCommand.Command | Select-Object -Unique | Should -BeLike "*-MgBetaUserCalendar*"
            } | Should -Not -Throw
        }
        It 'Should find command using action with FQNamespace.' {
            {
                $Uri = "/sites/{site-id}/onenote/pages/{onenotePage-id}/microsoft.graph.onenotePatchContent"
                $MgCommand = Find-MgGraphCommand -Uri $Uri -ApiVersion beta
                $MgCommand.Method | Should -Be "POST"
                $MgCommand.APIVersion | Should -Be "beta"
                $MgCommand.Command | Should -Be "Update-MgBetaSiteOnenotePageContent"
                $MgCommand.Uri | Should -Be "/sites/{site-id}/onenote/pages/{onenotePage-id}/onenotePatchContent"
            } | Should -Not -Throw
        }
        It 'Should find command using action with nested FQNamespace.' {
            {
                $Uri = "/admin/windows/updates/deployments/{deployment-id}/audience/microsoft.graph.windowsUpdates.updateAudience"
                $MgCommand = Find-MgGraphCommand -Uri $Uri -ApiVersion beta
                $MgCommand.Method | Should -Be "POST"
                $MgCommand.APIVersion | Should -Be "beta"
                $MgCommand.Command | Should -Be "Update-MgBetaWindowsUpdatesDeploymentAudience"
                $MgCommand.Uri | Should -Be "/admin/windows/updates/deployments/{deployment-id}/audience/updateAudience"
            } | Should -Not -Throw
        }
        It 'Should find command using function without FQNamespace.' {
            {
                $Uri = "/deviceManagement/assignmentFilters/getState"
                $MgCommand = Find-MgGraphCommand -Uri $Uri -ApiVersion beta
                $MgCommand.Method | Should -Be "GET"
                $MgCommand.APIVersion | Should -Be "beta"
                $MgCommand.Command | Should -Be "Get-MgBetaDeviceManagementAssignmentFilterState"
                $MgCommand.Uri | Should -Be "/deviceManagement/assignmentFilters/getState"
            } | Should -Not -Throw
        }
        It 'Should support pipeline input' {
            {
                $MgCommand = "users", "users/788282" | Find-MgGraphCommand -Method GET
                $MgCommand.Count | Should -BeGreaterThan 1
                $MgCommand.Method | Select-Object -Unique | Should -Be "GET"
                $MgCommand.APIVersion | Select-Object -Unique | Should -BeIn @("v1.0", "beta")
                $MgCommand.Command | Select-Object -Unique | Should -BeIn @("Get-MgUser", "Get-MgBetaUser")
                $MgCommand.Uri | Select-Object -Unique | Should -BeIn @("/users", "/users/{user-id}")
            } | Should -Not -Throw
        }
        It 'Should throw error when URI is invalid' {
            $ExpectedErrorMessage = "*is not valid or is not currently supported by the SDK*"
            { Find-MgGraphCommand -Uri "invalidURI" -Method GET -ErrorAction Stop | Out-Null } | Should -Throw -ExpectedMessage $ExpectedErrorMessage
        }
        It 'Should find command using actual id in key segments inside parenthesis' {
            {
                $ExpectedResourceUri = @("/reports/getSharePointActivityUserCounts(period='{period}')", "/reports/getSharePointActivityUserCounts(period='{period}')")
                $Uri = "/reports/getSharePointActivityUserCounts(period='D3')"
                $MgCommand = Find-MgGraphCommand -Uri $Uri 
                $MgCommand | Should -HaveCount 2
                $MgCommand.Method | Should -Be @("GET", "GET")
                $MgCommand.APIVersion | Should -BeIn @("v1.0", "beta")
                $MgCommand.Variants | Should -Contain "Get"
                $MgCommand.URI | Should -Be $ExpectedResourceUri
                $MgCommand.Command | Should -Be @("Get-MgReportSharePointActivityUserCount", "Get-MgBetaReportSharePointActivityUserCount")
            } | Should -Not -Throw    
        }
        It 'Should find commands for uri with /me segments' {
            {
                $MgCommand = Find-MgGraphCommand -Uri "/me/events/"
                $MgCommand | Should -HaveCount 4
                $MgCommand.Command | Select-Object -Unique | should -HaveCount 4
                $MgCommand.Method | Select-Object -Unique | should -HaveCount 2
                $MgCommand.APIVersion | Select-Object -Unique | should -HaveCount 2
                $MgCommand.Variants | Select-Object -Unique | should -HaveCount 5
                $MgCommand.URI | Select-Object -Unique | Should -Be "/users/{user-id}/events"
                $MgCommand.Command | Select-Object -Unique | Should -BeIn @("New-MgUserEvent", "Get-MgUserEvent", "New-MgBetaUserEvent", "Get-MgBetaUserEvent")
            } | Should -Not -Throw
        }
        It 'Should find commands for uri with /me segments' {
            {
                $MgCommand = Find-MgGraphCommand -Uri "https://graph.microsoft.com/v1.0/me/events/"
                $MgCommand | Should -HaveCount 4
                $MgCommand.Command | Select-Object -Unique | should -HaveCount 4
                $MgCommand.Method | Select-Object -Unique | should -HaveCount 2
                $MgCommand.APIVersion | Select-Object -Unique | should -HaveCount 2
                $MgCommand.Variants | Select-Object -Unique | should -HaveCount 5
                $MgCommand.URI | Select-Object -Unique | Should -Be "/users/{user-id}/events"
                $MgCommand.Command | Select-Object -Unique | Should -BeIn @("New-MgUserEvent", "Get-MgUserEvent", "New-MgBetaUserEvent", "Get-MgBetaUserEvent")
            } | Should -Not -Throw
        }
        It 'Should find commands for uri with Microsoft.Graph prefix in nested segments' {
            {
                $MgCommand = Find-MgGraphCommand -Uri "/identity/authenticationEventsFlows/{authenticationEventsFlow-id}/microsoft.graph.externalUsersSelfServiceSignUpEventsFlow/onAuthenticationMethodLoadStart/microsoft.graph.onAuthenticationMethodLoadStartExternalUsersSelfServiceSignUp/identityProviders"
                $MgCommand | Should -HaveCount 1
                $MgCommand.Command | Select-Object -Unique | should -HaveCount 1
                $MgCommand.Method | Select-Object -Unique | should -HaveCount 1
                $MgCommand.APIVersion | Select-Object -Unique | should -HaveCount 1
                $MgCommand.Variants | Select-Object -Unique | should -HaveCount 1
                $MgCommand.URI | Select-Object -Unique | Should -Be "/identity/authenticationEventsFlows/{authenticationEventsFlow-id}/externalUsersSelfServiceSignUpEventsFlow/onAuthenticationMethodLoadStart/onAuthenticationMethodLoadStartExternalUsersSelfServiceSignUp/identityProviders"
                $MgCommand.Command | Select-Object -Unique | Should -BeIn @("Get-MgBetaIdentityAuthenticationEventFlowAsOnAuthenticationMethodLoadStartExternalUserSelfServiceSignUpIdentityProvider")
            } | Should -Not -Throw
        }
    }

    Context "FindByCommand" {
        It 'Should find command using only mandatory parameters' {
            {
                $MgCommand = Find-MgGraphCommand -Command "Get-MgUser"
                $MgCommand | Should -HaveCount 2 # /users and /users/{id}.
                $MgCommand[0].Method | Select-Object -Unique | Should -Be "GET"
                $MgCommand[0].APIVersion | Select-Object -Unique | Should -Be "v1.0"
                $MgCommand[0].Command | Select-Object -Unique | Should -Be "Get-MgUser"
            } | Should -Not -Throw
        }
        Context "FindByCommand" {
            It 'Should find command using all parameters' {
                {
                    $MgCommand = Find-MgGraphCommand -Command "Invoke-MgBetaAcceptGroupCalendarEvent" -ApiVersion beta
                    $MgCommand | Should -HaveCount 1
                    $MgCommand.Method | Should -Be "POST"
                    $MgCommand.APIVersion | Should -Be "beta"
                    $MgCommand.Command | Should -Be "Invoke-MgBetaAcceptGroupCalendarEvent"
                    $MgCommand.URI | Should -Be "/groups/{group-id}/calendar/events/{event-id}/accept"
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
            It 'Should throw error when command name is invalid' {
                {
                    Find-MgGraphCommand -Command "New-MgInvalid" -ErrorAction Stop | Out-Null
                } | Should -Throw -ExpectedMessage "*'New-MgInvalid' is not a valid Microsoft Graph PowerShell command.*"
            }
        }
    }
}
# SIG # Begin signature block
# MIIn0QYJKoZIhvcNAQcCoIInwjCCJ74CAQExDzANBglghkgBZQMEAgEFADB5Bgor
# BgEEAYI3AgEEoGswaTA0BgorBgEEAYI3AgEeMCYCAwEAAAQQH8w7YFlLCE63JNLG
# KX7zUQIBAAIBAAIBAAIBAAIBADAxMA0GCWCGSAFlAwQCAQUABCCXU0wQM5yHUC9K
# uzv/Q9pTWOM2LURV4vGkZ/U4k5ljrqCCDYUwggYDMIID66ADAgECAhMzAAADri01
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
# cVZOSEXAQsmbdlsKgEhr/Xmfwb1tbWrJUnMTDXpQzTGCGaIwghmeAgEBMIGVMH4x
# CzAJBgNVBAYTAlVTMRMwEQYDVQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRt
# b25kMR4wHAYDVQQKExVNaWNyb3NvZnQgQ29ycG9yYXRpb24xKDAmBgNVBAMTH01p
# Y3Jvc29mdCBDb2RlIFNpZ25pbmcgUENBIDIwMTECEzMAAAOuLTVRyFOPVR0AAAAA
# A64wDQYJYIZIAWUDBAIBBQCgga4wGQYJKoZIhvcNAQkDMQwGCisGAQQBgjcCAQQw
# HAYKKwYBBAGCNwIBCzEOMAwGCisGAQQBgjcCARUwLwYJKoZIhvcNAQkEMSIEICuj
# +7yP6++OWRTibF7H/H4MJ0hvBIUaAMKd+aLpWW0cMEIGCisGAQQBgjcCAQwxNDAy
# oBSAEgBNAGkAYwByAG8AcwBvAGYAdKEagBhodHRwOi8vd3d3Lm1pY3Jvc29mdC5j
# b20wDQYJKoZIhvcNAQEBBQAEggEAAgi9VpsajylJIXFFtKXQO75yw6qYTQE7jdas
# J9R/pH7cQIANyQ8OmgG/iGY4c8XZ9pwcgmi/ziSXBuV2YdJPZSs06zBcqB6Q9upy
# Nhwb9dfS19C2zscfbxYFYw0iFUP/JNA/eRXOBrXKV4aQVliyL0cmm+W76Ua//wSC
# 8XKimdwkNBZWmVzw7pdjX1XhLHFTrp2AFbYegHMC3r/v3Pf3KO/8tkcClqET6e6c
# /bkeZJgP24sWb9aZaxkRofw9kJZXlRTjV03GEaMaj2/21+ed79afLgS7o2xdnS65
# u6YvRuyxD8QFDeQdaaOPwLH8qO/GrGhSQmANXxrqv5/bcXTrbaGCFywwghcoBgor
# BgEEAYI3AwMBMYIXGDCCFxQGCSqGSIb3DQEHAqCCFwUwghcBAgEDMQ8wDQYJYIZI
# AWUDBAIBBQAwggFZBgsqhkiG9w0BCRABBKCCAUgEggFEMIIBQAIBAQYKKwYBBAGE
# WQoDATAxMA0GCWCGSAFlAwQCAQUABCCVqnNoOLGEkKhrcgv0lpoadriy3eRg+Eco
# A8U/WWEbRAIGZfydamPrGBMyMDI0MDQwOTIyMDcxOS44NjZaMASAAgH0oIHYpIHV
# MIHSMQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMH
# UmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMS0wKwYDVQQL
# EyRNaWNyb3NvZnQgSXJlbGFuZCBPcGVyYXRpb25zIExpbWl0ZWQxJjAkBgNVBAsT
# HVRoYWxlcyBUU1MgRVNOOkZDNDEtNEJENC1EMjIwMSUwIwYDVQQDExxNaWNyb3Nv
# ZnQgVGltZS1TdGFtcCBTZXJ2aWNloIIRezCCBycwggUPoAMCAQICEzMAAAHimZmV
# 8dzjIOsAAQAAAeIwDQYJKoZIhvcNAQELBQAwfDELMAkGA1UEBhMCVVMxEzARBgNV
# BAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jv
# c29mdCBDb3Jwb3JhdGlvbjEmMCQGA1UEAxMdTWljcm9zb2Z0IFRpbWUtU3RhbXAg
# UENBIDIwMTAwHhcNMjMxMDEyMTkwNzI1WhcNMjUwMTEwMTkwNzI1WjCB0jELMAkG
# A1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQx
# HjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjEtMCsGA1UECxMkTWljcm9z
# b2Z0IElyZWxhbmQgT3BlcmF0aW9ucyBMaW1pdGVkMSYwJAYDVQQLEx1UaGFsZXMg
# VFNTIEVTTjpGQzQxLTRCRDQtRDIyMDElMCMGA1UEAxMcTWljcm9zb2Z0IFRpbWUt
# U3RhbXAgU2VydmljZTCCAiIwDQYJKoZIhvcNAQEBBQADggIPADCCAgoCggIBALVj
# tZhV+kFmb8cKQpg2mzisDlRI978Gb2amGvbAmCd04JVGeTe/QGzM8KbQrMDol7DC
# 7jS03JkcrPsWi9WpVwsIckRQ8AkX1idBG9HhyCspAavfuvz55khl7brPQx7H99UJ
# bsE3wMmpmJasPWpgF05zZlvpWQDULDcIYyl5lXI4HVZ5N6MSxWO8zwWr4r9xkMmU
# Xs7ICxDJr5a39SSePAJRIyznaIc0WzZ6MFcTRzLLNyPBE4KrVv1LFd96FNxAzwne
# tSePg88EmRezr2T3HTFElneJXyQYd6YQ7eCIc7yllWoY03CEg9ghorp9qUKcBUfF
# cS4XElf3GSERnlzJsK7s/ZGPU4daHT2jWGoYha2QCOmkgjOmBFCqQFFwFmsPrZj4
# eQszYxq4c4HqPnUu4hT4aqpvUZ3qIOXbdyU42pNL93cn0rPTTleOUsOQbgvlRdth
# FCBepxfb6nbsp3fcZaPBfTbtXVa8nLQuMCBqyfsebuqnbwj+lHQfqKpivpyd7KCW
# ACoj78XUwYqy1HyYnStTme4T9vK6u2O/KThfROeJHiSg44ymFj+34IcFEhPogaKv
# NNsTVm4QbqphCyknrwByqorBCLH6bllRtJMJwmu7GRdTQsIx2HMKqphEtpSm1z3u
# fASdPrgPhsQIRFkHZGuihL1Jjj4Lu3CbAmha0lOrAgMBAAGjggFJMIIBRTAdBgNV
# HQ4EFgQURIQOEdq+7QdslptJiCRNpXgJ2gUwHwYDVR0jBBgwFoAUn6cVXQBeYl2D
# 9OXSZacbUzUZ6XIwXwYDVR0fBFgwVjBUoFKgUIZOaHR0cDovL3d3dy5taWNyb3Nv
# ZnQuY29tL3BraW9wcy9jcmwvTWljcm9zb2Z0JTIwVGltZS1TdGFtcCUyMFBDQSUy
# MDIwMTAoMSkuY3JsMGwGCCsGAQUFBwEBBGAwXjBcBggrBgEFBQcwAoZQaHR0cDov
# L3d3dy5taWNyb3NvZnQuY29tL3BraW9wcy9jZXJ0cy9NaWNyb3NvZnQlMjBUaW1l
# LVN0YW1wJTIwUENBJTIwMjAxMCgxKS5jcnQwDAYDVR0TAQH/BAIwADAWBgNVHSUB
# Af8EDDAKBggrBgEFBQcDCDAOBgNVHQ8BAf8EBAMCB4AwDQYJKoZIhvcNAQELBQAD
# ggIBAORURDGrVRTbnulfsg2cTsyyh7YXvhVU7NZMkITAQYsFEPVgvSviCylr5ap3
# ka76Yz0t/6lxuczI6w7tXq8n4WxUUgcj5wAhnNorhnD8ljYqbck37fggYK3+wEwL
# hP1PGC5tvXK0xYomU1nU+lXOy9ZRnShI/HZdFrw2srgtsbWow9OMuADS5lg7okrX
# a2daCOGnxuaD1IO+65E7qv2O0W0sGj7AWdOjNdpexPrspL2KEcOMeJVmkk/O0gan
# hFzzHAnWjtNWneU11WQ6Bxv8OpN1fY9wzQoiycgvOOJM93od55EGeXxfF8bofLVl
# UE3zIikoSed+8s61NDP+x9RMya2mwK/Ys1xdvDlZTHndIKssfmu3vu/a+BFf2uIo
# ycVTvBQpv/drRJD68eo401mkCRFkmy/+BmQlRrx2rapqAu5k0Nev+iUdBUKmX/iO
# aKZ75vuQg7hCiBA5xIm5ZIXDSlX47wwFar3/BgTwntMq9ra6QRAeS/o/uYWkmvqv
# E8Aq38QmKgTiBnWSS/uVPcaHEyArnyFh5G+qeCGmL44MfEnFEhxc3saPmXhe6MhS
# gCIGJUZDA7336nQD8fn4y6534Lel+LuT5F5bFt0mLwd+H5GxGzObZmm/c3pEWtHv
# 1ug7dS/Dfrcd1sn2E4gk4W1L1jdRBbK9xwkMmwY+CHZeMSvBMIIHcTCCBVmgAwIB
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
# Y1NNje6CbaUFEMFxBmoQtB1VM1izoXBm8qGCAtcwggJAAgEBMIIBAKGB2KSB1TCB
# 0jELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1Jl
# ZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjEtMCsGA1UECxMk
# TWljcm9zb2Z0IElyZWxhbmQgT3BlcmF0aW9ucyBMaW1pdGVkMSYwJAYDVQQLEx1U
# aGFsZXMgVFNTIEVTTjpGQzQxLTRCRDQtRDIyMDElMCMGA1UEAxMcTWljcm9zb2Z0
# IFRpbWUtU3RhbXAgU2VydmljZaIjCgEBMAcGBSsOAwIaAxUAFpuZafp0bnpJdIhf
# iB1d8pTohm+ggYMwgYCkfjB8MQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGlu
# Z3RvbjEQMA4GA1UEBxMHUmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBv
# cmF0aW9uMSYwJAYDVQQDEx1NaWNyb3NvZnQgVGltZS1TdGFtcCBQQ0EgMjAxMDAN
# BgkqhkiG9w0BAQUFAAIFAOm/fc8wIhgPMjAyNDA0MDkxNjQxNTFaGA8yMDI0MDQx
# MDE2NDE1MVowdzA9BgorBgEEAYRZCgQBMS8wLTAKAgUA6b99zwIBADAKAgEAAgIP
# wwIB/zAHAgEAAgITNDAKAgUA6cDPTwIBADA2BgorBgEEAYRZCgQCMSgwJjAMBgor
# BgEEAYRZCgMCoAowCAIBAAIDB6EgoQowCAIBAAIDAYagMA0GCSqGSIb3DQEBBQUA
# A4GBAD0Rnav5FZpnZNbnUSDs039aMsrNE3Avor32tZfJshHsVwpAnDCnQROy2ZcK
# dzkYJuBY82VVMQVS5sRWrt92QEjIYQhHe6990r9pzl4w34yUVuHrSqehKMourEFE
# GsGmQeh079JJOzSae0KYJJLkRHjUtCa0SWmehCYvcmH1Xo/SMYIEDTCCBAkCAQEw
# gZMwfDELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNVBAcT
# B1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjEmMCQGA1UE
# AxMdTWljcm9zb2Z0IFRpbWUtU3RhbXAgUENBIDIwMTACEzMAAAHimZmV8dzjIOsA
# AQAAAeIwDQYJYIZIAWUDBAIBBQCgggFKMBoGCSqGSIb3DQEJAzENBgsqhkiG9w0B
# CRABBDAvBgkqhkiG9w0BCQQxIgQgyKa8nprM/C1AYeC73bpN4YPAzMMAKxrQZXsl
# kzDPDZ4wgfoGCyqGSIb3DQEJEAIvMYHqMIHnMIHkMIG9BCAriSpKEP0muMbBUETO
# DoL4d5LU6I/bjucIZkOJCI9//zCBmDCBgKR+MHwxCzAJBgNVBAYTAlVTMRMwEQYD
# VQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVNaWNy
# b3NvZnQgQ29ycG9yYXRpb24xJjAkBgNVBAMTHU1pY3Jvc29mdCBUaW1lLVN0YW1w
# IFBDQSAyMDEwAhMzAAAB4pmZlfHc4yDrAAEAAAHiMCIEIEP6EiE7SaAGmoTdOD17
# urIEIn0m2V+Nzu9Hv1zrEBH9MA0GCSqGSIb3DQEBCwUABIICAFQu/m2zN7EVQIaf
# dBakgZp2IdUl9wczQd2an+lkmWWlnLbN7se2oscnOezaoG9srPk0hh3PQtRp/0bl
# u2GkZo9YSw8ExTtyrFvFjneFdVFyhGjIo4MK3I4U/Va8xPxohJUr1CdyKO6koCAm
# hTlUcGacndUsOQRgOlZ2EGnE4obuko/7P6sNeUDrQa6sDpAbLs35TgyCARpWsvNo
# qphxMZEoH8mBMBdmoBHRvsI4GzhfFMyLmVkrmw7Nc60nhaDy23ul8L7QCuAPdoSO
# mNjEum7kAusK9iL2y5UFVzcCvaAGt6bHoraEVDB3NkYTgpkoffx8Q0bbp0G1u243
# uK3SYsLVTajp3BI+/U8u5NqFEf76e5ZSv6mULiKe9wzsGMpT3aTMCOcoPTBsjbWl
# aozNeOp2PzqnVsxFwqqCXBwQObrqhtNq/CGoNCHR7zsK8N4L/Xi+SraFK6jJcSJF
# IZdthGVsJDmzy4in0lEomgjOX7vIUTBGhBfhm8lU4G+QBNQvVGeHyy5lpOGl4Np0
# NmqaWATMlsGICoccHbnYsUel5OT9ilv5NJysrld2qXqf5iYmF+cMjhttaBLnnm12
# 5DHWENi4F3we8R5QFr/OwjSI1ta52cqQmKqtVtvNK9r+idwY63WtSNaZSACTJJa4
# ssL4fqS9RGtLoCHEDNJ6HdEIbzS5
# SIG # End signature block
