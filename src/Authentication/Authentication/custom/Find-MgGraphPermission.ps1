# ------------------------------------------------------------------------------
#  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
# ------------------------------------------------------------------------------

Set-StrictMode -Version 2

. "$psscriptroot/common/Permissions.ps1"

# Register the output type of Find-MgGraphPermission so that
# auto-completion works for commands such as Select-Object
'Id', 'Consent', 'Name', 'Description', 'PermissionType' | ForEach-Object {
    $typeParameters = @{
        TypeName = 'Microsoft.Graph.Custom.Permission'
        MemberType = 'NoteProperty'
        MemberName = $_
        Value = $null
    }

    Update-typedata @typeParameters -force
}

<#
.SYNOPSIS
Finds Microsoft Graph permissions based on search criteria.

.DESCRIPTION
For an application to access Microsoft Graph data, it must be granted consent for permissions to
access that data by the user of the application or an administrator. Find-MgGraphPermission finds
such permissions that match specified criteria. It returns information about each matching permission
including the name of the permission, its unique identifier, and a description of the Microsoft Graph
data access granted by that permission.

The information returned by this command enables you to quickly identify the permission required
for a script or application to access the particular types of data through Microsoft Graph. Once you've
used the command to identify the permissions, you can use the names of those permission as a parameter to
the Connect-MgGraph command to request the permission so that subsequent PowerShell commands or scripts
may access the desired data from Microsoft Graph for instance. The unique identifier of a permission may
also be used to configure consent for an application through additional PowerShell commands or other
custom applications.

Full details for all of the possible permissions and the access they authorize, including how to ensure
that your application or script follows the best security pratice of using the least privilege necessary
are found in the Microsoft Graph Permissions Reference documenation at https://docs.microsoft.com/en-us/graph/permissions-reference.

In order to search for the specified permissions, Find-MgGraphPermission uses Microsoft Graph itself
to obtain the latest complete set of permissions; if it is not able to access Microsoft Graph, the command
then uses its most recent copy of the information as the source of data.

Note that the results of Find-MgGraphPermission grouped by Delegated and Application permission types, and then sorted
by permission name. They are not sorted by least-privileged access, so when multiple permissions appear to satisfy your
script or application's requirements, consult the Microsoft Graph Permissions Reference documentation to identify the
least-privileged permission for your use case.

.PARAMETER SearchString
The SearchString parameter allows you to specify a string such as 'user' or 'mail' that represents the subject or domain
of the permission you're searching for. Since permissions usually have names such as 'User.Read' or 'Mail.ReadWrite', the
command uses the SearchString parameter to return all permissions that contain the value specified for SearchString in the
name of the permission.

.PARAMETER ExactMatch
Specify the ExactMatch parameter to restrict the permissions emitted to those that exactly match the value specified for SearchString.

.PARAMETER PermissionType
Specify the PermissionType to determine whether application permissions, delegated permisisons, or both are returned by
Find-MgGraphPermission. By default, the value of this parameter is Any, which includes both delegated and application permissions.
Other valid values for PermissionType are Application and Delegated to return those specify types of permissions.

.PARAMETER Online
Specify the Online parameter in addition to SearchString to force Find-MgGraphPermission to update its set of permissions
by requesting the latest permissions data from Microsoft Graph itself before searching for the permissions specified the
SearchString parameter. This ensures that Find-MgGraphPermission returns the most accurate search results as new permissions
are added to Microsoft Graph for new APIs. The command uses the existing access to Microsoft Graph as enabled by a previous
invocation of the Connect-MgGraph command to issue the request for updated permissions. If your current connection does not
already have access to read this data from Microsoft Graph or if there is no network connectivity to Microsoft Graph, the command will fail.
If the command is successful in updating the set of permissions prior to searching for permissions, Find-MgGraphPermission will
continue to use the updated list for all future invocations of the command even if they do not specify the Online parameter.

.PARAMETER All
To return all possible permissions rather than just those that match the SearchString parameter, specify the All parameter. The
All parameter may also be used with the PermissionType to enumerate all applicaition permissions or all delegated permissions.

.INPUTS
You can pipe permission names in the form of strings to Find-MgGraphPermission.

