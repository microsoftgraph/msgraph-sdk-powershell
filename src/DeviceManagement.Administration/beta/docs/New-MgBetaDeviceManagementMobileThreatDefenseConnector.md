---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement.Administration
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement.administration/new-mgbetadevicemanagementmobilethreatdefenseconnector
schema: 2.0.0
---

# New-MgBetaDeviceManagementMobileThreatDefenseConnector

## SYNOPSIS
Create new navigation property to mobileThreatDefenseConnectors for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaDeviceManagementMobileThreatDefenseConnector [-AdditionalProperties <Hashtable>]
 [-AllowPartnerToCollectIosApplicationMetadata] [-AllowPartnerToCollectIosPersonalApplicationMetadata]
 [-AndroidDeviceBlockedOnMissingPartnerData] [-AndroidEnabled] [-AndroidMobileApplicationManagementEnabled]
 [-Id <String>] [-IosDeviceBlockedOnMissingPartnerData] [-IosEnabled] [-IosMobileApplicationManagementEnabled]
 [-LastHeartbeatDateTime <DateTime>] [-MacDeviceBlockedOnMissingPartnerData] [-MacEnabled]
 [-MicrosoftDefenderForEndpointAttachEnabled] [-PartnerState <MobileThreatPartnerTenantState>]
 [-PartnerUnresponsivenessThresholdInDays <Int32>] [-PartnerUnsupportedOSVersionBlocked]
 [-WindowsDeviceBlockedOnMissingPartnerData] [-WindowsEnabled] [-WindowsMobileApplicationManagementEnabled]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaDeviceManagementMobileThreatDefenseConnector
 -BodyParameter <IMicrosoftGraphMobileThreatDefenseConnector> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to mobileThreatDefenseConnectors for deviceManagement

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

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

### -AllowPartnerToCollectIosApplicationMetadata
When TRUE, indicates the Mobile Threat Defense partner may collect metadata about installed applications from Intune for IOS devices.
When FALSE, indicates the Mobile Threat Defense partner may not collect metadata about installed applications from Intune for IOS devices.
Default value is FALSE.

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

### -AllowPartnerToCollectIosPersonalApplicationMetadata
When TRUE, indicates the Mobile Threat Defense partner may collect metadata about personally installed applications from Intune for IOS devices.
When FALSE, indicates the Mobile Threat Defense partner may not collect metadata about personally installed applications from Intune for IOS devices.
Default value is FALSE.

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

### -AndroidDeviceBlockedOnMissingPartnerData
For Android, set whether Intune must receive data from the Mobile Threat Defense partner prior to marking a device compliant

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

### -AndroidEnabled
For Android, set whether data from the Mobile Threat Defense partner should be used during compliance evaluations

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

### -AndroidMobileApplicationManagementEnabled
When TRUE, inidicates that data from the Mobile Threat Defense partner can be used during Mobile Application Management (MAM) evaluations for Android devices.
When FALSE, inidicates that data from the Mobile Threat Defense partner should not be used during Mobile Application Management (MAM) evaluations for Android devices.
Only one partner per platform may be enabled for Mobile Application Management (MAM) evaluation.
Default value is FALSE.

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

### -BodyParameter
Entity which represents a connection to Mobile Threat Defense partner.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMobileThreatDefenseConnector
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
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

### -IosDeviceBlockedOnMissingPartnerData
For IOS, set whether Intune must receive data from the Mobile Threat Defense partner prior to marking a device compliant

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

### -IosEnabled
For IOS, get or set whether data from the Mobile Threat Defense partner should be used during compliance evaluations

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

### -IosMobileApplicationManagementEnabled
When TRUE, inidicates that data from the Mobile Threat Defense partner can be used during Mobile Application Management (MAM) evaluations for IOS devices.
When FALSE, inidicates that data from the Mobile Threat Defense partner should not be used during Mobile Application Management (MAM) evaluations for IOS devices.
Only one partner per platform may be enabled for Mobile Application Management (MAM) evaluation.
Default value is FALSE.

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

### -LastHeartbeatDateTime
DateTime of last Heartbeat recieved from the Mobile Threat Defense partner

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

### -MacDeviceBlockedOnMissingPartnerData
For Mac, get or set whether Intune must receive data from the Mobile Threat Defense partner prior to marking a device compliant

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

### -MacEnabled
For Mac, get or set whether data from the Mobile Threat Defense partner should be used during compliance evaluations

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

### -MicrosoftDefenderForEndpointAttachEnabled
When TRUE, inidicates that configuration profile management via Microsoft Defender for Endpoint is enabled.
When FALSE, inidicates that configuration profile management via Microsoft Defender for Endpoint is disabled.
Default value is FALSE.

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

### -PartnerState
Partner state of this tenant.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Support.MobileThreatPartnerTenantState
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PartnerUnresponsivenessThresholdInDays
Get or Set days the per tenant tolerance to unresponsiveness for this partner integration

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

### -PartnerUnsupportedOSVersionBlocked
Get or set whether to block devices on the enabled platforms that do not meet the minimum version requirements of the Mobile Threat Defense partner

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

### -WindowsDeviceBlockedOnMissingPartnerData
When TRUE, inidicates that Intune must receive data from the Mobile Threat Defense partner prior to marking a device compliant for Windows.
When FALSE, inidicates that Intune may make a device compliant without receiving data from the Mobile Threat Defense partner for Windows.
Default value is FALSE.

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

