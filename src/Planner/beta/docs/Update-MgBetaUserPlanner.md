---
external help file:
Module Name: Microsoft.Graph.Beta.Planner
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.planner/update-mgbetauserplanner
schema: 2.0.0
---

# Update-MgBetaUserPlanner

## SYNOPSIS
Update the navigation property planner in users

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaUserPlanner -UserId <String> -IfMatch <String> [-AdditionalProperties <Hashtable>]
 [-All <IMicrosoftGraphPlannerDelta[]>] [-FavoritePlanReferences <Hashtable>]
 [-FavoritePlans <IMicrosoftGraphPlannerPlan[]>] [-Id <String>] [-Plans <IMicrosoftGraphPlannerPlan[]>]
 [-RecentPlanReferences <Hashtable>] [-RecentPlans <IMicrosoftGraphPlannerPlan[]>]
 [-RosterPlans <IMicrosoftGraphPlannerPlan[]>] [-Tasks <IMicrosoftGraphPlannerTask[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgBetaUserPlanner -UserId <String> -IfMatch <String> -BodyParameter <IMicrosoftGraphPlannerUser>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaUserPlanner -InputObject <IPlannerIdentity> -IfMatch <String>
 -BodyParameter <IMicrosoftGraphPlannerUser> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaUserPlanner -InputObject <IPlannerIdentity> -IfMatch <String> [-AdditionalProperties <Hashtable>]
 [-All <IMicrosoftGraphPlannerDelta[]>] [-FavoritePlanReferences <Hashtable>]
 [-FavoritePlans <IMicrosoftGraphPlannerPlan[]>] [-Id <String>] [-Plans <IMicrosoftGraphPlannerPlan[]>]
 [-RecentPlanReferences <Hashtable>] [-RecentPlans <IMicrosoftGraphPlannerPlan[]>]
 [-RosterPlans <IMicrosoftGraphPlannerPlan[]>] [-Tasks <IMicrosoftGraphPlannerTask[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property planner in users

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Planner
$params = @{
	FavoritePlanReferences = @{
		Jd8S5gOaFk2S8aWCIAJz42QAAxtD = @{
			"@odata.type" = "#microsoft.graph.plannerFavoritePlanReference"
			OrderHint = " !"
			PlanTitle = "Next Release Discussion"
		}
		"7oTB5aMIAE2rVo-1N-L7RmQAGX2q" = $null
	}
	RecentPlanReferences = @{
		Jd8S5gOaFk2S8aWCIAJz42QAAxtD = @{
			"@odata.type" = "#microsoft.graph.plannerRecentPlanReference"
			LastAccessedDateTime = "2018-01-02T22:49:46.155Z"
			PlanTitle = "Next Release Discussion"
		}
	}
}
# A UPN can also be used as -UserId.
Update-MgBetaUserPlanner -UserId $userId -BodyParameter $params
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

### -All
.
To construct, see NOTES section for ALL properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPlannerDelta[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
plannerUser
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPlannerUser
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -FavoritePlanReferences
plannerFavoritePlanReferenceCollection

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

### -FavoritePlans
Read-only.
Nullable.
Returns the plannerPlans that the user marked as favorites.
To construct, see NOTES section for FAVORITEPLANS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPlannerPlan[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
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

### -IfMatch
ETag value.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IPlannerIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Plans
.
To construct, see NOTES section for PLANS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPlannerPlan[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RecentPlanReferences
plannerRecentPlanReferenceCollection

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

### -RecentPlans
Read-only.
Nullable.
Returns the plannerPlans that have been recently viewed by the user in apps that support recent plans.
To construct, see NOTES section for RECENTPLANS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPlannerPlan[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RosterPlans
Read-only.
Nullable.
Returns the plannerPlans contained by the plannerRosters the user is a member.
To construct, see NOTES section for ROSTERPLANS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPlannerPlan[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tasks
Read-only.
Nullable.
Returns the plannerTasks assigned to the user.
To construct, see NOTES section for TASKS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPlannerTask[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
The unique identifier of user

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPlannerUser

### Microsoft.Graph.Beta.PowerShell.Models.IPlannerIdentity

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPlannerUser

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ALL <IMicrosoftGraphPlannerDelta[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.

`BODYPARAMETER <IMicrosoftGraphPlannerUser>`: plannerUser
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[All <IMicrosoftGraphPlannerDelta[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[FavoritePlanReferences <IMicrosoftGraphPlannerFavoritePlanReferenceCollection>]`: plannerFavoritePlanReferenceCollection
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[FavoritePlans <IMicrosoftGraphPlannerPlan[]>]`: Read-only. Nullable. Returns the plannerPlans that the user marked as favorites.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Buckets <IMicrosoftGraphPlannerBucket[]>]`: Collection of buckets in the plan. Read-only. Nullable.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[CreationSource <IMicrosoftGraphPlannerBucketCreation>]`: plannerBucketCreation
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[CreationSourceKind <String>]`: plannerCreationSourceKind
      - `[Name <String>]`: Name of the bucket.
      - `[OrderHint <String>]`: Hint used to order items of this type in a list view. For details about the supported format, see Using order hints in Planner.
      - `[PlanId <String>]`: Plan ID to which the bucket belongs.
      - `[Tasks <IMicrosoftGraphPlannerTask[]>]`: Read-only. Nullable. The collection of tasks in the bucket.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[ActiveChecklistItemCount <Int32?>]`: Number of checklist items with value set to false, representing incomplete items.
        - `[AppliedCategories <IMicrosoftGraphPlannerAppliedCategories>]`: plannerAppliedCategories
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AssignedToTaskBoardFormat <IMicrosoftGraphPlannerAssignedToTaskBoardTaskFormat>]`: plannerAssignedToTaskBoardTaskFormat
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Id <String>]`: The unique identifier for an entity. Read-only.
          - `[OrderHintsByAssignee <IMicrosoftGraphPlannerOrderHintsByAssignee>]`: plannerOrderHintsByAssignee
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[UnassignedOrderHint <String>]`: Hint value used to order the task on the AssignedTo view of the Task Board when the task isn't assigned to anyone, or if the orderHintsByAssignee dictionary doesn't provide an order hint for the user the task is assigned to. The format is defined as outlined here.
        - `[AssigneePriority <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
        - `[Assignments <IMicrosoftGraphPlannerAssignments>]`: plannerAssignments
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[BucketId <String>]`: Bucket ID to which the task belongs. The bucket needs to be in the plan that the task is in. It is 28 characters long and case-sensitive. Format validation is done on the service.
        - `[BucketTaskBoardFormat <IMicrosoftGraphPlannerBucketTaskBoardTaskFormat>]`: plannerBucketTaskBoardTaskFormat
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Id <String>]`: The unique identifier for an entity. Read-only.
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
          - `[Id <String>]`: The unique identifier for an entity. Read-only.
          - `[Checklist <IMicrosoftGraphPlannerChecklistItems>]`: plannerChecklistItems
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[CompletionRequirements <IMicrosoftGraphPlannerTaskCompletionRequirementDetails>]`: plannerTaskCompletionRequirementDetails
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[ChecklistRequirement <IMicrosoftGraphPlannerChecklistRequirement>]`: plannerChecklistRequirement
              - `[(Any) <Object>]`: This indicates any property can be added to this object.
              - `[RequiredChecklistItemIds <String[]>]`: A collection of required plannerChecklistItems identifiers to complete the plannerTask.
          - `[Description <String>]`: Description of the task.
          - `[Notes <IMicrosoftGraphItemBody>]`: itemBody
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Content <String>]`: The content of the item.
            - `[ContentType <String>]`: bodyType
          - `[PreviewType <String>]`: plannerPreviewType
          - `[References <IMicrosoftGraphPlannerExternalReferences>]`: plannerExternalReferences
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DueDateTime <DateTime?>]`: Date and time at which the task is due. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        - `[HasDescription <Boolean?>]`: Read-only. Value is true if the details object of the task has a nonempty description and false otherwise.
        - `[OrderHint <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
        - `[PercentComplete <Int32?>]`: Percentage of task completion. When set to 100, the task is considered completed.
        - `[PlanId <String>]`: Plan ID to which the task belongs.
        - `[PreviewType <String>]`: plannerPreviewType
        - `[Priority <Int32?>]`: Priority of the task. Valid range of values is between 0 and 10 (inclusive), with increasing value being lower priority (0 has the highest priority and 10 has the lowest priority).  Currently, Planner interprets values 0 and 1 as 'urgent', 2 and 3 and 4 as 'important', 5, 6, and 7 as 'medium', and 8, 9, and 10 as 'low'.  Currently, Planner sets the value 1 for 'urgent', 3 for 'important', 5 for 'medium', and 9 for 'low'.
        - `[ProgressTaskBoardFormat <IMicrosoftGraphPlannerProgressTaskBoardTaskFormat>]`: plannerProgressTaskBoardTaskFormat
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Id <String>]`: The unique identifier for an entity. Read-only.
          - `[OrderHint <String>]`: Hint value used to order the task on the progress view of the task board. For details about the supported format, see Using order hints in Planner.
        - `[Recurrence <IMicrosoftGraphPlannerTaskRecurrence>]`: plannerTaskRecurrence
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[NextInSeriesTaskId <String>]`: The taskId of the next task in this series. This value is assigned at the time the next task in the series is created, and is null prior to that time.
          - `[OccurrenceId <Int32?>]`: The 1-based index of this task within the recurrence series. The first task in a series has the value 1, the next task in the series has the value 2, and so on.
          - `[PreviousInSeriesTaskId <String>]`: The taskId of the previous task in this series. null for the first task in a series since it has no predecessor. All subsequent tasks in the series have a value that corresponds to their predecessors.
          - `[RecurrenceStartDateTime <DateTime?>]`: The date and time when this recurrence series begin. For the first task in a series (occurrenceId = 1) this value is copied from schedule.patternStartDateTime. For subsequent tasks in the series (occurrenceId >= 2) this value is copied from the previous task and never changes; it preserves the start date of the recurring series. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
          - `[Schedule <IMicrosoftGraphPlannerRecurrenceSchedule>]`: plannerRecurrenceSchedule
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[NextOccurrenceDateTime <DateTime?>]`: The next date for this schedule. When a new task is instantiated to continue the recurrence series, this date is used for the dueDateTime of the new plannerTask. Auto-generated by the service. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
            - `[Pattern <IMicrosoftGraphRecurrencePattern>]`: recurrencePattern
              - `[(Any) <Object>]`: This indicates any property can be added to this object.
              - `[DayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
              - `[DaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
              - `[FirstDayOfWeek <String>]`: dayOfWeek
              - `[Index <String>]`: weekIndex
              - `[Interval <Int32?>]`: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.
              - `[Month <Int32?>]`: The month in which the event occurs.  This is a number from 1 to 12.
              - `[Type <String>]`: recurrencePatternType
            - `[PatternStartDateTime <DateTime?>]`: The start date for the recurrence pattern. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Required.
          - `[SeriesId <String>]`: The recurrence series this task belongs to. A GUID-based value that serves as the unique identifier for a series.
        - `[ReferenceCount <Int32?>]`: Number of external references that exist on the task.
        - `[SpecifiedCompletionRequirements <String>]`: plannerTaskCompletionRequirements
        - `[StartDateTime <DateTime?>]`: Date and time at which the task starts. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        - `[Title <String>]`: Title of the task.
    - `[Container <IMicrosoftGraphPlannerPlanContainer>]`: plannerPlanContainer
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ContainerId <String>]`: The identifier of the resource that contains the plan. Optional.
      - `[Type <String>]`: plannerContainerType
      - `[Url <String>]`: The full canonical URL of the container. Optional.
    - `[Contexts <IMicrosoftGraphPlannerPlanContextCollection>]`: plannerPlanContextCollection
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: Read-only. Date and time at which the plan is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[CreationSource <IMicrosoftGraphPlannerPlanCreation>]`: plannerPlanCreation
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CreationSourceKind <String>]`: plannerCreationSourceKind
    - `[Details <IMicrosoftGraphPlannerPlanDetails>]`: plannerPlanDetails
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[CategoryDescriptions <IMicrosoftGraphPlannerCategoryDescriptions>]`: plannerCategoryDescriptions
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Category1 <String>]`: The label associated with Category 1
        - `[Category10 <String>]`: The label associated with Category 10
        - `[Category11 <String>]`: The label associated with Category 11
        - `[Category12 <String>]`: The label associated with Category 12
        - `[Category13 <String>]`: The label associated with Category 13
        - `[Category14 <String>]`: The label associated with Category 14
        - `[Category15 <String>]`: The label associated with Category 15
        - `[Category16 <String>]`: The label associated with Category 16
        - `[Category17 <String>]`: The label associated with Category 17
        - `[Category18 <String>]`: The label associated with Category 18
        - `[Category19 <String>]`: The label associated with Category 19
        - `[Category2 <String>]`: The label associated with Category 2
        - `[Category20 <String>]`: The label associated with Category 20
        - `[Category21 <String>]`: The label associated with Category 21
        - `[Category22 <String>]`: The label associated with Category 22
        - `[Category23 <String>]`: The label associated with Category 23
        - `[Category24 <String>]`: The label associated with Category 24
        - `[Category25 <String>]`: The label associated with Category 25
        - `[Category3 <String>]`: The label associated with Category 3
        - `[Category4 <String>]`: The label associated with Category 4
        - `[Category5 <String>]`: The label associated with Category 5
        - `[Category6 <String>]`: The label associated with Category 6
        - `[Category7 <String>]`: The label associated with Category 7
        - `[Category8 <String>]`: The label associated with Category 8
        - `[Category9 <String>]`: The label associated with Category 9
      - `[ContextDetails <IMicrosoftGraphPlannerPlanContextDetailsCollection>]`: plannerPlanContextDetailsCollection
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[SharedWith <IMicrosoftGraphPlannerUserIds>]`: plannerUserIds
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Owner <String>]`: 
    - `[SharedWithContainers <IMicrosoftGraphPlannerSharedWithContainer[]>]`: List of containers the plan is shared with.
      - `[ContainerId <String>]`: The identifier of the resource that contains the plan. Optional.
      - `[Type <String>]`: plannerContainerType
      - `[Url <String>]`: The full canonical URL of the container. Optional.
      - `[AccessLevel <String>]`: plannerPlanAccessLevel
    - `[Tasks <IMicrosoftGraphPlannerTask[]>]`: Collection of tasks in the plan. Read-only. Nullable.
    - `[Title <String>]`: Required. Title of the plan.
  - `[Plans <IMicrosoftGraphPlannerPlan[]>]`: 
  - `[RecentPlanReferences <IMicrosoftGraphPlannerRecentPlanReferenceCollection>]`: plannerRecentPlanReferenceCollection
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[RecentPlans <IMicrosoftGraphPlannerPlan[]>]`: Read-only. Nullable. Returns the plannerPlans that have been recently viewed by the user in apps that support recent plans.
  - `[RosterPlans <IMicrosoftGraphPlannerPlan[]>]`: Read-only. Nullable. Returns the plannerPlans contained by the plannerRosters the user is a member.
  - `[Tasks <IMicrosoftGraphPlannerTask[]>]`: Read-only. Nullable. Returns the plannerTasks assigned to the user.

`FAVORITEPLANS <IMicrosoftGraphPlannerPlan[]>`: Read-only. Nullable. Returns the plannerPlans that the user marked as favorites.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Buckets <IMicrosoftGraphPlannerBucket[]>]`: Collection of buckets in the plan. Read-only. Nullable.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CreationSource <IMicrosoftGraphPlannerBucketCreation>]`: plannerBucketCreation
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CreationSourceKind <String>]`: plannerCreationSourceKind
    - `[Name <String>]`: Name of the bucket.
    - `[OrderHint <String>]`: Hint used to order items of this type in a list view. For details about the supported format, see Using order hints in Planner.
    - `[PlanId <String>]`: Plan ID to which the bucket belongs.
    - `[Tasks <IMicrosoftGraphPlannerTask[]>]`: Read-only. Nullable. The collection of tasks in the bucket.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[ActiveChecklistItemCount <Int32?>]`: Number of checklist items with value set to false, representing incomplete items.
      - `[AppliedCategories <IMicrosoftGraphPlannerAppliedCategories>]`: plannerAppliedCategories
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AssignedToTaskBoardFormat <IMicrosoftGraphPlannerAssignedToTaskBoardTaskFormat>]`: plannerAssignedToTaskBoardTaskFormat
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[OrderHintsByAssignee <IMicrosoftGraphPlannerOrderHintsByAssignee>]`: plannerOrderHintsByAssignee
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[UnassignedOrderHint <String>]`: Hint value used to order the task on the AssignedTo view of the Task Board when the task isn't assigned to anyone, or if the orderHintsByAssignee dictionary doesn't provide an order hint for the user the task is assigned to. The format is defined as outlined here.
      - `[AssigneePriority <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
      - `[Assignments <IMicrosoftGraphPlannerAssignments>]`: plannerAssignments
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[BucketId <String>]`: Bucket ID to which the task belongs. The bucket needs to be in the plan that the task is in. It is 28 characters long and case-sensitive. Format validation is done on the service.
      - `[BucketTaskBoardFormat <IMicrosoftGraphPlannerBucketTaskBoardTaskFormat>]`: plannerBucketTaskBoardTaskFormat
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
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
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[Checklist <IMicrosoftGraphPlannerChecklistItems>]`: plannerChecklistItems
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[CompletionRequirements <IMicrosoftGraphPlannerTaskCompletionRequirementDetails>]`: plannerTaskCompletionRequirementDetails
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[ChecklistRequirement <IMicrosoftGraphPlannerChecklistRequirement>]`: plannerChecklistRequirement
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[RequiredChecklistItemIds <String[]>]`: A collection of required plannerChecklistItems identifiers to complete the plannerTask.
        - `[Description <String>]`: Description of the task.
        - `[Notes <IMicrosoftGraphItemBody>]`: itemBody
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Content <String>]`: The content of the item.
          - `[ContentType <String>]`: bodyType
        - `[PreviewType <String>]`: plannerPreviewType
        - `[References <IMicrosoftGraphPlannerExternalReferences>]`: plannerExternalReferences
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DueDateTime <DateTime?>]`: Date and time at which the task is due. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[HasDescription <Boolean?>]`: Read-only. Value is true if the details object of the task has a nonempty description and false otherwise.
      - `[OrderHint <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
      - `[PercentComplete <Int32?>]`: Percentage of task completion. When set to 100, the task is considered completed.
      - `[PlanId <String>]`: Plan ID to which the task belongs.
      - `[PreviewType <String>]`: plannerPreviewType
      - `[Priority <Int32?>]`: Priority of the task. Valid range of values is between 0 and 10 (inclusive), with increasing value being lower priority (0 has the highest priority and 10 has the lowest priority).  Currently, Planner interprets values 0 and 1 as 'urgent', 2 and 3 and 4 as 'important', 5, 6, and 7 as 'medium', and 8, 9, and 10 as 'low'.  Currently, Planner sets the value 1 for 'urgent', 3 for 'important', 5 for 'medium', and 9 for 'low'.
      - `[ProgressTaskBoardFormat <IMicrosoftGraphPlannerProgressTaskBoardTaskFormat>]`: plannerProgressTaskBoardTaskFormat
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[OrderHint <String>]`: Hint value used to order the task on the progress view of the task board. For details about the supported format, see Using order hints in Planner.
      - `[Recurrence <IMicrosoftGraphPlannerTaskRecurrence>]`: plannerTaskRecurrence
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[NextInSeriesTaskId <String>]`: The taskId of the next task in this series. This value is assigned at the time the next task in the series is created, and is null prior to that time.
        - `[OccurrenceId <Int32?>]`: The 1-based index of this task within the recurrence series. The first task in a series has the value 1, the next task in the series has the value 2, and so on.
        - `[PreviousInSeriesTaskId <String>]`: The taskId of the previous task in this series. null for the first task in a series since it has no predecessor. All subsequent tasks in the series have a value that corresponds to their predecessors.
        - `[RecurrenceStartDateTime <DateTime?>]`: The date and time when this recurrence series begin. For the first task in a series (occurrenceId = 1) this value is copied from schedule.patternStartDateTime. For subsequent tasks in the series (occurrenceId >= 2) this value is copied from the previous task and never changes; it preserves the start date of the recurring series. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Schedule <IMicrosoftGraphPlannerRecurrenceSchedule>]`: plannerRecurrenceSchedule
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[NextOccurrenceDateTime <DateTime?>]`: The next date for this schedule. When a new task is instantiated to continue the recurrence series, this date is used for the dueDateTime of the new plannerTask. Auto-generated by the service. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
          - `[Pattern <IMicrosoftGraphRecurrencePattern>]`: recurrencePattern
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[DayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
            - `[DaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
            - `[FirstDayOfWeek <String>]`: dayOfWeek
            - `[Index <String>]`: weekIndex
            - `[Interval <Int32?>]`: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.
            - `[Month <Int32?>]`: The month in which the event occurs.  This is a number from 1 to 12.
            - `[Type <String>]`: recurrencePatternType
          - `[PatternStartDateTime <DateTime?>]`: The start date for the recurrence pattern. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Required.
        - `[SeriesId <String>]`: The recurrence series this task belongs to. A GUID-based value that serves as the unique identifier for a series.
      - `[ReferenceCount <Int32?>]`: Number of external references that exist on the task.
      - `[SpecifiedCompletionRequirements <String>]`: plannerTaskCompletionRequirements
      - `[StartDateTime <DateTime?>]`: Date and time at which the task starts. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[Title <String>]`: Title of the task.
  - `[Container <IMicrosoftGraphPlannerPlanContainer>]`: plannerPlanContainer
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ContainerId <String>]`: The identifier of the resource that contains the plan. Optional.
    - `[Type <String>]`: plannerContainerType
    - `[Url <String>]`: The full canonical URL of the container. Optional.
  - `[Contexts <IMicrosoftGraphPlannerPlanContextCollection>]`: plannerPlanContextCollection
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[CreatedDateTime <DateTime?>]`: Read-only. Date and time at which the plan is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[CreationSource <IMicrosoftGraphPlannerPlanCreation>]`: plannerPlanCreation
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CreationSourceKind <String>]`: plannerCreationSourceKind
  - `[Details <IMicrosoftGraphPlannerPlanDetails>]`: plannerPlanDetails
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CategoryDescriptions <IMicrosoftGraphPlannerCategoryDescriptions>]`: plannerCategoryDescriptions
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Category1 <String>]`: The label associated with Category 1
      - `[Category10 <String>]`: The label associated with Category 10
      - `[Category11 <String>]`: The label associated with Category 11
      - `[Category12 <String>]`: The label associated with Category 12
      - `[Category13 <String>]`: The label associated with Category 13
      - `[Category14 <String>]`: The label associated with Category 14
      - `[Category15 <String>]`: The label associated with Category 15
      - `[Category16 <String>]`: The label associated with Category 16
      - `[Category17 <String>]`: The label associated with Category 17
      - `[Category18 <String>]`: The label associated with Category 18
      - `[Category19 <String>]`: The label associated with Category 19
      - `[Category2 <String>]`: The label associated with Category 2
      - `[Category20 <String>]`: The label associated with Category 20
      - `[Category21 <String>]`: The label associated with Category 21
      - `[Category22 <String>]`: The label associated with Category 22
      - `[Category23 <String>]`: The label associated with Category 23
      - `[Category24 <String>]`: The label associated with Category 24
      - `[Category25 <String>]`: The label associated with Category 25
      - `[Category3 <String>]`: The label associated with Category 3
      - `[Category4 <String>]`: The label associated with Category 4
      - `[Category5 <String>]`: The label associated with Category 5
      - `[Category6 <String>]`: The label associated with Category 6
      - `[Category7 <String>]`: The label associated with Category 7
      - `[Category8 <String>]`: The label associated with Category 8
      - `[Category9 <String>]`: The label associated with Category 9
    - `[ContextDetails <IMicrosoftGraphPlannerPlanContextDetailsCollection>]`: plannerPlanContextDetailsCollection
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[SharedWith <IMicrosoftGraphPlannerUserIds>]`: plannerUserIds
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Owner <String>]`: 
  - `[SharedWithContainers <IMicrosoftGraphPlannerSharedWithContainer[]>]`: List of containers the plan is shared with.
    - `[ContainerId <String>]`: The identifier of the resource that contains the plan. Optional.
    - `[Type <String>]`: plannerContainerType
    - `[Url <String>]`: The full canonical URL of the container. Optional.
    - `[AccessLevel <String>]`: plannerPlanAccessLevel
  - `[Tasks <IMicrosoftGraphPlannerTask[]>]`: Collection of tasks in the plan. Read-only. Nullable.
  - `[Title <String>]`: Required. Title of the plan.

`INPUTOBJECT <IPlannerIdentity>`: Identity Parameter
  - `[GroupId <String>]`: The unique identifier of group
  - `[PlannerBucketId <String>]`: The unique identifier of plannerBucket
  - `[PlannerDeltaId <String>]`: The unique identifier of plannerDelta
  - `[PlannerPlanId <String>]`: The unique identifier of plannerPlan
  - `[PlannerRosterId <String>]`: The unique identifier of plannerRoster
  - `[PlannerRosterMemberId <String>]`: The unique identifier of plannerRosterMember
  - `[PlannerTaskId <String>]`: The unique identifier of plannerTask
  - `[UserId <String>]`: The unique identifier of user

`PLANS <IMicrosoftGraphPlannerPlan[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Buckets <IMicrosoftGraphPlannerBucket[]>]`: Collection of buckets in the plan. Read-only. Nullable.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CreationSource <IMicrosoftGraphPlannerBucketCreation>]`: plannerBucketCreation
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CreationSourceKind <String>]`: plannerCreationSourceKind
    - `[Name <String>]`: Name of the bucket.
    - `[OrderHint <String>]`: Hint used to order items of this type in a list view. For details about the supported format, see Using order hints in Planner.
    - `[PlanId <String>]`: Plan ID to which the bucket belongs.
    - `[Tasks <IMicrosoftGraphPlannerTask[]>]`: Read-only. Nullable. The collection of tasks in the bucket.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[ActiveChecklistItemCount <Int32?>]`: Number of checklist items with value set to false, representing incomplete items.
      - `[AppliedCategories <IMicrosoftGraphPlannerAppliedCategories>]`: plannerAppliedCategories
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AssignedToTaskBoardFormat <IMicrosoftGraphPlannerAssignedToTaskBoardTaskFormat>]`: plannerAssignedToTaskBoardTaskFormat
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[OrderHintsByAssignee <IMicrosoftGraphPlannerOrderHintsByAssignee>]`: plannerOrderHintsByAssignee
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[UnassignedOrderHint <String>]`: Hint value used to order the task on the AssignedTo view of the Task Board when the task isn't assigned to anyone, or if the orderHintsByAssignee dictionary doesn't provide an order hint for the user the task is assigned to. The format is defined as outlined here.
      - `[AssigneePriority <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
      - `[Assignments <IMicrosoftGraphPlannerAssignments>]`: plannerAssignments
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[BucketId <String>]`: Bucket ID to which the task belongs. The bucket needs to be in the plan that the task is in. It is 28 characters long and case-sensitive. Format validation is done on the service.
      - `[BucketTaskBoardFormat <IMicrosoftGraphPlannerBucketTaskBoardTaskFormat>]`: plannerBucketTaskBoardTaskFormat
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
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
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[Checklist <IMicrosoftGraphPlannerChecklistItems>]`: plannerChecklistItems
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[CompletionRequirements <IMicrosoftGraphPlannerTaskCompletionRequirementDetails>]`: plannerTaskCompletionRequirementDetails
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[ChecklistRequirement <IMicrosoftGraphPlannerChecklistRequirement>]`: plannerChecklistRequirement
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[RequiredChecklistItemIds <String[]>]`: A collection of required plannerChecklistItems identifiers to complete the plannerTask.
        - `[Description <String>]`: Description of the task.
        - `[Notes <IMicrosoftGraphItemBody>]`: itemBody
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Content <String>]`: The content of the item.
          - `[ContentType <String>]`: bodyType
        - `[PreviewType <String>]`: plannerPreviewType
        - `[References <IMicrosoftGraphPlannerExternalReferences>]`: plannerExternalReferences
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DueDateTime <DateTime?>]`: Date and time at which the task is due. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[HasDescription <Boolean?>]`: Read-only. Value is true if the details object of the task has a nonempty description and false otherwise.
      - `[OrderHint <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
      - `[PercentComplete <Int32?>]`: Percentage of task completion. When set to 100, the task is considered completed.
      - `[PlanId <String>]`: Plan ID to which the task belongs.
      - `[PreviewType <String>]`: plannerPreviewType
      - `[Priority <Int32?>]`: Priority of the task. Valid range of values is between 0 and 10 (inclusive), with increasing value being lower priority (0 has the highest priority and 10 has the lowest priority).  Currently, Planner interprets values 0 and 1 as 'urgent', 2 and 3 and 4 as 'important', 5, 6, and 7 as 'medium', and 8, 9, and 10 as 'low'.  Currently, Planner sets the value 1 for 'urgent', 3 for 'important', 5 for 'medium', and 9 for 'low'.
      - `[ProgressTaskBoardFormat <IMicrosoftGraphPlannerProgressTaskBoardTaskFormat>]`: plannerProgressTaskBoardTaskFormat
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[OrderHint <String>]`: Hint value used to order the task on the progress view of the task board. For details about the supported format, see Using order hints in Planner.
      - `[Recurrence <IMicrosoftGraphPlannerTaskRecurrence>]`: plannerTaskRecurrence
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[NextInSeriesTaskId <String>]`: The taskId of the next task in this series. This value is assigned at the time the next task in the series is created, and is null prior to that time.
        - `[OccurrenceId <Int32?>]`: The 1-based index of this task within the recurrence series. The first task in a series has the value 1, the next task in the series has the value 2, and so on.
        - `[PreviousInSeriesTaskId <String>]`: The taskId of the previous task in this series. null for the first task in a series since it has no predecessor. All subsequent tasks in the series have a value that corresponds to their predecessors.
        - `[RecurrenceStartDateTime <DateTime?>]`: The date and time when this recurrence series begin. For the first task in a series (occurrenceId = 1) this value is copied from schedule.patternStartDateTime. For subsequent tasks in the series (occurrenceId >= 2) this value is copied from the previous task and never changes; it preserves the start date of the recurring series. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Schedule <IMicrosoftGraphPlannerRecurrenceSchedule>]`: plannerRecurrenceSchedule
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[NextOccurrenceDateTime <DateTime?>]`: The next date for this schedule. When a new task is instantiated to continue the recurrence series, this date is used for the dueDateTime of the new plannerTask. Auto-generated by the service. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
          - `[Pattern <IMicrosoftGraphRecurrencePattern>]`: recurrencePattern
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[DayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
            - `[DaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
            - `[FirstDayOfWeek <String>]`: dayOfWeek
            - `[Index <String>]`: weekIndex
            - `[Interval <Int32?>]`: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.
            - `[Month <Int32?>]`: The month in which the event occurs.  This is a number from 1 to 12.
            - `[Type <String>]`: recurrencePatternType
          - `[PatternStartDateTime <DateTime?>]`: The start date for the recurrence pattern. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Required.
        - `[SeriesId <String>]`: The recurrence series this task belongs to. A GUID-based value that serves as the unique identifier for a series.
      - `[ReferenceCount <Int32?>]`: Number of external references that exist on the task.
      - `[SpecifiedCompletionRequirements <String>]`: plannerTaskCompletionRequirements
      - `[StartDateTime <DateTime?>]`: Date and time at which the task starts. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[Title <String>]`: Title of the task.
  - `[Container <IMicrosoftGraphPlannerPlanContainer>]`: plannerPlanContainer
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ContainerId <String>]`: The identifier of the resource that contains the plan. Optional.
    - `[Type <String>]`: plannerContainerType
    - `[Url <String>]`: The full canonical URL of the container. Optional.
  - `[Contexts <IMicrosoftGraphPlannerPlanContextCollection>]`: plannerPlanContextCollection
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[CreatedDateTime <DateTime?>]`: Read-only. Date and time at which the plan is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[CreationSource <IMicrosoftGraphPlannerPlanCreation>]`: plannerPlanCreation
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CreationSourceKind <String>]`: plannerCreationSourceKind
  - `[Details <IMicrosoftGraphPlannerPlanDetails>]`: plannerPlanDetails
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CategoryDescriptions <IMicrosoftGraphPlannerCategoryDescriptions>]`: plannerCategoryDescriptions
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Category1 <String>]`: The label associated with Category 1
      - `[Category10 <String>]`: The label associated with Category 10
      - `[Category11 <String>]`: The label associated with Category 11
      - `[Category12 <String>]`: The label associated with Category 12
      - `[Category13 <String>]`: The label associated with Category 13
      - `[Category14 <String>]`: The label associated with Category 14
      - `[Category15 <String>]`: The label associated with Category 15
      - `[Category16 <String>]`: The label associated with Category 16
      - `[Category17 <String>]`: The label associated with Category 17
      - `[Category18 <String>]`: The label associated with Category 18
      - `[Category19 <String>]`: The label associated with Category 19
      - `[Category2 <String>]`: The label associated with Category 2
      - `[Category20 <String>]`: The label associated with Category 20
      - `[Category21 <String>]`: The label associated with Category 21
      - `[Category22 <String>]`: The label associated with Category 22
      - `[Category23 <String>]`: The label associated with Category 23
      - `[Category24 <String>]`: The label associated with Category 24
      - `[Category25 <String>]`: The label associated with Category 25
      - `[Category3 <String>]`: The label associated with Category 3
      - `[Category4 <String>]`: The label associated with Category 4
      - `[Category5 <String>]`: The label associated with Category 5
      - `[Category6 <String>]`: The label associated with Category 6
      - `[Category7 <String>]`: The label associated with Category 7
      - `[Category8 <String>]`: The label associated with Category 8
      - `[Category9 <String>]`: The label associated with Category 9
    - `[ContextDetails <IMicrosoftGraphPlannerPlanContextDetailsCollection>]`: plannerPlanContextDetailsCollection
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[SharedWith <IMicrosoftGraphPlannerUserIds>]`: plannerUserIds
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Owner <String>]`: 
  - `[SharedWithContainers <IMicrosoftGraphPlannerSharedWithContainer[]>]`: List of containers the plan is shared with.
    - `[ContainerId <String>]`: The identifier of the resource that contains the plan. Optional.
    - `[Type <String>]`: plannerContainerType
    - `[Url <String>]`: The full canonical URL of the container. Optional.
    - `[AccessLevel <String>]`: plannerPlanAccessLevel
  - `[Tasks <IMicrosoftGraphPlannerTask[]>]`: Collection of tasks in the plan. Read-only. Nullable.
  - `[Title <String>]`: Required. Title of the plan.

`RECENTPLANS <IMicrosoftGraphPlannerPlan[]>`: Read-only. Nullable. Returns the plannerPlans that have been recently viewed by the user in apps that support recent plans.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Buckets <IMicrosoftGraphPlannerBucket[]>]`: Collection of buckets in the plan. Read-only. Nullable.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CreationSource <IMicrosoftGraphPlannerBucketCreation>]`: plannerBucketCreation
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CreationSourceKind <String>]`: plannerCreationSourceKind
    - `[Name <String>]`: Name of the bucket.
    - `[OrderHint <String>]`: Hint used to order items of this type in a list view. For details about the supported format, see Using order hints in Planner.
    - `[PlanId <String>]`: Plan ID to which the bucket belongs.
    - `[Tasks <IMicrosoftGraphPlannerTask[]>]`: Read-only. Nullable. The collection of tasks in the bucket.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[ActiveChecklistItemCount <Int32?>]`: Number of checklist items with value set to false, representing incomplete items.
      - `[AppliedCategories <IMicrosoftGraphPlannerAppliedCategories>]`: plannerAppliedCategories
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AssignedToTaskBoardFormat <IMicrosoftGraphPlannerAssignedToTaskBoardTaskFormat>]`: plannerAssignedToTaskBoardTaskFormat
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[OrderHintsByAssignee <IMicrosoftGraphPlannerOrderHintsByAssignee>]`: plannerOrderHintsByAssignee
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[UnassignedOrderHint <String>]`: Hint value used to order the task on the AssignedTo view of the Task Board when the task isn't assigned to anyone, or if the orderHintsByAssignee dictionary doesn't provide an order hint for the user the task is assigned to. The format is defined as outlined here.
      - `[AssigneePriority <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
      - `[Assignments <IMicrosoftGraphPlannerAssignments>]`: plannerAssignments
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[BucketId <String>]`: Bucket ID to which the task belongs. The bucket needs to be in the plan that the task is in. It is 28 characters long and case-sensitive. Format validation is done on the service.
      - `[BucketTaskBoardFormat <IMicrosoftGraphPlannerBucketTaskBoardTaskFormat>]`: plannerBucketTaskBoardTaskFormat
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
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
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[Checklist <IMicrosoftGraphPlannerChecklistItems>]`: plannerChecklistItems
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[CompletionRequirements <IMicrosoftGraphPlannerTaskCompletionRequirementDetails>]`: plannerTaskCompletionRequirementDetails
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[ChecklistRequirement <IMicrosoftGraphPlannerChecklistRequirement>]`: plannerChecklistRequirement
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[RequiredChecklistItemIds <String[]>]`: A collection of required plannerChecklistItems identifiers to complete the plannerTask.
        - `[Description <String>]`: Description of the task.
        - `[Notes <IMicrosoftGraphItemBody>]`: itemBody
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Content <String>]`: The content of the item.
          - `[ContentType <String>]`: bodyType
        - `[PreviewType <String>]`: plannerPreviewType
        - `[References <IMicrosoftGraphPlannerExternalReferences>]`: plannerExternalReferences
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DueDateTime <DateTime?>]`: Date and time at which the task is due. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[HasDescription <Boolean?>]`: Read-only. Value is true if the details object of the task has a nonempty description and false otherwise.
      - `[OrderHint <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
      - `[PercentComplete <Int32?>]`: Percentage of task completion. When set to 100, the task is considered completed.
      - `[PlanId <String>]`: Plan ID to which the task belongs.
      - `[PreviewType <String>]`: plannerPreviewType
      - `[Priority <Int32?>]`: Priority of the task. Valid range of values is between 0 and 10 (inclusive), with increasing value being lower priority (0 has the highest priority and 10 has the lowest priority).  Currently, Planner interprets values 0 and 1 as 'urgent', 2 and 3 and 4 as 'important', 5, 6, and 7 as 'medium', and 8, 9, and 10 as 'low'.  Currently, Planner sets the value 1 for 'urgent', 3 for 'important', 5 for 'medium', and 9 for 'low'.
      - `[ProgressTaskBoardFormat <IMicrosoftGraphPlannerProgressTaskBoardTaskFormat>]`: plannerProgressTaskBoardTaskFormat
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[OrderHint <String>]`: Hint value used to order the task on the progress view of the task board. For details about the supported format, see Using order hints in Planner.
      - `[Recurrence <IMicrosoftGraphPlannerTaskRecurrence>]`: plannerTaskRecurrence
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[NextInSeriesTaskId <String>]`: The taskId of the next task in this series. This value is assigned at the time the next task in the series is created, and is null prior to that time.
        - `[OccurrenceId <Int32?>]`: The 1-based index of this task within the recurrence series. The first task in a series has the value 1, the next task in the series has the value 2, and so on.
        - `[PreviousInSeriesTaskId <String>]`: The taskId of the previous task in this series. null for the first task in a series since it has no predecessor. All subsequent tasks in the series have a value that corresponds to their predecessors.
        - `[RecurrenceStartDateTime <DateTime?>]`: The date and time when this recurrence series begin. For the first task in a series (occurrenceId = 1) this value is copied from schedule.patternStartDateTime. For subsequent tasks in the series (occurrenceId >= 2) this value is copied from the previous task and never changes; it preserves the start date of the recurring series. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Schedule <IMicrosoftGraphPlannerRecurrenceSchedule>]`: plannerRecurrenceSchedule
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[NextOccurrenceDateTime <DateTime?>]`: The next date for this schedule. When a new task is instantiated to continue the recurrence series, this date is used for the dueDateTime of the new plannerTask. Auto-generated by the service. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
          - `[Pattern <IMicrosoftGraphRecurrencePattern>]`: recurrencePattern
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[DayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
            - `[DaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
            - `[FirstDayOfWeek <String>]`: dayOfWeek
            - `[Index <String>]`: weekIndex
            - `[Interval <Int32?>]`: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.
            - `[Month <Int32?>]`: The month in which the event occurs.  This is a number from 1 to 12.
            - `[Type <String>]`: recurrencePatternType
          - `[PatternStartDateTime <DateTime?>]`: The start date for the recurrence pattern. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Required.
        - `[SeriesId <String>]`: The recurrence series this task belongs to. A GUID-based value that serves as the unique identifier for a series.
      - `[ReferenceCount <Int32?>]`: Number of external references that exist on the task.
      - `[SpecifiedCompletionRequirements <String>]`: plannerTaskCompletionRequirements
      - `[StartDateTime <DateTime?>]`: Date and time at which the task starts. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[Title <String>]`: Title of the task.
  - `[Container <IMicrosoftGraphPlannerPlanContainer>]`: plannerPlanContainer
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ContainerId <String>]`: The identifier of the resource that contains the plan. Optional.
    - `[Type <String>]`: plannerContainerType
    - `[Url <String>]`: The full canonical URL of the container. Optional.
  - `[Contexts <IMicrosoftGraphPlannerPlanContextCollection>]`: plannerPlanContextCollection
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[CreatedDateTime <DateTime?>]`: Read-only. Date and time at which the plan is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[CreationSource <IMicrosoftGraphPlannerPlanCreation>]`: plannerPlanCreation
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CreationSourceKind <String>]`: plannerCreationSourceKind
  - `[Details <IMicrosoftGraphPlannerPlanDetails>]`: plannerPlanDetails
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CategoryDescriptions <IMicrosoftGraphPlannerCategoryDescriptions>]`: plannerCategoryDescriptions
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Category1 <String>]`: The label associated with Category 1
      - `[Category10 <String>]`: The label associated with Category 10
      - `[Category11 <String>]`: The label associated with Category 11
      - `[Category12 <String>]`: The label associated with Category 12
      - `[Category13 <String>]`: The label associated with Category 13
      - `[Category14 <String>]`: The label associated with Category 14
      - `[Category15 <String>]`: The label associated with Category 15
      - `[Category16 <String>]`: The label associated with Category 16
      - `[Category17 <String>]`: The label associated with Category 17
      - `[Category18 <String>]`: The label associated with Category 18
      - `[Category19 <String>]`: The label associated with Category 19
      - `[Category2 <String>]`: The label associated with Category 2
      - `[Category20 <String>]`: The label associated with Category 20
      - `[Category21 <String>]`: The label associated with Category 21
      - `[Category22 <String>]`: The label associated with Category 22
      - `[Category23 <String>]`: The label associated with Category 23
      - `[Category24 <String>]`: The label associated with Category 24
      - `[Category25 <String>]`: The label associated with Category 25
      - `[Category3 <String>]`: The label associated with Category 3
      - `[Category4 <String>]`: The label associated with Category 4
      - `[Category5 <String>]`: The label associated with Category 5
      - `[Category6 <String>]`: The label associated with Category 6
      - `[Category7 <String>]`: The label associated with Category 7
      - `[Category8 <String>]`: The label associated with Category 8
      - `[Category9 <String>]`: The label associated with Category 9
    - `[ContextDetails <IMicrosoftGraphPlannerPlanContextDetailsCollection>]`: plannerPlanContextDetailsCollection
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[SharedWith <IMicrosoftGraphPlannerUserIds>]`: plannerUserIds
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Owner <String>]`: 
  - `[SharedWithContainers <IMicrosoftGraphPlannerSharedWithContainer[]>]`: List of containers the plan is shared with.
    - `[ContainerId <String>]`: The identifier of the resource that contains the plan. Optional.
    - `[Type <String>]`: plannerContainerType
    - `[Url <String>]`: The full canonical URL of the container. Optional.
    - `[AccessLevel <String>]`: plannerPlanAccessLevel
  - `[Tasks <IMicrosoftGraphPlannerTask[]>]`: Collection of tasks in the plan. Read-only. Nullable.
  - `[Title <String>]`: Required. Title of the plan.

