---
external help file:
Module Name: Microsoft.Graph.Beta.Search
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.search/new-mgbetaexternalindustrydatainboundflow
schema: 2.0.0
---

# New-MgBetaExternalIndustryDataInboundFlow

## SYNOPSIS
Create a new inboundFileFlow object.
The following prerequisite resources are required when you create an inboundFileFlow:

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaExternalIndustryDataInboundFlow [-AdditionalProperties <Hashtable>]
 [-DataConnector <IMicrosoftGraphIndustryDataConnector>] [-DataDomain <String>] [-DisplayName <String>]
 [-EffectiveDateTime <DateTime>] [-ExpirationDateTime <DateTime>] [-Id <String>] [-ReadinessStatus <String>]
 [-ResponseHeadersVariable <String>] [-Year <IMicrosoftGraphIndustryDataYearTimePeriodDefinition>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaExternalIndustryDataInboundFlow -BodyParameter <IMicrosoftGraphIndustryDataInboundFlow>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new inboundFileFlow object.
The following prerequisite resources are required when you create an inboundFileFlow:

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
inboundFlow
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIndustryDataInboundFlow
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DataConnector
industryDataConnector
To construct, see NOTES section for DATACONNECTOR properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIndustryDataConnector
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DataDomain
inboundDomain

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

### -DisplayName
The name of the activity.
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

### -EffectiveDateTime
The start of the time window when the flow is allowed to run.
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.

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

### -ExpirationDateTime
The end of the time window when the flow is allowed to run.
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.

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

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -ReadinessStatus
readinessStatus

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

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Year
yearTimePeriodDefinition
To construct, see NOTES section for YEAR properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIndustryDataYearTimePeriodDefinition
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIndustryDataInboundFlow

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIndustryDataInboundFlow

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphIndustryDataInboundFlow>`: inboundFlow
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: The name of the activity. Maximum supported length is 100 characters.
  - `[ReadinessStatus <String>]`: readinessStatus
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DataConnector <IMicrosoftGraphIndustryDataConnector>]`: industryDataConnector
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DisplayName <String>]`: The name of the data connector. Maximum supported length is 100 characters.
    - `[SourceSystem <IMicrosoftGraphIndustryDataSourceSystemDefinition>]`: sourceSystemDefinition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[DisplayName <String>]`: The name of the source system. Maximum supported length is 100 characters.
      - `[UserMatchingSettings <IMicrosoftGraphIndustryDataUserMatchingSetting[]>]`: A collection of user matching settings by roleGroup.
        - `[MatchTarget <IMicrosoftGraphIndustryDataUserMatchTargetReferenceValue>]`: userMatchTargetReferenceValue
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Code <String>]`: The code of the desired referenceDefinition entry.
          - `[Value <IMicrosoftGraphIndustryDataReferenceDefinition>]`: referenceDefinition
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Id <String>]`: The unique identifier for an entity. Read-only.
            - `[Code <String>]`: The code value for the definition that must be unique within the referenceType.
            - `[IsDisabled <Boolean?>]`: Indicates whether the definition has been disabled.
            - `[ReferenceType <String>]`: The categorical type for a collection of enumerated values.
            - `[SortIndex <Int32?>]`: The ordering index to present the definitions within a type consistently in user interfaces.
        - `[PriorityOrder <Int32?>]`: The priority order to apply when a user has multiple RefRole codes assigned.
        - `[RoleGroup <IMicrosoftGraphIndustryDataRoleGroup>]`: roleGroup
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Id <String>]`: The unique identifier for an entity. Read-only.
          - `[DisplayName <String>]`: The name of the role group.
          - `[Roles <IMicrosoftGraphIndustryDataRoleReferenceValue[]>]`: The set of roles included in the role group.
            - `[Code <String>]`: The code of the desired referenceDefinition entry.
            - `[Value <IMicrosoftGraphIndustryDataReferenceDefinition>]`: referenceDefinition
        - `[SourceIdentifier <IMicrosoftGraphIndustryDataIdentifierTypeReferenceValue>]`: identifierTypeReferenceValue
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Code <String>]`: The code of the desired referenceDefinition entry.
          - `[Value <IMicrosoftGraphIndustryDataReferenceDefinition>]`: referenceDefinition
      - `[Vendor <String>]`: The name of the vendor who supplies the source system. Maximum supported length is 100 characters.
  - `[DataDomain <String>]`: inboundDomain
  - `[EffectiveDateTime <DateTime?>]`: The start of the time window when the flow is allowed to run. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[ExpirationDateTime <DateTime?>]`: The end of the time window when the flow is allowed to run. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[Year <IMicrosoftGraphIndustryDataYearTimePeriodDefinition>]`: yearTimePeriodDefinition
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DisplayName <String>]`: The name of the year. Maximum supported length is 100 characters.
    - `[EndDate <DateTime?>]`: The last day of the year using ISO 8601 format for date.
    - `[StartDate <DateTime?>]`: The first day of the year using ISO 8601 format for date.
    - `[Year <IMicrosoftGraphIndustryDataYearReferenceValue>]`: yearReferenceValue
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Code <String>]`: The code of the desired referenceDefinition entry.
      - `[Value <IMicrosoftGraphIndustryDataReferenceDefinition>]`: referenceDefinition

