---
external help file:
Module Name: Microsoft.Graph.DevicesApps.OfficeConfiguration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicesapps.officeconfiguration/update-mgofficeconfiguration
schema: 2.0.0
---

# Update-MgOfficeConfiguration

## SYNOPSIS
Update officeConfiguration

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgOfficeConfiguration [-ClientConfigurations <IMicrosoftGraphOfficeClientConfiguration[]>]
 [-Id <String>] [-TenantCheckinStatuses <IMicrosoftGraphOfficeClientCheckinStatus[]>]
 [-TenantUserCheckinSummaryFailedUserCount <Int32>] [-TenantUserCheckinSummarySucceededUserCount <Int32>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgOfficeConfiguration -BodyParameter <IMicrosoftGraphOfficeConfiguration> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update officeConfiguration

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
officeConfiguration
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfficeConfiguration
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ClientConfigurations
.
To construct, see NOTES section for CLIENTCONFIGURATIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfficeClientConfiguration[]
Parameter Sets: UpdateExpanded
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
Parameter Sets: UpdateExpanded
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

### -TenantCheckinStatuses
.
To construct, see NOTES section for TENANTCHECKINSTATUSES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfficeClientCheckinStatus[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TenantUserCheckinSummaryFailedUserCount
.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TenantUserCheckinSummarySucceededUserCount
.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfficeConfiguration

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphOfficeConfiguration>: officeConfiguration
  - `[Id <String>]`: Read-only.
  - `[ClientConfigurations <IMicrosoftGraphOfficeClientConfiguration[]>]`: 
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
  - `[TenantCheckinStatuses <IMicrosoftGraphOfficeClientCheckinStatus[]>]`: 
  - `[TenantUserCheckinSummaryFailedUserCount <Int32?>]`: 
  - `[TenantUserCheckinSummarySucceededUserCount <Int32?>]`: 

CLIENTCONFIGURATIONS <IMicrosoftGraphOfficeClientConfiguration[]>: .
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

TENANTCHECKINSTATUSES <IMicrosoftGraphOfficeClientCheckinStatus[]>: .
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

