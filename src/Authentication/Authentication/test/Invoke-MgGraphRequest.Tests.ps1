
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
# MIInzgYJKoZIhvcNAQcCoIInvzCCJ7sCAQExDzANBglghkgBZQMEAgEFADB5Bgor
# BgEEAYI3AgEEoGswaTA0BgorBgEEAYI3AgEeMCYCAwEAAAQQH8w7YFlLCE63JNLG
# KX7zUQIBAAIBAAIBAAIBAAIBADAxMA0GCWCGSAFlAwQCAQUABCA2mfWMBv21nn/c
# bqekpmb9ecgmwg2E8c08t2HB8GD0uqCCDYUwggYDMIID66ADAgECAhMzAAADri01
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
# HAYKKwYBBAGCNwIBCzEOMAwGCisGAQQBgjcCARUwLwYJKoZIhvcNAQkEMSIEIC+p
# Ccday524irI5LsYiI7/jGj20DLCfAAPmbrAZFARDMEIGCisGAQQBgjcCAQwxNDAy
# oBSAEgBNAGkAYwByAG8AcwBvAGYAdKEagBhodHRwOi8vd3d3Lm1pY3Jvc29mdC5j
# b20wDQYJKoZIhvcNAQEBBQAEggEA6QqET8MLSE6HEmV6BoGC/Q7mrLCAajIWLqNy
# yZve2q9h+/gb7lKW9V6p01itjnjLH9YKjhZgky3N60l7c1hpanZbjRi4JE63uhq6
# 5r5N8rL6m0Y12wWE48sSEdeOgby5nDuXoDtUqfFKlxk+D4SIGAoWBIsDNkYCpLYd
# q8B4KtIlItXwlazhuEsTMdDkw7gLpzg8PH9M6vBloqbM6EyZ37t0tLydMYiZR9Rd
# qoA/vgOfsjGPGzNKRA3ayJmjUyEhpcdFa7uQD4sOsI7yOaADUs8jNDXqogiuu+uG
# 2+7KL/8c8zPjiJgDbfttqx2LhLfqeWKv7m86S+rVn7+AvpJ5D6GCFykwghclBgor
# BgEEAYI3AwMBMYIXFTCCFxEGCSqGSIb3DQEHAqCCFwIwghb+AgEDMQ8wDQYJYIZI
# AWUDBAIBBQAwggFZBgsqhkiG9w0BCRABBKCCAUgEggFEMIIBQAIBAQYKKwYBBAGE
# WQoDATAxMA0GCWCGSAFlAwQCAQUABCAuhqR7GVm7x2bXqutiTOqml/dg04JhnvVC
# mY1wdqtWLwIGZbqdnsJSGBMyMDI0MDIwODA1MjgwNy44MDdaMASAAgH0oIHYpIHV
# MIHSMQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMH
# UmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMS0wKwYDVQQL
# EyRNaWNyb3NvZnQgSXJlbGFuZCBPcGVyYXRpb25zIExpbWl0ZWQxJjAkBgNVBAsT
# HVRoYWxlcyBUU1MgRVNOOjhENDEtNEJGNy1CM0I3MSUwIwYDVQQDExxNaWNyb3Nv
# ZnQgVGltZS1TdGFtcCBTZXJ2aWNloIIReDCCBycwggUPoAMCAQICEzMAAAHj372b
# mhxogyIAAQAAAeMwDQYJKoZIhvcNAQELBQAwfDELMAkGA1UEBhMCVVMxEzARBgNV
# BAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jv
# c29mdCBDb3Jwb3JhdGlvbjEmMCQGA1UEAxMdTWljcm9zb2Z0IFRpbWUtU3RhbXAg
# UENBIDIwMTAwHhcNMjMxMDEyMTkwNzI5WhcNMjUwMTEwMTkwNzI5WjCB0jELMAkG
# A1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQx
# HjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjEtMCsGA1UECxMkTWljcm9z
# b2Z0IElyZWxhbmQgT3BlcmF0aW9ucyBMaW1pdGVkMSYwJAYDVQQLEx1UaGFsZXMg
# VFNTIEVTTjo4RDQxLTRCRjctQjNCNzElMCMGA1UEAxMcTWljcm9zb2Z0IFRpbWUt
# U3RhbXAgU2VydmljZTCCAiIwDQYJKoZIhvcNAQEBBQADggIPADCCAgoCggIBAL6k
# DWgeRp+fxSBUD6N/yuEJpXggzBeNG5KB8M9AbIWeEokJgOghlMg8JmqkNsB4Wl1N
# EXR7cL6vlPCsWGLMhyqmscQu36/8h2bx6TU4M8dVZEd6V4U+l9gpte+VF91kOI35
# fOqJ6eQDMwSBQ5c9ElPFUijTA7zV7Y5PRYrS4FL9p494TidCpBEH5N6AO5u8wNA/
# jKO94Zkfjgu7sLF8SUdrc1GRNEk2F91L3pxR+32FsuQTZi8hqtrFpEORxbySgiQB
# P3cH7fPleN1NynhMRf6T7XC1L0PRyKy9MZ6TBWru2HeWivkxIue1nLQb/O/n0j2Q
# Vd42Zf0ArXB/Vq54gQ8JIvUH0cbvyWM8PomhFi6q2F7he43jhrxyvn1Xi1pwHOVs
# bH26YxDKTWxl20hfQLdzz4RVTo8cFRMdQCxlKkSnocPWqfV/4H5APSPXk0r8Cc/c
# Mmva3g4EvupF4ErbSO0UNnCRv7UDxlSGiwiGkmny53mqtAZ7NLePhFtwfxp6ATIo
# jl8JXjr3+bnQWUCDCd5Oap54fGeGYU8KxOohmz604BgT14e3sRWABpW+oXYSCyFQ
# 3SZQ3/LNTVby9ENsuEh2UIQKWU7lv7chrBrHCDw0jM+WwOjYUS7YxMAhaSyOahpb
# udALvRUXpQhELFoO6tOx/66hzqgjSTOEY3pu46BFAgMBAAGjggFJMIIBRTAdBgNV
# HQ4EFgQUsa4NZr41FbehZ8Y+ep2m2YiYqQMwHwYDVR0jBBgwFoAUn6cVXQBeYl2D
# 9OXSZacbUzUZ6XIwXwYDVR0fBFgwVjBUoFKgUIZOaHR0cDovL3d3dy5taWNyb3Nv
# ZnQuY29tL3BraW9wcy9jcmwvTWljcm9zb2Z0JTIwVGltZS1TdGFtcCUyMFBDQSUy
# MDIwMTAoMSkuY3JsMGwGCCsGAQUFBwEBBGAwXjBcBggrBgEFBQcwAoZQaHR0cDov
# L3d3dy5taWNyb3NvZnQuY29tL3BraW9wcy9jZXJ0cy9NaWNyb3NvZnQlMjBUaW1l
# LVN0YW1wJTIwUENBJTIwMjAxMCgxKS5jcnQwDAYDVR0TAQH/BAIwADAWBgNVHSUB
# Af8EDDAKBggrBgEFBQcDCDAOBgNVHQ8BAf8EBAMCB4AwDQYJKoZIhvcNAQELBQAD
# ggIBALe+my6p1NPMEW1t70a8Y2hGxj6siDSulGAs4UxmkfzxMAic4j0+GTPbHxk1
# 93mQ0FRPa9dtbRbaezV0GLkEsUWTGF2tP6WsDdl5/lD4wUQ76ArFOencCpK5svE0
# sO0FyhrJHZxMLCOclvd6vAIPOkZAYihBH/RXcxzbiliOCr//3w7REnsLuOp/7vlX
# JAsGzmJesBP/0ERqxjKudPWuBGz/qdRlJtOl5nv9NZkyLig4D5hy9p2Ec1zaotiL
# iHnJ9mlsJEcUDhYj8PnYnJjjsCxv+yJzao2aUHiIQzMbFq+M08c8uBEf+s37YbZQ
# 7XAFxwe2EVJAUwpWjmtJ3b3zSWTMmFWunFr2aLk6vVeS0u1MyEfEv+0bDk+N3jms
# CwbLkM9FaDi7q2HtUn3z6k7AnETc28dAvLf/ioqUrVYTwBrbRH4XVFEvaIQ+i7es
# DQicWW1dCDA/J3xOoCECV68611jriajfdVg8o0Wp+FCg5CAUtslgOFuiYULgcxnq
# zkmP2i58ZEa0rm4LZymHBzsIMU0yMmuVmAkYxbdEDi5XqlZIupPpqmD6/fLjD4ub
# 0SEEttOpg0np0ra/MNCfv/tVhJtz5wgiEIKX+s4akawLfY+16xDB64Nm0HoGs/Gy
# 823ulIm4GyrUcpNZxnXvE6OZMjI/V1AgSAg8U/heMWuZTWVUMIIHcTCCBVmgAwIB
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
# aGFsZXMgVFNTIEVTTjo4RDQxLTRCRjctQjNCNzElMCMGA1UEAxMcTWljcm9zb2Z0
# IFRpbWUtU3RhbXAgU2VydmljZaIjCgEBMAcGBSsOAwIaAxUAPYiXu8ORQ4hvKcuE
# 7GK0COgxWnqggYMwgYCkfjB8MQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGlu
# Z3RvbjEQMA4GA1UEBxMHUmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBv
# cmF0aW9uMSYwJAYDVQQDEx1NaWNyb3NvZnQgVGltZS1TdGFtcCBQQ0EgMjAxMDAN
# BgkqhkiG9w0BAQUFAAIFAOluVh4wIhgPMjAyNDAyMDgwMzE4NTRaGA8yMDI0MDIw
# OTAzMTg1NFowdDA6BgorBgEEAYRZCgQBMSwwKjAKAgUA6W5WHgIBADAHAgEAAgIN
# 4DAHAgEAAgIRkTAKAgUA6W+nngIBADA2BgorBgEEAYRZCgQCMSgwJjAMBgorBgEE
# AYRZCgMCoAowCAIBAAIDB6EgoQowCAIBAAIDAYagMA0GCSqGSIb3DQEBBQUAA4GB
# AJ37vmp+Fp6Dss08t8cRClZG291jPHYmbhHIXQrmorlPHcd2CkJBBEG/k9m8feP3
# HWPSZ1gcpZFG0l8Gmekoh1+NcoH5X10O+XBSZdR7omQHVVQmKb/xaDUT4KPAhs5t
# w5XQfvNtb/LDcIuzLfQy6VQY41PKRm6Q5rnn81RDilR9MYIEDTCCBAkCAQEwgZMw
# fDELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1Jl
# ZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjEmMCQGA1UEAxMd
# TWljcm9zb2Z0IFRpbWUtU3RhbXAgUENBIDIwMTACEzMAAAHj372bmhxogyIAAQAA
# AeMwDQYJYIZIAWUDBAIBBQCgggFKMBoGCSqGSIb3DQEJAzENBgsqhkiG9w0BCRAB
# BDAvBgkqhkiG9w0BCQQxIgQgp8LICRNUKJTWGessx4909EwSfy5BfutIU6vNuU0M
# 61IwgfoGCyqGSIb3DQEJEAIvMYHqMIHnMIHkMIG9BCAz1COr5bD+ZPdEgQjWvcIW
# uDJcQbdgq8Ndj0xyMuYmKjCBmDCBgKR+MHwxCzAJBgNVBAYTAlVTMRMwEQYDVQQI
# EwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVNaWNyb3Nv
# ZnQgQ29ycG9yYXRpb24xJjAkBgNVBAMTHU1pY3Jvc29mdCBUaW1lLVN0YW1wIFBD
# QSAyMDEwAhMzAAAB49+9m5ocaIMiAAEAAAHjMCIEIBYRHEyItxb2jZgXAZgxRHq5
# IKy3KLWzRe3+KrSD5Q5oMA0GCSqGSIb3DQEBCwUABIICAElcY/trmz05vsrYrYey
# GCTbhiMe4982mwvGs8YMJhwbV/AC6a3uFbKuVWmH7r1uSPRvepxzCDR825ucn6xP
# sTOgFVzNR0QlCHFUKWutbVdFmJ9JRQKocMxGG4tI44uDu3n975auYaFEm2X/K2yz
# gXm3h6rQqL25Oy8f5v0QkbGIPV2UswH9hBmi6Ry14nRoAR0JtWslmbWDWbnk0pFH
# jT6K1lyHNFn5wZAmBVSCiKB10X/OsZHtj70EzQtwZpLFO/sryuJGNF773s0pfgI8
# yeVQnmQlocDYPrGhMbuBuKy3qrjeEeMdqlUVYzSb65877GIH0/qq2DQNg2UStfDa
# U6k7UBsy1E7gl1wTvNjvPgzIkPqYSWIDxGTJm8EcFatZO32uMUSx/gVUFeSMEtxD
# gUY8n9/KMjLXBOPnjyXtmmsKJrZV93FDTopnyT+WCX5Wyblib+hde5g24WnrPwfA
# uJSV70tri7CkSO6h/28JoQadgMYylxznd7gkEQAHhvYL6RAqZKSip29v9VKEGaml
# eKcHHmZC7W4JrXnGHTdT3hbeOo76UobyQk3gmW2oM6vVywCxWjFuRjKfBazOoJ7q
# tx9OVRwK8gQb3lrUzmw6tSlY3h9SttltacrWDSqUGTmytx5sOQiCzT7k/Ot110Ro
# AH3RFmU1CfmAIwLuxbZV3JGl
# SIG # End signature block