`DATACONNECTOR <IMicrosoftGraphIndustryDataConnector>`: industryDataConnector
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DisplayName <String>]`: The name of the data connector. Maximum supported length is 100 characters.
  - `[SourceSystem <IMicrosoftGraphIndustryDataSourceSystemDefinition>]`: sourceSystemDefinition
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DisplayName <String>]`: The name of the source system. Maximum supported length is 100 characters.
    - `[UserMatchingSettings <IMicrosoftGraphIndustryDataUserMatchingSetting[]>]`: A collection of user matching settings by roleGroup.
      - `[MatchTarget <IMicrosoftGraphIndustryDataUserMatchTargetReferenceValue>]`: userMatchTargetReferenceValue
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Code <String>]`: The code of the desired referenceDefinition entry.
        - `[Value <IMicrosoftGraphIndustryDataReferenceDefinition>]`: referenceDefinition
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Id <String>]`: The unique identifier for an entity. Read-only.
          - `[Code <String>]`: The code value for the definition that must be unique within the referenceType.
          - `[IsDisabled <Boolean?>]`: Indicates whether the definition has been disabled.
          - `[ReferenceType <String>]`: The categorical type for a collection of enumerated values.
          - `[SortIndex <Int32?>]`: The ordering index to present the definitions within a type consistently in user interfaces.
      - `[PriorityOrder <Int32?>]`: The priority order to apply when a user has multiple RefRole codes assigned.
      - `[RoleGroup <IMicrosoftGraphIndustryDataRoleGroup>]`: roleGroup
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[DisplayName <String>]`: The name of the role group.
        - `[Roles <IMicrosoftGraphIndustryDataRoleReferenceValue[]>]`: The set of roles included in the role group.
          - `[Code <String>]`: The code of the desired referenceDefinition entry.
          - `[Value <IMicrosoftGraphIndustryDataReferenceDefinition>]`: referenceDefinition
      - `[SourceIdentifier <IMicrosoftGraphIndustryDataIdentifierTypeReferenceValue>]`: identifierTypeReferenceValue
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Code <String>]`: The code of the desired referenceDefinition entry.
        - `[Value <IMicrosoftGraphIndustryDataReferenceDefinition>]`: referenceDefinition
    - `[Vendor <String>]`: The name of the vendor who supplies the source system. Maximum supported length is 100 characters.

`YEAR <IMicrosoftGraphIndustryDataYearTimePeriodDefinition>`: yearTimePeriodDefinition
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

