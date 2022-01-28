---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.actions/invoke-mgquerydevicemanagementresourceaccessprofile
schema: 2.0.0
---

# Invoke-MgQueryDeviceManagementResourceAccessProfile

## SYNOPSIS
Invoke action queryByPlatformType

## SYNTAX

### QueryExpanded (Default)
```
Invoke-MgQueryDeviceManagementResourceAccessProfile [-AdditionalProperties <Hashtable>]
 [-PlatformType <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Query
```
Invoke-MgQueryDeviceManagementResourceAccessProfile
 -BodyParameter <IPaths1Aw4396DevicemanagementResourceaccessprofilesMicrosoftGraphQuerybyplatformtypePostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action queryByPlatformType

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: QueryExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IPaths1Aw4396DevicemanagementResourceaccessprofilesMicrosoftGraphQuerybyplatformtypePostRequestbodyContentApplicationJsonSchema
Parameter Sets: Query
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PlatformType
Supported platform types for policies.

```yaml
Type: System.String
Parameter Sets: QueryExpanded
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

### Microsoft.Graph.PowerShell.Models.IPaths1Aw4396DevicemanagementResourceaccessprofilesMicrosoftGraphQuerybyplatformtypePostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceManagementResourceAccessProfileBase

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1Aw4396DevicemanagementResourceaccessprofilesMicrosoftGraphQuerybyplatformtypePostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[PlatformType <String>]`: Supported platform types for policies.

## RELATED LINKS

