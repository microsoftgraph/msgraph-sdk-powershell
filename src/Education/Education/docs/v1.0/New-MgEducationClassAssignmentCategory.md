---
external help file:
Module Name: Microsoft.Graph.Education
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.education/new-mgeducationclassassignmentcategory
schema: 2.0.0
---

# New-MgEducationClassAssignmentCategory

## SYNOPSIS
Create new navigation property to assignmentCategories for education

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgEducationClassAssignmentCategory -EducationClassId <String> [-AdditionalProperties <Hashtable>]
 [-DisplayName <String>] [-Id <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgEducationClassAssignmentCategory -EducationClassId <String>
 -BodyParameter <IMicrosoftGraphEducationCategory> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create2
```
New-MgEducationClassAssignmentCategory -EducationAssignmentId <String> -EducationClassId <String>
 -BodyParameter <IMicrosoftGraphEducationCategory> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateExpanded2
```
New-MgEducationClassAssignmentCategory -EducationAssignmentId <String> -EducationClassId <String>
 [-AdditionalProperties <Hashtable>] [-DisplayName <String>] [-Id <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentity1
```
New-MgEducationClassAssignmentCategory -InputObject <IEducationIdentity>
 -BodyParameter <IMicrosoftGraphEducationCategory> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity2
```
New-MgEducationClassAssignmentCategory -InputObject <IEducationIdentity>
 -BodyParameter <IMicrosoftGraphEducationCategory> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded1
```
New-MgEducationClassAssignmentCategory -InputObject <IEducationIdentity> [-AdditionalProperties <Hashtable>]
 [-DisplayName <String>] [-Id <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded2
```
New-MgEducationClassAssignmentCategory -InputObject <IEducationIdentity> [-AdditionalProperties <Hashtable>]
 [-DisplayName <String>] [-Id <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to assignmentCategories for education

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded1, CreateExpanded2, CreateViaIdentityExpanded1, CreateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
educationCategory
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationCategory
Parameter Sets: Create1, Create2, CreateViaIdentity1, CreateViaIdentity2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
Unique identifier for the category.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateExpanded2, CreateViaIdentityExpanded1, CreateViaIdentityExpanded2
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EducationAssignmentId
key: id of educationAssignment

```yaml
Type: System.String
Parameter Sets: Create2, CreateExpanded2
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
Parameter Sets: Create1, Create2, CreateExpanded1, CreateExpanded2
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1, CreateExpanded2, CreateViaIdentityExpanded1, CreateViaIdentityExpanded2
Aliases:

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
Parameter Sets: CreateViaIdentity1, CreateViaIdentity2, CreateViaIdentityExpanded1, CreateViaIdentityExpanded2
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationCategory

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationCategory

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphEducationCategory>: educationCategory
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[DisplayName <String>]`: Unique identifier for the category.

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

