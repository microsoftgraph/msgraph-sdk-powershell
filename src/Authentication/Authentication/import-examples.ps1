[CmdletBinding()]
Param(
  [string] $DocsLocation = (Join-Path $PSScriptRoot "../docs/"),
  [string] $ExamplesLocation = (Join-Path $PSScriptRoot "../examples/")
)
function Start-Import {
    foreach ($File in Get-ChildItem $DocsLocation) {
        $ExampleFile = (Join-Path $ExamplesLocation $File.Name)
        if (Test-Path $ExampleFile) {
           $FileEmpty = Test-FileEmpty -File $ExampleFile
           if(-not($FileEmpty)) {
              Write-Host $ExampleFile
              $Content = Get-Content -Path $ExampleFile
              Import-Examples -Content $Content -File $File
           }
        }
    }
}


function Import-Examples {
    Param (
        [object]$Content,
        [string]$File
    ) 
    $SearchBlock = "## EXAMPLES(?s).*## PARAMETERS"
    $SearchBlock2 = "## DESCRIPTION(?s).*## PARAMETERS"
    $option = [System.Text.RegularExpressions.RegexOptions]::Multiline
    $Re = [regex]::new($SearchBlock, $option)
    $Re2 = [regex]::new($SearchBlock2, $option)
    $RetainedExamples = New-Object Collections.Generic.List[string] 
    $End = 0
    $NoOfExamples = 0
    foreach ($C in $Content) {
        if ($C.StartsWith("### Example")) {
            $NoOfExamples++
        }
        $End++  
    }
    Get-ExistingDescriptions -Content $Content -File $File  -start 0 -end $End -NoOfExamples $NoOfExamples
    if(Test-Path $File){
    $TitleCount = 1
    $DestinationContent = Get-Content -Encoding UTF8 -Raw $File
    $RetainedContent = $null
    foreach ($Ex in $RetainedExamples) {
            $ContentBody = $Ex.Split("**##@**")[0]
            $ContentDescription = $Ex.Split("**##@**")[2]
            $RetainedContent += "$ContentBody$ContentDescription"  
            $TitleCount++ 
                        
    }

   
    if(-not($Null -eq $RetainedContent) -and -not($RetainedContent.Contains("Add title here"))){
     if($DestinationContent -match $Re){
        $Extracted = $Matches[0]
        $FinalOutput = "## EXAMPLES`r`n$RetainedContent`r`n## PARAMETERS"
        $text = $DestinationContent.ToString()
        if(-not($Extracted.Contains("``````powershell"))){
            $text = $text.Replace($Extracted, "## PARAMETERS") 
            Write-Host "Does not have snippet"
        }else{
            $text = $text.Replace($Extracted, $FinalOutput)
        }
          $text | Out-File $File -Encoding UTF8
     }
     if($DestinationContent -match $Re2){
        $Extracted2 = $Matches[0]
        $DescriptionCommand = [System.IO.Path]::GetFileNameWithoutExtension($File)
        $Description1 = "This example shows how to use the $DescriptionCommand Cmdlet."
        $Description2 = "To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference)."
      
        $text2 = $DestinationContent.ToString()
        if(-not($Extracted2.Contains("## EXAMPLES"))){
            Write-Host "Does not have snippet $DescriptionCommand"
            $text2 = $text2.Replace($Description1, $null)
            $text2 = $text2.Replace($Description2, $null)
            $text2 | Out-File $File -Encoding UTF8

        }
     }
     $Stream = [IO.File]::OpenWrite($File)
     try
     {
         $Stream.SetLength($stream.Length - 2)
         $Stream.Close()
     }
     catch
     {
         
     }
     $Stream.Dispose()
     $RetainedExamples.Clear()
    }
    
}
    
}

function Get-ExistingDescriptions {

    Param (
        [object]$Content,
        [string]$File,
        [string]$CommandPattern,
        [int]$Start,
        [int]$End,
        [int]$NoOfExamples
    )
    $Title = $null
    $ContentBlock = $null
 
    for ($i = $Start; $i -lt $End; $i++) {
        $Value = $Content[$i]
        $ContentBlock += "$Value`n" 
        if ($Content[$i].StartsWith("### Example")) {
            $Title = $Content[$i]
        }   
        if ($Content[$i].EndsWith("``")) {
            $Start = $i
            break;
        }
    }
    $RetainedDescription = $null
    for ($j = $Start + 1; $j -lt $end; $j++) {
       
        if ($Content[$j].StartsWith("### Example")) {
            break;
        }
        $DescVal = $Content[$j]
        $RetainedDescription += "$DescVal`n"
    }
    $RetainedExamples.Add("$ContentBlock**##@**$Title**##@**$RetainedDescription")
    if ($NoOfExamples -gt 1) {
        $NoOfExamples--
        for ($k = $Start; $k -lt $End; $k++) {
            if ($Content[$k].StartsWith("### Example")) {
                $Start = $k
                break;
            }
        }
      
        Get-ExistingDescriptions -Content $Content -File $File -start $Start -end $End -NoOfExamples $NoOfExamples
    }
   
}

