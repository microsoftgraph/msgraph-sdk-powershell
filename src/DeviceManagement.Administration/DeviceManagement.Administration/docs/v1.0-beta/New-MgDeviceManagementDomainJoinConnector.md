---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.administration/new-mgdevicemanagementdomainjoinconnector
schema: 2.0.0
---

# New-MgDeviceManagementDomainJoinConnector

## SYNOPSIS
Create new navigation property to domainJoinConnectors for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementDomainJoinConnector [-AdditionalProperties <Hashtable>] [-DisplayName <String>]
 [-Id <String>] [-LastConnectionDateTime <DateTime>] [-State <DeviceManagementDomainJoinConnectorState>]
 [-Version <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementDomainJoinConnector -BodyParameter <IMicrosoftGraphDeviceManagementDomainJoinConnector>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to domainJoinConnectors for deviceManagement

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
A Domain Join Connector is a connector that is responsible to allocate (and delete) machine account blobs
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementDomainJoinConnector
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
The connector display name.

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

### -LastConnectionDateTime
Last time connector contacted Intune.

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

### -State
The ODJ request states.

```yaml
Type: Microsoft.Graph.PowerShell.Support.DeviceManagementDomainJoinConnectorState
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Version
The version of the connector.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementDomainJoinConnector

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementDomainJoinConnector

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphDeviceManagementDomainJoinConnector>: A Domain Join Connector is a connector that is responsible to allocate (and delete) machine account blobs
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[DisplayName <String>]`: The connector display name.
  - `[LastConnectionDateTime <DateTime?>]`: Last time connector contacted Intune.
  - `[State <DeviceManagementDomainJoinConnectorState?>]`: The ODJ request states.
  - `[Version <String>]`: The version of the connector.

## RELATED LINKS

