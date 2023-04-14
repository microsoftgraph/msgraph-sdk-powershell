---
external help file:
Module Name: Microsoft.Graph.Users.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.actions/confirm-mgusermemberobject
schema: 2.0.0
---

# Confirm-MgUserMemberObject

## SYNOPSIS
Invoke action checkMemberObjects

## SYNTAX

### CheckExpanded1 (Default)
```
Confirm-MgUserMemberObject -UserId <String> [-AdditionalProperties <Hashtable>] [-Ids <String[]>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Check1
```
Confirm-MgUserMemberObject -UserId <String>
 -BodyParameter <IPathsJ9Yxi4UsersUserIdMicrosoftGraphCheckmemberobjectsPostRequestbodyContentApplicationJsonSchema1>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CheckViaIdentity1
```
Confirm-MgUserMemberObject -InputObject <IUsersActionsIdentity>
 -BodyParameter <IPathsJ9Yxi4UsersUserIdMicrosoftGraphCheckmemberobjectsPostRequestbodyContentApplicationJsonSchema1>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CheckViaIdentityExpanded1
```
Confirm-MgUserMemberObject -InputObject <IUsersActionsIdentity> [-AdditionalProperties <Hashtable>]
 [-Ids <String[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action checkMemberObjects

## EXAMPLES

### Example 1: Using the Confirm-MgUserMemberObject Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	Ids = @(
		"80a963dd-84af-4eb8-b2a6-781e444d4fb0"
		"62e90394-69f5-4237-9190-012177145e10"
		"86a64f51-3a64-4cc6-a8c8-6b8f000c0f52"
		"ac38546e-ddf3-437a-ac5c-27a94cd7a0f1"
	)
}
# A UPN can also be used as -UserId.
Confirm-MgUserMemberObject -UserId $userId -BodyParameter $params
```

This example shows how to use the Confirm-MgUserMemberObject Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CheckExpanded1, CheckViaIdentityExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.IPathsJ9Yxi4UsersUserIdMicrosoftGraphCheckmemberobjectsPostRequestbodyContentApplicationJsonSchema1
Parameter Sets: Check1, CheckViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Ids
.

```yaml
Type: System.String[]
Parameter Sets: CheckExpanded1, CheckViaIdentityExpanded1
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
Parameter Sets: CheckViaIdentity1, CheckViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -UserId
The unique identifier of user

```yaml
Type: System.String
Parameter Sets: Check1, CheckExpanded1
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

### Microsoft.Graph.PowerShell.Models.IPathsJ9Yxi4UsersUserIdMicrosoftGraphCheckmemberobjectsPostRequestbodyContentApplicationJsonSchema1

### Microsoft.Graph.PowerShell.Models.IUsersActionsIdentity

## OUTPUTS

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPathsJ9Yxi4UsersUserIdMicrosoftGraphCheckmemberobjectsPostRequestbodyContentApplicationJsonSchema1>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Ids <String[]>]`: 

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

