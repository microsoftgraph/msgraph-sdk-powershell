---
external help file:
Module Name: Microsoft.Graph.DevicesApps.OfficeConfiguration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicesapps.officeconfiguration/update-mgofficeconfigurationclientconfigurationassignment
schema: 2.0.0
---

# Update-MgOfficeConfigurationClientConfigurationAssignment

## SYNOPSIS
Update the navigation property assignments in officeConfiguration

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgOfficeConfigurationClientConfigurationAssignment -OfficeClientConfigurationAssignmentId <String>
 -OfficeClientConfigurationId <String> [-Id <String>]
 [-Target <IMicrosoftGraphOfficeConfigurationAssignmentTarget>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgOfficeConfigurationClientConfigurationAssignment -OfficeClientConfigurationAssignmentId <String>
 -OfficeClientConfigurationId <String> -BodyParameter <IMicrosoftGraphOfficeClientConfigurationAssignment>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgOfficeConfigurationClientConfigurationAssignment
 -InputObject <IDevicesAppsOfficeConfigurationIdentity>
 -BodyParameter <IMicrosoftGraphOfficeClientConfigurationAssignment> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgOfficeConfigurationClientConfigurationAssignment
 -InputObject <IDevicesAppsOfficeConfigurationIdentity> [-Id <String>]
 [-Target <IMicrosoftGraphOfficeConfigurationAssignmentTarget>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property assignments in officeConfiguration

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
Parameter Sets: Update, UpdateViaIdentity
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OfficeClientConfigurationAssignmentId
key: officeClientConfigurationAssignment-id of officeClientConfigurationAssignment

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OfficeClientConfigurationId
key: officeClientConfiguration-id of officeClientConfiguration

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
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

### -Target
officeConfigurationAssignmentTarget

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfficeConfigurationAssignmentTarget
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### System.Boolean

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

