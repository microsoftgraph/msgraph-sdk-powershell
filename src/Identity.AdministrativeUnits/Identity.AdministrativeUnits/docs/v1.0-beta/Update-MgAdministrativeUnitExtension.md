---
external help file:
Module Name: Microsoft.Graph.Identity.AdministrativeUnits
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.administrativeunits/update-mgadministrativeunitextension
schema: 2.0.0
---

# Update-MgAdministrativeUnitExtension

## SYNOPSIS
Update the navigation property extensions in administrativeUnits

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgAdministrativeUnitExtension -AdministrativeUnitId <String> -ExtensionId <String> [-Id <String>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgAdministrativeUnitExtension -AdministrativeUnitId <String> -ExtensionId <String>
 -BodyParameter <IMicrosoftGraphExtension> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgAdministrativeUnitExtension -InputObject <IIdentityAdministrativeUnitsIdentity>
 -BodyParameter <IMicrosoftGraphExtension> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgAdministrativeUnitExtension -InputObject <IIdentityAdministrativeUnitsIdentity> [-Id <String>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property extensions in administrativeUnits

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

### -AdministrativeUnitId
key: administrativeUnit-id of administrativeUnit

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

### -BodyParameter
extension
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExtension
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ExtensionId
key: extension-id of extension

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
Type: Microsoft.Graph.PowerShell.Models.IIdentityAdministrativeUnitsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### Microsoft.Graph.PowerShell.Models.IIdentityAdministrativeUnitsIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExtension

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphExtension>: extension
  - `[Id <String>]`: Read-only.

INPUTOBJECT <IIdentityAdministrativeUnitsIdentity>: Identity Parameter
  - `[AdministrativeUnitId <String>]`: key: administrativeUnit-id of administrativeUnit
  - `[DirectoryObjectId <String>]`: key: directoryObject-id of directoryObject
  - `[ExtensionId <String>]`: key: extension-id of extension
  - `[ScopedRoleMembershipId <String>]`: key: scopedRoleMembership-id of scopedRoleMembership
  - `[UserId <String>]`: key: user-id of user

## RELATED LINKS

