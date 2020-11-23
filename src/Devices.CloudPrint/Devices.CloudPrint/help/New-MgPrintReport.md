---
external help file: Microsoft.Graph.Devices.CloudPrint-help.xml
Module Name: Microsoft.Graph.Devices.CloudPrint
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.cloudprint/new-mgprintreport
schema: 2.0.0
---

# New-MgPrintReport

## SYNOPSIS
Create new navigation property to reports for print

## SYNTAX

### CreateExpanded (Default)
```
New-MgPrintReport [-AdditionalProperties <Hashtable>]
 [-ApplicationSignInDetailedSummary <IMicrosoftGraphApplicationSignInDetailedSummary[]>]
 [-CredentialUserRegistrationDetails <IMicrosoftGraphCredentialUserRegistrationDetails[]>]
 [-DailyPrintUsageSummariesByPrinter <IMicrosoftGraphPrintUsageSummaryByPrinter[]>]
 [-DailyPrintUsageSummariesByUser <IMicrosoftGraphPrintUsageSummaryByUser[]>] [-Id <String>]
 [-MonthlyPrintUsageSummariesByPrinter <IMicrosoftGraphPrintUsageSummaryByPrinter[]>]
 [-MonthlyPrintUsageSummariesByUser <IMicrosoftGraphPrintUsageSummaryByUser[]>]
 [-UserCredentialUsageDetails <IMicrosoftGraphUserCredentialUsageDetails[]>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Create
```
New-MgPrintReport -BodyParameter <IMicrosoftGraphReportRoot> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to reports for print

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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ApplicationSignInDetailedSummary
.
To construct, see NOTES section for APPLICATIONSIGNINDETAILEDSUMMARY properties and create a hash table.

