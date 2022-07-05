---
external help file:
Module Name: Microsoft.Graph.Planner
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.planner/new-mgplannerplan
schema: 2.0.0
---

# New-MgPlannerPlan

## SYNOPSIS
Create new navigation property to plans for planner

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgPlannerPlan [-AdditionalProperties <Hashtable>] [-Buckets <IMicrosoftGraphPlannerBucket1[]>]
 [-Container <IMicrosoftGraphPlannerPlanContainer>] [-Contexts <Hashtable>]
 [-CreatedBy <IMicrosoftGraphIdentitySet>] [-CreatedDateTime <DateTime>]
 [-Details <IMicrosoftGraphPlannerPlanDetails1>] [-Id <String>] [-Owner <String>]
 [-Tasks <IMicrosoftGraphPlannerTask1[]>] [-Title <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgPlannerPlan -BodyParameter <IMicrosoftGraphPlannerPlan1> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to plans for planner

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
plannerPlan
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerPlan1
Parameter Sets: Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Buckets
Collection of buckets in the plan.
Read-only.
Nullable.
To construct, please use Get-Help -Online and see NOTES section for BUCKETS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerBucket1[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Container
plannerPlanContainer
To construct, please use Get-Help -Online and see NOTES section for CONTAINER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerPlanContainer
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Contexts
plannerPlanContextCollection

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded1
Aliases:

Required: False
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
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
Read-only.
Date and time at which the plan is created.
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Details
plannerPlanDetails
To construct, please use Get-Help -Online and see NOTES section for DETAILS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerPlanDetails1
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Owner
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tasks
Collection of tasks in the plan.
Read-only.
Nullable.
To construct, please use Get-Help -Online and see NOTES section for TASKS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerTask1[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Title
Required.
Title of the plan.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerPlan1

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPlannerPlan1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphPlannerPlan1>: plannerPlan
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Buckets <IMicrosoftGraphPlannerBucket1[]>]`: Collection of buckets in the plan. Read-only. Nullable.
    - `[Id <String>]`: 
    - `[Name <String>]`: Name of the bucket.
    - `[OrderHint <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
    - `[PlanId <String>]`: Plan ID to which the bucket belongs.
    - `[Tasks <IMicrosoftGraphPlannerTask1[]>]`: Read-only. Nullable. The collection of tasks in the bucket.
      - `[Id <String>]`: 
      - `[ActiveChecklistItemCount <Int32?>]`: Number of checklist items with value set to false, representing incomplete items.
      - `[AppliedCategories <IMicrosoftGraphPlannerAppliedCategories>]`: plannerAppliedCategories
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AssignedToTaskBoardFormat <IMicrosoftGraphPlannerAssignedToTaskBoardTaskFormat1>]`: plannerAssignedToTaskBoardTaskFormat
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: 
        - `[OrderHintsByAssignee <IMicrosoftGraphPlannerOrderHintsByAssignee>]`: plannerOrderHintsByAssignee
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[UnassignedOrderHint <String>]`: Hint value used to order the task on the AssignedTo view of the Task Board when the task is not assigned to anyone, or if the orderHintsByAssignee dictionary does not provide an order hint for the user the task is assigned to. The format is defined as outlined here.
      - `[AssigneePriority <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
      - `[Assignments <IMicrosoftGraphPlannerAssignments>]`: plannerAssignments
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[BucketId <String>]`: Bucket ID to which the task belongs. The bucket needs to be in the plan that the task is in. It is 28 characters long and case-sensitive. Format validation is done on the service.
      - `[BucketTaskBoardFormat <IMicrosoftGraphPlannerBucketTaskBoardTaskFormat1>]`: plannerBucketTaskBoardTaskFormat
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: 
        - `[OrderHint <String>]`: Hint used to order tasks in the Bucket view of the Task Board. The format is defined as outlined here.
      - `[ChecklistItemCount <Int32?>]`: Number of checklist items that are present on the task.
      - `[CompletedBy <IMicrosoftGraphIdentitySet>]`: identitySet
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Application <IMicrosoftGraphIdentity>]`: identity
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
          - `[Id <String>]`: Unique identifier for the identity.
        - `[Device <IMicrosoftGraphIdentity>]`: identity
        - `[User <IMicrosoftGraphIdentity>]`: identity
      - `[CompletedDateTime <DateTime?>]`: Read-only. Date and time at which the 'percentComplete' of the task is set to '100'. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[ConversationThreadId <String>]`: Thread ID of the conversation on the task. This is the ID of the conversation thread object created in the group.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: Read-only. Date and time at which the task is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[CreationSource <IMicrosoftGraphPlannerTaskCreation>]`: plannerTaskCreation
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[TeamsPublicationInfo <IMicrosoftGraphPlannerTeamsPublicationInfo>]`: plannerTeamsPublicationInfo
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[LastModifiedDateTime <DateTime?>]`: The date and time when this task was last modified by the publication process. Read-only.
          - `[PublicationId <String>]`: The identifier of the publication. Read-only.
          - `[PublishedToPlanId <String>]`: The identifier of the plannerPlan this task was originally placed in. Read-only.
          - `[PublishingTeamId <String>]`: The identifier of the team that initiated the publication process. Read-only.
          - `[PublishingTeamName <String>]`: The display name of the team that initiated the publication process. This display name is for reference only, and might not represent the most up-to-date name of the team. Read-only.
      - `[Details <IMicrosoftGraphPlannerTaskDetails1>]`: plannerTaskDetails
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
      - `[ProgressTaskBoardFormat <IMicrosoftGraphPlannerProgressTaskBoardTaskFormat1>]`: plannerProgressTaskBoardTaskFormat
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
  - `[Contexts <IMicrosoftGraphPlannerPlanContextCollection>]`: plannerPlanContextCollection
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[CreatedDateTime <DateTime?>]`: Read-only. Date and time at which the plan is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Details <IMicrosoftGraphPlannerPlanDetails1>]`: plannerPlanDetails
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
    - `[ContextDetails <IMicrosoftGraphPlannerPlanContextDetailsCollection>]`: plannerPlanContextDetailsCollection
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[SharedWith <IMicrosoftGraphPlannerUserIds>]`: plannerUserIds
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Owner <String>]`: 
  - `[Tasks <IMicrosoftGraphPlannerTask1[]>]`: Collection of tasks in the plan. Read-only. Nullable.
  - `[Title <String>]`: Required. Title of the plan.

BUCKETS <IMicrosoftGraphPlannerBucket1[]>: Collection of buckets in the plan. Read-only. Nullable.
  - `[Id <String>]`: 
  - `[Name <String>]`: Name of the bucket.
  - `[OrderHint <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
  - `[PlanId <String>]`: Plan ID to which the bucket belongs.
  - `[Tasks <IMicrosoftGraphPlannerTask1[]>]`: Read-only. Nullable. The collection of tasks in the bucket.
    - `[Id <String>]`: 
    - `[ActiveChecklistItemCount <Int32?>]`: Number of checklist items with value set to false, representing incomplete items.
    - `[AppliedCategories <IMicrosoftGraphPlannerAppliedCategories>]`: plannerAppliedCategories
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AssignedToTaskBoardFormat <IMicrosoftGraphPlannerAssignedToTaskBoardTaskFormat1>]`: plannerAssignedToTaskBoardTaskFormat
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[OrderHintsByAssignee <IMicrosoftGraphPlannerOrderHintsByAssignee>]`: plannerOrderHintsByAssignee
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[UnassignedOrderHint <String>]`: Hint value used to order the task on the AssignedTo view of the Task Board when the task is not assigned to anyone, or if the orderHintsByAssignee dictionary does not provide an order hint for the user the task is assigned to. The format is defined as outlined here.
    - `[AssigneePriority <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
    - `[Assignments <IMicrosoftGraphPlannerAssignments>]`: plannerAssignments
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[BucketId <String>]`: Bucket ID to which the task belongs. The bucket needs to be in the plan that the task is in. It is 28 characters long and case-sensitive. Format validation is done on the service.
    - `[BucketTaskBoardFormat <IMicrosoftGraphPlannerBucketTaskBoardTaskFormat1>]`: plannerBucketTaskBoardTaskFormat
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[OrderHint <String>]`: Hint used to order tasks in the Bucket view of the Task Board. The format is defined as outlined here.
    - `[ChecklistItemCount <Int32?>]`: Number of checklist items that are present on the task.
    - `[CompletedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[CompletedDateTime <DateTime?>]`: Read-only. Date and time at which the 'percentComplete' of the task is set to '100'. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[ConversationThreadId <String>]`: Thread ID of the conversation on the task. This is the ID of the conversation thread object created in the group.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: Read-only. Date and time at which the task is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[CreationSource <IMicrosoftGraphPlannerTaskCreation>]`: plannerTaskCreation
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[TeamsPublicationInfo <IMicrosoftGraphPlannerTeamsPublicationInfo>]`: plannerTeamsPublicationInfo
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[LastModifiedDateTime <DateTime?>]`: The date and time when this task was last modified by the publication process. Read-only.
        - `[PublicationId <String>]`: The identifier of the publication. Read-only.
        - `[PublishedToPlanId <String>]`: The identifier of the plannerPlan this task was originally placed in. Read-only.
        - `[PublishingTeamId <String>]`: The identifier of the team that initiated the publication process. Read-only.
        - `[PublishingTeamName <String>]`: The display name of the team that initiated the publication process. This display name is for reference only, and might not represent the most up-to-date name of the team. Read-only.
    - `[Details <IMicrosoftGraphPlannerTaskDetails1>]`: plannerTaskDetails
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
    - `[ProgressTaskBoardFormat <IMicrosoftGraphPlannerProgressTaskBoardTaskFormat1>]`: plannerProgressTaskBoardTaskFormat
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[OrderHint <String>]`: Hint value used to order the task on the Progress view of the Task Board. The format is defined as outlined here.
    - `[ReferenceCount <Int32?>]`: Number of external references that exist on the task.
    - `[StartDateTime <DateTime?>]`: Date and time at which the task starts. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[Title <String>]`: Title of the task.

CONTAINER <IMicrosoftGraphPlannerPlanContainer>: plannerPlanContainer
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ContainerId <String>]`: The identifier of the resource that contains the plan.
  - `[Type <String>]`: plannerContainerType
  - `[Url <String>]`: The full canonical URL of the container.

CREATEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

DETAILS <IMicrosoftGraphPlannerPlanDetails1>: plannerPlanDetails
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
  - `[ContextDetails <IMicrosoftGraphPlannerPlanContextDetailsCollection>]`: plannerPlanContextDetailsCollection
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[SharedWith <IMicrosoftGraphPlannerUserIds>]`: plannerUserIds
    - `[(Any) <Object>]`: This indicates any property can be added to this object.

