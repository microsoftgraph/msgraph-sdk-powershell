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
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

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
Name of the configuration profile for syncing identities.

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
All errors associated with this synchronization profile.
To construct, please use Get-Help -Online and see NOTES section for ERRORS properties and create a hash table.

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
The date the profile should be considered expired and cease syncing.
Provide the date in YYYY-MM-DD format, following ISO 8601.
Maximum value is 18 months from profile creation.
(optional)

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
Determines if School Data Sync should automatically replace unsupported special characters while syncing from source.

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
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

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
License setup configuration.
To construct, please use Get-Help -Online and see NOTES section for LICENSESTOASSIGN properties and create a hash table.

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
To construct, please use Get-Help -Online and see NOTES section for PROFILESTATUS properties and create a hash table.

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
  - `[Id <String>]`: 
  - `[DataProvider <IMicrosoftGraphEducationSynchronizationDataProvider>]`: educationSynchronizationDataProvider
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: Name of the configuration profile for syncing identities.
  - `[Errors <IMicrosoftGraphEducationSynchronizationError[]>]`: All errors associated with this synchronization profile.
    - `[Id <String>]`: 
    - `[EntryType <String>]`: Represents the sync entity (school, section, student, teacher).
    - `[ErrorCode <String>]`: Represents the error code for this error.
    - `[ErrorMessage <String>]`: Contains a description of the error.
    - `[JoiningValue <String>]`: The unique identifier for the entry.
    - `[RecordedDateTime <DateTime?>]`: The time of occurrence of this error.
    - `[ReportableIdentifier <String>]`: The identifier of this error entry.
  - `[ExpirationDate <DateTime?>]`: The date the profile should be considered expired and cease syncing. Provide the date in YYYY-MM-DD format, following ISO 8601. Maximum value is 18 months from profile creation.  (optional)
  - `[HandleSpecialCharacterConstraint <Boolean?>]`: Determines if School Data Sync should automatically replace unsupported special characters while syncing from source.
  - `[IdentitySynchronizationConfiguration <IMicrosoftGraphEducationIdentitySynchronizationConfiguration>]`: educationIdentitySynchronizationConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[LicensesToAssign <IMicrosoftGraphEducationSynchronizationLicenseAssignment[]>]`: License setup configuration.
    - `[AppliesTo <String>]`: 
    - `[SkuIds <String[]>]`: Represents the SKU identifiers of the licenses to assign.
  - `[ProfileStatus <IMicrosoftGraphEducationSynchronizationProfileStatus>]`: educationSynchronizationProfileStatus
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[ErrorCount <Int64?>]`: Number of errors during synchronization.
    - `[LastActivityDateTime <DateTime?>]`: Represents the time when most recent changes were observed in profile.
    - `[LastSynchronizationDateTime <DateTime?>]`: Represents the time of the most recent successful  synchronization.
    - `[Status <String>]`: educationSynchronizationStatus
    - `[StatusMessage <String>]`: Status message for the current profile's synchronization stage.
  - `[State <String>]`: educationSynchronizationProfileState

ERRORS <IMicrosoftGraphEducationSynchronizationError[]>: All errors associated with this synchronization profile.
  - `[Id <String>]`: 
  - `[EntryType <String>]`: Represents the sync entity (school, section, student, teacher).
  - `[ErrorCode <String>]`: Represents the error code for this error.
  - `[ErrorMessage <String>]`: Contains a description of the error.
  - `[JoiningValue <String>]`: The unique identifier for the entry.
  - `[RecordedDateTime <DateTime?>]`: The time of occurrence of this error.
  - `[ReportableIdentifier <String>]`: The identifier of this error entry.

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

LICENSESTOASSIGN <IMicrosoftGraphEducationSynchronizationLicenseAssignment[]>: License setup configuration.
  - `[AppliesTo <String>]`: 
  - `[SkuIds <String[]>]`: Represents the SKU identifiers of the licenses to assign.

PROFILESTATUS <IMicrosoftGraphEducationSynchronizationProfileStatus>: educationSynchronizationProfileStatus
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[ErrorCount <Int64?>]`: Number of errors during synchronization.
  - `[LastActivityDateTime <DateTime?>]`: Represents the time when most recent changes were observed in profile.
  - `[LastSynchronizationDateTime <DateTime?>]`: Represents the time of the most recent successful  synchronization.
  - `[Status <String>]`: educationSynchronizationStatus
  - `[StatusMessage <String>]`: Status message for the current profile's synchronization stage.

## RELATED LINKS

