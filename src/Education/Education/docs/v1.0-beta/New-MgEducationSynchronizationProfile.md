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
New-MgEducationSynchronizationProfile [-DataProvider <IMicrosoftGraphEducationSynchronizationDataProvider>]
 [-DisplayName <String>] [-Errors <IMicrosoftGraphEducationSynchronizationError[]>]
 [-HandleSpecialCharacterConstraint] [-Id <String>]
 [-IdentitySynchronizationConfiguration <IMicrosoftGraphEducationIdentitySynchronizationConfiguration>]
 [-LicensesToAssign <IMicrosoftGraphEducationSynchronizationLicenseAssignment[]>] [-ProfileStatusId <String>]
 [-ProfileStatusLastSynchronizationDateTime <DateTime>] [-ProfileStatusStatus <String>] [-State <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgEducationSynchronizationProfile -BodyParameter <IMicrosoftGraphEducationSynchronizationProfile>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to synchronizationProfiles for education

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
educationSynchronizationProfile
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationSynchronizationDataProvider
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEducationIdentitySynchronizationConfiguration
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LicensesToAssign
.
To construct, see NOTES section for LICENSESTOASSIGN properties and create a hash table.

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

### -ProfileStatusId
Read-only.

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

### -ProfileStatusLastSynchronizationDateTime
.

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

### -ProfileStatusStatus
educationSynchronizationStatus

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
  - `[Id <String>]`: Read-only.
  - `[DataProvider <IMicrosoftGraphEducationSynchronizationDataProvider>]`: educationSynchronizationDataProvider
  - `[DisplayName <String>]`: 
  - `[Errors <IMicrosoftGraphEducationSynchronizationError[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[EntryType <String>]`: 
    - `[ErrorCode <String>]`: 
    - `[ErrorMessage <String>]`: 
    - `[JoiningValue <String>]`: 
    - `[RecordedDateTime <DateTime?>]`: 
    - `[ReportableIdentifier <String>]`: 
  - `[HandleSpecialCharacterConstraint <Boolean?>]`: 
  - `[IdentitySynchronizationConfiguration <IMicrosoftGraphEducationIdentitySynchronizationConfiguration>]`: educationIdentitySynchronizationConfiguration
  - `[LicensesToAssign <IMicrosoftGraphEducationSynchronizationLicenseAssignment[]>]`: 
    - `[AppliesTo <String>]`: 
    - `[SkuIds <String[]>]`: 
  - `[ProfileStatusId <String>]`: Read-only.
  - `[ProfileStatusLastSynchronizationDateTime <DateTime?>]`: 
  - `[ProfileStatusStatus <String>]`: educationSynchronizationStatus
  - `[State <String>]`: educationSynchronizationProfileState

ERRORS <IMicrosoftGraphEducationSynchronizationError[]>: .
  - `[Id <String>]`: Read-only.
  - `[EntryType <String>]`: 
  - `[ErrorCode <String>]`: 
  - `[ErrorMessage <String>]`: 
  - `[JoiningValue <String>]`: 
  - `[RecordedDateTime <DateTime?>]`: 
  - `[ReportableIdentifier <String>]`: 

LICENSESTOASSIGN <IMicrosoftGraphEducationSynchronizationLicenseAssignment[]>: .
  - `[AppliesTo <String>]`: 
  - `[SkuIds <String[]>]`: 

## RELATED LINKS

