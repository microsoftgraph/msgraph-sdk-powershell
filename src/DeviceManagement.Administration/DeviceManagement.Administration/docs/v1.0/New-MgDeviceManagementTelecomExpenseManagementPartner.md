---
external help file: Microsoft.Graph.DeviceManagement.Administration-help.xml
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.administration/new-mgdevicemanagementtelecomexpensemanagementpartner
schema: 2.0.0
---

# New-MgDeviceManagementTelecomExpenseManagementPartner

## SYNOPSIS
The telecom expense management partners.

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgDeviceManagementTelecomExpenseManagementPartner [-AdditionalProperties <Hashtable>] [-AppAuthorized]
 [-DisplayName <String>] [-Enabled] [-Id <String>] [-LastConnectionDateTime <DateTime>] [-Url <String>]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create1
```
New-MgDeviceManagementTelecomExpenseManagementPartner
 -BodyParameter <IMicrosoftGraphTelecomExpenseManagementPartner> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
The telecom expense management partners.

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded1
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
Type: SwitchParameter
Parameter Sets: CreateExpanded1
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
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphTelecomExpenseManagementPartner
Parameter Sets: Create1
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
Type: String
Parameter Sets: CreateExpanded1
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
Type: SwitchParameter
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: String
Parameter Sets: CreateExpanded1
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
Type: DateTime
Parameter Sets: CreateExpanded1
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
Type: String
Parameter Sets: CreateExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTelecomExpenseManagementPartner
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTelecomExpenseManagementPartner
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphTelecomExpenseManagementPartner>: telecomExpenseManagementPartner resources represent the metadata and status of a given TEM service. Once your organization has onboarded with a partner, the partner can be enabled or disabled to switch TEM functionality on or off.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[AppAuthorized <Boolean?>]`: Whether the partner's AAD app has been authorized to access Intune.
  - `[DisplayName <String>]`: Display name of the TEM partner.
  - `[Enabled <Boolean?>]`: Whether Intune's connection to the TEM service is currently enabled or disabled.
  - `[LastConnectionDateTime <DateTime?>]`: Timestamp of the last request sent to Intune by the TEM partner.
  - `[Url <String>]`: URL of the TEM partner's administrative control panel, where an administrator can configure their TEM service.

## RELATED LINKS
