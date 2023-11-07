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
        It 'Should find commands for uri woth /me segments' {
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
        It 'Should find commands for uri woth /me segments' {
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
# MIIoKQYJKoZIhvcNAQcCoIIoGjCCKBYCAQExDzANBglghkgBZQMEAgEFADB5Bgor
# BgEEAYI3AgEEoGswaTA0BgorBgEEAYI3AgEeMCYCAwEAAAQQH8w7YFlLCE63JNLG
# KX7zUQIBAAIBAAIBAAIBAAIBADAxMA0GCWCGSAFlAwQCAQUABCDzAwrYLBeHHYb4
# xi+R1O0f89YgN90ehbovShGh+vOv4qCCDXYwggX0MIID3KADAgECAhMzAAADTrU8
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
# /Xmfwb1tbWrJUnMTDXpQzTGCGgkwghoFAgEBMIGVMH4xCzAJBgNVBAYTAlVTMRMw
# EQYDVQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVN
# aWNyb3NvZnQgQ29ycG9yYXRpb24xKDAmBgNVBAMTH01pY3Jvc29mdCBDb2RlIFNp
# Z25pbmcgUENBIDIwMTECEzMAAANOtTx6wYRv6ysAAAAAA04wDQYJYIZIAWUDBAIB
# BQCgga4wGQYJKoZIhvcNAQkDMQwGCisGAQQBgjcCAQQwHAYKKwYBBAGCNwIBCzEO
# MAwGCisGAQQBgjcCARUwLwYJKoZIhvcNAQkEMSIEIDZUrQ591SyIHYjvsYzfRFkK
# H3T8Z/QswtISTDZJ98BrMEIGCisGAQQBgjcCAQwxNDAyoBSAEgBNAGkAYwByAG8A
# cwBvAGYAdKEagBhodHRwOi8vd3d3Lm1pY3Jvc29mdC5jb20wDQYJKoZIhvcNAQEB
# BQAEggEAuwoy+LVpygJhnIsR4P+YuhpVb7kze4sWC4bgAFTvD1PFcOEX6TdeGaiI
# DpEv0g5JhfMyNUb6Pu7sWWoJFPFjpc4HyKuEpHWJUwvmR4DJ8RuEbnNGC02y6A9u
# QF8kmPlPQ3up8OmUiJs/juCNkJB5bxj+NmejwJOSEXq3MhqWHh+w24g/qX8pVVeq
# 6x0qq570B+kkrIoavgyUyL8TKyRZESCoLp1PRCKj7c3YeHZN1CkxthG+k3SG2LG6
# n3t3ZVFKHvVPtRkI/bzNoH8YKhS+bANyTvUOdS89yEhwZR7dXS1ok7DqHLfBAoJj
# tLf7ea9jrjoOgckCZ5CJEnlGT7J3hKGCF5MwghePBgorBgEEAYI3AwMBMYIXfzCC
# F3sGCSqGSIb3DQEHAqCCF2wwghdoAgEDMQ8wDQYJYIZIAWUDBAIBBQAwggFRBgsq
# hkiG9w0BCRABBKCCAUAEggE8MIIBOAIBAQYKKwYBBAGEWQoDATAxMA0GCWCGSAFl
# AwQCAQUABCCrp5r3nF0cOnxxgb9EO5TeoucCSIZzii9xWOr4YXF1jgIGZSiVwM2b
# GBIyMDIzMTEwNzEyMTg0NC4zNFowBIACAfSggdGkgc4wgcsxCzAJBgNVBAYTAlVT
# MRMwEQYDVQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQK
# ExVNaWNyb3NvZnQgQ29ycG9yYXRpb24xJTAjBgNVBAsTHE1pY3Jvc29mdCBBbWVy
# aWNhIE9wZXJhdGlvbnMxJzAlBgNVBAsTHm5TaGllbGQgVFNTIEVTTjo4OTAwLTA1
# RTAtRDk0NzElMCMGA1UEAxMcTWljcm9zb2Z0IFRpbWUtU3RhbXAgU2VydmljZaCC
# EeowggcgMIIFCKADAgECAhMzAAAB0x0ymhc7QDBzAAEAAAHTMA0GCSqGSIb3DQEB
# CwUAMHwxCzAJBgNVBAYTAlVTMRMwEQYDVQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQH
# EwdSZWRtb25kMR4wHAYDVQQKExVNaWNyb3NvZnQgQ29ycG9yYXRpb24xJjAkBgNV
# BAMTHU1pY3Jvc29mdCBUaW1lLVN0YW1wIFBDQSAyMDEwMB4XDTIzMDUyNTE5MTIy
# NFoXDTI0MDIwMTE5MTIyNFowgcsxCzAJBgNVBAYTAlVTMRMwEQYDVQQIEwpXYXNo
# aW5ndG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVNaWNyb3NvZnQgQ29y
# cG9yYXRpb24xJTAjBgNVBAsTHE1pY3Jvc29mdCBBbWVyaWNhIE9wZXJhdGlvbnMx
# JzAlBgNVBAsTHm5TaGllbGQgVFNTIEVTTjo4OTAwLTA1RTAtRDk0NzElMCMGA1UE
# AxMcTWljcm9zb2Z0IFRpbWUtU3RhbXAgU2VydmljZTCCAiIwDQYJKoZIhvcNAQEB
# BQADggIPADCCAgoCggIBALSOq5M3iDXFuFcJzwxX5067xSpzcpttpa2Lm92wBYzU
# Ph9VKL7g1aAa0/8FVFitWPahWeczLR5rOJ1A4ni5SxwExs8dozFo2mBtEb0URBEW
# dwBSm1acj5U+Xnc8Pow8vTLPxwcLZkPfB4XjD64wMAacvfoGSbSys41e+cz142+c
# bl2OikSqIeh1ZJq5HJ7i5+0FHaxPAYdWbEq7QZLh87zs2BsnhUbMgJHJlfD35G+9
# cwb+OEzXUfwBYrMqmfSgwabUxIx428tRZvfUdJl6TH80ES1e+Z2jvk5XTfQ0eAhe
# KHFgR5KBQjF9sjk6aAyr9UMJCnav9/L/k1VrcqMJCg2qaYQzqisAnZcqNiEQnOin
# idYJwn3vRTqtekE8rhcY0oEWGEtrvhMz/KxMUisRc4kbV9S5d9x1ZvQTHQUB5NOv
# qCaYKqt4k16M0d98b9UR4Xss29Sq5gVGd2IJSGDLrbitbqm1ydBOJF8TRAv+AsXj
# WQDa9kxjNxzXoSJhdBAFoXdcC0x26HV2lepM89AQ7cyzn/kH8q2OFKykxw9S9G9v
# fkhY36r4v7MTCKmGacIYVO7I4ypzlATSu4Y3czHRW/rH+Fw6ZpfGsdAak0ojk+fv
# 1iTz0ByWpTaZcfPVkdan4oFzcPpU/svfYmXDGEnHdqxrTznG/Rc8PnwxFbVZoa9p
# AgMBAAGjggFJMIIBRTAdBgNVHQ4EFgQU0scghrgUAPj3jPfmG/MKabTjXmIwHwYD
# VR0jBBgwFoAUn6cVXQBeYl2D9OXSZacbUzUZ6XIwXwYDVR0fBFgwVjBUoFKgUIZO
# aHR0cDovL3d3dy5taWNyb3NvZnQuY29tL3BraW9wcy9jcmwvTWljcm9zb2Z0JTIw
# VGltZS1TdGFtcCUyMFBDQSUyMDIwMTAoMSkuY3JsMGwGCCsGAQUFBwEBBGAwXjBc
# BggrBgEFBQcwAoZQaHR0cDovL3d3dy5taWNyb3NvZnQuY29tL3BraW9wcy9jZXJ0
# cy9NaWNyb3NvZnQlMjBUaW1lLVN0YW1wJTIwUENBJTIwMjAxMCgxKS5jcnQwDAYD
# VR0TAQH/BAIwADAWBgNVHSUBAf8EDDAKBggrBgEFBQcDCDAOBgNVHQ8BAf8EBAMC
# B4AwDQYJKoZIhvcNAQELBQADggIBAEBiWFihRD7hppDngwU18ToTLy/ita/4u0NF
# KMwzZf2Di5qcD1xTtWK12kg9X/MTq/gASF79WeDZQBHmqPZJXezP58Oo3pUtZRmw
# pHRBHYlhcqcU9FWPXp7NnI/vN3kfwiy+xwRyid5f5pEcXTEYYzi0MutLzi+PpGbR
# uChYtdacxNnmQ/ijCcaabQuyYie67QYqsNmeR5NWZ+TyBNPLx3XLc/YhhzZQjiIl
# hcK5JooK4V47TCrKxym+EZBKejVcAUrehrJu4PWZKhDFP2rvv4sAYZBuJKgaWBON
# BBrJixBo9wbVDhA3A40aqQBIJlNvMmWeaQeCRaUpItO6U5qKVYhjiFLURn7D6xfQ
# En0twzXjaHnU6Vcsyg8unMcBvrHbaKloAnkp/e7IVo4pbDiGe7TNaz48o93X3ad1
# 4raiBZ9oV1+cS+RYMMfZ2gv5kDlAF3xeeCz+Z3cGueWXYGRn+CJkT98rKiWuJHdp
# MBYLEUJcoiX8KW7ZtueP2p9VgukBVARw9oJ9MB/s5kGVeaW4RO+rVj9I2HELownV
# AsKeRdIj/+JdimZEpPvzdApGCaj/jO2Pe4v1nvFtsbEhKD4/QdNFfXnLhNF4Fs7Z
# EU3IKPzyA45GT6zBPWRopdR8YHjOODle6XFJvLe4s3FB5sTpMTdwArT5+djlSkdo
# R2XDh7uKMIIHcTCCBVmgAwIBAgITMwAAABXF52ueAptJmQAAAAAAFTANBgkqhkiG
# 9w0BAQsFADCBiDELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAO
# BgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjEy
# MDAGA1UEAxMpTWljcm9zb2Z0IFJvb3QgQ2VydGlmaWNhdGUgQXV0aG9yaXR5IDIw
# MTAwHhcNMjEwOTMwMTgyMjI1WhcNMzAwOTMwMTgzMjI1WjB8MQswCQYDVQQGEwJV
# UzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMHUmVkbW9uZDEeMBwGA1UE
# ChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMSYwJAYDVQQDEx1NaWNyb3NvZnQgVGlt
# ZS1TdGFtcCBQQ0EgMjAxMDCCAiIwDQYJKoZIhvcNAQEBBQADggIPADCCAgoCggIB
# AOThpkzntHIhC3miy9ckeb0O1YLT/e6cBwfSqWxOdcjKNVf2AX9sSuDivbk+F2Az
# /1xPx2b3lVNxWuJ+Slr+uDZnhUYjDLWNE893MsAQGOhgfWpSg0S3po5GawcU88V2
# 9YZQ3MFEyHFcUTE3oAo4bo3t1w/YJlN8OWECesSq/XJprx2rrPY2vjUmZNqYO7oa
# ezOtgFt+jBAcnVL+tuhiJdxqD89d9P6OU8/W7IVWTe/dvI2k45GPsjksUZzpcGkN
# yjYtcI4xyDUoveO0hyTD4MmPfrVUj9z6BVWYbWg7mka97aSueik3rMvrg0XnRm7K
# MtXAhjBcTyziYrLNueKNiOSWrAFKu75xqRdbZ2De+JKRHh09/SDPc31BmkZ1zcRf
# NN0Sidb9pSB9fvzZnkXftnIv231fgLrbqn427DZM9ituqBJR6L8FA6PRc6ZNN3SU
# HDSCD/AQ8rdHGO2n6Jl8P0zbr17C89XYcz1DTsEzOUyOArxCaC4Q6oRRRuLRvWoY
# WmEBc8pnol7XKHYC4jMYctenIPDC+hIK12NvDMk2ZItboKaDIV1fMHSRlJTYuVD5
# C4lh8zYGNRiER9vcG9H9stQcxWv2XFJRXRLbJbqvUAV6bMURHXLvjflSxIUXk8A8
# FdsaN8cIFRg/eKtFtvUeh17aj54WcmnGrnu3tz5q4i6tAgMBAAGjggHdMIIB2TAS
# BgkrBgEEAYI3FQEEBQIDAQABMCMGCSsGAQQBgjcVAgQWBBQqp1L+ZMSavoKRPEY1
# Kc8Q/y8E7jAdBgNVHQ4EFgQUn6cVXQBeYl2D9OXSZacbUzUZ6XIwXAYDVR0gBFUw
# UzBRBgwrBgEEAYI3TIN9AQEwQTA/BggrBgEFBQcCARYzaHR0cDovL3d3dy5taWNy
# b3NvZnQuY29tL3BraW9wcy9Eb2NzL1JlcG9zaXRvcnkuaHRtMBMGA1UdJQQMMAoG
# CCsGAQUFBwMIMBkGCSsGAQQBgjcUAgQMHgoAUwB1AGIAQwBBMAsGA1UdDwQEAwIB
# hjAPBgNVHRMBAf8EBTADAQH/MB8GA1UdIwQYMBaAFNX2VsuP6KJcYmjRPZSQW9fO
# mhjEMFYGA1UdHwRPME0wS6BJoEeGRWh0dHA6Ly9jcmwubWljcm9zb2Z0LmNvbS9w
# a2kvY3JsL3Byb2R1Y3RzL01pY1Jvb0NlckF1dF8yMDEwLTA2LTIzLmNybDBaBggr
# BgEFBQcBAQROMEwwSgYIKwYBBQUHMAKGPmh0dHA6Ly93d3cubWljcm9zb2Z0LmNv
# bS9wa2kvY2VydHMvTWljUm9vQ2VyQXV0XzIwMTAtMDYtMjMuY3J0MA0GCSqGSIb3
# DQEBCwUAA4ICAQCdVX38Kq3hLB9nATEkW+Geckv8qW/qXBS2Pk5HZHixBpOXPTEz
# tTnXwnE2P9pkbHzQdTltuw8x5MKP+2zRoZQYIu7pZmc6U03dmLq2HnjYNi6cqYJW
# AAOwBb6J6Gngugnue99qb74py27YP0h1AdkY3m2CDPVtI1TkeFN1JFe53Z/zjj3G
# 82jfZfakVqr3lbYoVSfQJL1AoL8ZthISEV09J+BAljis9/kpicO8F7BUhUKz/Aye
# ixmJ5/ALaoHCgRlCGVJ1ijbCHcNhcy4sa3tuPywJeBTpkbKpW99Jo3QMvOyRgNI9
# 5ko+ZjtPu4b6MhrZlvSP9pEB9s7GdP32THJvEKt1MMU0sHrYUP4KWN1APMdUbZ1j
# dEgssU5HLcEUBHG/ZPkkvnNtyo4JvbMBV0lUZNlz138eW0QBjloZkWsNn6Qo3GcZ
# KCS6OEuabvshVGtqRRFHqfG3rsjoiV5PndLQTHa1V1QJsWkBRH58oWFsc/4Ku+xB
# Zj1p/cvBQUl+fpO+y/g75LcVv7TOPqUxUYS8vwLBgqJ7Fx0ViY1w/ue10CgaiQuP
# Ntq6TPmb/wrpNPgkNWcr4A245oyZ1uEi6vAnQj0llOZ0dFtq0Z4+7X6gMTN9vMvp
# e784cETRkPHIqzqKOghif9lwY1NNje6CbaUFEMFxBmoQtB1VM1izoXBm8qGCA00w
# ggI1AgEBMIH5oYHRpIHOMIHLMQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGlu
# Z3RvbjEQMA4GA1UEBxMHUmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBv
# cmF0aW9uMSUwIwYDVQQLExxNaWNyb3NvZnQgQW1lcmljYSBPcGVyYXRpb25zMScw
# JQYDVQQLEx5uU2hpZWxkIFRTUyBFU046ODkwMC0wNUUwLUQ5NDcxJTAjBgNVBAMT
# HE1pY3Jvc29mdCBUaW1lLVN0YW1wIFNlcnZpY2WiIwoBATAHBgUrDgMCGgMVAFLH
# bdwxw0HUhDCz8tiRFdrsjkmwoIGDMIGApH4wfDELMAkGA1UEBhMCVVMxEzARBgNV
# BAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jv
# c29mdCBDb3Jwb3JhdGlvbjEmMCQGA1UEAxMdTWljcm9zb2Z0IFRpbWUtU3RhbXAg
# UENBIDIwMTAwDQYJKoZIhvcNAQELBQACBQDo9AjWMCIYDzIwMjMxMTA3MDA1MjM4
# WhgPMjAyMzExMDgwMDUyMzhaMHQwOgYKKwYBBAGEWQoEATEsMCowCgIFAOj0CNYC
# AQAwBwIBAAICLrwwBwIBAAICE5owCgIFAOj1WlYCAQAwNgYKKwYBBAGEWQoEAjEo
# MCYwDAYKKwYBBAGEWQoDAqAKMAgCAQACAwehIKEKMAgCAQACAwGGoDANBgkqhkiG
# 9w0BAQsFAAOCAQEAILHIn1TO1i4SV8cBoMJzJI7OaONYGYfwKsSrxJtbBrLs4NLF
# 1WwJ948IXjMBxyOgV5w7sMd6CU7WuBbBi1+Q27Oucs+9awrR3Zz2ePir7mfOP71d
# wfXz7J/StU26bRBSo2h2BTcW1WKY1E2+bzUFzr4jGCOLJDsPjhZeu2upSurhwwrR
# vpQY0uUxACGZgPskiHusQsxrLLMVuyz2QGZGYL86nfUmWD6L2hIuamMC5vXO0fUS
# jzoMEiWlmt9ytw/lCMkIMJ1FE+ZbdbiXG/E2usV3INgTuIMwKJ/3pWqdnhj2pl94
# pk9kwMuEu31JLNVyBj4FLgV5BIZX/0wI0/e2WzGCBA0wggQJAgEBMIGTMHwxCzAJ
# BgNVBAYTAlVTMRMwEQYDVQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRtb25k
# MR4wHAYDVQQKExVNaWNyb3NvZnQgQ29ycG9yYXRpb24xJjAkBgNVBAMTHU1pY3Jv
# c29mdCBUaW1lLVN0YW1wIFBDQSAyMDEwAhMzAAAB0x0ymhc7QDBzAAEAAAHTMA0G
# CWCGSAFlAwQCAQUAoIIBSjAaBgkqhkiG9w0BCQMxDQYLKoZIhvcNAQkQAQQwLwYJ
# KoZIhvcNAQkEMSIEIEUHsQWFodL0L3ThzMyyG6vDeH49CgB1+LA71qNrxlY5MIH6
# BgsqhkiG9w0BCRACLzGB6jCB5zCB5DCBvQQgkmb06sTg7k9YDUpoVrO2v24/3qtC
# ASf62Aa1jfE6qvUwgZgwgYCkfjB8MQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2Fz
# aGluZ3RvbjEQMA4GA1UEBxMHUmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENv
# cnBvcmF0aW9uMSYwJAYDVQQDEx1NaWNyb3NvZnQgVGltZS1TdGFtcCBQQ0EgMjAx
# MAITMwAAAdMdMpoXO0AwcwABAAAB0zAiBCCmkx7Nro+PFnbflzfweYwVUuysXlhT
# AtlkMJE9PRdVojANBgkqhkiG9w0BAQsFAASCAgB5EUjlIOMeY3OBV5vPJJTomOYu
# 8+PAf1L8pUadHLYIHrO3OU/7f92FKNNDb06LuKeA1wl9e/8dYL4e+C24MYWVSaKX
# N6PkTqDAfpBJxx1pJ1cC0Hy9Q715Nl3Dxuvij6CbsdPElHoAoNHZ8FZKSY8tSc9z
# UfCMCVVZS5VW4QofOr9sbvBv6+UO/FrIMvc8JxqK2jc/ZfwehY4/tQwtLiTppgiq
# YC1UHvhGuGW/Kpw3ngBCgEjQv4Wdc86aH+PySDGvS4GinXy9e09voGSFpkk47Z2O
# T5sY8pm911lS+gkp9ccUlaiBiNpkThPvokTcO48eMcjyGPRI1jf8xMw+Ua0oh8Qq
# m9yAZ1OmgA1rlc2pd5ZuYaaSFetVvoztopFB5KLUJsqRQnswC4BghNaOpGoU7GnS
# rxkij9EpAv5m/UoXn3FAnJf95cmY8/7dy3HkeF85C6/kRHPcC8NsZhdJe24InBTk
# Yvr/gQNB4UNWhjMNZ4rJXL0cUbRx18g6atpRUJkKzBXmW2wxAfplfrmvPjNn7SRq
# ZtTma615lbHmhdgqecCsgKK3EvlUwNRMLLMTSZ/kNVJTiwUKek1HKsrTZw96lllf
# Vik36a1C8u4/76TMGebDF5HgJgttaN2Sexg1Zu3VMwY1V5uneyXqdych3JgjepRx
# zBxZUMv803fh6IrAYQ==
# SIG # End signature block
