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
 [-ClientConfigurations <IMicrosoftGraphOfficeClientConfiguration[]>] [-Id <String>]
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

### -TenantUserCheckinSummary
officeUserCheckinSummary
To construct, see NOTES section for TENANTUSERCHECKINSUMMARY properties and create a hash table.

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
  - `[Id <String>]`: Read-only.
  - `[ClientConfigurations <IMicrosoftGraphOfficeClientConfiguration[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Assignments <IMicrosoftGraphOfficeClientConfigurationAssignment[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[Target <IMicrosoftGraphOfficeConfigurationAssignmentTarget>]`: officeConfigurationAssignmentTarget
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
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
    - `[UserCheckinSummary <IMicrosoftGraphOfficeUserCheckinSummary>]`: officeUserCheckinSummary
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[FailedUserCount <Int32?>]`: 
      - `[SucceededUserCount <Int32?>]`: 
    - `[UserPreferencePayload <Byte[]>]`: 
  - `[TenantCheckinStatuses <IMicrosoftGraphOfficeClientCheckinStatus[]>]`: 
  - `[TenantUserCheckinSummary <IMicrosoftGraphOfficeUserCheckinSummary>]`: officeUserCheckinSummary

CLIENTCONFIGURATIONS <IMicrosoftGraphOfficeClientConfiguration[]>: .
  - `[Id <String>]`: Read-only.
  - `[Assignments <IMicrosoftGraphOfficeClientConfigurationAssignment[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Target <IMicrosoftGraphOfficeConfigurationAssignmentTarget>]`: officeConfigurationAssignmentTarget
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
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
  - `[UserCheckinSummary <IMicrosoftGraphOfficeUserCheckinSummary>]`: officeUserCheckinSummary
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[FailedUserCount <Int32?>]`: 
    - `[SucceededUserCount <Int32?>]`: 
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

TENANTUSERCHECKINSUMMARY <IMicrosoftGraphOfficeUserCheckinSummary>: officeUserCheckinSummary
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[FailedUserCount <Int32?>]`: 
  - `[SucceededUserCount <Int32?>]`: 

## RELATED LINKS