```yaml
Type: IMicrosoftGraphApplicationSignInDetailedSummary[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
The resource that represents an instance of History Reports.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphReportRoot
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CredentialUserRegistrationDetails
.
To construct, see NOTES section for CREDENTIALUSERREGISTRATIONDETAILS properties and create a hash table.

```yaml
Type: IMicrosoftGraphCredentialUserRegistrationDetails[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DailyPrintUsageSummariesByPrinter
.
To construct, see NOTES section for DAILYPRINTUSAGESUMMARIESBYPRINTER properties and create a hash table.

```yaml
Type: IMicrosoftGraphPrintUsageSummaryByPrinter[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DailyPrintUsageSummariesByUser
.
To construct, see NOTES section for DAILYPRINTUSAGESUMMARIESBYUSER properties and create a hash table.

```yaml
Type: IMicrosoftGraphPrintUsageSummaryByUser[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MonthlyPrintUsageSummariesByPrinter
.
To construct, see NOTES section for MONTHLYPRINTUSAGESUMMARIESBYPRINTER properties and create a hash table.

```yaml
Type: IMicrosoftGraphPrintUsageSummaryByPrinter[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MonthlyPrintUsageSummariesByUser
.
To construct, see NOTES section for MONTHLYPRINTUSAGESUMMARIESBYUSER properties and create a hash table.

```yaml
Type: IMicrosoftGraphPrintUsageSummaryByUser[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserCredentialUsageDetails
.
To construct, see NOTES section for USERCREDENTIALUSAGEDETAILS properties and create a hash table.

```yaml
Type: IMicrosoftGraphUserCredentialUsageDetails[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphReportRoot
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphReportRoot
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

APPLICATIONSIGNINDETAILEDSUMMARY \<IMicrosoftGraphApplicationSignInDetailedSummary\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[AggregatedEventDateTime \<DateTime?\>\]: 
  \[AppDisplayName \<String\>\]: 
  \[AppId \<String\>\]: 
  \[SignInCount \<Int64?\>\]: 
  \[Status \<IMicrosoftGraphSignInStatus\>\]: signInStatus
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[AdditionalDetails \<String\>\]: Provides additional details on the sign-in activity
    \[ErrorCode \<Int32?\>\]: Provides the 5-6digit error code that's generated during a sign-in failure.
Check out the list of error codes and messages.
    \[FailureReason \<String\>\]: Provides the error message or the reason for failure for the corresponding sign-in activity.
Check out the list of error codes and messages.

BODYPARAMETER \<IMicrosoftGraphReportRoot\>: The resource that represents an instance of History Reports.
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[ApplicationSignInDetailedSummary \<IMicrosoftGraphApplicationSignInDetailedSummary\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[AggregatedEventDateTime \<DateTime?\>\]: 
    \[AppDisplayName \<String\>\]: 
    \[AppId \<String\>\]: 
    \[SignInCount \<Int64?\>\]: 
    \[Status \<IMicrosoftGraphSignInStatus\>\]: signInStatus
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[AdditionalDetails \<String\>\]: Provides additional details on the sign-in activity
      \[ErrorCode \<Int32?\>\]: Provides the 5-6digit error code that's generated during a sign-in failure.
Check out the list of error codes and messages.
      \[FailureReason \<String\>\]: Provides the error message or the reason for failure for the corresponding sign-in activity.
Check out the list of error codes and messages.
  \[CredentialUserRegistrationDetails \<IMicrosoftGraphCredentialUserRegistrationDetails\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[AuthMethods \<String\[\]\>\]: 
    \[IsCapable \<Boolean?\>\]: 
    \[IsEnabled \<Boolean?\>\]: 
    \[IsMfaRegistered \<Boolean?\>\]: 
    \[IsRegistered \<Boolean?\>\]: 
    \[UserDisplayName \<String\>\]: 
    \[UserPrincipalName \<String\>\]: 
  \[DailyPrintUsageSummariesByPrinter \<IMicrosoftGraphPrintUsageSummaryByPrinter\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[CompletedBlackAndWhiteJobCount \<Int64?\>\]: 
    \[CompletedColorJobCount \<Int64?\>\]: 
    \[IncompleteJobCount \<Int64?\>\]: 
    \[PrinterId \<String\>\]: 
    \[UsageDate \<DateTime?\>\]: 
  \[DailyPrintUsageSummariesByUser \<IMicrosoftGraphPrintUsageSummaryByUser\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[CompletedBlackAndWhiteJobCount \<Int64?\>\]: 
    \[CompletedColorJobCount \<Int64?\>\]: 
    \[IncompleteJobCount \<Int64?\>\]: 
    \[UsageDate \<DateTime?\>\]: 
    \[UserPrincipalName \<String\>\]: 
  \[MonthlyPrintUsageSummariesByPrinter \<IMicrosoftGraphPrintUsageSummaryByPrinter\[\]\>\]: 
  \[MonthlyPrintUsageSummariesByUser \<IMicrosoftGraphPrintUsageSummaryByUser\[\]\>\]: 
  \[UserCredentialUsageDetails \<IMicrosoftGraphUserCredentialUsageDetails\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[AuthMethod \<String\>\]: usageAuthMethod
    \[EventDateTime \<DateTime?\>\]: 
    \[FailureReason \<String\>\]: 
    \[Feature \<String\>\]: featureType
    \[IsSuccess \<Boolean?\>\]: 
    \[UserDisplayName \<String\>\]: 
    \[UserPrincipalName \<String\>\]: 

CREDENTIALUSERREGISTRATIONDETAILS \<IMicrosoftGraphCredentialUserRegistrationDetails\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[AuthMethods \<String\[\]\>\]: 
  \[IsCapable \<Boolean?\>\]: 
  \[IsEnabled \<Boolean?\>\]: 
  \[IsMfaRegistered \<Boolean?\>\]: 
  \[IsRegistered \<Boolean?\>\]: 
  \[UserDisplayName \<String\>\]: 
  \[UserPrincipalName \<String\>\]: 

DAILYPRINTUSAGESUMMARIESBYPRINTER \<IMicrosoftGraphPrintUsageSummaryByPrinter\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[CompletedBlackAndWhiteJobCount \<Int64?\>\]: 
  \[CompletedColorJobCount \<Int64?\>\]: 
  \[IncompleteJobCount \<Int64?\>\]: 
  \[PrinterId \<String\>\]: 
  \[UsageDate \<DateTime?\>\]: 

DAILYPRINTUSAGESUMMARIESBYUSER \<IMicrosoftGraphPrintUsageSummaryByUser\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[CompletedBlackAndWhiteJobCount \<Int64?\>\]: 
  \[CompletedColorJobCount \<Int64?\>\]: 
  \[IncompleteJobCount \<Int64?\>\]: 
  \[UsageDate \<DateTime?\>\]: 
  \[UserPrincipalName \<String\>\]: 

MONTHLYPRINTUSAGESUMMARIESBYPRINTER \<IMicrosoftGraphPrintUsageSummaryByPrinter\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[CompletedBlackAndWhiteJobCount \<Int64?\>\]: 
  \[CompletedColorJobCount \<Int64?\>\]: 
  \[IncompleteJobCount \<Int64?\>\]: 
  \[PrinterId \<String\>\]: 
  \[UsageDate \<DateTime?\>\]: 

MONTHLYPRINTUSAGESUMMARIESBYUSER \<IMicrosoftGraphPrintUsageSummaryByUser\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[CompletedBlackAndWhiteJobCount \<Int64?\>\]: 
  \[CompletedColorJobCount \<Int64?\>\]: 
  \[IncompleteJobCount \<Int64?\>\]: 
  \[UsageDate \<DateTime?\>\]: 
  \[UserPrincipalName \<String\>\]: 

USERCREDENTIALUSAGEDETAILS \<IMicrosoftGraphUserCredentialUsageDetails\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[AuthMethod \<String\>\]: usageAuthMethod
  \[EventDateTime \<DateTime?\>\]: 
  \[FailureReason \<String\>\]: 
  \[Feature \<String\>\]: featureType
  \[IsSuccess \<Boolean?\>\]: 
  \[UserDisplayName \<String\>\]: 
  \[UserPrincipalName \<String\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.cloudprint/new-mgprintreport](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.cloudprint/new-mgprintreport)

