---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementmicrosofttunnelconfiguration
schema: 2.0.0
---

# New-MgDeviceManagementMicrosoftTunnelConfiguration

## SYNOPSIS
Create new navigation property to microsoftTunnelConfigurations for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementMicrosoftTunnelConfiguration [-AdditionalProperties <Hashtable>]
 [-AdvancedSettings <IMicrosoftGraphKeyValuePair[]>] [-DefaultDomainSuffix <String>] [-Description <String>]
 [-DisableUdpConnections] [-DisplayName <String>] [-DnsServers <String[]>] [-Id <String>]
 [-LastUpdateDateTime <DateTime>] [-ListenPort <Int32>] [-Network <String>] [-RoleScopeTagIds <String[]>]
 [-RoutesExclude <String[]>] [-RoutesInclude <String[]>] [-SplitDns <String[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementMicrosoftTunnelConfiguration
 -BodyParameter <IMicrosoftGraphMicrosoftTunnelConfiguration> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to microsoftTunnelConfigurations for deviceManagement

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

### -AdvancedSettings
Additional settings that may be applied to the server
To construct, please use Get-Help -Online and see NOTES section for ADVANCEDSETTINGS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphKeyValuePair[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Entity that represents a collection of Microsoft Tunnel settings
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMicrosoftTunnelConfiguration
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DefaultDomainSuffix
The Default Domain appendix that will be used by the clients

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

### -Description
The MicrosoftTunnelConfiguration's description

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

### -DisableUdpConnections
When DisableUdpConnections is set, the clients and VPN server will not use DTLS connections to tansfer data.

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

### -DisplayName
The MicrosoftTunnelConfiguration's display name

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

### -DnsServers
The DNS servers that will be used by the clients

```yaml
Type: System.String[]
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

### -LastUpdateDateTime
When the MicrosoftTunnelConfiguration was last updated

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

### -ListenPort
The port that both TCP and UPD will listen over on the server

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

### -Network
The subnet that will be used to allocate virtual address for the clients

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

### -RoleScopeTagIds
List of Scope Tags for this Entity instance.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RoutesExclude
Subsets of the routes that will not be routed by the server

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RoutesInclude
The routs that will be routed by the server

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SplitDns
The domains that will be resolved using the provided dns servers

```yaml
Type: System.String[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMicrosoftTunnelConfiguration

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMicrosoftTunnelConfiguration

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ADVANCEDSETTINGS <IMicrosoftGraphKeyValuePair[]>: Additional settings that may be applied to the server
  - `[Name <String>]`: Name for this key-value pair
  - `[Value <String>]`: Value for this key-value pair

BODYPARAMETER <IMicrosoftGraphMicrosoftTunnelConfiguration>: Entity that represents a collection of Microsoft Tunnel settings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[AdvancedSettings <IMicrosoftGraphKeyValuePair[]>]`: Additional settings that may be applied to the server
    - `[Name <String>]`: Name for this key-value pair
    - `[Value <String>]`: Value for this key-value pair
  - `[DefaultDomainSuffix <String>]`: The Default Domain appendix that will be used by the clients
  - `[Description <String>]`: The MicrosoftTunnelConfiguration's description
  - `[DisableUdpConnections <Boolean?>]`: When DisableUdpConnections is set, the clients and VPN server will not use DTLS connections to tansfer data.
  - `[DisplayName <String>]`: The MicrosoftTunnelConfiguration's display name
  - `[DnsServers <String[]>]`: The DNS servers that will be used by the clients
  - `[LastUpdateDateTime <DateTime?>]`: When the MicrosoftTunnelConfiguration was last updated
  - `[ListenPort <Int32?>]`: The port that both TCP and UPD will listen over on the server
  - `[Network <String>]`: The subnet that will be used to allocate virtual address for the clients
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.
  - `[RoutesExclude <String[]>]`: Subsets of the routes that will not be routed by the server
  - `[RoutesInclude <String[]>]`: The routs that will be routed by the server
  - `[SplitDns <String[]>]`: The domains that will be resolved using the provided dns servers

## RELATED LINKS

