---
external help file:
Module Name: Microsoft.Graph.Planner
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.planner/update-mguserplanner
schema: 2.0.0
---

# Update-MgUserPlanner

## SYNOPSIS
Update the navigation property planner in users

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgUserPlanner -UserId <String> [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-Plans <IMicrosoftGraphPlannerPlan[]>] [-Tasks <IMicrosoftGraphPlannerTask[]>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgUserPlanner -UserId <String> -BodyParameter <IMicrosoftGraphPlannerUser1> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgUserPlanner -InputObject <IPlannerIdentity> -BodyParameter <IMicrosoftGraphPlannerUser1> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgUserPlanner -InputObject <IPlannerIdentity> [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-Plans <IMicrosoftGraphPlannerPlan[]>] [-Tasks <IMicrosoftGraphPlannerTask[]>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property planner in users

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
plannerUser
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerUser1
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
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

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPlannerIdentity
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
To construct, please use Get-Help -Online and see NOTES section for PLANS properties and create a hash table.

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
Returns the plannerTasks assigned to the user.
To construct, please use Get-Help -Online and see NOTES section for TASKS properties and create a hash table.

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
key: id of user

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerUser1

### Microsoft.Graph.PowerShell.Models.IPlannerIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphPlannerUser1>: plannerUser
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Plans <IMicrosoftGraphPlannerPlan[]>]`: Read-only. Nullable. Returns the plannerTasks assigned to the user.
    - `[Id <String>]`: 
    - `[Buckets <IMicrosoftGraphPlannerBucket[]>]`: Collection of buckets in the plan. Read-only. Nullable.
      - `[Id <String>]`: 
      - `[Name <String>]`: Name of the bucket.
      - `[OrderHint <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
      - `[PlanId <String>]`: Plan ID to which the bucket belongs.
      - `[Tasks <IMicrosoftGraphPlannerTask[]>]`: Read-only. Nullable. The collection of tasks in the bucket.
        - `[Id <String>]`: 
        - `[ActiveChecklistItemCount <Int32?>]`: Number of checklist items with value set to false, representing incomplete items.
        - `[AppliedCategories <IMicrosoftGraphPlannerAppliedCategories>]`: plannerAppliedCategories
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AssignedToTaskBoardFormat <IMicrosoftGraphPlannerAssignedToTaskBoardTaskFormat>]`: plannerAssignedToTaskBoardTaskFormat
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Id <String>]`: 
          - `[OrderHintsByAssignee <IMicrosoftGraphPlannerOrderHintsByAssignee>]`: plannerOrderHintsByAssignee
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[UnassignedOrderHint <String>]`: Hint value used to order the task on the AssignedTo view of the Task Board when the task is not assigned to anyone, or if the orderHintsByAssignee dictionary does not provide an order hint for the user the task is assigned to. The format is defined as outlined here.
        - `[AssigneePriority <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
        - `[Assignments <IMicrosoftGraphPlannerAssignments>]`: plannerAssignments
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[BucketId <String>]`: Bucket ID to which the task belongs. The bucket needs to be in the plan that the task is in. It is 28 characters long and case-sensitive. Format validation is done on the service.
        - `[BucketTaskBoardFormat <IMicrosoftGraphPlannerBucketTaskBoardTaskFormat>]`: plannerBucketTaskBoardTaskFormat
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Id <String>]`: 
          - `[OrderHint <String>]`: Hint used to order tasks in the Bucket view of the Task Board. The format is defined as outlined here.
        - `[ChecklistItemCount <Int32?>]`: Number of checklist items that are present on the task.
        - `[CompletedBy <IMicrosoftGraphIdentitySet>]`: identitySet
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Application <IMicrosoftGraphIdentity>]`: identity
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
            - `[Id <String>]`: Unique identifier for the identity.
          - `[Device <IMicrosoftGraphIdentity>]`: identity
          - `[User <IMicrosoftGraphIdentity>]`: identity
        - `[CompletedDateTime <DateTime?>]`: Read-only. Date and time at which the 'percentComplete' of the task is set to '100'. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        - `[ConversationThreadId <String>]`: Thread ID of the conversation on the task. This is the ID of the conversation thread object created in the group.
        - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[CreatedDateTime <DateTime?>]`: Read-only. Date and time at which the task is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        - `[Details <IMicrosoftGraphPlannerTaskDetails>]`: plannerTaskDetails
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Id <String>]`: 
          - `[Checklist <IMicrosoftGraphPlannerChecklistItems>]`: plannerChecklistItems
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Description <String>]`: Description of the task.
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
          - `[Id <String>]`: 
          - `[OrderHint <String>]`: Hint value used to order the task on the Progress view of the Task Board. The format is defined as outlined here.
        - `[ReferenceCount <Int32?>]`: Number of external references that exist on the task.
        - `[StartDateTime <DateTime?>]`: Date and time at which the task starts. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        - `[Title <String>]`: Title of the task.
    - `[Container <IMicrosoftGraphPlannerPlanContainer>]`: plannerPlanContainer
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ContainerId <String>]`: The identifier of the resource that contains the plan.
      - `[Type <String>]`: plannerContainerType
      - `[Url <String>]`: The full canonical URL of the container.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: Read-only. Date and time at which the plan is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[Details <IMicrosoftGraphPlannerPlanDetails>]`: plannerPlanDetails
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
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
      - `[SharedWith <IMicrosoftGraphPlannerUserIds>]`: plannerUserIds
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Owner <String>]`: 
    - `[Tasks <IMicrosoftGraphPlannerTask[]>]`: Collection of tasks in the plan. Read-only. Nullable.
    - `[Title <String>]`: Required. Title of the plan.
  - `[Tasks <IMicrosoftGraphPlannerTask[]>]`: Read-only. Nullable. Returns the plannerTasks assigned to the user.

INPUTOBJECT <IPlannerIdentity>: Identity Parameter
  - `[GroupId <String>]`: key: id of group
  - `[PlannerBucketId <String>]`: key: id of plannerBucket
  - `[PlannerDeltaId <String>]`: key: id of plannerDelta
  - `[PlannerPlanId <String>]`: key: id of plannerPlan
  - `[PlannerRosterId <String>]`: key: id of plannerRoster
  - `[PlannerRosterMemberId <String>]`: key: id of plannerRosterMember
  - `[PlannerTaskId <String>]`: key: id of plannerTask
  - `[UserId <String>]`: key: id of user

PLANS <IMicrosoftGraphPlannerPlan[]>: Read-only. Nullable. Returns the plannerTasks assigned to the user.
  - `[Id <String>]`: 
  - `[Buckets <IMicrosoftGraphPlannerBucket[]>]`: Collection of buckets in the plan. Read-only. Nullable.
    - `[Id <String>]`: 
    - `[Name <String>]`: Name of the bucket.
    - `[OrderHint <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
    - `[PlanId <String>]`: Plan ID to which the bucket belongs.
    - `[Tasks <IMicrosoftGraphPlannerTask[]>]`: Read-only. Nullable. The collection of tasks in the bucket.
      - `[Id <String>]`: 
      - `[ActiveChecklistItemCount <Int32?>]`: Number of checklist items with value set to false, representing incomplete items.
      - `[AppliedCategories <IMicrosoftGraphPlannerAppliedCategories>]`: plannerAppliedCategories
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AssignedToTaskBoardFormat <IMicrosoftGraphPlannerAssignedToTaskBoardTaskFormat>]`: plannerAssignedToTaskBoardTaskFormat
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: 
        - `[OrderHintsByAssignee <IMicrosoftGraphPlannerOrderHintsByAssignee>]`: plannerOrderHintsByAssignee
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[UnassignedOrderHint <String>]`: Hint value used to order the task on the AssignedTo view of the Task Board when the task is not assigned to anyone, or if the orderHintsByAssignee dictionary does not provide an order hint for the user the task is assigned to. The format is defined as outlined here.
      - `[AssigneePriority <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
      - `[Assignments <IMicrosoftGraphPlannerAssignments>]`: plannerAssignments
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[BucketId <String>]`: Bucket ID to which the task belongs. The bucket needs to be in the plan that the task is in. It is 28 characters long and case-sensitive. Format validation is done on the service.
      - `[BucketTaskBoardFormat <IMicrosoftGraphPlannerBucketTaskBoardTaskFormat>]`: plannerBucketTaskBoardTaskFormat
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: 
        - `[OrderHint <String>]`: Hint used to order tasks in the Bucket view of the Task Board. The format is defined as outlined here.
      - `[ChecklistItemCount <Int32?>]`: Number of checklist items that are present on the task.
      - `[CompletedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Application <IMicrosoftGraphIdentity>]`: identity
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
          - `[Id <String>]`: Unique identifier for the identity.
        - `[Device <IMicrosoftGraphIdentity>]`: identity
        - `[User <IMicrosoftGraphIdentity>]`: identity
      - `[CompletedDateTime <DateTime?>]`: Read-only. Date and time at which the 'percentComplete' of the task is set to '100'. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[ConversationThreadId <String>]`: Thread ID of the conversation on the task. This is the ID of the conversation thread object created in the group.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: Read-only. Date and time at which the task is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[Details <IMicrosoftGraphPlannerTaskDetails>]`: plannerTaskDetails
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: 
        - `[Checklist <IMicrosoftGraphPlannerChecklistItems>]`: plannerChecklistItems
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Description <String>]`: Description of the task.
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
        - `[Id <String>]`: 
        - `[OrderHint <String>]`: Hint value used to order the task on the Progress view of the Task Board. The format is defined as outlined here.
      - `[ReferenceCount <Int32?>]`: Number of external references that exist on the task.
      - `[StartDateTime <DateTime?>]`: Date and time at which the task starts. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[Title <String>]`: Title of the task.
  - `[Container <IMicrosoftGraphPlannerPlanContainer>]`: plannerPlanContainer
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ContainerId <String>]`: The identifier of the resource that contains the plan.
    - `[Type <String>]`: plannerContainerType
    - `[Url <String>]`: The full canonical URL of the container.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[CreatedDateTime <DateTime?>]`: Read-only. Date and time at which the plan is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Details <IMicrosoftGraphPlannerPlanDetails>]`: plannerPlanDetails
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
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
    - `[SharedWith <IMicrosoftGraphPlannerUserIds>]`: plannerUserIds
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Owner <String>]`: 
  - `[Tasks <IMicrosoftGraphPlannerTask[]>]`: Collection of tasks in the plan. Read-only. Nullable.
  - `[Title <String>]`: Required. Title of the plan.

