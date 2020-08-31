---
external help file:
Module Name: Microsoft.Graph.Security
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/new-mgsecuritysecurescorecontrolprofile
schema: 2.0.0
---

# New-MgSecuritySecureScoreControlProfile

## SYNOPSIS
Create new navigation property to secureScoreControlProfiles for Security

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgSecuritySecureScoreControlProfile [-ActionType <String>] [-ActionUrl <String>] [-AzureTenantId <String>]
 [-ComplianceInformation <IMicrosoftGraphComplianceInformation[]>] [-ControlCategory <String>]
 [-ControlStateUpdates <IMicrosoftGraphSecureScoreControlStateUpdate[]>] [-Deprecated] [-Id <String>]
 [-ImplementationCost <String>] [-LastModifiedDateTime <DateTime>] [-MaxScore <Double>] [-Rank <Int32>]
 [-Remediation <String>] [-RemediationImpact <String>] [-Service <String>] [-Threats <String[]>]
 [-Tier <String>] [-Title <String>] [-UserImpact <String>] [-VendorInformationProvider <String>]
 [-VendorInformationProviderVersion <String>] [-VendorInformationSubProvider <String>]
 [-VendorInformationVendor <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgSecuritySecureScoreControlProfile -BodyParameter <IMicrosoftGraphSecureScoreControlProfile> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to secureScoreControlProfiles for Security

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

### -ActionType
Control action type (Config, Review, Behavior).

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ActionUrl
URL to where the control can be actioned.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzureTenantId
GUID string for tenant ID.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
secureScoreControlProfile
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecureScoreControlProfile
Parameter Sets: Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ComplianceInformation
.
To construct, see NOTES section for COMPLIANCEINFORMATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphComplianceInformation[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ControlCategory
Control action category (Identity, Data, Device, Apps, Infrastructure).

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ControlStateUpdates
.
To construct, see NOTES section for CONTROLSTATEUPDATES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecureScoreControlStateUpdate[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Deprecated
Flag to indicate if a control is depreciated.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImplementationCost
Resource cost of implemmentating control (low, moderate, high).

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
Time at which the control profile entity was last modified.
The Timestamp type represents date and time

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MaxScore
max attainable score for the control.

```yaml
Type: System.Double
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Rank
Microsoft's stack ranking of control.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Remediation
Description of what the control will help remediate.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RemediationImpact
Description of the impact on users of the remediation.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Service
Service that owns the control (Exchange, Sharepoint, Azure AD).

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Threats
List of threats the control mitigates (accountBreach,dataDeletion,dataExfiltration,dataSpillage,

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tier
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Title
Title of the control.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserImpact
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecureScoreControlProfile

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecureScoreControlProfile

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphSecureScoreControlProfile>: secureScoreControlProfile
  - `[Id <String>]`: Read-only.
  - `[ActionType <String>]`: Control action type (Config, Review, Behavior).
  - `[ActionUrl <String>]`: URL to where the control can be actioned.
  - `[AzureTenantId <String>]`: GUID string for tenant ID.
  - `[ComplianceInformation <IMicrosoftGraphComplianceInformation[]>]`: 
    - `[CertificationControls <IMicrosoftGraphCertificationControl[]>]`: Collection of the certification controls associated with certification
      - `[Name <String>]`: Certification control name
      - `[Url <String>]`: URL for the Microsoft Service Trust Portal
    - `[CertificationName <String>]`: Compliance certification name (for example, ISO 27018:2014, GDPR, FedRAMP, NIST 800-171)
  - `[ControlCategory <String>]`: Control action category (Identity, Data, Device, Apps, Infrastructure).
  - `[ControlStateUpdates <IMicrosoftGraphSecureScoreControlStateUpdate[]>]`: 
    - `[AssignedTo <String>]`: Assigns the control to the user who will take the action.
    - `[Comment <String>]`: Provides optional comment about the control.
    - `[State <String>]`: State of the control, which can be modified via a PATCH command (for example, ignored, thirdParty).
    - `[UpdatedBy <String>]`: ID of the user who updated tenant state.
    - `[UpdatedDateTime <DateTime?>]`: Time at which the control state was updated.
  - `[Deprecated <Boolean?>]`: Flag to indicate if a control is depreciated.
  - `[ImplementationCost <String>]`: Resource cost of implemmentating control (low, moderate, high).
  - `[LastModifiedDateTime <DateTime?>]`: Time at which the control profile entity was last modified. The Timestamp type represents date and time
  - `[MaxScore <Double?>]`: max attainable score for the control.
  - `[Rank <Int32?>]`: Microsoft's stack ranking of control.
  - `[Remediation <String>]`: Description of what the control will help remediate.
  - `[RemediationImpact <String>]`: Description of the impact on users of the remediation.
  - `[Service <String>]`: Service that owns the control (Exchange, Sharepoint, Azure AD).
  - `[Threats <String[]>]`: List of threats the control mitigates (accountBreach,dataDeletion,dataExfiltration,dataSpillage,
  - `[Tier <String>]`: 
  - `[Title <String>]`: Title of the control.
  - `[UserImpact <String>]`: 
  - `[VendorInformationProvider <String>]`: Specific provider (product/service - not vendor company); for example, WindowsDefenderATP.
  - `[VendorInformationProviderVersion <String>]`: Version of the provider or subprovider, if it exists, that generated the alert. Required
  - `[VendorInformationSubProvider <String>]`: Specific subprovider (under aggregating provider); for example, WindowsDefenderATP.SmartScreen.
  - `[VendorInformationVendor <String>]`: Name of the alert vendor (for example, Microsoft, Dell, FireEye). Required

COMPLIANCEINFORMATION <IMicrosoftGraphComplianceInformation[]>: .
  - `[CertificationControls <IMicrosoftGraphCertificationControl[]>]`: Collection of the certification controls associated with certification
    - `[Name <String>]`: Certification control name
    - `[Url <String>]`: URL for the Microsoft Service Trust Portal
  - `[CertificationName <String>]`: Compliance certification name (for example, ISO 27018:2014, GDPR, FedRAMP, NIST 800-171)

CONTROLSTATEUPDATES <IMicrosoftGraphSecureScoreControlStateUpdate[]>: .
  - `[AssignedTo <String>]`: Assigns the control to the user who will take the action.
  - `[Comment <String>]`: Provides optional comment about the control.
  - `[State <String>]`: State of the control, which can be modified via a PATCH command (for example, ignored, thirdParty).
  - `[UpdatedBy <String>]`: ID of the user who updated tenant state.
  - `[UpdatedDateTime <DateTime?>]`: Time at which the control state was updated.

## RELATED LINKS