Function Test-FileEmpty {

    Param ([Parameter(Mandatory = $true)][string]$File)
  
    if ((Test-Path -LiteralPath $File) -and !((Get-Content -LiteralPath $file -Raw) -match '\S')) {return $true} else {return $false}
  
  }
Start-Import
# SIG # Begin signature block
# MIIoLAYJKoZIhvcNAQcCoIIoHTCCKBkCAQExDzANBglghkgBZQMEAgEFADB5Bgor
# BgEEAYI3AgEEoGswaTA0BgorBgEEAYI3AgEeMCYCAwEAAAQQH8w7YFlLCE63JNLG
# KX7zUQIBAAIBAAIBAAIBAAIBADAxMA0GCWCGSAFlAwQCAQUABCAz9Jnkqy4aEzym
# l5WpNrPY5IdvYruTSJuJnfcx6eHpDqCCDXYwggX0MIID3KADAgECAhMzAAADrzBA
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
# /Xmfwb1tbWrJUnMTDXpQzTGCGgwwghoIAgEBMIGVMH4xCzAJBgNVBAYTAlVTMRMw
# EQYDVQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVN
# aWNyb3NvZnQgQ29ycG9yYXRpb24xKDAmBgNVBAMTH01pY3Jvc29mdCBDb2RlIFNp
# Z25pbmcgUENBIDIwMTECEzMAAAOvMEAOTKNNBUEAAAAAA68wDQYJYIZIAWUDBAIB
# BQCgga4wGQYJKoZIhvcNAQkDMQwGCisGAQQBgjcCAQQwHAYKKwYBBAGCNwIBCzEO
# MAwGCisGAQQBgjcCARUwLwYJKoZIhvcNAQkEMSIEIBc+SHAcMqkUGbpZWvieD3oQ
# AZBBhpOFQst74Pw83r95MEIGCisGAQQBgjcCAQwxNDAyoBSAEgBNAGkAYwByAG8A
# cwBvAGYAdKEagBhodHRwOi8vd3d3Lm1pY3Jvc29mdC5jb20wDQYJKoZIhvcNAQEB
# BQAEggEApSRC28sGxUjeeI4kPe2RHX6AJei/I6BKyojZGi9ON3tLBCYuW1TFBW5/
# Nc8UM4ff8c9N57+0PNa9StG/r/C8UtTR2aFnOnNkj91UO/CSKoho90nqZ9fsNZDX
# 2qYUyhLbyh3suVogVBN1pMJpqiI19z4KUrvl6JPH0ODGBM8HZbPsoOSacKxNQR0h
# BcPyLli+dNuMfv+oY7YcV9TubsxLRCvPnSGH73JyTMYi0EHfH23Hhn0EhOEqDnal
# 0qTgL7uVLO/sqv+okOX/EwVAMjrK7yxIGnQtLmkSOy4q2aMstfJXp8AIv/tN0efH
# vQAnMwo1nQP8gpoSAR1Yqgmcc+n6raGCF5YwgheSBgorBgEEAYI3AwMBMYIXgjCC
# F34GCSqGSIb3DQEHAqCCF28wghdrAgEDMQ8wDQYJYIZIAWUDBAIBBQAwggFSBgsq
# hkiG9w0BCRABBKCCAUEEggE9MIIBOQIBAQYKKwYBBAGEWQoDATAxMA0GCWCGSAFl
# AwQCAQUABCCo+UbhblaPkYpSp/RwpsmO8TtgN/HL9ZXgrUig6JrB5gIGZbpqknyT
# GBMyMDI0MDEzMTE5NTYwMC4wOTVaMASAAgH0oIHRpIHOMIHLMQswCQYDVQQGEwJV
# UzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMHUmVkbW9uZDEeMBwGA1UE
# ChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMSUwIwYDVQQLExxNaWNyb3NvZnQgQW1l
# cmljYSBPcGVyYXRpb25zMScwJQYDVQQLEx5uU2hpZWxkIFRTUyBFU046ODkwMC0w
# NUUwLUQ5NDcxJTAjBgNVBAMTHE1pY3Jvc29mdCBUaW1lLVN0YW1wIFNlcnZpY2Wg
# ghHsMIIHIDCCBQigAwIBAgITMwAAAdMdMpoXO0AwcwABAAAB0zANBgkqhkiG9w0B
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
# 6Xu/OHBE0ZDxyKs6ijoIYn/ZcGNTTY3ugm2lBRDBcQZqELQdVTNYs6FwZvKhggNP
# MIICNwIBATCB+aGB0aSBzjCByzELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldhc2hp
# bmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jw
# b3JhdGlvbjElMCMGA1UECxMcTWljcm9zb2Z0IEFtZXJpY2EgT3BlcmF0aW9uczEn
# MCUGA1UECxMeblNoaWVsZCBUU1MgRVNOOjg5MDAtMDVFMC1EOTQ3MSUwIwYDVQQD
# ExxNaWNyb3NvZnQgVGltZS1TdGFtcCBTZXJ2aWNloiMKAQEwBwYFKw4DAhoDFQBS
# x23cMcNB1IQws/LYkRXa7I5JsKCBgzCBgKR+MHwxCzAJBgNVBAYTAlVTMRMwEQYD
# VQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVNaWNy
# b3NvZnQgQ29ycG9yYXRpb24xJjAkBgNVBAMTHU1pY3Jvc29mdCBUaW1lLVN0YW1w
# IFBDQSAyMDEwMA0GCSqGSIb3DQEBCwUAAgUA6WTpFDAiGA8yMDI0MDEzMTE1NDMx
# NloYDzIwMjQwMjAxMTU0MzE2WjB2MDwGCisGAQQBhFkKBAExLjAsMAoCBQDpZOkU
# AgEAMAkCAQACAVgCAf8wBwIBAAICEtYwCgIFAOlmOpQCAQAwNgYKKwYBBAGEWQoE
# AjEoMCYwDAYKKwYBBAGEWQoDAqAKMAgCAQACAwehIKEKMAgCAQACAwGGoDANBgkq
# hkiG9w0BAQsFAAOCAQEAHT5YM+LdMAsO5Vuuk7TOA1vIn0B9UUO80S26N1WHMh7Y
# xb43+/oaIXMerU6I5kZfPMlxIXqNA0pILLxKLNR5DCprkvkutNJASly2RbM9HXyW
# 703PONZDgaTcDhdONdnSvitiD4T06f/K3zK50aK+rmFPYZj5wctrQ/AuAPnQ/zVT
# qJEkT+9+bFkWDPQcZz0f514wDv0n4KJjIA5fE/Qghp0yP/1oElPxqPvpmMBXEPZ4
# vF47GwhnDM8W2QRXEbFZfkT1p6N4OuGz+fSjCrSJvpnHNcx3lPxO/VaURdgMrba8
# XCu+EbJ7g2/YW3DbLVjmw1rkDO6/K9KnTWNp+yLGTzGCBA0wggQJAgEBMIGTMHwx
# CzAJBgNVBAYTAlVTMRMwEQYDVQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRt
# b25kMR4wHAYDVQQKExVNaWNyb3NvZnQgQ29ycG9yYXRpb24xJjAkBgNVBAMTHU1p
# Y3Jvc29mdCBUaW1lLVN0YW1wIFBDQSAyMDEwAhMzAAAB0x0ymhc7QDBzAAEAAAHT
# MA0GCWCGSAFlAwQCAQUAoIIBSjAaBgkqhkiG9w0BCQMxDQYLKoZIhvcNAQkQAQQw
# LwYJKoZIhvcNAQkEMSIEIMGfCgTmJf2GYJcH7Zbe1qRzL/0owuweixnbggcVAUFT
# MIH6BgsqhkiG9w0BCRACLzGB6jCB5zCB5DCBvQQgkmb06sTg7k9YDUpoVrO2v24/
# 3qtCASf62Aa1jfE6qvUwgZgwgYCkfjB8MQswCQYDVQQGEwJVUzETMBEGA1UECBMK
# V2FzaGluZ3RvbjEQMA4GA1UEBxMHUmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0
# IENvcnBvcmF0aW9uMSYwJAYDVQQDEx1NaWNyb3NvZnQgVGltZS1TdGFtcCBQQ0Eg
# MjAxMAITMwAAAdMdMpoXO0AwcwABAAAB0zAiBCCroFdMHUfFpASH31fOTxgxpQow
# 06XxQ2jKb4QXiEZMMDANBgkqhkiG9w0BAQsFAASCAgCYT7M5/XTp4Ue7lTuLsNGS
# /xfh4dMUTRoxJW9A8+4ivg7ZoYRTVMg4Kl9W99p5WzmTME4lfoJs1p5enJRhjGPK
# b0P+RJMIXXGLQTJniB5hsiDrrVWV5mHwO1OifwSM8YsNjUxxotxeYGlOaT93F4ZD
# uwoQBaKct44go73wwFcU5XbyRUx0MxAKv4+znf98f7w7EYg7gz2SIExZScDxYIVp
# m3FHRQIdGiVn20vX1yqIkf++FEW46yvZDmPGJe1jh8jdEYFPaSSsz9hobox1z5cB
# lPFW48+odU0lArPYJCNzjMve5qiUTG1DNFaSbLQReIvcBzEf2JrrTqierI17C0WB
# /zBg4t8amP0zujXUgZTN/4w4qBZLRrtuhLNX3gmsfvFqvaV9DDrv8mbhWCFpEkfq
# F5KpO5SyLl67BV9UqvMKm3iGYJu7efTYibuY14GI/GwPmxOUMvSOUhmXc0cEBo7a
# 6e65QcAj9VI6PQKPBeit4OIbMB2VQYD2qPCaAzpJSkqsZ/vgHgA8w9zKbhW2YSNP
# FNEOmEhhWY4z/tL31RivR5D483M3QbosJrZ3ja4pdkYnm6pX2BHNOOrONzecDPIf
# kW9GsNeIkxXxu96/KQKFuL1iZhKjJ17ziKhVWhuFWR0TVlHW5DVGrcvezvJmTIOU
# jEvPwHVo4Ro4XMAQy/iFMw==
# SIG # End signature block
