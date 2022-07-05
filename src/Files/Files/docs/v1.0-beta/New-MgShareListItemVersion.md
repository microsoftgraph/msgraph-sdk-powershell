---
external help file:
Module Name: Microsoft.Graph.Files
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.files/new-mgsharelistitemversion
schema: 2.0.0
---

# New-MgShareListItemVersion

## SYNOPSIS
Create new navigation property to versions for shares

## SYNTAX

### CreateExpanded3 (Default)
```
New-MgShareListItemVersion -SharedDriveItemId <String> [-AdditionalProperties <Hashtable>]
 [-Fields <Hashtable>] [-Id <String>] [-LastModifiedBy <IMicrosoftGraphIdentitySet>]
 [-LastModifiedDateTime <DateTime>] [-Publication <IMicrosoftGraphPublicationFacet>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create2
```
New-MgShareListItemVersion -ListItemId <String> -SharedDriveItemId <String>
 -BodyParameter <IMicrosoftGraphListItemVersion> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create3
```
New-MgShareListItemVersion -SharedDriveItemId <String> -BodyParameter <IMicrosoftGraphListItemVersion>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateExpanded2
```
New-MgShareListItemVersion -ListItemId <String> -SharedDriveItemId <String>
 [-AdditionalProperties <Hashtable>] [-Fields <Hashtable>] [-Id <String>]
 [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-LastModifiedDateTime <DateTime>]
 [-Publication <IMicrosoftGraphPublicationFacet>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity2
```
New-MgShareListItemVersion -InputObject <IFilesIdentity> -BodyParameter <IMicrosoftGraphListItemVersion>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity3
```
New-MgShareListItemVersion -InputObject <IFilesIdentity> -BodyParameter <IMicrosoftGraphListItemVersion>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded2
```
New-MgShareListItemVersion -InputObject <IFilesIdentity> [-AdditionalProperties <Hashtable>]
 [-Fields <Hashtable>] [-Id <String>] [-LastModifiedBy <IMicrosoftGraphIdentitySet>]
 [-LastModifiedDateTime <DateTime>] [-Publication <IMicrosoftGraphPublicationFacet>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentityExpanded3
```
New-MgShareListItemVersion -InputObject <IFilesIdentity> [-AdditionalProperties <Hashtable>]
 [-Fields <Hashtable>] [-Id <String>] [-LastModifiedBy <IMicrosoftGraphIdentitySet>]
 [-LastModifiedDateTime <DateTime>] [-Publication <IMicrosoftGraphPublicationFacet>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to versions for shares

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded2, CreateExpanded3, CreateViaIdentityExpanded2, CreateViaIdentityExpanded3
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
listItemVersion
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphListItemVersion
Parameter Sets: Create2, Create3, CreateViaIdentity2, CreateViaIdentity3
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Fields
fieldValueSet

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded2, CreateExpanded3, CreateViaIdentityExpanded2, CreateViaIdentityExpanded3
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded2, CreateExpanded3, CreateViaIdentityExpanded2, CreateViaIdentityExpanded3
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
Type: Microsoft.Graph.PowerShell.Models.IFilesIdentity
Parameter Sets: CreateViaIdentity2, CreateViaIdentity3, CreateViaIdentityExpanded2, CreateViaIdentityExpanded3
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastModifiedBy
identitySet
To construct, please use Get-Help -Online and see NOTES section for LASTMODIFIEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: CreateExpanded2, CreateExpanded3, CreateViaIdentityExpanded2, CreateViaIdentityExpanded3
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
Date and time the version was last modified.
Read-only.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded2, CreateExpanded3, CreateViaIdentityExpanded2, CreateViaIdentityExpanded3
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ListItemId
key: id of listItem

```yaml
Type: System.String
Parameter Sets: Create2, CreateExpanded2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Publication
publicationFacet
To construct, please use Get-Help -Online and see NOTES section for PUBLICATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPublicationFacet
Parameter Sets: CreateExpanded2, CreateExpanded3, CreateViaIdentityExpanded2, CreateViaIdentityExpanded3
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SharedDriveItemId
key: id of sharedDriveItem

```yaml
Type: System.String
Parameter Sets: Create2, Create3, CreateExpanded2, CreateExpanded3
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

### Microsoft.Graph.PowerShell.Models.IFilesIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphListItemVersion

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphListItemVersion

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphListItemVersion>: listItemVersion
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[LastModifiedDateTime <DateTime?>]`: Date and time the version was last modified. Read-only.
  - `[Publication <IMicrosoftGraphPublicationFacet>]`: publicationFacet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Level <String>]`: The state of publication for this document. Either published or checkout. Read-only.
    - `[VersionId <String>]`: The unique identifier for the version that is visible to the current caller. Read-only.
  - `[Id <String>]`: 
  - `[Fields <IMicrosoftGraphFieldValueSet>]`: fieldValueSet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 

INPUTOBJECT <IFilesIdentity>: Identity Parameter
  - `[ColumnDefinitionId <String>]`: key: id of columnDefinition
  - `[ColumnLinkId <String>]`: key: id of columnLink
  - `[ContentTypeId <String>]`: key: id of contentType
  - `[ContentTypeId1 <String>]`: key: id of contentType
  - `[DocumentSetVersionId <String>]`: key: id of documentSetVersion
  - `[DriveId <String>]`: key: id of drive
  - `[DriveItemId <String>]`: key: id of driveItem
  - `[DriveItemId1 <String>]`: key: id of driveItem
  - `[DriveItemVersionId <String>]`: key: id of driveItemVersion
  - `[EndDateTime <String>]`: Usage: endDateTime='{endDateTime}'
  - `[GroupId <String>]`: key: id of group
  - `[Interval <String>]`: Usage: interval='{interval}'
  - `[ListItemId <String>]`: key: id of listItem
  - `[ListItemVersionId <String>]`: key: id of listItemVersion
  - `[PermissionId <String>]`: key: id of permission
  - `[Q <String>]`: Usage: q='{q}'
  - `[RichLongRunningOperationId <String>]`: key: id of richLongRunningOperation
  - `[SharedDriveItemId <String>]`: key: id of sharedDriveItem
  - `[StartDateTime <String>]`: Usage: startDateTime='{startDateTime}'
  - `[SubscriptionId <String>]`: key: id of subscription
  - `[ThumbnailSetId <String>]`: key: id of thumbnailSet
  - `[Token <String>]`: Usage: token='{token}'
  - `[UserId <String>]`: key: id of user

LASTMODIFIEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

PUBLICATION <IMicrosoftGraphPublicationFacet>: publicationFacet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Level <String>]`: The state of publication for this document. Either published or checkout. Read-only.
  - `[VersionId <String>]`: The unique identifier for the version that is visible to the current caller. Read-only.

## RELATED LINKS

