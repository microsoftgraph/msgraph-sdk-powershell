---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement.Administration
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement.administration/new-mgbetadevicemanagementpartner
schema: 2.0.0
---

# New-MgBetaDeviceManagementPartner

## SYNOPSIS
Create new navigation property to deviceManagementPartners for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaDeviceManagementPartner [-AdditionalProperties <Hashtable>] [-DisplayName <String>]
 [-GroupsRequiringPartnerEnrollment <IMicrosoftGraphDeviceManagementPartnerAssignment[]>] [-Id <String>]
 [-IsConfigured] [-LastHeartbeatDateTime <DateTime>] [-PartnerAppType <DeviceManagementPartnerAppType>]
 [-PartnerState <DeviceManagementPartnerTenantState>] [-ResponseHeadersVariable <String>]
 [-SingleTenantAppId <String>] [-WhenPartnerDevicesWillBeMarkedAsNonCompliantDateTime <DateTime>]
 [-WhenPartnerDevicesWillBeRemovedDateTime <DateTime>] [-Headers <IDictionary>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgBetaDeviceManagementPartner -BodyParameter <IMicrosoftGraphDeviceManagementPartner>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to deviceManagementPartners for deviceManagement

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

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
Entity which represents a connection to device management partner.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceManagementPartner
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
Partner display name

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

### -GroupsRequiringPartnerEnrollment
User groups that specifies whether enrollment is through partner.
To construct, see NOTES section for GROUPSREQUIRINGPARTNERENROLLMENT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceManagementPartnerAssignment[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
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

### -IsConfigured
Whether device management partner is configured or not

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

### -LastHeartbeatDateTime
Timestamp of last heartbeat after admin enabled option Connect to Device management Partner

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

### -PartnerAppType
Partner App Type.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Support.DeviceManagementPartnerAppType
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PartnerState
Partner state of this tenant.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Support.DeviceManagementPartnerTenantState
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SingleTenantAppId
Partner Single tenant App id

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

### -WhenPartnerDevicesWillBeMarkedAsNonCompliantDateTime
DateTime in UTC when PartnerDevices will be marked as NonCompliant

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

### -WhenPartnerDevicesWillBeRemovedDateTime
DateTime in UTC when PartnerDevices will be removed

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceManagementPartner

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDeviceManagementPartner

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphDeviceManagementPartner>`: Entity which represents a connection to device management partner.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DisplayName <String>]`: Partner display name
  - `[GroupsRequiringPartnerEnrollment <IMicrosoftGraphDeviceManagementPartnerAssignment[]>]`: User groups that specifies whether enrollment is through partner.
    - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
      - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.
  - `[IsConfigured <Boolean?>]`: Whether device management partner is configured or not
  - `[LastHeartbeatDateTime <DateTime?>]`: Timestamp of last heartbeat after admin enabled option Connect to Device management Partner
  - `[PartnerAppType <DeviceManagementPartnerAppType?>]`: Partner App Type.
  - `[PartnerState <DeviceManagementPartnerTenantState?>]`: Partner state of this tenant.
  - `[SingleTenantAppId <String>]`: Partner Single tenant App id
  - `[WhenPartnerDevicesWillBeMarkedAsNonCompliantDateTime <DateTime?>]`: DateTime in UTC when PartnerDevices will be marked as NonCompliant
  - `[WhenPartnerDevicesWillBeRemovedDateTime <DateTime?>]`: DateTime in UTC when PartnerDevices will be removed

`GROUPSREQUIRINGPARTNERENROLLMENT <IMicrosoftGraphDeviceManagementPartnerAssignment[]>`: User groups that specifies whether enrollment is through partner.
  - `[Target <IMicrosoftGraphDeviceAndAppManagementAssignmentTarget>]`: Base type for assignment targets.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceAndAppManagementAssignmentFilterId <String>]`: The Id of the filter for the target assignment.
    - `[DeviceAndAppManagementAssignmentFilterType <DeviceAndAppManagementAssignmentFilterType?>]`: Represents type of the assignment filter.

## RELATED LINKS

