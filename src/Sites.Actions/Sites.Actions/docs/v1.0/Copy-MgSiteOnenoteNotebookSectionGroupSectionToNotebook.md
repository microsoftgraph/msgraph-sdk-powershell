---
external help file:
Module Name: Microsoft.Graph.Sites.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.sites.actions/copy-mgsiteonenotenotebooksectiongroupsectiontonotebook
schema: 2.0.0
---

# Copy-MgSiteOnenoteNotebookSectionGroupSectionToNotebook

## SYNOPSIS
Invoke action copyToNotebook

## SYNTAX

### CopyExpanded (Default)
```
Copy-MgSiteOnenoteNotebookSectionGroupSectionToNotebook -NotebookId <String> -OnenoteSectionId <String>
 -SectionGroupId <String> -SiteId <String> [-GroupId <String>] [-Id <String>] [-RenameAs <String>]
 [-SiteCollectionId <String>] [-SiteId1 <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Copy
```
Copy-MgSiteOnenoteNotebookSectionGroupSectionToNotebook -NotebookId <String> -OnenoteSectionId <String>
 -SectionGroupId <String> -SiteId <String>
 -BodyParameter <IPathsD1OdemSitesSiteIdOnenoteNotebooksNotebookIdSectiongroupsSectiongroupIdSectionsOnenotesectionIdMicrosoftGraphCopytonotebookPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CopyViaIdentity
```
Copy-MgSiteOnenoteNotebookSectionGroupSectionToNotebook -InputObject <ISitesActionsIdentity>
 -BodyParameter <IPathsD1OdemSitesSiteIdOnenoteNotebooksNotebookIdSectiongroupsSectiongroupIdSectionsOnenotesectionIdMicrosoftGraphCopytonotebookPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CopyViaIdentityExpanded
```
Copy-MgSiteOnenoteNotebookSectionGroupSectionToNotebook -InputObject <ISitesActionsIdentity>
 [-SiteId <String>] [-GroupId <String>] [-Id <String>] [-RenameAs <String>] [-SiteCollectionId <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action copyToNotebook

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
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPathsD1OdemSitesSiteIdOnenoteNotebooksNotebookIdSectiongroupsSectiongroupIdSectionsOnenotesectionIdMicrosoftGraphCopytonotebookPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Copy, CopyViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -GroupId
.

```yaml
Type: System.String
Parameter Sets: CopyExpanded, CopyViaIdentityExpanded
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
Parameter Sets: CopyExpanded, CopyViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.ISitesActionsIdentity
Parameter Sets: CopyViaIdentity, CopyViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -NotebookId
key: notebook-id of notebook

```yaml
Type: System.String
Parameter Sets: Copy, CopyExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnenoteSectionId
key: onenoteSection-id of onenoteSection

```yaml
Type: System.String
Parameter Sets: Copy, CopyExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RenameAs
.

```yaml
Type: System.String
Parameter Sets: CopyExpanded, CopyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SectionGroupId
key: sectionGroup-id of sectionGroup

```yaml
Type: System.String
Parameter Sets: Copy, CopyExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SiteCollectionId
.

```yaml
Type: System.String
Parameter Sets: CopyExpanded, CopyViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SiteId
key: site-id of site

```yaml
Type: System.String
Parameter Sets: Copy, CopyExpanded, CopyViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SiteId1
.

```yaml
Type: System.String
Parameter Sets: CopyExpanded
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

### Microsoft.Graph.PowerShell.Models.IPathsD1OdemSitesSiteIdOnenoteNotebooksNotebookIdSectiongroupsSectiongroupIdSectionsOnenotesectionIdMicrosoftGraphCopytonotebookPostRequestbodyContentApplicationJsonSchema

### Microsoft.Graph.PowerShell.Models.ISitesActionsIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnenoteOperation

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPathsD1OdemSitesSiteIdOnenoteNotebooksNotebookIdSectiongroupsSectiongroupIdSectionsOnenotesectionIdMicrosoftGraphCopytonotebookPostRequestbodyContentApplicationJsonSchema>: .
  - `[GroupId <String>]`: 
  - `[Id <String>]`: 
  - `[RenameAs <String>]`: 
  - `[SiteCollectionId <String>]`: 
  - `[SiteId <String>]`: 

INPUTOBJECT <ISitesActionsIdentity>: Identity Parameter
  - `[ItemActivityOldId <String>]`: key: itemActivityOLD-id of itemActivityOLD
  - `[ListId <String>]`: key: list-id of list
  - `[ListItemId <String>]`: key: listItem-id of listItem
  - `[ListItemVersionId <String>]`: key: listItemVersion-id of listItemVersion
  - `[NotebookId <String>]`: key: notebook-id of notebook
  - `[OnenotePageId <String>]`: key: onenotePage-id of onenotePage
  - `[OnenoteSectionId <String>]`: key: onenoteSection-id of onenoteSection
  - `[SectionGroupId <String>]`: key: sectionGroup-id of sectionGroup
  - `[SiteId <String>]`: key: site-id of site
  - `[SitePageId <String>]`: key: sitePage-id of sitePage

## RELATED LINKS

