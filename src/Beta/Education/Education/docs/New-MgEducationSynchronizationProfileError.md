---
external help file:
Module Name: Microsoft.Graph.Education
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.education/new-mgeducationsynchronizationprofileerror
schema: 2.0.0
---

# New-MgEducationSynchronizationProfileError

## SYNOPSIS
Create new navigation property to errors for education

## SYNTAX

### CreateExpanded (Default)
```
New-MgEducationSynchronizationProfileError -EducationSynchronizationProfileId <String> [-EntryType <String>]
 [-ErrorCode <String>] [-ErrorMessage <String>] [-Id <String>] [-JoiningValue <String>]
 [-RecordedDateTime <DateTime>] [-ReportableIdentifier <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgEducationSynchronizationProfileError -EducationSynchronizationProfileId <String>
 -BodyParameter <IMicrosoftGraphEducationSynchronizationError> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgEducationSynchronizationProfileError -InputObject <IEducationIdentity>
 -BodyParameter <IMicrosoftGraphEducationSynchronizationError> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgEducationSynchronizationProfileError -InputObject <IEducationIdentity> [-EntryType <String>]
 [-ErrorCode <String>] [-ErrorMessage <String>] [-Id <String>] [-JoiningValue <String>]
 [-RecordedDateTime <DateTime>] [-ReportableIdentifier <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to errors for education

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -BodyParameter
educationSynchronizationError
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationSynchronizationError
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -EducationSynchronizationProfileId
key: educationSynchronizationProfile-id of educationSynchronizationProfile

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -EntryType
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ErrorCode
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ErrorMessage
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Id
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IEducationIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -JoiningValue
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RecordedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ReportableIdentifier
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IEducationIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationSynchronizationError

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationSynchronizationError

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphEducationSynchronizationError>: educationSynchronizationError
  - `[Id <String>]`: Read-only.
  - `[EntryType <String>]`: 
  - `[ErrorCode <String>]`: 
  - `[ErrorMessage <String>]`: 
  - `[JoiningValue <String>]`: 
  - `[RecordedDateTime <DateTime?>]`: 
  - `[ReportableIdentifier <String>]`: 

#### INPUTOBJECT <IEducationIdentity>: Identity Parameter
  - `[EducationAssignmentId <String>]`: key: educationAssignment-id of educationAssignment
  - `[EducationAssignmentResourceId <String>]`: key: educationAssignmentResource-id of educationAssignmentResource
  - `[EducationCategoryId <String>]`: key: educationCategory-id of educationCategory
  - `[EducationClassId <String>]`: key: educationClass-id of educationClass
  - `[EducationOutcomeId <String>]`: key: educationOutcome-id of educationOutcome
  - `[EducationRubricId <String>]`: key: educationRubric-id of educationRubric
  - `[EducationSchoolId <String>]`: key: educationSchool-id of educationSchool
  - `[EducationSubmissionId <String>]`: key: educationSubmission-id of educationSubmission
  - `[EducationSubmissionResourceId <String>]`: key: educationSubmissionResource-id of educationSubmissionResource
  - `[EducationSynchronizationErrorId <String>]`: key: educationSynchronizationError-id of educationSynchronizationError
  - `[EducationSynchronizationProfileId <String>]`: key: educationSynchronizationProfile-id of educationSynchronizationProfile
  - `[EducationUserId <String>]`: key: educationUser-id of educationUser

## RELATED LINKS

