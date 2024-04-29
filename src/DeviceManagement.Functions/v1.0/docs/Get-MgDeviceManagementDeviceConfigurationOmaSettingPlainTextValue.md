---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Functions
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.devicemanagement.functions/get-mgdevicemanagementdeviceconfigurationomasettingplaintextvalue
schema: 2.0.0
---

# Get-MgDeviceManagementDeviceConfigurationOmaSettingPlainTextValue

## SYNOPSIS
Invoke function getOmaSettingPlainTextValue

## SYNTAX

### Get (Default)
```
Get-MgDeviceManagementDeviceConfigurationOmaSettingPlainTextValue -DeviceConfigurationId <String>
 -SecretReferenceValueId <String> [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgDeviceManagementDeviceConfigurationOmaSettingPlainTextValue
 -InputObject <IDeviceManagementFunctionsIdentity> [<CommonParameters>]
```

## DESCRIPTION
Invoke function getOmaSettingPlainTextValue

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

### -DeviceConfigurationId
The unique identifier of deviceConfiguration

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IDeviceManagementFunctionsIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -SecretReferenceValueId
Usage: secretReferenceValueId='{secretReferenceValueId}'

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IDeviceManagementFunctionsIdentity

## OUTPUTS

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`INPUTOBJECT <IDeviceManagementFunctionsIdentity>`: Identity Parameter
  - `[Category <String>]`: Usage: category='{category}'
  - `[DeviceConfigurationId <String>]`: The unique identifier of deviceConfiguration
  - `[DomainName <String>]`: Usage: domainName='{domainName}'
  - `[Scope <String>]`: Usage: scope='{scope}'
  - `[SecretReferenceValueId <String>]`: Usage: secretReferenceValueId='{secretReferenceValueId}'
  - `[SummarizeBy <UserExperienceAnalyticsSummarizedBy?>]`: Usage: summarizeBy='{summarizeBy}'

## RELATED LINKS

