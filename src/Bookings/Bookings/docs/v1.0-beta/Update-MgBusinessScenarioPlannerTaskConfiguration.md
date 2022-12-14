---
external help file:
Module Name: Microsoft.Graph.Beta.Bookings
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.bookings/update-mgbusinessscenarioplannertaskconfiguration
schema: 2.0.0
---

# Update-MgBetaBusinessScenarioPlannerTaskConfiguration

## SYNOPSIS
Update the navigation property taskConfiguration in solutions

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaBusinessScenarioPlannerTaskConfiguration -BusinessScenarioId <String>
 [-AdditionalProperties <Hashtable>] [-EditPolicy <IMicrosoftGraphPlannerTaskPolicy>] [-Id <String>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaBusinessScenarioPlannerTaskConfiguration -BusinessScenarioId <String>
 -BodyParameter <IMicrosoftGraphPlannerTaskConfiguration> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaBusinessScenarioPlannerTaskConfiguration -InputObject <IBookingsIdentity>
 -BodyParameter <IMicrosoftGraphPlannerTaskConfiguration> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaBusinessScenarioPlannerTaskConfiguration -InputObject <IBookingsIdentity>
 [-AdditionalProperties <Hashtable>] [-EditPolicy <IMicrosoftGraphPlannerTaskPolicy>] [-Id <String>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property taskConfiguration in solutions

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
plannerTaskConfiguration
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPlannerTaskConfiguration
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -BusinessScenarioId
key: id of businessScenario

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

### -EditPolicy
plannerTaskPolicy
To construct, please use Get-Help -Online and see NOTES section for EDITPOLICY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPlannerTaskPolicy
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IBookingsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### Microsoft.Graph.Beta.PowerShell.Models.IBookingsIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPlannerTaskConfiguration

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphPlannerTaskConfiguration>: plannerTaskConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[EditPolicy <IMicrosoftGraphPlannerTaskPolicy>]`: plannerTaskPolicy
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Rules <IMicrosoftGraphPlannerTaskRoleBasedRule[]>]`: 
      - `[DefaultRule <String>]`: 
      - `[PropertyRule <IMicrosoftGraphPlannerTaskPropertyRule>]`: plannerTaskPropertyRule
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[RuleKind <String>]`: plannerRuleKind
        - `[AppliedCategories <IMicrosoftGraphPlannerFieldRules>]`: plannerFieldRules
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[DefaultRules <String[]>]`: 
          - `[Overrides <IMicrosoftGraphPlannerRuleOverride[]>]`: 
            - `[Name <String>]`: 
            - `[Rules <String[]>]`: 
        - `[Assignments <IMicrosoftGraphPlannerFieldRules>]`: plannerFieldRules
        - `[CheckLists <IMicrosoftGraphPlannerFieldRules>]`: plannerFieldRules
        - `[Delete <String[]>]`: 
        - `[DueDate <String[]>]`: 
        - `[Move <String[]>]`: 
        - `[Notes <String[]>]`: 
        - `[Order <String[]>]`: 
        - `[PercentComplete <String[]>]`: 
        - `[PreviewType <String[]>]`: 
        - `[Priority <String[]>]`: 
        - `[References <IMicrosoftGraphPlannerFieldRules>]`: plannerFieldRules
        - `[StartDate <String[]>]`: 
        - `[Title <String[]>]`: 
      - `[Role <IMicrosoftGraphPlannerTaskConfigurationRoleBase>]`: plannerTaskConfigurationRoleBase
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[RoleKind <String>]`: plannerUserRoleKind

EDITPOLICY <IMicrosoftGraphPlannerTaskPolicy>: plannerTaskPolicy
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Rules <IMicrosoftGraphPlannerTaskRoleBasedRule[]>]`: 
    - `[DefaultRule <String>]`: 
    - `[PropertyRule <IMicrosoftGraphPlannerTaskPropertyRule>]`: plannerTaskPropertyRule
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[RuleKind <String>]`: plannerRuleKind
      - `[AppliedCategories <IMicrosoftGraphPlannerFieldRules>]`: plannerFieldRules
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DefaultRules <String[]>]`: 
        - `[Overrides <IMicrosoftGraphPlannerRuleOverride[]>]`: 
          - `[Name <String>]`: 
          - `[Rules <String[]>]`: 
      - `[Assignments <IMicrosoftGraphPlannerFieldRules>]`: plannerFieldRules
      - `[CheckLists <IMicrosoftGraphPlannerFieldRules>]`: plannerFieldRules
      - `[Delete <String[]>]`: 
      - `[DueDate <String[]>]`: 
      - `[Move <String[]>]`: 
      - `[Notes <String[]>]`: 
      - `[Order <String[]>]`: 
      - `[PercentComplete <String[]>]`: 
      - `[PreviewType <String[]>]`: 
      - `[Priority <String[]>]`: 
      - `[References <IMicrosoftGraphPlannerFieldRules>]`: plannerFieldRules
      - `[StartDate <String[]>]`: 
      - `[Title <String[]>]`: 
    - `[Role <IMicrosoftGraphPlannerTaskConfigurationRoleBase>]`: plannerTaskConfigurationRoleBase
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[RoleKind <String>]`: plannerUserRoleKind

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

