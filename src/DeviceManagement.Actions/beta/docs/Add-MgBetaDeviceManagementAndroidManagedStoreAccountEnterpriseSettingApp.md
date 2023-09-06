---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement.Actions
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement.actions/add-mgbetadevicemanagementandroidmanagedstoreaccountenterprisesettingapp
schema: 2.0.0
---

# Add-MgBetaDeviceManagementAndroidManagedStoreAccountEnterpriseSettingApp

## SYNOPSIS
Invoke action addApps

## SYNTAX

### AddExpanded (Default)
```
Add-MgBetaDeviceManagementAndroidManagedStoreAccountEnterpriseSettingApp [-AdditionalProperties <Hashtable>]
 [-ProductIds <String[]>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Add
```
Add-MgBetaDeviceManagementAndroidManagedStoreAccountEnterpriseSettingApp
 -BodyParameter <IPaths17XorxvDevicemanagementAndroidmanagedstoreaccountenterprisesettingsMicrosoftGraphAddappsPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action addApps

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
Parameter Sets: AddExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths17XorxvDevicemanagementAndroidmanagedstoreaccountenterprisesettingsMicrosoftGraphAddappsPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Add
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

### -ProductIds
.

```yaml
Type: System.String[]
Parameter Sets: AddExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IPaths17XorxvDevicemanagementAndroidmanagedstoreaccountenterprisesettingsMicrosoftGraphAddappsPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPaths17XorxvDevicemanagementAndroidmanagedstoreaccountenterprisesettingsMicrosoftGraphAddappsPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ProductIds <String[]>]`: 

## RELATED LINKS

