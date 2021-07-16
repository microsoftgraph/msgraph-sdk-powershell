---
external help file: Microsoft.Graph.Groups-help.xml
Module Name: Microsoft.Graph.Groups
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.groups/update-mggroupphoto
schema: 2.0.0
---

# Update-MgGroupPhoto

## SYNOPSIS
The group's profile photo.

## SYNTAX

### UpdateExpanded2 (Default)
```
Update-MgGroupPhoto -GroupId <String> [-AdditionalProperties <Hashtable>] [-Height <Int32>] [-Id <String>]
 [-Width <Int32>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateExpanded3
```
Update-MgGroupPhoto -GroupId <String> -ProfilePhotoId <String> [-AdditionalProperties <Hashtable>]
 [-Height <Int32>] [-Id <String>] [-Width <Int32>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Update3
```
Update-MgGroupPhoto -GroupId <String> -ProfilePhotoId <String> -BodyParameter <IMicrosoftGraphProfilePhoto>
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Update2
```
Update-MgGroupPhoto -GroupId <String> -BodyParameter <IMicrosoftGraphProfilePhoto> [-PassThru] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded3
```
Update-MgGroupPhoto -InputObject <IGroupsIdentity> [-AdditionalProperties <Hashtable>] [-Height <Int32>]
 [-Id <String>] [-Width <Int32>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded2
```
Update-MgGroupPhoto -InputObject <IGroupsIdentity> [-AdditionalProperties <Hashtable>] [-Height <Int32>]
 [-Id <String>] [-Width <Int32>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity3
```
Update-MgGroupPhoto -InputObject <IGroupsIdentity> -BodyParameter <IMicrosoftGraphProfilePhoto> [-PassThru]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity2
```
Update-MgGroupPhoto -InputObject <IGroupsIdentity> -BodyParameter <IMicrosoftGraphProfilePhoto> [-PassThru]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
The group's profile photo.

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: UpdateExpanded2, UpdateExpanded3, UpdateViaIdentityExpanded3, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
profilePhoto
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphProfilePhoto
Parameter Sets: Update3, Update2, UpdateViaIdentity3, UpdateViaIdentity2
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
Type: String
Parameter Sets: UpdateExpanded2, UpdateExpanded3, Update3, Update2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Height
The height of the photo.
Read-only.

```yaml
Type: Int32
Parameter Sets: UpdateExpanded2, UpdateExpanded3, UpdateViaIdentityExpanded3, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: String
Parameter Sets: UpdateExpanded2, UpdateExpanded3, UpdateViaIdentityExpanded3, UpdateViaIdentityExpanded2
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
Parameter Sets: UpdateViaIdentityExpanded3, UpdateViaIdentityExpanded2, UpdateViaIdentity3, UpdateViaIdentity2
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
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProfilePhotoId
key: id of profilePhoto

```yaml
Type: String
Parameter Sets: UpdateExpanded3, Update3
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Width
The width of the photo.
Read-only.

```yaml
Type: Int32
Parameter Sets: UpdateExpanded2, UpdateExpanded3, UpdateViaIdentityExpanded3, UpdateViaIdentityExpanded2
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
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProfilePhoto
## OUTPUTS

### System.Boolean
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphProfilePhoto>: profilePhoto
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Height <Int32?>]`: The height of the photo. Read-only.
  - `[Width <Int32?>]`: The width of the photo. Read-only.

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
