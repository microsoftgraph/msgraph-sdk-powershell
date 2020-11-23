---
external help file: Microsoft.Graph.Groups-help.xml
Module Name: Microsoft.Graph.Groups
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.groups/update-mggrouppermissiongrant
schema: 2.0.0
---

# Update-MgGroupPermissionGrant

## SYNOPSIS
Update the navigation property permissionGrants in groups

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgGroupPermissionGrant -GroupId <String> -ResourceSpecificPermissionGrantId <String>
 [-AdditionalProperties <Hashtable>] [-ClientAppId <String>] [-ClientId <String>] [-DeletedDateTime <DateTime>]
 [-Id <String>] [-Permission <String>] [-PermissionType <String>] [-ResourceAppId <String>] [-PassThru]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Update
```
Update-MgGroupPermissionGrant -GroupId <String> -ResourceSpecificPermissionGrantId <String>
 -BodyParameter <IMicrosoftGraphResourceSpecificPermissionGrant> [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgGroupPermissionGrant -InputObject <IGroupsIdentity> [-AdditionalProperties <Hashtable>]
 [-ClientAppId <String>] [-ClientId <String>] [-DeletedDateTime <DateTime>] [-Id <String>]
 [-Permission <String>] [-PermissionType <String>] [-ResourceAppId <String>] [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgGroupPermissionGrant -InputObject <IGroupsIdentity>
 -BodyParameter <IMicrosoftGraphResourceSpecificPermissionGrant> [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property permissionGrants in groups

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Represents an Azure Active Directory object.
The directoryObject type is the base type for many other directory entity types.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphResourceSpecificPermissionGrant
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ClientAppId
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClientId
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeletedDateTime
.

```yaml
Type: DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GroupId
key: id of group

```yaml
Type: String
Parameter Sets: UpdateExpanded, Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: IGroupsIdentity
Parameter Sets: UpdateViaIdentityExpanded, UpdateViaIdentity
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
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -Permission
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PermissionType
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceAppId
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceSpecificPermissionGrantId
key: id of resourceSpecificPermissionGrant

```yaml
Type: String
Parameter Sets: UpdateExpanded, Update
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
Type: SwitchParameter
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
Type: SwitchParameter
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
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphResourceSpecificPermissionGrant
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphResourceSpecificPermissionGrant\>: Represents an Azure Active Directory object.
The directoryObject type is the base type for many other directory entity types.
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[DeletedDateTime \<DateTime?\>\]: 
  \[Id \<String\>\]: Read-only.
  \[ClientAppId \<String\>\]: 
  \[ClientId \<String\>\]: 
  \[Permission \<String\>\]: 
  \[PermissionType \<String\>\]: 
  \[ResourceAppId \<String\>\]: 

INPUTOBJECT \<IGroupsIdentity\>: Identity Parameter
  \[AttachmentId \<String\>\]: key: id of attachment
  \[ConversationId \<String\>\]: key: id of conversation
  \[ConversationThreadId \<String\>\]: key: id of conversationThread
  \[DirectoryObjectId \<String\>\]: key: id of directoryObject
  \[DirectorySettingId \<String\>\]: key: id of directorySetting
  \[EndpointId \<String\>\]: key: id of endpoint
  \[EventId \<String\>\]: key: id of event
  \[ExtensionId \<String\>\]: key: id of extension
  \[GroupId \<String\>\]: key: id of group
  \[GroupLifecyclePolicyId \<String\>\]: key: id of groupLifecyclePolicy
  \[IncludePersonalNotebooks \<Boolean?\>\]: 
  \[MentionId \<String\>\]: key: id of mention
  \[MultiValueLegacyExtendedPropertyId \<String\>\]: key: id of multiValueLegacyExtendedProperty
  \[NotebookId \<String\>\]: key: id of notebook
  \[OnenotePageId \<String\>\]: key: id of onenotePage
  \[OnenoteSectionId \<String\>\]: key: id of onenoteSection
  \[PostId \<String\>\]: key: id of post
  \[ProfilePhotoId \<String\>\]: key: id of profilePhoto
  \[ResourceSpecificPermissionGrantId \<String\>\]: key: id of resourceSpecificPermissionGrant
  \[SingleValueLegacyExtendedPropertyId \<String\>\]: key: id of singleValueLegacyExtendedProperty
  \[User \<String\>\]: 
  \[UserId \<String\>\]: key: id of user

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.groups/update-mggrouppermissiongrant](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.groups/update-mggrouppermissiongrant)

