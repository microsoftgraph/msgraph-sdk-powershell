---
external help file:
Module Name: Microsoft.Graph.Beta.Users.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.users.actions/initialize-mguserserviceplan
schema: 2.0.0
---

# Initialize-MgBetaUserServicePlan

## SYNOPSIS
Activate a service plan with a given `servicePlanId` and `skuId` for a given user.

## SYNTAX

### ActivateExpanded (Default)
```
Initialize-MgBetaUserServicePlan -UserId <String> [-AdditionalProperties <Hashtable>] [-ServicePlanId <String>]
 [-SkuId <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Activate
```
Initialize-MgBetaUserServicePlan -UserId <String>
 -BodyParameter <IComponents2P8K5LRequestbodiesActivateserviceplanrequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ActivateViaIdentity
```
Initialize-MgBetaUserServicePlan -InputObject <IUsersActionsIdentity>
 -BodyParameter <IComponents2P8K5LRequestbodiesActivateserviceplanrequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ActivateViaIdentityExpanded
```
Initialize-MgBetaUserServicePlan -InputObject <IUsersActionsIdentity> [-AdditionalProperties <Hashtable>]
 [-ServicePlanId <String>] [-SkuId <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Activate a service plan with a given `servicePlanId` and `skuId` for a given user.

## EXAMPLES

### Example 1: Using the Initialize-MgBetaUserServicePlan Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
$params = @{
	ServicePlanId = "28f42d6f-8034-4a0f-9d8a-a218a63b3299"
	SkuId = "465a2a90-5e59-456d-a7b8-127b9fb2e484"
}
# A UPN can also be used as -UserId.
Initialize-MgBetaUserServicePlan -UserId $userId -BodyParameter $params
```

This example shows how to use the Initialize-MgBetaUserServicePlan Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: ActivateExpanded, ActivateViaIdentityExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IComponents2P8K5LRequestbodiesActivateserviceplanrequestbodyContentApplicationJsonSchema
Parameter Sets: Activate, ActivateViaIdentity
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IUsersActionsIdentity
Parameter Sets: ActivateViaIdentity, ActivateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -ServicePlanId
.

```yaml
Type: System.String
Parameter Sets: ActivateExpanded, ActivateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SkuId
.

```yaml
Type: System.String
Parameter Sets: ActivateExpanded, ActivateViaIdentityExpanded
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
Parameter Sets: Activate, ActivateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IComponents2P8K5LRequestbodiesActivateserviceplanrequestbodyContentApplicationJsonSchema

### Microsoft.Graph.Beta.PowerShell.Models.IUsersActionsIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IComponents2P8K5LRequestbodiesActivateserviceplanrequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ServicePlanId <String>]`: 
  - `[SkuId <String>]`: 

INPUTOBJECT <IUsersActionsIdentity>: Identity Parameter
  - `[AccessReviewInstanceId <String>]`: key: id of accessReviewInstance
  - `[AccessReviewStageId <String>]`: key: id of accessReviewStage
  - `[AppLogCollectionRequestId <String>]`: key: id of appLogCollectionRequest
  - `[AuthenticationMethodId <String>]`: key: id of authenticationMethod
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
  - `[PhoneAuthenticationMethodId <String>]`: key: id of phoneAuthenticationMethod
  - `[ResourceSpecificPermissionGrantId <String>]`: key: id of resourceSpecificPermissionGrant
  - `[SensitivityLabelId <String>]`: key: id of sensitivityLabel
  - `[SubscriptionId <String>]`: key: id of subscription
  - `[TeamsAppInstallationId <String>]`: key: id of teamsAppInstallation
  - `[TodoTaskId <String>]`: key: id of todoTask
  - `[TodoTaskListId <String>]`: key: id of todoTaskList
  - `[UserId <String>]`: key: id of user
  - `[WindowsHelloForBusinessAuthenticationMethodId <String>]`: key: id of windowsHelloForBusinessAuthenticationMethod

## RELATED LINKS

