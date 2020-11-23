---
external help file: Microsoft.Graph.Search-help.xml
Module Name: Microsoft.Graph.Search
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.search/invoke-mgquerysearch
schema: 2.0.0
---

# Invoke-MgQuerySearch

## SYNOPSIS
Invoke action query

## SYNTAX

### QueryExpanded1 (Default)
```
Invoke-MgQuerySearch [-AdditionalProperties <Hashtable>] [-Requests <IMicrosoftGraphSearchRequest1[]>]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Query1
```
Invoke-MgQuerySearch
 -BodyParameter <IPaths1Kd2XrlSearchMicrosoftGraphQueryPostRequestbodyContentApplicationJsonSchema1> [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Invoke action query

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

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: QueryExpanded1
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
Type: IPaths1Kd2XrlSearchMicrosoftGraphQueryPostRequestbodyContentApplicationJsonSchema1
Parameter Sets: Query1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Requests
.
To construct, see NOTES section for REQUESTS properties and create a hash table.

```yaml
Type: IMicrosoftGraphSearchRequest1[]
Parameter Sets: QueryExpanded1
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
Type: SwitchParameter
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
Type: SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IPaths1Kd2XrlSearchMicrosoftGraphQueryPostRequestbodyContentApplicationJsonSchema1
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSearchResponse1
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IPaths1Kd2XrlSearchMicrosoftGraphQueryPostRequestbodyContentApplicationJsonSchema\>: .
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Requests \<IMicrosoftGraphSearchRequest\[\]\>\]: 
    \[ContentSources \<String\[\]\>\]: 
    \[EnableTopResults \<Boolean?\>\]: 
    \[EntityTypes \<String\[\]\>\]: 
    \[Fields \<String\[\]\>\]: 
    \[From \<Int32?\>\]: 
    \[Query \<IMicrosoftGraphSearchQuery\>\]: searchQuery
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[QueryString \<String\>\]: 
    \[Size \<Int32?\>\]: 

REQUESTS \<IMicrosoftGraphSearchRequest\[\]\>: .
  \[ContentSources \<String\[\]\>\]: 
  \[EnableTopResults \<Boolean?\>\]: 
  \[EntityTypes \<String\[\]\>\]: 
  \[Fields \<String\[\]\>\]: 
  \[From \<Int32?\>\]: 
  \[Query \<IMicrosoftGraphSearchQuery\>\]: searchQuery
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[QueryString \<String\>\]: 
  \[Size \<Int32?\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.search/invoke-mgquerysearch](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.search/invoke-mgquerysearch)

