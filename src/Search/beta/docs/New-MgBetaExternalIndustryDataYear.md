---
external help file:
Module Name: Microsoft.Graph.Beta.Search
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.search/new-mgbetaexternalindustrydatayear
schema: 2.0.0
---

# New-MgBetaExternalIndustryDataYear

## SYNOPSIS
Create a new yearTimePeriodDefinition object.

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaExternalIndustryDataYear [-AdditionalProperties <Hashtable>] [-DisplayName <String>]
 [-EndDate <DateTime>] [-Id <String>] [-StartDate <DateTime>] [-Year <Hashtable>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgBetaExternalIndustryDataYear -BodyParameter <IMicrosoftGraphIndustryDataYearTimePeriodDefinition>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new yearTimePeriodDefinition object.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
yearTimePeriodDefinition
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIndustryDataYearTimePeriodDefinition
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
The name of the year.
Maximum supported length is 100 characters.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EndDate
The last day of the year using ISO 8601 format for date.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StartDate
The first day of the year using ISO 8601 format for date.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Year
yearReferenceValue

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIndustryDataYearTimePeriodDefinition

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIndustryDataYearTimePeriodDefinition

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphIndustryDataYearTimePeriodDefinition>`: yearTimePeriodDefinition
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DisplayName <String>]`: The name of the year. Maximum supported length is 100 characters.
  - `[EndDate <DateTime?>]`: The last day of the year using ISO 8601 format for date.
  - `[StartDate <DateTime?>]`: The first day of the year using ISO 8601 format for date.
  - `[Year <IMicrosoftGraphIndustryDataYearReferenceValue>]`: yearReferenceValue
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Code <String>]`: The code of the desired referenceDefinition entry.
    - `[Value <IMicrosoftGraphIndustryDataReferenceDefinition>]`: referenceDefinition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Code <String>]`: The code value for the definition that must be unique within the referenceType.
      - `[IsDisabled <Boolean?>]`: Indicates whether the definition has been disabled.
      - `[ReferenceType <String>]`: The categorical type for a collection of enumerated values.
      - `[SortIndex <Int32?>]`: The ordering index to present the definitions within a type consistently in user interfaces.

## RELATED LINKS

