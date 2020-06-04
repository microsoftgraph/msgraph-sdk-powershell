---
external help file:
Module Name: Microsoft.Graph.Education
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.education/new-mgeducationuserassignment
schema: 2.0.0
---

# New-MgEducationUserAssignment

## SYNOPSIS
Create new navigation property to assignments for education

## SYNTAX

### CreateExpanded (Default)
```
New-MgEducationUserAssignment -EducationUserId <String> [-AllowLateSubmissions]
 [-AllowStudentsToAddResourcesToSubmission] [-AssignDateTime <DateTime>] [-AssignedDateTime <DateTime>]
 [-AssignTo <IMicrosoftGraphEducationAssignmentRecipient>] [-Categories <IMicrosoftGraphEducationCategory[]>]
 [-ClassId <String>] [-CloseDateTime <DateTime>] [-CreatedBy <IMicrosoftGraphIdentitySet>]
 [-CreatedDateTime <DateTime>] [-DescriptionContent <String>] [-DescriptionContentType <String>]
 [-DisplayName <String>] [-DueDateTime <DateTime>] [-Grading <IMicrosoftGraphEducationAssignmentGradeType>]
 [-Id <String>] [-InstructionContent <String>] [-InstructionContentType <String>]
 [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-LastModifiedDateTime <DateTime>]
 [-Resources <IMicrosoftGraphEducationAssignmentResource[]>] [-RubricCreatedBy <IMicrosoftGraphIdentitySet>]
 [-RubricCreatedDateTime <DateTime>] [-RubricDisplayName <String>]
 [-RubricGrading <IMicrosoftGraphEducationAssignmentGradeType>] [-RubricId <String>]
 [-RubricLastModifiedBy <IMicrosoftGraphIdentitySet>] [-RubricLastModifiedDateTime <DateTime>]
 [-RubricLevels <IMicrosoftGraphRubricLevel[]>] [-RubricQualities <IMicrosoftGraphRubricQuality[]>]
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
New-MgEducationUserAssignment -InputObject <IEducationIdentity> [-AllowLateSubmissions]
 [-AllowStudentsToAddResourcesToSubmission] [-AssignDateTime <DateTime>] [-AssignedDateTime <DateTime>]
 [-AssignTo <IMicrosoftGraphEducationAssignmentRecipient>] [-Categories <IMicrosoftGraphEducationCategory[]>]
 [-ClassId <String>] [-CloseDateTime <DateTime>] [-CreatedBy <IMicrosoftGraphIdentitySet>]
 [-CreatedDateTime <DateTime>] [-DescriptionContent <String>] [-DescriptionContentType <String>]
 [-DisplayName <String>] [-DueDateTime <DateTime>] [-Grading <IMicrosoftGraphEducationAssignmentGradeType>]
 [-Id <String>] [-InstructionContent <String>] [-InstructionContentType <String>]
 [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-LastModifiedDateTime <DateTime>]
 [-Resources <IMicrosoftGraphEducationAssignmentResource[]>] [-RubricCreatedBy <IMicrosoftGraphIdentitySet>]
 [-RubricCreatedDateTime <DateTime>] [-RubricDisplayName <String>]
 [-RubricGrading <IMicrosoftGraphEducationAssignmentGradeType>] [-RubricId <String>]
 [-RubricLastModifiedBy <IMicrosoftGraphIdentitySet>] [-RubricLastModifiedDateTime <DateTime>]
 [-RubricLevels <IMicrosoftGraphRubricLevel[]>] [-RubricQualities <IMicrosoftGraphRubricQuality[]>]
 [-Status <String>] [-Submissions <IMicrosoftGraphEducationSubmission[]>] [-Confirm] [-WhatIf]
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

### -AllowLateSubmissions
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AllowStudentsToAddResourcesToSubmission
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AssignDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AssignedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AssignTo
educationAssignmentRecipient

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationAssignmentRecipient
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
```

### -Categories
.
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
Dynamic: False
```

### -ClassId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CloseDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
```

