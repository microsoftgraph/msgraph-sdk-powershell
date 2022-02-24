---
external help file:
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/invoke-mghasdeviceappmgttargetedmanagedappconfigurationpayloadlink
schema: 2.0.0
---

# Invoke-MgHasDeviceAppMgtTargetedManagedAppConfigurationPayloadLink

## SYNOPSIS
Invoke action hasPayloadLinks

## SYNTAX

### HasExpanded (Default)
```
Invoke-MgHasDeviceAppMgtTargetedManagedAppConfigurationPayloadLink [-AdditionalProperties <Hashtable>]
 [-PayloadIds <String[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Has
```
Invoke-MgHasDeviceAppMgtTargetedManagedAppConfigurationPayloadLink
 -BodyParameter <IPathsOw6D8EDeviceappmanagementTargetedmanagedappconfigurationsMicrosoftGraphHaspayloadlinksPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action hasPayloadLinks

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: HasExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IPathsOw6D8EDeviceappmanagementTargetedmanagedappconfigurationsMicrosoftGraphHaspayloadlinksPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Has
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PayloadIds
.

```yaml
Type: System.String[]
Parameter Sets: HasExpanded
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

### Microsoft.Graph.PowerShell.Models.IPathsOw6D8EDeviceappmanagementTargetedmanagedappconfigurationsMicrosoftGraphHaspayloadlinksPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphHasPayloadLinkResultItem

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPathsOw6D8EDeviceappmanagementTargetedmanagedappconfigurationsMicrosoftGraphHaspayloadlinksPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[PayloadIds <String[]>]`: 

## RELATED LINKS

