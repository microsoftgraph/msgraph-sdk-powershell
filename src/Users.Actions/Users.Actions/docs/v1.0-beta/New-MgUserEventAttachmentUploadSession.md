---
external help file:
Module Name: Microsoft.Graph.Users.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.actions/new-mgusereventattachmentuploadsession
schema: 2.0.0
---

# New-MgUserEventAttachmentUploadSession

## SYNOPSIS
Invoke action createUploadSession

## SYNTAX

### CreateExpanded (Default)
```
New-MgUserEventAttachmentUploadSession -EventId <String> -UserId <String> [-AdditionalProperties <Hashtable>]
 [-AttachmentItem <IMicrosoftGraphAttachmentItem>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgUserEventAttachmentUploadSession -EventId <String> -UserId <String>
 -BodyParameter <IPaths1Ly1W91UsersUserIdEventsEventIdAttachmentsMicrosoftGraphCreateuploadsessionPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgUserEventAttachmentUploadSession -InputObject <IUsersActionsIdentity>
 -BodyParameter <IPaths1Ly1W91UsersUserIdEventsEventIdAttachmentsMicrosoftGraphCreateuploadsessionPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgUserEventAttachmentUploadSession -InputObject <IUsersActionsIdentity>
 [-AdditionalProperties <Hashtable>] [-AttachmentItem <IMicrosoftGraphAttachmentItem>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Invoke action createUploadSession

## EXAMPLES

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

### -AttachmentItem
attachmentItem
To construct, please use Get-Help -Online and see NOTES section for ATTACHMENTITEM properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAttachmentItem
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
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPaths1Ly1W91UsersUserIdEventsEventIdAttachmentsMicrosoftGraphCreateuploadsessionPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -EventId
key: id of event

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

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

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

### -UserId
key: id of user

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

### Microsoft.Graph.PowerShell.Models.IPaths1Ly1W91UsersUserIdEventsEventIdAttachmentsMicrosoftGraphCreateuploadsessionPostRequestbodyContentApplicationJsonSchema

### Microsoft.Graph.PowerShell.Models.IUsersActionsIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUploadSession

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ATTACHMENTITEM <IMicrosoftGraphAttachmentItem>: attachmentItem
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AttachmentType <String>]`: attachmentType
  - `[ContentId <String>]`: The CID or Content-Id of the attachment for referencing in case of in-line attachments using <img src='cid:contentId'> tag in HTML messages. Optional.
  - `[ContentType <String>]`: The nature of the data in the attachment. Optional.
  - `[IsInline <Boolean?>]`: true if the attachment is an inline attachment; otherwise, false. Optional.
  - `[Name <String>]`: The display name of the attachment. This can be a descriptive string and does not have to be the actual file name. Required.
  - `[Size <Int64?>]`: The length of the attachment in bytes. Required.

BODYPARAMETER <IPaths1Ly1W91UsersUserIdEventsEventIdAttachmentsMicrosoftGraphCreateuploadsessionPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AttachmentItem <IMicrosoftGraphAttachmentItem>]`: attachmentItem
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AttachmentType <String>]`: attachmentType
    - `[ContentId <String>]`: The CID or Content-Id of the attachment for referencing in case of in-line attachments using <img src='cid:contentId'> tag in HTML messages. Optional.
    - `[ContentType <String>]`: The nature of the data in the attachment. Optional.
    - `[IsInline <Boolean?>]`: true if the attachment is an inline attachment; otherwise, false. Optional.
    - `[Name <String>]`: The display name of the attachment. This can be a descriptive string and does not have to be the actual file name. Required.
    - `[Size <Int64?>]`: The length of the attachment in bytes. Required.

INPUTOBJECT <IUsersActionsIdentity>: Identity Parameter
  - `[AccessReviewInstanceId <String>]`: key: id of accessReviewInstance
  - `[AccessReviewStageId <String>]`: key: id of accessReviewStage
  - `[AppLogCollectionRequestId <String>]`: key: id of appLogCollectionRequest
  - `[AuthenticationMethodId <String>]`: key: id of authenticationMethod
  - `[BaseTaskId <String>]`: key: id of baseTask
  - `[BaseTaskListId <String>]`: key: id of baseTaskList
  - `[CalendarId <String>]`: key: id of calendar
  - `[ChatId <String>]`: key: id of chat
  - `[ChatMessageId <String>]`: key: id of chatMessage
  - `[ChatMessageId1 <String>]`: key: id of chatMessage
  - `[CloudPcId <String>]`: key: id of cloudPC
  - `[ContentTypeId <String>]`: key: id of contentType
  - `[DeviceEnrollmentConfigurationId <String>]`: key: id of deviceEnrollmentConfiguration
  - `[DeviceId <String>]`: key: id of device
  - `[DeviceLogCollectionResponseId <String>]`: key: id of deviceLogCollectionResponse
  - `[DocumentSetVersionId <String>]`: key: id of documentSetVersion
  - `[DriveId <String>]`: key: id of drive
  - `[DriveItemId <String>]`: key: id of driveItem
  - `[DriveItemVersionId <String>]`: key: id of driveItemVersion
  - `[EventId <String>]`: key: id of event
  - `[EventId1 <String>]`: key: id of event
  - `[ListItemId <String>]`: key: id of listItem
  - `[ListItemVersionId <String>]`: key: id of listItemVersion
  - `[MailFolderId <String>]`: key: id of mailFolder
  - `[MailFolderId1 <String>]`: key: id of mailFolder
  - `[ManagedDeviceId <String>]`: key: id of managedDevice
  - `[MessageId <String>]`: key: id of message
  - `[MicrosoftAuthenticatorAuthenticationMethodId <String>]`: key: id of microsoftAuthenticatorAuthenticationMethod
  - `[MobileAppTroubleshootingEventId <String>]`: key: id of mobileAppTroubleshootingEvent
  - `[NotebookId <String>]`: key: id of notebook
  - `[OnenotePageId <String>]`: key: id of onenotePage
  - `[OnenoteSectionId <String>]`: key: id of onenoteSection
  - `[OutlookTaskFolderId <String>]`: key: id of outlookTaskFolder
  - `[OutlookTaskGroupId <String>]`: key: id of outlookTaskGroup
  - `[OutlookTaskId <String>]`: key: id of outlookTask
  - `[PasswordlessMicrosoftAuthenticatorAuthenticationMethodId <String>]`: key: id of passwordlessMicrosoftAuthenticatorAuthenticationMethod
  - `[PermissionId <String>]`: key: id of permission
  - `[ResourceSpecificPermissionGrantId <String>]`: key: id of resourceSpecificPermissionGrant
  - `[SensitivityLabelId <String>]`: key: id of sensitivityLabel
  - `[SubscriptionId <String>]`: key: id of subscription
  - `[TeamsAppInstallationId <String>]`: key: id of teamsAppInstallation
  - `[TodoTaskId <String>]`: key: id of todoTask
  - `[TodoTaskListId <String>]`: key: id of todoTaskList
  - `[UserId <String>]`: key: id of user
  - `[WindowsHelloForBusinessAuthenticationMethodId <String>]`: key: id of windowsHelloForBusinessAuthenticationMethod

## RELATED LINKS

