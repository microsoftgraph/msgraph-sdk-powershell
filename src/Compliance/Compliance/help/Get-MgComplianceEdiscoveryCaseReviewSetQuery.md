---
external help file: Microsoft.Graph.Compliance-help.xml
Module Name: Microsoft.Graph.Compliance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.compliance/get-mgcomplianceediscoverycasereviewsetquery
schema: 2.0.0
---

# Get-MgComplianceEdiscoveryCaseReviewSetQuery

## SYNOPSIS
Get queries from compliance

## SYNTAX

### List (Default)
```
Get-MgComplianceEdiscoveryCaseReviewSetQuery -EdiscoveryCaseId <String> -ReviewSetId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [-Filter <String>] [-Search <String>] [-Skip <Int32>]
 [-Sort <String[]>] [-Top <Int32>] [-PageSize <Int32>] [-All] [-CountVariable <String>] [<CommonParameters>]
```

### Get
```
Get-MgComplianceEdiscoveryCaseReviewSetQuery -EdiscoveryCaseId <String> -ReviewSetId <String>
 -ReviewSetQueryId <String> [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgComplianceEdiscoveryCaseReviewSetQuery -InputObject <IComplianceIdentity> [-ExpandProperty <String[]>]
 [-Property <String[]>] [<CommonParameters>]
```

## DESCRIPTION
Get queries from compliance

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

### -All
List all pages.

```yaml
Type: SwitchParameter
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -CountVariable
Specifies a count of the total number of items in a collection.
By default, this variable will be set in the global scope.

```yaml
Type: String
Parameter Sets: List
Aliases: CV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EdiscoveryCaseId
key: id of ediscoveryCase

```yaml
Type: String
Parameter Sets: List, Get
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

### -Filter
Filter items by property values

```yaml
Type: String
Parameter Sets: List
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
Type: IComplianceIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PageSize
Sets the page size of results.

```yaml
Type: Int32
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
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

### -ReviewSetId
key: id of reviewSet

```yaml
Type: String
Parameter Sets: List, Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReviewSetQueryId
key: id of reviewSetQuery

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

### -Search
Search items by search phrases

```yaml
Type: String
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sort
Order items by property values

```yaml
Type: String[]
Parameter Sets: List
Aliases: OrderBy

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Top
Show only the first n items

```yaml
Type: Int32
Parameter Sets: List
Aliases: Limit

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -Skip
Skip the first n items

```yaml
Type: Int32
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IComplianceIdentity
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphReviewSetQuery
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

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.compliance/get-mgcomplianceediscoverycasereviewsetquery](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.compliance/get-mgcomplianceediscoverycasereviewsetquery)

