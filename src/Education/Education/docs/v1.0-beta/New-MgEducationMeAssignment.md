---
external help file:
Module Name: Microsoft.Graph.Education
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.education/new-mgeducationmeassignment
schema: 2.0.0
---

# New-MgEducationMeAssignment

## SYNOPSIS
Create new navigation property to assignments for education

## SYNTAX

### CreateExpanded (Default)
```
New-MgEducationMeAssignment [-AdditionalProperties <Hashtable>] [-AllowLateSubmissions]
 [-AllowStudentsToAddResourcesToSubmission] [-AssignDateTime <DateTime>] [-AssignedDateTime <DateTime>]
 [-AssignTo <Hashtable>] [-Categories <IMicrosoftGraphEducationCategory[]>] [-ClassId <String>]
 [-CloseDateTime <DateTime>] [-CreatedBy <IMicrosoftGraphIdentitySet>] [-CreatedDateTime <DateTime>]
 [-DisplayName <String>] [-DueDateTime <DateTime>] [-Grading <Hashtable>] [-Id <String>]
 [-Instructions <IMicrosoftGraphEducationItemBody>] [-LastModifiedBy <IMicrosoftGraphIdentitySet>]
 [-LastModifiedDateTime <DateTime>] [-Resources <IMicrosoftGraphEducationAssignmentResource[]>]
 [-Rubric <IMicrosoftGraphEducationRubric>] [-Status <String>]
 [-Submissions <IMicrosoftGraphEducationSubmission[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgEducationMeAssignment -BodyParameter <IMicrosoftGraphEducationAssignment> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to assignments for education

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

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowLateSubmissions
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowStudentsToAddResourcesToSubmission
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AssignDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AssignedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Categories
.
To construct, see NOTES section for CATEGORIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationCategory[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClassId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CloseDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DueDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Grading
educationAssignmentGradeType

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Instructions
educationItemBody
To construct, see NOTES section for INSTRUCTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationItemBody
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Resources
.
To construct, see NOTES section for RESOURCES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationAssignmentResource[]
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Submissions
.
To construct, see NOTES section for SUBMISSIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationSubmission[]
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationAssignment

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationAssignment

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphEducationAssignment>: educationAssignment
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[AllowLateSubmissions <Boolean?>]`: 
  - `[AllowStudentsToAddResourcesToSubmission <Boolean?>]`: 
  - `[AssignDateTime <DateTime?>]`: 
  - `[AssignTo <IMicrosoftGraphEducationAssignmentRecipient>]`: educationAssignmentRecipient
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AssignedDateTime <DateTime?>]`: 
  - `[Categories <IMicrosoftGraphEducationCategory[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: 
  - `[ClassId <String>]`: 
  - `[CloseDateTime <DateTime?>]`: 
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: 
  - `[DisplayName <String>]`: 
  - `[DueDateTime <DateTime?>]`: 
  - `[Grading <IMicrosoftGraphEducationAssignmentGradeType>]`: educationAssignmentGradeType
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Instructions <IMicrosoftGraphEducationItemBody>]`: educationItemBody
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Content <String>]`: 
    - `[ContentType <String>]`: bodyType
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Resources <IMicrosoftGraphEducationAssignmentResource[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DistributeForStudentWork <Boolean?>]`: 
    - `[Resource <IMicrosoftGraphEducationResource>]`: educationResource
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: 
      - `[DisplayName <String>]`: 
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Rubric <IMicrosoftGraphEducationRubric>]`: educationRubric
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Description <IMicrosoftGraphEducationItemBody>]`: educationItemBody
    - `[DisplayName <String>]`: 
    - `[Grading <IMicrosoftGraphEducationAssignmentGradeType>]`: educationAssignmentGradeType
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Levels <IMicrosoftGraphRubricLevel[]>]`: 
      - `[Description <IMicrosoftGraphEducationItemBody>]`: educationItemBody
      - `[DisplayName <String>]`: 
      - `[Grading <IMicrosoftGraphEducationAssignmentGradeType>]`: educationAssignmentGradeType
      - `[LevelId <String>]`: 
    - `[Qualities <IMicrosoftGraphRubricQuality[]>]`: 
      - `[Criteria <IMicrosoftGraphRubricCriterion[]>]`: 
        - `[Description <IMicrosoftGraphEducationItemBody>]`: educationItemBody
      - `[Description <IMicrosoftGraphEducationItemBody>]`: educationItemBody
      - `[DisplayName <String>]`: 
      - `[QualityId <String>]`: 
      - `[Weight <Single?>]`: 
  - `[Status <String>]`: educationAssignmentStatus
  - `[Submissions <IMicrosoftGraphEducationSubmission[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Outcomes <IMicrosoftGraphEducationOutcome[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Recipient <IMicrosoftGraphEducationSubmissionRecipient>]`: educationSubmissionRecipient
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ReleasedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[ReleasedDateTime <DateTime?>]`: 
    - `[Resources <IMicrosoftGraphEducationSubmissionResource[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AssignmentResourceUrl <String>]`: 
      - `[Resource <IMicrosoftGraphEducationResource>]`: educationResource
    - `[ResourcesFolderUrl <String>]`: 
    - `[ReturnedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[ReturnedDateTime <DateTime?>]`: 
    - `[Status <String>]`: educationSubmissionStatus
    - `[SubmittedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[SubmittedDateTime <DateTime?>]`: 
    - `[SubmittedResources <IMicrosoftGraphEducationSubmissionResource[]>]`: 
    - `[UnsubmittedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[UnsubmittedDateTime <DateTime?>]`: 

CATEGORIES <IMicrosoftGraphEducationCategory[]>: .
  - `[Id <String>]`: Read-only.
  - `[DisplayName <String>]`: 

CREATEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

INSTRUCTIONS <IMicrosoftGraphEducationItemBody>: educationItemBody
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Content <String>]`: 
  - `[ContentType <String>]`: bodyType

LASTMODIFIEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

RESOURCES <IMicrosoftGraphEducationAssignmentResource[]>: .
  - `[Id <String>]`: Read-only.
  - `[DistributeForStudentWork <Boolean?>]`: 
  - `[Resource <IMicrosoftGraphEducationResource>]`: educationResource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[CreatedDateTime <DateTime?>]`: 
    - `[DisplayName <String>]`: 
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[LastModifiedDateTime <DateTime?>]`: 

RUBRIC <IMicrosoftGraphEducationRubric>: educationRubric
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Description <IMicrosoftGraphEducationItemBody>]`: educationItemBody
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Content <String>]`: 
    - `[ContentType <String>]`: bodyType
  - `[DisplayName <String>]`: 
  - `[Grading <IMicrosoftGraphEducationAssignmentGradeType>]`: educationAssignmentGradeType
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Levels <IMicrosoftGraphRubricLevel[]>]`: 
    - `[Description <IMicrosoftGraphEducationItemBody>]`: educationItemBody
    - `[DisplayName <String>]`: 
    - `[Grading <IMicrosoftGraphEducationAssignmentGradeType>]`: educationAssignmentGradeType
    - `[LevelId <String>]`: 
  - `[Qualities <IMicrosoftGraphRubricQuality[]>]`: 
    - `[Criteria <IMicrosoftGraphRubricCriterion[]>]`: 
      - `[Description <IMicrosoftGraphEducationItemBody>]`: educationItemBody
    - `[Description <IMicrosoftGraphEducationItemBody>]`: educationItemBody
    - `[DisplayName <String>]`: 
    - `[QualityId <String>]`: 
    - `[Weight <Single?>]`: 

SUBMISSIONS <IMicrosoftGraphEducationSubmission[]>: .
  - `[Id <String>]`: Read-only.
  - `[Outcomes <IMicrosoftGraphEducationOutcome[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Recipient <IMicrosoftGraphEducationSubmissionRecipient>]`: educationSubmissionRecipient
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ReleasedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[ReleasedDateTime <DateTime?>]`: 
  - `[Resources <IMicrosoftGraphEducationSubmissionResource[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AssignmentResourceUrl <String>]`: 
    - `[Resource <IMicrosoftGraphEducationResource>]`: educationResource
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[CreatedDateTime <DateTime?>]`: 
      - `[DisplayName <String>]`: 
      - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[LastModifiedDateTime <DateTime?>]`: 
  - `[ResourcesFolderUrl <String>]`: 
  - `[ReturnedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[ReturnedDateTime <DateTime?>]`: 
  - `[Status <String>]`: educationSubmissionStatus
  - `[SubmittedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[SubmittedDateTime <DateTime?>]`: 
  - `[SubmittedResources <IMicrosoftGraphEducationSubmissionResource[]>]`: 
  - `[UnsubmittedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[UnsubmittedDateTime <DateTime?>]`: 

## RELATED LINKS

