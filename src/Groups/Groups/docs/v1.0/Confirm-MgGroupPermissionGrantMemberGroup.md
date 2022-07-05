---
external help file:
Module Name: Microsoft.Graph.Groups
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.groups/confirm-mggrouppermissiongrantmembergroup
schema: 2.0.0
---

# Confirm-MgGroupPermissionGrantMemberGroup

## SYNOPSIS
Invoke action checkMemberGroups

## SYNTAX

### CheckExpanded1 (Default)
```
Confirm-MgGroupPermissionGrantMemberGroup -GroupId <String> -ResourceSpecificPermissionGrantId <String>
 [-AdditionalProperties <Hashtable>] [-GroupIds <String[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Check1
```
Confirm-MgGroupPermissionGrantMemberGroup -GroupId <String> -ResourceSpecificPermissionGrantId <String>
 -BodyParameter <IPaths1Dr4KhqGroupsGroupIdPermissiongrantsResourcespecificpermissiongrantIdMicrosoftGraphCheckmembergroupsPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CheckViaIdentity1
```
Confirm-MgGroupPermissionGrantMemberGroup -InputObject <IGroupsIdentity>
 -BodyParameter <IPaths1Dr4KhqGroupsGroupIdPermissiongrantsResourcespecificpermissiongrantIdMicrosoftGraphCheckmembergroupsPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CheckViaIdentityExpanded1
```
Confirm-MgGroupPermissionGrantMemberGroup -InputObject <IGroupsIdentity> [-AdditionalProperties <Hashtable>]
 [-GroupIds <String[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action checkMemberGroups

## EXAMPLES

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
Type: Microsoft.Graph.PowerShell.Models.IPaths1Dr4KhqGroupsGroupIdPermissiongrantsResourcespecificpermissiongrantIdMicrosoftGraphCheckmembergroupsPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Check1, CheckViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -GroupId
key: id of group

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

### -GroupIds
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
Type: Microsoft.Graph.PowerShell.Models.IGroupsIdentity
Parameter Sets: CheckViaIdentity1, CheckViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ResourceSpecificPermissionGrantId
key: id of resourceSpecificPermissionGrant

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

### Microsoft.Graph.PowerShell.Models.IGroupsIdentity

### Microsoft.Graph.PowerShell.Models.IPaths1Dr4KhqGroupsGroupIdPermissiongrantsResourcespecificpermissiongrantIdMicrosoftGraphCheckmembergroupsPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1Dr4KhqGroupsGroupIdPermissiongrantsResourcespecificpermissiongrantIdMicrosoftGraphCheckmembergroupsPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[GroupIds <String[]>]`: 

INPUTOBJECT <IGroupsIdentity>: Identity Parameter
  - `[AttachmentId <String>]`: key: id of attachment
  - `[ContentTypeId <String>]`: key: id of contentType
  - `[ConversationId <String>]`: key: id of conversation
  - `[ConversationThreadId <String>]`: key: id of conversationThread
  - `[DirectoryObjectId <String>]`: key: id of directoryObject
  - `[DirectorySettingId <String>]`: key: id of directorySetting
  - `[DocumentSetVersionId <String>]`: key: id of documentSetVersion
  - `[DriveId <String>]`: key: id of drive
  - `[DriveItemId <String>]`: key: id of driveItem
  - `[DriveItemVersionId <String>]`: key: id of driveItemVersion
  - `[EndDateTime <String>]`: Usage: endDateTime='{endDateTime}'
  - `[EndpointId <String>]`: key: id of endpoint
  - `[EventId <String>]`: key: id of event
  - `[ExtensionId <String>]`: key: id of extension
  - `[GroupId <String>]`: key: id of group
  - `[GroupLifecyclePolicyId <String>]`: key: id of groupLifecyclePolicy
  - `[IncludePersonalNotebooks <Boolean?>]`: Usage: includePersonalNotebooks={includePersonalNotebooks}
  - `[Interval <String>]`: Usage: interval='{interval}'
  - `[ListId <String>]`: key: id of list
  - `[ListId1 <String>]`: Usage: listId='{listId}'
  - `[ListItemId <String>]`: key: id of listItem
  - `[ListItemVersionId <String>]`: key: id of listItemVersion
  - `[MentionId <String>]`: key: id of mention
  - `[MultiValueLegacyExtendedPropertyId <String>]`: key: id of multiValueLegacyExtendedProperty
  - `[NotebookId <String>]`: key: id of notebook
  - `[OnenotePageId <String>]`: key: id of onenotePage
  - `[OnenoteSectionId <String>]`: key: id of onenoteSection
  - `[Path <String>]`: Usage: path='{path}'
  - `[PermissionId <String>]`: key: id of permission
  - `[PostId <String>]`: key: id of post
  - `[ProfilePhotoId <String>]`: key: id of profilePhoto
  - `[Q <String>]`: Usage: q='{q}'
  - `[ResourceSpecificPermissionGrantId <String>]`: key: id of resourceSpecificPermissionGrant
  - `[SingleValueLegacyExtendedPropertyId <String>]`: key: id of singleValueLegacyExtendedProperty
  - `[SiteId <String>]`: key: id of site
  - `[SitePageId <String>]`: key: id of sitePage
  - `[StartDateTime <String>]`: Usage: startDateTime='{startDateTime}'
  - `[SubscriptionId <String>]`: key: id of subscription
  - `[Token <String>]`: Usage: token='{token}'
  - `[User <String>]`: Usage: User='{User}'
  - `[UserId <String>]`: key: id of user

## RELATED LINKS

