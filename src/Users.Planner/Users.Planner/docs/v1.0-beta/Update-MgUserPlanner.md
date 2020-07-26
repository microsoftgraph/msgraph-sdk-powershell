---
external help file:
Module Name: Microsoft.Graph.Users.Planner
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.planner/update-mguserplanner
schema: 2.0.0
---

# Update-MgUserPlanner

## SYNOPSIS
Update the navigation property planner in users

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgUserPlanner -UserId <String> [-All <IMicrosoftGraphPlannerDelta[]>]
 [-FavoritePlanReferences <IMicrosoftGraphPlannerFavoritePlanReferenceCollection>]
 [-FavoritePlans <IMicrosoftGraphPlannerPlan[]>] [-Id <String>] [-Plans <IMicrosoftGraphPlannerPlan[]>]
 [-RecentPlanReferences <IMicrosoftGraphPlannerRecentPlanReferenceCollection>]
 [-RecentPlans <IMicrosoftGraphPlannerPlan[]>] [-Tasks <IMicrosoftGraphPlannerTask[]>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgUserPlanner -UserId <String> -BodyParameter <IMicrosoftGraphPlannerUser> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgUserPlanner -InputObject <IUsersPlannerIdentity> -BodyParameter <IMicrosoftGraphPlannerUser>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgUserPlanner -InputObject <IUsersPlannerIdentity> [-All <IMicrosoftGraphPlannerDelta[]>]
 [-FavoritePlanReferences <IMicrosoftGraphPlannerFavoritePlanReferenceCollection>]
 [-FavoritePlans <IMicrosoftGraphPlannerPlan[]>] [-Id <String>] [-Plans <IMicrosoftGraphPlannerPlan[]>]
 [-RecentPlanReferences <IMicrosoftGraphPlannerRecentPlanReferenceCollection>]
 [-RecentPlans <IMicrosoftGraphPlannerPlan[]>] [-Tasks <IMicrosoftGraphPlannerTask[]>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property planner in users

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -All
.
To construct, see NOTES section for ALL properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerDelta[]
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerUser
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerFavoritePlanReferenceCollection
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FavoritePlans
.
To construct, see NOTES section for FAVORITEPLANS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerPlan[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IUsersPlannerIdentity
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

### -Plans
Read-only.
Nullable.
Returns the plannerTasks assigned to the user.
To construct, see NOTES section for PLANS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerPlan[]
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerRecentPlanReferenceCollection
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RecentPlans
.
To construct, see NOTES section for RECENTPLANS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerPlan[]
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
Returns the plannerPlans shared with the user.
To construct, see NOTES section for TASKS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerTask[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
key: user-id of user

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerUser

### Microsoft.Graph.PowerShell.Models.IUsersPlannerIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ALL <IMicrosoftGraphPlannerDelta[]>: .
  - `[Id <String>]`: Read-only.

BODYPARAMETER <IMicrosoftGraphPlannerUser>: plannerUser
  - `[Id <String>]`: Read-only.
  - `[All <IMicrosoftGraphPlannerDelta[]>]`: 
    - `[Id <String>]`: Read-only.
  - `[FavoritePlanReferences <IMicrosoftGraphPlannerFavoritePlanReferenceCollection>]`: plannerFavoritePlanReferenceCollection
  - `[FavoritePlans <IMicrosoftGraphPlannerPlan[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Buckets <IMicrosoftGraphPlannerBucket[]>]`: Read-only. Nullable. Collection of buckets in the plan.
      - `[Id <String>]`: Read-only.
      - `[Name <String>]`: Name of the bucket.
      - `[OrderHint <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
      - `[PlanId <String>]`: Plan ID to which the bucket belongs.
      - `[Tasks <IMicrosoftGraphPlannerTask[]>]`: Read-only. Nullable. The collection of tasks in the bucket.
        - `[Id <String>]`: Read-only.
        - `[ActiveChecklistItemCount <Int32?>]`: Number of checklist items with value set to false, representing incomplete items.
        - `[AppliedCategories <IMicrosoftGraphPlannerAppliedCategories>]`: plannerAppliedCategories
        - `[AssignedToTaskBoardFormatId <String>]`: Read-only.
        - `[AssignedToTaskBoardFormatOrderHintsByAssignee <IMicrosoftGraphPlannerOrderHintsByAssignee>]`: plannerOrderHintsByAssignee
        - `[AssignedToTaskBoardFormatUnassignedOrderHint <String>]`: Hint value used to order the task on the AssignedTo view of the Task Board when the task is not assigned to anyone, or if the orderHintsByAssignee dictionary does not provide an order hint for the user the task is assigned to. The format is defined as outlined here.
        - `[AssigneePriority <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
        - `[Assignments <IMicrosoftGraphPlannerAssignments>]`: plannerAssignments
        - `[BucketId <String>]`: Bucket ID to which the task belongs. The bucket needs to be in the plan that the task is in. It is 28 characters long and case-sensitive. Format validation is done on the service.
        - `[BucketTaskBoardFormatId <String>]`: Read-only.
        - `[BucketTaskBoardFormatOrderHint <String>]`: Hint used to order tasks in the Bucket view of the Task Board. The format is defined as outlined here.
        - `[ChecklistItemCount <Int32?>]`: Number of checklist items that are present on the task.
        - `[CompletedBy <IMicrosoftGraphIdentitySet>]`: identitySet
          - `[Application <IMicrosoftGraphIdentity>]`: identity
            - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
            - `[Id <String>]`: Unique identifier for the identity.
          - `[Device <IMicrosoftGraphIdentity>]`: identity
          - `[User <IMicrosoftGraphIdentity>]`: identity
        - `[CompletedDateTime <DateTime?>]`: Read-only. Date and time at which the 'percentComplete' of the task is set to '100'. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        - `[ConversationThreadId <String>]`: Thread ID of the conversation on the task. This is the ID of the conversation thread object created in the group.
        - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[CreatedDateTime <DateTime?>]`: Read-only. Date and time at which the task is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        - `[DetailChecklist <IMicrosoftGraphPlannerChecklistItems>]`: plannerChecklistItems
        - `[DetailDescription <String>]`: Description of the task
        - `[DetailId <String>]`: Read-only.
        - `[DetailPreviewType <String>]`: plannerPreviewType
        - `[DetailReferences <IMicrosoftGraphPlannerExternalReferences>]`: plannerExternalReferences
        - `[DueDateTime <DateTime?>]`: Date and time at which the task is due. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        - `[HasDescription <Boolean?>]`: Read-only. Value is true if the details object of the task has a non-empty description and false otherwise.
        - `[OrderHint <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
        - `[PercentComplete <Int32?>]`: Percentage of task completion. When set to 100, the task is considered completed.
        - `[PlanId <String>]`: Plan ID to which the task belongs.
        - `[PreviewType <String>]`: plannerPreviewType
        - `[Priority <Int32?>]`: 
        - `[ProgressTaskBoardFormatId <String>]`: Read-only.
        - `[ProgressTaskBoardFormatOrderHint <String>]`: Hint value used to order the task on the Progress view of the Task Board. The format is defined as outlined here.
        - `[ReferenceCount <Int32?>]`: Number of external references that exist on the task.
        - `[StartDateTime <DateTime?>]`: Date and time at which the task starts. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        - `[Title <String>]`: Title of the task.
    - `[CategoryDescriptionCategory1 <String>]`: The label associated with Category 1
    - `[CategoryDescriptionCategory2 <String>]`: The label associated with Category 2
    - `[CategoryDescriptionCategory3 <String>]`: The label associated with Category 3
    - `[CategoryDescriptionCategory4 <String>]`: The label associated with Category 4
    - `[CategoryDescriptionCategory5 <String>]`: The label associated with Category 5
    - `[CategoryDescriptionCategory6 <String>]`: The label associated with Category 6
    - `[Contexts <IMicrosoftGraphPlannerPlanContextCollection>]`: plannerPlanContextCollection
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: Read-only. Date and time at which the plan is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[DetailContextDetails <IMicrosoftGraphPlannerPlanContextDetailsCollection>]`: plannerPlanContextDetailsCollection
    - `[DetailId <String>]`: Read-only.
    - `[DetailSharedWith <IMicrosoftGraphPlannerUserIds>]`: plannerUserIds
    - `[Owner <String>]`: ID of the Group that owns the plan. A valid group must exist before this field can be set. After it is set, this property can’t be updated.
    - `[Tasks <IMicrosoftGraphPlannerTask[]>]`: Read-only. Nullable. Collection of tasks in the plan.
    - `[Title <String>]`: Required. Title of the plan.
  - `[Plans <IMicrosoftGraphPlannerPlan[]>]`: Read-only. Nullable. Returns the plannerTasks assigned to the user.
  - `[RecentPlanReferences <IMicrosoftGraphPlannerRecentPlanReferenceCollection>]`: plannerRecentPlanReferenceCollection
  - `[RecentPlans <IMicrosoftGraphPlannerPlan[]>]`: 
  - `[Tasks <IMicrosoftGraphPlannerTask[]>]`: Read-only. Nullable. Returns the plannerPlans shared with the user.

FAVORITEPLANS <IMicrosoftGraphPlannerPlan[]>: .
  - `[Id <String>]`: Read-only.
  - `[Buckets <IMicrosoftGraphPlannerBucket[]>]`: Read-only. Nullable. Collection of buckets in the plan.
    - `[Id <String>]`: Read-only.
    - `[Name <String>]`: Name of the bucket.
    - `[OrderHint <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
    - `[PlanId <String>]`: Plan ID to which the bucket belongs.
    - `[Tasks <IMicrosoftGraphPlannerTask[]>]`: Read-only. Nullable. The collection of tasks in the bucket.
      - `[Id <String>]`: Read-only.
      - `[ActiveChecklistItemCount <Int32?>]`: Number of checklist items with value set to false, representing incomplete items.
      - `[AppliedCategories <IMicrosoftGraphPlannerAppliedCategories>]`: plannerAppliedCategories
      - `[AssignedToTaskBoardFormatId <String>]`: Read-only.
      - `[AssignedToTaskBoardFormatOrderHintsByAssignee <IMicrosoftGraphPlannerOrderHintsByAssignee>]`: plannerOrderHintsByAssignee
      - `[AssignedToTaskBoardFormatUnassignedOrderHint <String>]`: Hint value used to order the task on the AssignedTo view of the Task Board when the task is not assigned to anyone, or if the orderHintsByAssignee dictionary does not provide an order hint for the user the task is assigned to. The format is defined as outlined here.
      - `[AssigneePriority <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
      - `[Assignments <IMicrosoftGraphPlannerAssignments>]`: plannerAssignments
      - `[BucketId <String>]`: Bucket ID to which the task belongs. The bucket needs to be in the plan that the task is in. It is 28 characters long and case-sensitive. Format validation is done on the service.
      - `[BucketTaskBoardFormatId <String>]`: Read-only.
      - `[BucketTaskBoardFormatOrderHint <String>]`: Hint used to order tasks in the Bucket view of the Task Board. The format is defined as outlined here.
      - `[ChecklistItemCount <Int32?>]`: Number of checklist items that are present on the task.
      - `[CompletedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[Application <IMicrosoftGraphIdentity>]`: identity
          - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
          - `[Id <String>]`: Unique identifier for the identity.
        - `[Device <IMicrosoftGraphIdentity>]`: identity
        - `[User <IMicrosoftGraphIdentity>]`: identity
      - `[CompletedDateTime <DateTime?>]`: Read-only. Date and time at which the 'percentComplete' of the task is set to '100'. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[ConversationThreadId <String>]`: Thread ID of the conversation on the task. This is the ID of the conversation thread object created in the group.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: Read-only. Date and time at which the task is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[DetailChecklist <IMicrosoftGraphPlannerChecklistItems>]`: plannerChecklistItems
      - `[DetailDescription <String>]`: Description of the task
      - `[DetailId <String>]`: Read-only.
      - `[DetailPreviewType <String>]`: plannerPreviewType
      - `[DetailReferences <IMicrosoftGraphPlannerExternalReferences>]`: plannerExternalReferences
      - `[DueDateTime <DateTime?>]`: Date and time at which the task is due. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[HasDescription <Boolean?>]`: Read-only. Value is true if the details object of the task has a non-empty description and false otherwise.
      - `[OrderHint <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
      - `[PercentComplete <Int32?>]`: Percentage of task completion. When set to 100, the task is considered completed.
      - `[PlanId <String>]`: Plan ID to which the task belongs.
      - `[PreviewType <String>]`: plannerPreviewType
      - `[Priority <Int32?>]`: 
      - `[ProgressTaskBoardFormatId <String>]`: Read-only.
      - `[ProgressTaskBoardFormatOrderHint <String>]`: Hint value used to order the task on the Progress view of the Task Board. The format is defined as outlined here.
      - `[ReferenceCount <Int32?>]`: Number of external references that exist on the task.
      - `[StartDateTime <DateTime?>]`: Date and time at which the task starts. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[Title <String>]`: Title of the task.
  - `[CategoryDescriptionCategory1 <String>]`: The label associated with Category 1
  - `[CategoryDescriptionCategory2 <String>]`: The label associated with Category 2
  - `[CategoryDescriptionCategory3 <String>]`: The label associated with Category 3
  - `[CategoryDescriptionCategory4 <String>]`: The label associated with Category 4
  - `[CategoryDescriptionCategory5 <String>]`: The label associated with Category 5
  - `[CategoryDescriptionCategory6 <String>]`: The label associated with Category 6
  - `[Contexts <IMicrosoftGraphPlannerPlanContextCollection>]`: plannerPlanContextCollection
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[CreatedDateTime <DateTime?>]`: Read-only. Date and time at which the plan is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[DetailContextDetails <IMicrosoftGraphPlannerPlanContextDetailsCollection>]`: plannerPlanContextDetailsCollection
  - `[DetailId <String>]`: Read-only.
  - `[DetailSharedWith <IMicrosoftGraphPlannerUserIds>]`: plannerUserIds
  - `[Owner <String>]`: ID of the Group that owns the plan. A valid group must exist before this field can be set. After it is set, this property can’t be updated.
  - `[Tasks <IMicrosoftGraphPlannerTask[]>]`: Read-only. Nullable. Collection of tasks in the plan.
  - `[Title <String>]`: Required. Title of the plan.

INPUTOBJECT <IUsersPlannerIdentity>: Identity Parameter
  - `[PlannerBucketId <String>]`: key: plannerBucket-id of plannerBucket
  - `[PlannerDeltaId <String>]`: key: plannerDelta-id of plannerDelta
  - `[PlannerPlanId <String>]`: key: plannerPlan-id of plannerPlan
  - `[PlannerTaskId <String>]`: key: plannerTask-id of plannerTask
  - `[UserId <String>]`: key: user-id of user

PLANS <IMicrosoftGraphPlannerPlan[]>: Read-only. Nullable. Returns the plannerTasks assigned to the user.
  - `[Id <String>]`: Read-only.
  - `[Buckets <IMicrosoftGraphPlannerBucket[]>]`: Read-only. Nullable. Collection of buckets in the plan.
    - `[Id <String>]`: Read-only.
    - `[Name <String>]`: Name of the bucket.
    - `[OrderHint <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
    - `[PlanId <String>]`: Plan ID to which the bucket belongs.
    - `[Tasks <IMicrosoftGraphPlannerTask[]>]`: Read-only. Nullable. The collection of tasks in the bucket.
      - `[Id <String>]`: Read-only.
      - `[ActiveChecklistItemCount <Int32?>]`: Number of checklist items with value set to false, representing incomplete items.
      - `[AppliedCategories <IMicrosoftGraphPlannerAppliedCategories>]`: plannerAppliedCategories
      - `[AssignedToTaskBoardFormatId <String>]`: Read-only.
      - `[AssignedToTaskBoardFormatOrderHintsByAssignee <IMicrosoftGraphPlannerOrderHintsByAssignee>]`: plannerOrderHintsByAssignee
      - `[AssignedToTaskBoardFormatUnassignedOrderHint <String>]`: Hint value used to order the task on the AssignedTo view of the Task Board when the task is not assigned to anyone, or if the orderHintsByAssignee dictionary does not provide an order hint for the user the task is assigned to. The format is defined as outlined here.
      - `[AssigneePriority <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
      - `[Assignments <IMicrosoftGraphPlannerAssignments>]`: plannerAssignments
      - `[BucketId <String>]`: Bucket ID to which the task belongs. The bucket needs to be in the plan that the task is in. It is 28 characters long and case-sensitive. Format validation is done on the service.
      - `[BucketTaskBoardFormatId <String>]`: Read-only.
      - `[BucketTaskBoardFormatOrderHint <String>]`: Hint used to order tasks in the Bucket view of the Task Board. The format is defined as outlined here.
      - `[ChecklistItemCount <Int32?>]`: Number of checklist items that are present on the task.
      - `[CompletedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[Application <IMicrosoftGraphIdentity>]`: identity
          - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
          - `[Id <String>]`: Unique identifier for the identity.
        - `[Device <IMicrosoftGraphIdentity>]`: identity
        - `[User <IMicrosoftGraphIdentity>]`: identity
      - `[CompletedDateTime <DateTime?>]`: Read-only. Date and time at which the 'percentComplete' of the task is set to '100'. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[ConversationThreadId <String>]`: Thread ID of the conversation on the task. This is the ID of the conversation thread object created in the group.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: Read-only. Date and time at which the task is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[DetailChecklist <IMicrosoftGraphPlannerChecklistItems>]`: plannerChecklistItems
      - `[DetailDescription <String>]`: Description of the task
      - `[DetailId <String>]`: Read-only.
      - `[DetailPreviewType <String>]`: plannerPreviewType
      - `[DetailReferences <IMicrosoftGraphPlannerExternalReferences>]`: plannerExternalReferences
      - `[DueDateTime <DateTime?>]`: Date and time at which the task is due. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[HasDescription <Boolean?>]`: Read-only. Value is true if the details object of the task has a non-empty description and false otherwise.
      - `[OrderHint <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
      - `[PercentComplete <Int32?>]`: Percentage of task completion. When set to 100, the task is considered completed.
      - `[PlanId <String>]`: Plan ID to which the task belongs.
      - `[PreviewType <String>]`: plannerPreviewType
      - `[Priority <Int32?>]`: 
      - `[ProgressTaskBoardFormatId <String>]`: Read-only.
      - `[ProgressTaskBoardFormatOrderHint <String>]`: Hint value used to order the task on the Progress view of the Task Board. The format is defined as outlined here.
      - `[ReferenceCount <Int32?>]`: Number of external references that exist on the task.
      - `[StartDateTime <DateTime?>]`: Date and time at which the task starts. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[Title <String>]`: Title of the task.
  - `[CategoryDescriptionCategory1 <String>]`: The label associated with Category 1
  - `[CategoryDescriptionCategory2 <String>]`: The label associated with Category 2
  - `[CategoryDescriptionCategory3 <String>]`: The label associated with Category 3
  - `[CategoryDescriptionCategory4 <String>]`: The label associated with Category 4
  - `[CategoryDescriptionCategory5 <String>]`: The label associated with Category 5
  - `[CategoryDescriptionCategory6 <String>]`: The label associated with Category 6
  - `[Contexts <IMicrosoftGraphPlannerPlanContextCollection>]`: plannerPlanContextCollection
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[CreatedDateTime <DateTime?>]`: Read-only. Date and time at which the plan is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[DetailContextDetails <IMicrosoftGraphPlannerPlanContextDetailsCollection>]`: plannerPlanContextDetailsCollection
  - `[DetailId <String>]`: Read-only.
  - `[DetailSharedWith <IMicrosoftGraphPlannerUserIds>]`: plannerUserIds
  - `[Owner <String>]`: ID of the Group that owns the plan. A valid group must exist before this field can be set. After it is set, this property can’t be updated.
  - `[Tasks <IMicrosoftGraphPlannerTask[]>]`: Read-only. Nullable. Collection of tasks in the plan.
  - `[Title <String>]`: Required. Title of the plan.

RECENTPLANS <IMicrosoftGraphPlannerPlan[]>: .
  - `[Id <String>]`: Read-only.
  - `[Buckets <IMicrosoftGraphPlannerBucket[]>]`: Read-only. Nullable. Collection of buckets in the plan.
    - `[Id <String>]`: Read-only.
    - `[Name <String>]`: Name of the bucket.
    - `[OrderHint <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
    - `[PlanId <String>]`: Plan ID to which the bucket belongs.
    - `[Tasks <IMicrosoftGraphPlannerTask[]>]`: Read-only. Nullable. The collection of tasks in the bucket.
      - `[Id <String>]`: Read-only.
      - `[ActiveChecklistItemCount <Int32?>]`: Number of checklist items with value set to false, representing incomplete items.
      - `[AppliedCategories <IMicrosoftGraphPlannerAppliedCategories>]`: plannerAppliedCategories
      - `[AssignedToTaskBoardFormatId <String>]`: Read-only.
      - `[AssignedToTaskBoardFormatOrderHintsByAssignee <IMicrosoftGraphPlannerOrderHintsByAssignee>]`: plannerOrderHintsByAssignee
      - `[AssignedToTaskBoardFormatUnassignedOrderHint <String>]`: Hint value used to order the task on the AssignedTo view of the Task Board when the task is not assigned to anyone, or if the orderHintsByAssignee dictionary does not provide an order hint for the user the task is assigned to. The format is defined as outlined here.
      - `[AssigneePriority <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
      - `[Assignments <IMicrosoftGraphPlannerAssignments>]`: plannerAssignments
      - `[BucketId <String>]`: Bucket ID to which the task belongs. The bucket needs to be in the plan that the task is in. It is 28 characters long and case-sensitive. Format validation is done on the service.
      - `[BucketTaskBoardFormatId <String>]`: Read-only.
      - `[BucketTaskBoardFormatOrderHint <String>]`: Hint used to order tasks in the Bucket view of the Task Board. The format is defined as outlined here.
      - `[ChecklistItemCount <Int32?>]`: Number of checklist items that are present on the task.
      - `[CompletedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[Application <IMicrosoftGraphIdentity>]`: identity
          - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
          - `[Id <String>]`: Unique identifier for the identity.
        - `[Device <IMicrosoftGraphIdentity>]`: identity
        - `[User <IMicrosoftGraphIdentity>]`: identity
      - `[CompletedDateTime <DateTime?>]`: Read-only. Date and time at which the 'percentComplete' of the task is set to '100'. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[ConversationThreadId <String>]`: Thread ID of the conversation on the task. This is the ID of the conversation thread object created in the group.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: Read-only. Date and time at which the task is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[DetailChecklist <IMicrosoftGraphPlannerChecklistItems>]`: plannerChecklistItems
      - `[DetailDescription <String>]`: Description of the task
      - `[DetailId <String>]`: Read-only.
      - `[DetailPreviewType <String>]`: plannerPreviewType
      - `[DetailReferences <IMicrosoftGraphPlannerExternalReferences>]`: plannerExternalReferences
      - `[DueDateTime <DateTime?>]`: Date and time at which the task is due. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[HasDescription <Boolean?>]`: Read-only. Value is true if the details object of the task has a non-empty description and false otherwise.
      - `[OrderHint <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
      - `[PercentComplete <Int32?>]`: Percentage of task completion. When set to 100, the task is considered completed.
      - `[PlanId <String>]`: Plan ID to which the task belongs.
      - `[PreviewType <String>]`: plannerPreviewType
      - `[Priority <Int32?>]`: 
      - `[ProgressTaskBoardFormatId <String>]`: Read-only.
      - `[ProgressTaskBoardFormatOrderHint <String>]`: Hint value used to order the task on the Progress view of the Task Board. The format is defined as outlined here.
      - `[ReferenceCount <Int32?>]`: Number of external references that exist on the task.
      - `[StartDateTime <DateTime?>]`: Date and time at which the task starts. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
      - `[Title <String>]`: Title of the task.
  - `[CategoryDescriptionCategory1 <String>]`: The label associated with Category 1
  - `[CategoryDescriptionCategory2 <String>]`: The label associated with Category 2
  - `[CategoryDescriptionCategory3 <String>]`: The label associated with Category 3
  - `[CategoryDescriptionCategory4 <String>]`: The label associated with Category 4
  - `[CategoryDescriptionCategory5 <String>]`: The label associated with Category 5
  - `[CategoryDescriptionCategory6 <String>]`: The label associated with Category 6
  - `[Contexts <IMicrosoftGraphPlannerPlanContextCollection>]`: plannerPlanContextCollection
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[CreatedDateTime <DateTime?>]`: Read-only. Date and time at which the plan is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[DetailContextDetails <IMicrosoftGraphPlannerPlanContextDetailsCollection>]`: plannerPlanContextDetailsCollection
  - `[DetailId <String>]`: Read-only.
  - `[DetailSharedWith <IMicrosoftGraphPlannerUserIds>]`: plannerUserIds
  - `[Owner <String>]`: ID of the Group that owns the plan. A valid group must exist before this field can be set. After it is set, this property can’t be updated.
  - `[Tasks <IMicrosoftGraphPlannerTask[]>]`: Read-only. Nullable. Collection of tasks in the plan.
  - `[Title <String>]`: Required. Title of the plan.

TASKS <IMicrosoftGraphPlannerTask[]>: Read-only. Nullable. Returns the plannerPlans shared with the user.
  - `[Id <String>]`: Read-only.
  - `[ActiveChecklistItemCount <Int32?>]`: Number of checklist items with value set to false, representing incomplete items.
  - `[AppliedCategories <IMicrosoftGraphPlannerAppliedCategories>]`: plannerAppliedCategories
  - `[AssignedToTaskBoardFormatId <String>]`: Read-only.
  - `[AssignedToTaskBoardFormatOrderHintsByAssignee <IMicrosoftGraphPlannerOrderHintsByAssignee>]`: plannerOrderHintsByAssignee
  - `[AssignedToTaskBoardFormatUnassignedOrderHint <String>]`: Hint value used to order the task on the AssignedTo view of the Task Board when the task is not assigned to anyone, or if the orderHintsByAssignee dictionary does not provide an order hint for the user the task is assigned to. The format is defined as outlined here.
  - `[AssigneePriority <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
  - `[Assignments <IMicrosoftGraphPlannerAssignments>]`: plannerAssignments
  - `[BucketId <String>]`: Bucket ID to which the task belongs. The bucket needs to be in the plan that the task is in. It is 28 characters long and case-sensitive. Format validation is done on the service.
  - `[BucketTaskBoardFormatId <String>]`: Read-only.
  - `[BucketTaskBoardFormatOrderHint <String>]`: Hint used to order tasks in the Bucket view of the Task Board. The format is defined as outlined here.
  - `[ChecklistItemCount <Int32?>]`: Number of checklist items that are present on the task.
  - `[CompletedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CompletedDateTime <DateTime?>]`: Read-only. Date and time at which the 'percentComplete' of the task is set to '100'. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[ConversationThreadId <String>]`: Thread ID of the conversation on the task. This is the ID of the conversation thread object created in the group.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[CreatedDateTime <DateTime?>]`: Read-only. Date and time at which the task is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[DetailChecklist <IMicrosoftGraphPlannerChecklistItems>]`: plannerChecklistItems
  - `[DetailDescription <String>]`: Description of the task
  - `[DetailId <String>]`: Read-only.
  - `[DetailPreviewType <String>]`: plannerPreviewType
  - `[DetailReferences <IMicrosoftGraphPlannerExternalReferences>]`: plannerExternalReferences
  - `[DueDateTime <DateTime?>]`: Date and time at which the task is due. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[HasDescription <Boolean?>]`: Read-only. Value is true if the details object of the task has a non-empty description and false otherwise.
  - `[OrderHint <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
  - `[PercentComplete <Int32?>]`: Percentage of task completion. When set to 100, the task is considered completed.
  - `[PlanId <String>]`: Plan ID to which the task belongs.
  - `[PreviewType <String>]`: plannerPreviewType
  - `[Priority <Int32?>]`: 
  - `[ProgressTaskBoardFormatId <String>]`: Read-only.
  - `[ProgressTaskBoardFormatOrderHint <String>]`: Hint value used to order the task on the Progress view of the Task Board. The format is defined as outlined here.
  - `[ReferenceCount <Int32?>]`: Number of external references that exist on the task.
  - `[StartDateTime <DateTime?>]`: Date and time at which the task starts. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[Title <String>]`: Title of the task.

## RELATED LINKS

