---
external help file:
Module Name: Microsoft.Graph.Bookings
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.bookings/update-mgbusinessscenarioplannerplanconfiguration
schema: 2.0.0
---

# Update-MgBusinessScenarioPlannerPlanConfiguration

## SYNOPSIS
Update the properties of a plannerPlanConfiguration object for a businessScenario.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBusinessScenarioPlannerPlanConfiguration -BusinessScenarioId <String>
 [-AdditionalProperties <Hashtable>] [-Buckets <IMicrosoftGraphPlannerPlanConfigurationBucketDefinition[]>]
 [-CreatedBy <IMicrosoftGraphIdentitySet>] [-CreatedDateTime <DateTime>] [-DefaultLanguage <String>]
 [-Id <String>] [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-LastModifiedDateTime <DateTime>]
 [-Localizations <IMicrosoftGraphPlannerPlanConfigurationLocalization[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgBusinessScenarioPlannerPlanConfiguration -BusinessScenarioId <String>
 -BodyParameter <IMicrosoftGraphPlannerPlanConfiguration> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBusinessScenarioPlannerPlanConfiguration -InputObject <IBookingsIdentity>
 -BodyParameter <IMicrosoftGraphPlannerPlanConfiguration> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBusinessScenarioPlannerPlanConfiguration -InputObject <IBookingsIdentity>
 [-AdditionalProperties <Hashtable>] [-Buckets <IMicrosoftGraphPlannerPlanConfigurationBucketDefinition[]>]
 [-CreatedBy <IMicrosoftGraphIdentitySet>] [-CreatedDateTime <DateTime>] [-DefaultLanguage <String>]
 [-Id <String>] [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-LastModifiedDateTime <DateTime>]
 [-Localizations <IMicrosoftGraphPlannerPlanConfigurationLocalization[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the properties of a plannerPlanConfiguration object for a businessScenario.

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
plannerPlanConfiguration
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerPlanConfiguration
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Buckets
List the buckets that should be created in the plan.
To construct, please use Get-Help -Online and see NOTES section for BUCKETS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerPlanConfigurationBucketDefinition[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedBy
identitySet
To construct, please use Get-Help -Online and see NOTES section for CREATEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The date and time when the plan configuration was created.
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultLanguage
The language code for the default language to be used for the names of the objects created for the plan.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastModifiedBy
identitySet
To construct, please use Get-Help -Online and see NOTES section for LASTMODIFIEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
The date and time when the plan configuration was last modified.
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Localizations
Localized names for the plan configuration.
To construct, please use Get-Help -Online and see NOTES section for LOCALIZATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerPlanConfigurationLocalization[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerPlanConfiguration

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphPlannerPlanConfiguration>: plannerPlanConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Buckets <IMicrosoftGraphPlannerPlanConfigurationBucketDefinition[]>]`: List the buckets that should be created in the plan.
    - `[ExternalBucketId <String>]`: Application-specified identifier of the bucket.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: The date and time when the plan configuration was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[DefaultLanguage <String>]`: The language code for the default language to be used for the names of the objects created for the plan.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: The date and time when the plan configuration was last modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[Localizations <IMicrosoftGraphPlannerPlanConfigurationLocalization[]>]`: Localized names for the plan configuration.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Buckets <IMicrosoftGraphPlannerPlanConfigurationBucketLocalization[]>]`: Localized names for configured buckets in the plan configuration.
      - `[ExternalBucketId <String>]`: Application-specified identifier of the bucket.
      - `[Name <String>]`: Name of the bucket.
    - `[LanguageTag <String>]`: The language code associated with the localized names in this object.
    - `[PlanTitle <String>]`: Localized title of the plan.

BUCKETS <IMicrosoftGraphPlannerPlanConfigurationBucketDefinition[]>: List the buckets that should be created in the plan.
  - `[ExternalBucketId <String>]`: Application-specified identifier of the bucket.

CREATEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

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

LASTMODIFIEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

LOCALIZATIONS <IMicrosoftGraphPlannerPlanConfigurationLocalization[]>: Localized names for the plan configuration.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Buckets <IMicrosoftGraphPlannerPlanConfigurationBucketLocalization[]>]`: Localized names for configured buckets in the plan configuration.
    - `[ExternalBucketId <String>]`: Application-specified identifier of the bucket.
    - `[Name <String>]`: Name of the bucket.
  - `[LanguageTag <String>]`: The language code associated with the localized names in this object.
  - `[PlanTitle <String>]`: Localized title of the plan.

## RELATED LINKS

