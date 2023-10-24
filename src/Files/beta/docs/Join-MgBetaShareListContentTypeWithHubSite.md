---
external help file:
Module Name: Microsoft.Graph.Beta.Files
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.files/join-mgbetasharelistcontenttypewithhubsite
schema: 2.0.0
---

# Join-MgBetaShareListContentTypeWithHubSite

## SYNOPSIS
Associate a content type][contentType] with a list of hub sites.
This API is available in the following [national cloud deployments.

## SYNTAX

### AssociateExpanded (Default)
```
Join-MgBetaShareListContentTypeWithHubSite -ContentTypeId <String> -SharedDriveItemId <String>
 [-AdditionalProperties <Hashtable>] [-HubSiteUrls <String[]>] [-PropagateToExistingLists] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Associate
```
Join-MgBetaShareListContentTypeWithHubSite -ContentTypeId <String> -SharedDriveItemId <String>
 -BodyParameter <IPaths8Cnul4SharesShareddriveitemIdListContenttypesContenttypeIdMicrosoftGraphAssociatewithhubsitesPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### AssociateViaIdentity
```
Join-MgBetaShareListContentTypeWithHubSite -InputObject <IFilesIdentity>
 -BodyParameter <IPaths8Cnul4SharesShareddriveitemIdListContenttypesContenttypeIdMicrosoftGraphAssociatewithhubsitesPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### AssociateViaIdentityExpanded
```
Join-MgBetaShareListContentTypeWithHubSite -InputObject <IFilesIdentity> [-AdditionalProperties <Hashtable>]
 [-HubSiteUrls <String[]>] [-PropagateToExistingLists] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Associate a content type][contentType] with a list of hub sites.
This API is available in the following [national cloud deployments.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: AssociateExpanded, AssociateViaIdentityExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths8Cnul4SharesShareddriveitemIdListContenttypesContenttypeIdMicrosoftGraphAssociatewithhubsitesPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Associate, AssociateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ContentTypeId
The unique identifier of contentType

```yaml
Type: System.String
Parameter Sets: Associate, AssociateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HubSiteUrls
.

```yaml
Type: System.String[]
Parameter Sets: AssociateExpanded, AssociateViaIdentityExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IFilesIdentity
Parameter Sets: AssociateViaIdentity, AssociateViaIdentityExpanded
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

### -PropagateToExistingLists
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: AssociateExpanded, AssociateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SharedDriveItemId
The unique identifier of sharedDriveItem

```yaml
Type: System.String
Parameter Sets: Associate, AssociateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IFilesIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IPaths8Cnul4SharesShareddriveitemIdListContenttypesContenttypeIdMicrosoftGraphAssociatewithhubsitesPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPaths8Cnul4SharesShareddriveitemIdListContenttypesContenttypeIdMicrosoftGraphAssociatewithhubsitesPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[HubSiteUrls <String[]>]`: 
  - `[PropagateToExistingLists <Boolean?>]`: 

`INPUTOBJECT <IFilesIdentity>`: Identity Parameter
  - `[ColumnDefinitionId <String>]`: The unique identifier of columnDefinition
  - `[ColumnLinkId <String>]`: The unique identifier of columnLink
  - `[ContentTypeId <String>]`: The unique identifier of contentType
  - `[ContentTypeId1 <String>]`: The unique identifier of contentType
  - `[DocumentSetVersionId <String>]`: The unique identifier of documentSetVersion
  - `[DriveId <String>]`: The unique identifier of drive
  - `[DriveItemId <String>]`: The unique identifier of driveItem
  - `[DriveItemId1 <String>]`: The unique identifier of driveItem
  - `[DriveItemVersionId <String>]`: The unique identifier of driveItemVersion
  - `[EndDateTime <String>]`: Usage: endDateTime='{endDateTime}'
  - `[GroupId <String>]`: The unique identifier of group
  - `[Interval <String>]`: Usage: interval='{interval}'
  - `[ItemActivityStatId <String>]`: The unique identifier of itemActivityStat
  - `[ListItemId <String>]`: The unique identifier of listItem
  - `[ListItemVersionId <String>]`: The unique identifier of listItemVersion
  - `[PermissionId <String>]`: The unique identifier of permission
  - `[Q <String>]`: Usage: q='{q}'
  - `[RichLongRunningOperationId <String>]`: The unique identifier of richLongRunningOperation
  - `[SharedDriveItemId <String>]`: The unique identifier of sharedDriveItem
  - `[StartDateTime <String>]`: Usage: startDateTime='{startDateTime}'
  - `[SubscriptionId <String>]`: The unique identifier of subscription
  - `[ThumbnailSetId <String>]`: The unique identifier of thumbnailSet
  - `[Token <String>]`: Usage: token='{token}'
  - `[UserId <String>]`: The unique identifier of user

## RELATED LINKS