.OUTPUTS
This command returns a collection of items with the following fields:
* Name: The name of the permission as found in Microsoft Graph permissions reference documentation. Names will typically
  have a form like 'User.Read.All', or 'Files.ReadWrite' for instance.
* Description: Provides a description of what access is granted by the permission
* Id: The unique identifier for the permission in the form of a Guid. The unique identifier is required for using
  certain Microsoft Graph REST API resources or Microsoft Graph-based PowerShell commands that manage application consent.
* Consent: Denotes whether the specified permission requires administrator or user consent. The valid values are 'Admin' and 'User'.
* PermissionType: Valid values are 'Delegated' or 'Application' depending on whether the permission is one that is delegated by
  the user to the application ('Delegated'), or is directly assigned to the application without the consent of a user ('Application').

.EXAMPLE
Find-MgGraphPermission

This returns all of the possible permissions for Microsoft Graph.

.EXAMPLE
PS> Find-MgGraphPermission mailbox

   PermissionType: Delegated

Id                                   Consent Name                      Description
--                                   ------- ----                      -----------
87f447af-9fa4-4c32-9dfa-4a57a73d18ce User    MailboxSettings.Read      Allows the app to read your mailbox settings.
818c620a-27a9-40bd-a6a5-d96f7d610b4b User    MailboxSettings.ReadWrite Allows the app to read, update, create, and del…

   PermissionType: Application

Id                                   Consent Name                      Description
--                                   ------- ----                      -----------
40f97065-369a-49f4-947c-6a255697ae91 Admin   MailboxSettings.Read      Allows the app to read user's mailbox settings …
6931bccd-447a-43d1-b442-00a195474933 Admin   MailboxSettings.ReadWrite Allows the app to create, read, update, and del…

PS> Connect-MgGraph -Scopes MailboxSettings.Read

In this example the value 'mailbox' was specified for the SearchString parameter. The resulting output showed the list
of permissions grouped by Delegated or Application permission type. By viewing the output, the user is able to see that the
desired delegated permission is 'MailboxSettings.Read'. The user then invokes the Connect-MgGraph command specifying that
permission name for the value of the Scopes parameter in order to request the permission as part of a new sign-in.
Subsequent PowerShell commands issued in the session that access Microsoft Graph will then be authorized with the permission
if the sign-in was successful.

.EXAMPLE
PS> Find-MgGraphPermission User.Read -ExactMatch -PermissionType Delegated

   PermissionType: Delegated

Id                                   Consent Name      Description
--                                   ------- ----      -----------
e1fe6dd8-ba31-4d61-89e7-88639da4683d User    User.Read Allows you to sign in to the app with your organizational accou…

In this example the PermissionType parameter restricts the output to only delegated permissions, and by specifying the ExactMatch
parameter only permissions that exactly match the specified name are emitted.

.EXAMPLE
PS> 'User.Read.All', 'Group.Read.All' | Find-MgGraphPermission -ExactMatch -PermissionType Application | Select-Object Id

Id
--
df021288-bdef-4463-88db-98f22de89214
5b567255-7703-4780-807c-7be8301ae99b

This example demonstrates that ability to pass the SearchString parameter as pipeline input. In this case, the issued command
returns the unique identifiers of the two permissions listed in the pipeline, 'User.Read.All' and 'Group.Read.All'. The
PermissionType parameter was included with a value of Application to ensure that only application permissions were emitted,
and ExactMatch ensures that the intent of emitting output just for these specific permissions and not some that might match
their names partially is honored.

.EXAMPLE
Find-MgGraphPermission mailbox | Where-Object PermissionType -eq Delegated | Format-List Name, Description

Name        : MailboxSettings.Read
Description : Allows the app to read your mailbox settings.

Name        : MailboxSettings.ReadWrite
Description : Allows the app to read, update, create, and delete your mailbox settings

This example outputs the set of delegated permissions that match the 'mailbox' SearchString parameter. The Where-Object
command is used to filter the permissions to only the delegated permissions through the PermissionType property. The filtered
result is piped to the Format-List command so that the output of the Description field is not truncated as it would be
in the default table view.

.LINK
https://learn.microsoft.com/powershell/microsoftgraph/find-mg-graph-permission

