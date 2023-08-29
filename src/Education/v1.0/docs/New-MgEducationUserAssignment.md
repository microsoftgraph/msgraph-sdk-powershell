---
external help file:
Module Name: Microsoft.Graph.Education
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.education/new-mgeducationuserassignment
schema: 2.0.0
---

# New-MgEducationUserAssignment

## SYNOPSIS
Create new navigation property to assignments for education

## SYNTAX

### CreateExpanded (Default)
```
New-MgEducationUserAssignment -EducationUserId <String> [-AddedStudentAction <String>]
 [-AdditionalProperties <Hashtable>] [-AddToCalendarAction <String>] [-AllowLateSubmissions]
 [-AllowStudentsToAddResourcesToSubmission] [-AssignTo <Hashtable>]
 [-Categories <IMicrosoftGraphEducationCategory[]>] [-ClassId <String>] [-CloseDateTime <DateTime>]
 [-CreatedBy <IMicrosoftGraphIdentitySet>] [-DisplayName <String>] [-DueDateTime <DateTime>]
 [-Grading <Hashtable>] [-Id <String>] [-Instructions <IMicrosoftGraphEducationItemBody>]
 [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-NotificationChannelUrl <String>]
 [-Resources <IMicrosoftGraphEducationAssignmentResource[]>] [-Rubric <IMicrosoftGraphEducationRubric>]
 [-Status <String>] [-Submissions <IMicrosoftGraphEducationSubmission[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgEducationUserAssignment -EducationUserId <String> -BodyParameter <IMicrosoftGraphEducationAssignment>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgEducationUserAssignment -InputObject <IEducationIdentity>
 -BodyParameter <IMicrosoftGraphEducationAssignment> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgEducationUserAssignment -InputObject <IEducationIdentity> [-AddedStudentAction <String>]
 [-AdditionalProperties <Hashtable>] [-AddToCalendarAction <String>] [-AllowLateSubmissions]
 [-AllowStudentsToAddResourcesToSubmission] [-AssignTo <Hashtable>]
 [-Categories <IMicrosoftGraphEducationCategory[]>] [-ClassId <String>] [-CloseDateTime <DateTime>]
 [-CreatedBy <IMicrosoftGraphIdentitySet>] [-DisplayName <String>] [-DueDateTime <DateTime>]
 [-Grading <Hashtable>] [-Id <String>] [-Instructions <IMicrosoftGraphEducationItemBody>]
 [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-NotificationChannelUrl <String>]
 [-Resources <IMicrosoftGraphEducationAssignmentResource[]>] [-Rubric <IMicrosoftGraphEducationRubric>]
 [-Status <String>] [-Submissions <IMicrosoftGraphEducationSubmission[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to assignments for education

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Education
```

