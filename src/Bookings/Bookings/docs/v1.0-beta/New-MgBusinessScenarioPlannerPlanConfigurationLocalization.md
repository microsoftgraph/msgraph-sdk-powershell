---
external help file:
Module Name: Microsoft.Graph.Beta.Bookings
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.bookings/new-mgbusinessscenarioplannerplanconfigurationlocalization
schema: 2.0.0
---

# New-MgBetaBusinessScenarioPlannerPlanConfigurationLocalization

## SYNOPSIS
Create new navigation property to localizations for solutions

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaBusinessScenarioPlannerPlanConfigurationLocalization -BusinessScenarioId <String>
 [-AdditionalProperties <Hashtable>] [-Buckets <IMicrosoftGraphPlannerPlanConfigurationBucketLocalization[]>]
 [-Id <String>] [-LanguageTag <String>] [-PlanTitle <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaBusinessScenarioPlannerPlanConfigurationLocalization -BusinessScenarioId <String>
 -BodyParameter <IMicrosoftGraphPlannerPlanConfigurationLocalization> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgBetaBusinessScenarioPlannerPlanConfigurationLocalization -InputObject <IBookingsIdentity>
 -BodyParameter <IMicrosoftGraphPlannerPlanConfigurationLocalization> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgBetaBusinessScenarioPlannerPlanConfigurationLocalization -InputObject <IBookingsIdentity>
 [-AdditionalProperties <Hashtable>] [-Buckets <IMicrosoftGraphPlannerPlanConfigurationBucketLocalization[]>]
 [-Id <String>] [-LanguageTag <String>] [-PlanTitle <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to localizations for solutions

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
plannerPlanConfigurationLocalization
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPlannerPlanConfigurationLocalization
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Buckets
.
To construct, please use Get-Help -Online and see NOTES section for BUCKETS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPlannerPlanConfigurationBucketLocalization[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BusinessScenarioId
key: id of businessScenario

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique idenfier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IBookingsIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LanguageTag
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PlanTitle
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IBookingsIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPlannerPlanConfigurationLocalization

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPlannerPlanConfigurationLocalization

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphPlannerPlanConfigurationLocalization>: plannerPlanConfigurationLocalization
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Buckets <IMicrosoftGraphPlannerPlanConfigurationBucketLocalization[]>]`: 
    - `[ExternalBucketId <String>]`: 
    - `[Name <String>]`: 
  - `[LanguageTag <String>]`: 
  - `[PlanTitle <String>]`: 

BUCKETS <IMicrosoftGraphPlannerPlanConfigurationBucketLocalization[]>: .
  - `[ExternalBucketId <String>]`: 
  - `[Name <String>]`: 

INPUTOBJECT <IBookingsIdentity>: Identity Parameter
  - `[BookingAppointmentId <String>]`: key: id of bookingAppointment
  - `[BookingBusinessId <String>]`: key: id of bookingBusiness
  - `[BookingCurrencyId <String>]`: key: id of bookingCurrency
  - `[BookingCustomQuestionId <String>]`: key: id of bookingCustomQuestion
  - `[BookingCustomerBaseId <String>]`: key: id of bookingCustomerBase
  - `[BookingCustomerId <String>]`: key: id of bookingCustomer
  - `[BookingServiceId <String>]`: key: id of bookingService
  - `[BookingStaffMemberBaseId <String>]`: key: id of bookingStaffMemberBase
  - `[BookingStaffMemberId <String>]`: key: id of bookingStaffMember
  - `[BusinessScenarioId <String>]`: key: id of businessScenario
  - `[BusinessScenarioTaskId <String>]`: key: id of businessScenarioTask
  - `[PlannerPlanConfigurationLocalizationId <String>]`: key: id of plannerPlanConfigurationLocalization

## RELATED LINKS

