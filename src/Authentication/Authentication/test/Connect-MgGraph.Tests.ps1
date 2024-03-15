# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------

BeforeAll {
    $ModuleName = "Microsoft.Graph.Authentication"
    $ModulePath = Join-Path $PSScriptRoot "..\artifacts\$ModuleName.psd1"
    Import-Module $ModulePath -Force
    $RandomClientId = (New-Guid).Guid
    
    $AvailableAzModule = Get-Module Az.Accounts -ListAvailable
    if ($AvailableAzModule.Count -lt 1) {
        Install-Module Az.Accounts -Repository PSGallery -Scope CurrentUser -Force -AllowClobber
    }
}
Describe 'Connect-MgGraph ParameterSets' {
    BeforeAll {
        $ConnectMgGraphCommand = Get-Command Connect-MgGraph
    }
    it 'Should have three ParameterSets' {
        $ConnectMgGraphCommand | Should -Not -BeNullOrEmpty
        $ConnectMgGraphCommand.ParameterSets | Should -HaveCount 6
    }
    It 'Should have UserParameterSet' {
        $UserParameterSet = $ConnectMgGraphCommand.ParameterSets | Where-Object Name -eq 'UserParameterSet'
        $UserParameterSet | Should -Not -BeNull
        $UserParameterSet.IsDefault | Should -BeTrue
        $UserParameterSet.Parameters | Where-Object IsMandatory | Should -HaveCount 0
        @('ClientId', 'TenantId', 'ContextScope', 'Environment', 'ClientTimeout') | Should -BeIn $UserParameterSet.Parameters.Name
    }

    It 'Should have AppCertificateParameterSet' {
        $AppCertificateParameterSet = $ConnectMgGraphCommand.ParameterSets | Where-Object Name -eq 'AppCertificateParameterSet'
        $AppCertificateParameterSet | Should -Not -BeNull
        @('ClientId', 'TenantId', 'CertificateSubjectName', 'CertificateThumbprint', 'ContextScope', 'Environment', 'ClientTimeout') | Should -BeIn $AppCertificateParameterSet.Parameters.Name
        $MandatoryParameters = $AppCertificateParameterSet.Parameters | Where-Object IsMandatory
        $MandatoryParameters | Should -HaveCount 1
        $MandatoryParameters.Name | Should -Be 'ClientId'
    }

    It 'Should have AppSecretCredentialParameterSet' {
        $AppSecretCredentialParameterSet = $ConnectMgGraphCommand.ParameterSets | Where-Object Name -eq 'AppSecretCredentialParameterSet'
        $AppSecretCredentialParameterSet | Should -Not -BeNull
        @('ClientSecretCredential', 'TenantId', 'ContextScope', 'Environment', 'ClientTimeout') | Should -BeIn $AppSecretCredentialParameterSet.Parameters.Name
        $MandatoryParameters = $AppSecretCredentialParameterSet.Parameters | Where-Object IsMandatory
        $MandatoryParameters | Should -HaveCount 0
    }

    It 'Should have EnvironmentVariableParameterSet' {
        $EnvironmentVariableParameterSet = $ConnectMgGraphCommand.ParameterSets | Where-Object Name -eq 'EnvironmentVariableParameterSet'
        $EnvironmentVariableParameterSet | Should -Not -BeNull
        @('EnvironmentVariable', 'ContextScope', 'Environment', 'ClientTimeout') | Should -BeIn $EnvironmentVariableParameterSet.Parameters.Name
        $MandatoryParameters = $EnvironmentVariableParameterSet.Parameters | Where-Object IsMandatory
        $MandatoryParameters | Should -HaveCount 0
    }

    It 'Should Have AccessTokenParameterSet' {
        $AccessTokenParameterSet = $ConnectMgGraphCommand.ParameterSets | Where-Object Name -eq 'AccessTokenParameterSet'
        $AccessTokenParameterSet | Should -Not -BeNull
        @('AccessToken', 'Environment', 'ClientTimeout') | Should -BeIn $AccessTokenParameterSet.Parameters.Name
        $MandatoryParameters = $AccessTokenParameterSet.Parameters | Where-Object IsMandatory
        $MandatoryParameters | Should -HaveCount 1
        $MandatoryParameters.Name | Should -Be 'AccessToken'
    }
}

