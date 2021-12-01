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
https://docs.microsoft.com/en-us/graph/permissions-reference
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
