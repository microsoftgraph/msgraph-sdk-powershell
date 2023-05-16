
Describe 'Invoke-MgGraphRequest Command' -skip {
     BeforeAll {
          $utils = Join-Path $PSScriptRoot "../../../../tools/Utilities/utils.ps1" -Resolve
          . $utils
          $ModuleName = "Microsoft.Graph.Authentication"
          $ModulePath = Join-Path $PSScriptRoot "..\artifacts\$ModuleName.psd1"
          Import-Module $ModulePath -Force

          Connect-GraphTenant
     }
     Context 'Collection Results' {
          It 'Should return PsObject' {
               Invoke-MgGraphRequest -OutputType PSObject -Uri "https://graph.microsoft.com/v1.0/users" | Should -BeOfType [System.Management.Automation.PSObject]
          }

          It 'Should return HashTable' {
               Invoke-MgGraphRequest -OutputType Hashtable -Uri "https://graph.microsoft.com/v1.0/users" | Should -BeOfType [System.Collections.Hashtable]
          }

          It 'Should return JsonString' {
               Invoke-MgGraphRequest -OutputType Json -Uri "https://graph.microsoft.com/beta/users" | Should -BeOfType [System.String]
          }

          It 'Should return HttpResponseMessage' {
               Invoke-MgGraphRequest -OutputType HttpResponseMessage -Uri "https://graph.microsoft.com/beta/users" | Should -BeOfType [System.Net.Http.HttpResponseMessage]
          }
     }
     Context 'Single Entity' {
          It 'Should return PsObject' {
               Invoke-MgGraphRequest -OutputType PSObject -Uri "https://graph.microsoft.com/v1.0/users/${env:DEFAULTUSERID}" | Should -BeOfType [System.Management.Automation.PSObject]
          }

          It 'Should return HashTable' {
               Invoke-MgGraphRequest -OutputType Hashtable -Uri "https://graph.microsoft.com/v1.0/users/${env:DEFAULTUSERID}" | Should -BeOfType [System.Collections.Hashtable]
          }

          It 'Should return JsonString' {
               Invoke-MgGraphRequest -OutputType Json -Uri "https://graph.microsoft.com/beta/users/${env:DEFAULTUSERID}" | Should -BeOfType [System.String]
          }

          It 'Should return HttpResponseMessage' {
               Invoke-MgGraphRequest -OutputType HttpResponseMessage -Uri "https://graph.microsoft.com/beta/users/${env:DEFAULTUSERID}" | Should -BeOfType [System.Net.Http.HttpResponseMessage]
          }
     }

     Context 'Non-Json Responses' {
          It 'Should throw when -OutputFilePath is not specified and request returns a non-json response' {
               { Invoke-MgGraphRequest -OutputType PSObject -Uri "https://graph.microsoft.com/v1.0/reports/getTeamsUserActivityUserDetail(period='D7')" } | Should -Throw
          }
          It 'Should not throw when -OutputFilePath is specified' {
               { Invoke-MgGraphRequest -OutputType PSObject -Uri "https://graph.microsoft.com/v1.0/reports/getTeamsUserActivityUserDetail(period='D7')" -OutputFilePath ./data.csv } | Should -Not -Throw
          }
          It 'Should not throw when -InferOutputFilePath is specified' {
               { Invoke-MgGraphRequest -OutputType PSObject -Uri "https://graph.microsoft.com/v1.0/reports/getTeamsUserActivityUserDetail(period='D7')" -InferOutputFileName } | Should -Not -Throw
          }
     }

     Context 'Absolute and relative URIs' {
          It 'Should not throw when absolute URI is used on GET' {
               { Invoke-MgGraphRequest -Method GET -Uri "https://graph.microsoft.com/v1.0/organization" } | Should -Not -Throw
          }
          It 'Should not throw when relative URI is used on GET' {
               { Invoke-MgGraphRequest -Method GET -Uri "/v1.0/organization" } | Should -Not -Throw
          }
          It 'Should not throw when absolute URI is used on POST' {
               $body = @{ "ids" = @("00257bcc-c612-4a8b-b04d-ddc1e3cbafc1"); "types" = @("user") }
               { Invoke-MgGraphRequest -Method POST -Uri "https://graph.microsoft.com/v1.0/directoryObjects/getByIds" -Body $body } | Should -Not -Throw
          }
          It 'Should not throw when relative URI is used on POST' {
               $body = @{ "ids" = @("00257bcc-c612-4a8b-b04d-ddc1e3cbafc1"); "types" = @("user") }
               { Invoke-MgGraphRequest -Method POST -Uri "/v1.0/directoryObjects/getByIds" -Body $body } | Should -Not -Throw
          }
     }

     Context 'Empty Body Requests' {
          It 'Should Not Throw when Body is Empty for POST Requests' {
               {
                    Invoke-MgGraphRequest -Uri "https://graph.microsoft.com/v1.0/users/${env:DEFAULTUSERID}/revokeSignInSessions" -Method POST -Verbose
               } | Should  -Not -Throw
          }
     }

     AfterAll {
          Disconnect-MgGraph
     }
}
# SIG # Begin signature block
# MIInwgYJKoZIhvcNAQcCoIInszCCJ68CAQExDzANBglghkgBZQMEAgEFADB5Bgor
# BgEEAYI3AgEEoGswaTA0BgorBgEEAYI3AgEeMCYCAwEAAAQQH8w7YFlLCE63JNLG
# KX7zUQIBAAIBAAIBAAIBAAIBADAxMA0GCWCGSAFlAwQCAQUABCA2mfWMBv21nn/c
# bqekpmb9ecgmwg2E8c08t2HB8GD0uqCCDXYwggX0MIID3KADAgECAhMzAAADTrU8
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
# /Xmfwb1tbWrJUnMTDXpQzTGCGaIwghmeAgEBMIGVMH4xCzAJBgNVBAYTAlVTMRMw
# EQYDVQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVN
# aWNyb3NvZnQgQ29ycG9yYXRpb24xKDAmBgNVBAMTH01pY3Jvc29mdCBDb2RlIFNp
# Z25pbmcgUENBIDIwMTECEzMAAANOtTx6wYRv6ysAAAAAA04wDQYJYIZIAWUDBAIB
# BQCgga4wGQYJKoZIhvcNAQkDMQwGCisGAQQBgjcCAQQwHAYKKwYBBAGCNwIBCzEO
# MAwGCisGAQQBgjcCARUwLwYJKoZIhvcNAQkEMSIEIC+pCcday524irI5LsYiI7/j
# Gj20DLCfAAPmbrAZFARDMEIGCisGAQQBgjcCAQwxNDAyoBSAEgBNAGkAYwByAG8A
# cwBvAGYAdKEagBhodHRwOi8vd3d3Lm1pY3Jvc29mdC5jb20wDQYJKoZIhvcNAQEB
# BQAEggEAutu5MynFFlUKPbqCWeG3uYRnXg90EjahqX5stug1XHAC6ZUS8J1laFwd
# AdtNfvzMWq0/l4WKldU6O9yYb5VWU5h4k0haPTs4Acs3ksjpdvAMZUz5h+HXRmEV
# sz+qhHAqQacnIxW4/a1fH5rCZ/E8OsV7sGQ1tarz3LE2we8f1fJZ6/jOhmlMOOYZ
# L2020DYH0AfLniCd+MQFaCf0nMjDd3TZVbZDqHyHKzLvebW9p9gMNRdKHCJzrg99
# lGcnVM7YKpYEEifPTi/oUnPrXRwkTCn9byuUBjWaGJ0lMTnYt9usY2qsO8AbGbMR
# nAbCkdXZWEhb5GpGTVCxvmEkVgz6rqGCFywwghcoBgorBgEEAYI3AwMBMYIXGDCC
# FxQGCSqGSIb3DQEHAqCCFwUwghcBAgEDMQ8wDQYJYIZIAWUDBAIBBQAwggFZBgsq
# hkiG9w0BCRABBKCCAUgEggFEMIIBQAIBAQYKKwYBBAGEWQoDATAxMA0GCWCGSAFl
# AwQCAQUABCD0rZzYf58erKOzYk0/823iBq58i6kkEYNPLxlizDAtqAIGZD/VEc/H
# GBMyMDIzMDUxNjEyMjQ0OC42MTZaMASAAgH0oIHYpIHVMIHSMQswCQYDVQQGEwJV
# UzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMHUmVkbW9uZDEeMBwGA1UE
# ChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMS0wKwYDVQQLEyRNaWNyb3NvZnQgSXJl
# bGFuZCBPcGVyYXRpb25zIExpbWl0ZWQxJjAkBgNVBAsTHVRoYWxlcyBUU1MgRVNO
# OkZDNDEtNEJENC1EMjIwMSUwIwYDVQQDExxNaWNyb3NvZnQgVGltZS1TdGFtcCBT
# ZXJ2aWNloIIRezCCBycwggUPoAMCAQICEzMAAAG59gANZVRPvAMAAQAAAbkwDQYJ
# KoZIhvcNAQELBQAwfDELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24x
# EDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlv
# bjEmMCQGA1UEAxMdTWljcm9zb2Z0IFRpbWUtU3RhbXAgUENBIDIwMTAwHhcNMjIw
# OTIwMjAyMjE3WhcNMjMxMjE0MjAyMjE3WjCB0jELMAkGA1UEBhMCVVMxEzARBgNV
# BAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jv
# c29mdCBDb3Jwb3JhdGlvbjEtMCsGA1UECxMkTWljcm9zb2Z0IElyZWxhbmQgT3Bl
# cmF0aW9ucyBMaW1pdGVkMSYwJAYDVQQLEx1UaGFsZXMgVFNTIEVTTjpGQzQxLTRC
# RDQtRDIyMDElMCMGA1UEAxMcTWljcm9zb2Z0IFRpbWUtU3RhbXAgU2VydmljZTCC
# AiIwDQYJKoZIhvcNAQEBBQADggIPADCCAgoCggIBAONJPslh9RbHyQECbUIINxMF
# 5uQkyN07VIShITXubLpWnANgBCLvCcJl7o/2HHORnsRcmSINJ/qclAmLIrOjnYnr
# bocAnixiMEXC+a1sZ84qxYWtEVY7VYw0LCczY+86U/8shgxqsaezKpWriPOcpV1S
# h8SsOxf30yO7jvld/IBA3T6lHM2pT/HRjWk/r9uyx0Q4atx0mkLVYS9y55/oTlKL
# E00h792S+maadAdy3VgTweiwoEOXD785wv3h+fwH/wTQtC9lhAxhMO4p+OP9888W
# xkbl6BqRWXud54RTzqp2Vr+yen1Q1A6umyMB7Xq0snIYG5B1Acc4UgJlPQ/ZiMkq
# gxQNFCWQvz0G9oLgSPD8Ky0AkX22PcDOboPuNT4RceWPX0UVZUsX9IUgs7QF41Hi
# QSwEeOOHGyrfQdmSslATrbmH/18M5QrsTM5JINjct9G42xqN8VF9Z8WOiGMjNbvl
# pcEmmysYl5QyhrEDoFnQTU7bFrD3JX0fIfu1sbLWeBqXwbp4Z8yACTtphK2VbzOv
# i4vc0RCmRNzvYQQ2PjZ7NaTXE4Gu3vggAJ+rtzUTAfJotvOSqcMgNwLZa1Y+ET/l
# b0VyjrYwFuHtg0QWyQjP5350LTpv086pyVUh4A3w/Os5hTGFZgFe5bCyMnpY09M0
# yPdHaQ/56oYUsSIcyKyVAgMBAAGjggFJMIIBRTAdBgNVHQ4EFgQUt7A4cdtYQ5oJ
# jE1ZqrSonp41RFIwHwYDVR0jBBgwFoAUn6cVXQBeYl2D9OXSZacbUzUZ6XIwXwYD
# VR0fBFgwVjBUoFKgUIZOaHR0cDovL3d3dy5taWNyb3NvZnQuY29tL3BraW9wcy9j
# cmwvTWljcm9zb2Z0JTIwVGltZS1TdGFtcCUyMFBDQSUyMDIwMTAoMSkuY3JsMGwG
# CCsGAQUFBwEBBGAwXjBcBggrBgEFBQcwAoZQaHR0cDovL3d3dy5taWNyb3NvZnQu
# Y29tL3BraW9wcy9jZXJ0cy9NaWNyb3NvZnQlMjBUaW1lLVN0YW1wJTIwUENBJTIw
# MjAxMCgxKS5jcnQwDAYDVR0TAQH/BAIwADAWBgNVHSUBAf8EDDAKBggrBgEFBQcD
# CDAOBgNVHQ8BAf8EBAMCB4AwDQYJKoZIhvcNAQELBQADggIBAM3cZ7NFUHRMsLKz
# jl7rJPIkv7oJ+s9kkut0hZif9WSt60SzYGULp1zmdPqc+w8eHTkhqX0GKCp2TTqS
# zBXBhwHOm8+p6hUxNlDewGMZUos952aTXblAT3OKBnfVBLQyUavrSjuJGZAW30cN
# Y3rjVDUlGD+VygQHySaDaviJQbK6/6fQvUUFoqIk3ldGfjnAtnebsVlqh6WWamVc
# 5AZdpWR1jSzN/oxKYqc1BG4SxxlPtcfrAdBz/cU4bxVXqAAf02NZscvJNpRnOALf
# 5kVo2HupJXCsk9TzP5PNW2sTS3TmwhIQmPxr0E0UqOojUrBJUOhbITAxcnSa/IMl
# uL1HXRtLQZI+xs2eRtuPOUsKUW71/1YeqsYCLHLvu82ceDVQQvP7GHEEkp2kEjio
# fbjYErBo2iCEaxxeX4Z9HvAgA4MsQkbn6e4EFQf13sP+Kn3XgMIvJbqLJeFcQja+
# SUeOXu5cfkxe0GzTNojdyIwzaHlhOflVRZNrxee3B+yZwd3JHDIvv71uSI/SIzzt
# 9cU2GyHQVqxBSrRtKW6W8Vw7zpVvoVsIv3ljxg+7NiGSlXX1s7zbBNDMUj9OnzOl
# HK/3mrOU8YEuRf6RwakW5UCeGamy5MiKu2YuyKiGBCv4OGhPstNe7ALkEOh8BX12
# t4ntuYu+gw9L6yCPY0jWYaQtzAP9MIIHcTCCBVmgAwIBAgITMwAAABXF52ueAptJ
# mQAAAAAAFTANBgkqhkiG9w0BAQsFADCBiDELMAkGA1UEBhMCVVMxEzARBgNVBAgT
# Cldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29m
# dCBDb3Jwb3JhdGlvbjEyMDAGA1UEAxMpTWljcm9zb2Z0IFJvb3QgQ2VydGlmaWNh
# dGUgQXV0aG9yaXR5IDIwMTAwHhcNMjEwOTMwMTgyMjI1WhcNMzAwOTMwMTgzMjI1
# WjB8MQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMH
# UmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMSYwJAYDVQQD
# Ex1NaWNyb3NvZnQgVGltZS1TdGFtcCBQQ0EgMjAxMDCCAiIwDQYJKoZIhvcNAQEB
# BQADggIPADCCAgoCggIBAOThpkzntHIhC3miy9ckeb0O1YLT/e6cBwfSqWxOdcjK
# NVf2AX9sSuDivbk+F2Az/1xPx2b3lVNxWuJ+Slr+uDZnhUYjDLWNE893MsAQGOhg
# fWpSg0S3po5GawcU88V29YZQ3MFEyHFcUTE3oAo4bo3t1w/YJlN8OWECesSq/XJp
# rx2rrPY2vjUmZNqYO7oaezOtgFt+jBAcnVL+tuhiJdxqD89d9P6OU8/W7IVWTe/d
# vI2k45GPsjksUZzpcGkNyjYtcI4xyDUoveO0hyTD4MmPfrVUj9z6BVWYbWg7mka9
# 7aSueik3rMvrg0XnRm7KMtXAhjBcTyziYrLNueKNiOSWrAFKu75xqRdbZ2De+JKR
# Hh09/SDPc31BmkZ1zcRfNN0Sidb9pSB9fvzZnkXftnIv231fgLrbqn427DZM9itu
# qBJR6L8FA6PRc6ZNN3SUHDSCD/AQ8rdHGO2n6Jl8P0zbr17C89XYcz1DTsEzOUyO
# ArxCaC4Q6oRRRuLRvWoYWmEBc8pnol7XKHYC4jMYctenIPDC+hIK12NvDMk2ZItb
# oKaDIV1fMHSRlJTYuVD5C4lh8zYGNRiER9vcG9H9stQcxWv2XFJRXRLbJbqvUAV6
# bMURHXLvjflSxIUXk8A8FdsaN8cIFRg/eKtFtvUeh17aj54WcmnGrnu3tz5q4i6t
# AgMBAAGjggHdMIIB2TASBgkrBgEEAYI3FQEEBQIDAQABMCMGCSsGAQQBgjcVAgQW
# BBQqp1L+ZMSavoKRPEY1Kc8Q/y8E7jAdBgNVHQ4EFgQUn6cVXQBeYl2D9OXSZacb
# UzUZ6XIwXAYDVR0gBFUwUzBRBgwrBgEEAYI3TIN9AQEwQTA/BggrBgEFBQcCARYz
# aHR0cDovL3d3dy5taWNyb3NvZnQuY29tL3BraW9wcy9Eb2NzL1JlcG9zaXRvcnku
# aHRtMBMGA1UdJQQMMAoGCCsGAQUFBwMIMBkGCSsGAQQBgjcUAgQMHgoAUwB1AGIA
# QwBBMAsGA1UdDwQEAwIBhjAPBgNVHRMBAf8EBTADAQH/MB8GA1UdIwQYMBaAFNX2
# VsuP6KJcYmjRPZSQW9fOmhjEMFYGA1UdHwRPME0wS6BJoEeGRWh0dHA6Ly9jcmwu
# bWljcm9zb2Z0LmNvbS9wa2kvY3JsL3Byb2R1Y3RzL01pY1Jvb0NlckF1dF8yMDEw
# LTA2LTIzLmNybDBaBggrBgEFBQcBAQROMEwwSgYIKwYBBQUHMAKGPmh0dHA6Ly93
# d3cubWljcm9zb2Z0LmNvbS9wa2kvY2VydHMvTWljUm9vQ2VyQXV0XzIwMTAtMDYt
# MjMuY3J0MA0GCSqGSIb3DQEBCwUAA4ICAQCdVX38Kq3hLB9nATEkW+Geckv8qW/q
# XBS2Pk5HZHixBpOXPTEztTnXwnE2P9pkbHzQdTltuw8x5MKP+2zRoZQYIu7pZmc6
# U03dmLq2HnjYNi6cqYJWAAOwBb6J6Gngugnue99qb74py27YP0h1AdkY3m2CDPVt
# I1TkeFN1JFe53Z/zjj3G82jfZfakVqr3lbYoVSfQJL1AoL8ZthISEV09J+BAljis
# 9/kpicO8F7BUhUKz/AyeixmJ5/ALaoHCgRlCGVJ1ijbCHcNhcy4sa3tuPywJeBTp
# kbKpW99Jo3QMvOyRgNI95ko+ZjtPu4b6MhrZlvSP9pEB9s7GdP32THJvEKt1MMU0
# sHrYUP4KWN1APMdUbZ1jdEgssU5HLcEUBHG/ZPkkvnNtyo4JvbMBV0lUZNlz138e
# W0QBjloZkWsNn6Qo3GcZKCS6OEuabvshVGtqRRFHqfG3rsjoiV5PndLQTHa1V1QJ
# sWkBRH58oWFsc/4Ku+xBZj1p/cvBQUl+fpO+y/g75LcVv7TOPqUxUYS8vwLBgqJ7
# Fx0ViY1w/ue10CgaiQuPNtq6TPmb/wrpNPgkNWcr4A245oyZ1uEi6vAnQj0llOZ0
# dFtq0Z4+7X6gMTN9vMvpe784cETRkPHIqzqKOghif9lwY1NNje6CbaUFEMFxBmoQ
# tB1VM1izoXBm8qGCAtcwggJAAgEBMIIBAKGB2KSB1TCB0jELMAkGA1UEBhMCVVMx
# EzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoT
# FU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjEtMCsGA1UECxMkTWljcm9zb2Z0IElyZWxh
# bmQgT3BlcmF0aW9ucyBMaW1pdGVkMSYwJAYDVQQLEx1UaGFsZXMgVFNTIEVTTjpG
# QzQxLTRCRDQtRDIyMDElMCMGA1UEAxMcTWljcm9zb2Z0IFRpbWUtU3RhbXAgU2Vy
# dmljZaIjCgEBMAcGBSsOAwIaAxUAx2IeGHhk58MQkzzSWknGcLjfgTqggYMwgYCk
# fjB8MQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMH
# UmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMSYwJAYDVQQD
# Ex1NaWNyb3NvZnQgVGltZS1TdGFtcCBQQ0EgMjAxMDANBgkqhkiG9w0BAQUFAAIF
# AOgN6TQwIhgPMjAyMzA1MTYxOTM2MjBaGA8yMDIzMDUxNzE5MzYyMFowdzA9Bgor
# BgEEAYRZCgQBMS8wLTAKAgUA6A3pNAIBADAKAgEAAgID8AIB/zAHAgEAAgIRQjAK
# AgUA6A86tAIBADA2BgorBgEEAYRZCgQCMSgwJjAMBgorBgEEAYRZCgMCoAowCAIB
# AAIDB6EgoQowCAIBAAIDAYagMA0GCSqGSIb3DQEBBQUAA4GBAH3OGglYpk/qVvPR
# pt2RUgOsEo7pIE8vkMWGFoXLsppYq57fzhHMvJipitbbafEzw7uoeTR+NEaqP1jS
# M3X51c7b0cfmDNh2zzKR9tCJvJdxGwLUoyYtIT1qCbHA6dOktJnZZKzSwff9vQsu
# YWvAvPZ5FhhQ/Su7frAWmA/GuHrjMYIEDTCCBAkCAQEwgZMwfDELMAkGA1UEBhMC
# VVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNV
# BAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjEmMCQGA1UEAxMdTWljcm9zb2Z0IFRp
# bWUtU3RhbXAgUENBIDIwMTACEzMAAAG59gANZVRPvAMAAQAAAbkwDQYJYIZIAWUD
# BAIBBQCgggFKMBoGCSqGSIb3DQEJAzENBgsqhkiG9w0BCRABBDAvBgkqhkiG9w0B
# CQQxIgQglU0NW1TxA8S9XRpJdx8CeG+dLKT5CTHN6Xo2lkvBkh0wgfoGCyqGSIb3
# DQEJEAIvMYHqMIHnMIHkMIG9BCBk60bO8W85uTAfJVEO3vX2aLaQFcgcGpdwsOoi
# +foP9DCBmDCBgKR+MHwxCzAJBgNVBAYTAlVTMRMwEQYDVQQIEwpXYXNoaW5ndG9u
# MRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVNaWNyb3NvZnQgQ29ycG9yYXRp
# b24xJjAkBgNVBAMTHU1pY3Jvc29mdCBUaW1lLVN0YW1wIFBDQSAyMDEwAhMzAAAB
# ufYADWVUT7wDAAEAAAG5MCIEIBre2tIlmq+2ym+/ZoCEW5qXwR9AY4fRnf9HwBlZ
# CTZSMA0GCSqGSIb3DQEBCwUABIICADpivlMrEJtR/RNQ62fjGZAom7hgS0Yn+AvH
# BPPIPzImVF7/M7hBCklkLdx4suS4xrxz7ZfwGvCfgeURvLFFHTwd40bjcBMiPzcZ
# 4+xVxdZ2v4Bvv7Kri9gv9Ykqw6F1oxhwBmbozHqO01mCeNAyHOcF31VhBRHFqRKo
# fyghMSdT3w9Lo+MyoXVrNKg9CRPYHfVZAhuTEZ++M7DMSKrfG0Tglbye9sEIq7sz
# XjmOMeDFZxBz49hgYjDoNlKJBzFMEWp/Sn0geL89z+ROtaTVZAeH/NRxM732DysA
# kCpewwXPgS9YmDtmlbjhkm3mR5MqFKt/cxy0mLE2J+sMcVmcUvS6ZQm0YgGIjG5c
# POi1Fn/B1cDomO4kTQ9o/CmJFdE/Cl59ESeZjPUfHDWNU++wf4O0lUzZhbDYiquE
# PkmFhIxNYdewCPuul66hOa8lhRwxEDciqTip9lbYg+SmAC9lLmyAe8T9LOm3kkI9
# ZQUe9lJ+yEEQ5G9fhhFO0Gga63UATo/CSToQghgsu4gqYKysLkrlhQKra1PsQITV
# vGbEogwaAn7PXEEWD6hkesTnrRc5NOXkledjwmvBd/LlY8TpB8mUfYQJ31SpNkLT
# nwGq/U4mNbsWw5dhfE+o9z2l6kHKr2xtqoTTt1OiDT+6YUE4EJ52pBvfUNg0Ixqn
# P20tEvQs
# SIG # End signature block
