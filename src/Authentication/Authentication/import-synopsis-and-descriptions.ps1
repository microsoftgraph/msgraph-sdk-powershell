Param(
    [string] $DocsLocation = (Join-Path $PSScriptRoot "../docs/"),
    [string] $CmdletsList = (Join-Path $PSScriptRoot "../docs/Microsoft.Graph.Authentication.md"),
    [string] $SynopsisLocation = (Join-Path $PSScriptRoot "../synopsis/"),
    [string] $DescriptionLocation = (Join-Path $PSScriptRoot "../descriptions/")
  
)
$ImportMapping = @{
    "descriptions" = "## DESCRIPTION(?s).*## EXAMPLES"
    "synopsis"     = "## SYNOPSIS(?s).*## SYNTAX"
}
$MetaDataMapping = @{
    "Module Guid:"        = "Module Guid:.+"
    "Download Help Link:" = "Download Help Link:.+"
    "Locale:"             = "Locale:.+"
    "Help Version:"       = "Help Version:.+"
}
function Start-Import {
    foreach ($File in Get-ChildItem $DocsLocation) {
        $ImportMapping.Keys | ForEach-Object {
            $ImportContent = $_
            $SearchBlock = $ImportMapping[$ImportContent]
            $LocationFile = (Join-Path $SynopsisLocation $File.Name)
            if ($ImportContent -eq "descriptions") {
                $LocationFile = (Join-Path $DescriptionLocation $File.Name)
            }

    
            if (Test-Path $LocationFile) {
                $FileEmpty = Test-FileEmpty -File $LocationFile
                if (-not($FileEmpty)) {
                    Write-Host $LocationFile
                    $Content = Get-Content -Path $LocationFile
                    $FinalOutput = "## SYNOPSIS`r`n$Content`r`n## SYNTAX"
                    if ($ImportContent -eq "descriptions") {
                        $FinalOutput = "## DESCRIPTION`r`n$Content`r`n## EXAMPLES"
                    }
                    Import-Content -Content $Content -File $File -SearchBlock $SearchBlock -FinalOutput $FinalOutput
                }
            }
        }
    }
    $MetaDataMapping.Keys | ForEach-Object {
        $MetaDataContent = $_
        $SearchBlock = $MetaDataMapping[$MetaDataContent]
        UpdateMetaDataHeader -SearchBlock $SearchBlock -MetaDataContent $MetaDataContent
    }
}


function Import-Content {
    Param (
        [object]$Content,
        [string]$File,
        [string]$SearchBlock,
        [string]$FinalOutput
    ) 

    $option = [System.Text.RegularExpressions.RegexOptions]::Multiline
    $Re = [regex]::new($SearchBlock, $option)
    if (Test-Path $File) {
        $DestinationContent = Get-Content -Encoding UTF8 -Raw $File
        if ($DestinationContent -match $Re) {
            $Extracted = $Matches[0]
            $text = $DestinationContent.ToString()
            $text = $text.Replace($Extracted, $FinalOutput)
        }
        $text | Out-File $File -Encoding UTF8
    }
    $Stream = [IO.File]::OpenWrite($File)
    try {
        $Stream.SetLength($stream.Length - 2)
        $Stream.Close()
    }
    catch {
         
    }
    $Stream.Dispose()
}
function UpdateMetaDataHeader {
    Param (
        [string]$SearchBlock,
        [string]$MetaDataContent
    )
    $option = [System.Text.RegularExpressions.RegexOptions]::Multiline
    $Re = [regex]::new($SearchBlock, $option)
    $DestinationContent = Get-Content -Encoding UTF8 -Raw $CmdletsList
    $text = $DestinationContent.ToString()
    if ($DestinationContent -match $Re) {
        $Extracted = $Matches[0]
        if ($MetaDataContent -eq "Module Guid:") {
            $Guid = "Module Guid: " + [guid]::NewGuid()
            $text = $text.Replace($Extracted, $Guid) 
        }
        elseif ($MetaDataContent -eq "Download Help Link:") {
            $Link = "Download Help Link: https://learn.microsoft.com/powershell/module/Microsoft.Graph.Authentication"
            $text = $text.Replace($Extracted, $Link) 
        }
        elseif ($MetaDataContent -eq "Locale:") {
            $Locale = "Locale: en-US"
            $text = $text.Replace($Extracted, $Locale) 
        }
        elseif ($MetaDataContent -eq "Help Version:") {
            $HelpVersion = "Help Version: 1.0.0.0"
            $text = $text.Replace($Extracted, $HelpVersion) 
        }
        $text = $text.Replace("{{ Fill in the Description }}", "Microsoft Graph PowerShell Authentication Cmdlets")
        $text | Out-File $CmdletsList -Encoding UTF8
    }
}

