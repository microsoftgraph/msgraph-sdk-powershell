---
external help file:
Module Name: Microsoft.Graph.Education
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.education/update-mgeducationsynchronizationprofile
schema: 2.0.0
---

# Update-MgEducationSynchronizationProfile

## SYNOPSIS
Update the navigation property synchronizationProfiles in education

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgEducationSynchronizationProfile -EducationSynchronizationProfileId <String>
 [-AdditionalProperties <Hashtable>] [-DataProvider <Hashtable>] [-DisplayName <String>]
 [-Errors <IMicrosoftGraphEducationSynchronizationError[]>] [-ExpirationDate <DateTime>]
 [-HandleSpecialCharacterConstraint] [-Id <String>] [-IdentitySynchronizationConfiguration <Hashtable>]
 [-LicensesToAssign <IMicrosoftGraphEducationSynchronizationLicenseAssignment[]>]
 [-ProfileStatus <IMicrosoftGraphEducationSynchronizationProfileStatus>] [-State <String>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgEducationSynchronizationProfile -EducationSynchronizationProfileId <String>
 -BodyParameter <IMicrosoftGraphEducationSynchronizationProfile> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgEducationSynchronizationProfile -InputObject <IEducationIdentity>
 -BodyParameter <IMicrosoftGraphEducationSynchronizationProfile> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgEducationSynchronizationProfile -InputObject <IEducationIdentity> [-AdditionalProperties <Hashtable>]
 [-DataProvider <Hashtable>] [-DisplayName <String>]
 [-Errors <IMicrosoftGraphEducationSynchronizationError[]>] [-ExpirationDate <DateTime>]
 [-HandleSpecialCharacterConstraint] [-Id <String>] [-IdentitySynchronizationConfiguration <Hashtable>]
 [-LicensesToAssign <IMicrosoftGraphEducationSynchronizationLicenseAssignment[]>]
 [-ProfileStatus <IMicrosoftGraphEducationSynchronizationProfileStatus>] [-State <String>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property synchronizationProfiles in education

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
educationSynchronizationProfile
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationSynchronizationProfile
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DataProvider
educationSynchronizationDataProvider

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

### -DisplayName
.

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

### -EducationSynchronizationProfileId
key: id of educationSynchronizationProfile

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

### -Errors
.
To construct, see NOTES section for ERRORS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationSynchronizationError[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExpirationDate
.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HandleSpecialCharacterConstraint
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
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

### -IdentitySynchronizationConfiguration
educationIdentitySynchronizationConfiguration

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

### -LicensesToAssign
.
To construct, see NOTES section for LICENSESTOASSIGN properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationSynchronizationLicenseAssignment[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProfileStatus
educationSynchronizationProfileStatus
To construct, see NOTES section for PROFILESTATUS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationSynchronizationProfileStatus
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -State
educationSynchronizationProfileState

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationSynchronizationProfile

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphEducationSynchronizationProfile>: educationSynchronizationProfile
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[DataProvider <IMicrosoftGraphEducationSynchronizationDataProvider>]`: educationSynchronizationDataProvider
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: 
  - `[Errors <IMicrosoftGraphEducationSynchronizationError[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[EntryType <String>]`: 
    - `[ErrorCode <String>]`: 
    - `[ErrorMessage <String>]`: 
    - `[JoiningValue <String>]`: 
    - `[RecordedDateTime <DateTime?>]`: 
    - `[ReportableIdentifier <String>]`: 
  - `[ExpirationDate <DateTime?>]`: 
  - `[HandleSpecialCharacterConstraint <Boolean?>]`: 
  - `[IdentitySynchronizationConfiguration <IMicrosoftGraphEducationIdentitySynchronizationConfiguration>]`: educationIdentitySynchronizationConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[LicensesToAssign <IMicrosoftGraphEducationSynchronizationLicenseAssignment[]>]`: 
    - `[AppliesTo <String>]`: 
    - `[SkuIds <String[]>]`: 
  - `[ProfileStatus <IMicrosoftGraphEducationSynchronizationProfileStatus>]`: educationSynchronizationProfileStatus
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[LastSynchronizationDateTime <DateTime?>]`: 
    - `[Status <String>]`: educationSynchronizationStatus
  - `[State <String>]`: educationSynchronizationProfileState

ERRORS <IMicrosoftGraphEducationSynchronizationError[]>: .
  - `[Id <String>]`: Read-only.
  - `[EntryType <String>]`: 
  - `[ErrorCode <String>]`: 
  - `[ErrorMessage <String>]`: 
  - `[JoiningValue <String>]`: 
  - `[RecordedDateTime <DateTime?>]`: 
  - `[ReportableIdentifier <String>]`: 

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

LICENSESTOASSIGN <IMicrosoftGraphEducationSynchronizationLicenseAssignment[]>: .
  - `[AppliesTo <String>]`: 
  - `[SkuIds <String[]>]`: 

PROFILESTATUS <IMicrosoftGraphEducationSynchronizationProfileStatus>: educationSynchronizationProfileStatus
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[LastSynchronizationDateTime <DateTime?>]`: 
  - `[Status <String>]`: educationSynchronizationStatus

## RELATED LINKS

