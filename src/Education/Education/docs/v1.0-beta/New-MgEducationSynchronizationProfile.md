---
external help file:
Module Name: Microsoft.Graph.Education
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.education/new-mgeducationsynchronizationprofile
schema: 2.0.0
---

# New-MgEducationSynchronizationProfile

## SYNOPSIS
Create new navigation property to synchronizationProfiles for education

## SYNTAX

### CreateExpanded (Default)
```
New-MgEducationSynchronizationProfile [-AdditionalProperties <Hashtable>] [-DataProvider <Hashtable>]
 [-DisplayName <String>] [-Errors <IMicrosoftGraphEducationSynchronizationError[]>]
 [-ExpirationDate <DateTime>] [-HandleSpecialCharacterConstraint] [-Id <String>]
 [-IdentitySynchronizationConfiguration <Hashtable>]
 [-LicensesToAssign <IMicrosoftGraphEducationSynchronizationLicenseAssignment[]>]
 [-ProfileStatus <IMicrosoftGraphEducationSynchronizationProfileStatus>] [-State <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgEducationSynchronizationProfile -BodyParameter <IMicrosoftGraphEducationSynchronizationProfile>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to synchronizationProfiles for education

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded
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
Parameter Sets: Create
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LicensesToAssign
License setup configuration.
To construct, please use Get-Help -Online and see NOTES section for LICENSESTOASSIGN properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationSynchronizationLicenseAssignment[]
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationSynchronizationProfile

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationSynchronizationProfile

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

