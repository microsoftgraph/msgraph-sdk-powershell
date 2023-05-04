---
external help file:
Module Name: Microsoft.Graph.Groups
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.groups/invoke-mginvitegroupdriveitem
schema: 2.0.0
---

# Invoke-MgInviteGroupDriveItem

## SYNOPSIS
Invoke action invite

## SYNTAX

### InviteExpanded1 (Default)
```
Invoke-MgInviteGroupDriveItem -DriveId <String> -DriveItemId <String> -GroupId <String>
 [-AdditionalProperties <Hashtable>] [-ExpirationDateTime <String>] [-Message <String>] [-Password <String>]
 [-Recipients <IMicrosoftGraphDriveRecipient[]>] [-RequireSignIn] [-RetainInheritedPermissions]
 [-Roles <String[]>] [-SendInvitation] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Invite1
```
Invoke-MgInviteGroupDriveItem -DriveId <String> -DriveItemId <String> -GroupId <String>
 -BodyParameter <IPathsLx1Fn7GroupsGroupIdDrivesDriveIdItemsDriveitemIdMicrosoftGraphInvitePostRequestbodyContentApplicationJsonSchema1>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### InviteViaIdentity1
```
Invoke-MgInviteGroupDriveItem -InputObject <IGroupsIdentity>
 -BodyParameter <IPathsLx1Fn7GroupsGroupIdDrivesDriveIdItemsDriveitemIdMicrosoftGraphInvitePostRequestbodyContentApplicationJsonSchema1>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### InviteViaIdentityExpanded1
```
Invoke-MgInviteGroupDriveItem -InputObject <IGroupsIdentity> [-AdditionalProperties <Hashtable>]
 [-ExpirationDateTime <String>] [-Message <String>] [-Password <String>]
 [-Recipients <IMicrosoftGraphDriveRecipient[]>] [-RequireSignIn] [-RetainInheritedPermissions]
 [-Roles <String[]>] [-SendInvitation] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action invite

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: InviteExpanded1, InviteViaIdentityExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.IPathsLx1Fn7GroupsGroupIdDrivesDriveIdItemsDriveitemIdMicrosoftGraphInvitePostRequestbodyContentApplicationJsonSchema1
Parameter Sets: Invite1, InviteViaIdentity1
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
Parameter Sets: Invite1, InviteExpanded1
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
Parameter Sets: Invite1, InviteExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExpirationDateTime
.

```yaml
Type: System.String
Parameter Sets: InviteExpanded1, InviteViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GroupId
The unique identifier of group

```yaml
Type: System.String
Parameter Sets: Invite1, InviteExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.IGroupsIdentity
Parameter Sets: InviteViaIdentity1, InviteViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Message
.

```yaml
Type: System.String
Parameter Sets: InviteExpanded1, InviteViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Password
.

```yaml
Type: System.String
Parameter Sets: InviteExpanded1, InviteViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Recipients
.
To construct, please use Get-Help -Online and see NOTES section for RECIPIENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDriveRecipient[]
Parameter Sets: InviteExpanded1, InviteViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RequireSignIn
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: InviteExpanded1, InviteViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RetainInheritedPermissions
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: InviteExpanded1, InviteViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Roles
.

```yaml
Type: System.String[]
Parameter Sets: InviteExpanded1, InviteViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SendInvitation
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: InviteExpanded1, InviteViaIdentityExpanded1
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

### Microsoft.Graph.PowerShell.Models.IGroupsIdentity

### Microsoft.Graph.PowerShell.Models.IPathsLx1Fn7GroupsGroupIdDrivesDriveIdItemsDriveitemIdMicrosoftGraphInvitePostRequestbodyContentApplicationJsonSchema1

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPermission

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPathsLx1Fn7GroupsGroupIdDrivesDriveIdItemsDriveitemIdMicrosoftGraphInvitePostRequestbodyContentApplicationJsonSchema1>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ExpirationDateTime <String>]`: 
  - `[Message <String>]`: 
  - `[Password <String>]`: 
  - `[Recipients <IMicrosoftGraphDriveRecipient[]>]`: 
    - `[Alias <String>]`: The alias of the domain object, for cases where an email address is unavailable (e.g. security groups).
    - `[Email <String>]`: The email address for the recipient, if the recipient has an associated email address.
    - `[ObjectId <String>]`: The unique identifier for the recipient in the directory.
  - `[RequireSignIn <Boolean?>]`: 
  - `[RetainInheritedPermissions <Boolean?>]`: 
  - `[Roles <String[]>]`: 
  - `[SendInvitation <Boolean?>]`: 

INPUTOBJECT <IGroupsIdentity>: Identity Parameter
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
  - `[GroupSettingId <String>]`: The unique identifier of groupSetting
  - `[GroupSettingTemplateId <String>]`: The unique identifier of groupSettingTemplate
  - `[HorizontalSectionColumnId <String>]`: The unique identifier of horizontalSectionColumn
  - `[HorizontalSectionId <String>]`: The unique identifier of horizontalSection
  - `[IncludePersonalNotebooks <Boolean?>]`: Usage: includePersonalNotebooks={includePersonalNotebooks}
  - `[Interval <String>]`: Usage: interval='{interval}'
  - `[ListId <String>]`: The unique identifier of list
  - `[ListId1 <String>]`: Usage: listId='{listId}'
  - `[ListItemId <String>]`: The unique identifier of listItem
  - `[ListItemVersionId <String>]`: The unique identifier of listItemVersion
  - `[MentionId <String>]`: The unique identifier of mention
  - `[MultiValueLegacyExtendedPropertyId <String>]`: The unique identifier of multiValueLegacyExtendedProperty
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
  - `[SingleValueLegacyExtendedPropertyId <String>]`: The unique identifier of singleValueLegacyExtendedProperty
  - `[SiteId <String>]`: The unique identifier of site
  - `[SitePageId <String>]`: The unique identifier of sitePage
  - `[StartDateTime <String>]`: Usage: startDateTime='{startDateTime}'
  - `[SubscriptionId <String>]`: The unique identifier of subscription
  - `[Token <String>]`: Usage: token='{token}'
  - `[User <String>]`: Usage: User='{User}'
  - `[UserId <String>]`: The unique identifier of user
  - `[WebPartId <String>]`: The unique identifier of webPart

RECIPIENTS <IMicrosoftGraphDriveRecipient[]>: .
  - `[Alias <String>]`: The alias of the domain object, for cases where an email address is unavailable (e.g. security groups).
  - `[Email <String>]`: The email address for the recipient, if the recipient has an associated email address.
  - `[ObjectId <String>]`: The unique identifier for the recipient in the directory.

## RELATED LINKS

