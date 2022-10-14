---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementmicrosofttunnelsite
schema: 2.0.0
---

# New-MgDeviceManagementMicrosoftTunnelSite

## SYNOPSIS
Create new navigation property to microsoftTunnelSites for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementMicrosoftTunnelSite [-AdditionalProperties <Hashtable>] [-Description <String>]
 [-DisplayName <String>] [-EnableCertificatePinning] [-Id <String>] [-InternalNetworkProbeUrl <String>]
 [-MicrosoftTunnelConfiguration <IMicrosoftGraphMicrosoftTunnelConfiguration>]
 [-MicrosoftTunnelServers <IMicrosoftGraphMicrosoftTunnelServer[]>] [-PublicAddress <String>]
 [-RoleScopeTagIds <String[]>] [-UpgradeAutomatically] [-UpgradeAvailable] [-UpgradeWindowEndTime <String>]
 [-UpgradeWindowStartTime <String>] [-UpgradeWindowUtcOffsetInMinutes <Int32>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementMicrosoftTunnelSite -BodyParameter <IMicrosoftGraphMicrosoftTunnelSite> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to microsoftTunnelSites for deviceManagement

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
Entity that represents a Microsoft Tunnel site
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMicrosoftTunnelSite
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Description
The site's description (optional)

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
The display name for the site.
This property is required when a site is created.

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

### -EnableCertificatePinning
When set to true, certificate pinning will be enforced on connections between the Microsoft Tunnel server and Microsoft Tunnel clients.
When set to false, certificate pinning will be disabled.

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

### -Id
The unique idenfier for an entity.
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

### -InternalNetworkProbeUrl
The site's Internal Network Access Probe URL

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

### -MicrosoftTunnelConfiguration
Entity that represents a collection of Microsoft Tunnel settings
To construct, please use Get-Help -Online and see NOTES section for MICROSOFTTUNNELCONFIGURATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMicrosoftTunnelConfiguration
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MicrosoftTunnelServers
A list of MicrosoftTunnelServers that are registered to this MicrosoftTunnelSite
To construct, please use Get-Help -Online and see NOTES section for MICROSOFTTUNNELSERVERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMicrosoftTunnelServer[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PublicAddress
The site's public domain name or IP address

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
List of Scope Tags for this Entity instance

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

### -UpgradeAutomatically
The site's automatic upgrade setting.
True for automatic upgrades, false for manual control

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

### -UpgradeAvailable
The site provides the state of when an upgrade is available

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

### -UpgradeWindowEndTime
The site's upgrade window end time of day

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

### -UpgradeWindowStartTime
The site's upgrade window start time of day

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

### -UpgradeWindowUtcOffsetInMinutes
The site's timezone represented as a minute offset from UTC

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMicrosoftTunnelSite

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMicrosoftTunnelSite

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphMicrosoftTunnelSite>: Entity that represents a Microsoft Tunnel site
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Description <String>]`: The site's description (optional)
  - `[DisplayName <String>]`: The display name for the site. This property is required when a site is created.
  - `[EnableCertificatePinning <Boolean?>]`: When set to true, certificate pinning will be enforced on connections between the Microsoft Tunnel server and Microsoft Tunnel clients. When set to false, certificate pinning will be disabled.
  - `[InternalNetworkProbeUrl <String>]`: The site's Internal Network Access Probe URL
  - `[MicrosoftTunnelConfiguration <IMicrosoftGraphMicrosoftTunnelConfiguration>]`: Entity that represents a collection of Microsoft Tunnel settings
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[AdvancedSettings <IMicrosoftGraphKeyValuePair[]>]`: Additional settings that may be applied to the server
      - `[Name <String>]`: Name for this key-value pair
      - `[Value <String>]`: Value for this key-value pair
    - `[DefaultDomainSuffix <String>]`: The Default Domain appendix that will be used by the clients
    - `[Description <String>]`: The configuration's description (optional)
    - `[DisableUdpConnections <Boolean?>]`: When DisableUdpConnections is set, the clients and VPN server will not use DTLS connections to transfer data.
    - `[DisplayName <String>]`: The display name for the server configuration. This property is required when a server is created.
    - `[DnsServers <String[]>]`: The DNS servers that will be used by the clients
    - `[LastUpdateDateTime <DateTime?>]`: When the configuration was last updated
    - `[ListenPort <Int32?>]`: The port that both TCP and UPD will listen over on the server
    - `[Network <String>]`: The subnet that will be used to allocate virtual address for the clients
    - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance
    - `[RouteExcludes <String[]>]`: Subsets of the routes that will not be routed by the server
    - `[RouteIncludes <String[]>]`: The routes that will be routed by the server
    - `[RoutesExclude <String[]>]`: Subsets of the routes that will not be routed by the server. This property is going to be deprecated with the option of using the new property, 'RouteExcludes'.
    - `[RoutesInclude <String[]>]`: The routes that will be routed by the server. This property is going to be deprecated with the option of using the new property, 'RouteIncludes'.
    - `[SplitDns <String[]>]`: The domains that will be resolved using the provided dns servers
  - `[MicrosoftTunnelServers <IMicrosoftGraphMicrosoftTunnelServer[]>]`: A list of MicrosoftTunnelServers that are registered to this MicrosoftTunnelSite
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[AgentImageDigest <String>]`: The digest of the current agent image running on this server
    - `[DisplayName <String>]`: The display name for the server. This property is required when a server is created and cannot be cleared during updates.
    - `[LastCheckinDateTime <DateTime?>]`: Indicates when the server last checked in
    - `[ServerImageDigest <String>]`: The digest of the current server image running on this server
    - `[TunnelServerHealthStatus <MicrosoftTunnelServerHealthStatus?>]`: Enum of possible MicrosoftTunnelServer health status types
  - `[PublicAddress <String>]`: The site's public domain name or IP address
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance
  - `[UpgradeAutomatically <Boolean?>]`: The site's automatic upgrade setting. True for automatic upgrades, false for manual control
  - `[UpgradeAvailable <Boolean?>]`: The site provides the state of when an upgrade is available
  - `[UpgradeWindowEndTime <String>]`: The site's upgrade window end time of day
  - `[UpgradeWindowStartTime <String>]`: The site's upgrade window start time of day
  - `[UpgradeWindowUtcOffsetInMinutes <Int32?>]`: The site's timezone represented as a minute offset from UTC

MICROSOFTTUNNELCONFIGURATION <IMicrosoftGraphMicrosoftTunnelConfiguration>: Entity that represents a collection of Microsoft Tunnel settings
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AdvancedSettings <IMicrosoftGraphKeyValuePair[]>]`: Additional settings that may be applied to the server
    - `[Name <String>]`: Name for this key-value pair
    - `[Value <String>]`: Value for this key-value pair
  - `[DefaultDomainSuffix <String>]`: The Default Domain appendix that will be used by the clients
  - `[Description <String>]`: The configuration's description (optional)
  - `[DisableUdpConnections <Boolean?>]`: When DisableUdpConnections is set, the clients and VPN server will not use DTLS connections to transfer data.
  - `[DisplayName <String>]`: The display name for the server configuration. This property is required when a server is created.
  - `[DnsServers <String[]>]`: The DNS servers that will be used by the clients
  - `[LastUpdateDateTime <DateTime?>]`: When the configuration was last updated
  - `[ListenPort <Int32?>]`: The port that both TCP and UPD will listen over on the server
  - `[Network <String>]`: The subnet that will be used to allocate virtual address for the clients
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance
  - `[RouteExcludes <String[]>]`: Subsets of the routes that will not be routed by the server
  - `[RouteIncludes <String[]>]`: The routes that will be routed by the server
  - `[RoutesExclude <String[]>]`: Subsets of the routes that will not be routed by the server. This property is going to be deprecated with the option of using the new property, 'RouteExcludes'.
  - `[RoutesInclude <String[]>]`: The routes that will be routed by the server. This property is going to be deprecated with the option of using the new property, 'RouteIncludes'.
  - `[SplitDns <String[]>]`: The domains that will be resolved using the provided dns servers

MICROSOFTTUNNELSERVERS <IMicrosoftGraphMicrosoftTunnelServer[]>: A list of MicrosoftTunnelServers that are registered to this MicrosoftTunnelSite
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AgentImageDigest <String>]`: The digest of the current agent image running on this server
  - `[DisplayName <String>]`: The display name for the server. This property is required when a server is created and cannot be cleared during updates.
  - `[LastCheckinDateTime <DateTime?>]`: Indicates when the server last checked in
  - `[ServerImageDigest <String>]`: The digest of the current server image running on this server
  - `[TunnelServerHealthStatus <MicrosoftTunnelServerHealthStatus?>]`: Enum of possible MicrosoftTunnelServer health status types

## RELATED LINKS