Function Test-FileEmpty {

    Param ([Parameter(Mandatory = $true)][string]$File)
  
    if ((Test-Path -LiteralPath $File) -and !((Get-Content -LiteralPath $file -Raw) -match '\S')) { return $true } else { return $false }
  
}
Start-Import
# SIG # Begin signature block
# MIIoKgYJKoZIhvcNAQcCoIIoGzCCKBcCAQExDzANBglghkgBZQMEAgEFADB5Bgor
# BgEEAYI3AgEEoGswaTA0BgorBgEEAYI3AgEeMCYCAwEAAAQQH8w7YFlLCE63JNLG
# KX7zUQIBAAIBAAIBAAIBAAIBADAxMA0GCWCGSAFlAwQCAQUABCDQ807B3YbhWS8g
# 7yNGn5pt47bc6QRubtOIW11KVe+XHaCCDXYwggX0MIID3KADAgECAhMzAAADrzBA
# DkyjTQVBAAAAAAOvMA0GCSqGSIb3DQEBCwUAMH4xCzAJBgNVBAYTAlVTMRMwEQYD
# VQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVNaWNy
# b3NvZnQgQ29ycG9yYXRpb24xKDAmBgNVBAMTH01pY3Jvc29mdCBDb2RlIFNpZ25p
# bmcgUENBIDIwMTEwHhcNMjMxMTE2MTkwOTAwWhcNMjQxMTE0MTkwOTAwWjB0MQsw
# CQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMHUmVkbW9u
# ZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMR4wHAYDVQQDExVNaWNy
# b3NvZnQgQ29ycG9yYXRpb24wggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIB
# AQDOS8s1ra6f0YGtg0OhEaQa/t3Q+q1MEHhWJhqQVuO5amYXQpy8MDPNoJYk+FWA
# hePP5LxwcSge5aen+f5Q6WNPd6EDxGzotvVpNi5ve0H97S3F7C/axDfKxyNh21MG
# 0W8Sb0vxi/vorcLHOL9i+t2D6yvvDzLlEefUCbQV/zGCBjXGlYJcUj6RAzXyeNAN
# xSpKXAGd7Fh+ocGHPPphcD9LQTOJgG7Y7aYztHqBLJiQQ4eAgZNU4ac6+8LnEGAL
# go1ydC5BJEuJQjYKbNTy959HrKSu7LO3Ws0w8jw6pYdC1IMpdTkk2puTgY2PDNzB
# tLM4evG7FYer3WX+8t1UMYNTAgMBAAGjggFzMIIBbzAfBgNVHSUEGDAWBgorBgEE
# AYI3TAgBBggrBgEFBQcDAzAdBgNVHQ4EFgQURxxxNPIEPGSO8kqz+bgCAQWGXsEw
# RQYDVR0RBD4wPKQ6MDgxHjAcBgNVBAsTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjEW
# MBQGA1UEBRMNMjMwMDEyKzUwMTgyNjAfBgNVHSMEGDAWgBRIbmTlUAXTgqoXNzci
# tW2oynUClTBUBgNVHR8ETTBLMEmgR6BFhkNodHRwOi8vd3d3Lm1pY3Jvc29mdC5j
# b20vcGtpb3BzL2NybC9NaWNDb2RTaWdQQ0EyMDExXzIwMTEtMDctMDguY3JsMGEG
# CCsGAQUFBwEBBFUwUzBRBggrBgEFBQcwAoZFaHR0cDovL3d3dy5taWNyb3NvZnQu
# Y29tL3BraW9wcy9jZXJ0cy9NaWNDb2RTaWdQQ0EyMDExXzIwMTEtMDctMDguY3J0
# MAwGA1UdEwEB/wQCMAAwDQYJKoZIhvcNAQELBQADggIBAISxFt/zR2frTFPB45Yd
# mhZpB2nNJoOoi+qlgcTlnO4QwlYN1w/vYwbDy/oFJolD5r6FMJd0RGcgEM8q9TgQ
# 2OC7gQEmhweVJ7yuKJlQBH7P7Pg5RiqgV3cSonJ+OM4kFHbP3gPLiyzssSQdRuPY
# 1mIWoGg9i7Y4ZC8ST7WhpSyc0pns2XsUe1XsIjaUcGu7zd7gg97eCUiLRdVklPmp
# XobH9CEAWakRUGNICYN2AgjhRTC4j3KJfqMkU04R6Toyh4/Toswm1uoDcGr5laYn
# TfcX3u5WnJqJLhuPe8Uj9kGAOcyo0O1mNwDa+LhFEzB6CB32+wfJMumfr6degvLT
# e8x55urQLeTjimBQgS49BSUkhFN7ois3cZyNpnrMca5AZaC7pLI72vuqSsSlLalG
# OcZmPHZGYJqZ0BacN274OZ80Q8B11iNokns9Od348bMb5Z4fihxaBWebl8kWEi2O
# PvQImOAeq3nt7UWJBzJYLAGEpfasaA3ZQgIcEXdD+uwo6ymMzDY6UamFOfYqYWXk
# ntxDGu7ngD2ugKUuccYKJJRiiz+LAUcj90BVcSHRLQop9N8zoALr/1sJuwPrVAtx
# HNEgSW+AKBqIxYWM4Ev32l6agSUAezLMbq5f3d8x9qzT031jMDT+sUAoCw0M5wVt
# CUQcqINPuYjbS1WgJyZIiEkBMIIHejCCBWKgAwIBAgIKYQ6Q0gAAAAAAAzANBgkq
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
# Z25pbmcgUENBIDIwMTECEzMAAAOvMEAOTKNNBUEAAAAAA68wDQYJYIZIAWUDBAIB
# BQCgga4wGQYJKoZIhvcNAQkDMQwGCisGAQQBgjcCAQQwHAYKKwYBBAGCNwIBCzEO
# MAwGCisGAQQBgjcCARUwLwYJKoZIhvcNAQkEMSIEIDRfefQH1MXd0NTrFlo9hfpG
# 653dv2lfhnI6K1ubinDKMEIGCisGAQQBgjcCAQwxNDAyoBSAEgBNAGkAYwByAG8A
# cwBvAGYAdKEagBhodHRwOi8vd3d3Lm1pY3Jvc29mdC5jb20wDQYJKoZIhvcNAQEB
# BQAEggEAavF/uR8tvW73fypOIoq3eg+7tzJldxwd4jQdYRCdBWoaeDt656NtY8AX
# l5Lr1LXcrCJGp1VzR38tBq2eB0aWmDIRsnFgrnGRKCEyF4h0NP8nlSUzqOq3QZ0Y
# 0zefFdUtSqBADDHNbnfzEnZv/mcZ0dIOe+D4XZ5rCicSrNpneDkTywcVTkE5+0To
# AQ72NvmdU6KosrfJIApxvGJco3F/sEV7uasWGv/6IvuaPr5XjI7Xylb31zgR/rid
# 2jHsGz+Gwrd5PqBvi6vtqA4strTCramdNC07HL3HGnb+9DsUG5EoGZFCCEhkGrd/
# fn63jafHxbzC24ZEkTA86l+nRzCJfKGCF5QwgheQBgorBgEEAYI3AwMBMYIXgDCC
# F3wGCSqGSIb3DQEHAqCCF20wghdpAgEDMQ8wDQYJYIZIAWUDBAIBBQAwggFSBgsq
# hkiG9w0BCRABBKCCAUEEggE9MIIBOQIBAQYKKwYBBAGEWQoDATAxMA0GCWCGSAFl
# AwQCAQUABCBmgJH0whjdsBUacBi+Wa7+sMOUmlNR9Y+LP6BWJIiNdAIGZhfJkTlM
# GBMyMDI0MDQxNjEyNTA1OS4yMTNaMASAAgH0oIHRpIHOMIHLMQswCQYDVQQGEwJV
# UzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMHUmVkbW9uZDEeMBwGA1UE
# ChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMSUwIwYDVQQLExxNaWNyb3NvZnQgQW1l
# cmljYSBPcGVyYXRpb25zMScwJQYDVQQLEx5uU2hpZWxkIFRTUyBFU046QTQwMC0w
# NUUwLUQ5NDcxJTAjBgNVBAMTHE1pY3Jvc29mdCBUaW1lLVN0YW1wIFNlcnZpY2Wg
# ghHqMIIHIDCCBQigAwIBAgITMwAAAezgK6SC0JFSgAABAAAB7DANBgkqhkiG9w0B
# AQsFADB8MQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UE
# BxMHUmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMSYwJAYD
# VQQDEx1NaWNyb3NvZnQgVGltZS1TdGFtcCBQQ0EgMjAxMDAeFw0yMzEyMDYxODQ1
# MzhaFw0yNTAzMDUxODQ1MzhaMIHLMQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2Fz
# aGluZ3RvbjEQMA4GA1UEBxMHUmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENv
# cnBvcmF0aW9uMSUwIwYDVQQLExxNaWNyb3NvZnQgQW1lcmljYSBPcGVyYXRpb25z
# MScwJQYDVQQLEx5uU2hpZWxkIFRTUyBFU046QTQwMC0wNUUwLUQ5NDcxJTAjBgNV
# BAMTHE1pY3Jvc29mdCBUaW1lLVN0YW1wIFNlcnZpY2UwggIiMA0GCSqGSIb3DQEB
# AQUAA4ICDwAwggIKAoICAQCwR/RuCTbgxUWVm/Vdul22uwdEZm0IoAFs6oIr39VK
# /ItP80cn+8TmtP67iabB4DmAKJ9GH6dJGhEPJpY4vTKRSOwrRNxVIKoPPeUF3f4V
# yHEco/u1QUadlwD132NuZCxbnh6Mi2lLG7pDvszZqMG7S3MCi2bk2nvtGKdeAIL+
# H77gL4r01TSWb7rsE2Jb1P/N6Y/W1CqDi1/Ib3/zRqWXt4zxvdIGcPjS4ZKyQEF3
# SEZAq4XIjiyowPHaqNbZxdf2kWO/ajdfTU85t934CXAinb0o+uQ9KtaKNLVVcNf5
# QpS4f6/MsXOvIFuCYMRdKDjpmvowAeL+1j27bCxCBpDQHrWkfPzZp/X+bt9C7E5h
# PP6HVRoqBYR7u1gUf5GEq+5r1HA0jajn0Q6OvfYckE0HdOv6KWa+sAmJG7PDvTZa
# e77homzx6IPqggVpNZuCk79SfVmnKu9F58UAnU58TqDHEzGsQnMUQKstS3zjn6SU
# 0NLEFNCetluaKkqWDRVLEWbu329IEh3tqXPXfy6Rh/wCbwe9SCJIoqtBexBrPyQY
# A2Xaz1fK9ysTsx0kA9V1JwVV44Ia9c+MwtAR6sqKdAgRo/bs/Xu8gua8LDe6KWyu
# 974e9mGW7ZO8narDFrAT1EXGHDueygSKvv2K7wB8lAgMGJj73CQvr+jqoWwx6Xdy
# eQIDAQABo4IBSTCCAUUwHQYDVR0OBBYEFPRa0Edk/iv1whYQsV8UgEf4TIWGMB8G
# A1UdIwQYMBaAFJ+nFV0AXmJdg/Tl0mWnG1M1GelyMF8GA1UdHwRYMFYwVKBSoFCG
# Tmh0dHA6Ly93d3cubWljcm9zb2Z0LmNvbS9wa2lvcHMvY3JsL01pY3Jvc29mdCUy
# MFRpbWUtU3RhbXAlMjBQQ0ElMjAyMDEwKDEpLmNybDBsBggrBgEFBQcBAQRgMF4w
# XAYIKwYBBQUHMAKGUGh0dHA6Ly93d3cubWljcm9zb2Z0LmNvbS9wa2lvcHMvY2Vy
# dHMvTWljcm9zb2Z0JTIwVGltZS1TdGFtcCUyMFBDQSUyMDIwMTAoMSkuY3J0MAwG
# A1UdEwEB/wQCMAAwFgYDVR0lAQH/BAwwCgYIKwYBBQUHAwgwDgYDVR0PAQH/BAQD
# AgeAMA0GCSqGSIb3DQEBCwUAA4ICAQCSvMSkMSrvjlDPag8ARb0OFrAQtSLMDpN0
# UY3FjvPhwGKDrrixmnuMfjrmVjRq1u8IhkDvGF/bffbFTr+IAnDSeg8TB9zfG/4y
# bknuopklbeGjbt7MLxpfholCERyEc20PMZKJz9SvzfuO1n5xrrLOL8m0nmv5kBcv
# +y1AXJ5QcLicmhe2Ip3/D67Ed6oPqQI03mDjYaS1NQhBNtu57wPKXZ1EoNToBk8b
# A6839w119b+a9WToqIskdRGoP5xjDIv+mc0vBHhZGkJVvfIhm4Ap8zptC7xVAly0
# jeOv5dUGMCYgZjvoTmgd45bqAwundmPlGur7eleWYedLQf7s3L5+qfaY/xEh/9uo
# 17SnM/gHVSGAzvnreGhOrB2LtdKoVSe5LbYpihXctDe76iYtL+mhxXPEpzda3bJl
# hPTOQ3KOEZApVERBo5yltWjPCWlXxyCpl5jj9nY0nfd071bemnou8A3rUZrdgKIa
# utsH7SHOiOebZGqNu+622vJta3eAYsCAaxAcB9BiJPla7Xad9qrTYdT45VlCYTtB
# SY4oVRsedSADv99jv/iYIAGy1bCytua0o/Qqv9erKmzQCTVMXaDc25DTLcMGJrRu
# a3K0xivdtnoBexzVJr6yXqM+Ba2whIVRvGcriBkKX0FJFeW7r29XX+k0e4DnG6iB
# HKQjec6VNzCCB3EwggVZoAMCAQICEzMAAAAVxedrngKbSZkAAAAAABUwDQYJKoZI
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
# MCUGA1UECxMeblNoaWVsZCBUU1MgRVNOOkE0MDAtMDVFMC1EOTQ3MSUwIwYDVQQD
# ExxNaWNyb3NvZnQgVGltZS1TdGFtcCBTZXJ2aWNloiMKAQEwBwYFKw4DAhoDFQCO
# HPtgVdz9EW0iPNL/BXqJoqVMf6CBgzCBgKR+MHwxCzAJBgNVBAYTAlVTMRMwEQYD
# VQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVNaWNy
# b3NvZnQgQ29ycG9yYXRpb24xJjAkBgNVBAMTHU1pY3Jvc29mdCBUaW1lLVN0YW1w
# IFBDQSAyMDEwMA0GCSqGSIb3DQEBCwUAAgUA6cjfWDAiGA8yMDI0MDQxNjExMjgy
# NFoYDzIwMjQwNDE3MTEyODI0WjB0MDoGCisGAQQBhFkKBAExLDAqMAoCBQDpyN9Y
# AgEAMAcCAQACAhFMMAcCAQACAhNEMAoCBQDpyjDYAgEAMDYGCisGAQQBhFkKBAIx
# KDAmMAwGCisGAQQBhFkKAwKgCjAIAgEAAgMHoSChCjAIAgEAAgMBhqAwDQYJKoZI
# hvcNAQELBQADggEBABafyPIrma/NaAKkMCi3VB13dO7Gu2Rnqh0j/7PLf2P0EWBW
# f04eB/cuhKGToSm7vSBiJcwxC8FOJJKnJ58JXrY2yeWS4XGnee3Lv6zwD0Mg+ti9
# T2SN2P/Gggn6eMO4ks77lZNUnwTw/YQgcK8Fz4iYIik5aKOXiXCM+uevPKOeJz5h
# G+DCyGt9v8rXAK93n8PXuAlLHZxSYVn7wFyT5bATnR/2fdGLBNzJy/odNkWpnbNI
# 0+P8Xrz3GXNXHc4zsY2xeZIwQBJxILHEjwUvPK6jsCnYIhLQWK1hDc3h1R+39upk
# MEooFGixAJ1u2TA6dNSoSkDIjo2Pmyb5e1femOYxggQNMIIECQIBATCBkzB8MQsw
# CQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMHUmVkbW9u
# ZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMSYwJAYDVQQDEx1NaWNy
# b3NvZnQgVGltZS1TdGFtcCBQQ0EgMjAxMAITMwAAAezgK6SC0JFSgAABAAAB7DAN
# BglghkgBZQMEAgEFAKCCAUowGgYJKoZIhvcNAQkDMQ0GCyqGSIb3DQEJEAEEMC8G
# CSqGSIb3DQEJBDEiBCCbT5/UnNkK9S2iexfgW4IFQ8j528xE9l5DFURmn0UyZzCB
# +gYLKoZIhvcNAQkQAi8xgeowgecwgeQwgb0EICcJ5vVqfTfIhx21QBBbKyo/xciQ
# IXaoMWULejAE1QqDMIGYMIGApH4wfDELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldh
# c2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBD
# b3Jwb3JhdGlvbjEmMCQGA1UEAxMdTWljcm9zb2Z0IFRpbWUtU3RhbXAgUENBIDIw
# MTACEzMAAAHs4CukgtCRUoAAAQAAAewwIgQghgUx/LzqMnuzg2u0l4RxOfYSuEex
# NOu54mV9o6bdOzwwDQYJKoZIhvcNAQELBQAEggIAmg8KiV+7us92NHUS3ibOpAIb
# CYLZX6Oy7KGJjFmwqhMjIpQEeupoiTyGN78gmQF1CQ+5ltoa6qtlquerD8Chr5qW
# ea5gnq3KD0P1cwd2vyjJD42inQzQDVpJkTP6XSspiDjUjxvsF5rtRA9REmJ0UBA/
# zjZUMhPrFEE7kbod4GrtR8HJ+bKp5yGdlCr5OlOYY5/bCnF7Ley4rCa1nszPCBUt
# 0XLrB50+eI0IXsE5FmYp7n090wQhxzD2yEqjZB2LefS0yFhFe9j4nZMVM9a9Rq7h
# 0XnGVIm/TO5CJ8dCuXxD/0BaWW0aCvLIDDtMT8EjI5K6gvgxYLx934jhrP4MmZjl
# XcTOLcFn792eTF3lUP3If+BlYzd5rn9bNIZryhSa8wF3UOQZj94FUxpmwrYLh1rd
# gmiZBw910z3dmcw6cN/DwV5RozB4qhIlfoolV6ZRVAQZvM6CO7yfZZ5fhC/1/fiL
# xEhfrsGvlZyK2+tIcpsrAEVMbrGoLHvvug/vC1dKqEyyqqBYTsHRzZmRCjxsq+HZ
# w/Tt5NZvWksL8kvSsM2ZXSzA5uZqnC4GBslSxfvedRaevgoScQi+aa5s7XNPs/L/
# eO5BVp4TN4juckbXjYgIp95GxwHzy+P3vmU4J+mx23z0LasyYQ4wVtqIZ5gEwxyC
# gTR+Qn2xgm6M9tdr2bk=
# SIG # End signature block
