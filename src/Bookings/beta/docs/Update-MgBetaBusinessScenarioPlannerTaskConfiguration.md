---
external help file:
Module Name: Microsoft.Graph.Beta.Bookings
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.bookings/update-mgbetabusinessscenarioplannertaskconfiguration
schema: 2.0.0
---

# Update-MgBetaBusinessScenarioPlannerTaskConfiguration

## SYNOPSIS
Update the properties of a plannerTaskConfiguration object.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaBusinessScenarioPlannerTaskConfiguration -BusinessScenarioId <String>
 [-AdditionalProperties <Hashtable>] [-EditPolicy <IMicrosoftGraphPlannerTaskPolicy>] [-Id <String>]
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaBusinessScenarioPlannerTaskConfiguration -BusinessScenarioId <String>
 -BodyParameter <IMicrosoftGraphPlannerTaskConfiguration> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaBusinessScenarioPlannerTaskConfiguration -InputObject <IBookingsIdentity>
 -BodyParameter <IMicrosoftGraphPlannerTaskConfiguration> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaBusinessScenarioPlannerTaskConfiguration -InputObject <IBookingsIdentity>
 [-AdditionalProperties <Hashtable>] [-EditPolicy <IMicrosoftGraphPlannerTaskPolicy>] [-Id <String>]
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the properties of a plannerTaskConfiguration object.

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
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

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

### -EditPolicy
plannerTaskPolicy
To construct, see NOTES section for EDITPOLICY properties and create a hash table.

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
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

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

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPlannerTaskConfiguration

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphPlannerTaskConfiguration>`: plannerTaskConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[EditPolicy <IMicrosoftGraphPlannerTaskPolicy>]`: plannerTaskPolicy
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Rules <IMicrosoftGraphPlannerTaskRoleBasedRule[]>]`: The rules that should be enforced on the tasks when they're being changed outside of the scenario, based on the role of the caller.
      - `[DefaultRule <String>]`: Default rule that applies when a property or action-specific rule is not provided. Possible values are: Allow, Block
      - `[PropertyRule <IMicrosoftGraphPlannerTaskPropertyRule>]`: plannerTaskPropertyRule
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[RuleKind <String>]`: plannerRuleKind
        - `[AppliedCategories <IMicrosoftGraphPlannerFieldRules>]`: plannerFieldRules
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[DefaultRules <String[]>]`: The default rules that apply if no override matches to the current data.
          - `[Overrides <IMicrosoftGraphPlannerRuleOverride[]>]`: Overrides that specify different rules for specific data associated with the field.
            - `[Name <String>]`: Name of the override. Allowed override values will be dependent on the property affected by the rule.
            - `[Rules <String[]>]`: Overridden rules. These are used as rules for the override instead of the default rules.
        - `[ApprovalAttachment <IMicrosoftGraphPlannerFieldRules>]`: plannerFieldRules
        - `[Assignments <IMicrosoftGraphPlannerFieldRules>]`: plannerFieldRules
        - `[CheckLists <IMicrosoftGraphPlannerFieldRules>]`: plannerFieldRules
        - `[CompletionRequirements <String[]>]`: Rules and restrictions for completion requirements of the task. Accepted values are allow, add, remove, edit, and block.
        - `[Delete <String[]>]`: Rules and restrictions for deleting the task. Accepted values are allow and block.
        - `[DueDate <String[]>]`: Rules and restrictions for changing the due date of the task. Accepted values are allow and block.
        - `[Forms <IMicrosoftGraphPlannerFieldRules>]`: plannerFieldRules
        - `[Move <String[]>]`: Rules and restrictions for moving the task between buckets or plans. Accepted values are allow, moveBetweenPlans, moveBetweenBuckets, and block.
        - `[Notes <String[]>]`: Rules and restrictions for changing the notes of the task. Accepted values are allow and block.
        - `[Order <String[]>]`: Rules and restrictions for changing the order of the task. Accepted values are allow and block.
        - `[PercentComplete <String[]>]`: Rules and restrictions for changing the completion percentage of the task. Accepted values are allow, setToComplete, overrideRequirements, setToNotStarted, setToInProgress, and block.
        - `[PreviewType <String[]>]`: Rules and restrictions for changing the preview type of the task. Accepted values are allow and block.
        - `[Priority <String[]>]`: Rules and restrictions for changing the priority of the task. Accepted values are allow and block.
        - `[References <IMicrosoftGraphPlannerFieldRules>]`: plannerFieldRules
        - `[StartDate <String[]>]`: Rules and restrictions for changing the start date of the task. Accepted values are allow and block.
        - `[Title <String[]>]`: Rules and restrictions for changing the title of the task. Accepted values are allow and block.
      - `[Role <IMicrosoftGraphPlannerTaskConfigurationRoleBase>]`: plannerTaskConfigurationRoleBase
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[RoleKind <String>]`: plannerUserRoleKind

