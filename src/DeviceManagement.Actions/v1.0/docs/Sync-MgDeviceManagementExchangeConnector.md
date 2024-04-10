---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Actions
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.devicemanagement.actions/sync-mgdevicemanagementexchangeconnector
schema: 2.0.0
---

# Sync-MgDeviceManagementExchangeConnector

## SYNOPSIS
Not yet documented

## SYNTAX

### SyncExpanded (Default)
```
Sync-MgDeviceManagementExchangeConnector -DeviceManagementExchangeConnectorId <String>
 [-AdditionalProperties <Hashtable>] [-ResponseHeadersVariable <String>]
 [-SyncType <DeviceManagementExchangeConnectorSyncType>] [-Headers <IDictionary>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Sync
```
Sync-MgDeviceManagementExchangeConnector -DeviceManagementExchangeConnectorId <String>
 -BodyParameter <IPathsD33NzdDevicemanagementExchangeconnectorsDevicemanagementexchangeconnectorIdMicrosoftGraphSyncPostRequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### SyncViaIdentity
```
Sync-MgDeviceManagementExchangeConnector -InputObject <IDeviceManagementActionsIdentity>
 -BodyParameter <IPathsD33NzdDevicemanagementExchangeconnectorsDevicemanagementexchangeconnectorIdMicrosoftGraphSyncPostRequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### SyncViaIdentityExpanded
```
Sync-MgDeviceManagementExchangeConnector -InputObject <IDeviceManagementActionsIdentity>
 [-AdditionalProperties <Hashtable>] [-ResponseHeadersVariable <String>]
 [-SyncType <DeviceManagementExchangeConnectorSyncType>] [-Headers <IDictionary>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Not yet documented

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
Parameter Sets: SyncExpanded, SyncViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IPathsD33NzdDevicemanagementExchangeconnectorsDevicemanagementexchangeconnectorIdMicrosoftGraphSyncPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Sync, SyncViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeviceManagementExchangeConnectorId
The unique identifier of deviceManagementExchangeConnector

```yaml
Type: System.String
Parameter Sets: Sync, SyncExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
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
Parameter Sets: SyncViaIdentity, SyncViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -SyncType
The type of Exchange Connector sync requested.

```yaml
Type: Microsoft.Graph.PowerShell.Support.DeviceManagementExchangeConnectorSyncType
Parameter Sets: SyncExpanded, SyncViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IPathsD33NzdDevicemanagementExchangeconnectorsDevicemanagementexchangeconnectorIdMicrosoftGraphSyncPostRequestbodyContentApplicationJsonSchema

### System.Collections.IDictionary

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPathsD33NzdDevicemanagementExchangeconnectorsDevicemanagementexchangeconnectorIdMicrosoftGraphSyncPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[SyncType <DeviceManagementExchangeConnectorSyncType?>]`: The type of Exchange Connector sync requested.

`INPUTOBJECT <IDeviceManagementActionsIdentity>`: Identity Parameter
  - `[AppLogCollectionRequestId <String>]`: The unique identifier of appLogCollectionRequest
  - `[CloudPcId <String>]`: The unique identifier of cloudPC
  - `[CloudPcOnPremisesConnectionId <String>]`: The unique identifier of cloudPcOnPremisesConnection
  - `[CloudPcProvisioningPolicyId <String>]`: The unique identifier of cloudPcProvisioningPolicy
  - `[CloudPcUserSettingId <String>]`: The unique identifier of cloudPcUserSetting
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