Get-MgEducationMeAssignment

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Import-Module Microsoft.Graph.Education
```

Get-MgEducationUserAssignment -EducationUserId $educationUserId

### -------------------------- EXAMPLE 3 --------------------------
```powershell
Import-Module Microsoft.Graph.Education
```

Get-MgEducationUserAssignment -EducationUserId $educationUserId -ExpandProperty "submissions"

## PARAMETERS

### -AddedStudentAction
educationAddedStudentAction

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

### -AddToCalendarAction
educationAddToCalendarOptions

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

### -AllowLateSubmissions
Identifies whether students can submit after the due date.
If this property isn't specified during create, it defaults to true.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowStudentsToAddResourcesToSubmission
Identifies whether students can add their own resources to a submission or if they can only modify resources added by the teacher.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AssignTo
educationAssignmentRecipient

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
educationAssignment
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationAssignment
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Categories
When set, enables users to easily find assignments of a given type.
Read-only.
Nullable.
To construct, see NOTES section for CATEGORIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationCategory[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClassId
Class which this assignment belongs.

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

### -CloseDateTime
Date when the assignment will be closed for submissions.
This is an optional field that can be null if the assignment does not allowLateSubmissions or when the closeDateTime is the same as the dueDateTime.
But if specified, then the closeDateTime must be greater than or equal to the dueDateTime.
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedBy
identitySet
To construct, see NOTES section for CREATEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
Name of the assignment.

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

### -DueDateTime
Date when the students assignment is due.
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EducationUserId
The unique identifier of educationUser

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

### -Grading
educationAssignmentGradeType

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
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IEducationIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Instructions
educationItemBody
To construct, see NOTES section for INSTRUCTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationItemBody
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedBy
identitySet
To construct, see NOTES section for LASTMODIFIEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NotificationChannelUrl
Optional field to specify the URL of the channel to post the assignment publish notification.
If not specified or null, defaults to the General channel.
This field only applies to assignments where the assignTo value is educationAssignmentClassRecipient.
Updating the notificationChannelUrl isn't allowed after the assignment has been published.

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

### -Resources
Learning objects that are associated with this assignment.
Only teachers can modify this list.
Nullable.
To construct, see NOTES section for RESOURCES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationAssignmentResource[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Rubric
educationRubric
To construct, see NOTES section for RUBRIC properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationRubric
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
educationAssignmentStatus

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

### -Submissions
Once published, there is a submission object for each student representing their work and grade.
Read-only.
Nullable.
To construct, see NOTES section for SUBMISSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationSubmission[]
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

### Microsoft.Graph.PowerShell.Models.IEducationIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationAssignment

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationAssignment

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphEducationAssignment>`: educationAssignment
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AddToCalendarAction <String>]`: educationAddToCalendarOptions
  - `[AddedStudentAction <String>]`: educationAddedStudentAction
  - `[AllowLateSubmissions <Boolean?>]`: Identifies whether students can submit after the due date. If this property isn't specified during create, it defaults to true.
  - `[AllowStudentsToAddResourcesToSubmission <Boolean?>]`: Identifies whether students can add their own resources to a submission or if they can only modify resources added by the teacher.
  - `[AssignTo <IMicrosoftGraphEducationAssignmentRecipient>]`: educationAssignmentRecipient
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Categories <IMicrosoftGraphEducationCategory[]>]`: When set, enables users to easily find assignments of a given type.  Read-only. Nullable.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[DisplayName <String>]`: Unique identifier for the category.
  - `[ClassId <String>]`: Class which this assignment belongs.
  - `[CloseDateTime <DateTime?>]`: Date when the assignment will be closed for submissions. This is an optional field that can be null if the assignment does not allowLateSubmissions or when the closeDateTime is the same as the dueDateTime. But if specified, then the closeDateTime must be greater than or equal to the dueDateTime. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[DisplayName <String>]`: Name of the assignment.
  - `[DueDateTime <DateTime?>]`: Date when the students assignment is due.  The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[Grading <IMicrosoftGraphEducationAssignmentGradeType>]`: educationAssignmentGradeType
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Instructions <IMicrosoftGraphEducationItemBody>]`: educationItemBody
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Content <String>]`: 
    - `[ContentType <String>]`: bodyType
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[NotificationChannelUrl <String>]`: Optional field to specify the URL of the channel to post the assignment publish notification. If not specified or null, defaults to the General channel. This field only applies to assignments where the assignTo value is educationAssignmentClassRecipient. Updating the notificationChannelUrl isn't allowed after the assignment has been published.
  - `[Resources <IMicrosoftGraphEducationAssignmentResource[]>]`: Learning objects that are associated with this assignment.  Only teachers can modify this list. Nullable.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[DistributeForStudentWork <Boolean?>]`: Indicates whether this resource should be copied to each student submission for modification and submission. Required
    - `[Resource <IMicrosoftGraphEducationResource>]`: educationResource
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[DisplayName <String>]`: Display name of resource.
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[Rubric <IMicrosoftGraphEducationRubric>]`: educationRubric
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Description <IMicrosoftGraphEducationItemBody>]`: educationItemBody
    - `[DisplayName <String>]`: The name of this rubric.
    - `[Grading <IMicrosoftGraphEducationAssignmentGradeType>]`: educationAssignmentGradeType
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Levels <IMicrosoftGraphRubricLevel[]>]`: The collection of levels making up this rubric.
      - `[Description <IMicrosoftGraphEducationItemBody>]`: educationItemBody
      - `[DisplayName <String>]`: The name of this rubric level.
      - `[Grading <IMicrosoftGraphEducationAssignmentGradeType>]`: educationAssignmentGradeType
      - `[LevelId <String>]`: The ID of this resource.
    - `[Qualities <IMicrosoftGraphRubricQuality[]>]`: The collection of qualities making up this rubric.
      - `[Criteria <IMicrosoftGraphRubricCriterion[]>]`: The collection of criteria for this rubric quality.
        - `[Description <IMicrosoftGraphEducationItemBody>]`: educationItemBody
      - `[Description <IMicrosoftGraphEducationItemBody>]`: educationItemBody
      - `[DisplayName <String>]`: The name of this rubric quality.
      - `[QualityId <String>]`: The ID of this resource.
      - `[Weight <Single?>]`: If present, a numerical weight for this quality.  Weights must add up to 100.
  - `[Status <String>]`: educationAssignmentStatus
  - `[Submissions <IMicrosoftGraphEducationSubmission[]>]`: Once published, there is a submission object for each student representing their work and grade.  Read-only. Nullable.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Outcomes <IMicrosoftGraphEducationOutcome[]>]`: 
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: The moment in time when the resource was last modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2021 is 2021-01-01T00:00:00Z.
    - `[ReassignedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Recipient <IMicrosoftGraphEducationSubmissionRecipient>]`: educationSubmissionRecipient
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Resources <IMicrosoftGraphEducationSubmissionResource[]>]`: 
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[AssignmentResourceUrl <String>]`: Pointer to the assignment from which this resource was copied. If this is null, the student uploaded the resource.
      - `[Resource <IMicrosoftGraphEducationResource>]`: educationResource
    - `[ReturnedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Status <String>]`: educationSubmissionStatus
    - `[SubmittedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[SubmittedResources <IMicrosoftGraphEducationSubmissionResource[]>]`: 
    - `[UnsubmittedBy <IMicrosoftGraphIdentitySet>]`: identitySet

