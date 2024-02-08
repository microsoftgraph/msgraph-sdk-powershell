---
external help file:
Module Name: Microsoft.Graph.Beta.Education
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.education/update-mgbetaeducationclassassignmentcategory
schema: 2.0.0
---

# Update-MgBetaEducationClassAssignmentCategory

## SYNOPSIS
Update the navigation property assignmentCategories in education

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaEducationClassAssignmentCategory -EducationCategoryId <String> -EducationClassId <String>
 [-AdditionalProperties <Hashtable>] [-DisplayName <String>] [-Id <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgBetaEducationClassAssignmentCategory -EducationCategoryId <String> -EducationClassId <String>
 -BodyParameter <IMicrosoftGraphEducationCategory> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaEducationClassAssignmentCategory -InputObject <IEducationIdentity>
 -BodyParameter <IMicrosoftGraphEducationCategory> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaEducationClassAssignmentCategory -InputObject <IEducationIdentity>
 [-AdditionalProperties <Hashtable>] [-DisplayName <String>] [-Id <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property assignmentCategories in education

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

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
educationCategory
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEducationCategory
Parameter Sets: Update, UpdateViaIdentity
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EducationCategoryId
The unique identifier of educationCategory

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


`BODYPARAMETER <IMicrosoftGraphEducationCategory>`: educationCategory
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DisplayName <String>]`: Unique identifier for the category.

`INPUTOBJECT <IEducationIdentity>`: Identity Parameter
  - `[EducationAssignmentId <String>]`: The unique identifier of educationAssignment
  - `[EducationAssignmentResourceId <String>]`: The unique identifier of educationAssignmentResource
  - `[EducationAssignmentResourceId1 <String>]`: The unique identifier of educationAssignmentResource
  - `[EducationCategoryId <String>]`: The unique identifier of educationCategory
  - `[EducationClassId <String>]`: The unique identifier of educationClass
  - `[EducationGradingCategoryId <String>]`: The unique identifier of educationGradingCategory
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

