---
external help file:
Module Name: Microsoft.Graph.Users.OneNote
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.onenote/get-mguseronenotesectiongroupparentsectiongroup
schema: 2.0.0
---

# Get-MgUserOnenoteSectionGroupParentSectionGroup

## SYNOPSIS
Get parentSectionGroup from users

## SYNTAX

### Get (Default)
```
Get-MgUserOnenoteSectionGroupParentSectionGroup -SectionGroupId <String> -UserId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgUserOnenoteSectionGroupParentSectionGroup -InputObject <IUsersOneNoteIdentity>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

## DESCRIPTION
Get parentSectionGroup from users

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

### -ExpandProperty
Expand related entities

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Expand

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
Type: Microsoft.Graph.PowerShell.Models.IUsersOneNoteIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Property
Select properties to be returned

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Select

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
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
key: user-id of user

```yaml
Type: System.String
Parameter Sets: Get
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

### Microsoft.Graph.PowerShell.Models.IUsersOneNoteIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSectionGroup

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IUsersOneNoteIdentity>: Identity Parameter
  - `[NotebookId <String>]`: key: notebook-id of notebook
  - `[OnenoteOperationId <String>]`: key: onenoteOperation-id of onenoteOperation
  - `[OnenotePageId <String>]`: key: onenotePage-id of onenotePage
  - `[OnenotePageId1 <String>]`: key: onenotePage-id of onenotePage
  - `[OnenoteResourceId <String>]`: key: onenoteResource-id of onenoteResource
  - `[OnenoteSectionId <String>]`: key: onenoteSection-id of onenoteSection
  - `[OnenoteSectionId1 <String>]`: key: onenoteSection-id of onenoteSection
  - `[SectionGroupId <String>]`: key: sectionGroup-id of sectionGroup
  - `[SectionGroupId1 <String>]`: key: sectionGroup-id of sectionGroup
  - `[UserId <String>]`: key: user-id of user

## RELATED LINKS

