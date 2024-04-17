---
external help file:
Module Name: Microsoft.Graph.Beta.Education
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.education/update-mgbetaeducationclassassignmentsetting
schema: 2.0.0
---

# Update-MgBetaEducationClassAssignmentSetting

## SYNOPSIS
Update the properties of an educationAssignmentSettings object.
Only teachers can update these settings.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaEducationClassAssignmentSetting -EducationClassId <String> [-AdditionalProperties <Hashtable>]
 [-DefaultGradingScheme <IMicrosoftGraphEducationGradingScheme>]
 [-GradingCategories <IMicrosoftGraphEducationGradingCategory[]>]
 [-GradingSchemes <IMicrosoftGraphEducationGradingScheme[]>] [-Id <String>]
 [-ResponseHeadersVariable <String>] [-SubmissionAnimationDisabled] [-Headers <IDictionary>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaEducationClassAssignmentSetting -EducationClassId <String>
 -BodyParameter <IMicrosoftGraphEducationAssignmentSettings> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaEducationClassAssignmentSetting -InputObject <IEducationIdentity>
 -BodyParameter <IMicrosoftGraphEducationAssignmentSettings> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaEducationClassAssignmentSetting -InputObject <IEducationIdentity>
 [-AdditionalProperties <Hashtable>] [-DefaultGradingScheme <IMicrosoftGraphEducationGradingScheme>]
 [-GradingCategories <IMicrosoftGraphEducationGradingCategory[]>]
 [-GradingSchemes <IMicrosoftGraphEducationGradingScheme[]>] [-Id <String>]
 [-ResponseHeadersVariable <String>] [-SubmissionAnimationDisabled] [-Headers <IDictionary>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the properties of an educationAssignmentSettings object.
Only teachers can update these settings.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Education
```

$params = @{
	submissionAnimationDisabled = $true
}

Update-MgBetaEducationClassAssignmentSetting -EducationClassId $educationClassId -BodyParameter $params

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Education
```

$params = @{
	gradingCategories = @(
		@{
			displayName = "Lab"
			percentageWeight = 10
		}
		@{
			displayName = "Homework"
			percentageWeight = 80
		}
		@{
			displayName = "Test"
			percentageWeight = 10
		}
	)
}

Update-MgBetaEducationClassAssignmentSetting -EducationClassId $educationClassId -BodyParameter $params

### -------------------------- EXAMPLE 3 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Education
```

$params = @{
	"gradingCategories@delta" = @(
		@{
			id = "fb859cd3-943b-4cd6-9bbe-fe1c39eace0e"
			displayName = "Lab Test"
		}
		@{
			"@odata.context" = "https://graph.microsoft.com/beta/$metadata#gradingCategories/$deletedEntity"
			id = "e2a86277-24f9-4f29-8196-8c83fc69d00d"
			reason = "deleted"
		}
		@{
			displayName = "Lab Practice"
			percentageWeight = 
		}
		@{
			displayName = "Lab Theory"
			percentageWeight = 
		}
	)
}

Update-MgBetaEducationClassAssignmentSetting -EducationClassId $educationClassId -BodyParameter $params

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
educationAssignmentSettings
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEducationAssignmentSettings
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DefaultGradingScheme
educationGradingScheme
To construct, see NOTES section for DEFAULTGRADINGSCHEME properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEducationGradingScheme
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EducationClassId
The unique identifier of educationClass

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

### -GradingCategories
When set, enables users to weight assignments differently when computing a class average grade.
To construct, see NOTES section for GRADINGCATEGORIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEducationGradingCategory[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GradingSchemes
.
To construct, see NOTES section for GRADINGSCHEMES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEducationGradingScheme[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IEducationIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubmissionAnimationDisabled
Indicates whether turn-in celebration animation will be shown.
If true, the animation won't be shown.
The default value is false.

```yaml
Type: System.Management.Automation.SwitchParameter
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

### Microsoft.Graph.Beta.PowerShell.Models.IEducationIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEducationAssignmentSettings

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEducationAssignmentSettings

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphEducationAssignmentSettings>`: educationAssignmentSettings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DefaultGradingScheme <IMicrosoftGraphEducationGradingScheme>]`: educationGradingScheme
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DisplayName <String>]`: The name of the grading scheme.
    - `[Grades <IMicrosoftGraphEducationGradingSchemeGrade[]>]`: The grades that make up the scheme.
      - `[DefaultPercentage <Single?>]`: The midpoint of the grade range.
      - `[DisplayName <String>]`: The name of the grading scheme.
      - `[MinPercentage <Single?>]`: The minimum percentage of the total points needed to achieve this grade.
    - `[HidePointsDuringGrading <Boolean?>]`: The display setting for the UI. Indicates whether teachers can grade with points in addition to letter grades.
  - `[GradingCategories <IMicrosoftGraphEducationGradingCategory[]>]`: When set, enables users to weight assignments differently when computing a class average grade.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DisplayName <String>]`: The name of the grading category.
    - `[PercentageWeight <Int32?>]`: The weight of the category; an integer between 0 and 100.
  - `[GradingSchemes <IMicrosoftGraphEducationGradingScheme[]>]`: 
  - `[SubmissionAnimationDisabled <Boolean?>]`: Indicates whether turn-in celebration animation will be shown. If true, the animation won't be shown. The default value is false.

`DEFAULTGRADINGSCHEME <IMicrosoftGraphEducationGradingScheme>`: educationGradingScheme
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DisplayName <String>]`: The name of the grading scheme.
  - `[Grades <IMicrosoftGraphEducationGradingSchemeGrade[]>]`: The grades that make up the scheme.
    - `[DefaultPercentage <Single?>]`: The midpoint of the grade range.
    - `[DisplayName <String>]`: The name of the grading scheme.
    - `[MinPercentage <Single?>]`: The minimum percentage of the total points needed to achieve this grade.
  - `[HidePointsDuringGrading <Boolean?>]`: The display setting for the UI. Indicates whether teachers can grade with points in addition to letter grades.

`GRADINGCATEGORIES <IMicrosoftGraphEducationGradingCategory[]>`: When set, enables users to weight assignments differently when computing a class average grade.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DisplayName <String>]`: The name of the grading category.
  - `[PercentageWeight <Int32?>]`: The weight of the category; an integer between 0 and 100.

