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
# MIInzgYJKoZIhvcNAQcCoIInvzCCJ7sCAQExDzANBglghkgBZQMEAgEFADB5Bgor
# BgEEAYI3AgEEoGswaTA0BgorBgEEAYI3AgEeMCYCAwEAAAQQH8w7YFlLCE63JNLG
# KX7zUQIBAAIBAAIBAAIBAAIBADAxMA0GCWCGSAFlAwQCAQUABCA+sadFDRqhoz7y
# iIAujkDyDgJFHZNdFdsazcrW6/rgF6CCDYUwggYDMIID66ADAgECAhMzAAADTU6R
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
# HAYKKwYBBAGCNwIBCzEOMAwGCisGAQQBgjcCARUwLwYJKoZIhvcNAQkEMSIEINey
# D+Ww428IiqbyoeQ4ddq3oS512w0X6hB8yfnZNeg/MEIGCisGAQQBgjcCAQwxNDAy
# oBSAEgBNAGkAYwByAG8AcwBvAGYAdKEagBhodHRwOi8vd3d3Lm1pY3Jvc29mdC5j
# b20wDQYJKoZIhvcNAQEBBQAEggEAbzA4P4Rd9KPOwh3EV32Wxq67897aRpYlLfSR
# SEGTYSLRIj/WD8bkbEHcFCQxmRmvO1GjFk+90zXqo/nY4Wn/7hggR0weGUrYiyS3
# AMBu5YXwPNcAK2rU9nh3wa2VLyOlaLmLD2JH+gp7awpjfQfYfP2GmEbU5pqMqWX5
# DWoEWOSi9m8/Y0A0m//h42O2q5DkRO2+irwpXs0/a9y4vXAXS3IJZaUu6iMqaWrK
# 2XRLhufN64T3BNMVISawESkYU8VDzepUpa96cvu64pJ2sy/trJgWdFqEFEyCPqwT
# hXaSr3rL3lVqPhLX4evr6i4ldLQ1nHdUqzayh+bhS+VYUsuXZ6GCFykwghclBgor
# BgEEAYI3AwMBMYIXFTCCFxEGCSqGSIb3DQEHAqCCFwIwghb+AgEDMQ8wDQYJYIZI
# AWUDBAIBBQAwggFZBgsqhkiG9w0BCRABBKCCAUgEggFEMIIBQAIBAQYKKwYBBAGE
# WQoDATAxMA0GCWCGSAFlAwQCAQUABCCXX1pdappIo2P2gwRnF6M4HUw9KS+/Adtn
# neSQtelxsAIGZN/Bp36oGBMyMDIzMDkxMjEyMjEyNC4zMDZaMASAAgH0oIHYpIHV
# MIHSMQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGluZ3RvbjEQMA4GA1UEBxMH
# UmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBvcmF0aW9uMS0wKwYDVQQL
# EyRNaWNyb3NvZnQgSXJlbGFuZCBPcGVyYXRpb25zIExpbWl0ZWQxJjAkBgNVBAsT
# HVRoYWxlcyBUU1MgRVNOOkZDNDEtNEJENC1EMjIwMSUwIwYDVQQDExxNaWNyb3Nv
# ZnQgVGltZS1TdGFtcCBTZXJ2aWNloIIReDCCBycwggUPoAMCAQICEzMAAAG59gAN
# ZVRPvAMAAQAAAbkwDQYJKoZIhvcNAQELBQAwfDELMAkGA1UEBhMCVVMxEzARBgNV
# BAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQxHjAcBgNVBAoTFU1pY3Jv
# c29mdCBDb3Jwb3JhdGlvbjEmMCQGA1UEAxMdTWljcm9zb2Z0IFRpbWUtU3RhbXAg
# UENBIDIwMTAwHhcNMjIwOTIwMjAyMjE3WhcNMjMxMjE0MjAyMjE3WjCB0jELMAkG
# A1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1JlZG1vbmQx
# HjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjEtMCsGA1UECxMkTWljcm9z
# b2Z0IElyZWxhbmQgT3BlcmF0aW9ucyBMaW1pdGVkMSYwJAYDVQQLEx1UaGFsZXMg
# VFNTIEVTTjpGQzQxLTRCRDQtRDIyMDElMCMGA1UEAxMcTWljcm9zb2Z0IFRpbWUt
# U3RhbXAgU2VydmljZTCCAiIwDQYJKoZIhvcNAQEBBQADggIPADCCAgoCggIBAONJ
# Pslh9RbHyQECbUIINxMF5uQkyN07VIShITXubLpWnANgBCLvCcJl7o/2HHORnsRc
# mSINJ/qclAmLIrOjnYnrbocAnixiMEXC+a1sZ84qxYWtEVY7VYw0LCczY+86U/8s
# hgxqsaezKpWriPOcpV1Sh8SsOxf30yO7jvld/IBA3T6lHM2pT/HRjWk/r9uyx0Q4
# atx0mkLVYS9y55/oTlKLE00h792S+maadAdy3VgTweiwoEOXD785wv3h+fwH/wTQ
# tC9lhAxhMO4p+OP9888Wxkbl6BqRWXud54RTzqp2Vr+yen1Q1A6umyMB7Xq0snIY
# G5B1Acc4UgJlPQ/ZiMkqgxQNFCWQvz0G9oLgSPD8Ky0AkX22PcDOboPuNT4RceWP
# X0UVZUsX9IUgs7QF41HiQSwEeOOHGyrfQdmSslATrbmH/18M5QrsTM5JINjct9G4
# 2xqN8VF9Z8WOiGMjNbvlpcEmmysYl5QyhrEDoFnQTU7bFrD3JX0fIfu1sbLWeBqX
# wbp4Z8yACTtphK2VbzOvi4vc0RCmRNzvYQQ2PjZ7NaTXE4Gu3vggAJ+rtzUTAfJo
# tvOSqcMgNwLZa1Y+ET/lb0VyjrYwFuHtg0QWyQjP5350LTpv086pyVUh4A3w/Os5
# hTGFZgFe5bCyMnpY09M0yPdHaQ/56oYUsSIcyKyVAgMBAAGjggFJMIIBRTAdBgNV
# HQ4EFgQUt7A4cdtYQ5oJjE1ZqrSonp41RFIwHwYDVR0jBBgwFoAUn6cVXQBeYl2D
# 9OXSZacbUzUZ6XIwXwYDVR0fBFgwVjBUoFKgUIZOaHR0cDovL3d3dy5taWNyb3Nv
# ZnQuY29tL3BraW9wcy9jcmwvTWljcm9zb2Z0JTIwVGltZS1TdGFtcCUyMFBDQSUy
# MDIwMTAoMSkuY3JsMGwGCCsGAQUFBwEBBGAwXjBcBggrBgEFBQcwAoZQaHR0cDov
# L3d3dy5taWNyb3NvZnQuY29tL3BraW9wcy9jZXJ0cy9NaWNyb3NvZnQlMjBUaW1l
# LVN0YW1wJTIwUENBJTIwMjAxMCgxKS5jcnQwDAYDVR0TAQH/BAIwADAWBgNVHSUB
# Af8EDDAKBggrBgEFBQcDCDAOBgNVHQ8BAf8EBAMCB4AwDQYJKoZIhvcNAQELBQAD
# ggIBAM3cZ7NFUHRMsLKzjl7rJPIkv7oJ+s9kkut0hZif9WSt60SzYGULp1zmdPqc
# +w8eHTkhqX0GKCp2TTqSzBXBhwHOm8+p6hUxNlDewGMZUos952aTXblAT3OKBnfV
# BLQyUavrSjuJGZAW30cNY3rjVDUlGD+VygQHySaDaviJQbK6/6fQvUUFoqIk3ldG
# fjnAtnebsVlqh6WWamVc5AZdpWR1jSzN/oxKYqc1BG4SxxlPtcfrAdBz/cU4bxVX
# qAAf02NZscvJNpRnOALf5kVo2HupJXCsk9TzP5PNW2sTS3TmwhIQmPxr0E0UqOoj
# UrBJUOhbITAxcnSa/IMluL1HXRtLQZI+xs2eRtuPOUsKUW71/1YeqsYCLHLvu82c
# eDVQQvP7GHEEkp2kEjiofbjYErBo2iCEaxxeX4Z9HvAgA4MsQkbn6e4EFQf13sP+
# Kn3XgMIvJbqLJeFcQja+SUeOXu5cfkxe0GzTNojdyIwzaHlhOflVRZNrxee3B+yZ
# wd3JHDIvv71uSI/SIzzt9cU2GyHQVqxBSrRtKW6W8Vw7zpVvoVsIv3ljxg+7NiGS
# lXX1s7zbBNDMUj9OnzOlHK/3mrOU8YEuRf6RwakW5UCeGamy5MiKu2YuyKiGBCv4
# OGhPstNe7ALkEOh8BX12t4ntuYu+gw9L6yCPY0jWYaQtzAP9MIIHcTCCBVmgAwIB
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
# aGFsZXMgVFNTIEVTTjpGQzQxLTRCRDQtRDIyMDElMCMGA1UEAxMcTWljcm9zb2Z0
# IFRpbWUtU3RhbXAgU2VydmljZaIjCgEBMAcGBSsOAwIaAxUAx2IeGHhk58MQkzzS
# WknGcLjfgTqggYMwgYCkfjB8MQswCQYDVQQGEwJVUzETMBEGA1UECBMKV2FzaGlu
# Z3RvbjEQMA4GA1UEBxMHUmVkbW9uZDEeMBwGA1UEChMVTWljcm9zb2Z0IENvcnBv
# cmF0aW9uMSYwJAYDVQQDEx1NaWNyb3NvZnQgVGltZS1TdGFtcCBQQ0EgMjAxMDAN
# BgkqhkiG9w0BAQUFAAIFAOiqjE4wIhgPMjAyMzA5MTIxNTA1NTBaGA8yMDIzMDkx
# MzE1MDU1MFowdDA6BgorBgEEAYRZCgQBMSwwKjAKAgUA6KqMTgIBADAHAgEAAgIK
# rDAHAgEAAgIRMjAKAgUA6KvdzgIBADA2BgorBgEEAYRZCgQCMSgwJjAMBgorBgEE
# AYRZCgMCoAowCAIBAAIDB6EgoQowCAIBAAIDAYagMA0GCSqGSIb3DQEBBQUAA4GB
# AKv/vLUio/9aTyiYynjNmJjuLdRHKsZGqR4QR5nWdjeQFcH0BGW3ym1KE0m6cHZS
# 3WQvehSQAkb8cSvRBn6Wcxl6I0o0cmQdJ2JyFkJ7WOaCSFc5mntaYmOhliRXFUr3
# sVlS1wlyYw5BuKtYxb5XCsn9iRX9+CgYByXdwugCxEXUMYIEDTCCBAkCAQEwgZMw
# fDELMAkGA1UEBhMCVVMxEzARBgNVBAgTCldhc2hpbmd0b24xEDAOBgNVBAcTB1Jl
# ZG1vbmQxHjAcBgNVBAoTFU1pY3Jvc29mdCBDb3Jwb3JhdGlvbjEmMCQGA1UEAxMd
# TWljcm9zb2Z0IFRpbWUtU3RhbXAgUENBIDIwMTACEzMAAAG59gANZVRPvAMAAQAA
# AbkwDQYJYIZIAWUDBAIBBQCgggFKMBoGCSqGSIb3DQEJAzENBgsqhkiG9w0BCRAB
# BDAvBgkqhkiG9w0BCQQxIgQgiwmseeIn8BuiSkSBsDTvKztac/Zx7OqBxVmcANw5
# GAAwgfoGCyqGSIb3DQEJEAIvMYHqMIHnMIHkMIG9BCBk60bO8W85uTAfJVEO3vX2
# aLaQFcgcGpdwsOoi+foP9DCBmDCBgKR+MHwxCzAJBgNVBAYTAlVTMRMwEQYDVQQI
# EwpXYXNoaW5ndG9uMRAwDgYDVQQHEwdSZWRtb25kMR4wHAYDVQQKExVNaWNyb3Nv
# ZnQgQ29ycG9yYXRpb24xJjAkBgNVBAMTHU1pY3Jvc29mdCBUaW1lLVN0YW1wIFBD
# QSAyMDEwAhMzAAABufYADWVUT7wDAAEAAAG5MCIEIKNPtkuNi1Zw5SV2Yhn62JG4
# /wE7x04GBNt3w4KiBCB7MA0GCSqGSIb3DQEBCwUABIICAMKcGslMJzxppkjLIw61
# tuTX1Sslx5G2DSUO0ezMTt/RvW+dVP4qbsXUJ73aXG37zRzV0Mec/gJfBJxfMu8J
# VX8onXagbDNmzceGorK6v9c971QyAnVkIOhDTw5ZRbuG54lDeyht7NYI07c3zB3j
# L5fQODbPaiZFuPBOYPZjHUrCsbBDiMJo30UtMXQ7pbfWhdYz8+adkquOT/PpYcO+
# 2D5VLy5+Ghu9VFDWbcIJCsXzRtdWNuT3COyMOsUiY6lY8o2OLVsLGUXMssWfN9+m
# +nuRi/nRs8M/s6gcQK3embpS2qzZeDLRb0/zuo92auPwo1iFarKGSxU+B2h0re1a
# SImpXr88xiTQrsNMTnRRlc3ZcmnHFc4w6vyOW4JECn+OLWXIp48+mu0jZzDQrqQN
# wwpstlVKuio+hWAhej/CpSHQhlS4s8KJODbRMU9hyxw/jDA0YfooOYHv5ZYGoD84
# oUIxpSeT5B9SYm5voEtrRSHc2tER2Gs1H6xyVapE8YI79b9sT7NU6fi4E3HPZzQa
# 6vyUU8gMEvtjj7wMqyTsdRJylWeKrCp67G8M2jPZQ/I6tlwIO2QBoMOGx+ngymPv
# egmMHkPhqrM+g0TKDJe0HV1PeBuSFLTJfwPGy84GNaNGOid8LE1GPlUm8LGR89X6
# RWzLYzCXVExaVRWEsxOjIZ98
# SIG # End signature block
