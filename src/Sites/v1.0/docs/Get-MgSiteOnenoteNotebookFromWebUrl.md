---
external help file:
Module Name: Microsoft.Graph.Sites
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.sites/get-mgsiteonenotenotebookfromweburl
schema: 2.0.0
---

# Get-MgSiteOnenoteNotebookFromWebUrl

## SYNOPSIS
Retrieve the properties and relationships of a notebook object by using its URL path.
The location can be user notebooks on Microsoft 365, group notebooks, or SharePoint site-hosted team notebooks on Microsoft 365.
This API is available in the following national cloud deployments.

## SYNTAX

### GetExpanded (Default)
```
Get-MgSiteOnenoteNotebookFromWebUrl -SiteId <String> [-AdditionalProperties <Hashtable>] [-WebUrl <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Get
```
Get-MgSiteOnenoteNotebookFromWebUrl -SiteId <String>
 -BodyParameter <IPathsUkf43DSitesSiteIdOnenoteNotebooksMicrosoftGraphGetnotebookfromweburlPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgSiteOnenoteNotebookFromWebUrl -InputObject <ISitesIdentity>
 -BodyParameter <IPathsUkf43DSitesSiteIdOnenoteNotebooksMicrosoftGraphGetnotebookfromweburlPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### GetViaIdentityExpanded
```
Get-MgSiteOnenoteNotebookFromWebUrl -InputObject <ISitesIdentity> [-AdditionalProperties <Hashtable>]
 [-WebUrl <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Retrieve the properties and relationships of a notebook object by using its URL path.
The location can be user notebooks on Microsoft 365, group notebooks, or SharePoint site-hosted team notebooks on Microsoft 365.
This API is available in the following national cloud deployments.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Users.Actions
```

$params = @{
	WebUrl = "webUrl value"
}

# A UPN can also be used as -UserId.
Get-MgUserOnenoteNotebookFromWebUrl -UserId $userId -BodyParameter $params

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: GetExpanded, GetViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IPathsUkf43DSitesSiteIdOnenoteNotebooksMicrosoftGraphGetnotebookfromweburlPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Get, GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.ISitesIdentity
Parameter Sets: GetViaIdentity, GetViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -SiteId
The unique identifier of site

```yaml
Type: System.String
Parameter Sets: Get, GetExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WebUrl
.

```yaml
Type: System.String
Parameter Sets: GetExpanded, GetViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IPathsUkf43DSitesSiteIdOnenoteNotebooksMicrosoftGraphGetnotebookfromweburlPostRequestbodyContentApplicationJsonSchema

### Microsoft.Graph.PowerShell.Models.ISitesIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCopyNotebookModel

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPathsUkf43DSitesSiteIdOnenoteNotebooksMicrosoftGraphGetnotebookfromweburlPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[WebUrl <String>]`: 

`INPUTOBJECT <ISitesIdentity>`: Identity Parameter
  - `[BaseItemId <String>]`: The unique identifier of baseItem
  - `[ColumnDefinitionId <String>]`: The unique identifier of columnDefinition
  - `[ColumnLinkId <String>]`: The unique identifier of columnLink
  - `[ContentTypeId <String>]`: The unique identifier of contentType
  - `[ContentTypeId1 <String>]`: The unique identifier of contentType
  - `[DocumentSetVersionId <String>]`: The unique identifier of documentSetVersion
  - `[DriveId <String>]`: The unique identifier of drive
  - `[EndDateTime <String>]`: Usage: endDateTime='{endDateTime}'
  - `[GroupId <String>]`: The unique identifier of group
  - `[GroupId1 <String>]`: The unique identifier of group
  - `[IncludePersonalNotebooks <Boolean?>]`: Usage: includePersonalNotebooks={includePersonalNotebooks}
  - `[Interval <String>]`: Usage: interval='{interval}'
  - `[ItemActivityId <String>]`: The unique identifier of itemActivity
  - `[ItemActivityStatId <String>]`: The unique identifier of itemActivityStat
  - `[ListId <String>]`: The unique identifier of list
  - `[ListItemId <String>]`: The unique identifier of listItem
  - `[ListItemVersionId <String>]`: The unique identifier of listItemVersion
  - `[NotebookId <String>]`: The unique identifier of notebook
  - `[OnenoteOperationId <String>]`: The unique identifier of onenoteOperation
  - `[OnenotePageId <String>]`: The unique identifier of onenotePage
  - `[OnenoteResourceId <String>]`: The unique identifier of onenoteResource
  - `[OnenoteSectionId <String>]`: The unique identifier of onenoteSection
  - `[Path <String>]`: Usage: path='{path}'
  - `[PermissionId <String>]`: The unique identifier of permission
  - `[RelationId <String>]`: The unique identifier of relation
  - `[RichLongRunningOperationId <String>]`: The unique identifier of richLongRunningOperation
  - `[SectionGroupId <String>]`: The unique identifier of sectionGroup
  - `[SectionGroupId1 <String>]`: The unique identifier of sectionGroup
  - `[SetId <String>]`: The unique identifier of set
  - `[SetId1 <String>]`: The unique identifier of set
  - `[SiteId <String>]`: The unique identifier of site
  - `[SiteId1 <String>]`: The unique identifier of site
  - `[StartDateTime <String>]`: Usage: startDateTime='{startDateTime}'
  - `[StoreId <String>]`: The unique identifier of store
  - `[SubscriptionId <String>]`: The unique identifier of subscription
  - `[TermId <String>]`: The unique identifier of term
  - `[TermId1 <String>]`: The unique identifier of term
  - `[UserId <String>]`: The unique identifier of user

## RELATED LINKS

