---
external help file:
Module Name: Microsoft.Graph.Files.Drives
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.files.drives/update-mgdrivelistcontenttype
schema: 2.0.0
---

# Update-MgDriveListContentType

## SYNOPSIS
Update the navigation property contentTypes in drive

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgDriveListContentType -ContentTypeId <String> [-ColumnLinks <IMicrosoftGraphColumnLink[]>]
 [-Description <String>] [-Group <String>] [-Hidden] [-Id <String>]
 [-InheritedFrom <IMicrosoftGraphItemReference>] [-Name <String>] [-OrderDefault] [-OrderPosition <Int32>]
 [-ParentId <String>] [-ReadOnly] [-Sealed] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgDriveListContentType -ContentTypeId <String> -BodyParameter <IMicrosoftGraphContentType> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update2
```
Update-MgDriveListContentType -ContentTypeId <String> -DriveId <String>
 -BodyParameter <IMicrosoftGraphContentType> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateExpanded2
```
Update-MgDriveListContentType -ContentTypeId <String> -DriveId <String>
 [-ColumnLinks <IMicrosoftGraphColumnLink[]>] [-Description <String>] [-Group <String>] [-Hidden]
 [-Id <String>] [-InheritedFrom <IMicrosoftGraphItemReference>] [-Name <String>] [-OrderDefault]
 [-OrderPosition <Int32>] [-ParentId <String>] [-ReadOnly] [-Sealed] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgDriveListContentType -InputObject <IFilesDrivesIdentity> -BodyParameter <IMicrosoftGraphContentType>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity2
```
Update-MgDriveListContentType -InputObject <IFilesDrivesIdentity> -BodyParameter <IMicrosoftGraphContentType>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgDriveListContentType -InputObject <IFilesDrivesIdentity> [-ColumnLinks <IMicrosoftGraphColumnLink[]>]
 [-Description <String>] [-Group <String>] [-Hidden] [-Id <String>]
 [-InheritedFrom <IMicrosoftGraphItemReference>] [-Name <String>] [-OrderDefault] [-OrderPosition <Int32>]
 [-ParentId <String>] [-ReadOnly] [-Sealed] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded2
```
Update-MgDriveListContentType -InputObject <IFilesDrivesIdentity> [-ColumnLinks <IMicrosoftGraphColumnLink[]>]
 [-Description <String>] [-Group <String>] [-Hidden] [-Id <String>]
 [-InheritedFrom <IMicrosoftGraphItemReference>] [-Name <String>] [-OrderDefault] [-OrderPosition <Int32>]
 [-ParentId <String>] [-ReadOnly] [-Sealed] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property contentTypes in drive

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -BodyParameter
contentType
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphContentType
Parameter Sets: Update1, Update2, UpdateViaIdentity1, UpdateViaIdentity2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ColumnLinks
The collection of columns that are required by this content type
To construct, see NOTES section for COLUMNLINKS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphColumnLink[]
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContentTypeId
key: contentType-id of contentType

```yaml
Type: System.String
Parameter Sets: Update1, Update2, UpdateExpanded1, UpdateExpanded2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
The descriptive text for the item.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DriveId
key: drive-id of drive

```yaml
Type: System.String
Parameter Sets: Update2, UpdateExpanded2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Group
The name of the group this content type belongs to.
Helps organize related content types.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Hidden
Indicates whether the content type is hidden in the list's 'New' menu.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
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
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InheritedFrom
itemReference
To construct, see NOTES section for INHERITEDFROM properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphItemReference
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
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
Type: Microsoft.Graph.PowerShell.Models.IFilesDrivesIdentity
Parameter Sets: UpdateViaIdentity1, UpdateViaIdentity2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Name
The name of the content type.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OrderDefault
Whether this is the default Content Type

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OrderPosition
Specifies the position in which the Content Type appears in the selection UI.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParentId
The unique identifier of the content type.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
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

### -ReadOnly
If true, the content type cannot be modified unless this value is first set to false.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sealed
If true, the content type cannot be modified by users or through push-down operations.
Only site collection administrators can seal or unseal content types.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded1, UpdateExpanded2, UpdateViaIdentityExpanded1, UpdateViaIdentityExpanded2
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

