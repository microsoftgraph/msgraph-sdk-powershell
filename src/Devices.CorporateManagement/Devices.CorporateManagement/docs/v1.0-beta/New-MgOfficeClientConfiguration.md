---
external help file:
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgofficeclientconfiguration
schema: 2.0.0
---

# New-MgOfficeClientConfiguration

## SYNOPSIS
Create new navigation property to clientConfigurations for officeConfiguration

## SYNTAX

### CreateExpanded (Default)
```
New-MgOfficeClientConfiguration [-AdditionalProperties <Hashtable>]
 [-Assignments <IMicrosoftGraphOfficeClientConfigurationAssignment[]>]
 [-CheckinStatuses <IMicrosoftGraphOfficeClientCheckinStatus[]>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>] [-PolicyPayloadInputFile <String>] [-Priority <Int32>]
 [-UserCheckinSummary <IMicrosoftGraphOfficeUserCheckinSummary>] [-UserPreferencePayloadInputFile <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgOfficeClientConfiguration -BodyParameter <IMicrosoftGraphOfficeClientConfiguration> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to clientConfigurations for officeConfiguration

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

### -Assignments
The list of group assignments for the policy.
To construct, please use Get-Help -Online and see NOTES section for ASSIGNMENTS properties and create a hash table.

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
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

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
List of office Client check-in status.
To construct, please use Get-Help -Online and see NOTES section for CHECKINSTATUSES properties and create a hash table.

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
Not yet documented

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
Admin provided description of the office client configuration policy.

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

### -PolicyPayloadInputFile
Input File for PolicyPayload (Policy settings JSON string in binary format, these values cannot be changed by the user.)

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
Priority value should be unique value for each policy under a tenant and will be used for conflict resolution, lower values mean priority is high.

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

### -UserCheckinSummary
officeUserCheckinSummary
To construct, please use Get-Help -Online and see NOTES section for USERCHECKINSUMMARY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfficeUserCheckinSummary
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserPreferencePayloadInputFile
Input File for UserPreferencePayload (Preference settings JSON string in binary format, these values can be overridden by the user.)

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


ASSIGNMENTS <IMicrosoftGraphOfficeClientConfigurationAssignment[]>: The list of group assignments for the policy.
  - `[Id <String>]`: 
  - `[Target <IMicrosoftGraphOfficeConfigurationAssignmentTarget>]`: officeConfigurationAssignmentTarget
    - `[(Any) <Object>]`: This indicates any property can be added to this object.

BODYPARAMETER <IMicrosoftGraphOfficeClientConfiguration>: officeClientConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
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

CHECKINSTATUSES <IMicrosoftGraphOfficeClientCheckinStatus[]>: List of office Client check-in status.
  - `[AppliedPolicies <String[]>]`: List of policies delivered to the device as last checkin.
  - `[CheckinDateTime <DateTime?>]`: Last device check-in time in UTC.
  - `[DeviceName <String>]`: Device name trying to check-in.
  - `[DevicePlatform <String>]`: Device platform trying to check-in.
  - `[DevicePlatformVersion <String>]`: Device platform version trying to check-in.
  - `[ErrorMessage <String>]`: Error message if any associated for the last checkin.
  - `[UserId <String>]`: User identifier using the device.
  - `[UserPrincipalName <String>]`: User principal name using the device.
  - `[WasSuccessful <Boolean?>]`: If the last checkin was successful.

USERCHECKINSUMMARY <IMicrosoftGraphOfficeUserCheckinSummary>: officeUserCheckinSummary
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[FailedUserCount <Int32?>]`: Total failed user check ins for the last 3 months.
  - `[SucceededUserCount <Int32?>]`: Total successful user check ins for the last 3 months.

## RELATED LINKS

