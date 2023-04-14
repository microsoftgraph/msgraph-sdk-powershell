---
external help file:
Module Name: Microsoft.Graph.Users.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.actions/invoke-mgextractusersecurityinformationprotectionsensitivitylabelcontentlabel
schema: 2.0.0
---

# Invoke-MgExtractUserSecurityInformationProtectionSensitivityLabelContentLabel

## SYNOPSIS
Use the metadata that exists on an already-labeled piece of information to resolve the metadata to a specific sensitivity label.
The contentInfo input is resolved to informationProtectionContentLabel.

## SYNTAX

### ExtractExpanded (Default)
```
Invoke-MgExtractUserSecurityInformationProtectionSensitivityLabelContentLabel -UserId <String>
 [-AdditionalProperties <Hashtable>] [-ContentInfo <IMicrosoftGraphSecurityContentInfo>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Extract
```
Invoke-MgExtractUserSecurityInformationProtectionSensitivityLabelContentLabel -UserId <String>
 -BodyParameter <IPaths12WcorzUsersUserIdSecurityInformationprotectionSensitivitylabelsMicrosoftGraphSecurityExtractcontentlabelPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ExtractViaIdentity
```
Invoke-MgExtractUserSecurityInformationProtectionSensitivityLabelContentLabel
 -InputObject <IUsersActionsIdentity>
 -BodyParameter <IPaths12WcorzUsersUserIdSecurityInformationprotectionSensitivitylabelsMicrosoftGraphSecurityExtractcontentlabelPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ExtractViaIdentityExpanded
```
Invoke-MgExtractUserSecurityInformationProtectionSensitivityLabelContentLabel
 -InputObject <IUsersActionsIdentity> [-AdditionalProperties <Hashtable>]
 [-ContentInfo <IMicrosoftGraphSecurityContentInfo>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Use the metadata that exists on an already-labeled piece of information to resolve the metadata to a specific sensitivity label.
The contentInfo input is resolved to informationProtectionContentLabel.

## EXAMPLES

### Example 1: Using the Invoke-MgExtractUserSecurityInformationProtectionSensitivityLabelContentLabel Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	ContentInfo = @{
		Format = "default"
		Identifier = "MyDoc.docx"
		State = "rest"
		Metadata = @(
			@{
				Name = "MSIP_Label_0ed12617-d0ef-4053-b8e4-ecf5bcf2ffb3_Enabled"
				Value = "True"
			}
			@{
				Name = "MSIP_Label_0ed12617-d0ef-4053-b8e4-ecf5bcf2ffb3_Method"
				Value = "Standard"
			}
			@{
				Name = "MSIP_Label_0ed12617-d0ef-4053-b8e4-ecf5bcf2ffb3_SetDate"
				Value = "1/1/0001 12:00:00 AM"
			}
			@{
				Name = "MSIP_Label_0ed12617-d0ef-4053-b8e4-ecf5bcf2ffb3_SiteId"
				Value = "cfa4cf1d-a337-4481-aa99-19d8f3d63f7c"
			}
			@{
				Name = "MSIP_Label_0ed12617-d0ef-4053-b8e4-ecf5bcf2ffb3_Name"
				Value = "LabelScopedToBob_Tests"
			}
			@{
				Name = "MSIP_Label_0ed12617-d0ef-4053-b8e4-ecf5bcf2ffb3_ContentBits"
				Value = "0"
			}
			@{
				Name = "MSIP_Label_0ed12617-d0ef-4053-b8e4-ecf5bcf2ffb3_ActionId"
				Value = "00000000-0000-0000-0000-000000000000"
			}
		)
	}
}
Invoke-MgExtractUserSecurityInformationProtectionSensitivityLabelContentLabel -UserId $userId -BodyParameter $params
```

This example shows how to use the Invoke-MgExtractUserSecurityInformationProtectionSensitivityLabelContentLabel Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: ExtractExpanded, ExtractViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IPaths12WcorzUsersUserIdSecurityInformationprotectionSensitivitylabelsMicrosoftGraphSecurityExtractcontentlabelPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Extract, ExtractViaIdentity
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
Parameter Sets: ExtractExpanded, ExtractViaIdentityExpanded
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
Parameter Sets: ExtractViaIdentity, ExtractViaIdentityExpanded
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
Parameter Sets: Extract, ExtractExpanded
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

### Microsoft.Graph.PowerShell.Models.IPaths12WcorzUsersUserIdSecurityInformationprotectionSensitivitylabelsMicrosoftGraphSecurityExtractcontentlabelPostRequestbodyContentApplicationJsonSchema

### Microsoft.Graph.PowerShell.Models.IUsersActionsIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityContentLabel

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths12WcorzUsersUserIdSecurityInformationprotectionSensitivitylabelsMicrosoftGraphSecurityExtractcontentlabelPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ContentInfo <IMicrosoftGraphSecurityContentInfo>]`: contentInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ContentFormat <String>]`: The format of the content to be labeled. Possible values are: file, email.
    - `[Identifier <String>]`: Identifier used for Azure Information Protection Analytics.
    - `[Metadata <IMicrosoftGraphSecurityKeyValuePair[]>]`: Existing Microsoft Purview Information Protection metadata is passed as key-value pairs, where the key is the MSIP_Label_GUID_PropName.
      - `[Name <String>]`: Name for this key-value pair.
      - `[Value <String>]`: Value for this key-value pair.
    - `[State <String>]`: contentState

CONTENTINFO <IMicrosoftGraphSecurityContentInfo>: contentInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ContentFormat <String>]`: The format of the content to be labeled. Possible values are: file, email.
  - `[Identifier <String>]`: Identifier used for Azure Information Protection Analytics.
  - `[Metadata <IMicrosoftGraphSecurityKeyValuePair[]>]`: Existing Microsoft Purview Information Protection metadata is passed as key-value pairs, where the key is the MSIP_Label_GUID_PropName.
    - `[Name <String>]`: Name for this key-value pair.
    - `[Value <String>]`: Value for this key-value pair.
  - `[State <String>]`: contentState

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

