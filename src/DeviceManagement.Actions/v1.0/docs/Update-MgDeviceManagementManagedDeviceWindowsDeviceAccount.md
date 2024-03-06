---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Actions
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.devicemanagement.actions/update-mgdevicemanagementmanageddevicewindowsdeviceaccount
schema: 2.0.0
---

# Update-MgDeviceManagementManagedDeviceWindowsDeviceAccount

## SYNOPSIS
Not yet documented

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgDeviceManagementManagedDeviceWindowsDeviceAccount -ManagedDeviceId <String>
 [-AdditionalProperties <Hashtable>] [-ResponseHeadersVariable <String>]
 [-UpdateWindowsDeviceAccountActionParameter <IMicrosoftGraphUpdateWindowsDeviceAccountActionParameter>]
 [-Headers <IDictionary>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgDeviceManagementManagedDeviceWindowsDeviceAccount -ManagedDeviceId <String>
 -BodyParameter <IPaths1L95NseDevicemanagementManageddevicesManageddeviceIdMicrosoftGraphUpdatewindowsdeviceaccountPostRequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgDeviceManagementManagedDeviceWindowsDeviceAccount -InputObject <IDeviceManagementActionsIdentity>
 -BodyParameter <IPaths1L95NseDevicemanagementManageddevicesManageddeviceIdMicrosoftGraphUpdatewindowsdeviceaccountPostRequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgDeviceManagementManagedDeviceWindowsDeviceAccount -InputObject <IDeviceManagementActionsIdentity>
 [-AdditionalProperties <Hashtable>] [-ResponseHeadersVariable <String>]
 [-UpdateWindowsDeviceAccountActionParameter <IMicrosoftGraphUpdateWindowsDeviceAccountActionParameter>]
 [-Headers <IDictionary>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IPaths1L95NseDevicemanagementManageddevicesManageddeviceIdMicrosoftGraphUpdatewindowsdeviceaccountPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
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
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
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
Parameter Sets: Update, UpdateExpanded
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

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UpdateWindowsDeviceAccountActionParameter
updateWindowsDeviceAccountActionParameter
To construct, see NOTES section for UPDATEWINDOWSDEVICEACCOUNTACTIONPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUpdateWindowsDeviceAccountActionParameter
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

### Microsoft.Graph.PowerShell.Models.IDeviceManagementActionsIdentity

### Microsoft.Graph.PowerShell.Models.IPaths1L95NseDevicemanagementManageddevicesManageddeviceIdMicrosoftGraphUpdatewindowsdeviceaccountPostRequestbodyContentApplicationJsonSchema

### System.Collections.IDictionary

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPaths1L95NseDevicemanagementManageddevicesManageddeviceIdMicrosoftGraphUpdatewindowsdeviceaccountPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[UpdateWindowsDeviceAccountActionParameter <IMicrosoftGraphUpdateWindowsDeviceAccountActionParameter>]`: updateWindowsDeviceAccountActionParameter
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CalendarSyncEnabled <Boolean?>]`: Not yet documented
    - `[DeviceAccount <IMicrosoftGraphWindowsDeviceAccount>]`: windowsDeviceAccount
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Password <String>]`: Not yet documented
    - `[DeviceAccountEmail <String>]`: Not yet documented
    - `[ExchangeServer <String>]`: Not yet documented
    - `[PasswordRotationEnabled <Boolean?>]`: Not yet documented
    - `[SessionInitiationProtocalAddress <String>]`: Not yet documented

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

`UPDATEWINDOWSDEVICEACCOUNTACTIONPARAMETER <IMicrosoftGraphUpdateWindowsDeviceAccountActionParameter>`: updateWindowsDeviceAccountActionParameter
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CalendarSyncEnabled <Boolean?>]`: Not yet documented
  - `[DeviceAccount <IMicrosoftGraphWindowsDeviceAccount>]`: windowsDeviceAccount
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Password <String>]`: Not yet documented
  - `[DeviceAccountEmail <String>]`: Not yet documented
  - `[ExchangeServer <String>]`: Not yet documented
  - `[PasswordRotationEnabled <Boolean?>]`: Not yet documented
  - `[SessionInitiationProtocalAddress <String>]`: Not yet documented

## RELATED LINKS

