---
external help file:
Module Name: Microsoft.Graph.DevicesApps.OfficeConfiguration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicesapps.officeconfiguration/update-mgofficeconfigurationclientconfiguration
schema: 2.0.0
---

# Update-MgOfficeConfigurationClientConfiguration

## SYNOPSIS
Update the navigation property clientConfigurations in officeConfiguration

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgOfficeConfigurationClientConfiguration -OfficeClientConfigurationId <String>
 [-Assignments <IMicrosoftGraphOfficeClientConfigurationAssignment[]>]
 [-CheckinStatuses <IMicrosoftGraphOfficeClientCheckinStatus[]>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>] [-PolicyPayloadInputFile <String>] [-Priority <Int32>]
 [-UserCheckinSummaryFailedUserCount <Int32>] [-UserCheckinSummarySucceededUserCount <Int32>]
 [-UserPreferencePayloadInputFile <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgOfficeConfigurationClientConfiguration -OfficeClientConfigurationId <String>
 -BodyParameter <IMicrosoftGraphOfficeClientConfiguration> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgOfficeConfigurationClientConfiguration -InputObject <IDevicesAppsOfficeConfigurationIdentity>
 -BodyParameter <IMicrosoftGraphOfficeClientConfiguration> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgOfficeConfigurationClientConfiguration -InputObject <IDevicesAppsOfficeConfigurationIdentity>
 [-Assignments <IMicrosoftGraphOfficeClientConfigurationAssignment[]>]
 [-CheckinStatuses <IMicrosoftGraphOfficeClientCheckinStatus[]>] [-Description <String>]
 [-DisplayName <String>] [-Id <String>] [-PolicyPayloadInputFile <String>] [-Priority <Int32>]
 [-UserCheckinSummaryFailedUserCount <Int32>] [-UserCheckinSummarySucceededUserCount <Int32>]
 [-UserPreferencePayloadInputFile <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property clientConfigurations in officeConfiguration

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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BodyParameter
officeClientConfiguration
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfficeClientConfiguration
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -CheckinStatuses
.
To construct, see NOTES section for CHECKINSTATUSES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfficeClientCheckinStatus[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Description
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
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IDevicesAppsOfficeConfigurationIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -OfficeClientConfigurationId
key: officeClientConfiguration-id of officeClientConfiguration

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
```

### -PolicyPayloadInputFile
Input File for PolicyPayload (.)

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Priority
.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -UserCheckinSummaryFailedUserCount
.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -UserCheckinSummarySucceededUserCount
.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -UserPreferencePayloadInputFile
Input File for UserPreferencePayload (.)

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IDevicesAppsOfficeConfigurationIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfficeClientConfiguration

## OUTPUTS

### System.Boolean

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### ASSIGNMENTS <IMicrosoftGraphOfficeClientConfigurationAssignment[]>: .
  - `[Id <String>]`: Read-only.
  - `[Target <IMicrosoftGraphOfficeConfigurationAssignmentTarget>]`: officeConfigurationAssignmentTarget

#### BODYPARAMETER <IMicrosoftGraphOfficeClientConfiguration>: officeClientConfiguration
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

#### CHECKINSTATUSES <IMicrosoftGraphOfficeClientCheckinStatus[]>: .
  - `[AppliedPolicies <String[]>]`: 
  - `[CheckinDateTime <DateTime?>]`: 
  - `[DeviceName <String>]`: 
  - `[DevicePlatform <String>]`: 
  - `[DevicePlatformVersion <String>]`: 
  - `[ErrorMessage <String>]`: 
  - `[UserId <String>]`: 
  - `[UserPrincipalName <String>]`: 
  - `[WasSuccessful <Boolean?>]`: 

#### INPUTOBJECT <IDevicesAppsOfficeConfigurationIdentity>: Identity Parameter
  - `[OfficeClientConfigurationAssignmentId <String>]`: key: officeClientConfigurationAssignment-id of officeClientConfigurationAssignment
  - `[OfficeClientConfigurationId <String>]`: key: officeClientConfiguration-id of officeClientConfiguration

## RELATED LINKS

