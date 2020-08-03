---
external help file:
Module Name: Microsoft.Graph.Sites.Site
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.sites.site/get-mgsiteanalytic
schema: 2.0.0
---

# Get-MgSiteAnalytic

## SYNOPSIS
Get analytics from sites

## SYNTAX

### Get1 (Default)
```
Get-MgSiteAnalytic [-SiteId <String>] [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### GetViaIdentity1
```
Get-MgSiteAnalytic -InputObject <ISitesSiteIdentity> [-ExpandProperty <String[]>] [-Property <String[]>]
 [<CommonParameters>]
```

## DESCRIPTION
Get analytics from sites

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
Type: Microsoft.Graph.PowerShell.Models.ISitesSiteIdentity
Parameter Sets: GetViaIdentity1
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

### -SiteId
key: site-id of site

```yaml
Type: System.String
Parameter Sets: Get1
Aliases:

Required: False
Position: Named
Default value: "root"
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.ISitesSiteIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphItemAnalytics1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <ISitesSiteIdentity>: Identity Parameter
  - `[ColumnDefinitionId <String>]`: key: columnDefinition-id of columnDefinition
  - `[ColumnLinkId <String>]`: key: columnLink-id of columnLink
  - `[ContentTypeId <String>]`: key: contentType-id of contentType
  - `[SiteId <String>]`: key: site-id of site
  - `[SiteId1 <String>]`: key: site-id of site

## RELATED LINKS

