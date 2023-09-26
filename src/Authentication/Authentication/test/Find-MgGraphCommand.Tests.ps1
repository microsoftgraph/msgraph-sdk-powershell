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
# MIIoKgYJKoZIhvcNAQcCoIIoGzCCKBcCAQExDzANBglghkgBZQMEAgEFADB5Bgor
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
# /Xmfwb1tbWrJUnMTDXpQzTGCGgowghoGAgEBMIGVMH4xCzAJBgNVBAYTAlVTMRMw
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
# tLf7ea9jrjoOgckCZ5CJEnlGT7J3hKGCF5QwgheQBgorBgEEAYI3AwMBMYIXgDCC
# F3wGCSqGSIb3DQEHAqCCF20wghdpAgEDMQ8wDQYJYIZIAWUDBAIBBQAwggFSBgsq
# hkiG9w0BCRABBKCCAUEEggE9MIIBOQIBAQYKKwYBBAGEWQoDATAxMA0GCWCGSAFl
# AwQCAQUABCCrp5r3nF0cOnxxgb9EO5TeoucCSIZzii9xWOr4YXF1jgIGZQQZD+ox
# GBMyMDIzMDkyNjEyMjM0Mi42OTNaMASAAgH0oIHRpIHOMIHLMQswCQYDVQQGEwJV
# UzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMHUmVkbW9uZDEeMBwGA1UE
# ChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMSUwIwYDVQQLExxNaWNyb3NvZnQgQW1l
# cmljYSBPcGVyYXRpb25zMScwJQYDVQQLEx5uU2hpZWxkIFRTUyBFU046ODkwMC0w
# NUUwLUQ5NDcxJTAjBgNVBAMTHE1pY3Jvc29mdCBUaW1lLVN0YW1wIFNlcnZpY2Wg
# ghHqMIIHIDCCBQigAwIBAgITMwAAAdMdMpoXO0AwcwABAAAB0zANBgkqhkiG9w0B
# AQsFADB8MQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UE
# BxMHUmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMSYwJAYD
# VQQDEx1NaWNyb3NvZnQgVGltZS1TdGFtcCBQQ0EgMjAxMDAeFw0yMzA1MjUxOTEy
# MjRaFw0yNDAyMDExOTEyMjRaMIHLMQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2Fz
# aGluZ3RvbjEQMA4GA1UEBxMHUmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENv
# cnBvcmF0aW9uMSUwIwYDVQQLExxNaWNyb3NvZnQgQW1lcmljYSBPcGVyYXRpb25z
# MScwJQYDVQQLEx5uU2hpZWxkIFRTUyBFU046ODkwMC0wNUUwLUQ5NDcxJTAjBgNV
# BAMTHE1pY3Jvc29mdCBUaW1lLVN0YW1wIFNlcnZpY2UwggIiMA0GCSqGSIb3DQEB
# AQUAA4ICDwAwggIKAoICAQC0jquTN4g1xbhXCc8MV+dOu8Uqc3KbbaWti5vdsAWM
# 1D4fVSi+4NWgGtP/BVRYrVj2oVnnMy0eazidQOJ4uUscBMbPHaMxaNpgbRG9FEQR
# FncAUptWnI+VPl53PD6MPL0yz8cHC2ZD3weF4w+uMDAGnL36Bkm0srONXvnM9eNv
# nG5djopEqiHodWSauRye4uftBR2sTwGHVmxKu0GS4fO87NgbJ4VGzICRyZXw9+Rv
# vXMG/jhM11H8AWKzKpn0oMGm1MSMeNvLUWb31HSZekx/NBEtXvmdo75OV030NHgI
# XihxYEeSgUIxfbI5OmgMq/VDCQp2r/fy/5NVa3KjCQoNqmmEM6orAJ2XKjYhEJzo
# p4nWCcJ970U6rXpBPK4XGNKBFhhLa74TM/ysTFIrEXOJG1fUuXfcdWb0Ex0FAeTT
# r6gmmCqreJNejNHffG/VEeF7LNvUquYFRndiCUhgy624rW6ptcnQTiRfE0QL/gLF
# 41kA2vZMYzcc16EiYXQQBaF3XAtMduh1dpXqTPPQEO3Ms5/5B/KtjhSspMcPUvRv
# b35IWN+q+L+zEwiphmnCGFTuyOMqc5QE0ruGN3Mx0Vv6x/hcOmaXxrHQGpNKI5Pn
# 79Yk89AclqU2mXHz1ZHWp+KBc3D6VP7L32JlwxhJx3asa085xv0XPD58MRW1WaGv
# aQIDAQABo4IBSTCCAUUwHQYDVR0OBBYEFNLHIIa4FAD494z35hvzCmm0415iMB8G
# A1UdIwQYMBaAFJ+nFV0AXmJdg/Tl0mWnG1M1GelyMF8GA1UdHwRYMFYwVKBSoFCG
# Tmh0dHA6Ly93d3cubWljcm9zb2Z0LmNvbS9wa2lvcHMvY3JsL01pY3Jvc29mdCUy
# MFRpbWUtU3RhbXAlMjBQQ0ElMjAyMDEwKDEpLmNybDBsBggrBgEFBQcBAQRgMF4w
# XAYIKwYBBQUHMAKGUGh0dHA6Ly93d3cubWljcm9zb2Z0LmNvbS9wa2lvcHMvY2Vy
# dHMvTWljcm9zb2Z0JTIwVGltZS1TdGFtcCUyMFBDQSUyMDIwMTAoMSkuY3J0MAwG
# A1UdEwEB/wQCMAAwFgYDVR0lAQH/BAwwCgYIKwYBBQUHAwgwDgYDVR0PAQH/BAQD
# AgeAMA0GCSqGSIb3DQEBCwUAA4ICAQBAYlhYoUQ+4aaQ54MFNfE6Ey8v4rWv+LtD
# RSjMM2X9g4uanA9cU7VitdpIPV/zE6v4AEhe/Vng2UAR5qj2SV3sz+fDqN6VLWUZ
# sKR0QR2JYXKnFPRVj16ezZyP7zd5H8IsvscEconeX+aRHF0xGGM4tDLrS84vj6Rm
# 0bgoWLXWnMTZ5kP4ownGmm0LsmInuu0GKrDZnkeTVmfk8gTTy8d1y3P2IYc2UI4i
# JYXCuSaKCuFeO0wqyscpvhGQSno1XAFK3oaybuD1mSoQxT9q77+LAGGQbiSoGlgT
# jQQayYsQaPcG1Q4QNwONGqkASCZTbzJlnmkHgkWlKSLTulOailWIY4hS1EZ+w+sX
# 0BJ9LcM142h51OlXLMoPLpzHAb6x22ipaAJ5Kf3uyFaOKWw4hnu0zWs+PKPd192n
# deK2ogWfaFdfnEvkWDDH2doL+ZA5QBd8Xngs/md3Brnll2BkZ/giZE/fKyolriR3
# aTAWCxFCXKIl/Clu2bbnj9qfVYLpAVQEcPaCfTAf7OZBlXmluETvq1Y/SNhxC6MJ
# 1QLCnkXSI//iXYpmRKT783QKRgmo/4ztj3uL9Z7xbbGxISg+P0HTRX15y4TReBbO
# 2RFNyCj88gOORk+swT1kaKXUfGB4zjg5XulxSby3uLNxQebE6TE3cAK0+fnY5UpH
# aEdlw4e7ijCCB3EwggVZoAMCAQICEzMAAAAVxedrngKbSZkAAAAAABUwDQYJKoZI
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
# 6Xu/OHBE0ZDxyKs6ijoIYn/ZcGNTTY3ugm2lBRDBcQZqELQdVTNYs6FwZvKhggNN
# MIICNQIBATCB+aGB0aSBzjCByzELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldhc2hp
# bmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jw
# b3JhdGlvbjElMCMGA1UECxMcTWljcm9zb2Z0IEFtZXJpY2EgT3BlcmF0aW9uczEn
# MCUGA1UECxMeblNoaWVsZCBUU1MgRVNOOjg5MDAtMDVFMC1EOTQ3MSUwIwYDVQQD
# ExxNaWNyb3NvZnQgVGltZS1TdGFtcCBTZXJ2aWNloiMKAQEwBwYFKw4DAhoDFQBS
# x23cMcNB1IQws/LYkRXa7I5JsKCBgzCBgKR+MHwxCzAJBgNVBAYTAlVTMRMwEQYD
# VQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVNaWNy
# b3NvZnQgQ29ycG9yYXRpb24xJjAkBgNVBAMTHU1pY3Jvc29mdCBUaW1lLVN0YW1w
# IFBDQSAyMDEwMA0GCSqGSIb3DQEBCwUAAgUA6L0XcjAiGA8yMDIzMDkyNjA4NDAx
# OFoYDzIwMjMwOTI3MDg0MDE4WjB0MDoGCisGAQQBhFkKBAExLDAqMAoCBQDovRdy
# AgEAMAcCAQACAgXrMAcCAQACAhL5MAoCBQDovmjyAgEAMDYGCisGAQQBhFkKBAIx
# KDAmMAwGCisGAQQBhFkKAwKgCjAIAgEAAgMHoSChCjAIAgEAAgMBhqAwDQYJKoZI
# hvcNAQELBQADggEBALxOhiPHKdVrWX4iFGGPvg4fQhsy+L70JOom4EzrF+dUD/ah
# wxSXLElrlsISmrQ3/nzihrPuiNv+WSlgVKBsJeXDRCXoPPe6ZEZcm/8Oec8KrFLA
# FZZABVbncgGrajIUf7/B86YEbbB38rjVs84/CG3/+n6N/rIqugqimONhlfTWvrZC
# SYrGPnDS//4rU6sCfxe+hW/CgpulOe5Vs3fa8QaWEFHSvbjhehqGIhDzUvzsGDrh
# csg94qYfS/aNaaEJqFatUTsyRnJ4F/reVxAgENk8ktzZXWOAkT/7veB7uoXLIQoA
# CqInoViZWWYzf6ClEKDDXJ07M/V9GmSTUsCZ5PQxggQNMIIECQIBATCBkzB8MQsw
# CQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMHUmVkbW9u
# ZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMSYwJAYDVQQDEx1NaWNy
# b3NvZnQgVGltZS1TdGFtcCBQQ0EgMjAxMAITMwAAAdMdMpoXO0AwcwABAAAB0zAN
# BglghkgBZQMEAgEFAKCCAUowGgYJKoZIhvcNAQkDMQ0GCyqGSIb3DQEJEAEEMC8G
# CSqGSIb3DQEJBDEiBCBRXO6Lqu8GUq/+jEztkNZy8jlFExalQ3xBq22cANjVgjCB
# +gYLKoZIhvcNAQkQAi8xgeowgecwgeQwgb0EIJJm9OrE4O5PWA1KaFaztr9uP96r
# QgEn+tgGtY3xOqr1MIGYMIGApH4wfDELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldh
# c2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBD
# b3Jwb3JhdGlvbjEmMCQGA1UEAxMdTWljcm9zb2Z0IFRpbWUtU3RhbXAgUENBIDIw
# MTACEzMAAAHTHTKaFztAMHMAAQAAAdMwIgQg38hUubXpGYpYE7XwyYAMMc32wevc
# 16k3lPVNhca9rh4wDQYJKoZIhvcNAQELBQAEggIAZTqm6P/tzcdnVUbGjm1onmtb
# nczGMAaiZX3b7mzsQSJKgcfNP4+Jprr1d9Y0+SBFNNshVQmjoZ/Hny1yVcHvdpFD
# 2NRpr501FdKPL6ulwRmANe60Xm76ecXC4ITAThRw4peSYJhZkEDe3VRbQ7LVws8H
# HT7wb+/uQ14FoMU/Ded7AwyO66n9TeZUEi/sAqPndNGERpYXYyHsUKJWP0fR4okA
# otivmXF71myXdOemeRWL/Hrg1ImBLMSIaPrK5mO7ZrPhIU+uKIxkAIgHsSrTXktJ
# F48qys8usnU/2D7hKmZLierVTi865h1cGFTvEWzfndtgbGCWUp4Vz/WBB9KwTdBg
# tdIFvQLi8VpYP5WagOWLGUV6+5KUt6PmAQpetdaOeOYG9LGaMt3sF7jlMSUIde2r
# F8SuE0kQ71j/jsJ5Y3/7toRHrYezzPicvD63kl6bwdxuWweccXGF/gzh60P1RbIX
# MiQwdBdAqIKJCOzvoLkJryIgnjY7Dxzv/DdUU67+LwhfkxBjawWoAAgSEtOFmvgr
# x8PAec6emmgV3D3uWxqTkbO87qn/dVwLayusY4U4hUHQ9dRlC6or3w20z/WNdwTy
# 7Ol+IdvbS2uYdKglnPAuktS8vd3c7ppZ6iETh5LLnCo96i1Gth9SgBWMBPHGmz0u
# Naho9OJRBM9R6pL+pr4=
# SIG # End signature block
