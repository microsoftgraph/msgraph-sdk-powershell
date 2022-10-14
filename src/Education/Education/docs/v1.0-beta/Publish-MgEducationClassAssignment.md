---
external help file:
Module Name: Microsoft.Graph.Education
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.education/publish-mgeducationclassassignment
schema: 2.0.0
---

# Publish-MgEducationClassAssignment

## SYNOPSIS
Change the state of an educationAssignment from its original `draft` status to the `published` status.
You can change the state from `draft` to `scheduled` if the **assignment** is scheduled for a future date.
Only a teacher in the class can make this call.
When an **assignment** is in draft status, students will not see the **assignment**, nor will there be any submission objects.
When you call this API, educationSubmission objects are created and the assignment appears in the student's list.
The state of the **assignment** goes back to `draft` if there is any backend failure during publish process.
To update the properties of a published **assignment**, see update an assignment.
To update the properties of a published assignment, see update an assignment.

## SYNTAX

### Publish (Default)
```
Publish-MgEducationClassAssignment -EducationAssignmentId <String> -EducationClassId <String> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### PublishViaIdentity
```
Publish-MgEducationClassAssignment -InputObject <IEducationIdentity> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Change the state of an educationAssignment from its original `draft` status to the `published` status.
You can change the state from `draft` to `scheduled` if the **assignment** is scheduled for a future date.
Only a teacher in the class can make this call.
When an **assignment** is in draft status, students will not see the **assignment**, nor will there be any submission objects.
When you call this API, educationSubmission objects are created and the assignment appears in the student's list.
The state of the **assignment** goes back to `draft` if there is any backend failure during publish process.
To update the properties of a published **assignment**, see update an assignment.
To update the properties of a published assignment, see update an assignment.

## EXAMPLES

### Example 1: Using the Publish-MgEducationClassAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
Publish-MgEducationClassAssignment -EducationClassId $educationClassId -EducationAssignmentId $educationAssignmentId
```

This example shows how to use the Publish-MgEducationClassAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -EducationAssignmentId
key: id of educationAssignment

```yaml
Type: System.String
Parameter Sets: Publish
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EducationClassId
key: id of educationClass

```yaml
Type: System.String
Parameter Sets: Publish
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
Parameter Sets: PublishViaIdentity
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

### Microsoft.Graph.PowerShell.Models.IEducationIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationAssignment

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

