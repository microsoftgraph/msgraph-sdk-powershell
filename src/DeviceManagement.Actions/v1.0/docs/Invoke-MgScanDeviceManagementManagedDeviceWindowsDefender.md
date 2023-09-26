---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Actions
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.devicemanagement.actions/invoke-mgscandevicemanagementmanageddevicewindowsdefender
schema: 2.0.0
---

# Invoke-MgScanDeviceManagementManagedDeviceWindowsDefender

## SYNOPSIS
Not yet documented

## SYNTAX

### ScanExpanded (Default)
```
Invoke-MgScanDeviceManagementManagedDeviceWindowsDefender -ManagedDeviceId <String>
 [-AdditionalProperties <Hashtable>] [-QuickScan] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Scan
```
Invoke-MgScanDeviceManagementManagedDeviceWindowsDefender -ManagedDeviceId <String>
 -BodyParameter <IPathsByrzneDevicemanagementManageddevicesManageddeviceIdMicrosoftGraphWindowsdefenderscanPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ScanViaIdentity
```
Invoke-MgScanDeviceManagementManagedDeviceWindowsDefender -InputObject <IDeviceManagementActionsIdentity>
 -BodyParameter <IPathsByrzneDevicemanagementManageddevicesManageddeviceIdMicrosoftGraphWindowsdefenderscanPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ScanViaIdentityExpanded
```
Invoke-MgScanDeviceManagementManagedDeviceWindowsDefender -InputObject <IDeviceManagementActionsIdentity>
 [-AdditionalProperties <Hashtable>] [-QuickScan] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Not yet documented

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: ScanExpanded, ScanViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPathsByrzneDevicemanagementManageddevicesManageddeviceIdMicrosoftGraphWindowsdefenderscanPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Scan, ScanViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IDeviceManagementActionsIdentity
Parameter Sets: ScanViaIdentity, ScanViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ManagedDeviceId
The unique identifier of managedDevice

```yaml
Type: System.String
Parameter Sets: Scan, ScanExpanded
Aliases:

Required: True
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

### -QuickScan
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ScanExpanded, ScanViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IDeviceManagementActionsIdentity

### Microsoft.Graph.PowerShell.Models.IPathsByrzneDevicemanagementManageddevicesManageddeviceIdMicrosoftGraphWindowsdefenderscanPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPathsByrzneDevicemanagementManageddevicesManageddeviceIdMicrosoftGraphWindowsdefenderscanPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[QuickScan <Boolean?>]`: 

`INPUTOBJECT <IDeviceManagementActionsIdentity>`: Identity Parameter
  - `[AppLogCollectionRequestId <String>]`: The unique identifier of appLogCollectionRequest
  - `[DeviceCompliancePolicyId <String>]`: The unique identifier of deviceCompliancePolicy
  - `[DeviceConfigurationId <String>]`: The unique identifier of deviceConfiguration
  - `[DeviceEnrollmentConfigurationId <String>]`: The unique identifier of deviceEnrollmentConfiguration
  - `[DeviceLogCollectionResponseId <String>]`: The unique identifier of deviceLogCollectionResponse
  - `[DeviceManagementExchangeConnectorId <String>]`: The unique identifier of deviceManagementExchangeConnector
  - `[DeviceManagementPartnerId <String>]`: The unique identifier of deviceManagementPartner
  - `[ManagedDeviceId <String>]`: The unique identifier of managedDevice
  - `[MobileAppTroubleshootingEventId <String>]`: The unique identifier of mobileAppTroubleshootingEvent
  - `[NotificationMessageTemplateId <String>]`: The unique identifier of notificationMessageTemplate
  - `[RemoteAssistancePartnerId <String>]`: The unique identifier of remoteAssistancePartner
  - `[WindowsAutopilotDeviceIdentityId <String>]`: The unique identifier of windowsAutopilotDeviceIdentity

## RELATED LINKS

