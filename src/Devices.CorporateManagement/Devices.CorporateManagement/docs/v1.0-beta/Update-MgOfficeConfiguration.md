---
external help file:
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/update-mgofficeconfiguration
schema: 2.0.0
---

# Update-MgOfficeConfiguration

## SYNOPSIS
Update officeConfiguration

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgOfficeConfiguration [-AdditionalProperties <Hashtable>]
 [-ClientConfigurations <IMicrosoftGraphOfficeClientConfiguration[]>]
 [-TenantCheckinStatuses <IMicrosoftGraphOfficeClientCheckinStatus[]>]
 [-TenantUserCheckinSummary <IMicrosoftGraphOfficeUserCheckinSummary>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgOfficeConfiguration -BodyParameter <IMicrosoftGraphOfficeConfiguration> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update officeConfiguration

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
officeConfiguration
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

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
List of office Client configuration.
To construct, please use Get-Help -Online and see NOTES section for CLIENTCONFIGURATIONS properties and create a hash table.

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
List of office Client check-in status.
To construct, please use Get-Help -Online and see NOTES section for TENANTCHECKINSTATUSES properties and create a hash table.

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

### -TenantUserCheckinSummary
officeUserCheckinSummary
To construct, please use Get-Help -Online and see NOTES section for TENANTUSERCHECKINSUMMARY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfficeUserCheckinSummary
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
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ClientConfigurations <IMicrosoftGraphOfficeClientConfiguration[]>]`: List of office Client configuration.
    - `[Id <String>]`: 
    - `[Assignments <IMicrosoftGraphOfficeClientConfigurationAssignment[]>]`: The list of group assignments for the policy.
      - `[Id <String>]`: 
      - `[Target <IMicrosoftGraphOfficeConfigurationAssignmentTarget>]`: officeConfigurationAssignmentTarget
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CheckinStatuses <IMicrosoftGraphOfficeClientCheckinStatus[]>]`: List of office Client check-in status.
      - `[AppliedPolicies <String[]>]`: List of policies delivered to the device as last checkin.
      - `[CheckinDateTime <DateTime?>]`: Last device check-in time in UTC.
      - `[DeviceName <String>]`: Device name trying to check-in.
      - `[DevicePlatform <String>]`: Device platform trying to check-in.
      - `[DevicePlatformVersion <String>]`: Device platform version trying to check-in.
      - `[ErrorMessage <String>]`: Error message if any associated for the last checkin.
      - `[UserId <String>]`: User identifier using the device.
      - `[UserPrincipalName <String>]`: User principal name using the device.
      - `[WasSuccessful <Boolean?>]`: If the last checkin was successful.
    - `[Description <String>]`: Not yet documented
    - `[DisplayName <String>]`: Admin provided description of the office client configuration policy.
    - `[PolicyPayload <Byte[]>]`: Policy settings JSON string in binary format, these values cannot be changed by the user.
    - `[Priority <Int32?>]`: Priority value should be unique value for each policy under a tenant and will be used for conflict resolution, lower values mean priority is high.
    - `[UserCheckinSummary <IMicrosoftGraphOfficeUserCheckinSummary>]`: officeUserCheckinSummary
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[FailedUserCount <Int32?>]`: Total failed user check ins for the last 3 months.
      - `[SucceededUserCount <Int32?>]`: Total successful user check ins for the last 3 months.
    - `[UserPreferencePayload <Byte[]>]`: Preference settings JSON string in binary format, these values can be overridden by the user.
  - `[TenantCheckinStatuses <IMicrosoftGraphOfficeClientCheckinStatus[]>]`: List of office Client check-in status.
  - `[TenantUserCheckinSummary <IMicrosoftGraphOfficeUserCheckinSummary>]`: officeUserCheckinSummary

CLIENTCONFIGURATIONS <IMicrosoftGraphOfficeClientConfiguration[]>: List of office Client configuration.
  - `[Id <String>]`: 
  - `[Assignments <IMicrosoftGraphOfficeClientConfigurationAssignment[]>]`: The list of group assignments for the policy.
    - `[Id <String>]`: 
    - `[Target <IMicrosoftGraphOfficeConfigurationAssignmentTarget>]`: officeConfigurationAssignmentTarget
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CheckinStatuses <IMicrosoftGraphOfficeClientCheckinStatus[]>]`: List of office Client check-in status.
    - `[AppliedPolicies <String[]>]`: List of policies delivered to the device as last checkin.
    - `[CheckinDateTime <DateTime?>]`: Last device check-in time in UTC.
    - `[DeviceName <String>]`: Device name trying to check-in.
    - `[DevicePlatform <String>]`: Device platform trying to check-in.
    - `[DevicePlatformVersion <String>]`: Device platform version trying to check-in.
    - `[ErrorMessage <String>]`: Error message if any associated for the last checkin.
    - `[UserId <String>]`: User identifier using the device.
    - `[UserPrincipalName <String>]`: User principal name using the device.
    - `[WasSuccessful <Boolean?>]`: If the last checkin was successful.
  - `[Description <String>]`: Not yet documented
  - `[DisplayName <String>]`: Admin provided description of the office client configuration policy.
  - `[PolicyPayload <Byte[]>]`: Policy settings JSON string in binary format, these values cannot be changed by the user.
  - `[Priority <Int32?>]`: Priority value should be unique value for each policy under a tenant and will be used for conflict resolution, lower values mean priority is high.
  - `[UserCheckinSummary <IMicrosoftGraphOfficeUserCheckinSummary>]`: officeUserCheckinSummary
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[FailedUserCount <Int32?>]`: Total failed user check ins for the last 3 months.
    - `[SucceededUserCount <Int32?>]`: Total successful user check ins for the last 3 months.
  - `[UserPreferencePayload <Byte[]>]`: Preference settings JSON string in binary format, these values can be overridden by the user.

TENANTCHECKINSTATUSES <IMicrosoftGraphOfficeClientCheckinStatus[]>: List of office Client check-in status.
  - `[AppliedPolicies <String[]>]`: List of policies delivered to the device as last checkin.
  - `[CheckinDateTime <DateTime?>]`: Last device check-in time in UTC.
  - `[DeviceName <String>]`: Device name trying to check-in.
  - `[DevicePlatform <String>]`: Device platform trying to check-in.
  - `[DevicePlatformVersion <String>]`: Device platform version trying to check-in.
  - `[ErrorMessage <String>]`: Error message if any associated for the last checkin.
  - `[UserId <String>]`: User identifier using the device.
  - `[UserPrincipalName <String>]`: User principal name using the device.
  - `[WasSuccessful <Boolean?>]`: If the last checkin was successful.

TENANTUSERCHECKINSUMMARY <IMicrosoftGraphOfficeUserCheckinSummary>: officeUserCheckinSummary
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[FailedUserCount <Int32?>]`: Total failed user check ins for the last 3 months.
  - `[SucceededUserCount <Int32?>]`: Total successful user check ins for the last 3 months.

## RELATED LINKS

