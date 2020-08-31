---
external help file:
Module Name: Microsoft.Graph.Security
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/new-mgsecuritysecurescore
schema: 2.0.0
---

# New-MgSecuritySecureScore

## SYNOPSIS
Create new navigation property to secureScores for Security

## SYNTAX

### CreateExpanded (Default)
```
New-MgSecuritySecureScore [-ActiveUserCount <Int32>]
 [-AverageComparativeScores <IMicrosoftGraphAverageComparativeScore[]>] [-AzureTenantId <String>]
 [-ControlScores <IMicrosoftGraphControlScore[]>] [-CreatedDateTime <DateTime>] [-CurrentScore <Double>]
 [-EnabledServices <String[]>] [-Id <String>] [-LicensedUserCount <Int32>] [-MaxScore <Double>]
 [-VendorInformationProvider <String>] [-VendorInformationProviderVersion <String>]
 [-VendorInformationSubProvider <String>] [-VendorInformationVendor <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgSecuritySecureScore -BodyParameter <IMicrosoftGraphSecureScore> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to secureScores for Security

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

### -ActiveUserCount
Active user count of the given tenant.

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

### -AverageComparativeScores
Average score by different scopes (for example, average by industry, average by seating) and control category (Identity, Data, Device, Apps, Infrastructure) within the scope.
To construct, see NOTES section for AVERAGECOMPARATIVESCORES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAverageComparativeScore[]
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
secureScore
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecureScore
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ControlScores
Contains tenant scores for a set of controls.
To construct, see NOTES section for CONTROLSCORES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphControlScore[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The date when the entity is created.

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

### -CurrentScore
Tenant current attained score on specified date.

```yaml
Type: System.Double
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EnabledServices
Microsoft-provided services for the tenant (for example, Exchange online, Skype, Sharepoint).

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

### -LicensedUserCount
Licensed user count of the given tenant.

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

### -MaxScore
Tenant maximum possible score on specified date.

```yaml
Type: System.Double
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecureScore

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecureScore

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


AVERAGECOMPARATIVESCORES <IMicrosoftGraphAverageComparativeScore[]>: Average score by different scopes (for example, average by industry, average by seating) and control category (Identity, Data, Device, Apps, Infrastructure) within the scope.
  - `[AverageScore <Double?>]`: Average score within specified basis.
  - `[Basis <String>]`: Scope type. The possible values are: AllTenants, TotalSeats, IndustryTypes.

BODYPARAMETER <IMicrosoftGraphSecureScore>: secureScore
  - `[Id <String>]`: Read-only.
  - `[ActiveUserCount <Int32?>]`: Active user count of the given tenant.
  - `[AverageComparativeScores <IMicrosoftGraphAverageComparativeScore[]>]`: Average score by different scopes (for example, average by industry, average by seating) and control category (Identity, Data, Device, Apps, Infrastructure) within the scope.
    - `[AverageScore <Double?>]`: Average score within specified basis.
    - `[Basis <String>]`: Scope type. The possible values are: AllTenants, TotalSeats, IndustryTypes.
  - `[AzureTenantId <String>]`: GUID string for tenant ID.
  - `[ControlScores <IMicrosoftGraphControlScore[]>]`: Contains tenant scores for a set of controls.
    - `[ControlCategory <String>]`: Control action category (Identity, Data, Device, Apps, Infrastructure).
    - `[ControlName <String>]`: Control unique name.
    - `[Description <String>]`: Description of the control.
    - `[Score <Double?>]`: Tenant achieved score for the control (it varies day by day depending on tenant operations on the control).
  - `[CreatedDateTime <DateTime?>]`: The date when the entity is created.
  - `[CurrentScore <Double?>]`: Tenant current attained score on specified date.
  - `[EnabledServices <String[]>]`: Microsoft-provided services for the tenant (for example, Exchange online, Skype, Sharepoint).
  - `[LicensedUserCount <Int32?>]`: Licensed user count of the given tenant.
  - `[MaxScore <Double?>]`: Tenant maximum possible score on specified date.
  - `[VendorInformationProvider <String>]`: Specific provider (product/service - not vendor company); for example, WindowsDefenderATP.
  - `[VendorInformationProviderVersion <String>]`: Version of the provider or subprovider, if it exists, that generated the alert. Required
  - `[VendorInformationSubProvider <String>]`: Specific subprovider (under aggregating provider); for example, WindowsDefenderATP.SmartScreen.
  - `[VendorInformationVendor <String>]`: Name of the alert vendor (for example, Microsoft, Dell, FireEye). Required

CONTROLSCORES <IMicrosoftGraphControlScore[]>: Contains tenant scores for a set of controls.
  - `[ControlCategory <String>]`: Control action category (Identity, Data, Device, Apps, Infrastructure).
  - `[ControlName <String>]`: Control unique name.
  - `[Description <String>]`: Description of the control.
  - `[Score <Double?>]`: Tenant achieved score for the control (it varies day by day depending on tenant operations on the control).

## RELATED LINKS

