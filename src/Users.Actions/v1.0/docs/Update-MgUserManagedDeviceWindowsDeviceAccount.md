---
external help file:
Module Name: Microsoft.Graph.Users.Actions
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.users.actions/update-mgusermanageddevicewindowsdeviceaccount
schema: 2.0.0
---

# Update-MgUserManagedDeviceWindowsDeviceAccount

## SYNOPSIS
Not yet documented

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgUserManagedDeviceWindowsDeviceAccount -ManagedDeviceId <String> -UserId <String>
 [-AdditionalProperties <Hashtable>] [-ResponseHeadersVariable <String>]
 [-UpdateWindowsDeviceAccountActionParameter <IMicrosoftGraphUpdateWindowsDeviceAccountActionParameter>]
 [-Headers <IDictionary>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgUserManagedDeviceWindowsDeviceAccount -ManagedDeviceId <String> -UserId <String>
 -BodyParameter <IPaths1Q6DqpaUsersUserIdManageddevicesManageddeviceIdMicrosoftGraphUpdatewindowsdeviceaccountPostRequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgUserManagedDeviceWindowsDeviceAccount -InputObject <IUsersActionsIdentity>
 -BodyParameter <IPaths1Q6DqpaUsersUserIdManageddevicesManageddeviceIdMicrosoftGraphUpdatewindowsdeviceaccountPostRequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgUserManagedDeviceWindowsDeviceAccount -InputObject <IUsersActionsIdentity>
 [-AdditionalProperties <Hashtable>] [-ResponseHeadersVariable <String>]
 [-UpdateWindowsDeviceAccountActionParameter <IMicrosoftGraphUpdateWindowsDeviceAccountActionParameter>]
 [-Headers <IDictionary>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Not yet documented

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPaths1Q6DqpaUsersUserIdManageddevicesManageddeviceIdMicrosoftGraphUpdatewindowsdeviceaccountPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
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
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ManagedDeviceId
The unique identifier of managedDevice

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UpdateWindowsDeviceAccountActionParameter
updateWindowsDeviceAccountActionParameter
To construct, see NOTES section for UPDATEWINDOWSDEVICEACCOUNTACTIONPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUpdateWindowsDeviceAccountActionParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: Update, UpdateExpanded
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

### Microsoft.Graph.PowerShell.Models.IPaths1Q6DqpaUsersUserIdManageddevicesManageddeviceIdMicrosoftGraphUpdatewindowsdeviceaccountPostRequestbodyContentApplicationJsonSchema

### Microsoft.Graph.PowerShell.Models.IUsersActionsIdentity

### System.Collections.IDictionary

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPaths1Q6DqpaUsersUserIdManageddevicesManageddeviceIdMicrosoftGraphUpdatewindowsdeviceaccountPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[UpdateWindowsDeviceAccountActionParameter <IMicrosoftGraphUpdateWindowsDeviceAccountActionParameter>]`: updateWindowsDeviceAccountActionParameter
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CalendarSyncEnabled <Boolean?>]`: Not yet documented
    - `[DeviceAccount <IMicrosoftGraphWindowsDeviceAccount>]`: windowsDeviceAccount
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Password <String>]`: Not yet documented
    - `[DeviceAccountEmail <String>]`: Not yet documented
    - `[ExchangeServer <String>]`: Not yet documented
    - `[PasswordRotationEnabled <Boolean?>]`: Not yet documented
    - `[SessionInitiationProtocalAddress <String>]`: Not yet documented

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
  - `[OnlineMeetingId <String>]`: The unique identifier of onlineMeeting
  - `[PermissionId <String>]`: The unique identifier of permission
  - `[PhoneAuthenticationMethodId <String>]`: The unique identifier of phoneAuthenticationMethod
  - `[SubscriptionId <String>]`: The unique identifier of subscription
  - `[TeamsAppInstallationId <String>]`: The unique identifier of teamsAppInstallation
  - `[TodoTaskId <String>]`: The unique identifier of todoTask
  - `[TodoTaskListId <String>]`: The unique identifier of todoTaskList
  - `[UserId <String>]`: The unique identifier of user

`UPDATEWINDOWSDEVICEACCOUNTACTIONPARAMETER <IMicrosoftGraphUpdateWindowsDeviceAccountActionParameter>`: updateWindowsDeviceAccountActionParameter
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CalendarSyncEnabled <Boolean?>]`: Not yet documented
  - `[DeviceAccount <IMicrosoftGraphWindowsDeviceAccount>]`: windowsDeviceAccount
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Password <String>]`: Not yet documented
  - `[DeviceAccountEmail <String>]`: Not yet documented
  - `[ExchangeServer <String>]`: Not yet documented
  - `[PasswordRotationEnabled <Boolean?>]`: Not yet documented
  - `[SessionInitiationProtocalAddress <String>]`: Not yet documented

## RELATED LINKS

