---
external help file:
Module Name: Microsoft.Graph.Users.Actions
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.users.actions/reset-mguserauthenticationmethodpassword
schema: 2.0.0
---

# Reset-MgUserAuthenticationMethodPassword

## SYNOPSIS
Reset a user's password, represented by a password authentication method object.
This can only be done by an administrator with appropriate permissions and can't be performed on a user's own account.
This flow writes the new password to Microsoft Entra ID and pushes it to on-premises Active Directory if configured using password writeback.
The admin can either provide a new password or have the system generate one.
The user is prompted to change their password on their next sign in.
This reset is a long-running operation and returns a Location header with a link where the caller can periodically check for the status of the reset operation.

## SYNTAX

### ResetExpanded (Default)
```
Reset-MgUserAuthenticationMethodPassword -AuthenticationMethodId <String> -UserId <String>
 [-AdditionalProperties <Hashtable>] [-NewPassword <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Reset
```
Reset-MgUserAuthenticationMethodPassword -AuthenticationMethodId <String> -UserId <String>
 -BodyParameter <IPaths1KjcdupUsersUserIdAuthenticationMethodsAuthenticationmethodIdMicrosoftGraphResetpasswordPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ResetViaIdentity
```
Reset-MgUserAuthenticationMethodPassword -InputObject <IUsersActionsIdentity>
 -BodyParameter <IPaths1KjcdupUsersUserIdAuthenticationMethodsAuthenticationmethodIdMicrosoftGraphResetpasswordPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ResetViaIdentityExpanded
```
Reset-MgUserAuthenticationMethodPassword -InputObject <IUsersActionsIdentity>
 [-AdditionalProperties <Hashtable>] [-NewPassword <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Reset a user's password, represented by a password authentication method object.
This can only be done by an administrator with appropriate permissions and can't be performed on a user's own account.
This flow writes the new password to Microsoft Entra ID and pushes it to on-premises Active Directory if configured using password writeback.
The admin can either provide a new password or have the system generate one.
The user is prompted to change their password on their next sign in.
This reset is a long-running operation and returns a Location header with a link where the caller can periodically check for the status of the reset operation.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: ResetExpanded, ResetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AuthenticationMethodId
The unique identifier of authenticationMethod

```yaml
Type: System.String
Parameter Sets: Reset, ResetExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPaths1KjcdupUsersUserIdAuthenticationMethodsAuthenticationmethodIdMicrosoftGraphResetpasswordPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Reset, ResetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IUsersActionsIdentity
Parameter Sets: ResetViaIdentity, ResetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -NewPassword
.

```yaml
Type: System.String
Parameter Sets: ResetExpanded, ResetViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
The unique identifier of user

```yaml
Type: System.String
Parameter Sets: Reset, ResetExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IPaths1KjcdupUsersUserIdAuthenticationMethodsAuthenticationmethodIdMicrosoftGraphResetpasswordPostRequestbodyContentApplicationJsonSchema

### Microsoft.Graph.PowerShell.Models.IUsersActionsIdentity

## OUTPUTS

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPaths1KjcdupUsersUserIdAuthenticationMethodsAuthenticationmethodIdMicrosoftGraphResetpasswordPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[NewPassword <String>]`: 

`INPUTOBJECT <IUsersActionsIdentity>`: Identity Parameter
  - `[AuthenticationMethodId <String>]`: The unique identifier of authenticationMethod
  - `[CalendarId <String>]`: The unique identifier of calendar
  - `[ChatId <String>]`: The unique identifier of chat
  - `[ChatMessageId <String>]`: The unique identifier of chatMessage
  - `[ChatMessageId1 <String>]`: The unique identifier of chatMessage
  - `[ContentTypeId <String>]`: The unique identifier of contentType
  - `[DeviceLogCollectionResponseId <String>]`: The unique identifier of deviceLogCollectionResponse
  - `[DocumentSetVersionId <String>]`: The unique identifier of documentSetVersion
  - `[DriveId <String>]`: The unique identifier of drive
  - `[DriveItemId <String>]`: The unique identifier of driveItem
  - `[DriveItemVersionId <String>]`: The unique identifier of driveItemVersion
  - `[EventId <String>]`: The unique identifier of event
  - `[EventId1 <String>]`: The unique identifier of event
  - `[ListItemId <String>]`: The unique identifier of listItem
  - `[ListItemVersionId <String>]`: The unique identifier of listItemVersion
  - `[MailFolderId <String>]`: The unique identifier of mailFolder
  - `[MailFolderId1 <String>]`: The unique identifier of mailFolder
  - `[ManagedDeviceId <String>]`: The unique identifier of managedDevice
  - `[MessageId <String>]`: The unique identifier of message
  - `[NotebookId <String>]`: The unique identifier of notebook
  - `[OnenotePageId <String>]`: The unique identifier of onenotePage
  - `[OnenoteSectionId <String>]`: The unique identifier of onenoteSection
  - `[PermissionId <String>]`: The unique identifier of permission
  - `[PhoneAuthenticationMethodId <String>]`: The unique identifier of phoneAuthenticationMethod
  - `[SubscriptionId <String>]`: The unique identifier of subscription
  - `[TeamsAppInstallationId <String>]`: The unique identifier of teamsAppInstallation
  - `[TodoTaskId <String>]`: The unique identifier of todoTask
  - `[TodoTaskListId <String>]`: The unique identifier of todoTaskList
  - `[UserId <String>]`: The unique identifier of user

## RELATED LINKS

