---
external help file: Microsoft.Graph.Compliance-help.xml
Module Name: Microsoft.Graph.Compliance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.compliance/get-mgcomplianceediscoverycasecustodiansitesourcesite
schema: 2.0.0
---

# Get-MgComplianceEdiscoveryCaseCustodianSiteSourceSite

## SYNOPSIS
Get site from compliance

## SYNTAX

### Get (Default)
```
Get-MgComplianceEdiscoveryCaseCustodianSiteSourceSite -CustodianId <String> -EdiscoveryCaseId <String>
 -SiteSourceId <String> [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgComplianceEdiscoveryCaseCustodianSiteSourceSite -InputObject <IComplianceIdentity>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

## DESCRIPTION
Get site from compliance

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -CustodianId
key: id of custodian

```yaml
Type: String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EdiscoveryCaseId
key: id of ediscoveryCase

```yaml
Type: String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExpandProperty
Expand related entities

```yaml
Type: String[]
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
Type: IComplianceIdentity
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
Type: String[]
Parameter Sets: (All)
Aliases: Select

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SiteSourceId
key: id of siteSource

```yaml
Type: String
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

### Microsoft.Graph.PowerShell.Models.IComplianceIdentity
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSite
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT \<IComplianceIdentity\>: Identity Parameter
  \[CustodianId \<String\>\]: key: id of custodian
  \[EdiscoveryCaseId \<String\>\]: key: id of ediscoveryCase
  \[ReviewSetId \<String\>\]: key: id of reviewSet
  \[ReviewSetQueryId \<String\>\]: key: id of reviewSetQuery
  \[SiteSourceId \<String\>\]: key: id of siteSource
  \[UnifiedGroupSourceId \<String\>\]: key: id of unifiedGroupSource
  \[UserSourceId \<String\>\]: key: id of userSource

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.compliance/get-mgcomplianceediscoverycasecustodiansitesourcesite](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.compliance/get-mgcomplianceediscoverycasecustodiansitesourcesite)

