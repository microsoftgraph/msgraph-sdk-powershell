param(
  [switch]$Isolated,
  [switch]$Pack,
  [switch]$Release
)

$ErrorActionPreference = 'Stop'
$ModuleName = "Authentication"
$ModulePrefix = "Microsoft.Graph"
$netStandard = "netstandard2.0"
$netApp = "net6.0"
$netFx = "net472"
$copyExtensions = @('.dll', '.pdb')

# Source code locations
$coreSrc = Join-Path $PSScriptRoot "../$ModuleName.Core"
$cmdletsSrc = Join-Path $PSScriptRoot "../$ModuleName"

# Generated output locations
$outDir = Join-Path $PSScriptRoot "artifacts"
$outDeps = Join-Path $outDir "Dependencies"
$outCore = Join-Path $outDeps "Core"
$outDesktop = Join-Path $outDeps "Desktop"

if ($PSEdition -ne 'Core') {
  Write-Error 'This script requires PowerShell Core to execute. [Note] Generated cmdlets will work in both PowerShell Core or Windows PowerShell.'
}

$Configuration = 'Debug'
if ($Release) {
  $Configuration = 'Release'
}

if (-not $Isolated) {
  Write-Host -ForegroundColor Green 'Creating isolated process...'
  $pwsh = [System.Diagnostics.Process]::GetCurrentProcess().Path
  & "$pwsh" -NonInteractive -NoLogo -NoProfile -File $MyInvocation.MyCommand.Path @PSBoundParameters -Isolated

  if ($LastExitCode -ne 0) {
    # Build failed. Don't attempt to run the module.
    return
  }

  if ($Pack) {
    . (Join-Path $PSScriptRoot 'pack-module.ps1')
    if ($LastExitCode -ne 0) {
      # Packing failed. Don't attempt to run the module.
      return
    }
  }
  return
}

# Clean build folders.
Write-Host -ForegroundColor Green 'Cleaning build folders...'
$null = Remove-Item -Path "$coreSrc/bin", "$coreSrc/obj" -Recurse -ErrorAction Ignore
$null = Remove-Item -Path "$cmdletsSrc/bin", "$cmdletsSrc/obj" -Recurse -ErrorAction Ignore

if ((Test-Path "$cmdletsSrc/bin") -or (Test-Path "$cmdletsSrc/obj")) {
  Write-Host -ForegroundColor Cyan 'Did you forget to exit your isolated module session before rebuilding?'
  Write-Error 'Unable to clean ''bin'' or ''obj'' folder. A process may have an open handle.'
}

Write-Host -ForegroundColor Green 'Compiling module...'
# Build authentication.core for each framework.
Push-Location $coreSrc
dotnet publish -c $Configuration -f $netStandard --verbosity quiet /nologo
dotnet publish -c $Configuration -f $netApp --verbosity quiet /nologo
dotnet publish -c $Configuration -f $netFx --verbosity quiet /nologo
Pop-Location

# Build authentication.
Push-Location $cmdletsSrc
dotnet publish -c $Configuration --verbosity quiet /nologo
Pop-Location

if ($LastExitCode -ne 0) {
  Write-Error 'Compilation failed.'
}

# Ensure out directory exists and is clean.
if (Test-Path $outDir) {
  Remove-Item -Path $outDir -Recurse -Force
}
New-Item -Path $outDir -ItemType Directory | out-null
New-Item -Path $outDeps -ItemType Directory | out-null
New-Item -Path $outCore -ItemType Directory | out-null
New-Item -Path $outDesktop -ItemType Directory | out-null

# Copy manifest.
Copy-Item -Path "$cmdletsSrc/$ModulePrefix.$ModuleName.format.ps1xml" -Destination $outDir
Copy-Item -Path "$cmdletsSrc/$ModulePrefix.$ModuleName.psm1" -Destination $outDir
Copy-Item -Path "$cmdletsSrc/$ModulePrefix.$ModuleName.psd1" -Destination $outDir
Copy-Item -Path "$cmdletsSrc/StartupScripts" -Filter *.ps1 -Recurse -Destination $outDir