TASKS <IMicrosoftGraphPlannerTask1[]>: Collection of tasks in the plan. Read-only. Nullable.
  - `[Id <String>]`: 
  - `[ActiveChecklistItemCount <Int32?>]`: Number of checklist items with value set to false, representing incomplete items.
  - `[AppliedCategories <IMicrosoftGraphPlannerAppliedCategories>]`: plannerAppliedCategories
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AssignedToTaskBoardFormat <IMicrosoftGraphPlannerAssignedToTaskBoardTaskFormat1>]`: plannerAssignedToTaskBoardTaskFormat
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[OrderHintsByAssignee <IMicrosoftGraphPlannerOrderHintsByAssignee>]`: plannerOrderHintsByAssignee
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[UnassignedOrderHint <String>]`: Hint value used to order the task on the AssignedTo view of the Task Board when the task is not assigned to anyone, or if the orderHintsByAssignee dictionary does not provide an order hint for the user the task is assigned to. The format is defined as outlined here.
  - `[AssigneePriority <String>]`: Hint used to order items of this type in a list view. The format is defined as outlined here.
  - `[Assignments <IMicrosoftGraphPlannerAssignments>]`: plannerAssignments
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[BucketId <String>]`: Bucket ID to which the task belongs. The bucket needs to be in the plan that the task is in. It is 28 characters long and case-sensitive. Format validation is done on the service.
  - `[BucketTaskBoardFormat <IMicrosoftGraphPlannerBucketTaskBoardTaskFormat1>]`: plannerBucketTaskBoardTaskFormat
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[OrderHint <String>]`: Hint used to order tasks in the Bucket view of the Task Board. The format is defined as outlined here.
  - `[ChecklistItemCount <Int32?>]`: Number of checklist items that are present on the task.
  - `[CompletedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CompletedDateTime <DateTime?>]`: Read-only. Date and time at which the 'percentComplete' of the task is set to '100'. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[ConversationThreadId <String>]`: Thread ID of the conversation on the task. This is the ID of the conversation thread object created in the group.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[CreatedDateTime <DateTime?>]`: Read-only. Date and time at which the task is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[CreationSource <IMicrosoftGraphPlannerTaskCreation>]`: plannerTaskCreation
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[TeamsPublicationInfo <IMicrosoftGraphPlannerTeamsPublicationInfo>]`: plannerTeamsPublicationInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[LastModifiedDateTime <DateTime?>]`: The date and time when this task was last modified by the publication process. Read-only.
      - `[PublicationId <String>]`: The identifier of the publication. Read-only.
      - `[PublishedToPlanId <String>]`: The identifier of the plannerPlan this task was originally placed in. Read-only.
      - `[PublishingTeamId <String>]`: The identifier of the team that initiated the publication process. Read-only.
      - `[PublishingTeamName <String>]`: The display name of the team that initiated the publication process. This display name is for reference only, and might not represent the most up-to-date name of the team. Read-only.
  - `[Details <IMicrosoftGraphPlannerTaskDetails1>]`: plannerTaskDetails
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
  - `[ProgressTaskBoardFormat <IMicrosoftGraphPlannerProgressTaskBoardTaskFormat1>]`: plannerProgressTaskBoardTaskFormat
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[OrderHint <String>]`: Hint value used to order the task on the Progress view of the Task Board. The format is defined as outlined here.
  - `[ReferenceCount <Int32?>]`: Number of external references that exist on the task.
  - `[StartDateTime <DateTime?>]`: Date and time at which the task starts. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Title <String>]`: Title of the task.

## RELATED LINKS

