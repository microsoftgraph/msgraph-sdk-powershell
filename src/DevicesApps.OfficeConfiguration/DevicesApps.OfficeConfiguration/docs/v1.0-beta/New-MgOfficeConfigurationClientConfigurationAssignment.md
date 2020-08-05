---
external help file:
Module Name: Microsoft.Graph.DevicesApps.OfficeConfiguration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicesapps.officeconfiguration/new-mgofficeconfigurationclientconfigurationassignment
schema: 2.0.0
---

# New-MgOfficeConfigurationClientConfigurationAssignment

## SYNOPSIS
Create new navigation property to assignments for officeConfiguration

## SYNTAX

### CreateExpanded (Default)
```
New-MgOfficeConfigurationClientConfigurationAssignment -OfficeClientConfigurationId <String> [-Id <String>]
 [-Target <IMicrosoftGraphOfficeConfigurationAssignmentTarget>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgOfficeConfigurationClientConfigurationAssignment -OfficeClientConfigurationId <String>
 -BodyParameter <IMicrosoftGraphOfficeClientConfigurationAssignment> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgOfficeConfigurationClientConfigurationAssignment -InputObject <IDevicesAppsOfficeConfigurationIdentity>
 -BodyParameter <IMicrosoftGraphOfficeClientConfigurationAssignment> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgOfficeConfigurationClientConfigurationAssignment -InputObject <IDevicesAppsOfficeConfigurationIdentity>
 [-Id <String>] [-Target <IMicrosoftGraphOfficeConfigurationAssignmentTarget>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to assignments for officeConfiguration

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -BodyParameter
officeClientConfigurationAssignment
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfficeClientConfigurationAssignment
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IDevicesAppsOfficeConfigurationIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OfficeClientConfigurationId
key: officeClientConfiguration-id of officeClientConfiguration

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Target
officeConfigurationAssignmentTarget

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfficeConfigurationAssignmentTarget
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IDevicesAppsOfficeConfigurationIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfficeClientConfigurationAssignment

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfficeClientConfigurationAssignment

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphOfficeClientConfigurationAssignment>: officeClientConfigurationAssignment
  - `[Id <String>]`: Read-only.
  - `[Target <IMicrosoftGraphOfficeConfigurationAssignmentTarget>]`: officeConfigurationAssignmentTarget

INPUTOBJECT <IDevicesAppsOfficeConfigurationIdentity>: Identity Parameter
  - `[OfficeClientConfigurationAssignmentId <String>]`: key: officeClientConfigurationAssignment-id of officeClientConfigurationAssignment
  - `[OfficeClientConfigurationId <String>]`: key: officeClientConfiguration-id of officeClientConfiguration

## RELATED LINKS

