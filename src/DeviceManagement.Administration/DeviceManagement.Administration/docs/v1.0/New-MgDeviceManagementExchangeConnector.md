---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.administration/new-mgdevicemanagementexchangeconnector
schema: 2.0.0
---

# New-MgDeviceManagementExchangeConnector

## SYNOPSIS
Create new navigation property to exchangeConnectors for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementExchangeConnector [-AdditionalProperties <Hashtable>] [-ConnectorServerName <String>]
 [-ExchangeAlias <String>] [-ExchangeConnectorType <DeviceManagementExchangeConnectorType>]
 [-ExchangeOrganization <String>] [-Id <String>] [-LastSyncDateTime <DateTime>] [-PrimarySmtpAddress <String>]
 [-ServerName <String>] [-Status <DeviceManagementExchangeConnectorStatus>] [-Version <String>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementExchangeConnector -BodyParameter <IMicrosoftGraphDeviceManagementExchangeConnector>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to exchangeConnectors for deviceManagement

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
Entity which represents a connection to an Exchange environment.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementExchangeConnector
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ConnectorServerName
The name of the server hosting the Exchange Connector.

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

### -ExchangeAlias
An alias assigned to the Exchange server

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

### -ExchangeConnectorType
The type of Exchange Connector.

```yaml
Type: Microsoft.Graph.PowerShell.Support.DeviceManagementExchangeConnectorType
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExchangeOrganization
Exchange Organization to the Exchange server

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

### -LastSyncDateTime
Last sync time for the Exchange Connector

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

### -PrimarySmtpAddress
Email address used to configure the Service To Service Exchange Connector.

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

### -ServerName
The name of the Exchange server.

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
The current status of the Exchange Connector.

```yaml
Type: Microsoft.Graph.PowerShell.Support.DeviceManagementExchangeConnectorStatus
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Version
The version of the ExchangeConnectorAgent

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementExchangeConnector

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementExchangeConnector

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphDeviceManagementExchangeConnector>: Entity which represents a connection to an Exchange environment.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[ConnectorServerName <String>]`: The name of the server hosting the Exchange Connector.
  - `[ExchangeAlias <String>]`: An alias assigned to the Exchange server
  - `[ExchangeConnectorType <DeviceManagementExchangeConnectorType?>]`: The type of Exchange Connector.
  - `[ExchangeOrganization <String>]`: Exchange Organization to the Exchange server
  - `[LastSyncDateTime <DateTime?>]`: Last sync time for the Exchange Connector
  - `[PrimarySmtpAddress <String>]`: Email address used to configure the Service To Service Exchange Connector.
  - `[ServerName <String>]`: The name of the Exchange server.
  - `[Status <DeviceManagementExchangeConnectorStatus?>]`: The current status of the Exchange Connector.
  - `[Version <String>]`: The version of the ExchangeConnectorAgent

## RELATED LINKS

