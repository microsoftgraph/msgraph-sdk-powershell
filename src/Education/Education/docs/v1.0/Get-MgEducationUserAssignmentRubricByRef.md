---
external help file:
Module Name: Microsoft.Graph.Education
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.education/get-mgeducationuserassignmentrubricbyref
schema: 2.0.0
---

# Get-MgEducationUserAssignmentRubricByRef

## SYNOPSIS
Get the educationRubric object attached to an educationAssignment, if one exists.
Only teachers, students, and applications with application permissions can perform this operation.

## SYNTAX

### Get1 (Default)
```
Get-MgEducationUserAssignmentRubricByRef -EducationAssignmentId <String> -EducationUserId <String>
 [<CommonParameters>]
```

### GetViaIdentity1
```
Get-MgEducationUserAssignmentRubricByRef -InputObject <IEducationIdentity> [<CommonParameters>]
```

## DESCRIPTION
Get the educationRubric object attached to an educationAssignment, if one exists.
Only teachers, students, and applications with application permissions can perform this operation.

## EXAMPLES

## PARAMETERS

### -EducationAssignmentId
The unique identifier of educationAssignment

```yaml
Type: System.String
Parameter Sets: Get1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EducationUserId
The unique identifier of educationUser

```yaml
Type: System.String
Parameter Sets: Get1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IEducationIdentity
Parameter Sets: GetViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IEducationIdentity

## OUTPUTS

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IEducationIdentity>: Identity Parameter
  - `[EducationAssignmentId <String>]`: The unique identifier of educationAssignment
  - `[EducationAssignmentResourceId <String>]`: The unique identifier of educationAssignmentResource
  - `[EducationCategoryId <String>]`: The unique identifier of educationCategory
  - `[EducationClassId <String>]`: The unique identifier of educationClass
  - `[EducationOutcomeId <String>]`: The unique identifier of educationOutcome
  - `[EducationRubricId <String>]`: The unique identifier of educationRubric
  - `[EducationSchoolId <String>]`: The unique identifier of educationSchool
  - `[EducationSubmissionId <String>]`: The unique identifier of educationSubmission
  - `[EducationSubmissionResourceId <String>]`: The unique identifier of educationSubmissionResource
  - `[EducationSynchronizationErrorId <String>]`: The unique identifier of educationSynchronizationError
  - `[EducationSynchronizationProfileId <String>]`: The unique identifier of educationSynchronizationProfile
  - `[EducationUserId <String>]`: The unique identifier of educationUser

## RELATED LINKS

