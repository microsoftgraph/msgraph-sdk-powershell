---
external help file:
Module Name: Microsoft.Graph.Bookings
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.bookings/new-mgbusinessscenarioplannerplanconfigurationlocalization
schema: 2.0.0
---

# New-MgBusinessScenarioPlannerPlanConfigurationLocalization

## SYNOPSIS
Create a new plannerPlanConfigurationLocalization object.

## SYNTAX

### CreateExpanded (Default)
```
New-MgBusinessScenarioPlannerPlanConfigurationLocalization -BusinessScenarioId <String>
 [-AdditionalProperties <Hashtable>] [-Buckets <IMicrosoftGraphPlannerPlanConfigurationBucketLocalization[]>]
 [-Id <String>] [-LanguageTag <String>] [-PlanTitle <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBusinessScenarioPlannerPlanConfigurationLocalization -BusinessScenarioId <String>
 -BodyParameter <IMicrosoftGraphPlannerPlanConfigurationLocalization> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgBusinessScenarioPlannerPlanConfigurationLocalization -InputObject <IBookingsIdentity>
 -BodyParameter <IMicrosoftGraphPlannerPlanConfigurationLocalization> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgBusinessScenarioPlannerPlanConfigurationLocalization -InputObject <IBookingsIdentity>
 [-AdditionalProperties <Hashtable>] [-Buckets <IMicrosoftGraphPlannerPlanConfigurationBucketLocalization[]>]
 [-Id <String>] [-LanguageTag <String>] [-PlanTitle <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new plannerPlanConfigurationLocalization object.

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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerPlanConfigurationLocalization
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Buckets
Localized names for configured buckets in the plan configuration.
To construct, please use Get-Help -Online and see NOTES section for BUCKETS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerPlanConfigurationBucketLocalization[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BusinessScenarioId
The unique identifier of businessScenario

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
Type: Microsoft.Graph.PowerShell.Models.IBookingsIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LanguageTag
The language code associated with the localized names in this object.

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
Localized title of the plan.

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

### Microsoft.Graph.PowerShell.Models.IBookingsIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerPlanConfigurationLocalization

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerPlanConfigurationLocalization

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphPlannerPlanConfigurationLocalization>: plannerPlanConfigurationLocalization
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Buckets <IMicrosoftGraphPlannerPlanConfigurationBucketLocalization[]>]`: Localized names for configured buckets in the plan configuration.
    - `[ExternalBucketId <String>]`: Application-specified identifier of the bucket.
    - `[Name <String>]`: Name of the bucket.
  - `[LanguageTag <String>]`: The language code associated with the localized names in this object.
  - `[PlanTitle <String>]`: Localized title of the plan.

BUCKETS <IMicrosoftGraphPlannerPlanConfigurationBucketLocalization[]>: Localized names for configured buckets in the plan configuration.
  - `[ExternalBucketId <String>]`: Application-specified identifier of the bucket.
  - `[Name <String>]`: Name of the bucket.

INPUTOBJECT <IBookingsIdentity>: Identity Parameter
  - `[BookingAppointmentId <String>]`: The unique identifier of bookingAppointment
  - `[BookingBusinessId <String>]`: The unique identifier of bookingBusiness
  - `[BookingCurrencyId <String>]`: The unique identifier of bookingCurrency
  - `[BookingCustomQuestionId <String>]`: The unique identifier of bookingCustomQuestion
  - `[BookingCustomerBaseId <String>]`: The unique identifier of bookingCustomerBase
  - `[BookingCustomerId <String>]`: The unique identifier of bookingCustomer
  - `[BookingServiceId <String>]`: The unique identifier of bookingService
  - `[BookingStaffMemberBaseId <String>]`: The unique identifier of bookingStaffMemberBase
  - `[BookingStaffMemberId <String>]`: The unique identifier of bookingStaffMember
  - `[BusinessScenarioId <String>]`: The unique identifier of businessScenario
  - `[BusinessScenarioTaskId <String>]`: The unique identifier of businessScenarioTask
  - `[PlannerPlanConfigurationLocalizationId <String>]`: The unique identifier of plannerPlanConfigurationLocalization

## RELATED LINKS

