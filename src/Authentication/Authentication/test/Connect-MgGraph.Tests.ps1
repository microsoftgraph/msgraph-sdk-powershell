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
# MIInkwYJKoZIhvcNAQcCoIInhDCCJ4ACAQExDzANBglghkgBZQMEAgEFADB5Bgor
# BgEEAYI3AgEEoGswaTA0BgorBgEEAYI3AgEeMCYCAwEAAAQQH8w7YFlLCE63JNLG
# KX7zUQIBAAIBAAIBAAIBAAIBADAxMA0GCWCGSAFlAwQCAQUABCAAu5l9eG5ufPpb
# NazyMMCzbKhZcmS398lLvDuIAty00KCCDXYwggX0MIID3KADAgECAhMzAAADTrU8
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
# /Xmfwb1tbWrJUnMTDXpQzTGCGXMwghlvAgEBMIGVMH4xCzAJBgNVBAYTAlVTMRMw
# EQYDVQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVN
# aWNyb3NvZnQgQ29ycG9yYXRpb24xKDAmBgNVBAMTH01pY3Jvc29mdCBDb2RlIFNp
# Z25pbmcgUENBIDIwMTECEzMAAANOtTx6wYRv6ysAAAAAA04wDQYJYIZIAWUDBAIB
# BQCgga4wGQYJKoZIhvcNAQkDMQwGCisGAQQBgjcCAQQwHAYKKwYBBAGCNwIBCzEO
# MAwGCisGAQQBgjcCARUwLwYJKoZIhvcNAQkEMSIEINr1Obq01h2YnNDcr+diQ/t8
# rnOy6fVwIHEqB5hYgjl1MEIGCisGAQQBgjcCAQwxNDAyoBSAEgBNAGkAYwByAG8A
# cwBvAGYAdKEagBhodHRwOi8vd3d3Lm1pY3Jvc29mdC5jb20wDQYJKoZIhvcNAQEB
# BQAEggEAiEghpg9ELwo2E5LQk8Ekw70Q/LjXWqmKlnLypiNGvkcqBrulyq/JgEb0
# HfWZPnj2LWxVGLl3q7uG6CId+e+oFEMDCgYjNqdWI3j/nhqM1wWOtsuYFmEc7FKt
# v87sP4UePvD6SM9Ao735g73gFsRBu3BzAXKzBgNAv3WiiYV7er2EiFc4Mebbyfx2
# yoo2kIACKhnq08TwvGqcksRwc2QAJAzG9pQEQREFulICogjmU+66Hvdbtx2TX5Tq
# /HDv5MuUFr5DZdX7Es+Yd5VFgcFaKBhPDKLFqlo1TClUTI6a7mAVyIQyKWOWMEHx
# jys0zmeGzE3RhAPuAuPc83NSzKuhuKGCFv0wghb5BgorBgEEAYI3AwMBMYIW6TCC
# FuUGCSqGSIb3DQEHAqCCFtYwghbSAgEDMQ8wDQYJYIZIAWUDBAIBBQAwggFRBgsq
# hkiG9w0BCRABBKCCAUAEggE8MIIBOAIBAQYKKwYBBAGEWQoDATAxMA0GCWCGSAFl
# AwQCAQUABCASM7/qtKXCMBO3XhzRYeKws6C35c+F6O4RStDtmmh66QIGZLAQj9W5
# GBMyMDIzMDcxODIzNTAyMi4zOTZaMASAAgH0oIHQpIHNMIHKMQswCQYDVQQGEwJV
# UzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMHUmVkbW9uZDEeMBwGA1UE
# ChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMSUwIwYDVQQLExxNaWNyb3NvZnQgQW1l
# cmljYSBPcGVyYXRpb25zMSYwJAYDVQQLEx1UaGFsZXMgVFNTIEVTTjozRTdBLUUz
# NTktQTI1RDElMCMGA1UEAxMcTWljcm9zb2Z0IFRpbWUtU3RhbXAgU2VydmljZaCC
# EVQwggcMMIIE9KADAgECAhMzAAAByfrVjiUgdAJeAAEAAAHJMA0GCSqGSIb3DQEB
# CwUAMHwxCzAJBgNVBAYTAlVTMRMwEQYDVQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQH
# EwdSZWRtb25kMR4wHAYDVQQKExVNaWNyb3NvZnQgQ29ycG9yYXRpb24xJjAkBgNV
# BAMTHU1pY3Jvc29mdCBUaW1lLVN0YW1wIFBDQSAyMDEwMB4XDTIyMTEwNDE5MDEz
# OFoXDTI0MDIwMjE5MDEzOFowgcoxCzAJBgNVBAYTAlVTMRMwEQYDVQQIEwpXYXNo
# aW5ndG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVNaWNyb3NvZnQgQ29y
# cG9yYXRpb24xJTAjBgNVBAsTHE1pY3Jvc29mdCBBbWVyaWNhIE9wZXJhdGlvbnMx
# JjAkBgNVBAsTHVRoYWxlcyBUU1MgRVNOOjNFN0EtRTM1OS1BMjVEMSUwIwYDVQQD
# ExxNaWNyb3NvZnQgVGltZS1TdGFtcCBTZXJ2aWNlMIICIjANBgkqhkiG9w0BAQEF
# AAOCAg8AMIICCgKCAgEA1nLi5Y5vz8K+Woxhk7qGW/vCxi5euTM01TiEbFOG8g7S
# FB0VMjYgo6TiRzgOQ+CN53OBOKlyMHWzRL4xvaS03ZlIgetIILYiASogsEtljzEl
# RHO7fDGDFWcdz+lCNYmJoztbG3PMrnxblUHHUkr4C7EBHb2Y07Gd5GJBgP8+5AZN
# sTlsHGczHs45mmP7rUgcMn//c8Q/GYSqdT4OXELp53h99EnyF4zcsd2ZFjxdj1lP
# 8QGwZZS4F82JBGe2pCrSakyFjTxzFKUOwcQerwBR/YaQly7mtCra4PNcyEQm+n/L
# Dce/VViQa8OM2nBZHKw6CyMqEzFJJy5Hizz8Z6xrqqLKti8viJUQ0FtqkTXSR3//
# w8PAKyBlvIYTFF/Ly3Jh3cbVeOgSmubOVwv8nMehcQb2AtxcU/ldyEUqy8/thEHI
# WNabzHXx5O9D4btS6oJdgLmHxrTBtGscVQqx0z5/fUIkLE7tbwfoq84cF/URLEyw
# 3q57KV2U4gOhc356XYEVQdJXo6VFWBQDYbzanQ25zY21UCkj821CyD90gqrO3rQP
# lcQo6erwW2DF2fsmgAbVqzQsz6Rkmafz4re17km7qe09PuwHw5e3x5ZIGEoVlfNn
# Jv6+851uwKX6ApZFxPzeQo7W/5BtaTmkZEhwY5AdCPgPv0aaIEQn2qF7MvFwCcsC
# AwEAAaOCATYwggEyMB0GA1UdDgQWBBQFb51nRsI8ob54OhTFeVF7RC4yyzAfBgNV
# HSMEGDAWgBSfpxVdAF5iXYP05dJlpxtTNRnpcjBfBgNVHR8EWDBWMFSgUqBQhk5o
# dHRwOi8vd3d3Lm1pY3Jvc29mdC5jb20vcGtpb3BzL2NybC9NaWNyb3NvZnQlMjBU
# aW1lLVN0YW1wJTIwUENBJTIwMjAxMCgxKS5jcmwwbAYIKwYBBQUHAQEEYDBeMFwG
# CCsGAQUFBzAChlBodHRwOi8vd3d3Lm1pY3Jvc29mdC5jb20vcGtpb3BzL2NlcnRz
# L01pY3Jvc29mdCUyMFRpbWUtU3RhbXAlMjBQQ0ElMjAyMDEwKDEpLmNydDAMBgNV
# HRMBAf8EAjAAMBMGA1UdJQQMMAoGCCsGAQUFBwMIMA0GCSqGSIb3DQEBCwUAA4IC
# AQA2qLqcZt9HikIHcj7AlnHhjouxSjOeBaTE+EK8aXcVLm9cA8D2/ZY2OUpYvOdh
# uDEV9hElVmzopiJuk/xBYh6dWJTRhmS7hVjrGtqzSFW0LffsRysjxkpuqyhHiBDx
# MXMGZ6GdzUfqVP2Zd2O+J/BYQJgs9NHYz/CM4XaRP+T2VM3JE1mSO1qLa+mfB427
# QiLj/JC7TUYgh4RY+oLMFVuQJZvXYl/jITFfUppJoAakBr0Vc2r1kP5DiJaNvZWJ
# /cuYaiWQ4k9xpw6wGz3qq7xAWnlGzsawwFhjtwq5EH/s37LCfehyuCw8ZRJ9W3tg
# SFepAVM7sUE+Pr3Uu+iPvBV4TsTDNFL0CVIPX+1XOJ6YRGYJ2kHGpoGc/5sgA2IK
# Qcl97ZDYJIqixgwKNftyN70O0ATbpTVhsbN01FVli0H+vgcGhyzk6jpAywHPDSQ/
# xoEeGU4+6PFTXMRO/fMzGcUcf0ZHqZMm0UhoH8tOtk18k6B75KJXTtY3ZM7pTfur
# Sv2Qrv5zzCBiyystOPw/IJI+k9opTgatrC39L69/KwytD0x7t0jmTXtlLZaGvoSl
# jdyyr6QDRVkqsCaLUSSsAiWeav5qg64U3mLmeeko0E9TJ5yztN/jcizlHx0XsgOu
# N6sub3CPV7AAMMiKopdQYqiPXu9IxvqXT7CE/SMC2pcNyTCCB3EwggVZoAMCAQIC
# EzMAAAAVxedrngKbSZkAAAAAABUwDQYJKoZIhvcNAQELBQAwgYgxCzAJBgNVBAYT
# AlVTMRMwEQYDVQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYD
# VQQKExVNaWNyb3NvZnQgQ29ycG9yYXRpb24xMjAwBgNVBAMTKU1pY3Jvc29mdCBS
# b290IENlcnRpZmljYXRlIEF1dGhvcml0eSAyMDEwMB4XDTIxMDkzMDE4MjIyNVoX
# DTMwMDkzMDE4MzIyNVowfDELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0
# b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3Jh
# dGlvbjEmMCQGA1UEAxMdTWljcm9zb2Z0IFRpbWUtU3RhbXAgUENBIDIwMTAwggIi
# MA0GCSqGSIb3DQEBAQUAA4ICDwAwggIKAoICAQDk4aZM57RyIQt5osvXJHm9DtWC
# 0/3unAcH0qlsTnXIyjVX9gF/bErg4r25PhdgM/9cT8dm95VTcVrifkpa/rg2Z4VG
# Iwy1jRPPdzLAEBjoYH1qUoNEt6aORmsHFPPFdvWGUNzBRMhxXFExN6AKOG6N7dcP
# 2CZTfDlhAnrEqv1yaa8dq6z2Nr41JmTamDu6GnszrYBbfowQHJ1S/rboYiXcag/P
# XfT+jlPP1uyFVk3v3byNpOORj7I5LFGc6XBpDco2LXCOMcg1KL3jtIckw+DJj361
# VI/c+gVVmG1oO5pGve2krnopN6zL64NF50ZuyjLVwIYwXE8s4mKyzbnijYjklqwB
# Sru+cakXW2dg3viSkR4dPf0gz3N9QZpGdc3EXzTdEonW/aUgfX782Z5F37ZyL9t9
# X4C626p+Nuw2TPYrbqgSUei/BQOj0XOmTTd0lBw0gg/wEPK3Rxjtp+iZfD9M269e
# wvPV2HM9Q07BMzlMjgK8QmguEOqEUUbi0b1qGFphAXPKZ6Je1yh2AuIzGHLXpyDw
# wvoSCtdjbwzJNmSLW6CmgyFdXzB0kZSU2LlQ+QuJYfM2BjUYhEfb3BvR/bLUHMVr
# 9lxSUV0S2yW6r1AFemzFER1y7435UsSFF5PAPBXbGjfHCBUYP3irRbb1Hode2o+e
# FnJpxq57t7c+auIurQIDAQABo4IB3TCCAdkwEgYJKwYBBAGCNxUBBAUCAwEAATAj
# BgkrBgEEAYI3FQIEFgQUKqdS/mTEmr6CkTxGNSnPEP8vBO4wHQYDVR0OBBYEFJ+n
# FV0AXmJdg/Tl0mWnG1M1GelyMFwGA1UdIARVMFMwUQYMKwYBBAGCN0yDfQEBMEEw
# PwYIKwYBBQUHAgEWM2h0dHA6Ly93d3cubWljcm9zb2Z0LmNvbS9wa2lvcHMvRG9j
# cy9SZXBvc2l0b3J5Lmh0bTATBgNVHSUEDDAKBggrBgEFBQcDCDAZBgkrBgEEAYI3
# FAIEDB4KAFMAdQBiAEMAQTALBgNVHQ8EBAMCAYYwDwYDVR0TAQH/BAUwAwEB/zAf
# BgNVHSMEGDAWgBTV9lbLj+iiXGJo0T2UkFvXzpoYxDBWBgNVHR8ETzBNMEugSaBH
# hkVodHRwOi8vY3JsLm1pY3Jvc29mdC5jb20vcGtpL2NybC9wcm9kdWN0cy9NaWNS
# b29DZXJBdXRfMjAxMC0wNi0yMy5jcmwwWgYIKwYBBQUHAQEETjBMMEoGCCsGAQUF
# BzAChj5odHRwOi8vd3d3Lm1pY3Jvc29mdC5jb20vcGtpL2NlcnRzL01pY1Jvb0Nl
# ckF1dF8yMDEwLTA2LTIzLmNydDANBgkqhkiG9w0BAQsFAAOCAgEAnVV9/Cqt4Swf
# ZwExJFvhnnJL/Klv6lwUtj5OR2R4sQaTlz0xM7U518JxNj/aZGx80HU5bbsPMeTC
# j/ts0aGUGCLu6WZnOlNN3Zi6th542DYunKmCVgADsAW+iehp4LoJ7nvfam++Kctu
# 2D9IdQHZGN5tggz1bSNU5HhTdSRXud2f8449xvNo32X2pFaq95W2KFUn0CS9QKC/
# GbYSEhFdPSfgQJY4rPf5KYnDvBewVIVCs/wMnosZiefwC2qBwoEZQhlSdYo2wh3D
# YXMuLGt7bj8sCXgU6ZGyqVvfSaN0DLzskYDSPeZKPmY7T7uG+jIa2Zb0j/aRAfbO
# xnT99kxybxCrdTDFNLB62FD+CljdQDzHVG2dY3RILLFORy3BFARxv2T5JL5zbcqO
# Cb2zAVdJVGTZc9d/HltEAY5aGZFrDZ+kKNxnGSgkujhLmm77IVRrakURR6nxt67I
# 6IleT53S0Ex2tVdUCbFpAUR+fKFhbHP+CrvsQWY9af3LwUFJfn6Tvsv4O+S3Fb+0
# zj6lMVGEvL8CwYKiexcdFYmNcP7ntdAoGokLjzbaukz5m/8K6TT4JDVnK+ANuOaM
# mdbhIurwJ0I9JZTmdHRbatGePu1+oDEzfbzL6Xu/OHBE0ZDxyKs6ijoIYn/ZcGNT
# TY3ugm2lBRDBcQZqELQdVTNYs6FwZvKhggLLMIICNAIBATCB+KGB0KSBzTCByjEL
# MAkGA1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1v
# bmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjElMCMGA1UECxMcTWlj
# cm9zb2Z0IEFtZXJpY2EgT3BlcmF0aW9uczEmMCQGA1UECxMdVGhhbGVzIFRTUyBF
# U046M0U3QS1FMzU5LUEyNUQxJTAjBgNVBAMTHE1pY3Jvc29mdCBUaW1lLVN0YW1w
# IFNlcnZpY2WiIwoBATAHBgUrDgMCGgMVAH3pi8v+HgGbjVQs4G36dRxWBt0OoIGD
# MIGApH4wfDELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNV
# BAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjEmMCQG
# A1UEAxMdTWljcm9zb2Z0IFRpbWUtU3RhbXAgUENBIDIwMTAwDQYJKoZIhvcNAQEF
# BQACBQDoYSZoMCIYDzIwMjMwNzE4MjI1NTM2WhgPMjAyMzA3MTkyMjU1MzZaMHQw
# OgYKKwYBBAGEWQoEATEsMCowCgIFAOhhJmgCAQAwBwIBAAICChEwBwIBAAICEe8w
# CgIFAOhid+gCAQAwNgYKKwYBBAGEWQoEAjEoMCYwDAYKKwYBBAGEWQoDAqAKMAgC
# AQACAwehIKEKMAgCAQACAwGGoDANBgkqhkiG9w0BAQUFAAOBgQCWKP6OBAGSVHPF
# ntZEg9oe4LOd9vGFl3h3Y2wVI99w9PkBQT3YedzE5eI7uDP4TpkCTouyPZ5G2MGT
# IEa3ErkI5c1ySv4+9wsxm72E8qoGJ9J04AgJfvkP3rxCvgseARMDnOJMryoPcJpP
# Nl/HzVjYU5TjaXdvik0WGvSFNION9DGCBA0wggQJAgEBMIGTMHwxCzAJBgNVBAYT
# AlVTMRMwEQYDVQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYD
# VQQKExVNaWNyb3NvZnQgQ29ycG9yYXRpb24xJjAkBgNVBAMTHU1pY3Jvc29mdCBU
# aW1lLVN0YW1wIFBDQSAyMDEwAhMzAAAByfrVjiUgdAJeAAEAAAHJMA0GCWCGSAFl
# AwQCAQUAoIIBSjAaBgkqhkiG9w0BCQMxDQYLKoZIhvcNAQkQAQQwLwYJKoZIhvcN
# AQkEMSIEIAp279gh1P1uaq57one93kVX3ZqH6yOLfZjymI50whRAMIH6BgsqhkiG
# 9w0BCRACLzGB6jCB5zCB5DCBvQQggXXOf1LdUUsQJ3gp2H9gDSMhiQD/zX3hXXzh
# 2Tl2/YEwgZgwgYCkfjB8MQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGluZ3Rv
# bjEQMA4GA1UEBxMHUmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0
# aW9uMSYwJAYDVQQDEx1NaWNyb3NvZnQgVGltZS1TdGFtcCBQQ0EgMjAxMAITMwAA
# Acn61Y4lIHQCXgABAAAByTAiBCDojbgdRkzD/cux0+ZUmHBqRyYtGWEMLfIbs6HX
# t/EXKDANBgkqhkiG9w0BAQsFAASCAgB19P6+y+Q8JmhaFNdgo/PX5kvvdsFuc9Si
# s+YpQXwd51RCyFRpYRT75SCDDUG39gBgH7f6Qa8NJ62Cao9ZlHzFQ36DMYH6lxlg
# PUDm9HhfkpWrk/Mt1fqFNa3DXVpIY/G3PAVspdauWmvRLjkQ3C/iduCGcC9bxZz7
# +/ELzuIjQ8DYif24W7zKtQL9N7ejESb5Ug2xsEd/zLRog7HorPW12PDVwdOGxJX6
# /zFVRiKMHACj8EA18ncyoz6u6Qvpdd8emUgBupZrQLNsxmDzMrrGBujUOGYkd4Ba
# PwZiaEVZdS05md/CH7ziTv7Z/qOz7IvWnDFoxn8pSS2oDP81eVnMxWKQ2ihIshCv
# /S2MZ95IhXgYufa6tlNyIzoVw11lmaTueWrpNp3m3b5EFDb9H70ZUFN5MPP2k6Xn
# sXSSN+ayPFs+FGA9f1XAE1gdJg0tQmUjfV8tgNPcA0bMU0sPQ88kUR4fvxAzKO8j
# nZVhgClpmPdqs7voUIIICGi2v+bc0CiHqgzJlSitswbc6TkfxSREkAvXNckXC7V2
# +/tPkWcXmEhogkqHjIyzh5HKOvxCFqj8JIHVKc50RJItK8wAcE3PliPyjwehVBdn
# jCCLEKSR1ECbnbuLvT/XNQcD8DsnM0G444XRTgvAStGgZlhkNtl6I8HM9e6Fq/6R
# 61e6LK/p4w==
# SIG # End signature block