# Copy custom commands.
Copy-Item -Path "$cmdletsSrc/custom" -Recurse -Destination $outDir

# Core assemblies to include with cmdlets (Let PowerShell load them).
$CoreAssemblies = @('Microsoft.Graph.Authentication.Core')

# Copy each authentication.core asset to out directory and remember it.
$Deps = [System.Collections.Generic.HashSet[string]]::new()
Get-ChildItem -Path "$coreSrc/bin/$Configuration/$netStandard/publish/" |
Where-Object { $_.Extension -in $copyExtensions } |
Where-Object { -not $CoreAssemblies.Contains($_.BaseName) } |
ForEach-Object { [void]$Deps.Add($_.Name); Copy-Item -Path $_.FullName -Destination $outDeps }

Get-ChildItem -Path "$coreSrc/bin/$Configuration/$netApp/publish/" |
Where-Object { -not $CoreAssemblies.Contains($_.BaseName) } |
ForEach-Object { [void]$Deps.Add($_.Name); Copy-Item -Path $_.FullName -Destination $outCore }

Get-ChildItem -Path "$coreSrc/bin/$Configuration/$netFx/publish/" |
Where-Object { -not $CoreAssemblies.Contains($_.BaseName) } |
ForEach-Object { [void]$Deps.Add($_.Name); Copy-Item -Path $_.FullName -Destination $outDesktop }

# Now copy each authentication asset, not taking any found in authentication.core.
Get-ChildItem -Path "$cmdletsSrc/bin/$Configuration/$netStandard/publish/" |
Where-Object { -not $Deps.Contains($_.Name) -and $_.Extension -in $copyExtensions } |
ForEach-Object { Copy-Item -Path $_.FullName -Destination $outDir }

Write-Host -ForegroundColor Green '-------------Done-------------'