`GRADINGSCHEMES <IMicrosoftGraphEducationGradingScheme[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DisplayName <String>]`: The name of the grading scheme.
  - `[Grades <IMicrosoftGraphEducationGradingSchemeGrade[]>]`: The grades that make up the scheme.
    - `[DefaultPercentage <Single?>]`: The midpoint of the grade range.
    - `[DisplayName <String>]`: The name of the grading scheme.
    - `[MinPercentage <Single?>]`: The minimum percentage of the total points needed to achieve this grade.
  - `[HidePointsDuringGrading <Boolean?>]`: The display setting for the UI. Indicates whether teachers can grade with points in addition to letter grades.

`INPUTOBJECT <IEducationIdentity>`: Identity Parameter
  - `[EducationAssignmentId <String>]`: The unique identifier of educationAssignment
  - `[EducationAssignmentResourceId <String>]`: The unique identifier of educationAssignmentResource
  - `[EducationAssignmentResourceId1 <String>]`: The unique identifier of educationAssignmentResource
  - `[EducationCategoryId <String>]`: The unique identifier of educationCategory
  - `[EducationClassId <String>]`: The unique identifier of educationClass
  - `[EducationGradingCategoryId <String>]`: The unique identifier of educationGradingCategory
  - `[EducationGradingSchemeId <String>]`: The unique identifier of educationGradingScheme
  - `[EducationModuleId <String>]`: The unique identifier of educationModule
  - `[EducationModuleResourceId <String>]`: The unique identifier of educationModuleResource
  - `[EducationOutcomeId <String>]`: The unique identifier of educationOutcome
  - `[EducationRubricId <String>]`: The unique identifier of educationRubric
  - `[EducationSchoolId <String>]`: The unique identifier of educationSchool
  - `[EducationSubmissionId <String>]`: The unique identifier of educationSubmission
  - `[EducationSubmissionResourceId <String>]`: The unique identifier of educationSubmissionResource
  - `[EducationSubmissionResourceId1 <String>]`: The unique identifier of educationSubmissionResource
  - `[EducationSynchronizationErrorId <String>]`: The unique identifier of educationSynchronizationError
  - `[EducationSynchronizationProfileId <String>]`: The unique identifier of educationSynchronizationProfile
  - `[EducationUserId <String>]`: The unique identifier of educationUser

## RELATED LINKS