### Microsoft.Graph.PowerShell.Models.IFilesDrivesIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphContentType

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphContentType>: contentType
  - `[Id <String>]`: Read-only.
  - `[ColumnLinks <IMicrosoftGraphColumnLink[]>]`: The collection of columns that are required by this content type
    - `[Id <String>]`: Read-only.
    - `[Name <String>]`: The name of the column  in this content type.
  - `[Description <String>]`: The descriptive text for the item.
  - `[Group <String>]`: The name of the group this content type belongs to. Helps organize related content types.
  - `[Hidden <Boolean?>]`: Indicates whether the content type is hidden in the list's 'New' menu.
  - `[InheritedFrom <IMicrosoftGraphItemReference>]`: itemReference
    - `[DriveId <String>]`: Unique identifier of the drive instance that contains the item. Read-only.
    - `[DriveType <String>]`: Identifies the type of drive. See [drive][] resource for values.
    - `[Id <String>]`: Unique identifier of the item in the drive. Read-only.
    - `[Name <String>]`: The name of the item being referenced. Read-only.
    - `[Path <String>]`: Path that can be used to navigate to the item. Read-only.
    - `[ShareId <String>]`: A unique identifier for a shared resource that can be accessed via the [Shares][] API.
    - `[SharepointIds <IMicrosoftGraphSharepointIds>]`: sharepointIds
      - `[ListId <String>]`: The unique identifier (guid) for the item's list in SharePoint.
      - `[ListItemId <String>]`: An integer identifier for the item within the containing list.
      - `[ListItemUniqueId <String>]`: The unique identifier (guid) for the item within OneDrive for Business or a SharePoint site.
      - `[SiteId <String>]`: The unique identifier (guid) for the item's site collection (SPSite).
      - `[SiteUrl <String>]`: The SharePoint URL for the site that contains the item.
      - `[TenantId <String>]`: The unique identifier (guid) for the tenancy.
      - `[WebId <String>]`: The unique identifier (guid) for the item's site (SPWeb).
    - `[SiteId <String>]`: 
  - `[Name <String>]`: The name of the content type.
  - `[OrderDefault <Boolean?>]`: Whether this is the default Content Type
  - `[OrderPosition <Int32?>]`: Specifies the position in which the Content Type appears in the selection UI.
  - `[ParentId <String>]`: The unique identifier of the content type.
  - `[ReadOnly <Boolean?>]`: If true, the content type cannot be modified unless this value is first set to false.
  - `[Sealed <Boolean?>]`: If true, the content type cannot be modified by users or through push-down operations. Only site collection administrators can seal or unseal content types.

COLUMNLINKS <IMicrosoftGraphColumnLink[]>: The collection of columns that are required by this content type
  - `[Id <String>]`: Read-only.
  - `[Name <String>]`: The name of the column  in this content type.

INHERITEDFROM <IMicrosoftGraphItemReference>: itemReference
  - `[DriveId <String>]`: Unique identifier of the drive instance that contains the item. Read-only.
  - `[DriveType <String>]`: Identifies the type of drive. See [drive][] resource for values.
  - `[Id <String>]`: Unique identifier of the item in the drive. Read-only.
  - `[Name <String>]`: The name of the item being referenced. Read-only.
  - `[Path <String>]`: Path that can be used to navigate to the item. Read-only.
  - `[ShareId <String>]`: A unique identifier for a shared resource that can be accessed via the [Shares][] API.
  - `[SharepointIds <IMicrosoftGraphSharepointIds>]`: sharepointIds
    - `[ListId <String>]`: The unique identifier (guid) for the item's list in SharePoint.
    - `[ListItemId <String>]`: An integer identifier for the item within the containing list.
    - `[ListItemUniqueId <String>]`: The unique identifier (guid) for the item within OneDrive for Business or a SharePoint site.
    - `[SiteId <String>]`: The unique identifier (guid) for the item's site collection (SPSite).
    - `[SiteUrl <String>]`: The SharePoint URL for the site that contains the item.
    - `[TenantId <String>]`: The unique identifier (guid) for the tenancy.
    - `[WebId <String>]`: The unique identifier (guid) for the item's site (SPWeb).
  - `[SiteId <String>]`: 

INPUTOBJECT <IFilesDrivesIdentity>: Identity Parameter
  - `[ColumnDefinitionId <String>]`: key: columnDefinition-id of columnDefinition
  - `[ColumnLinkId <String>]`: key: columnLink-id of columnLink
  - `[ContentTypeId <String>]`: key: contentType-id of contentType
  - `[DriveId <String>]`: key: drive-id of drive
  - `[DriveItemId <String>]`: key: driveItem-id of driveItem
  - `[EndDateTime <String>]`: 
  - `[Interval <String>]`: 
  - `[ItemActivityOldId <String>]`: key: itemActivityOLD-id of itemActivityOLD
  - `[ItemActivityOldId1 <String>]`: key: itemActivityOLD-id of itemActivityOLD
  - `[ListItemId <String>]`: key: listItem-id of listItem
  - `[ListItemVersionId <String>]`: key: listItemVersion-id of listItemVersion
  - `[Q <String>]`: 
  - `[StartDateTime <String>]`: 
  - `[SubscriptionId <String>]`: key: subscription-id of subscription

## RELATED LINKS

