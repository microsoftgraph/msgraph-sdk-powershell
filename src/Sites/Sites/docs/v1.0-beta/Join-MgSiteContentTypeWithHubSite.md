---
external help file:
Module Name: Microsoft.Graph.Sites
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.sites/join-mgsitecontenttypewithhubsite
schema: 2.0.0
---

# Join-MgSiteContentTypeWithHubSite

## SYNOPSIS
Associate a [content type][contentType] with a list of hub sites.

## SYNTAX

### AssociateExpanded (Default)
```
Join-MgSiteContentTypeWithHubSite -ContentTypeId <String> -SiteId <String> [-AdditionalProperties <Hashtable>]
 [-HubSiteUrls <String[]>] [-PropagateToExistingLists] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Associate
```
Join-MgSiteContentTypeWithHubSite -ContentTypeId <String> -SiteId <String>
 -BodyParameter <IPaths1IvodsgSitesSiteIdContenttypesContenttypeIdMicrosoftGraphAssociatewithhubsitesPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### AssociateViaIdentity
```
Join-MgSiteContentTypeWithHubSite -InputObject <ISitesIdentity>
 -BodyParameter <IPaths1IvodsgSitesSiteIdContenttypesContenttypeIdMicrosoftGraphAssociatewithhubsitesPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### AssociateViaIdentityExpanded
```
Join-MgSiteContentTypeWithHubSite -InputObject <ISitesIdentity> [-AdditionalProperties <Hashtable>]
 [-HubSiteUrls <String[]>] [-PropagateToExistingLists] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Associate a [content type][contentType] with a list of hub sites.

## EXAMPLES

### Example 1: Using the Join-MgSiteContentTypeWithHubSite Cmdlet
```powershell
Import-Module Microsoft.Graph.Sites
$params = @{
	HubSiteUrls = @(
		"https://graph.microsoft.com/beta/sites/id"
	)
	PropagateToExistingLists = $false
}
Join-MgSiteContentTypeWithHubSite -SiteId $siteId -ContentTypeId $contentTypeId -BodyParameter $params
```

This example shows how to use the Join-MgSiteContentTypeWithHubSite Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

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
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPaths1IvodsgSitesSiteIdContenttypesContenttypeIdMicrosoftGraphAssociatewithhubsitesPostRequestbodyContentApplicationJsonSchema
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
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.ISitesIdentity
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

### -SiteId
The unique identifier of site

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

### Microsoft.Graph.PowerShell.Models.IPaths1IvodsgSitesSiteIdContenttypesContenttypeIdMicrosoftGraphAssociatewithhubsitesPostRequestbodyContentApplicationJsonSchema

### Microsoft.Graph.PowerShell.Models.ISitesIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1IvodsgSitesSiteIdContenttypesContenttypeIdMicrosoftGraphAssociatewithhubsitesPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[HubSiteUrls <String[]>]`: 
  - `[PropagateToExistingLists <Boolean?>]`: 

INPUTOBJECT <ISitesIdentity>: Identity Parameter
  - `[BaseItemId <String>]`: The unique identifier of baseItem
  - `[BitlockerRecoveryKeyId <String>]`: The unique identifier of bitlockerRecoveryKey
  - `[ColumnDefinitionId <String>]`: The unique identifier of columnDefinition
  - `[ColumnLinkId <String>]`: The unique identifier of columnLink
  - `[ContentTypeId <String>]`: The unique identifier of contentType
  - `[ContentTypeId1 <String>]`: The unique identifier of contentType
  - `[DataLossPreventionPolicyId <String>]`: The unique identifier of dataLossPreventionPolicy
  - `[DocumentSetVersionId <String>]`: The unique identifier of documentSetVersion
  - `[DriveId <String>]`: The unique identifier of drive
  - `[EndDateTime <String>]`: Usage: endDateTime='{endDateTime}'
  - `[GroupId <String>]`: The unique identifier of group
  - `[GroupId1 <String>]`: The unique identifier of group
  - `[HorizontalSectionColumnId <String>]`: The unique identifier of horizontalSectionColumn
  - `[HorizontalSectionId <String>]`: The unique identifier of horizontalSection
  - `[IncludePersonalNotebooks <Boolean?>]`: Usage: includePersonalNotebooks={includePersonalNotebooks}
  - `[InformationProtectionLabelId <String>]`: The unique identifier of informationProtectionLabel
  - `[Interval <String>]`: Usage: interval='{interval}'
  - `[ListId <String>]`: The unique identifier of list
  - `[ListId1 <String>]`: Usage: listId='{listId}'
  - `[ListItemId <String>]`: The unique identifier of listItem
  - `[ListItemVersionId <String>]`: The unique identifier of listItemVersion
  - `[NotebookId <String>]`: The unique identifier of notebook
  - `[OnenotePageId <String>]`: The unique identifier of onenotePage
  - `[OnenoteSectionId <String>]`: The unique identifier of onenoteSection
  - `[Path <String>]`: Usage: path='{path}'
  - `[PermissionId <String>]`: The unique identifier of permission
  - `[RelationId <String>]`: The unique identifier of relation
  - `[RichLongRunningOperationId <String>]`: The unique identifier of richLongRunningOperation
  - `[SensitivityLabelId <String>]`: The unique identifier of sensitivityLabel
  - `[SensitivityLabelId1 <String>]`: The unique identifier of sensitivityLabel
  - `[SetId <String>]`: The unique identifier of set
  - `[SetId1 <String>]`: The unique identifier of set
  - `[SiteId <String>]`: The unique identifier of site
  - `[SiteId1 <String>]`: The unique identifier of site
  - `[SitePageId <String>]`: The unique identifier of sitePage
  - `[StartDateTime <String>]`: Usage: startDateTime='{startDateTime}'
  - `[StoreId <String>]`: The unique identifier of store
  - `[SubscriptionId <String>]`: The unique identifier of subscription
  - `[TermId <String>]`: The unique identifier of term
  - `[TermId1 <String>]`: The unique identifier of term
  - `[ThreatAssessmentRequestId <String>]`: The unique identifier of threatAssessmentRequest
  - `[ThreatAssessmentResultId <String>]`: The unique identifier of threatAssessmentResult
  - `[Token <String>]`: Usage: token='{token}'
  - `[UserId <String>]`: The unique identifier of user
  - `[WebPartId <String>]`: The unique identifier of webPart

## RELATED LINKS