# SIG # Begin signature block
# MIInzQYJKoZIhvcNAQcCoIInvjCCJ7oCAQExDzANBglghkgBZQMEAgEFADB5Bgor
# BgEEAYI3AgEEoGswaTA0BgorBgEEAYI3AgEeMCYCAwEAAAQQH8w7YFlLCE63JNLG
# KX7zUQIBAAIBAAIBAAIBAAIBADAxMA0GCWCGSAFlAwQCAQUABCBzJVoIi+CeTiH1
# oSPpykW9rBY4WW+28+tmtqA7rUy4DaCCDYUwggYDMIID66ADAgECAhMzAAADTU6R
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
# cVZOSEXAQsmbdlsKgEhr/Xmfwb1tbWrJUnMTDXpQzTGCGZ4wghmaAgEBMIGVMH4x
# CzAJBgNVBAYTAlVTMRMwEQYDVQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRt
# b25kMR4wHAYDVQQKExVNaWNyb3NvZnQgQ29ycG9yYXRpb24xKDAmBgNVBAMTH01p
# Y3Jvc29mdCBDb2RlIFNpZ25pbmcgUENBIDIwMTECEzMAAANNTpGmGiiweI8AAAAA
# A00wDQYJYIZIAWUDBAIBBQCgga4wGQYJKoZIhvcNAQkDMQwGCisGAQQBgjcCAQQw
# HAYKKwYBBAGCNwIBCzEOMAwGCisGAQQBgjcCARUwLwYJKoZIhvcNAQkEMSIEILEN
# sjbfE3f3IKZyIpGhXCbOUwaioevZv8zfVaNVdPkwMEIGCisGAQQBgjcCAQwxNDAy
# oBSAEgBNAGkAYwByAG8AcwBvAGYAdKEagBhodHRwOi8vd3d3Lm1pY3Jvc29mdC5j
# b20wDQYJKoZIhvcNAQEBBQAEggEAsCAXb2AUpPFFozHaXglmgbFV8vLCb20OPHnP
# HZZjZc3/i4y9+w97x+gid/HdEOXI+hnIIvo92bgIUsfn/GngDxY7RQaWDTB7CY3H
# aVHd1s5d6vKcXDP0ClFbbrzQaV6ft0KD5jdtvDd3E564fdgA1k9F18UQFbVnTNsK
# EtZa4XWXDMfmxt8IX6aV7PDZWaBmb8BBITCXyQm1iHUKSV/QQaQpuaIJ7AvaWJ4t
# OGQY18kR089vmvgYEDAbgizPLW07Dr7L3R1wN5B+il9zGnSytcOt5Kw9pD1IqZrR
# Tj30v1jy1WeA1mLVA6HuDiVzx95uK+5phhOTwzo5SSzSgIS2O6GCFygwghckBgor
# BgEEAYI3AwMBMYIXFDCCFxAGCSqGSIb3DQEHAqCCFwEwghb9AgEDMQ8wDQYJYIZI
# AWUDBAIBBQAwggFYBgsqhkiG9w0BCRABBKCCAUcEggFDMIIBPwIBAQYKKwYBBAGE
# WQoDATAxMA0GCWCGSAFlAwQCAQUABCAw2Af6MXeeERAjRTQbluKjX2bdzpOw68Rs
# gmmaVHfUwgIGZD/V5QBzGBIyMDIzMDUxNjEyMjQ0Ni45M1owBIACAfSggdikgdUw
# gdIxCzAJBgNVBAYTAlVTMRMwEQYDVQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdS
# ZWRtb25kMR4wHAYDVQQKExVNaWNyb3NvZnQgQ29ycG9yYXRpb24xLTArBgNVBAsT
# JE1pY3Jvc29mdCBJcmVsYW5kIE9wZXJhdGlvbnMgTGltaXRlZDEmMCQGA1UECxMd
# VGhhbGVzIFRTUyBFU046MkFENC00QjkyLUZBMDExJTAjBgNVBAMTHE1pY3Jvc29m
# dCBUaW1lLVN0YW1wIFNlcnZpY2WgghF4MIIHJzCCBQ+gAwIBAgITMwAAAbHKkEPu
# C/ADqwABAAABsTANBgkqhkiG9w0BAQsFADB8MQswCQYDVQQGEwJVUzETMBEGA1UE
# CBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMHUmVkbW9uZDEeMBwGA1UEChMVTWljcm9z
# b2Z0IENvcnBvcmF0aW9uMSYwJAYDVQQDEx1NaWNyb3NvZnQgVGltZS1TdGFtcCBQ
# Q0EgMjAxMDAeFw0yMjA5MjAyMDIxNTlaFw0yMzEyMTQyMDIxNTlaMIHSMQswCQYD
# VQQGEwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMHUmVkbW9uZDEe
# MBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMS0wKwYDVQQLEyRNaWNyb3Nv
# ZnQgSXJlbGFuZCBPcGVyYXRpb25zIExpbWl0ZWQxJjAkBgNVBAsTHVRoYWxlcyBU
# U1MgRVNOOjJBRDQtNEI5Mi1GQTAxMSUwIwYDVQQDExxNaWNyb3NvZnQgVGltZS1T
# dGFtcCBTZXJ2aWNlMIICIjANBgkqhkiG9w0BAQEFAAOCAg8AMIICCgKCAgEAhqKr
# PtXsG8fsg4w8R4MzZTAKkzwvEBQ94ntS+72rRGIMF0GCyEL9IOt7f9gkGoamfbtr
# tdY4y+KIFR8w19/nU3EoWhJfrYamrfpgtFmTaE3XCKCsI7rnrPmlVOMmndDyN1gA
# lfeu4l5rdxx9ODECBPdS/+w/jDT7JkBhrYllqVXcwGAgWLdXAoUDgKVByv5XhKkb
# OrPx9qppuZjKm4nflmfwb/bTWkA3aMMQ67tBoMLSsbIN3BJNWZdwczjoQVXo3YXr
# 2fB+PYNmHviCcDUMHs0Vxmf7i/WSpBafsDMEn6WY7G8qtRGVX+7X0zDVg/7NVDLM
# qfn/iv++5hJGP+2Fmv4WZkBS1MBpwvOi4EQ25pIG45jWTffR4ynyed1I1SxSOP+e
# fuBx0WrN1A250lv5fGZHCL0vCMDT/w+U6wpNnxfDoQRY9Ut82iNK5alkxNozPP/D
# NI+nknTaSliaR2XnSXDIZEs7lfuJYg0qahfJJ1CZF2IYxOS9FK1crEigSb8QnEJo
# j6ThLf4FYpYLTsRXlPdQbvBsVvgt++BttooznwfK0DKMOc718SLS+unwkVO0aF23
# CEQSStoy0ZW34K+cbRmUfia+k9E+4luoTnT17oKqYfDNO5Rk8UwVa8mfh8+/R3fZ
# az2O/ZhiYT/RZHV9Quz5PHGlaCfXPQ8A6zFJlE8CAwEAAaOCAUkwggFFMB0GA1Ud
# DgQWBBT0m2eR7w2thIr18WehUTSmvQ45kzAfBgNVHSMEGDAWgBSfpxVdAF5iXYP0
# 5dJlpxtTNRnpcjBfBgNVHR8EWDBWMFSgUqBQhk5odHRwOi8vd3d3Lm1pY3Jvc29m
# dC5jb20vcGtpb3BzL2NybC9NaWNyb3NvZnQlMjBUaW1lLVN0YW1wJTIwUENBJTIw
# MjAxMCgxKS5jcmwwbAYIKwYBBQUHAQEEYDBeMFwGCCsGAQUFBzAChlBodHRwOi8v
# d3d3Lm1pY3Jvc29mdC5jb20vcGtpb3BzL2NlcnRzL01pY3Jvc29mdCUyMFRpbWUt
# U3RhbXAlMjBQQ0ElMjAyMDEwKDEpLmNydDAMBgNVHRMBAf8EAjAAMBYGA1UdJQEB
# /wQMMAoGCCsGAQUFBwMIMA4GA1UdDwEB/wQEAwIHgDANBgkqhkiG9w0BAQsFAAOC
# AgEA2Oc3kmql5VKEitAhoBCc1U6/VwMSYKQPqhC59f00Y5fbwnD+B2Qa0wnJqADS
# VVu6bBCVrks+EGbkuMhRb/lpiHNKVnuXF4PKTDnvCnYCqgwAmbttdxe0m38fJpGU
# 3fmECEFX4OYacEhFwTkLZtIUVjdqwPnQpRII+YqX/Q0Vp096g2puPllSdrxUB8xI
# Ox3F7LGOzyv/1WmrLyWAhUGpGte0W3qfX4YWkn7YCM+yl887tj5j+jO/l1MRi6bl
# 4MsN0PW2FCYeRbyzQEENsg5Pd351Z08ROR/nR8z+cAuQwR29ijaDKIms5IbRr1nZ
# L/qZskFSuCuSA+nYeMuTJxHg2HCXrt6ECFbEkYoPaBGTzxPYopcuJEcChhNlWkdu
# CRguykEsmz0LvtmS7Fe68g4Zoh3sQkIE5VEwnKC3HwVemhK7eNYR1q7RYExfGFUD
# MQdO7tQpbcPD4oaBbtFGWGu3nz1IryWs9K88zo8+eoQV/o9SxNU7Rs6TMqcLdM6C
# 6LgmGVaWKKC0S2DVKU8zFx0y5z25h1ZJ7X/Zhaav1mtXVG6+lJIq8ktJgOU5/pom
# umdftgosxGjIp3NORy9fDUll+KQl4YmN9GzZxPYkhuI0QYriLmytBtUK+AK91hUR
# VldVbUjP8sksr1dsiQwyOYQIkSxrTuhp0pw7h5329jphgEYwggdxMIIFWaADAgEC
# AhMzAAAAFcXna54Cm0mZAAAAAAAVMA0GCSqGSIb3DQEBCwUAMIGIMQswCQYDVQQG
# EwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMHUmVkbW9uZDEeMBwG
# A1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMTIwMAYDVQQDEylNaWNyb3NvZnQg
# Um9vdCBDZXJ0aWZpY2F0ZSBBdXRob3JpdHkgMjAxMDAeFw0yMTA5MzAxODIyMjVa
# Fw0zMDA5MzAxODMyMjVaMHwxCzAJBgNVBAYTAlVTMRMwEQYDVQQIEwpXYXNoaW5n
# dG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVNaWNyb3NvZnQgQ29ycG9y
# YXRpb24xJjAkBgNVBAMTHU1pY3Jvc29mdCBUaW1lLVN0YW1wIFBDQSAyMDEwMIIC
# IjANBgkqhkiG9w0BAQEFAAOCAg8AMIICCgKCAgEA5OGmTOe0ciELeaLL1yR5vQ7V
# gtP97pwHB9KpbE51yMo1V/YBf2xK4OK9uT4XYDP/XE/HZveVU3Fa4n5KWv64NmeF
# RiMMtY0Tz3cywBAY6GB9alKDRLemjkZrBxTzxXb1hlDcwUTIcVxRMTegCjhuje3X
# D9gmU3w5YQJ6xKr9cmmvHaus9ja+NSZk2pg7uhp7M62AW36MEBydUv626GIl3GoP
# z130/o5Tz9bshVZN7928jaTjkY+yOSxRnOlwaQ3KNi1wjjHINSi947SHJMPgyY9+
# tVSP3PoFVZhtaDuaRr3tpK56KTesy+uDRedGbsoy1cCGMFxPLOJiss254o2I5Jas
# AUq7vnGpF1tnYN74kpEeHT39IM9zfUGaRnXNxF803RKJ1v2lIH1+/NmeRd+2ci/b
# fV+AutuqfjbsNkz2K26oElHovwUDo9Fzpk03dJQcNIIP8BDyt0cY7afomXw/TNuv
# XsLz1dhzPUNOwTM5TI4CvEJoLhDqhFFG4tG9ahhaYQFzymeiXtcodgLiMxhy16cg
# 8ML6EgrXY28MyTZki1ugpoMhXV8wdJGUlNi5UPkLiWHzNgY1GIRH29wb0f2y1BzF
# a/ZcUlFdEtsluq9QBXpsxREdcu+N+VLEhReTwDwV2xo3xwgVGD94q0W29R6HXtqP
# nhZyacaue7e3PmriLq0CAwEAAaOCAd0wggHZMBIGCSsGAQQBgjcVAQQFAgMBAAEw
# IwYJKwYBBAGCNxUCBBYEFCqnUv5kxJq+gpE8RjUpzxD/LwTuMB0GA1UdDgQWBBSf
# pxVdAF5iXYP05dJlpxtTNRnpcjBcBgNVHSAEVTBTMFEGDCsGAQQBgjdMg30BATBB
# MD8GCCsGAQUFBwIBFjNodHRwOi8vd3d3Lm1pY3Jvc29mdC5jb20vcGtpb3BzL0Rv
# Y3MvUmVwb3NpdG9yeS5odG0wEwYDVR0lBAwwCgYIKwYBBQUHAwgwGQYJKwYBBAGC
# NxQCBAweCgBTAHUAYgBDAEEwCwYDVR0PBAQDAgGGMA8GA1UdEwEB/wQFMAMBAf8w
# HwYDVR0jBBgwFoAU1fZWy4/oolxiaNE9lJBb186aGMQwVgYDVR0fBE8wTTBLoEmg
# R4ZFaHR0cDovL2NybC5taWNyb3NvZnQuY29tL3BraS9jcmwvcHJvZHVjdHMvTWlj
# Um9vQ2VyQXV0XzIwMTAtMDYtMjMuY3JsMFoGCCsGAQUFBwEBBE4wTDBKBggrBgEF
# BQcwAoY+aHR0cDovL3d3dy5taWNyb3NvZnQuY29tL3BraS9jZXJ0cy9NaWNSb29D
# ZXJBdXRfMjAxMC0wNi0yMy5jcnQwDQYJKoZIhvcNAQELBQADggIBAJ1VffwqreEs
# H2cBMSRb4Z5yS/ypb+pcFLY+TkdkeLEGk5c9MTO1OdfCcTY/2mRsfNB1OW27DzHk
# wo/7bNGhlBgi7ulmZzpTTd2YurYeeNg2LpypglYAA7AFvonoaeC6Ce5732pvvinL
# btg/SHUB2RjebYIM9W0jVOR4U3UkV7ndn/OOPcbzaN9l9qRWqveVtihVJ9AkvUCg
# vxm2EhIRXT0n4ECWOKz3+SmJw7wXsFSFQrP8DJ6LGYnn8AtqgcKBGUIZUnWKNsId
# w2FzLixre24/LAl4FOmRsqlb30mjdAy87JGA0j3mSj5mO0+7hvoyGtmW9I/2kQH2
# zsZ0/fZMcm8Qq3UwxTSwethQ/gpY3UA8x1RtnWN0SCyxTkctwRQEcb9k+SS+c23K
# jgm9swFXSVRk2XPXfx5bRAGOWhmRaw2fpCjcZxkoJLo4S5pu+yFUa2pFEUep8beu
# yOiJXk+d0tBMdrVXVAmxaQFEfnyhYWxz/gq77EFmPWn9y8FBSX5+k77L+DvktxW/
# tM4+pTFRhLy/AsGConsXHRWJjXD+57XQKBqJC4822rpM+Zv/Cuk0+CQ1ZyvgDbjm
# jJnW4SLq8CdCPSWU5nR0W2rRnj7tfqAxM328y+l7vzhwRNGQ8cirOoo6CGJ/2XBj
# U02N7oJtpQUQwXEGahC0HVUzWLOhcGbyoYIC1DCCAj0CAQEwggEAoYHYpIHVMIHS
# MQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMHUmVk
# bW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMS0wKwYDVQQLEyRN
# aWNyb3NvZnQgSXJlbGFuZCBPcGVyYXRpb25zIExpbWl0ZWQxJjAkBgNVBAsTHVRo
# YWxlcyBUU1MgRVNOOjJBRDQtNEI5Mi1GQTAxMSUwIwYDVQQDExxNaWNyb3NvZnQg
# VGltZS1TdGFtcCBTZXJ2aWNloiMKAQEwBwYFKw4DAhoDFQDtZLG+pANsDu/LLr1O
# fTA/kEbHK6CBgzCBgKR+MHwxCzAJBgNVBAYTAlVTMRMwEQYDVQQIEwpXYXNoaW5n
# dG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVNaWNyb3NvZnQgQ29ycG9y
# YXRpb24xJjAkBgNVBAMTHU1pY3Jvc29mdCBUaW1lLVN0YW1wIFBDQSAyMDEwMA0G
# CSqGSIb3DQEBBQUAAgUA6A3sHDAiGA8yMDIzMDUxNjE5NDg0NFoYDzIwMjMwNTE3
# MTk0ODQ0WjB0MDoGCisGAQQBhFkKBAExLDAqMAoCBQDoDewcAgEAMAcCAQACAhwK
# MAcCAQACAhPTMAoCBQDoDz2cAgEAMDYGCisGAQQBhFkKBAIxKDAmMAwGCisGAQQB
# hFkKAwKgCjAIAgEAAgMHoSChCjAIAgEAAgMBhqAwDQYJKoZIhvcNAQEFBQADgYEA
# FdaOiciLzgR12U8QMhCcYMZxLpfxrDWnLLcdmky07IIUNJGbE/VW5JNpJ0etyUry
# Aicy6Yibwyfmfxsoiu7jXFQrhT0RzguX993WNnWrFGFy0A/tJhQOEKqSfSG6XqZs
# Y4NLltA8TD6FoG8+B74dzTEIB1a08NXPj+fQDksgHlExggQNMIIECQIBATCBkzB8
# MQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMHUmVk
# bW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMSYwJAYDVQQDEx1N
# aWNyb3NvZnQgVGltZS1TdGFtcCBQQ0EgMjAxMAITMwAAAbHKkEPuC/ADqwABAAAB
# sTANBglghkgBZQMEAgEFAKCCAUowGgYJKoZIhvcNAQkDMQ0GCyqGSIb3DQEJEAEE
# MC8GCSqGSIb3DQEJBDEiBCBVQbmv+krHYIOHAio+5JJue72MQPaKNGymjj4ynGDI
# AzCB+gYLKoZIhvcNAQkQAi8xgeowgecwgeQwgb0EIIPtDYsUW9+p4OjL2Cm7fm3p
# 1h6usM7RwxOU4iibNM9sMIGYMIGApH4wfDELMAkGA1UEBhMCVVMxEzARBgNVBAgT
# Cldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29m
# dCBDb3Jwb3JhdGlvbjEmMCQGA1UEAxMdTWljcm9zb2Z0IFRpbWUtU3RhbXAgUENB
# IDIwMTACEzMAAAGxypBD7gvwA6sAAQAAAbEwIgQgO/3gwPXNB7LExjNk1pqgLVlO
# SmhfbbKDBcq+7XQOzkwwDQYJKoZIhvcNAQELBQAEggIAg9KnzRbllaLv0PqbwI3Z
# eaMb11ptR3+i/auFMIxXSIkqKDjyGJzBVo4dsX3QcsjHyd89pwP9T1sgb4jmgVvA
# L4sPVqjR5kB+9XY7+aESuYDG+O9zxTnpk8yjhyAk0S1dNT80L88Op8IAmqjc8fjx
# WhOJQJmaFUN3XCWwBNeq5CUouF748oh5Vxv9nFJKB52R/HvEVAmbQL1I+XKadyZr
# Cliy1aZtlORoudZUdDA6vCS1J+B0m7i0qwJFbpZ4YeKVYiUpAAUM7DnwXDZ8eEiK
# eRII+ratvB6eNUqVAbXGiwp+yCcX8AAeE7nm/t8MqiIEmqQz9fTMwSKfsuTcRBU0
# wRvSkz0MPWY2aDV6MHsLCvIxiB540wqiWihRtSlU9n7DrDagm++qiKzb58+uXLAO
# 1XqpC7M0R6sx1Hmrndr0auEyttCQYv6dK4JCEHcd7py5KJONo8dTkts5uMVH80TU
# 6AIvlhG9V+er15fqNQobKJjwpDE5EK/Nq+rg/mnR6wQjjW6BQEvXaTbntRjHM/Vw
# aRdAj/f2JmaiyzwOAhCL9AhRYKONxkdb9OK8HMVDVGTKFEK8hztcxSpg6Isf6zih
# Spz3b9hULu/eiGb61WoiMOCbA+QJElNY6xrMYFQ+DrNgF53A8abq1f2O/KnF1nex
# R2Mf7OclUXO3Fb6at1tKNPE=
# SIG # End signature block
