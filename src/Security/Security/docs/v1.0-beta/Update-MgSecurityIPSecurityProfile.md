---
external help file:
Module Name: Microsoft.Graph.Security
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/update-mgsecurityipsecurityprofile
schema: 2.0.0
---

# Update-MgSecurityIPSecurityProfile

## SYNOPSIS
Update the navigation property ipSecurityProfiles in Security

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgSecurityIPSecurityProfile -IPSecurityProfileId <String> [-ActivityGroupNames <String[]>]
 [-Address <String>] [-AzureSubscriptionId <String>] [-AzureTenantId <String>] [-CountHits <Int32>]
 [-CountHosts <Int32>] [-FirstSeenDateTime <DateTime>] [-Id <String>]
 [-IPCategories <IMicrosoftGraphIPCategory[]>] [-IPReferenceData <IMicrosoftGraphIPReferenceData[]>]
 [-LastSeenDateTime <DateTime>] [-RiskScore <String>] [-Tags <String[]>] [-VendorInformationProvider <String>]
 [-VendorInformationProviderVersion <String>] [-VendorInformationSubProvider <String>]
 [-VendorInformationVendor <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgSecurityIPSecurityProfile -IPSecurityProfileId <String>
 -BodyParameter <IMicrosoftGraphIPSecurityProfile> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgSecurityIPSecurityProfile -InputObject <ISecurityIdentity>
 -BodyParameter <IMicrosoftGraphIPSecurityProfile> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgSecurityIPSecurityProfile -InputObject <ISecurityIdentity> [-ActivityGroupNames <String[]>]
 [-Address <String>] [-AzureSubscriptionId <String>] [-AzureTenantId <String>] [-CountHits <Int32>]
 [-CountHosts <Int32>] [-FirstSeenDateTime <DateTime>] [-Id <String>]
 [-IPCategories <IMicrosoftGraphIPCategory[]>] [-IPReferenceData <IMicrosoftGraphIPReferenceData[]>]
 [-LastSeenDateTime <DateTime>] [-RiskScore <String>] [-Tags <String[]>] [-VendorInformationProvider <String>]
 [-VendorInformationProviderVersion <String>] [-VendorInformationSubProvider <String>]
 [-VendorInformationVendor <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property ipSecurityProfiles in Security

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

### -ActivityGroupNames
.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Address
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
```

### -AzureSubscriptionId
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
```

### -AzureTenantId
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
```

### -BodyParameter
ipSecurityProfile
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIPSecurityProfile
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CountHits
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
```

### -CountHosts
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
```

### -FirstSeenDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: System.String
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
Type: Microsoft.Graph.PowerShell.Models.ISecurityIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IPCategories
.
To construct, see NOTES section for IPCATEGORIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIPCategory[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IPReferenceData
.
To construct, see NOTES section for IPREFERENCEDATA properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIPReferenceData[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IPSecurityProfileId
key: ipSecurityProfile-id of ipSecurityProfile

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastSeenDateTime
.

```yaml
Type: System.DateTime
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
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
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
Type: System.String
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
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VendorInformationProvider
Specific provider (product/service - not vendor company); for example, WindowsDefenderATP.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VendorInformationProviderVersion
Version of the provider or subprovider, if it exists, that generated the alert.
Required

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VendorInformationSubProvider
Specific subprovider (under aggregating provider); for example, WindowsDefenderATP.SmartScreen.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VendorInformationVendor
Name of the alert vendor (for example, Microsoft, Dell, FireEye).
Required

```yaml
Type: System.String
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIPSecurityProfile

### Microsoft.Graph.PowerShell.Models.ISecurityIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphIPSecurityProfile>: ipSecurityProfile
  - `[Id <String>]`: Read-only.
  - `[ActivityGroupNames <String[]>]`: 
  - `[Address <String>]`: 
  - `[AzureSubscriptionId <String>]`: 
  - `[AzureTenantId <String>]`: 
  - `[CountHits <Int32?>]`: 
  - `[CountHosts <Int32?>]`: 
  - `[FirstSeenDateTime <DateTime?>]`: 
  - `[IPCategories <IMicrosoftGraphIPCategory[]>]`: 
    - `[Description <String>]`: 
    - `[Name <String>]`: 
    - `[Vendor <String>]`: 
  - `[IPReferenceData <IMicrosoftGraphIPReferenceData[]>]`: 
    - `[Asn <Int32?>]`: 
    - `[City <String>]`: 
    - `[CountryOrRegionCode <String>]`: 
    - `[Organization <String>]`: 
    - `[State <String>]`: 
    - `[Vendor <String>]`: 
  - `[LastSeenDateTime <DateTime?>]`: 
  - `[RiskScore <String>]`: 
  - `[Tags <String[]>]`: 
  - `[VendorInformationProvider <String>]`: Specific provider (product/service - not vendor company); for example, WindowsDefenderATP.
  - `[VendorInformationProviderVersion <String>]`: Version of the provider or subprovider, if it exists, that generated the alert. Required
  - `[VendorInformationSubProvider <String>]`: Specific subprovider (under aggregating provider); for example, WindowsDefenderATP.SmartScreen.
  - `[VendorInformationVendor <String>]`: Name of the alert vendor (for example, Microsoft, Dell, FireEye). Required

INPUTOBJECT <ISecurityIdentity>: Identity Parameter
  - `[AlertId <String>]`: key: alert-id of alert
  - `[CloudAppSecurityProfileId <String>]`: key: cloudAppSecurityProfile-id of cloudAppSecurityProfile
  - `[DomainSecurityProfileId <String>]`: key: domainSecurityProfile-id of domainSecurityProfile
  - `[FileSecurityProfileId <String>]`: key: fileSecurityProfile-id of fileSecurityProfile
  - `[HostSecurityProfileId <String>]`: key: hostSecurityProfile-id of hostSecurityProfile
  - `[IPSecurityProfileId <String>]`: key: ipSecurityProfile-id of ipSecurityProfile
  - `[ProviderTenantSettingId <String>]`: key: providerTenantSetting-id of providerTenantSetting
  - `[SecureScoreControlProfileId <String>]`: key: secureScoreControlProfile-id of secureScoreControlProfile
  - `[SecureScoreId <String>]`: key: secureScore-id of secureScore
  - `[SecurityActionId <String>]`: key: securityAction-id of securityAction
  - `[TiIndicatorId <String>]`: key: tiIndicator-id of tiIndicator
  - `[UserSecurityProfileId <String>]`: key: userSecurityProfile-id of userSecurityProfile

IPCATEGORIES <IMicrosoftGraphIPCategory[]>: .
  - `[Description <String>]`: 
  - `[Name <String>]`: 
  - `[Vendor <String>]`: 

IPREFERENCEDATA <IMicrosoftGraphIPReferenceData[]>: .
  - `[Asn <Int32?>]`: 
  - `[City <String>]`: 
  - `[CountryOrRegionCode <String>]`: 
  - `[Organization <String>]`: 
  - `[State <String>]`: 
  - `[Vendor <String>]`: 

## RELATED LINKS

