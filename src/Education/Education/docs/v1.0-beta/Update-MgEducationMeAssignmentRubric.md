---
external help file:
Module Name: Microsoft.Graph.Education
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.education/update-mgeducationmeassignmentrubric
schema: 2.0.0
---

# Update-MgEducationMeAssignmentRubric

## SYNOPSIS
Update the navigation property rubric in education

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgEducationMeAssignmentRubric -EducationAssignmentId <String> [-CreatedBy <IMicrosoftGraphIdentitySet>]
 [-CreatedDateTime <DateTime>] [-DescriptionContent <String>] [-DescriptionContentType <String>]
 [-DisplayName <String>] [-Grading <IMicrosoftGraphEducationAssignmentGradeType>] [-Id <String>]
 [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-LastModifiedDateTime <DateTime>]
 [-Levels <IMicrosoftGraphRubricLevel[]>] [-Qualities <IMicrosoftGraphRubricQuality[]>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgEducationMeAssignmentRubric -EducationAssignmentId <String>
 -BodyParameter <IMicrosoftGraphEducationRubric> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgEducationMeAssignmentRubric -InputObject <IEducationIdentity>
 -BodyParameter <IMicrosoftGraphEducationRubric> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgEducationMeAssignmentRubric -InputObject <IEducationIdentity>
 [-CreatedBy <IMicrosoftGraphIdentitySet>] [-CreatedDateTime <DateTime>] [-DescriptionContent <String>]
 [-DescriptionContentType <String>] [-DisplayName <String>]
 [-Grading <IMicrosoftGraphEducationAssignmentGradeType>] [-Id <String>]
 [-LastModifiedBy <IMicrosoftGraphIdentitySet>] [-LastModifiedDateTime <DateTime>]
 [-Levels <IMicrosoftGraphRubricLevel[]>] [-Qualities <IMicrosoftGraphRubricQuality[]>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property rubric in education

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

### -BodyParameter
educationRubric
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationRubric
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedBy
identitySet
To construct, see NOTES section for CREATEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
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

### -DescriptionContent
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

### -DescriptionContentType
bodyType

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

### -EducationAssignmentId
key: educationAssignment-id of educationAssignment

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

### -Grading
educationAssignmentGradeType

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationAssignmentGradeType
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
Type: Microsoft.Graph.PowerShell.Models.IEducationIdentity
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
To construct, see NOTES section for LASTMODIFIEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentitySet
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

### -Levels
.
To construct, see NOTES section for LEVELS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRubricLevel[]
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

### -Qualities
.
To construct, see NOTES section for QUALITIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRubricQuality[]
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

### Microsoft.Graph.PowerShell.Models.IEducationIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationRubric

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphEducationRubric>: educationRubric
  - `[Id <String>]`: Read-only.
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
  - `[Grading <IMicrosoftGraphEducationAssignmentGradeType>]`: educationAssignmentGradeType
  - `[LastModifiedBy <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Levels <IMicrosoftGraphRubricLevel[]>]`: 
    - `[DescriptionContent <String>]`: 
    - `[DescriptionContentType <String>]`: bodyType
    - `[DisplayName <String>]`: 
    - `[Grading <IMicrosoftGraphEducationAssignmentGradeType>]`: educationAssignmentGradeType
    - `[LevelId <String>]`: 
  - `[Qualities <IMicrosoftGraphRubricQuality[]>]`: 
    - `[Criteria <IMicrosoftGraphRubricCriterion[]>]`: 
      - `[DescriptionContent <String>]`: 
      - `[DescriptionContentType <String>]`: bodyType
    - `[DescriptionContent <String>]`: 
    - `[DescriptionContentType <String>]`: bodyType
    - `[DisplayName <String>]`: 
    - `[QualityId <String>]`: 
    - `[Weight <Single?>]`: 

CREATEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

INPUTOBJECT <IEducationIdentity>: Identity Parameter
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

LASTMODIFIEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

LEVELS <IMicrosoftGraphRubricLevel[]>: .
  - `[DescriptionContent <String>]`: 
  - `[DescriptionContentType <String>]`: bodyType
  - `[DisplayName <String>]`: 
  - `[Grading <IMicrosoftGraphEducationAssignmentGradeType>]`: educationAssignmentGradeType
  - `[LevelId <String>]`: 

QUALITIES <IMicrosoftGraphRubricQuality[]>: .
  - `[Criteria <IMicrosoftGraphRubricCriterion[]>]`: 
    - `[DescriptionContent <String>]`: 
    - `[DescriptionContentType <String>]`: bodyType
  - `[DescriptionContent <String>]`: 
  - `[DescriptionContentType <String>]`: bodyType
  - `[DisplayName <String>]`: 
  - `[QualityId <String>]`: 
  - `[Weight <Single?>]`: 

## RELATED LINKS

