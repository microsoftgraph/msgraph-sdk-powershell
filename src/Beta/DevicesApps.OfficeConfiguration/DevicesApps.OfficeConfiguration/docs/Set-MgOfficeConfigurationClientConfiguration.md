---
external help file:
Module Name: Microsoft.Graph.DevicesApps.OfficeConfiguration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicesapps.officeconfiguration/set-mgofficeconfigurationclientconfiguration
schema: 2.0.0
---

# Set-MgOfficeConfigurationClientConfiguration

## SYNOPSIS
Invoke action assign

## SYNTAX

### AssignExpanded (Default)
```
Set-MgOfficeConfigurationClientConfiguration -OfficeClientConfigurationId <String>
 [-OfficeConfigurationAssignments <IMicrosoftGraphOfficeClientConfigurationAssignment[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Assign
```
Set-MgOfficeConfigurationClientConfiguration -OfficeClientConfigurationId <String>
 -BodyParameter <IPathsMtl0Z8OfficeconfigurationClientconfigurationsOfficeclientconfigurationIdMicrosoftGraphAssignPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### AssignViaIdentity
```
Set-MgOfficeConfigurationClientConfiguration -InputObject <IDevicesAppsOfficeConfigurationIdentity>
 -BodyParameter <IPathsMtl0Z8OfficeconfigurationClientconfigurationsOfficeclientconfigurationIdMicrosoftGraphAssignPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### AssignViaIdentityExpanded
```
Set-MgOfficeConfigurationClientConfiguration -InputObject <IDevicesAppsOfficeConfigurationIdentity>
 [-OfficeConfigurationAssignments <IMicrosoftGraphOfficeClientConfigurationAssignment[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Invoke action assign

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
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPathsMtl0Z8OfficeconfigurationClientconfigurationsOfficeclientconfigurationIdMicrosoftGraphAssignPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Assign, AssignViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IDevicesAppsOfficeConfigurationIdentity
Parameter Sets: AssignViaIdentity, AssignViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -OfficeClientConfigurationId
key: officeClientConfiguration-id of officeClientConfiguration

```yaml
Type: System.String
Parameter Sets: Assign, AssignExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -OfficeConfigurationAssignments
.
To construct, see NOTES section for OFFICECONFIGURATIONASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfficeClientConfigurationAssignment[]
Parameter Sets: AssignExpanded, AssignViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IDevicesAppsOfficeConfigurationIdentity

### Microsoft.Graph.PowerShell.Models.IPathsMtl0Z8OfficeconfigurationClientconfigurationsOfficeclientconfigurationIdMicrosoftGraphAssignPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOfficeClientConfigurationAssignment

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IPathsMtl0Z8OfficeconfigurationClientconfigurationsOfficeclientconfigurationIdMicrosoftGraphAssignPostRequestbodyContentApplicationJsonSchema>: .
  - `[OfficeConfigurationAssignments <IMicrosoftGraphOfficeClientConfigurationAssignment[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Target <IMicrosoftGraphOfficeConfigurationAssignmentTarget>]`: officeConfigurationAssignmentTarget

#### INPUTOBJECT <IDevicesAppsOfficeConfigurationIdentity>: Identity Parameter
  - `[OfficeClientConfigurationAssignmentId <String>]`: key: officeClientConfigurationAssignment-id of officeClientConfigurationAssignment
  - `[OfficeClientConfigurationId <String>]`: key: officeClientConfiguration-id of officeClientConfiguration

#### OFFICECONFIGURATIONASSIGNMENTS <IMicrosoftGraphOfficeClientConfigurationAssignment[]>: .
  - `[Id <String>]`: Read-only.
  - `[Target <IMicrosoftGraphOfficeConfigurationAssignmentTarget>]`: officeConfigurationAssignmentTarget

## RELATED LINKS