Describe 'Connect-MgGraph In Delegated Mode' {
    # We'll skip this test until https://github.com/Azure/azure-sdk-for-net/issues/28036 is fixed.
    It 'Should throw exception when invalid tenantId is specified' -skip {
        { Connect-MgGraph -TenantId "thisdomaindoesnotexist.com" -ErrorAction Stop -UseDeviceAuthentication } | Should -Throw -ExpectedMessage "*AADSTS90002*Tenant 'thisdomaindoesnotexist.com' not found*"
    }
}

Describe 'Connect-MgGraph In Environment Variable Mode' {
    It 'Should throw exception when supported environment variables are not specified' {
        { Connect-MgGraph -EnvironmentVariable -ErrorAction Stop } | Should -Throw -ExpectedMessage "*EnvironmentCredential authentication unavailable. Environment variables are not fully configured*"
    }
    It 'Should attempt to use configured environment variables' {
        {
            $Env:AZURE_CLIENT_ID = "Not_Valid"
            $Env:AZURE_CLIENT_SECRET = "Not_Valid"
            $Env:AZURE_TENANT_ID = "common"
            Connect-MgGraph -EnvironmentVariable -ErrorAction Stop
        } | Should -Throw -ExpectedMessage "*ClientSecretCredential authentication failed: AADSTS700016: Application with identifier 'Not_Valid' was not found in the directory 'Microsoft'.*"
    }
}

Describe 'Connect-MgGraph In App Mode' {
    It 'Should throw exception when certificate thumbprint length is > 40' {
        { Connect-MgGraph -ClientId $RandomClientId -CertificateThumbprint '12345678901234567890123456789012345678901' -ErrorAction Stop } | Should -Throw -ExpectedMessage "*'CertificateThumbprint' must have a length of 40.*"
    }

    It 'Should throw exception when certificate thumbprint length is < 40' {
        { Connect-MgGraph -ClientId $RandomClientId -CertificateThumbprint '123456789012345678901234567890123456789' -ErrorAction Stop } | Should -Throw -ExpectedMessage "*'CertificateThumbprint' must have a length of 40.*"
    }

}

Describe 'Connect-MgGraph Dependency Resolution' {
    It 'Should load Mg module side by side with Az module.' {
        { Connect-AzAccount -ApplicationId $RandomClientId -CertificateThumbprint "Invalid" -Tenant "Invalid" -ErrorAction Stop } | Should -Throw -ExpectedMessage "*Could not find tenant id*"
        { Connect-MgGraph -TenantId "thisdomaindoesnotexist.com" -ErrorAction Stop -UseDeviceAuthentication } | Should -Throw -ExpectedMessage "*AADSTS90002*"
    }
}

