---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.administration/new-mgdevicemanagementtelecomexpensemanagementpartner
schema: 2.0.0
---

# New-MgDeviceManagementTelecomExpenseManagementPartner

## SYNOPSIS
Create new navigation property to telecomExpenseManagementPartners for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementTelecomExpenseManagementPartner [-AdditionalProperties <Hashtable>] [-AppAuthorized]
 [-DisplayName <String>] [-Enabled] [-Id <String>] [-LastConnectionDateTime <DateTime>] [-Url <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementTelecomExpenseManagementPartner
 -BodyParameter <IMicrosoftGraphTelecomExpenseManagementPartner> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to telecomExpenseManagementPartners for deviceManagement

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppAuthorized
Whether the partner's AAD app has been authorized to access Intune.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
telecomExpenseManagementPartner resources represent the metadata and status of a given TEM service.
Once your organization has onboarded with a partner, the partner can be enabled or disabled to switch TEM functionality on or off.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTelecomExpenseManagementPartner
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
Display name of the TEM partner.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Enabled
Whether Intune's connection to the TEM service is currently enabled or disabled.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastConnectionDateTime
Timestamp of the last request sent to Intune by the TEM partner.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Url
URL of the TEM partner's administrative control panel, where an administrator can configure their TEM service.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTelecomExpenseManagementPartner

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTelecomExpenseManagementPartner

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphTelecomExpenseManagementPartner>: telecomExpenseManagementPartner resources represent the metadata and status of a given TEM service. Once your organization has onboarded with a partner, the partner can be enabled or disabled to switch TEM functionality on or off.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[AppAuthorized <Boolean?>]`: Whether the partner's AAD app has been authorized to access Intune.
  - `[DisplayName <String>]`: Display name of the TEM partner.
  - `[Enabled <Boolean?>]`: Whether Intune's connection to the TEM service is currently enabled or disabled.
  - `[LastConnectionDateTime <DateTime?>]`: Timestamp of the last request sent to Intune by the TEM partner.
  - `[Url <String>]`: URL of the TEM partner's administrative control panel, where an administrator can configure their TEM service.

## RELATED LINKS

