---
external help file:
Module Name: Microsoft.Graph.Identity.RoleManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.rolemanagement/new-mgrolemanagementdevicemanagementroleassignmentappscope
schema: 2.0.0
---

# New-MgRoleManagementDeviceManagementRoleAssignmentAppScope

## SYNOPSIS
Create new navigation property to appScopes for roleManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgRoleManagementDeviceManagementRoleAssignmentAppScope -UnifiedRoleAssignmentMultipleId <String>
 [-DisplayName <String>] [-Id <String>] [-Type <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgRoleManagementDeviceManagementRoleAssignmentAppScope -UnifiedRoleAssignmentMultipleId <String>
 -BodyParameter <IMicrosoftGraphAppScope> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgRoleManagementDeviceManagementRoleAssignmentAppScope -InputObject <IIdentityRoleManagementIdentity>
 -BodyParameter <IMicrosoftGraphAppScope> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgRoleManagementDeviceManagementRoleAssignmentAppScope -InputObject <IIdentityRoleManagementIdentity>
 [-DisplayName <String>] [-Id <String>] [-Type <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to appScopes for roleManagement

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
appScope
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppScope
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
.

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
Type: Microsoft.Graph.PowerShell.Models.IIdentityRoleManagementIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Type
.

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

### -UnifiedRoleAssignmentMultipleId
key: unifiedRoleAssignmentMultiple-id of unifiedRoleAssignmentMultiple

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

### Microsoft.Graph.PowerShell.Models.IIdentityRoleManagementIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppScope

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppScope

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphAppScope>: appScope
  - `[Id <String>]`: Read-only.
  - `[DisplayName <String>]`: 
  - `[Type <String>]`: 

INPUTOBJECT <IIdentityRoleManagementIdentity>: Identity Parameter
  - `[AppScopeId <String>]`: key: appScope-id of appScope
  - `[DirectoryObjectId <String>]`: key: directoryObject-id of directoryObject
  - `[UnifiedRoleAssignmentId <String>]`: key: unifiedRoleAssignment-id of unifiedRoleAssignment
  - `[UnifiedRoleAssignmentMultipleId <String>]`: key: unifiedRoleAssignmentMultiple-id of unifiedRoleAssignmentMultiple
  - `[UnifiedRoleDefinitionId <String>]`: key: unifiedRoleDefinition-id of unifiedRoleDefinition

## RELATED LINKS

