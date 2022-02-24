---
external help file:
Module Name: Microsoft.Graph.WindowsUpdates
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.windowsupdates/add-mgwindowsupdatesupdatableassetmember
schema: 2.0.0
---

# Add-MgWindowsUpdatesUpdatableAssetMember

## SYNOPSIS
Invoke action addMembers

## SYNTAX

### AddExpanded (Default)
```
Add-MgWindowsUpdatesUpdatableAssetMember -UpdatableAssetId <String> [-AdditionalProperties <Hashtable>]
 [-Assets <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Add
```
Add-MgWindowsUpdatesUpdatableAssetMember -UpdatableAssetId <String>
 -BodyParameter <IPathsH2EvdrAdminWindowsUpdatesUpdatableassetsUpdatableassetIdMicrosoftGraphWindowsupdatesAddmembersPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### AddViaIdentity
```
Add-MgWindowsUpdatesUpdatableAssetMember -InputObject <IWindowsUpdatesIdentity>
 -BodyParameter <IPathsH2EvdrAdminWindowsUpdatesUpdatableassetsUpdatableassetIdMicrosoftGraphWindowsupdatesAddmembersPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### AddViaIdentityExpanded
```
Add-MgWindowsUpdatesUpdatableAssetMember -InputObject <IWindowsUpdatesIdentity>
 [-AdditionalProperties <Hashtable>] [-Assets <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action addMembers

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: AddExpanded, AddViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Assets
.
To construct, please use Get-Help -Online and see NOTES section for ASSETS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsUpdatesUpdatableAsset[]
Parameter Sets: AddExpanded, AddViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPathsH2EvdrAdminWindowsUpdatesUpdatableassetsUpdatableassetIdMicrosoftGraphWindowsupdatesAddmembersPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Add, AddViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IWindowsUpdatesIdentity
Parameter Sets: AddViaIdentity, AddViaIdentityExpanded
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
Parameter Sets: Add, AddExpanded
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

### Microsoft.Graph.PowerShell.Models.IPathsH2EvdrAdminWindowsUpdatesUpdatableassetsUpdatableassetIdMicrosoftGraphWindowsupdatesAddmembersPostRequestbodyContentApplicationJsonSchema

### Microsoft.Graph.PowerShell.Models.IWindowsUpdatesIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

### Add-MgWuUpdatableAssetMember

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ASSETS <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>: .
  - `[Id <String>]`: Read-only.

BODYPARAMETER <IPathsH2EvdrAdminWindowsUpdatesUpdatableassetsUpdatableassetIdMicrosoftGraphWindowsupdatesAddmembersPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Assets <IMicrosoftGraphWindowsUpdatesUpdatableAsset[]>]`: 
    - `[Id <String>]`: Read-only.

INPUTOBJECT <IWindowsUpdatesIdentity>: Identity Parameter
  - `[CatalogEntryId <String>]`: key: id of catalogEntry
  - `[DeploymentId <String>]`: key: id of deployment
  - `[UpdatableAssetId <String>]`: key: id of updatableAsset

## RELATED LINKS

