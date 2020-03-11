---
external help file:
Module Name: Microsoft.Graph.Security
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/new-mgsecurityhostsecurityprofile
schema: 2.0.0
---

# New-MgSecurityHostSecurityProfile

## SYNOPSIS
Create new navigation property to hostSecurityProfiles for Security

## SYNTAX

### CreateExpanded (Default)
```
New-MgSecurityHostSecurityProfile [-AzureSubscriptionId <String>] [-AzureTenantId <String>]
 [-FirstSeenDateTime <DateTime>] [-Fqdn <String>] [-Id <String>] [-IsAzureAdJoined] [-IsAzureAdRegistered]
 [-IsHybridAzureDomainJoined] [-LastSeenDateTime <DateTime>] [-LogonUsers <IMicrosoftGraphLogonUser[]>]
 [-NetBiosName <String>] [-NetworkInterfaces <IMicrosoftGraphNetworkInterface[]>] [-OS <String>]
 [-OSVersion <String>] [-ParentHost <String>] [-RelatedHostIds <String[]>] [-RiskScore <String>]
 [-Tags <String[]>] [-VendorInformationProvider <String>] [-VendorInformationProviderVersion <String>]
 [-VendorInformationSubProvider <String>] [-VendorInformationVendor <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgSecurityHostSecurityProfile -BodyParameter <IMicrosoftGraphHostSecurityProfile> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to hostSecurityProfiles for Security

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

### -AzureSubscriptionId
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
Dynamic: False
```

### -AzureTenantId
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
Dynamic: False
```

### -BodyParameter
hostSecurityProfile
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphHostSecurityProfile
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -FirstSeenDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Fqdn
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
Dynamic: False
```

### -Id
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
Dynamic: False
```

### -IsAzureAdJoined
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -IsAzureAdRegistered
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -IsHybridAzureDomainJoined
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -LastSeenDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -LogonUsers
.
To construct, see NOTES section for LOGONUSERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphLogonUser[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -NetBiosName
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
Dynamic: False
```

### -NetworkInterfaces
.
To construct, see NOTES section for NETWORKINTERFACES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphNetworkInterface[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -OS
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
Dynamic: False
```

### -OSVersion
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
Dynamic: False
```

### -ParentHost
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
Dynamic: False
```

### -RelatedHostIds
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RiskScore
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
Dynamic: False
```

### -Tags
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -VendorInformationProvider
Specific provider (product/service - not vendor company); for example, WindowsDefenderATP.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -VendorInformationProviderVersion
Version of the provider or subprovider, if it exists, that generated the alert.
Required

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -VendorInformationSubProvider
Specific subprovider (under aggregating provider); for example, WindowsDefenderATP.SmartScreen.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -VendorInformationVendor
Name of the alert vendor (for example, Microsoft, Dell, FireEye).
Required

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphHostSecurityProfile

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphHostSecurityProfile

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphHostSecurityProfile>: hostSecurityProfile
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
    - `[AccountDomain <String>]`: 
    - `[AccountName <String>]`: 
    - `[AccountType <String>]`: userAccountSecurityType
    - `[FirstSeenDateTime <DateTime?>]`: 
    - `[LastSeenDateTime <DateTime?>]`: 
    - `[LogonId <String>]`: 
    - `[LogonTypes <String[]>]`: 
  - `[NetBiosName <String>]`: 
  - `[NetworkInterfaces <IMicrosoftGraphNetworkInterface[]>]`: 
    - `[Description <String>]`: 
    - `[IPV4Address <String>]`: 
    - `[IPV6Address <String>]`: 
    - `[LocalIPV6Address <String>]`: 
    - `[MacAddress <String>]`: 
  - `[OS <String>]`: 
  - `[OSVersion <String>]`: 
  - `[ParentHost <String>]`: 
  - `[RelatedHostIds <String[]>]`: 
  - `[RiskScore <String>]`: 
  - `[Tags <String[]>]`: 
  - `[VendorInformationProvider <String>]`: Specific provider (product/service - not vendor company); for example, WindowsDefenderATP.
  - `[VendorInformationProviderVersion <String>]`: Version of the provider or subprovider, if it exists, that generated the alert. Required
  - `[VendorInformationSubProvider <String>]`: Specific subprovider (under aggregating provider); for example, WindowsDefenderATP.SmartScreen.
  - `[VendorInformationVendor <String>]`: Name of the alert vendor (for example, Microsoft, Dell, FireEye). Required

#### LOGONUSERS <IMicrosoftGraphLogonUser[]>: .
  - `[AccountDomain <String>]`: 
  - `[AccountName <String>]`: 
  - `[AccountType <String>]`: userAccountSecurityType
  - `[FirstSeenDateTime <DateTime?>]`: 
  - `[LastSeenDateTime <DateTime?>]`: 
  - `[LogonId <String>]`: 
  - `[LogonTypes <String[]>]`: 

#### NETWORKINTERFACES <IMicrosoftGraphNetworkInterface[]>: .
  - `[Description <String>]`: 
  - `[IPV4Address <String>]`: 
  - `[IPV6Address <String>]`: 
  - `[LocalIPV6Address <String>]`: 
  - `[MacAddress <String>]`: 

## RELATED LINKS

