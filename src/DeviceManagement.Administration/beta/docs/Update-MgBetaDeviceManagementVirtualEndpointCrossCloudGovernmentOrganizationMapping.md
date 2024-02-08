---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement.Administration
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devicemanagement.administration/update-mgbetadevicemanagementvirtualendpointcrosscloudgovernmentorganizationmapping
schema: 2.0.0
---

# Update-MgBetaDeviceManagementVirtualEndpointCrossCloudGovernmentOrganizationMapping

## SYNOPSIS
Update the navigation property crossCloudGovernmentOrganizationMapping in deviceManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaDeviceManagementVirtualEndpointCrossCloudGovernmentOrganizationMapping
 [-AdditionalProperties <Hashtable>] [-Id <String>] [-OrganizationIdsInUsGovCloud <String[]>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaDeviceManagementVirtualEndpointCrossCloudGovernmentOrganizationMapping
 -BodyParameter <IMicrosoftGraphCloudPcCrossCloudGovernmentOrganizationMapping> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property crossCloudGovernmentOrganizationMapping in deviceManagement

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
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
cloudPcCrossCloudGovernmentOrganizationMapping
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCloudPcCrossCloudGovernmentOrganizationMapping
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OrganizationIdsInUsGovCloud
The tenant ID in the Azure Government cloud corresponding to the GCC tenant in the public cloud.
Currently, 1:1 mappings are supported, so this collection can only contain one tenant ID.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCloudPcCrossCloudGovernmentOrganizationMapping

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCloudPcCrossCloudGovernmentOrganizationMapping

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphCloudPcCrossCloudGovernmentOrganizationMapping>`: cloudPcCrossCloudGovernmentOrganizationMapping
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[OrganizationIdsInUsGovCloud <String[]>]`: The tenant ID in the Azure Government cloud corresponding to the GCC tenant in the public cloud. Currently, 1:1 mappings are supported, so this collection can only contain one tenant ID.

## RELATED LINKS

