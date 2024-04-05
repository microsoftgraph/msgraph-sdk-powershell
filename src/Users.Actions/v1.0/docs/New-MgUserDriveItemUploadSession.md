---
external help file:
Module Name: Microsoft.Graph.Users.Actions
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.users.actions/new-mguserdriveitemuploadsession
schema: 2.0.0
---

# New-MgUserDriveItemUploadSession

## SYNOPSIS
Invoke action createUploadSession

## SYNTAX

### CreateExpanded (Default)
```
New-MgUserDriveItemUploadSession -DriveId <String> -DriveItemId <String> -UserId <String>
 [-AdditionalProperties <Hashtable>] [-Item <IMicrosoftGraphDriveItemUploadableProperties>]
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgUserDriveItemUploadSession -DriveId <String> -DriveItemId <String> -UserId <String>
 -BodyParameter <IPaths10ZzsxfUsersUserIdDrivesDriveIdItemsDriveitemIdMicrosoftGraphCreateuploadsessionPostRequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgUserDriveItemUploadSession -InputObject <IUsersActionsIdentity>
 -BodyParameter <IPaths10ZzsxfUsersUserIdDrivesDriveIdItemsDriveitemIdMicrosoftGraphCreateuploadsessionPostRequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgUserDriveItemUploadSession -InputObject <IUsersActionsIdentity> [-AdditionalProperties <Hashtable>]
 [-Item <IMicrosoftGraphDriveItemUploadableProperties>] [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action createUploadSession

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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IPaths10ZzsxfUsersUserIdDrivesDriveIdItemsDriveitemIdMicrosoftGraphCreateuploadsessionPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DriveId
The unique identifier of drive

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DriveItemId
The unique identifier of driveItem

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
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
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Item
driveItemUploadableProperties
To construct, see NOTES section for ITEM properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDriveItemUploadableProperties
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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

### -UserId
The unique identifier of user

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
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

### Microsoft.Graph.PowerShell.Models.IPaths10ZzsxfUsersUserIdDrivesDriveIdItemsDriveitemIdMicrosoftGraphCreateuploadsessionPostRequestbodyContentApplicationJsonSchema

### Microsoft.Graph.PowerShell.Models.IUsersActionsIdentity

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUploadSession

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPaths10ZzsxfUsersUserIdDrivesDriveIdItemsDriveitemIdMicrosoftGraphCreateuploadsessionPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Item <IMicrosoftGraphDriveItemUploadableProperties>]`: driveItemUploadableProperties
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Description <String>]`: Provides a user-visible description of the item. Read-write. Only on OneDrive Personal.
    - `[DriveItemSource <IMicrosoftGraphDriveItemSource>]`: driveItemSource
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <String>]`: driveItemSourceApplication
      - `[ExternalId <String>]`: The external identifier for the drive item from the source.
    - `[FileSize <Int64?>]`: Provides an expected file size to perform a quota check before uploading. Only on OneDrive Personal.
    - `[FileSystemInfo <IMicrosoftGraphFileSystemInfo>]`: fileSystemInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CreatedDateTime <DateTime?>]`: The UTC date and time the file was created on a client.
      - `[LastAccessedDateTime <DateTime?>]`: The UTC date and time the file was last accessed. Available for the recent file list only.
      - `[LastModifiedDateTime <DateTime?>]`: The UTC date and time the file was last modified on a client.
    - `[MediaSource <IMicrosoftGraphMediaSource>]`: mediaSource
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ContentCategory <String>]`: mediaSourceContentCategory
    - `[Name <String>]`: The name of the item (filename and extension). Read-write.

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

`ITEM <IMicrosoftGraphDriveItemUploadableProperties>`: driveItemUploadableProperties
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Description <String>]`: Provides a user-visible description of the item. Read-write. Only on OneDrive Personal.
  - `[DriveItemSource <IMicrosoftGraphDriveItemSource>]`: driveItemSource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <String>]`: driveItemSourceApplication
    - `[ExternalId <String>]`: The external identifier for the drive item from the source.
  - `[FileSize <Int64?>]`: Provides an expected file size to perform a quota check before uploading. Only on OneDrive Personal.
  - `[FileSystemInfo <IMicrosoftGraphFileSystemInfo>]`: fileSystemInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CreatedDateTime <DateTime?>]`: The UTC date and time the file was created on a client.
    - `[LastAccessedDateTime <DateTime?>]`: The UTC date and time the file was last accessed. Available for the recent file list only.
    - `[LastModifiedDateTime <DateTime?>]`: The UTC date and time the file was last modified on a client.
  - `[MediaSource <IMicrosoftGraphMediaSource>]`: mediaSource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ContentCategory <String>]`: mediaSourceContentCategory
  - `[Name <String>]`: The name of the item (filename and extension). Read-write.

## RELATED LINKS

