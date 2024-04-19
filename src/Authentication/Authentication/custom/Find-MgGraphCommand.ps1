# ------------------------------------------------------------------------------
#  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
# ------------------------------------------------------------------------------
Set-StrictMode -Version 2
Function Find-MgGraphCommand {
    [CmdletBinding(DefaultParameterSetName = 'FindByCommandOrUri', PositionalBinding = $false, HelpUri = 'https://learn.microsoft.com/en-us/powershell/module/microsoft.graph.authentication/find-mggraphcommand')]
    [OutputType([Microsoft.Graph.PowerShell.Authentication.Models.IGraphCommand])]
    param (
        [Parameter(ParameterSetName = "FindByUri", Mandatory = $true, Position = 0, ValueFromPipeline = $true, HelpMessage = 'The URI to find.')]
        [string[]]$Uri,

        [Parameter(ParameterSetName = "FindByUri", HelpMessage = 'The HTTP method to specify. i.e. GET, POST, PUT, PATCH, DELETE')]
        [ValidateSet("GET", "POST", "PUT", "PATCH", "DELETE")]
        [string]$Method,

        [Parameter(ParameterSetName = "FindByCommandOrUri")]
        [Parameter(ParameterSetName = "FindByUri")]
        [Parameter(ParameterSetName = "FindByCommand", HelpMessage = 'The API version to specify. i.e. v1.0, beta')]
        [ValidateSet("v1.0", "beta")]
        [string]$ApiVersion,

        [Parameter(ParameterSetName = "FindByCommand", Mandatory = $true, HelpMessage = 'The command to find.')]
        [ValidateNotNullorEmpty()]
        [string[]]$Command,

        [Parameter(ParameterSetName = 'FindByCommandOrUri', Mandatory = $true, Position = 0, ValueFromPipeline = $true, HelpMessage = 'The command or URI to find.')]
        [object[]]$InputObject
    )

    begin {
        # Import utility scripts.
        . "$PSScriptRoot/common/GraphCommand.ps1" | Out-Null
        . "$PSScriptRoot/common/GraphUri.ps1" | Out-Null

        # Read content of metadata file and cache in session object.
        if ($null -ne [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance -and
            $null -ne [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.MgCommandMetadata) {
            Write-Debug "Reading MgCommandMetadata from session object."
        }
        else {
            [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.MgCommandMetadata = GraphCommand_ReadGraphCommandMetadata
        }

        function ResolveCommand {
            param(
                [Parameter(Mandatory = $true, Position = 0)]
                [string]$Command
            )

            Write-Debug "Received Command: $Command"

            # Read content of mapping file and cache in session object.
            if ($null -ne [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance -and
                $null -ne [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.MgLegacyCommandMapping) {
                Write-Debug "Reading MgLegacyCommandMapping from session object."
            }
            else {
                [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.MgLegacyCommandMapping = GraphCommand_ReadLegacyGraphCommandMapping
            }

            # Resolve legacy commands.
            [array]$ResolvedCommands = [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.MgLegacyCommandMapping | Where-Object LegacyMapping -Contains $Command
            if ($ResolvedCommands) {
                $ResolvedCommands = $ResolvedCommands.Command
            }
            else {
                $ResolvedCommands = $Command
            }
            Write-Debug "Resolved Command: $ResolvedCommands"
            Write-Output $ResolvedCommands -NoEnumerate
        }

        function FindByCommand {
            param(
                [Parameter(Mandatory = $true, Position = 0)]
                [string[]]$Command
            )

            foreach ($c in $Command) {
                $Result = @()
                Write-Debug "Matching Command: $c"
                Write-Debug "Matching ApiVersion: $ApiVersion"
                [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.MgCommandMetadata | ForEach-Object {
                    if ($_.ApiVersion -match $ApiVersion -and
                        $_.Command -match "^$c$") {
                        $Result += [Microsoft.Graph.PowerShell.Authentication.Models.GraphCommand]$_
                    }
                }
                Write-Output $Result -NoEnumerate
            }
        }

        function ResolveUri {
            param(
                [Parameter(Mandatory = $true, Position = 0)]
                [string]$Uri
            )

            $Result = @()
            Write-Debug "Received URI: $Uri."
            
            $Uri = GraphUri_RemoveNamespaceFromActionFunction $Uri
            $GraphUri = GraphUri_ConvertStringToUri $Uri

            # Use API version in URI if -ApiVersion is not provided.
            if ([System.String]::IsNullOrWhiteSpace($ApiVersion) -and ($GraphUri.OriginalString -match "(v1.0|beta)\/")) {
                $ApiVersion = $Matches[1]
            }
            
            

            if (!$GraphUri.IsAbsoluteUri) {
                $GraphUri = GraphUri_ConvertRelativeUriToAbsoluteUri -Uri $GraphUri -ApiVersion $ApiVersion
            }
            
            $ContainsMeSegment = $False
            $Segment = $GraphUri.Segments
            foreach ($s in $Segment) {
                if ($s.StartsWith("me")) {
                    $ContainsMeSegment = $True
                    break
                }
            }
            if ($ContainsMeSegment) {
                $GraphUri = $GraphUri.AbsoluteUri.Replace("/me/", "/users/{id}/")
            }
            Write-Debug "Resolved URI: $GraphUri."
            return $GraphUri
        }

        function FindByUri {
            param(
                [Parameter(Mandatory = $true, Position = 0)]
                [System.Uri]$Uri
            )
            $Result = @()
            $TokenizedUri = GraphUri_TokenizeIds $Uri
            Write-Debug "Tokenized URI: $TokenizedUri."

            $ResourceSegmentRegex = GraphUri_GetResourceSegmentRegex $TokenizedUri
            Write-Debug "Matching URI: $ResourceSegmentRegex"
            Write-Debug "Matching Method: $Method"
            Write-Debug "Matching ApiVersion: $ApiVersion"
            [Microsoft.Graph.PowerShell.Authentication.GraphSession]::Instance.MgCommandMetadata | ForEach-Object {
                if ($_.Method -match $Method -and
                    $_.ApiVersion -match $ApiVersion -and
                    $_.Uri -match $ResourceSegmentRegex) {
                    $Result += [Microsoft.Graph.PowerShell.Authentication.Models.GraphCommand]$_
                }
            }
            Write-Output $Result -NoEnumerate
        }
    }

    process {
        $Result = @()
        try {
            switch ($PSCmdlet.ParameterSetName) {
                "FindByCommandOrUri" {
                    foreach ($o in $InputObject) {
                        if ($o -is [System.Management.Automation.CommandInfo]) {
                            $InputString = $o.Name
                        }
                        else {
                            $InputString = $o
                        }

                        $ResolvedCommand = ResolveCommand $InputString
                        $Result = FindByCommand $ResolvedCommand
                        if ($Result.Count -lt 1) {
                            $GraphUri = ResolveUri $InputString
                            $Result = FindByUri $GraphUri
                        }
                        if ($Result.Count -lt 1) {
                            Write-Error "'$InputString' is not a valid Microsoft Graph PowerShell command. Please check the name and try again."
                            Write-Error "URI '$Method $GraphUri' in $ApiVersion is not valid or is not currently supported by the SDK. Ensure the URI is formatted correctly and try again."
                        }
                    }
                }
                "FindByUri" {
                    foreach ($u in $Uri) {
                        $GraphUri = ResolveUri $u
                        $Result = FindByUri $GraphUri
                        if ($Result.Count -lt 1) {
                            Write-Error "URI '$Method $GraphUri' in $ApiVersion is not valid or is not currently supported by the SDK. Ensure the URI is formatted correctly and try again."
                        }
                    }
                }
                "FindByCommand" {
                    foreach ($c in $Command) {
                        $ResolvedCommand = ResolveCommand $c
                        $Result = FindByCommand $ResolvedCommand
                        if ($Result.Count -lt 1) {
                            Write-Error "'$c' is not a valid Microsoft Graph PowerShell command. Please check the name and try again."
                        }
                    }
                }
            }
        }
        catch {
            Write-Error $_.Exception
        }

        return $Result | Sort-Object @{Expression = "APIVersion"; Descending = $True }, @{Expression = "Command"; Descending = $False }
    }
}
# SIG # Begin signature block
# MIInwAYJKoZIhvcNAQcCoIInsTCCJ60CAQExDzANBglghkgBZQMEAgEFADB5Bgor
# BgEEAYI3AgEEoGswaTA0BgorBgEEAYI3AgEeMCYCAwEAAAQQH8w7YFlLCE63JNLG
# KX7zUQIBAAIBAAIBAAIBAAIBADAxMA0GCWCGSAFlAwQCAQUABCBuzbOPsN9upEx4
# HJ3jSUUmIBzwRGbtsGD9+3aQ2i4R8KCCDXYwggX0MIID3KADAgECAhMzAAADrzBA
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
# /Xmfwb1tbWrJUnMTDXpQzTGCGaAwghmcAgEBMIGVMH4xCzAJBgNVBAYTAlVTMRMw
# EQYDVQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVN
# aWNyb3NvZnQgQ29ycG9yYXRpb24xKDAmBgNVBAMTH01pY3Jvc29mdCBDb2RlIFNp
# Z25pbmcgUENBIDIwMTECEzMAAAOvMEAOTKNNBUEAAAAAA68wDQYJYIZIAWUDBAIB
# BQCgga4wGQYJKoZIhvcNAQkDMQwGCisGAQQBgjcCAQQwHAYKKwYBBAGCNwIBCzEO
# MAwGCisGAQQBgjcCARUwLwYJKoZIhvcNAQkEMSIEIIHpu3QXkyKEaL8hgBT4mNiB
# G3pnn8vsUjs+PppqZokHMEIGCisGAQQBgjcCAQwxNDAyoBSAEgBNAGkAYwByAG8A
# cwBvAGYAdKEagBhodHRwOi8vd3d3Lm1pY3Jvc29mdC5jb20wDQYJKoZIhvcNAQEB
# BQAEggEABSYegGW4QrGfklj6KOFnxeo/V5P4v3NLCxxFRc+7Cp+EcLgQdkaOpUM/
# SAtR/8AGljhM/RB8E3TfkwYEoZkn5A7sdFTEmTqMtTypVQBubUxwbtzYgNy1lBFo
# P+Pwp9Xoy8ewNGYsZMFnMucT639vcEL6J4NcGxwtNc26judXQPaMU+Vqntv/lRdN
# kZmjZyLpAMTvVhEp+EzRKEfiWh4+7zJR8WPljfcTRcyL8V/LgrhfXRIXHPKAUxHu
# KX4bMAL/oWfAXgisXTsiz+KsWPnT2S1MiTp/nUSVj9aIeuxgWSnl91SuL9YHJg/e
# q/+2yR3BghudJMcgf39VxXMjSj7O5KGCFyowghcmBgorBgEEAYI3AwMBMYIXFjCC
# FxIGCSqGSIb3DQEHAqCCFwMwghb/AgEDMQ8wDQYJYIZIAWUDBAIBBQAwggFZBgsq
# hkiG9w0BCRABBKCCAUgEggFEMIIBQAIBAQYKKwYBBAGEWQoDATAxMA0GCWCGSAFl
# AwQCAQUABCCju+55JHux3oUe44OC+D0VK6iD1BUSXcpcM8sxjABYnwIGZiAgbMPl
# GBMyMDI0MDQxOTE0MDIxMi42MzFaMASAAgH0oIHYpIHVMIHSMQswCQYDVQQGEwJV
# UzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMHUmVkbW9uZDEeMBwGA1UE
# ChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMS0wKwYDVQQLEyRNaWNyb3NvZnQgSXJl
# bGFuZCBPcGVyYXRpb25zIExpbWl0ZWQxJjAkBgNVBAsTHVRoYWxlcyBUU1MgRVNO
# OkZDNDEtNEJENC1EMjIwMSUwIwYDVQQDExxNaWNyb3NvZnQgVGltZS1TdGFtcCBT
# ZXJ2aWNloIIReTCCBycwggUPoAMCAQICEzMAAAHimZmV8dzjIOsAAQAAAeIwDQYJ
# KoZIhvcNAQELBQAwfDELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24x
# EDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlv
# bjEmMCQGA1UEAxMdTWljcm9zb2Z0IFRpbWUtU3RhbXAgUENBIDIwMTAwHhcNMjMx
# MDEyMTkwNzI1WhcNMjUwMTEwMTkwNzI1WjCB0jELMAkGA1UEBhMCVVMxEzARBgNV
# BAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jv
# c29mdCBDb3Jwb3JhdGlvbjEtMCsGA1UECxMkTWljcm9zb2Z0IElyZWxhbmQgT3Bl
# cmF0aW9ucyBMaW1pdGVkMSYwJAYDVQQLEx1UaGFsZXMgVFNTIEVTTjpGQzQxLTRC
# RDQtRDIyMDElMCMGA1UEAxMcTWljcm9zb2Z0IFRpbWUtU3RhbXAgU2VydmljZTCC
# AiIwDQYJKoZIhvcNAQEBBQADggIPADCCAgoCggIBALVjtZhV+kFmb8cKQpg2mzis
# DlRI978Gb2amGvbAmCd04JVGeTe/QGzM8KbQrMDol7DC7jS03JkcrPsWi9WpVwsI
# ckRQ8AkX1idBG9HhyCspAavfuvz55khl7brPQx7H99UJbsE3wMmpmJasPWpgF05z
# ZlvpWQDULDcIYyl5lXI4HVZ5N6MSxWO8zwWr4r9xkMmUXs7ICxDJr5a39SSePAJR
# IyznaIc0WzZ6MFcTRzLLNyPBE4KrVv1LFd96FNxAzwnetSePg88EmRezr2T3HTFE
# lneJXyQYd6YQ7eCIc7yllWoY03CEg9ghorp9qUKcBUfFcS4XElf3GSERnlzJsK7s
# /ZGPU4daHT2jWGoYha2QCOmkgjOmBFCqQFFwFmsPrZj4eQszYxq4c4HqPnUu4hT4
# aqpvUZ3qIOXbdyU42pNL93cn0rPTTleOUsOQbgvlRdthFCBepxfb6nbsp3fcZaPB
# fTbtXVa8nLQuMCBqyfsebuqnbwj+lHQfqKpivpyd7KCWACoj78XUwYqy1HyYnStT
# me4T9vK6u2O/KThfROeJHiSg44ymFj+34IcFEhPogaKvNNsTVm4QbqphCyknrwBy
# qorBCLH6bllRtJMJwmu7GRdTQsIx2HMKqphEtpSm1z3ufASdPrgPhsQIRFkHZGui
# hL1Jjj4Lu3CbAmha0lOrAgMBAAGjggFJMIIBRTAdBgNVHQ4EFgQURIQOEdq+7Qds
# lptJiCRNpXgJ2gUwHwYDVR0jBBgwFoAUn6cVXQBeYl2D9OXSZacbUzUZ6XIwXwYD
# VR0fBFgwVjBUoFKgUIZOaHR0cDovL3d3dy5taWNyb3NvZnQuY29tL3BraW9wcy9j
# cmwvTWljcm9zb2Z0JTIwVGltZS1TdGFtcCUyMFBDQSUyMDIwMTAoMSkuY3JsMGwG
# CCsGAQUFBwEBBGAwXjBcBggrBgEFBQcwAoZQaHR0cDovL3d3dy5taWNyb3NvZnQu
# Y29tL3BraW9wcy9jZXJ0cy9NaWNyb3NvZnQlMjBUaW1lLVN0YW1wJTIwUENBJTIw
# MjAxMCgxKS5jcnQwDAYDVR0TAQH/BAIwADAWBgNVHSUBAf8EDDAKBggrBgEFBQcD
# CDAOBgNVHQ8BAf8EBAMCB4AwDQYJKoZIhvcNAQELBQADggIBAORURDGrVRTbnulf
# sg2cTsyyh7YXvhVU7NZMkITAQYsFEPVgvSviCylr5ap3ka76Yz0t/6lxuczI6w7t
# Xq8n4WxUUgcj5wAhnNorhnD8ljYqbck37fggYK3+wEwLhP1PGC5tvXK0xYomU1nU
# +lXOy9ZRnShI/HZdFrw2srgtsbWow9OMuADS5lg7okrXa2daCOGnxuaD1IO+65E7
# qv2O0W0sGj7AWdOjNdpexPrspL2KEcOMeJVmkk/O0ganhFzzHAnWjtNWneU11WQ6
# Bxv8OpN1fY9wzQoiycgvOOJM93od55EGeXxfF8bofLVlUE3zIikoSed+8s61NDP+
# x9RMya2mwK/Ys1xdvDlZTHndIKssfmu3vu/a+BFf2uIoycVTvBQpv/drRJD68eo4
# 01mkCRFkmy/+BmQlRrx2rapqAu5k0Nev+iUdBUKmX/iOaKZ75vuQg7hCiBA5xIm5
# ZIXDSlX47wwFar3/BgTwntMq9ra6QRAeS/o/uYWkmvqvE8Aq38QmKgTiBnWSS/uV
# PcaHEyArnyFh5G+qeCGmL44MfEnFEhxc3saPmXhe6MhSgCIGJUZDA7336nQD8fn4
# y6534Lel+LuT5F5bFt0mLwd+H5GxGzObZmm/c3pEWtHv1ug7dS/Dfrcd1sn2E4gk
# 4W1L1jdRBbK9xwkMmwY+CHZeMSvBMIIHcTCCBVmgAwIBAgITMwAAABXF52ueAptJ
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
# tB1VM1izoXBm8qGCAtUwggI+AgEBMIIBAKGB2KSB1TCB0jELMAkGA1UEBhMCVVMx
# EzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoT
# FU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjEtMCsGA1UECxMkTWljcm9zb2Z0IElyZWxh
# bmQgT3BlcmF0aW9ucyBMaW1pdGVkMSYwJAYDVQQLEx1UaGFsZXMgVFNTIEVTTjpG
# QzQxLTRCRDQtRDIyMDElMCMGA1UEAxMcTWljcm9zb2Z0IFRpbWUtU3RhbXAgU2Vy
# dmljZaIjCgEBMAcGBSsOAwIaAxUAFpuZafp0bnpJdIhfiB1d8pTohm+ggYMwgYCk
# fjB8MQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMH
# UmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMSYwJAYDVQQD
# Ex1NaWNyb3NvZnQgVGltZS1TdGFtcCBQQ0EgMjAxMDANBgkqhkiG9w0BAQUFAAIF
# AOnL8DcwIhgPMjAyNDA0MTkwMzE3MTFaGA8yMDI0MDQyMDAzMTcxMVowdTA7Bgor
# BgEEAYRZCgQBMS0wKzAKAgUA6cvwNwIBADAIAgEAAgMAyk4wBwIBAAICEV0wCgIF
# AOnNQbcCAQAwNgYKKwYBBAGEWQoEAjEoMCYwDAYKKwYBBAGEWQoDAqAKMAgCAQAC
# AwehIKEKMAgCAQACAwGGoDANBgkqhkiG9w0BAQUFAAOBgQDBY8kwbMdUBy3IaVyj
# S4SSXtHaPIbHkmxfP2vqUBn6VEhBXIGY/RIKaIsiM19tqziGGj0YerkewNJwTOvO
# 2WtXQ3CWZsqasjDgnITgynIwHVrrDpjeK78Ocqs1gSW0QZuT3bO9vPsUb7kEV/cL
# 05rZWfxwlPUbszUw5SvDJAOj1zGCBA0wggQJAgEBMIGTMHwxCzAJBgNVBAYTAlVT
# MRMwEQYDVQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQK
# ExVNaWNyb3NvZnQgQ29ycG9yYXRpb24xJjAkBgNVBAMTHU1pY3Jvc29mdCBUaW1l
# LVN0YW1wIFBDQSAyMDEwAhMzAAAB4pmZlfHc4yDrAAEAAAHiMA0GCWCGSAFlAwQC
# AQUAoIIBSjAaBgkqhkiG9w0BCQMxDQYLKoZIhvcNAQkQAQQwLwYJKoZIhvcNAQkE
# MSIEIEUPal14jz3BMvFKSCyCTX95FJHRTXsScQlaoVL9jLMPMIH6BgsqhkiG9w0B
# CRACLzGB6jCB5zCB5DCBvQQgK4kqShD9JrjGwVBEzg6C+HeS1OiP247nCGZDiQiP
# f/8wgZgwgYCkfjB8MQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQ
# MA4GA1UEBxMHUmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9u
# MSYwJAYDVQQDEx1NaWNyb3NvZnQgVGltZS1TdGFtcCBQQ0EgMjAxMAITMwAAAeKZ
# mZXx3OMg6wABAAAB4jAiBCA2nLrivZ9kP3fzp+Iq9z0XOqqH0Sm7Z6/fS9/91c2R
# 0jANBgkqhkiG9w0BAQsFAASCAgBzHPCj8n7Zn36+2ha8bbEe3xvDHJLlid1IKlW6
# lLChUxiMSKseFVxu2PkBqIRNVDYAcJWn4hnio+PKpzYhiq/+s5NBUh8KzbuoN4HS
# UlB+xadpCFjok70vWrBJSPoOVmF6676RoiQqlG80N+O8YMGlYNSj4kguYfGYZb5Y
# STHf0dpXffhvbtU6BFt1XleJwYAQFNVxjoj7TOmItfeGdNrcrQUK3hf1CwY2o4/a
# EIUGsI9nHhwMEDFl1slw7YL9UdOTWssBj3b1XGMRy7+hCM8h4TOTIB9l/ACpli7Y
# c3g24jkGt+cIcY2/oUCHJCO4xG+FBYkTJp41pSh9pn//S9CpkiibgNoyNLgH4Ln1
# VTb4hs4vDNGd2TmU0NtzumLUeyUBLKyuT9LG5OJx2i//61CtWFdTnsyPCLjkPI/b
# 2N1yo8ciYwyvFaRTzEg/OHBw3Buter62VNQrP6me0F/6fD3m9jrxDjzisKnmKknq
# eKDTmppXXKNCuOQ7lQDXspSAGj1xu0LwswYNBImDlYyBQbxxD24Clb7XlgvKKaSA
# I96T8HZ0XeWw7w+kiLPk9WkNURh800S6aXokdgUo31h0EY/ueHT9aHko6VzNpldt
# xmYSAmvVPtyqc6pyE1nDC5Di33tJHb7NnDpH0LTrZ0WQSj4JiNl2oI1vJShTCYiW
# k9Nx2Q==
# SIG # End signature block
