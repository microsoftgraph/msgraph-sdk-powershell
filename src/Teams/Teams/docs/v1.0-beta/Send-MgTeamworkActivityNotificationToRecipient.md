---
external help file:
Module Name: Microsoft.Graph.Teams
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams/send-mgteamworkactivitynotificationtorecipient
schema: 2.0.0
---

# Send-MgTeamworkActivityNotificationToRecipient

## SYNOPSIS
Invoke action sendActivityNotificationToRecipients

## SYNTAX

### SendExpanded1 (Default)
```
Send-MgTeamworkActivityNotificationToRecipient [-ActivityType <String>] [-AdditionalProperties <Hashtable>]
 [-ChainId <Int64>] [-PreviewText <IMicrosoftGraphItemBody>]
 [-Recipients <IMicrosoftGraphTeamworkNotificationRecipient[]>] [-TeamsAppId <String>]
 [-TemplateParameters <IMicrosoftGraphKeyValuePair[]>] [-Topic <IMicrosoftGraphTeamworkActivityTopic>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Send1
```
Send-MgTeamworkActivityNotificationToRecipient
 -BodyParameter <IPaths1T8Q21HTeamworkMicrosoftGraphSendactivitynotificationtorecipientsPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action sendActivityNotificationToRecipients

## EXAMPLES

### Example 1: Using the Send-MgTeamworkActivityNotificationToRecipient Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	Topic = @{
		Source = "entityUrl"
		Value = "https://graph.microsoft.com/beta/appCatalogs/teamsApps/{teamsAppId}"
	}
	ActivityType = "pendingFinanceApprovalRequests"
	PreviewText = @{
		Content = "Internal spending team has a pending finance approval requests"
	}
	Recipients = @(
		@{
			"@odata.type" = "microsoft.graph.aadUserNotificationRecipient"
			UserId = "569363e2-4e49-4661-87f2-16f245c5d66a"
		}
		@{
			"@odata.type" = "microsoft.graph.aadUserNotificationRecipient"
			UserId = "ab88234e-0874-477c-9638-d144296ed04f"
		}
		@{
			"@odata.type" = "microsoft.graph.aadUserNotificationRecipient"
			UserId = "01c64f53-69aa-42c7-9b7f-9f75195d6bfc"
		}
	)
	TemplateParameters = @(
		@{
			Name = "pendingRequestCount"
			Value = "5"
		}
	)
}
Send-MgTeamworkActivityNotificationToRecipient -BodyParameter $params
```

This example shows how to use the Send-MgTeamworkActivityNotificationToRecipient Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Using the Send-MgTeamworkActivityNotificationToRecipient Cmdlet
```powershell
Import-Module Microsoft.Graph.Teams
$params = @{
	Topic = @{
		Source = "text"
		Value = "Deployment Approvals Channel"
		WebUrl = "https://teams.microsoft.com/l/message/19:448cfd2ac2a7490a9084a9ed14cttr78c@thread.skype/1605223780000?tenantId=c8b1bf45-3834-4ecf-971a-b4c755ee677d&groupId=d4c2a937-f097-435a-bc91-5c1683ca7245&parentMessageId=1605223771864&teamName=Approvals&channelName=Azure%20DevOps&createdTime=1605223780000"
	}
	ActivityType = "deploymentApprovalRequired"
	PreviewText = @{
		Content = "New deployment requires your approval"
	}
	TemplateParameters = @(
		@{
			Name = "deploymentId"
			Value = "6788662"
		}
	)
	Recipients = @(
		@{
			"@odata.type" = "microsoft.graph.aadUserNotificationRecipient"
			UserId = "569363e2-4e49-4661-87f2-16f245c5d66a"
		}
		@{
			"@odata.type" = "microsoft.graph.aadUserNotificationRecipient"
			UserId = "ab88234e-0874-477c-9638-d144296ed04f"
		}
		@{
			"@odata.type" = "microsoft.graph.aadUserNotificationRecipient"
			UserId = "01c64f53-69aa-42c7-9b7f-9f75195d6bfc"
		}
	)
}
Send-MgTeamworkActivityNotificationToRecipient -BodyParameter $params
```

This example shows how to use the Send-MgTeamworkActivityNotificationToRecipient Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -ActivityType
.

```yaml
Type: System.String
Parameter Sets: SendExpanded1
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
Parameter Sets: SendExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.IPaths1T8Q21HTeamworkMicrosoftGraphSendactivitynotificationtorecipientsPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Send1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ChainId
.

```yaml
Type: System.Int64
Parameter Sets: SendExpanded1
Aliases:

Required: False
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

### -PreviewText
itemBody
To construct, please use Get-Help -Online and see NOTES section for PREVIEWTEXT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphItemBody
Parameter Sets: SendExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Recipients
.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamworkNotificationRecipient[]
Parameter Sets: SendExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TeamsAppId
.

```yaml
Type: System.String
Parameter Sets: SendExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TemplateParameters
.
To construct, please use Get-Help -Online and see NOTES section for TEMPLATEPARAMETERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphKeyValuePair[]
Parameter Sets: SendExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Topic
teamworkActivityTopic
To construct, please use Get-Help -Online and see NOTES section for TOPIC properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamworkActivityTopic
Parameter Sets: SendExpanded1
Aliases:

Required: False
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

### Microsoft.Graph.PowerShell.Models.IPaths1T8Q21HTeamworkMicrosoftGraphSendactivitynotificationtorecipientsPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1T8Q21HTeamworkMicrosoftGraphSendactivitynotificationtorecipientsPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ActivityType <String>]`: 
  - `[ChainId <Int64?>]`: 
  - `[PreviewText <IMicrosoftGraphItemBody>]`: itemBody
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Content <String>]`: The content of the item.
    - `[ContentType <String>]`: bodyType
  - `[Recipients <IMicrosoftGraphTeamworkNotificationRecipient[]>]`: 
  - `[TeamsAppId <String>]`: 
  - `[TemplateParameters <IMicrosoftGraphKeyValuePair[]>]`: 
    - `[Name <String>]`: Name for this key-value pair
    - `[Value <String>]`: Value for this key-value pair
  - `[Topic <IMicrosoftGraphTeamworkActivityTopic>]`: teamworkActivityTopic
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Source <String>]`: teamworkActivityTopicSource
    - `[Value <String>]`: The topic value. If the value of the source property is entityUrl, this must be a Microsoft Graph URL. If the vaule is text, this must be a plain text value.
    - `[WebUrl <String>]`: The link the user clicks when they select the notification. Optional when source is entityUrl; required when source is text.

PREVIEWTEXT <IMicrosoftGraphItemBody>: itemBody
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Content <String>]`: The content of the item.
  - `[ContentType <String>]`: bodyType

TEMPLATEPARAMETERS <IMicrosoftGraphKeyValuePair[]>: .
  - `[Name <String>]`: Name for this key-value pair
  - `[Value <String>]`: Value for this key-value pair

TOPIC <IMicrosoftGraphTeamworkActivityTopic>: teamworkActivityTopic
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Source <String>]`: teamworkActivityTopicSource
  - `[Value <String>]`: The topic value. If the value of the source property is entityUrl, this must be a Microsoft Graph URL. If the vaule is text, this must be a plain text value.
  - `[WebUrl <String>]`: The link the user clicks when they select the notification. Optional when source is entityUrl; required when source is text.

## RELATED LINKS

