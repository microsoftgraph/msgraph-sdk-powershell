---
external help file:
Module Name: Microsoft.Graph.Beta.Bookings
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.bookings/update-mgbusinessscenario
schema: 2.0.0
---

# Update-MgBetaBusinessScenario

## SYNOPSIS
Update the navigation property businessScenarios in solutions

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaBusinessScenario -BusinessScenarioId <String> [-AdditionalProperties <Hashtable>]
 [-CreatedBy <IMicrosoftGraphIdentitySet>] [-CreatedDateTime <DateTime>] [-DisplayName <String>]
 [-Id <String>] [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-LastModifiedDateTime <DateTime>]
 [-OwnerAppIds <String[]>] [-Planner <IMicrosoftGraphBusinessScenarioPlanner>] [-UniqueName <String>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaBusinessScenario -BusinessScenarioId <String> -BodyParameter <IMicrosoftGraphBusinessScenario>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaBusinessScenario -InputObject <IBookingsIdentity> -BodyParameter <IMicrosoftGraphBusinessScenario>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaBusinessScenario -InputObject <IBookingsIdentity> [-AdditionalProperties <Hashtable>]
 [-CreatedBy <IMicrosoftGraphIdentitySet>] [-CreatedDateTime <DateTime>] [-DisplayName <String>]
 [-Id <String>] [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-LastModifiedDateTime <DateTime>]
 [-OwnerAppIds <String[]>] [-Planner <IMicrosoftGraphBusinessScenarioPlanner>] [-UniqueName <String>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property businessScenarios in solutions

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
businessScenario
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphBusinessScenario
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

### -CreatedBy
identitySet
To construct, please use Get-Help -Online and see NOTES section for CREATEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
.

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

### -DisplayName
.

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
Type: Microsoft.Graph.Beta.PowerShell.Models.IBookingsIdentity
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
.

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

### -OwnerAppIds
.

```yaml
Type: System.String[]
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

### -Planner
businessScenarioPlanner
To construct, please use Get-Help -Online and see NOTES section for PLANNER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphBusinessScenarioPlanner
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UniqueName
.

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphBusinessScenario

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphBusinessScenario>: businessScenario
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: 
  - `[DisplayName <String>]`: 
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[OwnerAppIds <String[]>]`: 
  - `[Planner <IMicrosoftGraphBusinessScenarioPlanner>]`: businessScenarioPlanner
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[PlanConfiguration <IMicrosoftGraphPlannerPlanConfiguration>]`: plannerPlanConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Buckets <IMicrosoftGraphPlannerPlanConfigurationBucketDefinition[]>]`: 
        - `[ExternalBucketId <String>]`: 
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: 
      - `[DefaultLanguage <String>]`: 
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: 
      - `[Localizations <IMicrosoftGraphPlannerPlanConfigurationLocalization[]>]`: 
        - `[Id <String>]`: The unique idenfier for an entity. Read-only.
        - `[Buckets <IMicrosoftGraphPlannerPlanConfigurationBucketLocalization[]>]`: 
          - `[ExternalBucketId <String>]`: 
          - `[Name <String>]`: 
        - `[LanguageTag <String>]`: 
        - `[PlanTitle <String>]`: 
    - `[TaskConfiguration <IMicrosoftGraphPlannerTaskConfiguration>]`: plannerTaskConfiguration
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
    - `[Tasks <IMicrosoftGraphBusinessScenarioTask[]>]`: 
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
        - `[OrderHint <String>]`: Hint used to order tasks in the Bucket view of the Task Board. The format is defined as outlined here.
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
      - `[ReferenceCount <Int32?>]`: Number of external references that exist on the task.
      - `[StartDateTime <DateTime?>]`: Date and time at which the task starts. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[Title <String>]`: Title of the task.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[BusinessScenarioProperties <IMicrosoftGraphBusinessScenarioProperties>]`: businessScenarioProperties
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ExternalBucketId <String>]`: 
        - `[ExternalContextId <String>]`: 
        - `[ExternalObjectId <String>]`: 
        - `[ExternalObjectVersion <String>]`: 
        - `[WebUrl <String>]`: 
      - `[Target <IMicrosoftGraphBusinessScenarioTaskTargetBase>]`: businessScenarioTaskTargetBase
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[TaskTargetKind <String>]`: plannerTaskTargetKind
  - `[UniqueName <String>]`: 

CREATEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
    - `[Id <String>]`: The identifier of the identity. This property is read-only.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

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

LASTMODIFIEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
    - `[Id <String>]`: The identifier of the identity. This property is read-only.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

PLANNER <IMicrosoftGraphBusinessScenarioPlanner>: businessScenarioPlanner
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[PlanConfiguration <IMicrosoftGraphPlannerPlanConfiguration>]`: plannerPlanConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Buckets <IMicrosoftGraphPlannerPlanConfigurationBucketDefinition[]>]`: 
      - `[ExternalBucketId <String>]`: 
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
        - `[Id <String>]`: The identifier of the identity. This property is read-only.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[CreatedDateTime <DateTime?>]`: 
    - `[DefaultLanguage <String>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Localizations <IMicrosoftGraphPlannerPlanConfigurationLocalization[]>]`: 
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Buckets <IMicrosoftGraphPlannerPlanConfigurationBucketLocalization[]>]`: 
        - `[ExternalBucketId <String>]`: 
        - `[Name <String>]`: 
      - `[LanguageTag <String>]`: 
      - `[PlanTitle <String>]`: 
  - `[TaskConfiguration <IMicrosoftGraphPlannerTaskConfiguration>]`: plannerTaskConfiguration
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
  - `[Tasks <IMicrosoftGraphBusinessScenarioTask[]>]`: 
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
      - `[OrderHint <String>]`: Hint used to order tasks in the Bucket view of the Task Board. The format is defined as outlined here.
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
    - `[ReferenceCount <Int32?>]`: Number of external references that exist on the task.
    - `[StartDateTime <DateTime?>]`: Date and time at which the task starts. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[Title <String>]`: Title of the task.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[BusinessScenarioProperties <IMicrosoftGraphBusinessScenarioProperties>]`: businessScenarioProperties
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ExternalBucketId <String>]`: 
      - `[ExternalContextId <String>]`: 
      - `[ExternalObjectId <String>]`: 
      - `[ExternalObjectVersion <String>]`: 
      - `[WebUrl <String>]`: 
    - `[Target <IMicrosoftGraphBusinessScenarioTaskTargetBase>]`: businessScenarioTaskTargetBase
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[TaskTargetKind <String>]`: plannerTaskTargetKind

## RELATED LINKS

