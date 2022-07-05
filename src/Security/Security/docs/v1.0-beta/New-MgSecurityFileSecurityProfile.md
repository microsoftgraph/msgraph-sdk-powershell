---
external help file:
Module Name: Microsoft.Graph.Security
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/new-mgsecurityfilesecurityprofile
schema: 2.0.0
---

# New-MgSecurityFileSecurityProfile

## SYNOPSIS
Create new navigation property to fileSecurityProfiles for security

## SYNTAX

### CreateExpanded (Default)
```
New-MgSecurityFileSecurityProfile [-ActivityGroupNames <String[]>] [-AdditionalProperties <Hashtable>]
 [-AzureSubscriptionId <String>] [-AzureTenantId <String>] [-CertificateThumbprint <String>]
 [-Extensions <String[]>] [-FileType <String>] [-FirstSeenDateTime <DateTime>]
 [-Hashes <IMicrosoftGraphFileHash[]>] [-Id <String>] [-LastSeenDateTime <DateTime>]
 [-MalwareStates <IMicrosoftGraphMalwareState[]>] [-Names <String[]>] [-RiskScore <String>] [-Size <Int64>]
 [-Tags <String[]>] [-VendorInformation <IMicrosoftGraphSecurityVendorInformation>]
 [-VulnerabilityStates <IMicrosoftGraphVulnerabilityState[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgSecurityFileSecurityProfile -BodyParameter <IMicrosoftGraphFileSecurityProfile> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to fileSecurityProfiles for security

## EXAMPLES

## PARAMETERS

### -ActivityGroupNames
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
```

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
```

### -BodyParameter
fileSecurityProfile
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphFileSecurityProfile
Parameter Sets: Create
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FileType
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
```

### -Hashes
.
To construct, please use Get-Help -Online and see NOTES section for HASHES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphFileHash[]
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
```

### -MalwareStates
.
To construct, please use Get-Help -Online and see NOTES section for MALWARESTATES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMalwareState[]
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VendorInformation
securityVendorInformation
To construct, please use Get-Help -Online and see NOTES section for VENDORINFORMATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityVendorInformation
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VulnerabilityStates
.
To construct, please use Get-Help -Online and see NOTES section for VULNERABILITYSTATES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphVulnerabilityState[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphFileSecurityProfile

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphFileSecurityProfile

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphFileSecurityProfile>: fileSecurityProfile
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
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
  - `[VendorInformation <IMicrosoftGraphSecurityVendorInformation>]`: securityVendorInformation
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Provider <String>]`: Specific provider (product/service - not vendor company); for example, WindowsDefenderATP.
    - `[ProviderVersion <String>]`: Version of the provider or subprovider, if it exists, that generated the alert. Required
    - `[SubProvider <String>]`: Specific subprovider (under aggregating provider); for example, WindowsDefenderATP.SmartScreen.
    - `[Vendor <String>]`: Name of the alert vendor (for example, Microsoft, Dell, FireEye). Required
  - `[VulnerabilityStates <IMicrosoftGraphVulnerabilityState[]>]`: 
    - `[Cve <String>]`: Common Vulnerabilities and Exposures (CVE) for the vulnerability.
    - `[Severity <String>]`: Base Common Vulnerability Scoring System (CVSS) severity score for this vulnerability.
    - `[WasRunning <Boolean?>]`: Indicates whether the detected vulnerability (file) was running at the time of detection or was the file detected at rest on the disk.

HASHES <IMicrosoftGraphFileHash[]>: .
  - `[HashType <String>]`: fileHashType
  - `[HashValue <String>]`: Value of the file hash.

MALWARESTATES <IMicrosoftGraphMalwareState[]>: .
  - `[Category <String>]`: Provider-generated malware category (for example, trojan, ransomware, etc.).
  - `[Family <String>]`: Provider-generated malware family (for example, 'wannacry', 'notpetya', etc.).
  - `[Name <String>]`: Provider-generated malware variant name (for example, Trojan:Win32/Powessere.H).
  - `[Severity <String>]`: Provider-determined severity of this malware.
  - `[WasRunning <Boolean?>]`: Indicates whether the detected file (malware/vulnerability) was running at the time of detection or was detected at rest on the disk.

VENDORINFORMATION <IMicrosoftGraphSecurityVendorInformation>: securityVendorInformation
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Provider <String>]`: Specific provider (product/service - not vendor company); for example, WindowsDefenderATP.
  - `[ProviderVersion <String>]`: Version of the provider or subprovider, if it exists, that generated the alert. Required
  - `[SubProvider <String>]`: Specific subprovider (under aggregating provider); for example, WindowsDefenderATP.SmartScreen.
  - `[Vendor <String>]`: Name of the alert vendor (for example, Microsoft, Dell, FireEye). Required

VULNERABILITYSTATES <IMicrosoftGraphVulnerabilityState[]>: .
  - `[Cve <String>]`: Common Vulnerabilities and Exposures (CVE) for the vulnerability.
  - `[Severity <String>]`: Base Common Vulnerability Scoring System (CVSS) severity score for this vulnerability.
  - `[WasRunning <Boolean?>]`: Indicates whether the detected vulnerability (file) was running at the time of detection or was the file detected at rest on the disk.

## RELATED LINKS

