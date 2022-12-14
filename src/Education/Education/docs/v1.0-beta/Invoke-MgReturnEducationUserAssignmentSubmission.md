---
external help file:
Module Name: Microsoft.Graph.Beta.Education
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.education/invoke-mgreturneducationuserassignmentsubmission
schema: 2.0.0
---

# Invoke-MgBetaReturnEducationUserAssignmentSubmission

## SYNOPSIS
Make the grade and feedback associated with this submission available to the student.
This will change the status of the submission from 'submitted' to 'returned' and indicates that feedback is provided or grading is done.
This action can only be done by the teacher.

## SYNTAX

### Return (Default)
```
Invoke-MgBetaReturnEducationUserAssignmentSubmission -EducationAssignmentId <String>
 -EducationSubmissionId <String> -EducationUserId <String> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ReturnViaIdentity
```
Invoke-MgBetaReturnEducationUserAssignmentSubmission -InputObject <IEducationIdentity> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Make the grade and feedback associated with this submission available to the student.
This will change the status of the submission from 'submitted' to 'returned' and indicates that feedback is provided or grading is done.
This action can only be done by the teacher.

## EXAMPLES

### Example 1: Code snippet
```powershell
Import-Module Microsoft.Graph.Beta.Education

Invoke-MgBetaReturnEducationClassAssignmentSubmission -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId -EducationSubmissionId $educationSubmissionId
```

This example shows how to use the Invoke-MgBetaReturnEducationUserAssignmentSubmission Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -EducationAssignmentId
key: id of educationAssignment

```yaml
Type: System.String
Parameter Sets: Return
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
Parameter Sets: Return
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
Parameter Sets: Return
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
Parameter Sets: ReturnViaIdentity
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

