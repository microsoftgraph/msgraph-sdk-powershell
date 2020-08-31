---
external help file:
Module Name: Microsoft.Graph.Security
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/update-mgsecurityfilesecurityprofile
schema: 2.0.0
---

# Update-MgSecurityFileSecurityProfile

## SYNOPSIS
Update the navigation property fileSecurityProfiles in Security

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgSecurityFileSecurityProfile -FileSecurityProfileId <String> [-ActivityGroupNames <String[]>]
 [-AzureSubscriptionId <String>] [-AzureTenantId <String>] [-CertificateThumbprint <String>]
 [-Extensions <String[]>] [-FileType <String>] [-FirstSeenDateTime <DateTime>]
 [-Hashes <IMicrosoftGraphFileHash[]>] [-Id <String>] [-LastSeenDateTime <DateTime>]
 [-MalwareStates <IMicrosoftGraphMalwareState[]>] [-Names <String[]>] [-RiskScore <String>] [-Size <Int64>]
 [-Tags <String[]>] [-VendorInformationProvider <String>] [-VendorInformationProviderVersion <String>]
 [-VendorInformationSubProvider <String>] [-VendorInformationVendor <String>]
 [-VulnerabilityStates <IMicrosoftGraphVulnerabilityState[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgSecurityFileSecurityProfile -FileSecurityProfileId <String>
 -BodyParameter <IMicrosoftGraphFileSecurityProfile> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgSecurityFileSecurityProfile -InputObject <ISecurityIdentity>
 -BodyParameter <IMicrosoftGraphFileSecurityProfile> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgSecurityFileSecurityProfile -InputObject <ISecurityIdentity> [-ActivityGroupNames <String[]>]
 [-AzureSubscriptionId <String>] [-AzureTenantId <String>] [-CertificateThumbprint <String>]
 [-Extensions <String[]>] [-FileType <String>] [-FirstSeenDateTime <DateTime>]
 [-Hashes <IMicrosoftGraphFileHash[]>] [-Id <String>] [-LastSeenDateTime <DateTime>]
 [-MalwareStates <IMicrosoftGraphMalwareState[]>] [-Names <String[]>] [-RiskScore <String>] [-Size <Int64>]
 [-Tags <String[]>] [-VendorInformationProvider <String>] [-VendorInformationProviderVersion <String>]
 [-VendorInformationSubProvider <String>] [-VendorInformationVendor <String>]
 [-VulnerabilityStates <IMicrosoftGraphVulnerabilityState[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property fileSecurityProfiles in Security

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
fileSecurityProfile
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphFileSecurityProfile
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CertificateThumbprint
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

### -Extensions
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

### -FileSecurityProfileId
key: fileSecurityProfile-id of fileSecurityProfile

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

### -FileType
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

### -Hashes
.
To construct, see NOTES section for HASHES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphFileHash[]
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

### -MalwareStates
.
To construct, see NOTES section for MALWARESTATES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMalwareState[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Names
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

### -Size
.

```yaml
Type: System.Int64
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

### -VulnerabilityStates
.
To construct, see NOTES section for VULNERABILITYSTATES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphVulnerabilityState[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphFileSecurityProfile

### Microsoft.Graph.PowerShell.Models.ISecurityIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphFileSecurityProfile>: fileSecurityProfile
  - `[Id <String>]`: Read-only.
  - `[ActivityGroupNames <String[]>]`: 
  - `[AzureSubscriptionId <String>]`: 
  - `[AzureTenantId <String>]`: 
  - `[CertificateThumbprint <String>]`: 
  - `[Extensions <String[]>]`: 
  - `[FileType <String>]`: 
  - `[FirstSeenDateTime <DateTime?>]`: 
  - `[Hashes <IMicrosoftGraphFileHash[]>]`: 
    - `[HashType <String>]`: fileHashType
    - `[HashValue <String>]`: Value of the file hash.
  - `[LastSeenDateTime <DateTime?>]`: 
  - `[MalwareStates <IMicrosoftGraphMalwareState[]>]`: 
    - `[Category <String>]`: Provider-generated malware category (for example, trojan, ransomware, etc.).
    - `[Family <String>]`: Provider-generated malware family (for example, 'wannacry', 'notpetya', etc.).
    - `[Name <String>]`: Provider-generated malware variant name (for example, Trojan:Win32/Powessere.H).
    - `[Severity <String>]`: Provider-determined severity of this malware.
    - `[WasRunning <Boolean?>]`: Indicates whether the detected file (malware/vulnerability) was running at the time of detection or was detected at rest on the disk.
  - `[Names <String[]>]`: 
  - `[RiskScore <String>]`: 
  - `[Size <Int64?>]`: 
  - `[Tags <String[]>]`: 
  - `[VendorInformationProvider <String>]`: Specific provider (product/service - not vendor company); for example, WindowsDefenderATP.
  - `[VendorInformationProviderVersion <String>]`: Version of the provider or subprovider, if it exists, that generated the alert. Required
  - `[VendorInformationSubProvider <String>]`: Specific subprovider (under aggregating provider); for example, WindowsDefenderATP.SmartScreen.
  - `[VendorInformationVendor <String>]`: Name of the alert vendor (for example, Microsoft, Dell, FireEye). Required
  - `[VulnerabilityStates <IMicrosoftGraphVulnerabilityState[]>]`: 
    - `[Cve <String>]`: Common Vulnerabilities and Exposures (CVE) for the vulnerability.
    - `[Severity <String>]`: Base Common Vulnerability Scoring System (CVSS) severity score for this vulnerability.
    - `[WasRunning <Boolean?>]`: Indicates whether the detected vulnerability (file) was running at the time of detection or was the file detected at rest on the disk.

HASHES <IMicrosoftGraphFileHash[]>: .
  - `[HashType <String>]`: fileHashType
  - `[HashValue <String>]`: Value of the file hash.

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

MALWARESTATES <IMicrosoftGraphMalwareState[]>: .
  - `[Category <String>]`: Provider-generated malware category (for example, trojan, ransomware, etc.).
  - `[Family <String>]`: Provider-generated malware family (for example, 'wannacry', 'notpetya', etc.).
  - `[Name <String>]`: Provider-generated malware variant name (for example, Trojan:Win32/Powessere.H).
  - `[Severity <String>]`: Provider-determined severity of this malware.
  - `[WasRunning <Boolean?>]`: Indicates whether the detected file (malware/vulnerability) was running at the time of detection or was detected at rest on the disk.

VULNERABILITYSTATES <IMicrosoftGraphVulnerabilityState[]>: .
  - `[Cve <String>]`: Common Vulnerabilities and Exposures (CVE) for the vulnerability.
  - `[Severity <String>]`: Base Common Vulnerability Scoring System (CVSS) severity score for this vulnerability.
  - `[WasRunning <Boolean?>]`: Indicates whether the detected vulnerability (file) was running at the time of detection or was the file detected at rest on the disk.

## RELATED LINKS

