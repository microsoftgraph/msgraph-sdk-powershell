---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.administration/new-mgdevicemanagementmobilethreatdefenseconnector
schema: 2.0.0
---

# New-MgDeviceManagementMobileThreatDefenseConnector

## SYNOPSIS
Create new navigation property to mobileThreatDefenseConnectors for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementMobileThreatDefenseConnector [-AdditionalProperties <Hashtable>]
 [-AllowPartnerToCollectIosApplicationMetadata] [-AllowPartnerToCollectIosPersonalApplicationMetadata]
 [-AndroidDeviceBlockedOnMissingPartnerData] [-AndroidEnabled] [-AndroidMobileApplicationManagementEnabled]
 [-Id <String>] [-IosDeviceBlockedOnMissingPartnerData] [-IosEnabled] [-IosMobileApplicationManagementEnabled]
 [-LastHeartbeatDateTime <DateTime>] [-MacDeviceBlockedOnMissingPartnerData] [-MacEnabled]
 [-MicrosoftDefenderForEndpointAttachEnabled] [-PartnerState <MobileThreatPartnerTenantState>]
 [-PartnerUnresponsivenessThresholdInDays <Int32>] [-PartnerUnsupportedOSVersionBlocked]
 [-WindowsDeviceBlockedOnMissingPartnerData] [-WindowsEnabled] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementMobileThreatDefenseConnector
 -BodyParameter <IMicrosoftGraphMobileThreatDefenseConnector> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to mobileThreatDefenseConnectors for deviceManagement

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

### -AllowPartnerToCollectIosApplicationMetadata
For IOS devices, allows the admin to configure whether the data sync partner may also collect metadata about installed applications from Intune

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
For IOS devices, allows the admin to configure whether the data sync partner may also collect metadata about personally installed applications from Intune

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
For Android, set whether Intune must receive data from the data sync partner prior to marking a device compliant

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
For Android, set whether data from the data sync partner should be used during compliance evaluations

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
For Android, set whether data from the data sync partner should be used during Mobile Application Management (MAM) evaluations.
Only one partner per platform may be enabled for Mobile Application Management (MAM) evaluation.

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
Entity which represents a connection to Mobile threat defense partner.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileThreatDefenseConnector
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -IosDeviceBlockedOnMissingPartnerData
For IOS, set whether Intune must receive data from the data sync partner prior to marking a device compliant

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
For IOS, get or set whether data from the data sync partner should be used during compliance evaluations

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
For IOS, get or set whether data from the data sync partner should be used during Mobile Application Management (MAM) evaluations.
Only one partner per platform may be enabled for Mobile Application Management (MAM) evaluation.

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
DateTime of last Heartbeat recieved from the Data Sync Partner

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
For Mac, get or set whether Intune must receive data from the data sync partner prior to marking a device compliant

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
For Mac, get or set whether data from the data sync partner should be used during compliance evaluations

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
When TRUE, configuration profile management via Microsoft Defender for Endpoint is enabled.
When FALSE, configuration profile management via Microsoft Defender for Endpoint is disabled.

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
Type: Microsoft.Graph.PowerShell.Support.MobileThreatPartnerTenantState
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
Get or set whether to block devices on the enabled platforms that do not meet the minimum version requirements of the Data Sync Partner

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
For Windows, set whether Intune must receive data from the data sync partner prior to marking a device compliant

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
For Windows, get or set whether data from the data sync partner should be used during compliance evaluations

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileThreatDefenseConnector

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileThreatDefenseConnector

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphMobileThreatDefenseConnector>: Entity which represents a connection to Mobile threat defense partner.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[AllowPartnerToCollectIosApplicationMetadata <Boolean?>]`: For IOS devices, allows the admin to configure whether the data sync partner may also collect metadata about installed applications from Intune
  - `[AllowPartnerToCollectIosPersonalApplicationMetadata <Boolean?>]`: For IOS devices, allows the admin to configure whether the data sync partner may also collect metadata about personally installed applications from Intune
  - `[AndroidDeviceBlockedOnMissingPartnerData <Boolean?>]`: For Android, set whether Intune must receive data from the data sync partner prior to marking a device compliant
  - `[AndroidEnabled <Boolean?>]`: For Android, set whether data from the data sync partner should be used during compliance evaluations
  - `[AndroidMobileApplicationManagementEnabled <Boolean?>]`: For Android, set whether data from the data sync partner should be used during Mobile Application Management (MAM) evaluations. Only one partner per platform may be enabled for Mobile Application Management (MAM) evaluation.
  - `[IosDeviceBlockedOnMissingPartnerData <Boolean?>]`: For IOS, set whether Intune must receive data from the data sync partner prior to marking a device compliant
  - `[IosEnabled <Boolean?>]`: For IOS, get or set whether data from the data sync partner should be used during compliance evaluations
  - `[IosMobileApplicationManagementEnabled <Boolean?>]`: For IOS, get or set whether data from the data sync partner should be used during Mobile Application Management (MAM) evaluations. Only one partner per platform may be enabled for Mobile Application Management (MAM) evaluation.
  - `[LastHeartbeatDateTime <DateTime?>]`: DateTime of last Heartbeat recieved from the Data Sync Partner
  - `[MacDeviceBlockedOnMissingPartnerData <Boolean?>]`: For Mac, get or set whether Intune must receive data from the data sync partner prior to marking a device compliant
  - `[MacEnabled <Boolean?>]`: For Mac, get or set whether data from the data sync partner should be used during compliance evaluations
  - `[MicrosoftDefenderForEndpointAttachEnabled <Boolean?>]`: When TRUE, configuration profile management via Microsoft Defender for Endpoint is enabled. When FALSE, configuration profile management via Microsoft Defender for Endpoint is disabled.
  - `[PartnerState <MobileThreatPartnerTenantState?>]`: Partner state of this tenant.
  - `[PartnerUnresponsivenessThresholdInDays <Int32?>]`: Get or Set days the per tenant tolerance to unresponsiveness for this partner integration
  - `[PartnerUnsupportedOSVersionBlocked <Boolean?>]`: Get or set whether to block devices on the enabled platforms that do not meet the minimum version requirements of the Data Sync Partner
  - `[WindowsDeviceBlockedOnMissingPartnerData <Boolean?>]`: For Windows, set whether Intune must receive data from the data sync partner prior to marking a device compliant
  - `[WindowsEnabled <Boolean?>]`: For Windows, get or set whether data from the data sync partner should be used during compliance evaluations

## RELATED LINKS

