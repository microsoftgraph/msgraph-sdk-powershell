---
external help file: Microsoft.Graph.DeviceManagement-help.xml
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementembeddedsimactivationcodepool
schema: 2.0.0
---

# New-MgDeviceManagementEmbeddedSimActivationCodePool

## SYNOPSIS
The embedded SIM activation code pools created by this account.

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementEmbeddedSimActivationCodePool [-ActivationCodeCount <Int32>]
 [-ActivationCodes <IMicrosoftGraphEmbeddedSimActivationCode[]>] [-AdditionalProperties <Hashtable>]
 [-Assignments <IMicrosoftGraphEmbeddedSimActivationCodePoolAssignment[]>] [-CreatedDateTime <DateTime>]
 [-DeviceStates <IMicrosoftGraphEmbeddedSimDeviceState[]>] [-DisplayName <String>] [-Id <String>]
 [-ModifiedDateTime <DateTime>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementEmbeddedSimActivationCodePool
 -BodyParameter <IMicrosoftGraphEmbeddedSimActivationCodePool> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
The embedded SIM activation code pools created by this account.

## EXAMPLES

## PARAMETERS

### -ActivationCodeCount
The total count of activation codes which belong to this pool.

```yaml
Type: Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ActivationCodes
The activation codes which belong to this pool.
This navigation property is used to post activation codes to Intune but cannot be used to read activation codes from Intune.
To construct, see NOTES section for ACTIVATIONCODES properties and create a hash table.

```yaml
Type: IMicrosoftGraphEmbeddedSimActivationCode[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Assignments
Navigational property to a list of targets to which this pool is assigned.
To construct, see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: IMicrosoftGraphEmbeddedSimActivationCodePoolAssignment[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
A pool represents a group of embedded SIM activation codes.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphEmbeddedSimActivationCodePool
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
The time the embedded SIM activation code pool was created.
Generated service side.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceStates
Navigational property to a list of device states for this pool.
To construct, see NOTES section for DEVICESTATES properties and create a hash table.

```yaml
Type: IMicrosoftGraphEmbeddedSimDeviceState[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The admin defined name of the embedded SIM activation code pool.

```yaml
Type: String
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
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ModifiedDateTime
The time the embedded SIM activation code pool was last modified.
Updated service side.

```yaml
Type: DateTime
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
Type: SwitchParameter
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
Type: SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEmbeddedSimActivationCodePool
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEmbeddedSimActivationCodePool
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ACTIVATIONCODES <IMicrosoftGraphEmbeddedSimActivationCode[]>: The activation codes which belong to this pool. This navigation property is used to post activation codes to Intune but cannot be used to read activation codes from Intune.
  - `[IntegratedCircuitCardIdentifier <String>]`: The Integrated Circuit Card Identifier (ICCID) for this embedded SIM activation code as provided by the mobile operator.
  - `[MatchingIdentifier <String>]`: The MatchingIdentifier (MatchingID) as specified in the GSMA Association SGP.22 RSP Technical Specification section 4.1.
  - `[SmdpPlusServerAddress <String>]`: The fully qualified domain name of the SM-DP+ server as specified in the GSM Association SPG .22 RSP Technical Specification.

ASSIGNMENTS <IMicrosoftGraphEmbeddedSimActivationCodePoolAssignment[]>: Navigational property to a list of targets to which this pool is assigned.
  - `[Id <String>]`: Read-only.
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
    - `[DeviceAndAppManagementAssignmentFilterType <String>]`: deviceAndAppManagementAssignmentFilterType

BODYPARAMETER <IMicrosoftGraphEmbeddedSimActivationCodePool>: A pool represents a group of embedded SIM activation codes.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[ActivationCodeCount <Int32?>]`: The total count of activation codes which belong to this pool.
  - `[ActivationCodes <IMicrosoftGraphEmbeddedSimActivationCode[]>]`: The activation codes which belong to this pool. This navigation property is used to post activation codes to Intune but cannot be used to read activation codes from Intune.
    - `[IntegratedCircuitCardIdentifier <String>]`: The Integrated Circuit Card Identifier (ICCID) for this embedded SIM activation code as provided by the mobile operator.
    - `[MatchingIdentifier <String>]`: The MatchingIdentifier (MatchingID) as specified in the GSMA Association SGP.22 RSP Technical Specification section 4.1.
    - `[SmdpPlusServerAddress <String>]`: The fully qualified domain name of the SM-DP+ server as specified in the GSM Association SPG .22 RSP Technical Specification.
  - `[Assignments <IMicrosoftGraphEmbeddedSimActivationCodePoolAssignment[]>]`: Navigational property to a list of targets to which this pool is assigned.
    - `[Id <String>]`: Read-only.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget1>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <String>]`: deviceAndAppManagementAssignmentFilterType
  - `[CreatedDateTime <DateTime?>]`: The time the embedded SIM activation code pool was created. Generated service side.
  - `[DeviceStates <IMicrosoftGraphEmbeddedSimDeviceState[]>]`: Navigational property to a list of device states for this pool.
    - `[Id <String>]`: Read-only.
    - `[CreatedDateTime <DateTime?>]`: The time the embedded SIM device status was created. Generated service side.
    - `[DeviceName <String>]`: Device name to which the subscription was provisioned e.g. DESKTOP-JOE
    - `[LastSyncDateTime <DateTime?>]`: The time the embedded SIM device last checked in. Updated service side.
    - `[ModifiedDateTime <DateTime?>]`: The time the embedded SIM device status was last modified. Updated service side.
    - `[State <String>]`: embeddedSIMDeviceStateValue
    - `[StateDetails <String>]`: String description of the provisioning state.
    - `[UniversalIntegratedCircuitCardIdentifier <String>]`: The Universal Integrated Circuit Card Identifier (UICCID) identifying the hardware onto which a profile is to be deployed.
    - `[UserName <String>]`: Username which the subscription was provisioned to e.g. joe@contoso.com
  - `[DisplayName <String>]`: The admin defined name of the embedded SIM activation code pool.
  - `[ModifiedDateTime <DateTime?>]`: The time the embedded SIM activation code pool was last modified. Updated service side.

DEVICESTATES <IMicrosoftGraphEmbeddedSimDeviceState[]>: Navigational property to a list of device states for this pool.
  - `[Id <String>]`: Read-only.
  - `[CreatedDateTime <DateTime?>]`: The time the embedded SIM device status was created. Generated service side.
  - `[DeviceName <String>]`: Device name to which the subscription was provisioned e.g. DESKTOP-JOE
  - `[LastSyncDateTime <DateTime?>]`: The time the embedded SIM device last checked in. Updated service side.
  - `[ModifiedDateTime <DateTime?>]`: The time the embedded SIM device status was last modified. Updated service side.
  - `[State <String>]`: embeddedSIMDeviceStateValue
  - `[StateDetails <String>]`: String description of the provisioning state.
  - `[UniversalIntegratedCircuitCardIdentifier <String>]`: The Universal Integrated Circuit Card Identifier (UICCID) identifying the hardware onto which a profile is to be deployed.
  - `[UserName <String>]`: Username which the subscription was provisioned to e.g. joe@contoso.com

## RELATED LINKS
