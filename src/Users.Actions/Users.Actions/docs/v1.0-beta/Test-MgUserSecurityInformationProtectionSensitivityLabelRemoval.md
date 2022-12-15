---
external help file:
Module Name: Microsoft.Graph.Users.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.actions/test-mgusersecurityinformationprotectionsensitivitylabelremoval
schema: 2.0.0
---

# Test-MgUserSecurityInformationProtectionSensitivityLabelRemoval

## SYNOPSIS
Indicate to the consuming application what actions it should take to remove the label information.
Given contentInfo as an input, which includes existing content metadata key-value pairs, the API returns an informationProtectionAction that contains some combination of one or more of the following:

## SYNTAX

### EvaluateExpanded (Default)
```
Test-MgUserSecurityInformationProtectionSensitivityLabelRemoval -UserId <String>
 [-AdditionalProperties <Hashtable>] [-ContentInfo <IMicrosoftGraphSecurityContentInfo>]
 [-DowngradeJustification <IMicrosoftGraphSecurityDowngradeJustification>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Evaluate
```
Test-MgUserSecurityInformationProtectionSensitivityLabelRemoval -UserId <String>
 -BodyParameter <IPathsZhdpmhUsersUserIdSecurityInformationprotectionSensitivitylabelsMicrosoftGraphSecurityEvaluateremovalPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### EvaluateViaIdentity
```
Test-MgUserSecurityInformationProtectionSensitivityLabelRemoval -InputObject <IUsersActionsIdentity>
 -BodyParameter <IPathsZhdpmhUsersUserIdSecurityInformationprotectionSensitivitylabelsMicrosoftGraphSecurityEvaluateremovalPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### EvaluateViaIdentityExpanded
```
Test-MgUserSecurityInformationProtectionSensitivityLabelRemoval -InputObject <IUsersActionsIdentity>
 [-AdditionalProperties <Hashtable>] [-ContentInfo <IMicrosoftGraphSecurityContentInfo>]
 [-DowngradeJustification <IMicrosoftGraphSecurityDowngradeJustification>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Indicate to the consuming application what actions it should take to remove the label information.
Given contentInfo as an input, which includes existing content metadata key-value pairs, the API returns an informationProtectionAction that contains some combination of one or more of the following:

## EXAMPLES

### Example 1: Using the Test-MgUserSecurityInformationProtectionSensitivityLabelRemoval Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	ContentInfo = @{
		"@odata.type" = "#microsoft.graph.security.contentInfo"
		Identifier = $null
		State = "rest"
		Metadata = @(
			@{
				Name = "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_Enabled"
				Value = "True"
			}
			@{
				Name = "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_Method"
				Value = "Standard"
			}
			@{
				Name = "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_SetDate"
				Value = "1/1/0001 12:00:00 AM"
			}
			@{
				"@odata.type" = "#microsoft.graph.security.keyValuePair"
				Name = "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_SiteId"
				Value = "cfa4cf1d-a337-4481-aa99-19d8f3d63f7c"
			}
			@{
				"@odata.type" = "#microsoft.graph.security.keyValuePair"
				Name = "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_Name"
				Value = "LabelScopedToBob_Tests"
			}
			@{
				"@odata.type" = "#microsoft.graph.security.keyValuePair"
				Name = "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_ContentBits"
				Value = "0"
			}
			@{
				"@odata.type" = "#microsoft.graph.security.keyValuePair"
				Name = "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_ActionId"
				Value = "00000000-0000-0000-0000-000000000000"
			}
		)
	}
	DowngradeJustification = @{
		JustificationMessage = "The information has been declassified."
		IsDowngradeJustified = $true
	}
}
Test-MgUserSecurityInformationProtectionSensitivityLabelRemoval -UserId $userId -BodyParameter $params
```

This example shows how to use the Test-MgUserSecurityInformationProtectionSensitivityLabelRemoval Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: EvaluateExpanded, EvaluateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IPathsZhdpmhUsersUserIdSecurityInformationprotectionSensitivitylabelsMicrosoftGraphSecurityEvaluateremovalPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Evaluate, EvaluateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ContentInfo
contentInfo
To construct, please use Get-Help -Online and see NOTES section for CONTENTINFO properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityContentInfo
Parameter Sets: EvaluateExpanded, EvaluateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DowngradeJustification
downgradeJustification
To construct, please use Get-Help -Online and see NOTES section for DOWNGRADEJUSTIFICATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityDowngradeJustification
Parameter Sets: EvaluateExpanded, EvaluateViaIdentityExpanded
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
Parameter Sets: EvaluateViaIdentity, EvaluateViaIdentityExpanded
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
Parameter Sets: Evaluate, EvaluateExpanded
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

### Microsoft.Graph.PowerShell.Models.IPathsZhdpmhUsersUserIdSecurityInformationprotectionSensitivitylabelsMicrosoftGraphSecurityEvaluateremovalPostRequestbodyContentApplicationJsonSchema

### Microsoft.Graph.PowerShell.Models.IUsersActionsIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityInformationProtectionAction

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPathsZhdpmhUsersUserIdSecurityInformationprotectionSensitivitylabelsMicrosoftGraphSecurityEvaluateremovalPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ContentInfo <IMicrosoftGraphSecurityContentInfo>]`: contentInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ContentFormat <String>]`: The format of the content to be labeled. Possible values are: file, email.
    - `[Identifier <String>]`: Identifier used for Azure Information Protection Analytics.
    - `[Metadata <IMicrosoftGraphSecurityKeyValuePair[]>]`: Existing Microsoft Purview Information Protection metadata is passed as key-value pairs, where the key is the MSIP_Label_GUID_PropName.
      - `[Name <String>]`: Name for this key-value pair.
      - `[Value <String>]`: Value for this key-value pair.
    - `[State <String>]`: contentState
  - `[DowngradeJustification <IMicrosoftGraphSecurityDowngradeJustification>]`: downgradeJustification
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IsDowngradeJustified <Boolean?>]`: Indicates whether the downgrade is or is not justified.
    - `[JustificationMessage <String>]`: Message that indicates why a downgrade is justified. The message will appear in administrative logs.

CONTENTINFO <IMicrosoftGraphSecurityContentInfo>: contentInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ContentFormat <String>]`: The format of the content to be labeled. Possible values are: file, email.
  - `[Identifier <String>]`: Identifier used for Azure Information Protection Analytics.
  - `[Metadata <IMicrosoftGraphSecurityKeyValuePair[]>]`: Existing Microsoft Purview Information Protection metadata is passed as key-value pairs, where the key is the MSIP_Label_GUID_PropName.
    - `[Name <String>]`: Name for this key-value pair.
    - `[Value <String>]`: Value for this key-value pair.
  - `[State <String>]`: contentState

DOWNGRADEJUSTIFICATION <IMicrosoftGraphSecurityDowngradeJustification>: downgradeJustification
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[IsDowngradeJustified <Boolean?>]`: Indicates whether the downgrade is or is not justified.
  - `[JustificationMessage <String>]`: Message that indicates why a downgrade is justified. The message will appear in administrative logs.

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