### -CreatedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DescriptionContent
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DescriptionContentType
bodyType

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DisplayName
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DueDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -EducationUserId
key: educationUser-id of educationUser

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Grading
educationAssignmentGradeType

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationAssignmentGradeType
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Id
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
Dynamic: False
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
Dynamic: False
```

### -InstructionContent
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InstructionContentType
bodyType

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
```

### -LastModifiedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Resources
.
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
Dynamic: False
```

### -RubricCreatedBy
identitySet
To construct, see NOTES section for RUBRICCREATEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RubricCreatedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RubricDisplayName
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RubricGrading
educationAssignmentGradeType

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationAssignmentGradeType
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RubricId
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
Dynamic: False
```

### -RubricLastModifiedBy
identitySet
To construct, see NOTES section for RUBRICLASTMODIFIEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RubricLastModifiedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RubricLevels
.
To construct, see NOTES section for RUBRICLEVELS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRubricLevel[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RubricQualities
.
To construct, see NOTES section for RUBRICQUALITIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRubricQuality[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
```

### -Submissions
.
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IEducationIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationAssignment

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationAssignment

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphEducationAssignment>: educationAssignment
  - `[Id <String>]`: Read-only.
  - `[AllowLateSubmissions <Boolean?>]`: 
  - `[AllowStudentsToAddResourcesToSubmission <Boolean?>]`: 
  - `[AssignDateTime <DateTime?>]`: 
  - `[AssignTo <IMicrosoftGraphEducationAssignmentRecipient>]`: educationAssignmentRecipient
  - `[AssignedDateTime <DateTime?>]`: 
  - `[Categories <IMicrosoftGraphEducationCategory[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: 
  - `[ClassId <String>]`: 
  - `[CloseDateTime <DateTime?>]`: 
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: 
  - `[DescriptionContent <String>]`: 
  - `[DescriptionContentType <String>]`: bodyType
  - `[DisplayName <String>]`: 
  - `[DueDateTime <DateTime?>]`: 
  - `[Grading <IMicrosoftGraphEducationAssignmentGradeType>]`: educationAssignmentGradeType
  - `[InstructionContent <String>]`: 
  - `[InstructionContentType <String>]`: bodyType
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Resources <IMicrosoftGraphEducationAssignmentResource[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DistributeForStudentWork <Boolean?>]`: 
    - `[ResourceCreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[ResourceCreatedDateTime <DateTime?>]`: 
    - `[ResourceDisplayName <String>]`: 
    - `[ResourceLastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[ResourceLastModifiedDateTime <DateTime?>]`: 
  - `[RubricCreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[RubricCreatedDateTime <DateTime?>]`: 
  - `[RubricDisplayName <String>]`: 
  - `[RubricGrading <IMicrosoftGraphEducationAssignmentGradeType>]`: educationAssignmentGradeType
  - `[RubricId <String>]`: Read-only.
  - `[RubricLastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[RubricLastModifiedDateTime <DateTime?>]`: 
  - `[RubricLevels <IMicrosoftGraphRubricLevel[]>]`: 
    - `[DescriptionContent <String>]`: 
    - `[DescriptionContentType <String>]`: bodyType
    - `[DisplayName <String>]`: 
    - `[Grading <IMicrosoftGraphEducationAssignmentGradeType>]`: educationAssignmentGradeType
    - `[LevelId <String>]`: 
  - `[RubricQualities <IMicrosoftGraphRubricQuality[]>]`: 
    - `[Criteria <IMicrosoftGraphRubricCriterion[]>]`: 
      - `[DescriptionContent <String>]`: 
      - `[DescriptionContentType <String>]`: bodyType
    - `[DescriptionContent <String>]`: 
    - `[DescriptionContentType <String>]`: bodyType
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
    - `[ReleasedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[ReleasedDateTime <DateTime?>]`: 
    - `[Resources <IMicrosoftGraphEducationSubmissionResource[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AssignmentResourceUrl <String>]`: 
      - `[ResourceCreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[ResourceCreatedDateTime <DateTime?>]`: 
      - `[ResourceDisplayName <String>]`: 
      - `[ResourceLastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[ResourceLastModifiedDateTime <DateTime?>]`: 
    - `[ResourcesFolderUrl <String>]`: 
    - `[ReturnedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[ReturnedDateTime <DateTime?>]`: 
    - `[Status <String>]`: educationSubmissionStatus
    - `[SubmittedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[SubmittedDateTime <DateTime?>]`: 
    - `[SubmittedResources <IMicrosoftGraphEducationSubmissionResource[]>]`: 
    - `[UnsubmittedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[UnsubmittedDateTime <DateTime?>]`: 

#### CATEGORIES <IMicrosoftGraphEducationCategory[]>: .
  - `[Id <String>]`: Read-only.
  - `[DisplayName <String>]`: 

#### CREATEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

#### INPUTOBJECT <IEducationIdentity>: Identity Parameter
  - `[EducationAssignmentId <String>]`: key: educationAssignment-id of educationAssignment
  - `[EducationAssignmentResourceId <String>]`: key: educationAssignmentResource-id of educationAssignmentResource
  - `[EducationCategoryId <String>]`: key: educationCategory-id of educationCategory
  - `[EducationClassId <String>]`: key: educationClass-id of educationClass
  - `[EducationOutcomeId <String>]`: key: educationOutcome-id of educationOutcome
  - `[EducationRubricId <String>]`: key: educationRubric-id of educationRubric
  - `[EducationSchoolId <String>]`: key: educationSchool-id of educationSchool
  - `[EducationSubmissionId <String>]`: key: educationSubmission-id of educationSubmission
  - `[EducationSubmissionResourceId <String>]`: key: educationSubmissionResource-id of educationSubmissionResource
  - `[EducationSynchronizationErrorId <String>]`: key: educationSynchronizationError-id of educationSynchronizationError
  - `[EducationSynchronizationProfileId <String>]`: key: educationSynchronizationProfile-id of educationSynchronizationProfile
  - `[EducationUserId <String>]`: key: educationUser-id of educationUser

#### LASTMODIFIEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

#### RESOURCES <IMicrosoftGraphEducationAssignmentResource[]>: .
  - `[Id <String>]`: Read-only.
  - `[DistributeForStudentWork <Boolean?>]`: 
  - `[ResourceCreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[ResourceCreatedDateTime <DateTime?>]`: 
  - `[ResourceDisplayName <String>]`: 
  - `[ResourceLastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[ResourceLastModifiedDateTime <DateTime?>]`: 

#### RUBRICCREATEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

#### RUBRICLASTMODIFIEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

#### RUBRICLEVELS <IMicrosoftGraphRubricLevel[]>: .
  - `[DescriptionContent <String>]`: 
  - `[DescriptionContentType <String>]`: bodyType
  - `[DisplayName <String>]`: 
  - `[Grading <IMicrosoftGraphEducationAssignmentGradeType>]`: educationAssignmentGradeType
  - `[LevelId <String>]`: 

#### RUBRICQUALITIES <IMicrosoftGraphRubricQuality[]>: .
  - `[Criteria <IMicrosoftGraphRubricCriterion[]>]`: 
    - `[DescriptionContent <String>]`: 
    - `[DescriptionContentType <String>]`: bodyType
  - `[DescriptionContent <String>]`: 
  - `[DescriptionContentType <String>]`: bodyType
  - `[DisplayName <String>]`: 
  - `[QualityId <String>]`: 
  - `[Weight <Single?>]`: 

#### SUBMISSIONS <IMicrosoftGraphEducationSubmission[]>: .
  - `[Id <String>]`: Read-only.
  - `[Outcomes <IMicrosoftGraphEducationOutcome[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Recipient <IMicrosoftGraphEducationSubmissionRecipient>]`: educationSubmissionRecipient
  - `[ReleasedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[ReleasedDateTime <DateTime?>]`: 
  - `[Resources <IMicrosoftGraphEducationSubmissionResource[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AssignmentResourceUrl <String>]`: 
    - `[ResourceCreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[ResourceCreatedDateTime <DateTime?>]`: 
    - `[ResourceDisplayName <String>]`: 
    - `[ResourceLastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[ResourceLastModifiedDateTime <DateTime?>]`: 
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

