---
external help file:
Module Name: Microsoft.Graph.Education
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.education/update-mgeducationclassassignmentdefault
schema: 2.0.0
---

# Update-MgEducationClassAssignmentDefault

## SYNOPSIS
Update the properties of an educationAssignmentDefaults object.
Only teachers can update these settings.
This API is available in the following national cloud deployments.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgEducationClassAssignmentDefault -EducationClassId <String> [-AddedStudentAction <String>]
 [-AdditionalProperties <Hashtable>] [-AddToCalendarAction <String>] [-DueTime <String>] [-Id <String>]
 [-NotificationChannelUrl <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgEducationClassAssignmentDefault -EducationClassId <String>
 -BodyParameter <IMicrosoftGraphEducationAssignmentDefaults> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgEducationClassAssignmentDefault -InputObject <IEducationIdentity>
 -BodyParameter <IMicrosoftGraphEducationAssignmentDefaults> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgEducationClassAssignmentDefault -InputObject <IEducationIdentity> [-AddedStudentAction <String>]
 [-AdditionalProperties <Hashtable>] [-AddToCalendarAction <String>] [-DueTime <String>] [-Id <String>]
 [-NotificationChannelUrl <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the properties of an educationAssignmentDefaults object.
Only teachers can update these settings.
This API is available in the following national cloud deployments.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Education
```

$params = @{
	addedStudentAction = "assignIfOpen"
	notificationChannelUrl = "https://graph.microsoft.com/beta/teams('acdefc6b-2dc6-4e71-b1e9-6d9810ab1793')/channels('3da03fc4-8eac-4459-84fb-1422dc01f65e')"
}

Update-MgEducationClassAssignmentDefault -EducationClassId $educationClassId -BodyParameter $params

## PARAMETERS

### -AddedStudentAction
educationAddedStudentAction

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

### -AddToCalendarAction
educationAddToCalendarOptions

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

### -BodyParameter
educationAssignmentDefaults
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationAssignmentDefaults
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DueTime
Class-level default value for due time field.
Default value is 23:59:00.

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
Type: Microsoft.Graph.PowerShell.Models.IEducationIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -NotificationChannelUrl
Default Teams channel to which notifications will be sent.
Default value is null.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationAssignmentDefaults

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationAssignmentDefaults

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphEducationAssignmentDefaults>`: educationAssignmentDefaults
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AddToCalendarAction <String>]`: educationAddToCalendarOptions
  - `[AddedStudentAction <String>]`: educationAddedStudentAction
  - `[DueTime <String>]`: Class-level default value for due time field. Default value is 23:59:00.
  - `[NotificationChannelUrl <String>]`: Default Teams channel to which notifications will be sent. Default value is null.

`INPUTOBJECT <IEducationIdentity>`: Identity Parameter
  - `[EducationAssignmentId <String>]`: The unique identifier of educationAssignment
  - `[EducationAssignmentResourceId <String>]`: The unique identifier of educationAssignmentResource
  - `[EducationCategoryId <String>]`: The unique identifier of educationCategory
  - `[EducationClassId <String>]`: The unique identifier of educationClass
  - `[EducationOutcomeId <String>]`: The unique identifier of educationOutcome
  - `[EducationRubricId <String>]`: The unique identifier of educationRubric
  - `[EducationSchoolId <String>]`: The unique identifier of educationSchool
  - `[EducationSubmissionId <String>]`: The unique identifier of educationSubmission
  - `[EducationSubmissionResourceId <String>]`: The unique identifier of educationSubmissionResource
  - `[EducationUserId <String>]`: The unique identifier of educationUser

## RELATED LINKS

