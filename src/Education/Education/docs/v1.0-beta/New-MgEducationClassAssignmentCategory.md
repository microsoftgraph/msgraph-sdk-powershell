---
external help file:
Module Name: Microsoft.Graph.Beta.Education
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.education/new-mgeducationclassassignmentcategory
schema: 2.0.0
---

# New-MgBetaEducationClassAssignmentCategory

## SYNOPSIS
Create new navigation property to categories for education

## SYNTAX

### CreateExpanded3 (Default)
```
New-MgBetaEducationClassAssignmentCategory -EducationClassId <String> [-AdditionalProperties <Hashtable>]
 [-DisplayName <String>] [-Id <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaEducationClassAssignmentCategory -EducationAssignmentId <String> -EducationClassId <String>
 -BodyParameter <IMicrosoftGraphEducationCategory> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create3
```
New-MgBetaEducationClassAssignmentCategory -EducationClassId <String>
 -BodyParameter <IMicrosoftGraphEducationCategory> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateExpanded
```
New-MgBetaEducationClassAssignmentCategory -EducationAssignmentId <String> -EducationClassId <String>
 [-AdditionalProperties <Hashtable>] [-DisplayName <String>] [-Id <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgBetaEducationClassAssignmentCategory -InputObject <IEducationIdentity>
 -BodyParameter <IMicrosoftGraphEducationCategory> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity3
```
New-MgBetaEducationClassAssignmentCategory -InputObject <IEducationIdentity>
 -BodyParameter <IMicrosoftGraphEducationCategory> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgBetaEducationClassAssignmentCategory -InputObject <IEducationIdentity> [-AdditionalProperties <Hashtable>]
 [-DisplayName <String>] [-Id <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded3
```
New-MgBetaEducationClassAssignmentCategory -InputObject <IEducationIdentity> [-AdditionalProperties <Hashtable>]
 [-DisplayName <String>] [-Id <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to categories for education

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateExpanded3, CreateViaIdentityExpanded, CreateViaIdentityExpanded3
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEducationCategory
Parameter Sets: Create, Create3, CreateViaIdentity, CreateViaIdentity3
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
Parameter Sets: CreateExpanded, CreateExpanded3, CreateViaIdentityExpanded, CreateViaIdentityExpanded3
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
Parameter Sets: Create, CreateExpanded
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
Parameter Sets: Create, Create3, CreateExpanded, CreateExpanded3
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique idenfier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateExpanded3, CreateViaIdentityExpanded, CreateViaIdentityExpanded3
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IEducationIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentity3, CreateViaIdentityExpanded, CreateViaIdentityExpanded3
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEducationCategory

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEducationCategory

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphEducationCategory>: educationCategory
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
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

