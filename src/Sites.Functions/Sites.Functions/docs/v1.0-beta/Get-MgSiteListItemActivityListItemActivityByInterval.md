---
external help file:
Module Name: Microsoft.Graph.Sites.Functions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.sites.functions/get-mgsitelistitemactivitylistitemactivitybyinterval
schema: 2.0.0
---

# Get-MgSiteListItemActivityListItemActivityByInterval

## SYNOPSIS
Invoke function getActivitiesByInterval

## SYNTAX

### Get (Default)
```
Get-MgSiteListItemActivityListItemActivityByInterval -EndDateTime <String> -Interval <String>
 -ItemActivityOldId <String> -ListId <String> -ListItemId <String> -SiteId <String> -StartDateTime <String>
 [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgSiteListItemActivityListItemActivityByInterval -InputObject <ISitesFunctionsIdentity>
 [<CommonParameters>]
```

## DESCRIPTION
Invoke function getActivitiesByInterval

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

### -EndDateTime
.

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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.ISitesFunctionsIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Interval
.

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

### -ItemActivityOldId
key: itemActivityOLD-id of itemActivityOLD

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

### -ListId
key: list-id of list

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

### -ListItemId
key: listItem-id of listItem

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

### -SiteId
key: site-id of site

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

### -StartDateTime
.

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

### Microsoft.Graph.PowerShell.Models.ISitesFunctionsIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphItemActivityStat1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <ISitesFunctionsIdentity>: Identity Parameter
  - `[EndDateTime <String>]`: 
  - `[IncludePersonalNotebooks <Boolean?>]`: 
  - `[Interval <String>]`: 
  - `[ItemActivityOldId <String>]`: key: itemActivityOLD-id of itemActivityOLD
  - `[ListId <String>]`: key: list-id of list
  - `[ListItemId <String>]`: key: listItem-id of listItem
  - `[NotebookId <String>]`: key: notebook-id of notebook
  - `[OnenotePageId <String>]`: key: onenotePage-id of onenotePage
  - `[OnenotePageId1 <String>]`: key: onenotePage-id of onenotePage
  - `[OnenoteSectionId <String>]`: key: onenoteSection-id of onenoteSection
  - `[Path <String>]`: 
  - `[SectionGroupId <String>]`: key: sectionGroup-id of sectionGroup
  - `[SiteId <String>]`: key: site-id of site
  - `[StartDateTime <String>]`: 

## RELATED LINKS

