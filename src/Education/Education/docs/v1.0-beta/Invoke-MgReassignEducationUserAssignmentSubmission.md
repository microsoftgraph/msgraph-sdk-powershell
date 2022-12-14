---
external help file:
Module Name: Microsoft.Graph.Beta.Education
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.education/invoke-mgreassigneducationuserassignmentsubmission
schema: 2.0.0
---

# Invoke-MgBetaReassignEducationUserAssignmentSubmission

## SYNOPSIS
Reassign the submission to the student with feedback for review.
Only teachers can perform this action.
Include the `Prefer: include-unknown-enum-members` header when you call this method; otherwise, a reassigned submission will be treated as a returned submission.
This means that the `reassigned` status will be mapped to the `returned` status, and **reassignedDateTime** and **reassignedBy** properties will be mapped to **returnedDateTime** and **returnedBy** respectively.
If the header `Prefer: include-unknown-enum-members` is provided, a reassigned submission retains the `reassigned` status.
For details, see the examples section.

## SYNTAX

### Reassign (Default)
```
Invoke-MgBetaReassignEducationUserAssignmentSubmission -EducationAssignmentId <String>
 -EducationSubmissionId <String> -EducationUserId <String> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ReassignViaIdentity
```
Invoke-MgBetaReassignEducationUserAssignmentSubmission -InputObject <IEducationIdentity> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Reassign the submission to the student with feedback for review.
Only teachers can perform this action.
Include the `Prefer: include-unknown-enum-members` header when you call this method; otherwise, a reassigned submission will be treated as a returned submission.
This means that the `reassigned` status will be mapped to the `returned` status, and **reassignedDateTime** and **reassignedBy** properties will be mapped to **returnedDateTime** and **returnedBy** respectively.
If the header `Prefer: include-unknown-enum-members` is provided, a reassigned submission retains the `reassigned` status.
For details, see the examples section.

## EXAMPLES

## PARAMETERS

### -EducationAssignmentId
key: id of educationAssignment

```yaml
Type: System.String
Parameter Sets: Reassign
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EducationSubmissionId
key: id of educationSubmission

```yaml
Type: System.String
Parameter Sets: Reassign
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EducationUserId
key: id of educationUser

```yaml
Type: System.String
Parameter Sets: Reassign
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IEducationIdentity
Parameter Sets: ReassignViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEducationSubmission

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IEducationIdentity>: Identity Parameter
  - `[EducationAssignmentId <String>]`: key: id of educationAssignment
  - `[EducationAssignmentResourceId <String>]`: key: id of educationAssignmentResource
  - `[EducationCategoryId <String>]`: key: id of educationCategory
  - `[EducationClassId <String>]`: key: id of educationClass
  - `[EducationOutcomeId <String>]`: key: id of educationOutcome
  - `[EducationRubricId <String>]`: key: id of educationRubric
  - `[EducationSchoolId <String>]`: key: id of educationSchool
  - `[EducationSubmissionId <String>]`: key: id of educationSubmission
  - `[EducationSubmissionResourceId <String>]`: key: id of educationSubmissionResource
  - `[EducationSynchronizationErrorId <String>]`: key: id of educationSynchronizationError
  - `[EducationSynchronizationProfileId <String>]`: key: id of educationSynchronizationProfile
  - `[EducationUserId <String>]`: key: id of educationUser

## RELATED LINKS

