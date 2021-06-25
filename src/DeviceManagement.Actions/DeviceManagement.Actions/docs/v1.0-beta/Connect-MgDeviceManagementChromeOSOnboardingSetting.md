---
external help file: Microsoft.Graph.DeviceManagement.Actions-help.xml
Module Name: Microsoft.Graph.DeviceManagement.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.actions/connect-mgdevicemanagementchromeosonboardingsetting
schema: 2.0.0
---

# Connect-MgDeviceManagementChromeOSOnboardingSetting

## SYNOPSIS
Invoke action connect

## SYNTAX

### ConnectExpanded (Default)
```
Connect-MgDeviceManagementChromeOSOnboardingSetting [-AdditionalProperties <Hashtable>]
 [-OwnerUserPrincipalName <String>] [-ServiceAccountCredentials <String>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Connect
```
Connect-MgDeviceManagementChromeOSOnboardingSetting
 -BodyParameter <IPaths5LbknhDevicemanagementChromeosonboardingsettingsMicrosoftGraphConnectPostRequestbodyContentApplicationJsonSchema>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Invoke action connect

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: ConnectExpanded
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
Type: IPaths5LbknhDevicemanagementChromeosonboardingsettingsMicrosoftGraphConnectPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Connect
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OwnerUserPrincipalName
.

```yaml
Type: String
Parameter Sets: ConnectExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ServiceAccountCredentials
.

```yaml
Type: String
Parameter Sets: ConnectExpanded
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
Type: SwitchParameter
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
Type: SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IPaths5LbknhDevicemanagementChromeosonboardingsettingsMicrosoftGraphConnectPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths5LbknhDevicemanagementChromeosonboardingsettingsMicrosoftGraphConnectPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[OwnerUserPrincipalName <String>]`: 
  - `[ServiceAccountCredentials <String>]`: 

## RELATED LINKS