Describe 'Connect-MgGraph Logging' {
    It 'Should write MSAL logs to debug stream.' {
        $MgDebugStream = $(Connect-MgGraph -TenantId "thisdomaindoesnotexist.com" -UseDeviceAuthentication -Debug -ErrorAction SilentlyContinue) 5>&1
        $MgDebugStream[0] | Should -Match "DeviceCodeCredential.Authenticate invoked. Scopes: \[ User.Read \]"
    }
}
# SIG # Begin signature block
# MIIn0QYJKoZIhvcNAQcCoIInwjCCJ74CAQExDzANBglghkgBZQMEAgEFADB5Bgor
# BgEEAYI3AgEEoGswaTA0BgorBgEEAYI3AgEeMCYCAwEAAAQQH8w7YFlLCE63JNLG
# KX7zUQIBAAIBAAIBAAIBAAIBADAxMA0GCWCGSAFlAwQCAQUABCAAu5l9eG5ufPpb
# NazyMMCzbKhZcmS398lLvDuIAty00KCCDYUwggYDMIID66ADAgECAhMzAAADTU6R
# phoosHiPAAAAAANNMA0GCSqGSIb3DQEBCwUAMH4xCzAJBgNVBAYTAlVTMRMwEQYD
# VQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVNaWNy
# b3NvZnQgQ29ycG9yYXRpb24xKDAmBgNVBAMTH01pY3Jvc29mdCBDb2RlIFNpZ25p
# bmcgUENBIDIwMTEwHhcNMjMwMzE2MTg0MzI4WhcNMjQwMzE0MTg0MzI4WjB0MQsw
# CQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMHUmVkbW9u
# ZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMR4wHAYDVQQDExVNaWNy
# b3NvZnQgQ29ycG9yYXRpb24wggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIB
# AQDUKPcKGVa6cboGQU03ONbUKyl4WpH6Q2Xo9cP3RhXTOa6C6THltd2RfnjlUQG+
# Mwoy93iGmGKEMF/jyO2XdiwMP427j90C/PMY/d5vY31sx+udtbif7GCJ7jJ1vLzd
# j28zV4r0FGG6yEv+tUNelTIsFmmSb0FUiJtU4r5sfCThvg8dI/F9Hh6xMZoVti+k
# bVla+hlG8bf4s00VTw4uAZhjGTFCYFRytKJ3/mteg2qnwvHDOgV7QSdV5dWdd0+x
# zcuG0qgd3oCCAjH8ZmjmowkHUe4dUmbcZfXsgWlOfc6DG7JS+DeJak1DvabamYqH
# g1AUeZ0+skpkwrKwXTFwBRltAgMBAAGjggGCMIIBfjAfBgNVHSUEGDAWBgorBgEE
# AYI3TAgBBggrBgEFBQcDAzAdBgNVHQ4EFgQUId2Img2Sp05U6XI04jli2KohL+8w
# VAYDVR0RBE0wS6RJMEcxLTArBgNVBAsTJE1pY3Jvc29mdCBJcmVsYW5kIE9wZXJh
# dGlvbnMgTGltaXRlZDEWMBQGA1UEBRMNMjMwMDEyKzUwMDUxNzAfBgNVHSMEGDAW
# gBRIbmTlUAXTgqoXNzcitW2oynUClTBUBgNVHR8ETTBLMEmgR6BFhkNodHRwOi8v
# d3d3Lm1pY3Jvc29mdC5jb20vcGtpb3BzL2NybC9NaWNDb2RTaWdQQ0EyMDExXzIw
# MTEtMDctMDguY3JsMGEGCCsGAQUFBwEBBFUwUzBRBggrBgEFBQcwAoZFaHR0cDov
# L3d3dy5taWNyb3NvZnQuY29tL3BraW9wcy9jZXJ0cy9NaWNDb2RTaWdQQ0EyMDEx
# XzIwMTEtMDctMDguY3J0MAwGA1UdEwEB/wQCMAAwDQYJKoZIhvcNAQELBQADggIB
# ACMET8WuzLrDwexuTUZe9v2xrW8WGUPRQVmyJ1b/BzKYBZ5aU4Qvh5LzZe9jOExD
# YUlKb/Y73lqIIfUcEO/6W3b+7t1P9m9M1xPrZv5cfnSCguooPDq4rQe/iCdNDwHT
# 6XYW6yetxTJMOo4tUDbSS0YiZr7Mab2wkjgNFa0jRFheS9daTS1oJ/z5bNlGinxq
# 2v8azSP/GcH/t8eTrHQfcax3WbPELoGHIbryrSUaOCphsnCNUqUN5FbEMlat5MuY
# 94rGMJnq1IEd6S8ngK6C8E9SWpGEO3NDa0NlAViorpGfI0NYIbdynyOB846aWAjN
# fgThIcdzdWFvAl/6ktWXLETn8u/lYQyWGmul3yz+w06puIPD9p4KPiWBkCesKDHv
# XLrT3BbLZ8dKqSOV8DtzLFAfc9qAsNiG8EoathluJBsbyFbpebadKlErFidAX8KE
# usk8htHqiSkNxydamL/tKfx3V/vDAoQE59ysv4r3pE+zdyfMairvkFNNw7cPn1kH
# Gcww9dFSY2QwAxhMzmoM0G+M+YvBnBu5wjfxNrMRilRbxM6Cj9hKFh0YTwba6M7z
# ntHHpX3d+nabjFm/TnMRROOgIXJzYbzKKaO2g1kWeyG2QtvIR147zlrbQD4X10Ab
# rRg9CpwW7xYxywezj+iNAc+QmFzR94dzJkEPUSCJPsTFMIIHejCCBWKgAwIBAgIK
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
# Y3Jvc29mdCBDb2RlIFNpZ25pbmcgUENBIDIwMTECEzMAAANNTpGmGiiweI8AAAAA
# A00wDQYJYIZIAWUDBAIBBQCgga4wGQYJKoZIhvcNAQkDMQwGCisGAQQBgjcCAQQw
# HAYKKwYBBAGCNwIBCzEOMAwGCisGAQQBgjcCARUwLwYJKoZIhvcNAQkEMSIEINr1
# Obq01h2YnNDcr+diQ/t8rnOy6fVwIHEqB5hYgjl1MEIGCisGAQQBgjcCAQwxNDAy
# oBSAEgBNAGkAYwByAG8AcwBvAGYAdKEagBhodHRwOi8vd3d3Lm1pY3Jvc29mdC5j
# b20wDQYJKoZIhvcNAQEBBQAEggEAsC7qODCFPNx+1/w9slXN/2z+voIm0Hz/2Ctr
# SyQTOMlzR3qDzgmViFCOJakdxcTnAdloqGc2v2o8KVOhL/Om8TW4bHFIUcw9idU4
# 8uquu4onrZhMrZuFm9xvnMSr1ctF8evwiNS0R+R38Bk5GQGRjSs2ydxK2WLcEOVB
# W5QeVNI2ocm2XxvVy/FVLRW31uW/E0dWDcVd1uiey9Ra2qwJ4a1OhSQ7xJxfBkdC
# KjjM76eXgujbupcqo3ScaXNkb9mVmlrbJeX2ao7hlJUBlqCwoYjDGzJJ8Ocl68S+
# ElbT+CuN16nOHK69+5zpJte61DWA2IzeJTT0l5DXz5cVDWB+TKGCFywwghcoBgor
# BgEEAYI3AwMBMYIXGDCCFxQGCSqGSIb3DQEHAqCCFwUwghcBAgEDMQ8wDQYJYIZI
# AWUDBAIBBQAwggFZBgsqhkiG9w0BCRABBKCCAUgEggFEMIIBQAIBAQYKKwYBBAGE
# WQoDATAxMA0GCWCGSAFlAwQCAQUABCDzLp7nEzBehGZyZN1rdkn+QqbAyhyhxCKf
# qRxihwJJ5gIGZV34gu+VGBMyMDIzMTIwNzEzMzMyOS4yNjJaMASAAgH0oIHYpIHV
# MIHSMQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMH
# UmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMS0wKwYDVQQL
# EyRNaWNyb3NvZnQgSXJlbGFuZCBPcGVyYXRpb25zIExpbWl0ZWQxJjAkBgNVBAsT
# HVRoYWxlcyBUU1MgRVNOOjA4NDItNEJFNi1DMjlBMSUwIwYDVQQDExxNaWNyb3Nv
# ZnQgVGltZS1TdGFtcCBTZXJ2aWNloIIRezCCBycwggUPoAMCAQICEzMAAAHajtXJ
# WgDREbEAAQAAAdowDQYJKoZIhvcNAQELBQAwfDELMAkGA1UEBhMCVVMxEzARBgNV
# BAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jv
# c29mdCBDb3Jwb3JhdGlvbjEmMCQGA1UEAxMdTWljcm9zb2Z0IFRpbWUtU3RhbXAg
# UENBIDIwMTAwHhcNMjMxMDEyMTkwNjU5WhcNMjUwMTEwMTkwNjU5WjCB0jELMAkG
# A1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQx
# HjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjEtMCsGA1UECxMkTWljcm9z
# b2Z0IElyZWxhbmQgT3BlcmF0aW9ucyBMaW1pdGVkMSYwJAYDVQQLEx1UaGFsZXMg
# VFNTIEVTTjowODQyLTRCRTYtQzI5QTElMCMGA1UEAxMcTWljcm9zb2Z0IFRpbWUt
# U3RhbXAgU2VydmljZTCCAiIwDQYJKoZIhvcNAQEBBQADggIPADCCAgoCggIBAJOQ
# Bgh2tVFR1j8jQA4NDf8bcVrXSN080CNKPSQo7S57sCnPU0FKF47w2L6qHtwm4EnC
# lF2cruXFp/l7PpMQg25E7X8xDmvxr8BBE6iASAPCfrTebuvAsZWcJYhy7prgCuBf
# 7OidXpgsW1y8p6Vs7sD2aup/0uveYxeXlKtsPjMCplHkk0ba+HgLho0J68Kdji3D
# M2K59wHy9xrtsYK+X9erbDGZ2mmX3765aS5Q7/ugDxMVgzyj80yJn6ULnknD9i4k
# UQxVhqV1dc/DF6UBeuzfukkMed7trzUEZMRyla7qhvwUeQlgzCQhpZjz+zsQgpXl
# PczvGd0iqr7lACwfVGog5plIzdExvt1TA8Jmef819aTKwH1IVEIwYLA6uvS8kRdA
# 6RxvMcb//ulNjIuGceyykMAXEynVrLG9VvK4rfrCsGL3j30Lmidug+owrcCjQagY
# mrGk1hBykXilo9YB8Qyy5Q1KhGuH65V3zFy8a0kwbKBRs8VR4HtoPYw9z1DdcJfZ
# BO2dhzX3yAMipCGm6SmvmvavRsXhy805jiApDyN+s0/b7os2z8iRWGJk6M9uuT24
# 93gFV/9JLGg5YJJCJXI+yxkO/OXnZJsuGt0+zWLdHS4XIXBG17oPu5KsFfRTHREl
# oR2dI6GwaaxIyDySHYOtvIydla7u4lfnfCjY/qKTAgMBAAGjggFJMIIBRTAdBgNV
# HQ4EFgQUoXyNyVE9ZhOVizEUVwhNgL8PX0UwHwYDVR0jBBgwFoAUn6cVXQBeYl2D
# 9OXSZacbUzUZ6XIwXwYDVR0fBFgwVjBUoFKgUIZOaHR0cDovL3d3dy5taWNyb3Nv
# ZnQuY29tL3BraW9wcy9jcmwvTWljcm9zb2Z0JTIwVGltZS1TdGFtcCUyMFBDQSUy
# MDIwMTAoMSkuY3JsMGwGCCsGAQUFBwEBBGAwXjBcBggrBgEFBQcwAoZQaHR0cDov
# L3d3dy5taWNyb3NvZnQuY29tL3BraW9wcy9jZXJ0cy9NaWNyb3NvZnQlMjBUaW1l
# LVN0YW1wJTIwUENBJTIwMjAxMCgxKS5jcnQwDAYDVR0TAQH/BAIwADAWBgNVHSUB
# Af8EDDAKBggrBgEFBQcDCDAOBgNVHQ8BAf8EBAMCB4AwDQYJKoZIhvcNAQELBQAD
# ggIBALmDVdTtuI0jAEt41O2OM8CU237TGMyhrGr7FzKCEFaXxtoqk/IObQriq1ca
# HVh2vyuQ24nz3TdOBv7rcs/qnPjOxnXFLyZPeaWLsNuARVmUViyVYXjXYB5DwzaW
# ZgScY8GKL7yGjyWrh78WJUgh7rE1+5VD5h0/6rs9dBRqAzI9fhZz7spsjt8vnx50
# WExbBSSH7rfabHendpeqbTmW/RfcaT+GFIsT+g2ej7wRKIq/QhnsoF8mpFNPHV1q
# /WK/rF/ChovkhJMDvlqtETWi97GolOSKamZC9bYgcPKfz28ed25WJy10VtQ9P5+C
# /2dOfDaz1RmeOb27Kbegha0SfPcriTfORVvqPDSa3n9N7dhTY7+49I8evoad9hdZ
# 8CfIOPftwt3xTX2RhMZJCVoFlabHcvfb84raFM6cz5EYk+x1aVEiXtgK6R0xn1wj
# MXHf0AWlSjqRkzvSnRKzFsZwEl74VahlKVhI+Ci9RT9+6Gc0xWzJ7zQIUFE3Jiix
# 5+7KL8ArHfBY9UFLz4snboJ7Qip3IADbkU4ZL0iQ8j8Ixra7aSYfToUefmct3dM6
# 9ff4Eeh2Kh9NsKiiph589Ap/xS1jESlrfjL/g/ZboaS5d9a2fA598mubDvLD5x5P
# P37700vm/Y+PIhmp2fTvuS2sndeZBmyTqcUNHRNmCk+njV3nMIIHcTCCBVmgAwIB
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
# aGFsZXMgVFNTIEVTTjowODQyLTRCRTYtQzI5QTElMCMGA1UEAxMcTWljcm9zb2Z0
# IFRpbWUtU3RhbXAgU2VydmljZaIjCgEBMAcGBSsOAwIaAxUAQqIfIYljHUbNoY0/
# wjhXRn/sSA2ggYMwgYCkfjB8MQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGlu
# Z3RvbjEQMA4GA1UEBxMHUmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBv
# cmF0aW9uMSYwJAYDVQQDEx1NaWNyb3NvZnQgVGltZS1TdGFtcCBQQ0EgMjAxMDAN
# BgkqhkiG9w0BAQUFAAIFAOkcPFIwIhgPMjAyMzEyMDcyMDQyNThaGA8yMDIzMTIw
# ODIwNDI1OFowdzA9BgorBgEEAYRZCgQBMS8wLTAKAgUA6Rw8UgIBADAKAgEAAgIJ
# lgIB/zAHAgEAAgJG3jAKAgUA6R2N0gIBADA2BgorBgEEAYRZCgQCMSgwJjAMBgor
# BgEEAYRZCgMCoAowCAIBAAIDB6EgoQowCAIBAAIDAYagMA0GCSqGSIb3DQEBBQUA
# A4GBAJwIR3wHahcuXSo8KVeFnUDDzneg4T8ry7JHBz+rUFnwgmrHqJ96gRAwrsjF
# yTTsdf4cXsZtNns3VK8WVnDqiP+XbDEcs1PI5WNOgLgbye+rIzbJz5Z52Ih+/jCm
# +TG94Dlk3lR7mOOOyVmj19VRSl+ZwdiPLY56YUi1XnsSLMjpMYIEDTCCBAkCAQEw
# gZMwfDELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNVBAcT
# B1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjEmMCQGA1UE
# AxMdTWljcm9zb2Z0IFRpbWUtU3RhbXAgUENBIDIwMTACEzMAAAHajtXJWgDREbEA
# AQAAAdowDQYJYIZIAWUDBAIBBQCgggFKMBoGCSqGSIb3DQEJAzENBgsqhkiG9w0B
# CRABBDAvBgkqhkiG9w0BCQQxIgQg8S+54YZ96xoMqK84E0CEQwq/axawdCP/+G7N
# 86cRoeYwgfoGCyqGSIb3DQEJEAIvMYHqMIHnMIHkMIG9BCAipaNpYsDvnqTe95Dj
# 1C09020I5ljibrW/ndICOxg9xjCBmDCBgKR+MHwxCzAJBgNVBAYTAlVTMRMwEQYD
# VQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVNaWNy
# b3NvZnQgQ29ycG9yYXRpb24xJjAkBgNVBAMTHU1pY3Jvc29mdCBUaW1lLVN0YW1w
# IFBDQSAyMDEwAhMzAAAB2o7VyVoA0RGxAAEAAAHaMCIEIFsYfmUFNkhmPN6QBDht
# BJ3HJtoFkPygauhaxt149PiPMA0GCSqGSIb3DQEBCwUABIICAHflEoqKcYo+TjY8
# hy8EOz7a1ONpmnXt2FIhCCrKRPHMBjzUtzv3CG5YPv/yxjFjBDG9yZhSAMMs+Ca7
# KbBStAxptQ0kDw3fDtkuwAaiTofYwHkLHycoOAkArzF2w8p1lWVS8GOEarR9idwQ
# VWOS2LYqmZ3lhpXg06mL76I6vnZDIVqBVQVciTcD6G7gVID8Xp5qJ0Gg3z8sUxTK
# 7QYgF5m4MOO7yE6i1orzJJh7u6wHCSV0E3ypPAPYSNeVz7L+3U+Kt+85TZDPdzAd
# o8j+ZWe7da3/zLa+DXfy2GlFwtFenK8DSoffgMBW6O1f87uzGj6+G/wePARfbimz
# mlE35SXLbcJS7oOqLJqszScrwyvS+wPdt9r2QyC/Fs4VNuxy9cikBUGfd8HXioR6
# /rEQbmWmvW5O7Apq4dPnkRWhZBg2OgBVMawv9fW4DErANS/jetuHl+c2FkhKfHdt
# 2GZBaw/pLzbvH7xoLtTQiQJh+TK1ly0YeXlb6Tg4ClNOqUjyz69mBfhosjcLgBMw
# W8/tPwH/C7zjUIUYP7mjSejDSivCflXif4DuL0GQnV7SgrKydywbaMWpLYNVpQYL
# iudXnz/cYNXMOp77lFOIJffudMED3TMW8l5Js2r1cE3VGTCfq7Oe9nmO6FQdWGMO
# RFV6mtRrU9BOzDrsFhFrOpXPiGeO
# SIG # End signature block
