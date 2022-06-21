---
external help file:
Module Name: Microsoft.Graph.Notes
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.notes/new-mgsiteonenotesectiongroupsectiongroupbyref
schema: 2.0.0
---

# New-MgSiteOnenoteSectionGroupSectionGroupByRef

## SYNOPSIS
The section groups in the section.
Read-only.
Nullable.

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgSiteOnenoteSectionGroupSectionGroupByRef -SectionGroupId <String> -SiteId <String>
 [-AdditionalProperties <Hashtable>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgSiteOnenoteSectionGroupSectionGroupByRef -SectionGroupId <String> -SiteId <String>
 -BodyParameter <Hashtable> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity1
```
New-MgSiteOnenoteSectionGroupSectionGroupByRef -InputObject <INotesIdentity> -BodyParameter <Hashtable>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded1
```
New-MgSiteOnenoteSectionGroupSectionGroupByRef -InputObject <INotesIdentity>
 [-AdditionalProperties <Hashtable>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
The section groups in the section.
Read-only.
Nullable.

## EXAMPLES

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

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.INotesIdentity
Parameter Sets: CreateViaIdentity1, CreateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -SectionGroupId
key: id of sectionGroup

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

### -SiteId
key: id of site

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

### Microsoft.Graph.PowerShell.Models.INotesIdentity

### System.Collections.Hashtable

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IPaths6Y9EgcSitesSiteIdOnenoteSectiongroupsSectiongroupIdSectiongroupsRefPostResponses201ContentApplicationJsonSchema

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <INotesIdentity>: Identity Parameter
  - `[GroupId <String>]`: key: id of group
  - `[NotebookId <String>]`: key: id of notebook
  - `[OnenoteOperationId <String>]`: key: id of onenoteOperation
  - `[OnenotePageId <String>]`: key: id of onenotePage
  - `[OnenoteResourceId <String>]`: key: id of onenoteResource
  - `[OnenoteSectionId <String>]`: key: id of onenoteSection
  - `[SectionGroupId <String>]`: key: id of sectionGroup
  - `[SiteId <String>]`: key: id of site
  - `[UserId <String>]`: key: id of user

## RELATED LINKS

