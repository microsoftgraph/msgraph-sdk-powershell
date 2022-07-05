---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.administration/new-mgdevicemanagementcomanagementeligibledevice
schema: 2.0.0
---

# New-MgDeviceManagementComanagementEligibleDevice

## SYNOPSIS
Create new navigation property to comanagementEligibleDevices for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementComanagementEligibleDevice [-AdditionalProperties <Hashtable>]
 [-ClientRegistrationStatus <DeviceRegistrationState>] [-DeviceName <String>] [-DeviceType <DeviceType>]
 [-EntitySource <Int32>] [-Id <String>] [-ManagementAgents <ManagementAgentType>]
 [-ManagementState <ManagementState>] [-Manufacturer <String>] [-MdmStatus <String>] [-Model <String>]
 [-OSDescription <String>] [-OSVersion <String>] [-OwnerType <OwnerType>] [-ReferenceId <String>]
 [-SerialNumber <String>] [-Status <String>] [-Upn <String>] [-UserEmail <String>] [-UserId <String>]
 [-UserName <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementComanagementEligibleDevice -BodyParameter <IMicrosoftGraphComanagementEligibleDevice>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to comanagementEligibleDevices for deviceManagement

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
Device Co-Management eligibility state
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphComanagementEligibleDevice
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ClientRegistrationStatus
Device registration status.

```yaml
Type: Microsoft.Graph.PowerShell.Support.DeviceRegistrationState
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DeviceName
DeviceName

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

### -DeviceType
Device type.

```yaml
Type: Microsoft.Graph.PowerShell.Support.DeviceType
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EntitySource
EntitySource

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

### -ManagementAgents
Management agent type.

```yaml
Type: Microsoft.Graph.PowerShell.Support.ManagementAgentType
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ManagementState
Management state of device in Microsoft Intune.

```yaml
Type: Microsoft.Graph.PowerShell.Support.ManagementState
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Manufacturer
Manufacturer

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

### -MdmStatus
MDMStatus

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

### -Model
Model

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

### -OSDescription
OSDescription

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

### -OSVersion
OSVersion

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

### -OwnerType
Owner type of device.

```yaml
Type: Microsoft.Graph.PowerShell.Support.OwnerType
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ReferenceId
ReferenceId

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

### -SerialNumber
SerialNumber

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

### -Status
comanagementEligibleType

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

### -Upn
UPN

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

### -UserEmail
UserEmail

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

### -UserId
UserId

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

### -UserName
UserName

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphComanagementEligibleDevice

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphComanagementEligibleDevice

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphComanagementEligibleDevice>: Device Co-Management eligibility state
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[ClientRegistrationStatus <DeviceRegistrationState?>]`: Device registration status.
  - `[DeviceName <String>]`: DeviceName
  - `[DeviceType <DeviceType?>]`: Device type.
  - `[EntitySource <Int32?>]`: EntitySource
  - `[ManagementAgents <ManagementAgentType?>]`: Management agent type.
  - `[ManagementState <ManagementState?>]`: Management state of device in Microsoft Intune.
  - `[Manufacturer <String>]`: Manufacturer
  - `[MdmStatus <String>]`: MDMStatus
  - `[Model <String>]`: Model
  - `[OSDescription <String>]`: OSDescription
  - `[OSVersion <String>]`: OSVersion
  - `[OwnerType <OwnerType?>]`: Owner type of device.
  - `[ReferenceId <String>]`: ReferenceId
  - `[SerialNumber <String>]`: SerialNumber
  - `[Status <String>]`: comanagementEligibleType
  - `[Upn <String>]`: UPN
  - `[UserEmail <String>]`: UserEmail
  - `[UserId <String>]`: UserId
  - `[UserName <String>]`: UserName

## RELATED LINKS

