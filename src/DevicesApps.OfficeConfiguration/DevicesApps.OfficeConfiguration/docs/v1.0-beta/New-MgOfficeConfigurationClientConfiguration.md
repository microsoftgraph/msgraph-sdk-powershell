---
external help file:
Module Name: Microsoft.Graph.DevicesApps.OfficeConfiguration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicesapps.officeconfiguration/new-mgofficeconfigurationclientconfiguration
schema: 2.0.0
---

# New-MgOfficeConfigurationClientConfiguration

## SYNOPSIS
Create new navigation property to clientConfigurations for officeConfiguration

## SYNTAX

### CreateExpanded (Default)
```
New-MgOfficeConfigurationClientConfiguration
 [-Assignments <IMicrosoftGraphOfficeClientConfigurationAssignment[]>]
 [-CheckinStatuses <IMicrosoftGraphOfficeClientCheckinStatus[]>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>] [-PolicyPayloadInputFile <String>] [-Priority <Int32>]
 [-UserCheckinSummaryFailedUserCount <Int32>] [-UserCheckinSummarySucceededUserCount <Int32>]
 [-UserPreferencePayloadInputFile <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgOfficeConfigurationClientConfiguration -BodyParameter <IMicrosoftGraphOfficeClientConfiguration>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to clientConfigurations for officeConfiguration

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

### -Assignments
.
To construct, see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfficeClientConfigurationAssignment[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
officeClientConfiguration
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfficeClientConfiguration
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CheckinStatuses
.
To construct, see NOTES section for CHECKINSTATUSES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfficeClientCheckinStatus[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
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

### -PolicyPayloadInputFile
Input File for PolicyPayload (.)

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

### -Priority
.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserCheckinSummaryFailedUserCount
.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserCheckinSummarySucceededUserCount
.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserPreferencePayloadInputFile
Input File for UserPreferencePayload (.)

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfficeClientConfiguration

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfficeClientConfiguration

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSIGNMENTS <IMicrosoftGraphOfficeClientConfigurationAssignment[]>: .
  - `[Id <String>]`: Read-only.
  - `[Target <IMicrosoftGraphOfficeConfigurationAssignmentTarget>]`: officeConfigurationAssignmentTarget

BODYPARAMETER <IMicrosoftGraphOfficeClientConfiguration>: officeClientConfiguration
  - `[Id <String>]`: Read-only.
  - `[Assignments <IMicrosoftGraphOfficeClientConfigurationAssignment[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Target <IMicrosoftGraphOfficeConfigurationAssignmentTarget>]`: officeConfigurationAssignmentTarget
  - `[CheckinStatuses <IMicrosoftGraphOfficeClientCheckinStatus[]>]`: 
    - `[AppliedPolicies <String[]>]`: 
    - `[CheckinDateTime <DateTime?>]`: 
    - `[DeviceName <String>]`: 
    - `[DevicePlatform <String>]`: 
    - `[DevicePlatformVersion <String>]`: 
    - `[ErrorMessage <String>]`: 
    - `[UserId <String>]`: 
    - `[UserPrincipalName <String>]`: 
    - `[WasSuccessful <Boolean?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[PolicyPayload <Byte[]>]`: 
  - `[Priority <Int32?>]`: 
  - `[UserCheckinSummaryFailedUserCount <Int32?>]`: 
  - `[UserCheckinSummarySucceededUserCount <Int32?>]`: 
  - `[UserPreferencePayload <Byte[]>]`: 

CHECKINSTATUSES <IMicrosoftGraphOfficeClientCheckinStatus[]>: .
  - `[AppliedPolicies <String[]>]`: 
  - `[CheckinDateTime <DateTime?>]`: 
  - `[DeviceName <String>]`: 
  - `[DevicePlatform <String>]`: 
  - `[DevicePlatformVersion <String>]`: 
  - `[ErrorMessage <String>]`: 
  - `[UserId <String>]`: 
  - `[UserPrincipalName <String>]`: 
  - `[WasSuccessful <Boolean?>]`: 

## RELATED LINKS

