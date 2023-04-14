---
external help file:
Module Name: Microsoft.Graph.Education
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.education/get-mgeducationclassassignmentdefault
schema: 2.0.0
---

# Get-MgEducationClassAssignmentDefault

## SYNOPSIS
Read the properties and relationships of an educationAssignmentDefaults object.
These are the class-level assignment defaults respected by new assignments created in the class.
Callers can continue to specify custom values on each **assignment** creation if they don't want the default behaviors.
Only teachers can perform this operation.

## SYNTAX

### Get1 (Default)
```
Get-MgEducationClassAssignmentDefault -EducationClassId <String> [-ExpandProperty <String[]>]
 [-Property <String[]>] [<CommonParameters>]
```

### GetViaIdentity1
```
Get-MgEducationClassAssignmentDefault -InputObject <IEducationIdentity> [-ExpandProperty <String[]>]
 [-Property <String[]>] [<CommonParameters>]
```

## DESCRIPTION
Read the properties and relationships of an educationAssignmentDefaults object.
These are the class-level assignment defaults respected by new assignments created in the class.
Callers can continue to specify custom values on each **assignment** creation if they don't want the default behaviors.
Only teachers can perform this operation.

## EXAMPLES

### Example 1: Using the Get-MgEducationClassAssignmentDefault Cmdlet
```powershell
Import-Module Microsoft.Graph.Education
Get-MgEducationClassAssignmentDefault -EducationClassId $educationClassId
```

This example shows how to use the Get-MgEducationClassAssignmentDefault Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -EducationClassId
The unique identifier of educationClass

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

### -ExpandProperty
Expand related entities

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Expand

Required: False
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

### -Property
Select properties to be returned

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Select

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationAssignmentDefaults

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

