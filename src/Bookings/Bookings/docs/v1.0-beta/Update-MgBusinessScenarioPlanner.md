---
external help file:
Module Name: Microsoft.Graph.Bookings
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.bookings/update-mgbusinessscenarioplanner
schema: 2.0.0
---

# Update-MgBusinessScenarioPlanner

## SYNOPSIS
Update the navigation property planner in solutions

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBusinessScenarioPlanner -BusinessScenarioId <String> [-AdditionalProperties <Hashtable>]
 [-Id <String>] [-PlanConfiguration <IMicrosoftGraphPlannerPlanConfiguration>]
 [-TaskConfiguration <IMicrosoftGraphPlannerTaskConfiguration>]
 [-Tasks <IMicrosoftGraphBusinessScenarioTask[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBusinessScenarioPlanner -BusinessScenarioId <String>
 -BodyParameter <IMicrosoftGraphBusinessScenarioPlanner> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBusinessScenarioPlanner -InputObject <IBookingsIdentity>
 -BodyParameter <IMicrosoftGraphBusinessScenarioPlanner> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBusinessScenarioPlanner -InputObject <IBookingsIdentity> [-AdditionalProperties <Hashtable>]
 [-Id <String>] [-PlanConfiguration <IMicrosoftGraphPlannerPlanConfiguration>]
 [-TaskConfiguration <IMicrosoftGraphPlannerTaskConfiguration>]
 [-Tasks <IMicrosoftGraphBusinessScenarioTask[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property planner in solutions

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
businessScenarioPlanner
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBusinessScenarioPlanner
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

### -PlanConfiguration
plannerPlanConfiguration
To construct, please use Get-Help -Online and see NOTES section for PLANCONFIGURATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerPlanConfiguration
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TaskConfiguration
plannerTaskConfiguration
To construct, please use Get-Help -Online and see NOTES section for TASKCONFIGURATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerTaskConfiguration
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tasks
The Planner tasks for the scenario.
To construct, please use Get-Help -Online and see NOTES section for TASKS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBusinessScenarioTask[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphBusinessScenarioPlanner

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphBusinessScenarioPlanner>: businessScenarioPlanner
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[PlanConfiguration <IMicrosoftGraphPlannerPlanConfiguration>]`: plannerPlanConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Buckets <IMicrosoftGraphPlannerPlanConfigurationBucketDefinition[]>]`: List the buckets that should be created in the plan.
      - `[ExternalBucketId <String>]`: Application-specified identifier of the bucket.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
        - `[Id <String>]`: The identifier of the identity. This property is read-only.
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
  - `[TaskConfiguration <IMicrosoftGraphPlannerTaskConfiguration>]`: plannerTaskConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[EditPolicy <IMicrosoftGraphPlannerTaskPolicy>]`: plannerTaskPolicy
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Rules <IMicrosoftGraphPlannerTaskRoleBasedRule[]>]`: The rules that should be enforced on the tasks when they are being changed outside of the scenario, based on the role of the caller.
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
          - `[Assignments <IMicrosoftGraphPlannerFieldRules>]`: plannerFieldRules
          - `[CheckLists <IMicrosoftGraphPlannerFieldRules>]`: plannerFieldRules
          - `[Delete <String[]>]`: Rules and restrictions for deleting the task. Accepted values are allow and block.
          - `[DueDate <String[]>]`: Rules and restrictions for changing the due date of the task. Accepted values are allow and block.
          - `[Move <String[]>]`: Rules and restrictions for moving the task between buckets or plans. Accepted values are allow, moveBetweenPlans, moveBetweenBuckets, and block.
          - `[Notes <String[]>]`: Rules and restrictions for changing the notes of the task. Accepted values are allow and block.
          - `[Order <String[]>]`: Rules and restrictions for changing the order of the task. Accepted values are allow and block.
          - `[PercentComplete <String[]>]`: Rules and restrictions for changing the completion percentage of the task. Accepted values are allow, setToComplete, setToNotStarted, setToInProgress, and block.
          - `[PreviewType <String[]>]`: Rules and restrictions for changing the preview type of the task. Accepted values are allow and block.
          - `[Priority <String[]>]`: Rules and restrictions for changing the priority of the task. Accepted values are allow and block.
          - `[References <IMicrosoftGraphPlannerFieldRules>]`: plannerFieldRules
          - `[StartDate <String[]>]`: Rules and restrictions for changing the start date of the task. Accepted values are allow and block.
          - `[Title <String[]>]`: Rules and restrictions for changing the title of the task. Accepted values are allow and block.
        - `[Role <IMicrosoftGraphPlannerTaskConfigurationRoleBase>]`: plannerTaskConfigurationRoleBase
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[RoleKind <String>]`: plannerUserRoleKind
  - `[Tasks <IMicrosoftGraphBusinessScenarioTask[]>]`: The Planner tasks for the scenario.
    - `[ActiveChecklistItemCount <Int32?>]`: Number of checklist items with value set to false, representing incomplete items.
    - `[AppliedCategories <IMicrosoftGraphPlannerAppliedCategories>]`: plannerAppliedCategories
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AssignedToTaskBoardFormat <IMicrosoftGraphPlannerAssignedToTaskBoardTaskFormat>]`: plannerAssignedToTaskBoardTaskFormat
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[OrderHintsByAssignee <IMicrosoftGraphPlannerOrderHintsByAssignee>]`: plannerOrderHintsByAssignee
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[UnassignedOrderHint <String>]`: Hint value used to order the task on the AssignedTo view of the Task Board when the task is not assigned to anyone, or if the orderHintsByAssignee dictionary does not provide an order hint for the user the task is assigned to. The format is defined as outlined here.
    - `[AssigneePriority <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
    - `[Assignments <IMicrosoftGraphPlannerAssignments>]`: plannerAssignments
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[BucketId <String>]`: Bucket ID to which the task belongs. The bucket needs to be in the plan that the task is in. It is 28 characters long and case-sensitive. Format validation is done on the service.
    - `[BucketTaskBoardFormat <IMicrosoftGraphPlannerBucketTaskBoardTaskFormat>]`: plannerBucketTaskBoardTaskFormat
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[OrderHint <String>]`: Hint used to order tasks in the bucket view of the task board. For details about the supported format, see Using order hints in Planner.
    - `[ChecklistItemCount <Int32?>]`: Number of checklist items that are present on the task.
    - `[CompletedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CompletedDateTime <DateTime?>]`: Read-only. Date and time at which the 'percentComplete' of the task is set to '100'. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[ConversationThreadId <String>]`: Thread ID of the conversation on the task. This is the ID of the conversation thread object created in the group.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: Read-only. Date and time at which the task is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[CreationSource <IMicrosoftGraphPlannerTaskCreation>]`: plannerTaskCreation
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CreationSourceKind <String>]`: plannerCreationSourceKind
      - `[TeamsPublicationInfo <IMicrosoftGraphPlannerTeamsPublicationInfo>]`: plannerTeamsPublicationInfo
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[CreationSourceKind <String>]`: plannerCreationSourceKind
        - `[TeamsPublicationInfo <IMicrosoftGraphPlannerTeamsPublicationInfo>]`: plannerTeamsPublicationInfo
        - `[LastModifiedDateTime <DateTime?>]`: The date and time when this task was last modified by the publication process. Read-only.
        - `[PublicationId <String>]`: The identifier of the publication. Read-only.
        - `[PublishedToPlanId <String>]`: The identifier of the plannerPlan this task was originally placed in. Read-only.
        - `[PublishingTeamId <String>]`: The identifier of the team that initiated the publication process. Read-only.
        - `[PublishingTeamName <String>]`: The display name of the team that initiated the publication process. This display name is for reference only, and might not represent the most up-to-date name of the team. Read-only.
    - `[Details <IMicrosoftGraphPlannerTaskDetails>]`: plannerTaskDetails
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Checklist <IMicrosoftGraphPlannerChecklistItems>]`: plannerChecklistItems
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Description <String>]`: Description of the task.
      - `[Notes <IMicrosoftGraphItemBody>]`: itemBody
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Content <String>]`: The content of the item.
        - `[ContentType <String>]`: bodyType
      - `[PreviewType <String>]`: plannerPreviewType
      - `[References <IMicrosoftGraphPlannerExternalReferences>]`: plannerExternalReferences
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DueDateTime <DateTime?>]`: Date and time at which the task is due. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[HasDescription <Boolean?>]`: Read-only. Value is true if the details object of the task has a non-empty description and false otherwise.
    - `[OrderHint <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
    - `[PercentComplete <Int32?>]`: Percentage of task completion. When set to 100, the task is considered completed.
    - `[PlanId <String>]`: Plan ID to which the task belongs.
    - `[PreviewType <String>]`: plannerPreviewType
    - `[Priority <Int32?>]`: Priority of the task. Valid range of values is between 0 and 10 (inclusive), with increasing value being lower priority (0 has the highest priority and 10 has the lowest priority).  Currently, Planner interprets values 0 and 1 as 'urgent', 2 and 3 and 4 as 'important', 5, 6, and 7 as 'medium', and 8, 9, and 10 as 'low'.  Currently, Planner sets the value 1 for 'urgent', 3 for 'important', 5 for 'medium', and 9 for 'low'.
    - `[ProgressTaskBoardFormat <IMicrosoftGraphPlannerProgressTaskBoardTaskFormat>]`: plannerProgressTaskBoardTaskFormat
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[OrderHint <String>]`: Hint value used to order the task on the progress view of the task board. For details about the supported format, see Using order hints in Planner.
    - `[Recurrence <IMicrosoftGraphPlannerTaskRecurrence>]`: plannerTaskRecurrence
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[NextInSeriesTaskId <String>]`: 
      - `[OccurrenceId <Int32?>]`: 
      - `[PreviousInSeriesTaskId <String>]`: 
      - `[RecurrenceStartDateTime <DateTime?>]`: 
      - `[Schedule <IMicrosoftGraphPlannerRecurrenceSchedule>]`: plannerRecurrenceSchedule
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[NextOccurrenceDateTime <DateTime?>]`: 
        - `[Pattern <IMicrosoftGraphRecurrencePattern>]`: recurrencePattern
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[DayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
          - `[DaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
          - `[FirstDayOfWeek <String>]`: dayOfWeek
          - `[Index <String>]`: weekIndex
          - `[Interval <Int32?>]`: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.
          - `[Month <Int32?>]`: The month in which the event occurs.  This is a number from 1 to 12.
          - `[Type <String>]`: recurrencePatternType
        - `[PatternStartDateTime <DateTime?>]`: 
      - `[SeriesId <String>]`: 
    - `[ReferenceCount <Int32?>]`: Number of external references that exist on the task.
    - `[StartDateTime <DateTime?>]`: Date and time at which the task starts. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[Title <String>]`: Title of the task.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[BusinessScenarioProperties <IMicrosoftGraphBusinessScenarioProperties>]`: businessScenarioProperties
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ExternalBucketId <String>]`: The identifier for the bucketDefinition configured in the plannerPlanConfiguration for the scenario. The task will be placed in the corresponding plannerBucket in the target plan. Required.
      - `[ExternalContextId <String>]`: The identifier for the context of the task. Context is an application controlled value, and tasks can be queried by their externalContextId. Optional.
      - `[ExternalObjectId <String>]`: Application-specific identifier for the task. Every task for the same scenario must have a unique identifier specified for this property. Required.
      - `[ExternalObjectVersion <String>]`: Application-specific version of the task. Optional.
      - `[WebUrl <String>]`: The URL to the application-specific experience for this task. Optional.
    - `[Target <IMicrosoftGraphBusinessScenarioTaskTargetBase>]`: businessScenarioTaskTargetBase
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[TaskTargetKind <String>]`: plannerTaskTargetKind

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

PLANCONFIGURATION <IMicrosoftGraphPlannerPlanConfiguration>: plannerPlanConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Buckets <IMicrosoftGraphPlannerPlanConfigurationBucketDefinition[]>]`: List the buckets that should be created in the plan.
    - `[ExternalBucketId <String>]`: Application-specified identifier of the bucket.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
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

TASKCONFIGURATION <IMicrosoftGraphPlannerTaskConfiguration>: plannerTaskConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[EditPolicy <IMicrosoftGraphPlannerTaskPolicy>]`: plannerTaskPolicy
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Rules <IMicrosoftGraphPlannerTaskRoleBasedRule[]>]`: The rules that should be enforced on the tasks when they are being changed outside of the scenario, based on the role of the caller.
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
        - `[Assignments <IMicrosoftGraphPlannerFieldRules>]`: plannerFieldRules
        - `[CheckLists <IMicrosoftGraphPlannerFieldRules>]`: plannerFieldRules
        - `[Delete <String[]>]`: Rules and restrictions for deleting the task. Accepted values are allow and block.
        - `[DueDate <String[]>]`: Rules and restrictions for changing the due date of the task. Accepted values are allow and block.
        - `[Move <String[]>]`: Rules and restrictions for moving the task between buckets or plans. Accepted values are allow, moveBetweenPlans, moveBetweenBuckets, and block.
        - `[Notes <String[]>]`: Rules and restrictions for changing the notes of the task. Accepted values are allow and block.
        - `[Order <String[]>]`: Rules and restrictions for changing the order of the task. Accepted values are allow and block.
        - `[PercentComplete <String[]>]`: Rules and restrictions for changing the completion percentage of the task. Accepted values are allow, setToComplete, setToNotStarted, setToInProgress, and block.
        - `[PreviewType <String[]>]`: Rules and restrictions for changing the preview type of the task. Accepted values are allow and block.
        - `[Priority <String[]>]`: Rules and restrictions for changing the priority of the task. Accepted values are allow and block.
        - `[References <IMicrosoftGraphPlannerFieldRules>]`: plannerFieldRules
        - `[StartDate <String[]>]`: Rules and restrictions for changing the start date of the task. Accepted values are allow and block.
        - `[Title <String[]>]`: Rules and restrictions for changing the title of the task. Accepted values are allow and block.
      - `[Role <IMicrosoftGraphPlannerTaskConfigurationRoleBase>]`: plannerTaskConfigurationRoleBase
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[RoleKind <String>]`: plannerUserRoleKind

TASKS <IMicrosoftGraphBusinessScenarioTask[]>: The Planner tasks for the scenario.
  - `[ActiveChecklistItemCount <Int32?>]`: Number of checklist items with value set to false, representing incomplete items.
  - `[AppliedCategories <IMicrosoftGraphPlannerAppliedCategories>]`: plannerAppliedCategories
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AssignedToTaskBoardFormat <IMicrosoftGraphPlannerAssignedToTaskBoardTaskFormat>]`: plannerAssignedToTaskBoardTaskFormat
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[OrderHintsByAssignee <IMicrosoftGraphPlannerOrderHintsByAssignee>]`: plannerOrderHintsByAssignee
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[UnassignedOrderHint <String>]`: Hint value used to order the task on the AssignedTo view of the Task Board when the task is not assigned to anyone, or if the orderHintsByAssignee dictionary does not provide an order hint for the user the task is assigned to. The format is defined as outlined here.
  - `[AssigneePriority <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
  - `[Assignments <IMicrosoftGraphPlannerAssignments>]`: plannerAssignments
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[BucketId <String>]`: Bucket ID to which the task belongs. The bucket needs to be in the plan that the task is in. It is 28 characters long and case-sensitive. Format validation is done on the service.
  - `[BucketTaskBoardFormat <IMicrosoftGraphPlannerBucketTaskBoardTaskFormat>]`: plannerBucketTaskBoardTaskFormat
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[OrderHint <String>]`: Hint used to order tasks in the bucket view of the task board. For details about the supported format, see Using order hints in Planner.
  - `[ChecklistItemCount <Int32?>]`: Number of checklist items that are present on the task.
  - `[CompletedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CompletedDateTime <DateTime?>]`: Read-only. Date and time at which the 'percentComplete' of the task is set to '100'. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[ConversationThreadId <String>]`: Thread ID of the conversation on the task. This is the ID of the conversation thread object created in the group.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[CreatedDateTime <DateTime?>]`: Read-only. Date and time at which the task is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[CreationSource <IMicrosoftGraphPlannerTaskCreation>]`: plannerTaskCreation
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CreationSourceKind <String>]`: plannerCreationSourceKind
    - `[TeamsPublicationInfo <IMicrosoftGraphPlannerTeamsPublicationInfo>]`: plannerTeamsPublicationInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CreationSourceKind <String>]`: plannerCreationSourceKind
      - `[TeamsPublicationInfo <IMicrosoftGraphPlannerTeamsPublicationInfo>]`: plannerTeamsPublicationInfo
      - `[LastModifiedDateTime <DateTime?>]`: The date and time when this task was last modified by the publication process. Read-only.
      - `[PublicationId <String>]`: The identifier of the publication. Read-only.
      - `[PublishedToPlanId <String>]`: The identifier of the plannerPlan this task was originally placed in. Read-only.
      - `[PublishingTeamId <String>]`: The identifier of the team that initiated the publication process. Read-only.
      - `[PublishingTeamName <String>]`: The display name of the team that initiated the publication process. This display name is for reference only, and might not represent the most up-to-date name of the team. Read-only.
  - `[Details <IMicrosoftGraphPlannerTaskDetails>]`: plannerTaskDetails
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Checklist <IMicrosoftGraphPlannerChecklistItems>]`: plannerChecklistItems
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Description <String>]`: Description of the task.
    - `[Notes <IMicrosoftGraphItemBody>]`: itemBody
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Content <String>]`: The content of the item.
      - `[ContentType <String>]`: bodyType
    - `[PreviewType <String>]`: plannerPreviewType
    - `[References <IMicrosoftGraphPlannerExternalReferences>]`: plannerExternalReferences
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DueDateTime <DateTime?>]`: Date and time at which the task is due. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[HasDescription <Boolean?>]`: Read-only. Value is true if the details object of the task has a non-empty description and false otherwise.
  - `[OrderHint <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
  - `[PercentComplete <Int32?>]`: Percentage of task completion. When set to 100, the task is considered completed.
  - `[PlanId <String>]`: Plan ID to which the task belongs.
  - `[PreviewType <String>]`: plannerPreviewType
  - `[Priority <Int32?>]`: Priority of the task. Valid range of values is between 0 and 10 (inclusive), with increasing value being lower priority (0 has the highest priority and 10 has the lowest priority).  Currently, Planner interprets values 0 and 1 as 'urgent', 2 and 3 and 4 as 'important', 5, 6, and 7 as 'medium', and 8, 9, and 10 as 'low'.  Currently, Planner sets the value 1 for 'urgent', 3 for 'important', 5 for 'medium', and 9 for 'low'.
  - `[ProgressTaskBoardFormat <IMicrosoftGraphPlannerProgressTaskBoardTaskFormat>]`: plannerProgressTaskBoardTaskFormat
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[OrderHint <String>]`: Hint value used to order the task on the progress view of the task board. For details about the supported format, see Using order hints in Planner.
  - `[Recurrence <IMicrosoftGraphPlannerTaskRecurrence>]`: plannerTaskRecurrence
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[NextInSeriesTaskId <String>]`: 
    - `[OccurrenceId <Int32?>]`: 
    - `[PreviousInSeriesTaskId <String>]`: 
    - `[RecurrenceStartDateTime <DateTime?>]`: 
    - `[Schedule <IMicrosoftGraphPlannerRecurrenceSchedule>]`: plannerRecurrenceSchedule
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[NextOccurrenceDateTime <DateTime?>]`: 
      - `[Pattern <IMicrosoftGraphRecurrencePattern>]`: recurrencePattern
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
        - `[DaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
        - `[FirstDayOfWeek <String>]`: dayOfWeek
        - `[Index <String>]`: weekIndex
        - `[Interval <Int32?>]`: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.
        - `[Month <Int32?>]`: The month in which the event occurs.  This is a number from 1 to 12.
        - `[Type <String>]`: recurrencePatternType
      - `[PatternStartDateTime <DateTime?>]`: 
    - `[SeriesId <String>]`: 
  - `[ReferenceCount <Int32?>]`: Number of external references that exist on the task.
  - `[StartDateTime <DateTime?>]`: Date and time at which the task starts. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Title <String>]`: Title of the task.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[BusinessScenarioProperties <IMicrosoftGraphBusinessScenarioProperties>]`: businessScenarioProperties
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ExternalBucketId <String>]`: The identifier for the bucketDefinition configured in the plannerPlanConfiguration for the scenario. The task will be placed in the corresponding plannerBucket in the target plan. Required.
    - `[ExternalContextId <String>]`: The identifier for the context of the task. Context is an application controlled value, and tasks can be queried by their externalContextId. Optional.
    - `[ExternalObjectId <String>]`: Application-specific identifier for the task. Every task for the same scenario must have a unique identifier specified for this property. Required.
    - `[ExternalObjectVersion <String>]`: Application-specific version of the task. Optional.
    - `[WebUrl <String>]`: The URL to the application-specific experience for this task. Optional.
  - `[Target <IMicrosoftGraphBusinessScenarioTaskTargetBase>]`: businessScenarioTaskTargetBase
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[TaskTargetKind <String>]`: plannerTaskTargetKind

## RELATED LINKS