### -WindowsEnabled
When TRUE, inidicates that data from the Mobile Threat Defense partner can be used during compliance evaluations for Windows.
When FALSE, inidicates that data from the Mobile Threat Defense partner should not be used during compliance evaluations for Windows.
Default value is FALSE.

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

### -WindowsMobileApplicationManagementEnabled
When TRUE, app protection policies using the Device Threat Level rule will evaluate devices including data from this connector for Windows.
When FALSE, Intune will not use device risk details sent over this connector during app protection policies calculation for policies with a Device Threat Level configured.
Existing devices that are not compliant due to risk levels obtained from this connector will also become compliant.

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMobileThreatDefenseConnector

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphMobileThreatDefenseConnector

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphMobileThreatDefenseConnector>`: Entity which represents a connection to Mobile Threat Defense partner.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AllowPartnerToCollectIosApplicationMetadata <Boolean?>]`: When TRUE, indicates the Mobile Threat Defense partner may collect metadata about installed applications from Intune for IOS devices. When FALSE, indicates the Mobile Threat Defense partner may not collect metadata about installed applications from Intune for IOS devices. Default value is FALSE.
  - `[AllowPartnerToCollectIosPersonalApplicationMetadata <Boolean?>]`: When TRUE, indicates the Mobile Threat Defense partner may collect metadata about personally installed applications from Intune for IOS devices. When FALSE, indicates the Mobile Threat Defense partner may not collect metadata about personally installed applications from Intune for IOS devices. Default value is FALSE.
  - `[AndroidDeviceBlockedOnMissingPartnerData <Boolean?>]`: For Android, set whether Intune must receive data from the Mobile Threat Defense partner prior to marking a device compliant
  - `[AndroidEnabled <Boolean?>]`: For Android, set whether data from the Mobile Threat Defense partner should be used during compliance evaluations
  - `[AndroidMobileApplicationManagementEnabled <Boolean?>]`: When TRUE, inidicates that data from the Mobile Threat Defense partner can be used during Mobile Application Management (MAM) evaluations for Android devices. When FALSE, inidicates that data from the Mobile Threat Defense partner should not be used during Mobile Application Management (MAM) evaluations for Android devices. Only one partner per platform may be enabled for Mobile Application Management (MAM) evaluation. Default value is FALSE.
  - `[IosDeviceBlockedOnMissingPartnerData <Boolean?>]`: For IOS, set whether Intune must receive data from the Mobile Threat Defense partner prior to marking a device compliant
  - `[IosEnabled <Boolean?>]`: For IOS, get or set whether data from the Mobile Threat Defense partner should be used during compliance evaluations
  - `[IosMobileApplicationManagementEnabled <Boolean?>]`: When TRUE, inidicates that data from the Mobile Threat Defense partner can be used during Mobile Application Management (MAM) evaluations for IOS devices. When FALSE, inidicates that data from the Mobile Threat Defense partner should not be used during Mobile Application Management (MAM) evaluations for IOS devices. Only one partner per platform may be enabled for Mobile Application Management (MAM) evaluation. Default value is FALSE.
  - `[LastHeartbeatDateTime <DateTime?>]`: DateTime of last Heartbeat recieved from the Mobile Threat Defense partner
  - `[MacDeviceBlockedOnMissingPartnerData <Boolean?>]`: For Mac, get or set whether Intune must receive data from the Mobile Threat Defense partner prior to marking a device compliant
  - `[MacEnabled <Boolean?>]`: For Mac, get or set whether data from the Mobile Threat Defense partner should be used during compliance evaluations
  - `[MicrosoftDefenderForEndpointAttachEnabled <Boolean?>]`: When TRUE, inidicates that configuration profile management via Microsoft Defender for Endpoint is enabled. When FALSE, inidicates that configuration profile management via Microsoft Defender for Endpoint is disabled. Default value is FALSE.
  - `[PartnerState <MobileThreatPartnerTenantState?>]`: Partner state of this tenant.
  - `[PartnerUnresponsivenessThresholdInDays <Int32?>]`: Get or Set days the per tenant tolerance to unresponsiveness for this partner integration
  - `[PartnerUnsupportedOSVersionBlocked <Boolean?>]`: Get or set whether to block devices on the enabled platforms that do not meet the minimum version requirements of the Mobile Threat Defense partner
  - `[WindowsDeviceBlockedOnMissingPartnerData <Boolean?>]`: When TRUE, inidicates that Intune must receive data from the Mobile Threat Defense partner prior to marking a device compliant for Windows. When FALSE, inidicates that Intune may make a device compliant without receiving data from the Mobile Threat Defense partner for Windows. Default value is FALSE.
  - `[WindowsEnabled <Boolean?>]`: When TRUE, inidicates that data from the Mobile Threat Defense partner can be used during compliance evaluations for Windows. When FALSE, inidicates that data from the Mobile Threat Defense partner should not be used during compliance evaluations for Windows. Default value is FALSE.
  - `[WindowsMobileApplicationManagementEnabled <Boolean?>]`: When TRUE, app protection policies using the Device Threat Level rule will evaluate devices including data from this connector for Windows. When FALSE, Intune will not use device risk details sent over this connector during app protection policies calculation for policies with a Device Threat Level configured. Existing devices that are not compliant due to risk levels obtained from this connector will also become compliant.

## RELATED LINKS