`EDITPOLICY <IMicrosoftGraphPlannerTaskPolicy>`: plannerTaskPolicy
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Rules <IMicrosoftGraphPlannerTaskRoleBasedRule[]>]`: The rules that should be enforced on the tasks when they're being changed outside of the scenario, based on the role of the caller.
    - `[DefaultRule <String>]`: Default rule that applies when a property or action-specific rule is not provided. Possible values are: Allow, Block
    - `[PropertyRule <IMicrosoftGraphPlannerTaskPropertyRule>]`: plannerTaskPropertyRule
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[RuleKind <String>]`: plannerRuleKind
      - `[AppliedCategories <IMicrosoftGraphPlannerFieldRules>]`: plannerFieldRules
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DefaultRules <String[]>]`: The default rules that apply if no override matches to the current data.
        - `[Overrides <IMicrosoftGraphPlannerRuleOverride[]>]`: Overrides that specify different rules for specific data associated with the field.
          - `[Name <String>]`: Name of the override. Allowed override values will be dependent on the property affected by the rule.
          - `[Rules <String[]>]`: Overridden rules. These are used as rules for the override instead of the default rules.
      - `[ApprovalAttachment <IMicrosoftGraphPlannerFieldRules>]`: plannerFieldRules
      - `[Assignments <IMicrosoftGraphPlannerFieldRules>]`: plannerFieldRules
      - `[CheckLists <IMicrosoftGraphPlannerFieldRules>]`: plannerFieldRules
      - `[CompletionRequirements <String[]>]`: Rules and restrictions for completion requirements of the task. Accepted values are allow, add, remove, edit, and block.
      - `[Delete <String[]>]`: Rules and restrictions for deleting the task. Accepted values are allow and block.
      - `[DueDate <String[]>]`: Rules and restrictions for changing the due date of the task. Accepted values are allow and block.
      - `[Forms <IMicrosoftGraphPlannerFieldRules>]`: plannerFieldRules
      - `[Move <String[]>]`: Rules and restrictions for moving the task between buckets or plans. Accepted values are allow, moveBetweenPlans, moveBetweenBuckets, and block.
      - `[Notes <String[]>]`: Rules and restrictions for changing the notes of the task. Accepted values are allow and block.
      - `[Order <String[]>]`: Rules and restrictions for changing the order of the task. Accepted values are allow and block.
      - `[PercentComplete <String[]>]`: Rules and restrictions for changing the completion percentage of the task. Accepted values are allow, setToComplete, overrideRequirements, setToNotStarted, setToInProgress, and block.
      - `[PreviewType <String[]>]`: Rules and restrictions for changing the preview type of the task. Accepted values are allow and block.
      - `[Priority <String[]>]`: Rules and restrictions for changing the priority of the task. Accepted values are allow and block.
      - `[References <IMicrosoftGraphPlannerFieldRules>]`: plannerFieldRules
      - `[StartDate <String[]>]`: Rules and restrictions for changing the start date of the task. Accepted values are allow and block.
      - `[Title <String[]>]`: Rules and restrictions for changing the title of the task. Accepted values are allow and block.
    - `[Role <IMicrosoftGraphPlannerTaskConfigurationRoleBase>]`: plannerTaskConfigurationRoleBase
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[RoleKind <String>]`: plannerUserRoleKind

`INPUTOBJECT <IBookingsIdentity>`: Identity Parameter
  - `[AttendanceRecordId <String>]`: The unique identifier of attendanceRecord
  - `[BookingAppointmentId <String>]`: The unique identifier of bookingAppointment
  - `[BookingBusinessId <String>]`: The unique identifier of bookingBusiness
  - `[BookingCurrencyId <String>]`: The unique identifier of bookingCurrency
  - `[BookingCustomQuestionId <String>]`: The unique identifier of bookingCustomQuestion
  - `[BookingCustomerId <String>]`: The unique identifier of bookingCustomer
  - `[BookingServiceId <String>]`: The unique identifier of bookingService
  - `[BookingStaffMemberId <String>]`: The unique identifier of bookingStaffMember
  - `[BusinessScenarioId <String>]`: The unique identifier of businessScenario
  - `[BusinessScenarioTaskId <String>]`: The unique identifier of businessScenarioTask
  - `[JoinWebUrl <String>]`: Alternate key of virtualEventSession
  - `[MeetingAttendanceReportId <String>]`: The unique identifier of meetingAttendanceReport
  - `[PlannerPlanConfigurationLocalizationId <String>]`: The unique identifier of plannerPlanConfigurationLocalization
  - `[Role <String>]`: Usage: role='{role}'
  - `[UniqueName <String>]`: Alternate key of businessScenario
  - `[UserId <String>]`: Usage: userId='{userId}'
  - `[VirtualEventId <String>]`: The unique identifier of virtualEvent
  - `[VirtualEventPresenterId <String>]`: The unique identifier of virtualEventPresenter
  - `[VirtualEventRegistrationId <String>]`: The unique identifier of virtualEventRegistration
  - `[VirtualEventSessionId <String>]`: The unique identifier of virtualEventSession
  - `[VirtualEventTownhallId <String>]`: The unique identifier of virtualEventTownhall
  - `[VirtualEventWebinarId <String>]`: The unique identifier of virtualEventWebinar

## RELATED LINKS

