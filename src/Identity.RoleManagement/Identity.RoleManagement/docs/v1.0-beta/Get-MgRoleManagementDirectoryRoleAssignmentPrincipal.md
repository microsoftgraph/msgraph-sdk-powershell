---
external help file:
Module Name: Microsoft.Graph.Identity.RoleManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.rolemanagement/get-mgrolemanagementdirectoryroleassignmentprincipal
schema: 2.0.0
---

# Get-MgRoleManagementDirectoryRoleAssignmentPrincipal

## SYNOPSIS
Get principal from roleManagement

## SYNTAX

### Get (Default)
```
Get-MgRoleManagementDirectoryRoleAssignmentPrincipal -UnifiedRoleAssignmentId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgRoleManagementDirectoryRoleAssignmentPrincipal -InputObject <IIdentityRoleManagementIdentity>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

## DESCRIPTION
Get principal from roleManagement

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

### -ExpandProperty
Expand related entities

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Expand

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
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Property
Select properties to be returned

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Select

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UnifiedRoleAssignmentId
key: unifiedRoleAssignment-id of unifiedRoleAssignment

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IIdentityRoleManagementIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryObject

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IIdentityRoleManagementIdentity>: Identity Parameter
  - `[AppScopeId <String>]`: key: appScope-id of appScope
  - `[DirectoryObjectId <String>]`: key: directoryObject-id of directoryObject
  - `[UnifiedRoleAssignmentId <String>]`: key: unifiedRoleAssignment-id of unifiedRoleAssignment
  - `[UnifiedRoleAssignmentMultipleId <String>]`: key: unifiedRoleAssignmentMultiple-id of unifiedRoleAssignmentMultiple
  - `[UnifiedRoleDefinitionId <String>]`: key: unifiedRoleDefinition-id of unifiedRoleDefinition

## RELATED LINKS

