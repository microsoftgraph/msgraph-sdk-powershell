---
external help file:
Module Name: Microsoft.Graph.Users.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.actions/invoke-mgbulkrestoreusermanageddevicecloudpc
schema: 2.0.0
---

# Invoke-MgBulkRestoreUserManagedDeviceCloudPc

## SYNOPSIS
Restore multiple Cloud PC devices with a single request that includes the IDs of Intune managed devices and a restore point date and time.

## SYNTAX

### BulkExpanded (Default)
```
Invoke-MgBulkRestoreUserManagedDeviceCloudPc -UserId <String> [-AdditionalProperties <Hashtable>]
 [-ManagedDeviceIds <String[]>] [-RestorePointDateTime <DateTime>] [-TimeRange <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Bulk
```
Invoke-MgBulkRestoreUserManagedDeviceCloudPc -UserId <String>
 -BodyParameter <IPaths14X3W2OUsersUserIdManageddevicesMicrosoftGraphBulkrestorecloudpcPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### BulkViaIdentity
```
Invoke-MgBulkRestoreUserManagedDeviceCloudPc -InputObject <IUsersActionsIdentity>
 -BodyParameter <IPaths14X3W2OUsersUserIdManageddevicesMicrosoftGraphBulkrestorecloudpcPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### BulkViaIdentityExpanded
```
Invoke-MgBulkRestoreUserManagedDeviceCloudPc -InputObject <IUsersActionsIdentity>
 [-AdditionalProperties <Hashtable>] [-ManagedDeviceIds <String[]>] [-RestorePointDateTime <DateTime>]
 [-TimeRange <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Restore multiple Cloud PC devices with a single request that includes the IDs of Intune managed devices and a restore point date and time.

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: BulkExpanded, BulkViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IPaths14X3W2OUsersUserIdManageddevicesMicrosoftGraphBulkrestorecloudpcPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Bulk, BulkViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IUsersActionsIdentity
Parameter Sets: BulkViaIdentity, BulkViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ManagedDeviceIds
.

```yaml
Type: System.String[]
Parameter Sets: BulkExpanded, BulkViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RestorePointDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: BulkExpanded, BulkViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TimeRange
restoreTimeRange

```yaml
Type: System.String
Parameter Sets: BulkExpanded, BulkViaIdentityExpanded
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
Parameter Sets: Bulk, BulkExpanded
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

### Microsoft.Graph.PowerShell.Models.IPaths14X3W2OUsersUserIdManageddevicesMicrosoftGraphBulkrestorecloudpcPostRequestbodyContentApplicationJsonSchema

### Microsoft.Graph.PowerShell.Models.IUsersActionsIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcBulkRemoteActionResult

## NOTES

ALIASES

### Invoke-MgBulkUserManagedDeviceRestoreCloudPc

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths14X3W2OUsersUserIdManageddevicesMicrosoftGraphBulkrestorecloudpcPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ManagedDeviceIds <String[]>]`: 
  - `[RestorePointDateTime <DateTime?>]`: 
  - `[TimeRange <String>]`: restoreTimeRange

INPUTOBJECT <IUsersActionsIdentity>: Identity Parameter
  - `[AccessReviewInstanceId <String>]`: The unique identifier of accessReviewInstance
  - `[AccessReviewStageId <String>]`: The unique identifier of accessReviewStage
  - `[AppLogCollectionRequestId <String>]`: The unique identifier of appLogCollectionRequest
  - `[AuthenticationMethodId <String>]`: The unique identifier of authenticationMethod
  - `[CalendarId <String>]`: The unique identifier of calendar
  - `[ChatId <String>]`: The unique identifier of chat
  - `[ChatMessageId <String>]`: The unique identifier of chatMessage
  - `[ChatMessageId1 <String>]`: The unique identifier of chatMessage
  - `[CloudPcId <String>]`: The unique identifier of cloudPC
  - `[ContentTypeId <String>]`: The unique identifier of contentType
  - `[DeviceEnrollmentConfigurationId <String>]`: The unique identifier of deviceEnrollmentConfiguration
  - `[DeviceId <String>]`: The unique identifier of device
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
  - `[MobileAppTroubleshootingEventId <String>]`: The unique identifier of mobileAppTroubleshootingEvent
  - `[NotebookId <String>]`: The unique identifier of notebook
  - `[OnenotePageId <String>]`: The unique identifier of onenotePage
  - `[OnenoteSectionId <String>]`: The unique identifier of onenoteSection
  - `[OutlookTaskFolderId <String>]`: The unique identifier of outlookTaskFolder
  - `[OutlookTaskGroupId <String>]`: The unique identifier of outlookTaskGroup
  - `[OutlookTaskId <String>]`: The unique identifier of outlookTask
  - `[PermissionId <String>]`: The unique identifier of permission
  - `[PhoneAuthenticationMethodId <String>]`: The unique identifier of phoneAuthenticationMethod
  - `[ResourceSpecificPermissionGrantId <String>]`: The unique identifier of resourceSpecificPermissionGrant
  - `[SensitivityLabelId <String>]`: The unique identifier of sensitivityLabel
  - `[SubscriptionId <String>]`: The unique identifier of subscription
  - `[TeamsAppInstallationId <String>]`: The unique identifier of teamsAppInstallation
  - `[TodoTaskId <String>]`: The unique identifier of todoTask
  - `[TodoTaskListId <String>]`: The unique identifier of todoTaskList
  - `[UserId <String>]`: The unique identifier of user

## RELATED LINKS

