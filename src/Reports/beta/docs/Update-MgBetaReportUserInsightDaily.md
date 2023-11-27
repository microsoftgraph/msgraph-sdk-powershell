---
external help file:
Module Name: Microsoft.Graph.Beta.Reports
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.reports/update-mgbetareportuserinsightdaily
schema: 2.0.0
---

# Update-MgBetaReportUserInsightDaily

## SYNOPSIS
Update the navigation property daily in reports

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaReportUserInsightDaily [-ActiveUsers <IMicrosoftGraphActiveUsersMetric[]>]
 [-ActiveUsersBreakdown <IMicrosoftGraphActiveUsersBreakdownMetric[]>] [-AdditionalProperties <Hashtable>]
 [-Authentications <IMicrosoftGraphAuthenticationsMetric[]>] [-Id <String>]
 [-InactiveUsers <IMicrosoftGraphDailyInactiveUsersMetric[]>]
 [-InactiveUsersByApplication <IMicrosoftGraphDailyInactiveUsersByApplicationMetric[]>]
 [-MfaCompletions <IMicrosoftGraphMfaCompletionMetric[]>] [-SignUps <IMicrosoftGraphUserSignUpMetric[]>]
 [-Summary <IMicrosoftGraphInsightSummary[]>] [-UserCount <IMicrosoftGraphUserCountMetric[]>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaReportUserInsightDaily -BodyParameter <IMicrosoftGraphDailyUserInsightMetricsRoot> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property daily in reports

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

### -ActiveUsers
.
To construct, see NOTES section for ACTIVEUSERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphActiveUsersMetric[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ActiveUsersBreakdown
.
To construct, see NOTES section for ACTIVEUSERSBREAKDOWN properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphActiveUsersBreakdownMetric[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Authentications
.
To construct, see NOTES section for AUTHENTICATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAuthenticationsMetric[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
dailyUserInsightMetricsRoot
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDailyUserInsightMetricsRoot
Parameter Sets: Update
Aliases:

Required: True
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
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InactiveUsers
.
To construct, see NOTES section for INACTIVEUSERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDailyInactiveUsersMetric[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InactiveUsersByApplication
.
To construct, see NOTES section for INACTIVEUSERSBYAPPLICATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDailyInactiveUsersByApplicationMetric[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MfaCompletions
.
To construct, see NOTES section for MFACOMPLETIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMfaCompletionMetric[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SignUps
.
To construct, see NOTES section for SIGNUPS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUserSignUpMetric[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Summary
.
To construct, see NOTES section for SUMMARY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphInsightSummary[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserCount
.
To construct, see NOTES section for USERCOUNT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUserCountMetric[]
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDailyUserInsightMetricsRoot

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDailyUserInsightMetricsRoot

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ACTIVEUSERS <IMicrosoftGraphActiveUsersMetric[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Count <Int64?>]`: 
  - `[FactDate <DateTime?>]`: 

`ACTIVEUSERSBREAKDOWN <IMicrosoftGraphActiveUsersBreakdownMetric[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AppId <String>]`: 
  - `[AppName <String>]`: 
  - `[Count <Int64?>]`: 
  - `[FactDate <DateTime?>]`: 
  - `[OS <String>]`: 

`AUTHENTICATIONS <IMicrosoftGraphAuthenticationsMetric[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Appid <String>]`: 
  - `[AttemptsCount <Int64?>]`: 
  - `[Country <String>]`: 
  - `[FactDate <DateTime?>]`: 
  - `[OS <String>]`: 
  - `[SuccessCount <Int64?>]`: 

`BODYPARAMETER <IMicrosoftGraphDailyUserInsightMetricsRoot>`: dailyUserInsightMetricsRoot
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ActiveUsers <IMicrosoftGraphActiveUsersMetric[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Count <Int64?>]`: 
    - `[FactDate <DateTime?>]`: 
  - `[ActiveUsersBreakdown <IMicrosoftGraphActiveUsersBreakdownMetric[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AppId <String>]`: 
    - `[AppName <String>]`: 
    - `[Count <Int64?>]`: 
    - `[FactDate <DateTime?>]`: 
    - `[OS <String>]`: 
  - `[Authentications <IMicrosoftGraphAuthenticationsMetric[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Appid <String>]`: 
    - `[AttemptsCount <Int64?>]`: 
    - `[Country <String>]`: 
    - `[FactDate <DateTime?>]`: 
    - `[OS <String>]`: 
    - `[SuccessCount <Int64?>]`: 
  - `[InactiveUsers <IMicrosoftGraphDailyInactiveUsersMetric[]>]`: 
    - `[FactDate <DateTime?>]`: 
    - `[Inactive30DayCount <Int64?>]`: 
    - `[Inactive60DayCount <Int64?>]`: 
    - `[Inactive90DayCount <Int64?>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Inactive1DayCount <Int64?>]`: 
  - `[InactiveUsersByApplication <IMicrosoftGraphDailyInactiveUsersByApplicationMetric[]>]`: 
    - `[AppId <String>]`: 
    - `[FactDate <DateTime?>]`: 
    - `[Inactive30DayCount <Int64?>]`: 
    - `[Inactive60DayCount <Int64?>]`: 
    - `[Inactive90DayCount <Int64?>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Inactive1DayCount <Int64?>]`: 
  - `[MfaCompletions <IMicrosoftGraphMfaCompletionMetric[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AppId <String>]`: 
    - `[AttemptsCount <Int64?>]`: 
    - `[FactDate <DateTime?>]`: 
    - `[MfaMethod <String>]`: 
    - `[OS <String>]`: 
    - `[SuccessCount <Int64?>]`: 
  - `[SignUps <IMicrosoftGraphUserSignUpMetric[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Count <Int64?>]`: 
    - `[FactDate <DateTime?>]`: 
    - `[OS <String>]`: 
  - `[Summary <IMicrosoftGraphInsightSummary[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ActiveUsers <Int64?>]`: 
    - `[AppId <String>]`: 
    - `[AuthenticationCompletions <Int64?>]`: 
    - `[AuthenticationRequests <Int64?>]`: 
    - `[FactDate <DateTime?>]`: 
    - `[OS <String>]`: 
    - `[SecurityTextCompletions <Int64?>]`: 
    - `[SecurityTextRequests <Int64?>]`: 
    - `[SecurityVoiceCompletions <Int64?>]`: 
    - `[SecurityVoiceRequests <Int64?>]`: 
  - `[UserCount <IMicrosoftGraphUserCountMetric[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Count <Int64?>]`: 
    - `[FactDate <DateTime?>]`: 

`INACTIVEUSERS <IMicrosoftGraphDailyInactiveUsersMetric[]>`: .
  - `[FactDate <DateTime?>]`: 
  - `[Inactive30DayCount <Int64?>]`: 
  - `[Inactive60DayCount <Int64?>]`: 
  - `[Inactive90DayCount <Int64?>]`: 
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Inactive1DayCount <Int64?>]`: 

`INACTIVEUSERSBYAPPLICATION <IMicrosoftGraphDailyInactiveUsersByApplicationMetric[]>`: .
  - `[AppId <String>]`: 
  - `[FactDate <DateTime?>]`: 
  - `[Inactive30DayCount <Int64?>]`: 
  - `[Inactive60DayCount <Int64?>]`: 
  - `[Inactive90DayCount <Int64?>]`: 
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Inactive1DayCount <Int64?>]`: 

`MFACOMPLETIONS <IMicrosoftGraphMfaCompletionMetric[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AppId <String>]`: 
  - `[AttemptsCount <Int64?>]`: 
  - `[FactDate <DateTime?>]`: 
  - `[MfaMethod <String>]`: 
  - `[OS <String>]`: 
  - `[SuccessCount <Int64?>]`: 

`SIGNUPS <IMicrosoftGraphUserSignUpMetric[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Count <Int64?>]`: 
  - `[FactDate <DateTime?>]`: 
  - `[OS <String>]`: 

`SUMMARY <IMicrosoftGraphInsightSummary[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ActiveUsers <Int64?>]`: 
  - `[AppId <String>]`: 
  - `[AuthenticationCompletions <Int64?>]`: 
  - `[AuthenticationRequests <Int64?>]`: 
  - `[FactDate <DateTime?>]`: 
  - `[OS <String>]`: 
  - `[SecurityTextCompletions <Int64?>]`: 
  - `[SecurityTextRequests <Int64?>]`: 
  - `[SecurityVoiceCompletions <Int64?>]`: 
  - `[SecurityVoiceRequests <Int64?>]`: 

`USERCOUNT <IMicrosoftGraphUserCountMetric[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Count <Int64?>]`: 
  - `[FactDate <DateTime?>]`: 

## RELATED LINKS

