---
external help file:
Module Name: Microsoft.Graph.Files
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.files/new-mggroupdriveitemthumbnail
schema: 2.0.0
---

# New-MgGroupDriveItemThumbnail

## SYNOPSIS
Create new navigation property to thumbnails for groups

## SYNTAX

### CreateExpanded (Default)
```
New-MgGroupDriveItemThumbnail -DriveId <String> -DriveItemId <String> -GroupId <String>
 [-AdditionalProperties <Hashtable>] [-Id <String>] [-Large <IMicrosoftGraphThumbnail>]
 [-Medium <IMicrosoftGraphThumbnail>] [-Small <IMicrosoftGraphThumbnail>] [-Source <IMicrosoftGraphThumbnail>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgGroupDriveItemThumbnail -DriveId <String> -DriveItemId <String> -GroupId <String>
 -BodyParameter <IMicrosoftGraphThumbnailSet> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgGroupDriveItemThumbnail -InputObject <IFilesIdentity> -BodyParameter <IMicrosoftGraphThumbnailSet>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgGroupDriveItemThumbnail -InputObject <IFilesIdentity> [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-Large <IMicrosoftGraphThumbnail>] [-Medium <IMicrosoftGraphThumbnail>] [-Small <IMicrosoftGraphThumbnail>]
 [-Source <IMicrosoftGraphThumbnail>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to thumbnails for groups

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
thumbnailSet
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphThumbnailSet
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DriveId
key: id of drive

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DriveItemId
key: id of driveItem

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GroupId
key: id of group

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Large
thumbnail
To construct, please use Get-Help -Online and see NOTES section for LARGE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphThumbnail
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Medium
thumbnail
To construct, please use Get-Help -Online and see NOTES section for MEDIUM properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphThumbnail
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Small
thumbnail
To construct, please use Get-Help -Online and see NOTES section for SMALL properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphThumbnail
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Source
thumbnail
To construct, please use Get-Help -Online and see NOTES section for SOURCE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphThumbnail
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IFilesIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphThumbnailSet

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphThumbnailSet

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphThumbnailSet>: thumbnailSet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Large <IMicrosoftGraphThumbnail>]`: thumbnail
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Content <Byte[]>]`: The content stream for the thumbnail.
    - `[Height <Int32?>]`: The height of the thumbnail, in pixels.
    - `[SourceItemId <String>]`: The unique identifier of the item that provided the thumbnail. This is only available when a folder thumbnail is requested.
    - `[Url <String>]`: The URL used to fetch the thumbnail content.
    - `[Width <Int32?>]`: The width of the thumbnail, in pixels.
  - `[Medium <IMicrosoftGraphThumbnail>]`: thumbnail
  - `[Small <IMicrosoftGraphThumbnail>]`: thumbnail
  - `[Source <IMicrosoftGraphThumbnail>]`: thumbnail

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

LARGE <IMicrosoftGraphThumbnail>: thumbnail
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Content <Byte[]>]`: The content stream for the thumbnail.
  - `[Height <Int32?>]`: The height of the thumbnail, in pixels.
  - `[SourceItemId <String>]`: The unique identifier of the item that provided the thumbnail. This is only available when a folder thumbnail is requested.
  - `[Url <String>]`: The URL used to fetch the thumbnail content.
  - `[Width <Int32?>]`: The width of the thumbnail, in pixels.

MEDIUM <IMicrosoftGraphThumbnail>: thumbnail
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Content <Byte[]>]`: The content stream for the thumbnail.
  - `[Height <Int32?>]`: The height of the thumbnail, in pixels.
  - `[SourceItemId <String>]`: The unique identifier of the item that provided the thumbnail. This is only available when a folder thumbnail is requested.
  - `[Url <String>]`: The URL used to fetch the thumbnail content.
  - `[Width <Int32?>]`: The width of the thumbnail, in pixels.

SMALL <IMicrosoftGraphThumbnail>: thumbnail
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Content <Byte[]>]`: The content stream for the thumbnail.
  - `[Height <Int32?>]`: The height of the thumbnail, in pixels.
  - `[SourceItemId <String>]`: The unique identifier of the item that provided the thumbnail. This is only available when a folder thumbnail is requested.
  - `[Url <String>]`: The URL used to fetch the thumbnail content.
  - `[Width <Int32?>]`: The width of the thumbnail, in pixels.

SOURCE <IMicrosoftGraphThumbnail>: thumbnail
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Content <Byte[]>]`: The content stream for the thumbnail.
  - `[Height <Int32?>]`: The height of the thumbnail, in pixels.
  - `[SourceItemId <String>]`: The unique identifier of the item that provided the thumbnail. This is only available when a folder thumbnail is requested.
  - `[Url <String>]`: The URL used to fetch the thumbnail content.
  - `[Width <Int32?>]`: The width of the thumbnail, in pixels.

## RELATED LINKS

