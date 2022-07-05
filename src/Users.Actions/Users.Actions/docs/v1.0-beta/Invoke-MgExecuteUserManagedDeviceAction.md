---
external help file:
Module Name: Microsoft.Graph.Users.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.actions/invoke-mgexecuteusermanageddeviceaction
schema: 2.0.0
---

# Invoke-MgExecuteUserManagedDeviceAction

## SYNOPSIS
Invoke action executeAction

## SYNTAX

### ExecuteExpanded (Default)
```
Invoke-MgExecuteUserManagedDeviceAction -UserId <String> [-ActionName <ManagedDeviceRemoteAction>]
 [-AdditionalProperties <Hashtable>] [-CarrierUrl <String>] [-DeprovisionReason <String>]
 [-DeviceIds <String[]>] [-DeviceName <String>] [-KeepEnrollmentData] [-KeepUserData]
 [-NotificationBody <String>] [-NotificationTitle <String>] [-OrganizationalUnitPath <String>]
 [-PersistEsimDataPlan] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Execute
```
Invoke-MgExecuteUserManagedDeviceAction -UserId <String>
 -BodyParameter <IPaths1V92H65UsersUserIdManageddevicesMicrosoftGraphExecuteactionPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ExecuteViaIdentity
```
Invoke-MgExecuteUserManagedDeviceAction -InputObject <IUsersActionsIdentity>
 -BodyParameter <IPaths1V92H65UsersUserIdManageddevicesMicrosoftGraphExecuteactionPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ExecuteViaIdentityExpanded
```
Invoke-MgExecuteUserManagedDeviceAction -InputObject <IUsersActionsIdentity>
 [-ActionName <ManagedDeviceRemoteAction>] [-AdditionalProperties <Hashtable>] [-CarrierUrl <String>]
 [-DeprovisionReason <String>] [-DeviceIds <String[]>] [-DeviceName <String>] [-KeepEnrollmentData]
 [-KeepUserData] [-NotificationBody <String>] [-NotificationTitle <String>] [-OrganizationalUnitPath <String>]
 [-PersistEsimDataPlan] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action executeAction

## EXAMPLES

## PARAMETERS

### -ActionName
managedDeviceRemoteAction

```yaml
Type: Microsoft.Graph.PowerShell.Support.ManagedDeviceRemoteAction
Parameter Sets: ExecuteExpanded, ExecuteViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: ExecuteExpanded, ExecuteViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IPaths1V92H65UsersUserIdManageddevicesMicrosoftGraphExecuteactionPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Execute, ExecuteViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CarrierUrl
.

```yaml
Type: System.String
Parameter Sets: ExecuteExpanded, ExecuteViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeprovisionReason
.

```yaml
Type: System.String
Parameter Sets: ExecuteExpanded, ExecuteViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceIds
.

```yaml
Type: System.String[]
Parameter Sets: ExecuteExpanded, ExecuteViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceName
.

```yaml
Type: System.String
Parameter Sets: ExecuteExpanded, ExecuteViaIdentityExpanded
Aliases:

Required: False
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
Parameter Sets: ExecuteViaIdentity, ExecuteViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -KeepEnrollmentData
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ExecuteExpanded, ExecuteViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -KeepUserData
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ExecuteExpanded, ExecuteViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NotificationBody
.

```yaml
Type: System.String
Parameter Sets: ExecuteExpanded, ExecuteViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NotificationTitle
.

```yaml
Type: System.String
Parameter Sets: ExecuteExpanded, ExecuteViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OrganizationalUnitPath
.

```yaml
Type: System.String
Parameter Sets: ExecuteExpanded, ExecuteViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PersistEsimDataPlan
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ExecuteExpanded, ExecuteViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
key: id of user

```yaml
Type: System.String
Parameter Sets: Execute, ExecuteExpanded
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

### Microsoft.Graph.PowerShell.Models.IPaths1V92H65UsersUserIdManageddevicesMicrosoftGraphExecuteactionPostRequestbodyContentApplicationJsonSchema

### Microsoft.Graph.PowerShell.Models.IUsersActionsIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBulkManagedDeviceActionResult

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1V92H65UsersUserIdManageddevicesMicrosoftGraphExecuteactionPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ActionName <ManagedDeviceRemoteAction?>]`: managedDeviceRemoteAction
  - `[CarrierUrl <String>]`: 
  - `[DeprovisionReason <String>]`: 
  - `[DeviceIds <String[]>]`: 
  - `[DeviceName <String>]`: 
  - `[KeepEnrollmentData <Boolean?>]`: 
  - `[KeepUserData <Boolean?>]`: 
  - `[NotificationBody <String>]`: 
  - `[NotificationTitle <String>]`: 
  - `[OrganizationalUnitPath <String>]`: 
  - `[PersistEsimDataPlan <Boolean?>]`: 

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