TASKS <IMicrosoftGraphPlannerTask[]>: Read-only. Nullable. Returns the plannerTasks assigned to the user.
  - `[Id <String>]`: 
  - `[ActiveChecklistItemCount <Int32?>]`: Number of checklist items with value set to false, representing incomplete items.
  - `[AppliedCategories <IMicrosoftGraphPlannerAppliedCategories>]`: plannerAppliedCategories
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AssignedToTaskBoardFormat <IMicrosoftGraphPlannerAssignedToTaskBoardTaskFormat>]`: plannerAssignedToTaskBoardTaskFormat
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[OrderHintsByAssignee <IMicrosoftGraphPlannerOrderHintsByAssignee>]`: plannerOrderHintsByAssignee
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[UnassignedOrderHint <String>]`: Hint value used to order the task on the AssignedTo view of the Task Board when the task is not assigned to anyone, or if the orderHintsByAssignee dictionary does not provide an order hint for the user the task is assigned to. The format is defined as outlined here.
  - `[AssigneePriority <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
  - `[Assignments <IMicrosoftGraphPlannerAssignments>]`: plannerAssignments
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[BucketId <String>]`: Bucket ID to which the task belongs. The bucket needs to be in the plan that the task is in. It is 28 characters long and case-sensitive. Format validation is done on the service.
  - `[BucketTaskBoardFormat <IMicrosoftGraphPlannerBucketTaskBoardTaskFormat>]`: plannerBucketTaskBoardTaskFormat
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[OrderHint <String>]`: Hint used to order tasks in the Bucket view of the Task Board. The format is defined as outlined here.
  - `[ChecklistItemCount <Int32?>]`: Number of checklist items that are present on the task.
  - `[CompletedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CompletedDateTime <DateTime?>]`: Read-only. Date and time at which the 'percentComplete' of the task is set to '100'. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[ConversationThreadId <String>]`: Thread ID of the conversation on the task. This is the ID of the conversation thread object created in the group.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[CreatedDateTime <DateTime?>]`: Read-only. Date and time at which the task is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Details <IMicrosoftGraphPlannerTaskDetails>]`: plannerTaskDetails
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[Checklist <IMicrosoftGraphPlannerChecklistItems>]`: plannerChecklistItems
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Description <String>]`: Description of the task.
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
    - `[Id <String>]`: 
    - `[OrderHint <String>]`: Hint value used to order the task on the Progress view of the Task Board. The format is defined as outlined here.
  - `[ReferenceCount <Int32?>]`: Number of external references that exist on the task.
  - `[StartDateTime <DateTime?>]`: Date and time at which the task starts. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Title <String>]`: Title of the task.

## RELATED LINKS