`CATEGORIES <IMicrosoftGraphEducationCategory[]>`: When set, enables users to easily find assignments of a given type. Read-only. Nullable.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[DisplayName <String>]`: Unique identifier for the category.

`CREATEDBY <IMicrosoftGraphIdentitySet>`: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

`INPUTOBJECT <IEducationIdentity>`: Identity Parameter
  - `[EducationAssignmentId <String>]`: The unique identifier of educationAssignment
  - `[EducationAssignmentResourceId <String>]`: The unique identifier of educationAssignmentResource
  - `[EducationCategoryId <String>]`: The unique identifier of educationCategory
  - `[EducationClassId <String>]`: The unique identifier of educationClass
  - `[EducationOutcomeId <String>]`: The unique identifier of educationOutcome
  - `[EducationRubricId <String>]`: The unique identifier of educationRubric
  - `[EducationSchoolId <String>]`: The unique identifier of educationSchool
  - `[EducationSubmissionId <String>]`: The unique identifier of educationSubmission
  - `[EducationSubmissionResourceId <String>]`: The unique identifier of educationSubmissionResource
  - `[EducationUserId <String>]`: The unique identifier of educationUser

`INSTRUCTIONS <IMicrosoftGraphEducationItemBody>`: educationItemBody
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Content <String>]`: 
  - `[ContentType <String>]`: bodyType

`LASTMODIFIEDBY <IMicrosoftGraphIdentitySet>`: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

`RESOURCES <IMicrosoftGraphEducationAssignmentResource[]>`: Learning objects that are associated with this assignment. Only teachers can modify this list. Nullable.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[DistributeForStudentWork <Boolean?>]`: Indicates whether this resource should be copied to each student submission for modification and submission. Required
  - `[Resource <IMicrosoftGraphEducationResource>]`: educationResource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[DisplayName <String>]`: Display name of resource.
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet

`RUBRIC <IMicrosoftGraphEducationRubric>`: educationRubric
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[Description <IMicrosoftGraphEducationItemBody>]`: educationItemBody
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Content <String>]`: 
    - `[ContentType <String>]`: bodyType
  - `[DisplayName <String>]`: The name of this rubric.
  - `[Grading <IMicrosoftGraphEducationAssignmentGradeType>]`: educationAssignmentGradeType
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[Levels <IMicrosoftGraphRubricLevel[]>]`: The collection of levels making up this rubric.
    - `[Description <IMicrosoftGraphEducationItemBody>]`: educationItemBody
    - `[DisplayName <String>]`: The name of this rubric level.
    - `[Grading <IMicrosoftGraphEducationAssignmentGradeType>]`: educationAssignmentGradeType
    - `[LevelId <String>]`: The ID of this resource.
  - `[Qualities <IMicrosoftGraphRubricQuality[]>]`: The collection of qualities making up this rubric.
    - `[Criteria <IMicrosoftGraphRubricCriterion[]>]`: The collection of criteria for this rubric quality.
      - `[Description <IMicrosoftGraphEducationItemBody>]`: educationItemBody
    - `[Description <IMicrosoftGraphEducationItemBody>]`: educationItemBody
    - `[DisplayName <String>]`: The name of this rubric quality.
    - `[QualityId <String>]`: The ID of this resource.
    - `[Weight <Single?>]`: If present, a numerical weight for this quality.  Weights must add up to 100.

`SUBMISSIONS <IMicrosoftGraphEducationSubmission[]>`: Once published, there is a submission object for each student representing their work and grade. Read-only. Nullable.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Outcomes <IMicrosoftGraphEducationOutcome[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[LastModifiedDateTime <DateTime?>]`: The moment in time when the resource was last modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2021 is 2021-01-01T00:00:00Z.
  - `[ReassignedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[Recipient <IMicrosoftGraphEducationSubmissionRecipient>]`: educationSubmissionRecipient
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Resources <IMicrosoftGraphEducationSubmissionResource[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[AssignmentResourceUrl <String>]`: Pointer to the assignment from which this resource was copied. If this is null, the student uploaded the resource.
    - `[Resource <IMicrosoftGraphEducationResource>]`: educationResource
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[DisplayName <String>]`: Display name of resource.
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[ReturnedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[Status <String>]`: educationSubmissionStatus
  - `[SubmittedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[SubmittedResources <IMicrosoftGraphEducationSubmissionResource[]>]`: 
  - `[UnsubmittedBy <IMicrosoftGraphIdentitySet>]`: identitySet

## RELATED LINKS

