---
external help file:
Module Name: Microsoft.Graph.WindowsUpdates
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.windowsupdates/update-mgwindowsupdatesupdatableasset
schema: 2.0.0
---

# Update-MgWindowsUpdatesUpdatableAsset

## SYNOPSIS
Assets registered with the deployment service that can receive updates.
Read-only.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgWindowsUpdatesUpdatableAsset -UpdatableAssetId <String> [-AdditionalProperties <Hashtable>]
 [-Id <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgWindowsUpdatesUpdatableAsset -UpdatableAssetId <String> -BodyParameter <Hashtable> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgWindowsUpdatesUpdatableAsset -InputObject <IWindowsUpdatesIdentity> -BodyParameter <Hashtable>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgWindowsUpdatesUpdatableAsset -InputObject <IWindowsUpdatesIdentity>
 [-AdditionalProperties <Hashtable>] [-Id <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Assets registered with the deployment service that can receive updates.
Read-only.

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
updatableAsset

```yaml
Type: System.Collections.Hashtable
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
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IWindowsUpdatesIdentity
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

### -UpdatableAssetId
key: id of updatableAsset

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

### Microsoft.Graph.PowerShell.Models.IWindowsUpdatesIdentity

### System.Collections.Hashtable

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

### Update-MgWuUpdatableAsset

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IWindowsUpdatesIdentity>: Identity Parameter
  - `[CatalogEntryId <String>]`: key: id of catalogEntry
  - `[DeploymentId <String>]`: key: id of deployment
  - `[UpdatableAssetId <String>]`: key: id of updatableAsset

## RELATED LINKS

