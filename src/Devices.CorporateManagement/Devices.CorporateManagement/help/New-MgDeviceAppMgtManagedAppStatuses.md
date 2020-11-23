---
external help file: Microsoft.Graph.Devices.CorporateManagement-help.xml
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgdeviceappmgtmanagedappstatuses
schema: 2.0.0
---

# New-MgDeviceAppMgtManagedAppStatuses

## SYNOPSIS
Create new navigation property to managedAppStatuses for deviceAppManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceAppMgtManagedAppStatuses [-AdditionalProperties <Hashtable>] [-DisplayName <String>] [-Id <String>]
 [-Version <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgDeviceAppMgtManagedAppStatuses -BodyParameter <IMicrosoftGraphManagedAppStatus> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to managedAppStatuses for deviceAppManagement

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Represents app protection and configuration status for the organization.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphManagedAppStatus
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
Friendly name of the status report.

```yaml
Type: String
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Version
Version of the entity.

```yaml
Type: String
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedAppStatus
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedAppStatus
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphManagedAppStatus\>: Represents app protection and configuration status for the organization.
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[DisplayName \<String\>\]: Friendly name of the status report.
  \[Version \<String\>\]: Version of the entity.

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgdeviceappmgtmanagedappstatuses](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgdeviceappmgtmanagedappstatuses)

