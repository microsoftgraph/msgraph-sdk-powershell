---
external help file:
Module Name: Microsoft.Graph.Groups.Functions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.groups.functions/invoke-mgpreviewgrouponenotenotebooksectionpage
schema: 2.0.0
---

# Invoke-MgPreviewGroupOnenoteNotebookSectionPage

## SYNOPSIS
Invoke function preview

## SYNTAX

### Preview (Default)
```
Invoke-MgPreviewGroupOnenoteNotebookSectionPage -GroupId <String> -NotebookId <String> -OnenotePageId <String>
 -OnenoteSectionId <String> [<CommonParameters>]
```

### PreviewViaIdentity
```
Invoke-MgPreviewGroupOnenoteNotebookSectionPage -InputObject <IGroupsFunctionsIdentity> [<CommonParameters>]
```

## DESCRIPTION
Invoke function preview

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

### -GroupId
key: group-id of group

```yaml
Type: System.String
Parameter Sets: Preview
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IGroupsFunctionsIdentity
Parameter Sets: PreviewViaIdentity
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
Parameter Sets: Preview
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OnenotePageId
key: onenotePage-id of onenotePage

```yaml
Type: System.String
Parameter Sets: Preview
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
Parameter Sets: Preview
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IGroupsFunctionsIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnenotePagePreview

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IGroupsFunctionsIdentity>: Identity Parameter
  - `[EventId <String>]`: key: event-id of event
  - `[GroupId <String>]`: key: group-id of group
  - `[IncludePersonalNotebooks <Boolean?>]`: 
  - `[NotebookId <String>]`: key: notebook-id of notebook
  - `[OnenotePageId <String>]`: key: onenotePage-id of onenotePage
  - `[OnenotePageId1 <String>]`: key: onenotePage-id of onenotePage
  - `[OnenoteSectionId <String>]`: key: onenoteSection-id of onenoteSection
  - `[SectionGroupId <String>]`: key: sectionGroup-id of sectionGroup
  - `[User <String>]`: 

## RELATED LINKS

