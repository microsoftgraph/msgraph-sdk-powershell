---
external help file:
Module Name: Microsoft.Graph.Beta.Groups
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.groups/invoke-mgbetaforwardgroupevent
schema: 2.0.0
---

# Invoke-MgBetaForwardGroupEvent

## SYNOPSIS
This action allows the organizer or attendee of a meeting event to forward the \nmeeting request to a new recipient.
If the meeting event is forwarded from an attendee's Microsoft 365 mailbox to another recipient, this action \nalso sends a message to notify the organizer of the forwarding, and adds the recipient to the organizer's \ncopy of the meeting event.
This convenience is not available when forwarding from an Outlook.com account.

## SYNTAX

### ForwardExpanded (Default)
```
Invoke-MgBetaForwardGroupEvent -EventId <String> -GroupId <String> [-AdditionalProperties <Hashtable>]
 [-Comment <String>] [-ToRecipients <IMicrosoftGraphRecipient[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Forward
```
Invoke-MgBetaForwardGroupEvent -EventId <String> -GroupId <String>
 -BodyParameter <IPaths1K4KnkbGroupsGroupIdEventsEventIdMicrosoftGraphForwardPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ForwardViaIdentity
```
Invoke-MgBetaForwardGroupEvent -InputObject <IGroupsIdentity>
 -BodyParameter <IPaths1K4KnkbGroupsGroupIdEventsEventIdMicrosoftGraphForwardPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ForwardViaIdentityExpanded
```
Invoke-MgBetaForwardGroupEvent -InputObject <IGroupsIdentity> [-AdditionalProperties <Hashtable>]
 [-Comment <String>] [-ToRecipients <IMicrosoftGraphRecipient[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
This action allows the organizer or attendee of a meeting event to forward the \nmeeting request to a new recipient.
If the meeting event is forwarded from an attendee's Microsoft 365 mailbox to another recipient, this action \nalso sends a message to notify the organizer of the forwarding, and adds the recipient to the organizer's \ncopy of the meeting event.
This convenience is not available when forwarding from an Outlook.com account.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
```

$params = @{
	ToRecipients = @(
		@{
			EmailAddress = @{
				Address = "danas@contoso.onmicrosoft.com"
				Name = "Dana Swope"
			}
		}
	)
	Comment = "Dana, hope you can make this meeting."
}

# A UPN can also be used as -UserId.
Invoke-MgBetaForwardUserEvent -UserId $userId -EventId $eventId -BodyParameter $params

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: ForwardExpanded, ForwardViaIdentityExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths1K4KnkbGroupsGroupIdEventsEventIdMicrosoftGraphForwardPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Forward, ForwardViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Comment
.

```yaml
Type: System.String
Parameter Sets: ForwardExpanded, ForwardViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EventId
The unique identifier of event

```yaml
Type: System.String
Parameter Sets: Forward, ForwardExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GroupId
The unique identifier of group

```yaml
Type: System.String
Parameter Sets: Forward, ForwardExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IGroupsIdentity
Parameter Sets: ForwardViaIdentity, ForwardViaIdentityExpanded
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

### -ToRecipients
.
To construct, see NOTES section for TORECIPIENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRecipient[]
Parameter Sets: ForwardExpanded, ForwardViaIdentityExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IGroupsIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IPaths1K4KnkbGroupsGroupIdEventsEventIdMicrosoftGraphForwardPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPaths1K4KnkbGroupsGroupIdEventsEventIdMicrosoftGraphForwardPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Comment <String>]`: 
  - `[ToRecipients <IMicrosoftGraphRecipient[]>]`: 
    - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Address <String>]`: The email address of an entity instance.
      - `[Name <String>]`: The display name of an entity instance.

`INPUTOBJECT <IGroupsIdentity>`: Identity Parameter
  - `[AttachmentId <String>]`: The unique identifier of attachment
  - `[ContentTypeId <String>]`: The unique identifier of contentType
  - `[ConversationId <String>]`: The unique identifier of conversation
  - `[ConversationThreadId <String>]`: The unique identifier of conversationThread
  - `[DirectoryObjectId <String>]`: The unique identifier of directoryObject
  - `[DirectorySettingId <String>]`: The unique identifier of directorySetting
  - `[DocumentSetVersionId <String>]`: The unique identifier of documentSetVersion
  - `[DriveId <String>]`: The unique identifier of drive
  - `[DriveItemId <String>]`: The unique identifier of driveItem
  - `[DriveItemVersionId <String>]`: The unique identifier of driveItemVersion
  - `[EndDateTime <String>]`: Usage: endDateTime='{endDateTime}'
  - `[EndpointId <String>]`: The unique identifier of endpoint
  - `[EventId <String>]`: The unique identifier of event
  - `[ExtensionId <String>]`: The unique identifier of extension
  - `[GroupId <String>]`: The unique identifier of group
  - `[GroupLifecyclePolicyId <String>]`: The unique identifier of groupLifecyclePolicy
  - `[IncludePersonalNotebooks <Boolean?>]`: Usage: includePersonalNotebooks={includePersonalNotebooks}
  - `[Interval <String>]`: Usage: interval='{interval}'
  - `[ListId <String>]`: The unique identifier of list
  - `[ListItemId <String>]`: The unique identifier of listItem
  - `[ListItemVersionId <String>]`: The unique identifier of listItemVersion
  - `[MentionId <String>]`: The unique identifier of mention
  - `[NotebookId <String>]`: The unique identifier of notebook
  - `[OnenotePageId <String>]`: The unique identifier of onenotePage
  - `[OnenoteSectionId <String>]`: The unique identifier of onenoteSection
  - `[Path <String>]`: Usage: path='{path}'
  - `[PermissionId <String>]`: The unique identifier of permission
  - `[PlannerBucketId <String>]`: The unique identifier of plannerBucket
  - `[PlannerPlanId <String>]`: The unique identifier of plannerPlan
  - `[PostId <String>]`: The unique identifier of post
  - `[ProfilePhotoId <String>]`: The unique identifier of profilePhoto
  - `[Q <String>]`: Usage: q='{q}'
  - `[ResourceSpecificPermissionGrantId <String>]`: The unique identifier of resourceSpecificPermissionGrant
  - `[SensitivityLabelId <String>]`: The unique identifier of sensitivityLabel
  - `[SiteId <String>]`: The unique identifier of site
  - `[StartDateTime <String>]`: Usage: startDateTime='{startDateTime}'
  - `[SubscriptionId <String>]`: The unique identifier of subscription
  - `[Token <String>]`: Usage: token='{token}'
  - `[UniqueName <String>]`: Alternate key of group
  - `[User <String>]`: Usage: User='{User}'
  - `[UserId <String>]`: The unique identifier of user

`TORECIPIENTS <IMicrosoftGraphRecipient[]>`: .
  - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Address <String>]`: The email address of an entity instance.
    - `[Name <String>]`: The display name of an entity instance.

## RELATED LINKS