`ROSTERPLANS <IMicrosoftGraphPlannerPlan[]>`: Read-only. Nullable. Returns the plannerPlans contained by the plannerRosters the user is a member.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Buckets <IMicrosoftGraphPlannerBucket[]>]`: Collection of buckets in the plan. Read-only. Nullable.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CreationSource <IMicrosoftGraphPlannerBucketCreation>]`: plannerBucketCreation
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CreationSourceKind <String>]`: plannerCreationSourceKind
    - `[Name <String>]`: Name of the bucket.
    - `[OrderHint <String>]`: Hint used to order items of this type in a list view. For details about the supported format, see Using order hints in Planner.
    - `[PlanId <String>]`: Plan ID to which the bucket belongs.
    - `[Tasks <IMicrosoftGraphPlannerTask[]>]`: Read-only. Nullable. The collection of tasks in the bucket.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[ActiveChecklistItemCount <Int32?>]`: Number of checklist items with value set to false, representing incomplete items.
      - `[AppliedCategories <IMicrosoftGraphPlannerAppliedCategories>]`: plannerAppliedCategories
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AssignedToTaskBoardFormat <IMicrosoftGraphPlannerAssignedToTaskBoardTaskFormat>]`: plannerAssignedToTaskBoardTaskFormat
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[OrderHintsByAssignee <IMicrosoftGraphPlannerOrderHintsByAssignee>]`: plannerOrderHintsByAssignee
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[UnassignedOrderHint <String>]`: Hint value used to order the task on the AssignedTo view of the Task Board when the task isn't assigned to anyone, or if the orderHintsByAssignee dictionary doesn't provide an order hint for the user the task is assigned to. The format is defined as outlined here.
      - `[AssigneePriority <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
      - `[Assignments <IMicrosoftGraphPlannerAssignments>]`: plannerAssignments
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[BucketId <String>]`: Bucket ID to which the task belongs. The bucket needs to be in the plan that the task is in. It is 28 characters long and case-sensitive. Format validation is done on the service.
      - `[BucketTaskBoardFormat <IMicrosoftGraphPlannerBucketTaskBoardTaskFormat>]`: plannerBucketTaskBoardTaskFormat
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
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
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[Checklist <IMicrosoftGraphPlannerChecklistItems>]`: plannerChecklistItems
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[CompletionRequirements <IMicrosoftGraphPlannerTaskCompletionRequirementDetails>]`: plannerTaskCompletionRequirementDetails
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[ChecklistRequirement <IMicrosoftGraphPlannerChecklistRequirement>]`: plannerChecklistRequirement
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[RequiredChecklistItemIds <String[]>]`: A collection of required plannerChecklistItems identifiers to complete the plannerTask.
        - `[Description <String>]`: Description of the task.
        - `[Notes <IMicrosoftGraphItemBody>]`: itemBody
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Content <String>]`: The content of the item.
          - `[ContentType <String>]`: bodyType
        - `[PreviewType <String>]`: plannerPreviewType
        - `[References <IMicrosoftGraphPlannerExternalReferences>]`: plannerExternalReferences
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DueDateTime <DateTime?>]`: Date and time at which the task is due. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[HasDescription <Boolean?>]`: Read-only. Value is true if the details object of the task has a nonempty description and false otherwise.
      - `[OrderHint <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
      - `[PercentComplete <Int32?>]`: Percentage of task completion. When set to 100, the task is considered completed.
      - `[PlanId <String>]`: Plan ID to which the task belongs.
      - `[PreviewType <String>]`: plannerPreviewType
      - `[Priority <Int32?>]`: Priority of the task. Valid range of values is between 0 and 10 (inclusive), with increasing value being lower priority (0 has the highest priority and 10 has the lowest priority).  Currently, Planner interprets values 0 and 1 as 'urgent', 2 and 3 and 4 as 'important', 5, 6, and 7 as 'medium', and 8, 9, and 10 as 'low'.  Currently, Planner sets the value 1 for 'urgent', 3 for 'important', 5 for 'medium', and 9 for 'low'.
      - `[ProgressTaskBoardFormat <IMicrosoftGraphPlannerProgressTaskBoardTaskFormat>]`: plannerProgressTaskBoardTaskFormat
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[OrderHint <String>]`: Hint value used to order the task on the progress view of the task board. For details about the supported format, see Using order hints in Planner.
      - `[Recurrence <IMicrosoftGraphPlannerTaskRecurrence>]`: plannerTaskRecurrence
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[NextInSeriesTaskId <String>]`: The taskId of the next task in this series. This value is assigned at the time the next task in the series is created, and is null prior to that time.
        - `[OccurrenceId <Int32?>]`: The 1-based index of this task within the recurrence series. The first task in a series has the value 1, the next task in the series has the value 2, and so on.
        - `[PreviousInSeriesTaskId <String>]`: The taskId of the previous task in this series. null for the first task in a series since it has no predecessor. All subsequent tasks in the series have a value that corresponds to their predecessors.
        - `[RecurrenceStartDateTime <DateTime?>]`: The date and time when this recurrence series begin. For the first task in a series (occurrenceId = 1) this value is copied from schedule.patternStartDateTime. For subsequent tasks in the series (occurrenceId >= 2) this value is copied from the previous task and never changes; it preserves the start date of the recurring series. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Schedule <IMicrosoftGraphPlannerRecurrenceSchedule>]`: plannerRecurrenceSchedule
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[NextOccurrenceDateTime <DateTime?>]`: The next date for this schedule. When a new task is instantiated to continue the recurrence series, this date is used for the dueDateTime of the new plannerTask. Auto-generated by the service. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
          - `[Pattern <IMicrosoftGraphRecurrencePattern>]`: recurrencePattern
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[DayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
            - `[DaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
            - `[FirstDayOfWeek <String>]`: dayOfWeek
            - `[Index <String>]`: weekIndex
            - `[Interval <Int32?>]`: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.
            - `[Month <Int32?>]`: The month in which the event occurs.  This is a number from 1 to 12.
            - `[Type <String>]`: recurrencePatternType
          - `[PatternStartDateTime <DateTime?>]`: The start date for the recurrence pattern. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Required.
        - `[SeriesId <String>]`: The recurrence series this task belongs to. A GUID-based value that serves as the unique identifier for a series.
      - `[ReferenceCount <Int32?>]`: Number of external references that exist on the task.
      - `[SpecifiedCompletionRequirements <String>]`: plannerTaskCompletionRequirements
      - `[StartDateTime <DateTime?>]`: Date and time at which the task starts. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[Title <String>]`: Title of the task.
  - `[Container <IMicrosoftGraphPlannerPlanContainer>]`: plannerPlanContainer
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ContainerId <String>]`: The identifier of the resource that contains the plan. Optional.
    - `[Type <String>]`: plannerContainerType
    - `[Url <String>]`: The full canonical URL of the container. Optional.
  - `[Contexts <IMicrosoftGraphPlannerPlanContextCollection>]`: plannerPlanContextCollection
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[CreatedDateTime <DateTime?>]`: Read-only. Date and time at which the plan is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[CreationSource <IMicrosoftGraphPlannerPlanCreation>]`: plannerPlanCreation
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CreationSourceKind <String>]`: plannerCreationSourceKind
  - `[Details <IMicrosoftGraphPlannerPlanDetails>]`: plannerPlanDetails
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CategoryDescriptions <IMicrosoftGraphPlannerCategoryDescriptions>]`: plannerCategoryDescriptions
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Category1 <String>]`: The label associated with Category 1
      - `[Category10 <String>]`: The label associated with Category 10
      - `[Category11 <String>]`: The label associated with Category 11
      - `[Category12 <String>]`: The label associated with Category 12
      - `[Category13 <String>]`: The label associated with Category 13
      - `[Category14 <String>]`: The label associated with Category 14
      - `[Category15 <String>]`: The label associated with Category 15
      - `[Category16 <String>]`: The label associated with Category 16
      - `[Category17 <String>]`: The label associated with Category 17
      - `[Category18 <String>]`: The label associated with Category 18
      - `[Category19 <String>]`: The label associated with Category 19
      - `[Category2 <String>]`: The label associated with Category 2
      - `[Category20 <String>]`: The label associated with Category 20
      - `[Category21 <String>]`: The label associated with Category 21
      - `[Category22 <String>]`: The label associated with Category 22
      - `[Category23 <String>]`: The label associated with Category 23
      - `[Category24 <String>]`: The label associated with Category 24
      - `[Category25 <String>]`: The label associated with Category 25
      - `[Category3 <String>]`: The label associated with Category 3
      - `[Category4 <String>]`: The label associated with Category 4
      - `[Category5 <String>]`: The label associated with Category 5
      - `[Category6 <String>]`: The label associated with Category 6
      - `[Category7 <String>]`: The label associated with Category 7
      - `[Category8 <String>]`: The label associated with Category 8
      - `[Category9 <String>]`: The label associated with Category 9
    - `[ContextDetails <IMicrosoftGraphPlannerPlanContextDetailsCollection>]`: plannerPlanContextDetailsCollection
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[SharedWith <IMicrosoftGraphPlannerUserIds>]`: plannerUserIds
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Owner <String>]`: 
  - `[SharedWithContainers <IMicrosoftGraphPlannerSharedWithContainer[]>]`: List of containers the plan is shared with.
    - `[ContainerId <String>]`: The identifier of the resource that contains the plan. Optional.
    - `[Type <String>]`: plannerContainerType
    - `[Url <String>]`: The full canonical URL of the container. Optional.
    - `[AccessLevel <String>]`: plannerPlanAccessLevel
  - `[Tasks <IMicrosoftGraphPlannerTask[]>]`: Collection of tasks in the plan. Read-only. Nullable.
  - `[Title <String>]`: Required. Title of the plan.

`TASKS <IMicrosoftGraphPlannerTask[]>`: Read-only. Nullable. Returns the plannerTasks assigned to the user.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ActiveChecklistItemCount <Int32?>]`: Number of checklist items with value set to false, representing incomplete items.
  - `[AppliedCategories <IMicrosoftGraphPlannerAppliedCategories>]`: plannerAppliedCategories
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AssignedToTaskBoardFormat <IMicrosoftGraphPlannerAssignedToTaskBoardTaskFormat>]`: plannerAssignedToTaskBoardTaskFormat
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[OrderHintsByAssignee <IMicrosoftGraphPlannerOrderHintsByAssignee>]`: plannerOrderHintsByAssignee
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[UnassignedOrderHint <String>]`: Hint value used to order the task on the AssignedTo view of the Task Board when the task isn't assigned to anyone, or if the orderHintsByAssignee dictionary doesn't provide an order hint for the user the task is assigned to. The format is defined as outlined here.
  - `[AssigneePriority <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
  - `[Assignments <IMicrosoftGraphPlannerAssignments>]`: plannerAssignments
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[BucketId <String>]`: Bucket ID to which the task belongs. The bucket needs to be in the plan that the task is in. It is 28 characters long and case-sensitive. Format validation is done on the service.
  - `[BucketTaskBoardFormat <IMicrosoftGraphPlannerBucketTaskBoardTaskFormat>]`: plannerBucketTaskBoardTaskFormat
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
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
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Checklist <IMicrosoftGraphPlannerChecklistItems>]`: plannerChecklistItems
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CompletionRequirements <IMicrosoftGraphPlannerTaskCompletionRequirementDetails>]`: plannerTaskCompletionRequirementDetails
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ChecklistRequirement <IMicrosoftGraphPlannerChecklistRequirement>]`: plannerChecklistRequirement
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[RequiredChecklistItemIds <String[]>]`: A collection of required plannerChecklistItems identifiers to complete the plannerTask.
    - `[Description <String>]`: Description of the task.
    - `[Notes <IMicrosoftGraphItemBody>]`: itemBody
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Content <String>]`: The content of the item.
      - `[ContentType <String>]`: bodyType
    - `[PreviewType <String>]`: plannerPreviewType
    - `[References <IMicrosoftGraphPlannerExternalReferences>]`: plannerExternalReferences
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DueDateTime <DateTime?>]`: Date and time at which the task is due. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[HasDescription <Boolean?>]`: Read-only. Value is true if the details object of the task has a nonempty description and false otherwise.
  - `[OrderHint <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
  - `[PercentComplete <Int32?>]`: Percentage of task completion. When set to 100, the task is considered completed.
  - `[PlanId <String>]`: Plan ID to which the task belongs.
  - `[PreviewType <String>]`: plannerPreviewType
  - `[Priority <Int32?>]`: Priority of the task. Valid range of values is between 0 and 10 (inclusive), with increasing value being lower priority (0 has the highest priority and 10 has the lowest priority).  Currently, Planner interprets values 0 and 1 as 'urgent', 2 and 3 and 4 as 'important', 5, 6, and 7 as 'medium', and 8, 9, and 10 as 'low'.  Currently, Planner sets the value 1 for 'urgent', 3 for 'important', 5 for 'medium', and 9 for 'low'.
  - `[ProgressTaskBoardFormat <IMicrosoftGraphPlannerProgressTaskBoardTaskFormat>]`: plannerProgressTaskBoardTaskFormat
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[OrderHint <String>]`: Hint value used to order the task on the progress view of the task board. For details about the supported format, see Using order hints in Planner.
  - `[Recurrence <IMicrosoftGraphPlannerTaskRecurrence>]`: plannerTaskRecurrence
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[NextInSeriesTaskId <String>]`: The taskId of the next task in this series. This value is assigned at the time the next task in the series is created, and is null prior to that time.
    - `[OccurrenceId <Int32?>]`: The 1-based index of this task within the recurrence series. The first task in a series has the value 1, the next task in the series has the value 2, and so on.
    - `[PreviousInSeriesTaskId <String>]`: The taskId of the previous task in this series. null for the first task in a series since it has no predecessor. All subsequent tasks in the series have a value that corresponds to their predecessors.
    - `[RecurrenceStartDateTime <DateTime?>]`: The date and time when this recurrence series begin. For the first task in a series (occurrenceId = 1) this value is copied from schedule.patternStartDateTime. For subsequent tasks in the series (occurrenceId >= 2) this value is copied from the previous task and never changes; it preserves the start date of the recurring series. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Schedule <IMicrosoftGraphPlannerRecurrenceSchedule>]`: plannerRecurrenceSchedule
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[NextOccurrenceDateTime <DateTime?>]`: The next date for this schedule. When a new task is instantiated to continue the recurrence series, this date is used for the dueDateTime of the new plannerTask. Auto-generated by the service. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[Pattern <IMicrosoftGraphRecurrencePattern>]`: recurrencePattern
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DayOfMonth <Int32?>]`: The day of the month on which the event occurs. Required if type is absoluteMonthly or absoluteYearly.
        - `[DaysOfWeek <String[]>]`: A collection of the days of the week on which the event occurs. The possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday. If type is relativeMonthly or relativeYearly, and daysOfWeek specifies more than one day, the event falls on the first day that satisfies the pattern.  Required if type is weekly, relativeMonthly, or relativeYearly.
        - `[FirstDayOfWeek <String>]`: dayOfWeek
        - `[Index <String>]`: weekIndex
        - `[Interval <Int32?>]`: The number of units between occurrences, where units can be in days, weeks, months, or years, depending on the type. Required.
        - `[Month <Int32?>]`: The month in which the event occurs.  This is a number from 1 to 12.
        - `[Type <String>]`: recurrencePatternType
      - `[PatternStartDateTime <DateTime?>]`: The start date for the recurrence pattern. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Required.
    - `[SeriesId <String>]`: The recurrence series this task belongs to. A GUID-based value that serves as the unique identifier for a series.
  - `[ReferenceCount <Int32?>]`: Number of external references that exist on the task.
  - `[SpecifiedCompletionRequirements <String>]`: plannerTaskCompletionRequirements
  - `[StartDateTime <DateTime?>]`: Date and time at which the task starts. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Title <String>]`: Title of the task.

## RELATED LINKS