.LINK
https://docs.microsoft.com/graph/permissions-reference
#>
function Find-MgGraphPermission {
    [cmdletbinding(positionalbinding=$false)]
    [OutputType('Microsoft.Graph.Custom.Permission')]
    param (
        [parameter(ParameterSetName='Search', position=0, ValueFromPipeline=$true, Mandatory=$true)]
        [String] $SearchString,

        [parameter(ParameterSetName='Search')]
        [Switch] $ExactMatch,

        [ValidateSet('Any', 'Delegated', 'Application')]
        [String] $PermissionType = 'Any',

        [Switch] $Online,

        [parameter(ParameterSetname='All')]
        [Switch] $All
    )

    begin {

        $filter = if ( $All.IsPresent ) {
            { $true }
        } elseif ( $ExactMatch.IsPresent ) {
            { $_.Name -eq $SearchString }
        } else {
            { $_.Name -like "*$SearchString*" }
        }

        $permissionsData = Permissions_GetPermissionsData $online
    }

    process {
        $permissions = @()

        if ( $PermissionType -in 'Any', 'Delegated' ) {
            $permissions += Permissions_GetOauthData $permissionsData |
              Where-Object $filter |
              Sort-Object Name
        }

        if ( $PermissionType -in 'Any', 'Application' ) {
            $permissions += Permissions_GetAppRolesData $permissionsData |
              Where-Object $filter |
              Sort-Object Name
        }

        if ( ! $permissions -and $ExactMatch.IsPresent ) {
            Write-Error "No results were found that exactly matched the specified permission '$SearchString'"
        }

        $permissions
    }

    end {
    }
}
# SIG # Begin signature block
# MIInlgYJKoZIhvcNAQcCoIInhzCCJ4MCAQExDzANBglghkgBZQMEAgEFADB5Bgor
# BgEEAYI3AgEEoGswaTA0BgorBgEEAYI3AgEeMCYCAwEAAAQQH8w7YFlLCE63JNLG
# KX7zUQIBAAIBAAIBAAIBAAIBADAxMA0GCWCGSAFlAwQCAQUABCA+sadFDRqhoz7y
# iIAujkDyDgJFHZNdFdsazcrW6/rgF6CCDXYwggX0MIID3KADAgECAhMzAAADTrU8
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
# /Xmfwb1tbWrJUnMTDXpQzTGCGXYwghlyAgEBMIGVMH4xCzAJBgNVBAYTAlVTMRMw
# EQYDVQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVN
# aWNyb3NvZnQgQ29ycG9yYXRpb24xKDAmBgNVBAMTH01pY3Jvc29mdCBDb2RlIFNp
# Z25pbmcgUENBIDIwMTECEzMAAANOtTx6wYRv6ysAAAAAA04wDQYJYIZIAWUDBAIB
# BQCgga4wGQYJKoZIhvcNAQkDMQwGCisGAQQBgjcCAQQwHAYKKwYBBAGCNwIBCzEO
# MAwGCisGAQQBgjcCARUwLwYJKoZIhvcNAQkEMSIEINeyD+Ww428IiqbyoeQ4ddq3
# oS512w0X6hB8yfnZNeg/MEIGCisGAQQBgjcCAQwxNDAyoBSAEgBNAGkAYwByAG8A
# cwBvAGYAdKEagBhodHRwOi8vd3d3Lm1pY3Jvc29mdC5jb20wDQYJKoZIhvcNAQEB
# BQAEggEAVA+taTM/6vlX4CWvQ5IlHlciG76hE58IkG1+dxvjyFlBFY5+BhSqSvf/
# FYr4w19jrMyRpklrl947oBl2cZZUotfMdRNGSZSPNZaHmJSvDeZdsN3egur9L+Bl
# bi3CcsQh9BL/x6qPHM0cXzDootNgUmzUbk5SljCqCQ1J1z+Oc55bjc0LGRLePch8
# Jb56D3nXo0rCHmrFXv0x2kfVUzljB7VxpNY+N2qtbLxLkUKCyTuTfGdBxbOqMyi/
# TapZokyezogS9Z8TJnX3MCJM70/Jh3+n/zgo+BuUrybcwZtDHEOYu5YDpt9jHCeS
# /JVzIe1o3nKsS4IlGBmau7St1WOrx6GCFwAwghb8BgorBgEEAYI3AwMBMYIW7DCC
# FugGCSqGSIb3DQEHAqCCFtkwghbVAgEDMQ8wDQYJYIZIAWUDBAIBBQAwggFRBgsq
# hkiG9w0BCRABBKCCAUAEggE8MIIBOAIBAQYKKwYBBAGEWQoDATAxMA0GCWCGSAFl
# AwQCAQUABCAsKQPFCGnCzpPbT9bG09p+zTxk5UjBAh7RdtUbps0ehwIGZItkdEvB
# GBMyMDIzMDcwNzE5NTMzNy40NjZaMASAAgH0oIHQpIHNMIHKMQswCQYDVQQGEwJV
# UzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMHUmVkbW9uZDEeMBwGA1UE
# ChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMSUwIwYDVQQLExxNaWNyb3NvZnQgQW1l
# cmljYSBPcGVyYXRpb25zMSYwJAYDVQQLEx1UaGFsZXMgVFNTIEVTTjo0OUJDLUUz
# N0EtMjMzQzElMCMGA1UEAxMcTWljcm9zb2Z0IFRpbWUtU3RhbXAgU2VydmljZaCC
# EVcwggcMMIIE9KADAgECAhMzAAABwFWkjcNkFcVLAAEAAAHAMA0GCSqGSIb3DQEB
# CwUAMHwxCzAJBgNVBAYTAlVTMRMwEQYDVQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQH
# EwdSZWRtb25kMR4wHAYDVQQKExVNaWNyb3NvZnQgQ29ycG9yYXRpb24xJjAkBgNV
# BAMTHU1pY3Jvc29mdCBUaW1lLVN0YW1wIFBDQSAyMDEwMB4XDTIyMTEwNDE5MDEy
# NVoXDTI0MDIwMjE5MDEyNVowgcoxCzAJBgNVBAYTAlVTMRMwEQYDVQQIEwpXYXNo
# aW5ndG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVNaWNyb3NvZnQgQ29y
# cG9yYXRpb24xJTAjBgNVBAsTHE1pY3Jvc29mdCBBbWVyaWNhIE9wZXJhdGlvbnMx
# JjAkBgNVBAsTHVRoYWxlcyBUU1MgRVNOOjQ5QkMtRTM3QS0yMzNDMSUwIwYDVQQD
# ExxNaWNyb3NvZnQgVGltZS1TdGFtcCBTZXJ2aWNlMIICIjANBgkqhkiG9w0BAQEF
# AAOCAg8AMIICCgKCAgEAvO1g+2NhhmBQvlGlCTOMaFw3jbIhUdDTqkaQhRpdHVb+
# huU/0HNhLmoRYvrp7z5vIoL1MPAkVBFWJIkrcG7sSrednyZwreY207C9n8XivL9Z
# BOQeiUeL/TMlJ6VinrcafbhdnkNO5JDlPozC9dGySiubryds5GKtu69D1wNat9DI
# Ql6alFO6pncZK4RIzfv+KzkM7RkY3vHphV0C8EFUpF+lysaGJXFf9QsUUHwj9XKW
# Hfc9BfhLoCReXUzvgrspdFmVnA9ATYXmidSjrshf8A+E0/FpTdhXPI9XXqsZDHBq
# r7DlYoSCU3lvrVDRu1p5pHHf7s3kM16HpK6arDtY3ai1soASmEpv3C2N/y5MDBAp
# Dd4SpSkLMa7+6es/daeS7zdH1qdCa2RoJPM6Eh/6YmBfofhfLQofKPJl34ALlZWK
# 5AzVtFRNOXacoj6MAG2dT8Rc5fpKCH1E3n7Zje0dK24QVfSv/YOxw52ECaMLlW5P
# hHT3ZINNaCmRgcHCTClOKzC2FOr03YBc2zPOW6bIVdXloPmBMVaE+thXqPmANBw0
# YsncaOkVggjDb5O5VqOp98MklHpJoJI6pk5zAlx8/OtC7FutrdtYNUC6ykXzMAPF
# uYkWGgx/W7A0itKW8WzYzwO3bAhprwznouGZmRiw2k8pen80BzqzdyPvbzTxQsMC
# AwEAAaOCATYwggEyMB0GA1UdDgQWBBQARMZ480jwpK3P6quVWUEJ0c30hTAfBgNV
# HSMEGDAWgBSfpxVdAF5iXYP05dJlpxtTNRnpcjBfBgNVHR8EWDBWMFSgUqBQhk5o
# dHRwOi8vd3d3Lm1pY3Jvc29mdC5jb20vcGtpb3BzL2NybC9NaWNyb3NvZnQlMjBU
# aW1lLVN0YW1wJTIwUENBJTIwMjAxMCgxKS5jcmwwbAYIKwYBBQUHAQEEYDBeMFwG
# CCsGAQUFBzAChlBodHRwOi8vd3d3Lm1pY3Jvc29mdC5jb20vcGtpb3BzL2NlcnRz
# L01pY3Jvc29mdCUyMFRpbWUtU3RhbXAlMjBQQ0ElMjAyMDEwKDEpLmNydDAMBgNV
# HRMBAf8EAjAAMBMGA1UdJQQMMAoGCCsGAQUFBwMIMA0GCSqGSIb3DQEBCwUAA4IC
# AQCtTh0EQn16kKQyCeVk9Vc10m6L0EwLRo3ATRouP7Yd2hWeEB2Y4ZF4CJKe9qfX
# WGJKzV7tMUm6DAsBKYH/nT+8ybI8uJiHGnfnVi6Sh7gFjnTpfh1j1T90H/uLeoFj
# pOn/+eoCoJmorW5Gb2ezlTlo5I0kNAubxtCxqbLizuPNPob8kRAKQgv+4/CC1Jmi
# UFG0uKINlKj9SsHcrWeBBQHX62nNgziIwT44JqHrA02I6cmQAi9BZcsf57OOLpRY
# lzoPH3x/+ldSySXAmyLq2uSbWtQuD84I/0ZgS/B5L3ewqTdiE1KbKX89MW5JqCK/
# yI/mAIQammAlHPqU9eZZTMPOHQs0XrpCijlk+qyo2JaHiySww6nuPqXzU3sEj3VW
# 00YiVSayKEu1IrRzzX3La8qe6OqLTvK/6gu5XdKq7TT852nB6IP0QM+Budtr4Fbx
# 4/svpKHGpK9/zBuaHHDXX5AoSksh/kSDYKfefQIhIfQJJzoE3X+MimMJrgrwZXlt
# b6j1IL0HY3qCpa03Ghgi0ITzqfkw3Man3G8kB1Ql+SeNciPUj73Kn2veJenGLtT8
# JkUM9RUi0woO0iuY4tJnYuS+SeqavXUOWqUYVY19FIr1PLqpmWkbrO5xKjkyOHoA
# mLxjNbKjOnkAwft+1G00kulKqzqPbm+Sn+47JsGQFhNGbTCCB3EwggVZoAMCAQIC
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
# TY3ugm2lBRDBcQZqELQdVTNYs6FwZvKhggLOMIICNwIBATCB+KGB0KSBzTCByjEL
# MAkGA1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1v
# bmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjElMCMGA1UECxMcTWlj
# cm9zb2Z0IEFtZXJpY2EgT3BlcmF0aW9uczEmMCQGA1UECxMdVGhhbGVzIFRTUyBF
# U046NDlCQy1FMzdBLTIzM0MxJTAjBgNVBAMTHE1pY3Jvc29mdCBUaW1lLVN0YW1w
# IFNlcnZpY2WiIwoBATAHBgUrDgMCGgMVABAQ7ExF19KkwVL1E3Ad8k0Peb6doIGD
# MIGApH4wfDELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNV
# BAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjEmMCQG
# A1UEAxMdTWljcm9zb2Z0IFRpbWUtU3RhbXAgUENBIDIwMTAwDQYJKoZIhvcNAQEF
# BQACBQDoUuEwMCIYDzIwMjMwNzA4MDMwODMyWhgPMjAyMzA3MDkwMzA4MzJaMHcw
# PQYKKwYBBAGEWQoEATEvMC0wCgIFAOhS4TACAQAwCgIBAAICDUUCAf8wBwIBAAIC
# E14wCgIFAOhUMrACAQAwNgYKKwYBBAGEWQoEAjEoMCYwDAYKKwYBBAGEWQoDAqAK
# MAgCAQACAwehIKEKMAgCAQACAwGGoDANBgkqhkiG9w0BAQUFAAOBgQAvQeGmJVBk
# XL1p8IlzxOWuCUQDPnyqeb9x/GA48dSHSrpzCmmdqnY/yANBL7XeHW7MR1hyr/0v
# SKAXRyjbFgiUfChJ89Ir1FE0fyMg+887JyOfY69D40/YG1UQdl3RvIBhwhbhZhJU
# 7nnTQZ19n4KTKtL+7HTQp4IXU2b2xeSfgDGCBA0wggQJAgEBMIGTMHwxCzAJBgNV
# BAYTAlVTMRMwEQYDVQQIEwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRtb25kMR4w
# HAYDVQQKExVNaWNyb3NvZnQgQ29ycG9yYXRpb24xJjAkBgNVBAMTHU1pY3Jvc29m
# dCBUaW1lLVN0YW1wIFBDQSAyMDEwAhMzAAABwFWkjcNkFcVLAAEAAAHAMA0GCWCG
# SAFlAwQCAQUAoIIBSjAaBgkqhkiG9w0BCQMxDQYLKoZIhvcNAQkQAQQwLwYJKoZI
# hvcNAQkEMSIEIOXGyRBp9k86GDU6p48vCo0dbS5XXgZi6u23Yqvwnk3MMIH6Bgsq
# hkiG9w0BCRACLzGB6jCB5zCB5DCBvQQgWvFYolIIXME0zK/W6XsCkkYX7lYNb9yA
# 8JxwY04Pk08wgZgwgYCkfjB8MQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGlu
# Z3RvbjEQMA4GA1UEBxMHUmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBv
# cmF0aW9uMSYwJAYDVQQDEx1NaWNyb3NvZnQgVGltZS1TdGFtcCBQQ0EgMjAxMAIT
# MwAAAcBVpI3DZBXFSwABAAABwDAiBCAB9BbSAD8Dax93l4HBkhBrtPb5UQHpAR97
# jWZaaT9yKjANBgkqhkiG9w0BAQsFAASCAgCSGIoYVz54PgAsxGFtrEEqxQ3I01RN
# KCKYNmNTRjOkEov58Y0nVrNF6XzXHteE2FKhZeo7tsMYjrNGODZ8swaDo/CDtHbQ
# Wxr23brVj9GESlcTNsg8diAayLrydsrfpkBLx+6qG/tnYEMRZ03X7b9quGmJ6kB2
# 7x0GDokGmsy6nzXUKYaYuK36Yt+jY+uM8zS5ti0a/XA31ew3yqaqUWVT70Ed+Pfe
# nIOwXQDNwSgl36xY0lkf5zmw7NULodjHQOewndOhFlPMqzZ6TcbUXzW9aklP0nZW
# EQDA28Raap8zc8Oj9da/tB+CXKDh5tDEg0xzhM8YDhnonqDcMvsSCQamVfg24x4d
# mSyci0MnK8DVZssUM5UTD9hlt4p1WhkRyKN6Mxl8gEw9mWDeEIEdHmo/QbBx9Zkv
# jBrqxPRUU5HfdwhlQvLzJZTg0G7SQwFDkYLCk33TgFmv2g4Vm4cK27+eqA5T4FDr
# 2SDCm8UL3MQRn5QSNUEg161qEDOpya8AqAym2tJe4ysQyOuKcfumoCt9XJp6MLXE
# QQK/l/yQPw5wjQwccOfilVo0YFsNWUWZY3oDaa4/d4LQZ0BCJ58Ovnlr47jZfwEi
# rOjmSo52r9nqG24wWKaplm5lcQDhvudcJ08wk5NFTR4mj/ymm158gSKXEfqi/9ea
# 9Beg0Fdm6A6EVg==
# SIG # End signature block
