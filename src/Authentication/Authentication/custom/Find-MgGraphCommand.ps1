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
# MIInwgYJKoZIhvcNAQcCoIInszCCJ68CAQExDzANBglghkgBZQMEAgEFADB5Bgor
# BgEEAYI3AgEEoGswaTA0BgorBgEEAYI3AgEeMCYCAwEAAAQQH8w7YFlLCE63JNLG
# KX7zUQIBAAIBAAIBAAIBAAIBADAxMA0GCWCGSAFlAwQCAQUABCBLy3X6A6OzBIsY
# CkU47+0vtXWiC/ihGcg+h4+RI6C6SKCCDXYwggX0MIID3KADAgECAhMzAAADTrU8
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
# MAwGCisGAQQBgjcCARUwLwYJKoZIhvcNAQkEMSIEIDVH37apnueQVSuf2QFWMEUf
# 6+vBRm/dlNsSiSwtgSVpMEIGCisGAQQBgjcCAQwxNDAyoBSAEgBNAGkAYwByAG8A
# cwBvAGYAdKEagBhodHRwOi8vd3d3Lm1pY3Jvc29mdC5jb20wDQYJKoZIhvcNAQEB
# BQAEggEAMu6vDvJ/P/EHH8Q8YR6MRZSC0+JnvV1IyiabcuQwVM1dIcErj+2bgJNB
# Ge0hQmz4yacIE/Yz9e0fw2HutIt8qCDvs4Is2G+PVpTbFwr5Kme7/zjhFblNyIge
# sIlYebZic/EMYZ9eL6f0DUfepv7uJDEwB5y7P0aZ3ok9XQL1Nezgr3ZlMKT5M+48
# 5/bmZ7FsP+vPizBxsgxcUP+6eqOjRWd/GLWlFKV4TLpvdk3pBWG9Crdw8Bytva8y
# HpuvC8rfzFK7BnvYXnjwIsw/TH/zNjaR+AzuKO2PFoCoYZxsaKeTWVF2VZIOTDVo
# 5ZHKTRZ5uVTHTHBLUJ3qq7uKvKrw5KGCFywwghcoBgorBgEEAYI3AwMBMYIXGDCC
# FxQGCSqGSIb3DQEHAqCCFwUwghcBAgEDMQ8wDQYJYIZIAWUDBAIBBQAwggFZBgsq
# hkiG9w0BCRABBKCCAUgEggFEMIIBQAIBAQYKKwYBBAGEWQoDATAxMA0GCWCGSAFl
# AwQCAQUABCClZbeUxCJZagJimZcK5a7qufO+u4/Of7zg4e3s4eiqewIGZD/VQr2v
# GBMyMDIzMDUxNjEyMjQ1Mi45MjVaMASAAgH0oIHYpIHVMIHSMQswCQYDVQQGEwJV
# UzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMHUmVkbW9uZDEeMBwGA1UE
# ChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMS0wKwYDVQQLEyRNaWNyb3NvZnQgSXJl
# bGFuZCBPcGVyYXRpb25zIExpbWl0ZWQxJjAkBgNVBAsTHVRoYWxlcyBUU1MgRVNO
# OjNCRDQtNEI4MC02OUMzMSUwIwYDVQQDExxNaWNyb3NvZnQgVGltZS1TdGFtcCBT
# ZXJ2aWNloIIRezCCBycwggUPoAMCAQICEzMAAAG0+4AIRAXSLfoAAQAAAbQwDQYJ
# KoZIhvcNAQELBQAwfDELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24x
# EDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlv
# bjEmMCQGA1UEAxMdTWljcm9zb2Z0IFRpbWUtU3RhbXAgUENBIDIwMTAwHhcNMjIw
# OTIwMjAyMjA5WhcNMjMxMjE0MjAyMjA5WjCB0jELMAkGA1UEBhMCVVMxEzARBgNV
# BAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jv
# c29mdCBDb3Jwb3JhdGlvbjEtMCsGA1UECxMkTWljcm9zb2Z0IElyZWxhbmQgT3Bl
# cmF0aW9ucyBMaW1pdGVkMSYwJAYDVQQLEx1UaGFsZXMgVFNTIEVTTjozQkQ0LTRC
# ODAtNjlDMzElMCMGA1UEAxMcTWljcm9zb2Z0IFRpbWUtU3RhbXAgU2VydmljZTCC
# AiIwDQYJKoZIhvcNAQEBBQADggIPADCCAgoCggIBALRHpp5lBzJCH7zortuyvOmW
# 8FoZLBsFe9g5dbhnaq9qSpvpn86E/mJ4JKvWixH/lw7QA8gPtiiGVNIjvFhu/XiY
# 889vX5WaQSmyoPMZdj9zvXa5XrkMN05zXzTePkCIIzF6RN7cTxezOyESymTIjrdx
# X5BVlZolyQAOxNziMCYKYYNPbYd0786fDE/PhzrRt23a0Xf8trvFa0LEEy2YlcE2
# eqg2CjU/D0GZe8Ra0kjt0M12vdS4qWZ2Dpd7IhiQwnntQWu19Ytd3UBR8SpeRX+C
# cw3bjgWfOXtla6chctWt2shlMwayMOfY4TG4yMPWFXELfZFFp7cgpjZNeVsmwkvo
# V6RAwy1Y9V+VvbJ5qFtartN/rp6a0I1kGlbjuwX3L0HTVXcikqgHistXk9h3HOZ9
# WgFXlxZurG1SZmcz0BEEdya+1vGHE45KguYU9qq2LiHGBjn9z4+DqnV5tUKobsLb
# JMb4r+8st2fj8SacSsftnusxkWqEJiJS34P2uNlzVR03+ls6+ZO0NcO79LgP7BbI
# MipiOx8yh19PMQw0piaKFwOW7Q+gdJcfy6rOkG+CrYZwOzdiBHSebIzCIch2cAa+
# 38w7JFP/koKdlJ36qzdVXWv4G/qZpWycIvDKYbxJWM40+z2Stg5uHqK3I8e09kFX
# txCHpS7hm8c8m25WaEU5AgMBAAGjggFJMIIBRTAdBgNVHQ4EFgQUy0SF5fGUuDqc
# uxIot07eOMwy2X4wHwYDVR0jBBgwFoAUn6cVXQBeYl2D9OXSZacbUzUZ6XIwXwYD
# VR0fBFgwVjBUoFKgUIZOaHR0cDovL3d3dy5taWNyb3NvZnQuY29tL3BraW9wcy9j
# cmwvTWljcm9zb2Z0JTIwVGltZS1TdGFtcCUyMFBDQSUyMDIwMTAoMSkuY3JsMGwG
# CCsGAQUFBwEBBGAwXjBcBggrBgEFBQcwAoZQaHR0cDovL3d3dy5taWNyb3NvZnQu
# Y29tL3BraW9wcy9jZXJ0cy9NaWNyb3NvZnQlMjBUaW1lLVN0YW1wJTIwUENBJTIw
# MjAxMCgxKS5jcnQwDAYDVR0TAQH/BAIwADAWBgNVHSUBAf8EDDAKBggrBgEFBQcD
# CDAOBgNVHQ8BAf8EBAMCB4AwDQYJKoZIhvcNAQELBQADggIBABLRDwWMKbeCYqEq
# tI6Bs8KmF+kqDR+2G6qYAK3ZZ63bert7pCkRJbihFaktl2o18cdFJFxnOF4vXadm
# 0sabskJ05KviEMJIO6dXSq8AGtr3Zmjc895q0mnlBLuNMgk4R8KrkJMHqBuHqkUW
# XtfTrVUpgwzQt2UOiINKs+/b4r14MuXRVpOJ6cQOS8UhkeMAWl2iLlYaBGtOr3f/
# f9mLEPfWwoke0sSUbdV60OZCRh1ItBYYM9efKr14H5qu6jan6n00prEEa7W3uGb/
# 1/qj6P5emnvkqy5HI0X69DjVdLxVbjSsegm/dA+S4DaXPcfFf6iBxK/iV21l1upg
# EVVajUApl5VR40wY4XF8EpmnUdTqLXDf7CqdhDjPST2K/OjvWPyQGQvc7oPapYyk
# 66GU32AOyyHXJj6+vbtRUg/+ory+h0R2Xf5NhC+xbWcMzXEUXRRf1YKZDsRyH6r4
# 12pm8KDKE/r7Rk7aoKK7oYUpNGzNRf6QaYv5z2bVTSxkzWivFrepLHGwvRun9PYM
# /8AQSTgZr0yzzjk/97WghkqCaAwAVpyvg3uaYnuCl/AccSkGyb8c+70bFSeUephs
# fgb2r+QI7Mb2WcOnkJpCNLz0XJMS/UwlQn1ktLsiCpsqOk3aLJ2wTv6LK3u69I0v
# QB/LKRKlZYRXKUDXzoPwr3UtsTVTMIIHcTCCBVmgAwIBAgITMwAAABXF52ueAptJ
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
# bmQgT3BlcmF0aW9ucyBMaW1pdGVkMSYwJAYDVQQLEx1UaGFsZXMgVFNTIEVTTjoz
# QkQ0LTRCODAtNjlDMzElMCMGA1UEAxMcTWljcm9zb2Z0IFRpbWUtU3RhbXAgU2Vy
# dmljZaIjCgEBMAcGBSsOAwIaAxUAZZzYkPObl/ZzeCkSbf4B5CceCQiggYMwgYCk
# fjB8MQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMH
# UmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMSYwJAYDVQQD
# Ex1NaWNyb3NvZnQgVGltZS1TdGFtcCBQQ0EgMjAxMDANBgkqhkiG9w0BAQUFAAIF
# AOgN6X8wIhgPMjAyMzA1MTYxOTM3MzVaGA8yMDIzMDUxNzE5MzczNVowdzA9Bgor
# BgEEAYRZCgQBMS8wLTAKAgUA6A3pfwIBADAKAgEAAgIOfQIB/zAHAgEAAgITyzAK
# AgUA6A86/wIBADA2BgorBgEEAYRZCgQCMSgwJjAMBgorBgEEAYRZCgMCoAowCAIB
# AAIDB6EgoQowCAIBAAIDAYagMA0GCSqGSIb3DQEBBQUAA4GBAJ7pg/cN0kamudjW
# OI+buBxShdr7v6aI4lO6EX1fhuDxowa/shZJofYaEBskV2aW6TQwfEHsZ0YB9Q37
# JYvS6a1d7OJmKLKEpRSOWbnhdBwGXq/6aILKRJaGHeyGYmkfPqLMVG0t20iDCrXm
# 0qZdzzik1m54rkkM9/IRv0RvpKM2MYIEDTCCBAkCAQEwgZMwfDELMAkGA1UEBhMC
# VVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNV
# BAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjEmMCQGA1UEAxMdTWljcm9zb2Z0IFRp
# bWUtU3RhbXAgUENBIDIwMTACEzMAAAG0+4AIRAXSLfoAAQAAAbQwDQYJYIZIAWUD
# BAIBBQCgggFKMBoGCSqGSIb3DQEJAzENBgsqhkiG9w0BCRABBDAvBgkqhkiG9w0B
# CQQxIgQgwW8t7dagZPIlzgJEDHiHfH3h6SWHLF9r6nzOknWiDCYwgfoGCyqGSIb3
# DQEJEAIvMYHqMIHnMIHkMIG9BCDTyPd75qMwcAZRcb36/6xJa3hT0eLse71ysdp4
# twH3BjCBmDCBgKR+MHwxCzAJBgNVBAYTAlVTMRMwEQYDVQQIEwpXYXNoaW5ndG9u
# MRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVNaWNyb3NvZnQgQ29ycG9yYXRp
# b24xJjAkBgNVBAMTHU1pY3Jvc29mdCBUaW1lLVN0YW1wIFBDQSAyMDEwAhMzAAAB
# tPuACEQF0i36AAEAAAG0MCIEIJtQDKJkZuBfHo4RMXsI1W6s8cck+llhnu/J1csb
# 3e/gMA0GCSqGSIb3DQEBCwUABIICAE5WoVn3Be8ZS3Zx9TMqJXLaqI6A9Vv06wrd
# 36Xq8xJ7uWOq2n32/AkEzU9P4xb6M6wH/+GhWC9GPmOcYnowdWinq2GdQUlz6X+/
# aoJZjdA5NcOmBUA1Rm/ShrB4qaqTGnyoPMaayqoZACX+hJEKU5SlS9tL+M03WmPp
# GIVs4zghqAyZj1xXpiDv5AIyHmQpn36UD8QQAhByo/l0cJOzKBFDZZp7ssZiwnNY
# Xfo9oqOV1iFKLK5b3OlE7rsabW0lQFwxMWPifcJ6uHrL8DV1CsCbPZrQESdjirfs
# O3pX2uvmO0IvkgtJdk/Xf2VcipqQJvuzS7xROsAqn96RI4l+uPaCcJ0pXIJ4/b93
# D3Kzef9e2+YRvW53WLvXElVTfFXSmAO60D/XQKQyhct/wWVzKGsObUB7ES2aV9g3
# HKbAJOPTIBsepK+71y9nQHFcWFFdDtwAIw9iR1Sr3oBDZHiDeytcLrCxIoo/AzxW
# scqg+HezbHm0/tLPLS7u7+80/UwI8Zei+PGcIiUzNIkLhUTNF4xSiYmW6N0RBvz4
# PXaGbk42kdpezJihtfAFerRHHT+L5+wqSNDLhR0uRl4niE1wQq+cI5XMwqAO2k1x
# Xi+BTgcQFip953l6Of3O9Yu4cjtt2/MFkCvsPmiQAW03crdR7/UqRbfN+ZSuscRM
# H7m7zsdt
# SIG # End signature block
