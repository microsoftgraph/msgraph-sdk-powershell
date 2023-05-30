# ------------------------------------------------------------------------------
#  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
# ------------------------------------------------------------------------------
Set-StrictMode -Version 2

<#
.Synopsis
Find Microsoft Graph PowerShell command meta-info by URI or command name.

.Description
The Find-MgGraphCommand command retrieves meta-info about Microsoft Graph PowerShell commands by URI or command name.

.PARAMETER Uri
The API path a command calls. e.g., /users.

.PARAMETER Method
The HTTP method a command makes.

.PARAMETER ApiVersion
The service API version.

.PARAMETER Command
The name of a command. e.g., Get-MgUser.

.Example
PS C:\> Find-MgGraphCommand -Uri "/users/{id}"

   APIVersion: v1.0

Command       Module Method URI              OutputType           Permissions
-------       ------ ------ ---              ----------           -----------
Get-MgUser    Users  GET    /users/{user-id} IMicrosoftGraphUser1 {DeviceManagementApps.Read.All DeviceManagementApps.Rea…
Remove-MgUser Users  DELETE /users/{user-id}                      {DeviceManagementApps.ReadWrite.All DeviceManagementMan…
Update-MgUser Users  PATCH  /users/{user-id}                      {DeviceManagementApps.ReadWrite.All DeviceManagementMan…

   APIVersion: beta

Command       Module Method URI              OutputType          Permissions
-------       ------ ------ ---              ----------          -----------
Get-MgUser    Users  GET    /users/{user-id} IMicrosoftGraphUser {DeviceManagementApps.Read.All DeviceManagementApps.Read…
Remove-MgUser Users  DELETE /users/{user-id}                     {DeviceManagementApps.ReadWrite.All DeviceManagementMana…
Update-MgUser Users  PATCH  /users/{user-id}                     {DeviceManagementApps.ReadWrite.All DeviceManagementMana…

This example finds all commands that call the provided Microsoft Graph URI.

.Example
PS C:\> Find-MgGraphCommand -Command Send-MgUserMessage -ApiVersion beta

   APIVersion: beta

Command            Module        Method URI                                                         OutputType Permissions
-------            ------        ------ ---                                                         ---------- -----------
Send-MgUserMessage Users.Actions POST   /users/{user-id}/messages/{message-id}/microsoft.graph.send            {Mail.Send}

This example looks up a command with the provided command name that calls the beta version of the API.

.Inputs
Pipeline input accepts API URIs as an array of strings.

.Outputs
Microsoft.Graph.PowerShell.Authentication.Models.IGraphCommand with the following properties:
    1. Command: Name of command.
    2. Module: Module in which a command is defined.
    3. Method: The HTTP method a command makes.
    4. Uri: The Microsoft Graph API URI a command calls.
    5. OutputType: The return type of a command.
    6. Permissions: Permissions needed to use a command. This field can be empty if the permissions are not yet available in Graph Explorer.
    7. Variants: The parameter sets of a command.

.LINK
https://learn.microsoft.com/powershell/microsoftgraph/find-mg-graph-command
#>
Function Find-MgGraphCommand {
    [CmdletBinding(DefaultParameterSetName = 'FindByCommandOrUri', PositionalBinding = $false)]
    [OutputType([Microsoft.Graph.PowerShell.Authentication.Models.IGraphCommand])]
    param (
        [Parameter(ParameterSetName = "FindByUri", Mandatory = $true, Position = 0, ValueFromPipeline = $true)]
        [string[]]$Uri,

        [Parameter(ParameterSetName = "FindByUri")]
        [ValidateSet("GET", "POST", "PUT", "PATCH", "DELETE")]
        [string]$Method,

        [Parameter(ParameterSetName = "FindByCommandOrUri")]
        [Parameter(ParameterSetName = "FindByUri")]
        [Parameter(ParameterSetName = "FindByCommand")]
        [ValidateSet("v1.0", "beta")]
        [string]$ApiVersion,

        [Parameter(ParameterSetName = "FindByCommand", Mandatory = $true)]
        [ValidateNotNullorEmpty()]
        [string[]]$Command,

        [Parameter(ParameterSetName = 'FindByCommandOrUri', Mandatory = $true, Position = 0, ValueFromPipeline = $true)]
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
# MIInzgYJKoZIhvcNAQcCoIInvzCCJ7sCAQExDzANBglghkgBZQMEAgEFADB5Bgor
# BgEEAYI3AgEEoGswaTA0BgorBgEEAYI3AgEeMCYCAwEAAAQQH8w7YFlLCE63JNLG
# KX7zUQIBAAIBAAIBAAIBAAIBADAxMA0GCWCGSAFlAwQCAQUABCBLy3X6A6OzBIsY
# CkU47+0vtXWiC/ihGcg+h4+RI6C6SKCCDYUwggYDMIID66ADAgECAhMzAAADTU6R
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
# cVZOSEXAQsmbdlsKgEhr/Xmfwb1tbWrJUnMTDXpQzTGCGZ8wghmbAgEBMIGVMH4x
# CzAJBgNVBAYTAlVTMRMwEQYDVQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRt
# b25kMR4wHAYDVQQKExVNaWNyb3NvZnQgQ29ycG9yYXRpb24xKDAmBgNVBAMTH01p
# Y3Jvc29mdCBDb2RlIFNpZ25pbmcgUENBIDIwMTECEzMAAANNTpGmGiiweI8AAAAA
# A00wDQYJYIZIAWUDBAIBBQCgga4wGQYJKoZIhvcNAQkDMQwGCisGAQQBgjcCAQQw
# HAYKKwYBBAGCNwIBCzEOMAwGCisGAQQBgjcCARUwLwYJKoZIhvcNAQkEMSIEIDVH
# 37apnueQVSuf2QFWMEUf6+vBRm/dlNsSiSwtgSVpMEIGCisGAQQBgjcCAQwxNDAy
# oBSAEgBNAGkAYwByAG8AcwBvAGYAdKEagBhodHRwOi8vd3d3Lm1pY3Jvc29mdC5j
# b20wDQYJKoZIhvcNAQEBBQAEggEAE6tikuTXE42UTA4iNJg82aI/PF64iLKMxo54
# crqTwSySSwdb7ZqbxeySgO1vZGhQUMvnp0JKsDUEB8Re1j/rcT3siS/fjcu84ls9
# oRmxD6RYZb6h6zGHpgcimipBa4C7yhYr/KQIFSjBvjoxKzMwzAESVvmQUPtooQk5
# sdcTRGIentf63xnYCu8866AegJoxOV8cfC3AdePILGJRgYj1liLO0GNUN/Wfoloo
# a5Re7ENhPBdc2cKWWzSdrq+Zt//po87uTFIRUQ0KyQasKD77qKpsU2C3HgRs+tGp
# Dyn/ejQBVN8yXTM8mxa3kE4pBGOx4r967HLw6EGQoYEzhfVlLKGCFykwghclBgor
# BgEEAYI3AwMBMYIXFTCCFxEGCSqGSIb3DQEHAqCCFwIwghb+AgEDMQ8wDQYJYIZI
# AWUDBAIBBQAwggFZBgsqhkiG9w0BCRABBKCCAUgEggFEMIIBQAIBAQYKKwYBBAGE
# WQoDATAxMA0GCWCGSAFlAwQCAQUABCA/Ms3PRh2HWf2ns3xgOruAwsr0m98NM5Sj
# X+UjhPWVMAIGZGzxsqm/GBMyMDIzMDUzMDE2MDM0MC45MzdaMASAAgH0oIHYpIHV
# MIHSMQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMH
# UmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMS0wKwYDVQQL
# EyRNaWNyb3NvZnQgSXJlbGFuZCBPcGVyYXRpb25zIExpbWl0ZWQxJjAkBgNVBAsT
# HVRoYWxlcyBUU1MgRVNOOjg2REYtNEJCQy05MzM1MSUwIwYDVQQDExxNaWNyb3Nv
# ZnQgVGltZS1TdGFtcCBTZXJ2aWNloIIReDCCBycwggUPoAMCAQICEzMAAAG3ISca
# B6IqhkYAAQAAAbcwDQYJKoZIhvcNAQELBQAwfDELMAkGA1UEBhMCVVMxEzARBgNV
# BAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jv
# c29mdCBDb3Jwb3JhdGlvbjEmMCQGA1UEAxMdTWljcm9zb2Z0IFRpbWUtU3RhbXAg
# UENBIDIwMTAwHhcNMjIwOTIwMjAyMjE0WhcNMjMxMjE0MjAyMjE0WjCB0jELMAkG
# A1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQx
# HjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjEtMCsGA1UECxMkTWljcm9z
# b2Z0IElyZWxhbmQgT3BlcmF0aW9ucyBMaW1pdGVkMSYwJAYDVQQLEx1UaGFsZXMg
# VFNTIEVTTjo4NkRGLTRCQkMtOTMzNTElMCMGA1UEAxMcTWljcm9zb2Z0IFRpbWUt
# U3RhbXAgU2VydmljZTCCAiIwDQYJKoZIhvcNAQEBBQADggIPADCCAgoCggIBAMf9
# z1dQNBNkTBq3HJclypjQcJIlDAgpvsw4vHJe06n532RKGkcn0V7p65OeA1wOoO+8
# NsopnjPpVZ8+4s/RhdMCMNPQJXoWdkWOp/3puIEs1fzPBgTJrdmzdyUYzrAloICY
# x722gmdpbNf3P0y5Z2gRO48sWIYyYeNJYch+ZfJzXqqvuvq7G8Nm8IMQi8Zayvx+
# 5dSGBM5VYHBxCEjXF9EN6Qw7A60SaXjKjojSpUmpaM4FmVec985PNdSh8hOeP2tL
# 781SBan92DT19tfNHv9H0FAmE2HGRwizHkJ//mAZdS0s6bi/UwPMksAia5bpnIDB
# OoaYdWkV0lVG5rN0+ltRz9zjlaH9uhdGTJ+WiNKOr7mRnlzYQA53ftSSJBqsEpTz
# Cv7c673fdvltx3y48Per6vc6UR5e4kSZsH141IhxhmRR2SmEabuYKOTdO7Q/vlvA
# fQxuEnJ93NL4LYV1IWw8O+xNO6gljrBpCOfOOTQgWJF+M6/IPyuYrcv79Lu7lc67
# S+U9MEu2dog0MuJIoYCMiuVaXS5+FmOJiyfiCZm0VJsJ570y9k/tEQe6aQR9MxDW
# 1p2F3HWebolXj9su7zrrElNlHAEvpFhcgoMniylNTiTZzLwUj7TH83gnugw1FCEV
# Vh5U9lwNMPL1IGuz/3U+RT9wZCBJYIrFJPd6k8UtAgMBAAGjggFJMIIBRTAdBgNV
# HQ4EFgQUs/I5Pgw0JAVhDdYB2yPII8l4tOwwHwYDVR0jBBgwFoAUn6cVXQBeYl2D
# 9OXSZacbUzUZ6XIwXwYDVR0fBFgwVjBUoFKgUIZOaHR0cDovL3d3dy5taWNyb3Nv
# ZnQuY29tL3BraW9wcy9jcmwvTWljcm9zb2Z0JTIwVGltZS1TdGFtcCUyMFBDQSUy
# MDIwMTAoMSkuY3JsMGwGCCsGAQUFBwEBBGAwXjBcBggrBgEFBQcwAoZQaHR0cDov
# L3d3dy5taWNyb3NvZnQuY29tL3BraW9wcy9jZXJ0cy9NaWNyb3NvZnQlMjBUaW1l
# LVN0YW1wJTIwUENBJTIwMjAxMCgxKS5jcnQwDAYDVR0TAQH/BAIwADAWBgNVHSUB
# Af8EDDAKBggrBgEFBQcDCDAOBgNVHQ8BAf8EBAMCB4AwDQYJKoZIhvcNAQELBQAD
# ggIBAA2dZMybhVxSXTbJzFgvNiMCV5/Ayn5UuzJU495YDtcefold0ehR9QBGBhHm
# AMt10WYCHz2WQUyM3mQD4IsHfEL1JEwgG9tGq71ucn9dknLBHD30JvbQRhIKcvFS
# nvRCCpVpilM8F/YaWXC9VibSef/PU2GWA+1zs64VFxJqHeuy8KqrQyfF20SCnd8z
# RZl4YYBcjh9G0GjhJHUPAYEx0r8jSWjyi2o2WAHD6CppBtkwnZSf7A68DL4OwwBp
# mFB3+vubjgNwaICS+fkGVvRnP2ZgmlfnaAas8Mx7igJqciqq0Q6An+0rHj1kxisN
# dIiTzFlu5Gw2ehXpLrl59kvsmONVAJHhndpx3n/0r76TH+3WNS9UT9jbxQkE+t2t
# hif6MK5krFMnkBICCR/DVcV1qw9sg6sMEo0wWSXlQYXvcQWA65eVzSkosylhIlIZ
# ZLL3GHZD1LQtAjp2A5F7C3Iw4Nt7C7aDCfpFxom3ZulRnFJollPHb3unj9hA9xvR
# iKnWMAMpS4MZAoiV4O29zWKZdUzygp7gD4WjKK115KCJ0ovEcf92AnwMAXMnNs1o
# 0LCszg+uDmiQZs5eR7jzdKzVfF1z7bfDYNPAJvm5pSQdby3wIOsN/stYjM+EkaPt
# Uzr8OyMwrG+jpFMbsB4cfN6tvIeGtrtklMJFtnF68CcZZ5IAMIIHcTCCBVmgAwIB
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
# aGFsZXMgVFNTIEVTTjo4NkRGLTRCQkMtOTMzNTElMCMGA1UEAxMcTWljcm9zb2Z0
# IFRpbWUtU3RhbXAgU2VydmljZaIjCgEBMAcGBSsOAwIaAxUAyGdBGMObODlsGBZm
# SUX2oWgfqcaggYMwgYCkfjB8MQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGlu
# Z3RvbjEQMA4GA1UEBxMHUmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBv
# cmF0aW9uMSYwJAYDVQQDEx1NaWNyb3NvZnQgVGltZS1TdGFtcCBQQ0EgMjAxMDAN
# BgkqhkiG9w0BAQUFAAIFAOggAc4wIhgPMjAyMzA1MzAxMzAyMDZaGA8yMDIzMDUz
# MTEzMDIwNlowdDA6BgorBgEEAYRZCgQBMSwwKjAKAgUA6CABzgIBADAHAgEAAgIW
# WjAHAgEAAgIRdDAKAgUA6CFTTgIBADA2BgorBgEEAYRZCgQCMSgwJjAMBgorBgEE
# AYRZCgMCoAowCAIBAAIDB6EgoQowCAIBAAIDAYagMA0GCSqGSIb3DQEBBQUAA4GB
# AKjdpM8SF2HwaWKBZ6Jpxi5Tj4Av28NeB/kbL3YG4j861/Zzg7wF1GrAsBXrAWV2
# m2ZYY/0jTZP9JCEofw/z7t5+W5MklgC3d59eOvp03huzxXVmWKDBgOGWcEw4qJoG
# RaCJnSasPGvKxMazbRoxlH3+aqEGjaGYezgpDSKx7EBHMYIEDTCCBAkCAQEwgZMw
# fDELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1Jl
# ZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjEmMCQGA1UEAxMd
# TWljcm9zb2Z0IFRpbWUtU3RhbXAgUENBIDIwMTACEzMAAAG3IScaB6IqhkYAAQAA
# AbcwDQYJYIZIAWUDBAIBBQCgggFKMBoGCSqGSIb3DQEJAzENBgsqhkiG9w0BCRAB
# BDAvBgkqhkiG9w0BCQQxIgQgwiYpwmTCttAeBuqrYldEd1qnQEKlKniJDl9zddxn
# Gp4wgfoGCyqGSIb3DQEJEAIvMYHqMIHnMIHkMIG9BCBsJ3jTsh7aL8hNeiYGL5/8
# IBn8zUfr7/Q7rkM8ic1wQTCBmDCBgKR+MHwxCzAJBgNVBAYTAlVTMRMwEQYDVQQI
# EwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVNaWNyb3Nv
# ZnQgQ29ycG9yYXRpb24xJjAkBgNVBAMTHU1pY3Jvc29mdCBUaW1lLVN0YW1wIFBD
# QSAyMDEwAhMzAAABtyEnGgeiKoZGAAEAAAG3MCIEICMpI3bBFuPDmTLsJ+imocn7
# jDCY7Yw2VwmWsli7L2GlMA0GCSqGSIb3DQEBCwUABIICAD3UuPFEhOCowGGI7tRY
# R4bLpMT59ZJVW1lksARi8IHCHmVnw9nM5HrOkI1epQTPGB0WpitxAe9U9srXft2h
# mjYvzOAV2N3pTlKMqUuxE34QQTBF8G2sVEcPiiCDuivXm+rnXeTyMmcJcGfDnJ59
# 8kbxA6syMI34qdT2Y6dijutQZsjPNNI/HoSFQLkW6aD8hQaYQA7T5M6NHHpmlfFH
# jkseDcudYe4qGZ1Pb15FWrJb7HTt/6WFzUcsxa1L3dP1HEiHpJbpQ0q6UPs1Efyn
# c2dWHt2cKo8ft0FwkRxWAtAqDiumFZTKJRHkUEl67lUARvK5xGZL+Jtz2/jWw8QZ
# bjcWQf0CnfW9FLt+zQEP25Vc/d1tvZUvoDXd0p6SR08RI2JTzkAbmTPrlQDU8WtQ
# JfyH0rmDGEC0VUc1MdB+QljcLBxPaDvx0JlrHwS8uXlhgQvrSUXWbT8I12ZqG5GU
# FXKuWgLIcmeRqDXjG2cDhzBgHBsfI7ARQa5YU9YjgJiXxSfNys7ZORkE3ZthZ+Pu
# uFmChfVUurVt6fsh7/4HfsIcmKnIhzU8NmGg+7J7qn/JRfxQxoqr0YOYKHYPDPby
# cYfOrK+E5dxsOvUJmJOjeUkoCygR4UxLaZMQAOeiCkkidEhhSSBwkRqmfNCgW2pu
# lL2D21Gzie8WWB2X4/JsclIF
# SIG # End signature block
