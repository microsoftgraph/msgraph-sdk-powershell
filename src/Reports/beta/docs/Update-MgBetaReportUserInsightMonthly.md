---
external help file:
Module Name: Microsoft.Graph.Beta.Reports
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.reports/update-mgbetareportuserinsightmonthly
schema: 2.0.0
---

# Update-MgBetaReportUserInsightMonthly

## SYNOPSIS
Update the navigation property monthly in reports

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaReportUserInsightMonthly [-ActiveUsers <IMicrosoftGraphActiveUsersMetric[]>]
 [-ActiveUsersBreakdown <IMicrosoftGraphActiveUsersBreakdownMetric[]>] [-AdditionalProperties <Hashtable>]
 [-Authentications <IMicrosoftGraphAuthenticationsMetric[]>] [-Id <String>]
 [-InactiveUsers <IMicrosoftGraphMonthlyInactiveUsersMetric[]>]
 [-InactiveUsersByApplication <IMicrosoftGraphMonthlyInactiveUsersByApplicationMetric[]>]
 [-MfaCompletions <IMicrosoftGraphMfaCompletionMetric[]>] [-Requests <IMicrosoftGraphUserRequestsMetric[]>]
 [-SignUps <IMicrosoftGraphUserSignUpMetric[]>] [-Summary <IMicrosoftGraphInsightSummary[]>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaReportUserInsightMonthly -BodyParameter <IMicrosoftGraphMonthlyUserInsightMetricsRoot> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property monthly in reports

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
monthlyUserInsightMetricsRoot
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMonthlyUserInsightMetricsRoot
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMonthlyInactiveUsersMetric[]
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMonthlyInactiveUsersByApplicationMetric[]
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

### -Requests
.
To construct, see NOTES section for REQUESTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUserRequestsMetric[]
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMonthlyUserInsightMetricsRoot

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMonthlyUserInsightMetricsRoot

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

`BODYPARAMETER <IMicrosoftGraphMonthlyUserInsightMetricsRoot>`: monthlyUserInsightMetricsRoot
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
  - `[InactiveUsers <IMicrosoftGraphMonthlyInactiveUsersMetric[]>]`: 
    - `[FactDate <DateTime?>]`: 
    - `[Inactive30DayCount <Int64?>]`: 
    - `[Inactive60DayCount <Int64?>]`: 
    - `[Inactive90DayCount <Int64?>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[InactiveCalendarMonthCount <Int64?>]`: 
  - `[InactiveUsersByApplication <IMicrosoftGraphMonthlyInactiveUsersByApplicationMetric[]>]`: 
    - `[AppId <String>]`: 
    - `[FactDate <DateTime?>]`: 
    - `[Inactive30DayCount <Int64?>]`: 
    - `[Inactive60DayCount <Int64?>]`: 
    - `[Inactive90DayCount <Int64?>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[InactiveCalendarMonthCount <Int64?>]`: 
  - `[MfaCompletions <IMicrosoftGraphMfaCompletionMetric[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AppId <String>]`: 
    - `[AttemptsCount <Int64?>]`: 
    - `[FactDate <DateTime?>]`: 
    - `[MfaMethod <String>]`: 
    - `[OS <String>]`: 
    - `[SuccessCount <Int64?>]`: 
  - `[Requests <IMicrosoftGraphUserRequestsMetric[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[FactDate <DateTime?>]`: 
    - `[RequestCount <Int64?>]`: 
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

`INACTIVEUSERS <IMicrosoftGraphMonthlyInactiveUsersMetric[]>`: .
  - `[FactDate <DateTime?>]`: 
  - `[Inactive30DayCount <Int64?>]`: 
  - `[Inactive60DayCount <Int64?>]`: 
  - `[Inactive90DayCount <Int64?>]`: 
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[InactiveCalendarMonthCount <Int64?>]`: 

`INACTIVEUSERSBYAPPLICATION <IMicrosoftGraphMonthlyInactiveUsersByApplicationMetric[]>`: .
  - `[AppId <String>]`: 
  - `[FactDate <DateTime?>]`: 
  - `[Inactive30DayCount <Int64?>]`: 
  - `[Inactive60DayCount <Int64?>]`: 
  - `[Inactive90DayCount <Int64?>]`: 
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[InactiveCalendarMonthCount <Int64?>]`: 

`MFACOMPLETIONS <IMicrosoftGraphMfaCompletionMetric[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AppId <String>]`: 
  - `[AttemptsCount <Int64?>]`: 
  - `[FactDate <DateTime?>]`: 
  - `[MfaMethod <String>]`: 
  - `[OS <String>]`: 
  - `[SuccessCount <Int64?>]`: 

`REQUESTS <IMicrosoftGraphUserRequestsMetric[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[FactDate <DateTime?>]`: 
  - `[RequestCount <Int64?>]`: 

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

## RELATED LINKS

