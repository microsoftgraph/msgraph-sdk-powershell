---
external help file: Microsoft.Graph.Security-help.xml
Module Name: Microsoft.Graph.Security
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/update-mgsecurityhostsecurityprofile
schema: 2.0.0
---

# Update-MgSecurityHostSecurityProfile

## SYNOPSIS
Update the navigation property hostSecurityProfiles in security

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgSecurityHostSecurityProfile -HostSecurityProfileId <String> [-AdditionalProperties <Hashtable>]
 [-AzureSubscriptionId <String>] [-AzureTenantId <String>] [-FirstSeenDateTime <DateTime>] [-Fqdn <String>]
 [-Id <String>] [-IsAzureAdJoined] [-IsAzureAdRegistered] [-IsHybridAzureDomainJoined]
 [-LastSeenDateTime <DateTime>] [-LogonUsers <IMicrosoftGraphLogonUser[]>] [-NetBiosName <String>]
 [-NetworkInterfaces <IMicrosoftGraphNetworkInterface[]>] [-OS <String>] [-OSVersion <String>]
 [-ParentHost <String>] [-RelatedHostIds <String[]>] [-RiskScore <String>] [-Tags <String[]>]
 [-VendorInformation <IMicrosoftGraphSecurityVendorInformation>] [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Update
```
Update-MgSecurityHostSecurityProfile -HostSecurityProfileId <String>
 -BodyParameter <IMicrosoftGraphHostSecurityProfile> [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgSecurityHostSecurityProfile -InputObject <ISecurityIdentity> [-AdditionalProperties <Hashtable>]
 [-AzureSubscriptionId <String>] [-AzureTenantId <String>] [-FirstSeenDateTime <DateTime>] [-Fqdn <String>]
 [-Id <String>] [-IsAzureAdJoined] [-IsAzureAdRegistered] [-IsHybridAzureDomainJoined]
 [-LastSeenDateTime <DateTime>] [-LogonUsers <IMicrosoftGraphLogonUser[]>] [-NetBiosName <String>]
 [-NetworkInterfaces <IMicrosoftGraphNetworkInterface[]>] [-OS <String>] [-OSVersion <String>]
 [-ParentHost <String>] [-RelatedHostIds <String[]>] [-RiskScore <String>] [-Tags <String[]>]
 [-VendorInformation <IMicrosoftGraphSecurityVendorInformation>] [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgSecurityHostSecurityProfile -InputObject <ISecurityIdentity>
 -BodyParameter <IMicrosoftGraphHostSecurityProfile> [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property hostSecurityProfiles in security

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzureSubscriptionId
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzureTenantId
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
hostSecurityProfile
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphHostSecurityProfile
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -FirstSeenDateTime
.

```yaml
Type: DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Fqdn
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HostSecurityProfileId
key: id of hostSecurityProfile

```yaml
Type: String
Parameter Sets: UpdateExpanded, Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: ISecurityIdentity
Parameter Sets: UpdateViaIdentityExpanded, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsAzureAdJoined
.

```yaml
Type: SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsAzureAdRegistered
.

```yaml
Type: SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsHybridAzureDomainJoined
.

```yaml
Type: SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastSeenDateTime
.

```yaml
Type: DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LogonUsers
.
To construct, see NOTES section for LOGONUSERS properties and create a hash table.

```yaml
Type: IMicrosoftGraphLogonUser[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetBiosName
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkInterfaces
.
To construct, see NOTES section for NETWORKINTERFACES properties and create a hash table.

```yaml
Type: IMicrosoftGraphNetworkInterface[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OS
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OSVersion
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ParentHost
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RelatedHostIds
.

```yaml
Type: String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RiskScore
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tags
.

```yaml
Type: String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VendorInformation
securityVendorInformation
To construct, see NOTES section for VENDORINFORMATION properties and create a hash table.

```yaml
Type: IMicrosoftGraphSecurityVendorInformation
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphHostSecurityProfile

### Microsoft.Graph.PowerShell.Models.ISecurityIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphHostSecurityProfile>: hostSecurityProfile
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[AzureSubscriptionId <String>]`: 
  - `[AzureTenantId <String>]`: 
  - `[FirstSeenDateTime <DateTime?>]`: 
  - `[Fqdn <String>]`: 
  - `[IsAzureAdJoined <Boolean?>]`: 
  - `[IsAzureAdRegistered <Boolean?>]`: 
  - `[IsHybridAzureDomainJoined <Boolean?>]`: 
  - `[LastSeenDateTime <DateTime?>]`: 
  - `[LogonUsers <IMicrosoftGraphLogonUser[]>]`: 
    - `[AccountDomain <String>]`: Domain of user account used to logon.
    - `[AccountName <String>]`: Account name of user account used to logon.
    - `[AccountType <String>]`: userAccountSecurityType
    - `[FirstSeenDateTime <DateTime?>]`: DateTime at which the earliest logon by this user account occurred (provider-determined period). The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[LastSeenDateTime <DateTime?>]`: DateTime at which the latest logon by this user account occurred. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[LogonId <String>]`: User logon ID.
    - `[LogonTypes <String[]>]`: Collection of the logon types observed for the logged on user from when first to last seen. Possible values are: unknown, interactive, remoteInteractive, network, batch, service.
  - `[NetBiosName <String>]`: 
  - `[NetworkInterfaces <IMicrosoftGraphNetworkInterface[]>]`: 
    - `[Description <String>]`: Description of the NIC (e.g. Ethernet adapter, Wireless LAN adapter Local Area Connection <#/>, etc.).
    - `[IPV4Address <String>]`: Last IPv4 address associated with this NIC.
    - `[IPV6Address <String>]`: Last Public (aka global) IPv6 address associated with this NIC.
    - `[LocalIPV6Address <String>]`: Last local (link-local or site-local) IPv6 address associated with this NIC.
    - `[MacAddress <String>]`: MAC address of the NIC on this host.
  - `[OS <String>]`: 
  - `[OSVersion <String>]`: 
  - `[ParentHost <String>]`: 
  - `[RelatedHostIds <String[]>]`: 
  - `[RiskScore <String>]`: 
  - `[Tags <String[]>]`: 
  - `[VendorInformation <IMicrosoftGraphSecurityVendorInformation>]`: securityVendorInformation
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Provider <String>]`: Specific provider (product/service - not vendor company); for example, WindowsDefenderATP.
    - `[ProviderVersion <String>]`: Version of the provider or subprovider, if it exists, that generated the alert. Required
    - `[SubProvider <String>]`: Specific subprovider (under aggregating provider); for example, WindowsDefenderATP.SmartScreen.
    - `[Vendor <String>]`: Name of the alert vendor (for example, Microsoft, Dell, FireEye). Required

INPUTOBJECT <ISecurityIdentity>: Identity Parameter
  - `[AlertId <String>]`: key: id of alert
  - `[CloudAppSecurityProfileId <String>]`: key: id of cloudAppSecurityProfile
  - `[DomainSecurityProfileId <String>]`: key: id of domainSecurityProfile
  - `[FileSecurityProfileId <String>]`: key: id of fileSecurityProfile
  - `[HostSecurityProfileId <String>]`: key: id of hostSecurityProfile
  - `[IPSecurityProfileId <String>]`: key: id of ipSecurityProfile
  - `[ProviderTenantSettingId <String>]`: key: id of providerTenantSetting
  - `[SecureScoreControlProfileId <String>]`: key: id of secureScoreControlProfile
  - `[SecureScoreId <String>]`: key: id of secureScore
  - `[SecurityActionId <String>]`: key: id of securityAction
  - `[TiIndicatorId <String>]`: key: id of tiIndicator
  - `[UserSecurityProfileId <String>]`: key: id of userSecurityProfile

LOGONUSERS <IMicrosoftGraphLogonUser[]>: .
  - `[AccountDomain <String>]`: Domain of user account used to logon.
  - `[AccountName <String>]`: Account name of user account used to logon.
  - `[AccountType <String>]`: userAccountSecurityType
  - `[FirstSeenDateTime <DateTime?>]`: DateTime at which the earliest logon by this user account occurred (provider-determined period). The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[LastSeenDateTime <DateTime?>]`: DateTime at which the latest logon by this user account occurred. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[LogonId <String>]`: User logon ID.
  - `[LogonTypes <String[]>]`: Collection of the logon types observed for the logged on user from when first to last seen. Possible values are: unknown, interactive, remoteInteractive, network, batch, service.

NETWORKINTERFACES <IMicrosoftGraphNetworkInterface[]>: .
  - `[Description <String>]`: Description of the NIC (e.g. Ethernet adapter, Wireless LAN adapter Local Area Connection <#/>, etc.).
  - `[IPV4Address <String>]`: Last IPv4 address associated with this NIC.
  - `[IPV6Address <String>]`: Last Public (aka global) IPv6 address associated with this NIC.
  - `[LocalIPV6Address <String>]`: Last local (link-local or site-local) IPv6 address associated with this NIC.
  - `[MacAddress <String>]`: MAC address of the NIC on this host.

VENDORINFORMATION <IMicrosoftGraphSecurityVendorInformation>: securityVendorInformation
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Provider <String>]`: Specific provider (product/service - not vendor company); for example, WindowsDefenderATP.
  - `[ProviderVersion <String>]`: Version of the provider or subprovider, if it exists, that generated the alert. Required
  - `[SubProvider <String>]`: Specific subprovider (under aggregating provider); for example, WindowsDefenderATP.SmartScreen.
  - `[Vendor <String>]`: Name of the alert vendor (for example, Microsoft, Dell, FireEye). Required

## RELATED LINKS
