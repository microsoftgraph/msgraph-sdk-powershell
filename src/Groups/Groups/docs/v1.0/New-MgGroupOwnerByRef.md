---
external help file:
Module Name: Microsoft.Graph.Groups
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.groups/new-mggroupownerbyref
schema: 2.0.0
---

# New-MgGroupOwnerByRef

## SYNOPSIS
The owners of the group who can be users or service principals.
Nullable.
If this property is not specified when creating a Microsoft 365 group, the calling user is automatically assigned as the group owner.
Supports $expand including nested $select.
For example, /groups?$filter=startsWith(displayName,'Role')&$select=id,displayName&$expand=owners($select=id,userPrincipalName,displayName).

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgGroupOwnerByRef -GroupId <String> [-AdditionalProperties <Hashtable>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create1
```
New-MgGroupOwnerByRef -GroupId <String> -BodyParameter <Hashtable> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity1
```
New-MgGroupOwnerByRef -InputObject <IGroupsIdentity> -BodyParameter <Hashtable> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentityExpanded1
```
New-MgGroupOwnerByRef -InputObject <IGroupsIdentity> [-AdditionalProperties <Hashtable>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
The owners of the group who can be users or service principals.
Nullable.
If this property is not specified when creating a Microsoft 365 group, the calling user is automatically assigned as the group owner.
Supports $expand including nested $select.
For example, /groups?$filter=startsWith(displayName,'Role')&$select=id,displayName&$expand=owners($select=id,userPrincipalName,displayName).

## EXAMPLES

### Example 1: Add an owner to a group
```powershell
$newGroupOwner =@{
  "@odata.id"= "https://graph.microsoft.com/v1.0/users/{4de19c17-6a28-4a91-86d1-f717c3c8c229}"
  }

New-MgGroupOwnerByRef -GroupId '1cb7317c-9c49-4dc8-a358-67ad8e95217c' -BodyParameter $newGroupOwner
```

In this example, the first command defines the value of the $newGroupOwner variable.
The second command creates the value is an owner of the specified group.

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded1, CreateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.

```yaml
Type: System.Collections.Hashtable
Parameter Sets: Create1, CreateViaIdentity1
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
Parameter Sets: Create1, CreateExpanded1
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
Parameter Sets: CreateViaIdentity1, CreateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### System.Collections.Hashtable

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IPaths1Hc8E36GroupsGroupIdOwnersRefPostResponses201ContentApplicationJsonSchema

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IGroupsIdentity>: Identity Parameter
  - `[AttachmentId <String>]`: key: id of attachment
  - `[ConversationId <String>]`: key: id of conversation
  - `[ConversationThreadId <String>]`: key: id of conversationThread
  - `[DirectorySettingId <String>]`: key: id of directorySetting
  - `[EndpointId <String>]`: key: id of endpoint
  - `[EventId <String>]`: key: id of event
  - `[ExtensionId <String>]`: key: id of extension
  - `[GroupId <String>]`: key: id of group
  - `[GroupLifecyclePolicyId <String>]`: key: id of groupLifecyclePolicy
  - `[IncludePersonalNotebooks <Boolean?>]`: Usage: includePersonalNotebooks={includePersonalNotebooks}
  - `[MentionId <String>]`: key: id of mention
  - `[MultiValueLegacyExtendedPropertyId <String>]`: key: id of multiValueLegacyExtendedProperty
  - `[NotebookId <String>]`: key: id of notebook
  - `[OnenotePageId <String>]`: key: id of onenotePage
  - `[OnenoteSectionId <String>]`: key: id of onenoteSection
  - `[PostId <String>]`: key: id of post
  - `[ProfilePhotoId <String>]`: key: id of profilePhoto
  - `[ResourceSpecificPermissionGrantId <String>]`: key: id of resourceSpecificPermissionGrant
  - `[SingleValueLegacyExtendedPropertyId <String>]`: key: id of singleValueLegacyExtendedProperty
  - `[User <String>]`: Usage: User={User}
  - `[UserId <String>]`: key: id of user

## RELATED LINKS

