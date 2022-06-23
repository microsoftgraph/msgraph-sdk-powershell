---
external help file:
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
 [-OwnerAccessToken <String>] [-OwnerUserPrincipalName <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Connect
```
Connect-MgDeviceManagementChromeOSOnboardingSetting
 -BodyParameter <IPaths5LbknhDevicemanagementChromeosonboardingsettingsMicrosoftGraphConnectPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action connect

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
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
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPaths5LbknhDevicemanagementChromeosonboardingsettingsMicrosoftGraphConnectPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Connect
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OwnerAccessToken
.

```yaml
Type: System.String
Parameter Sets: ConnectExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OwnerUserPrincipalName
.

```yaml
Type: System.String
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

### Microsoft.Graph.PowerShell.Models.IPaths5LbknhDevicemanagementChromeosonboardingsettingsMicrosoftGraphConnectPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths5LbknhDevicemanagementChromeosonboardingsettingsMicrosoftGraphConnectPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[OwnerAccessToken <String>]`: 
  - `[OwnerUserPrincipalName <String>]`: 

## RELATED LINKS

