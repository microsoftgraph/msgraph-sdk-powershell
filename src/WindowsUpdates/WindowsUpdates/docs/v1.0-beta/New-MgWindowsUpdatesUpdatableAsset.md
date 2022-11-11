---
external help file:
Module Name: Microsoft.Graph.WindowsUpdates
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.windowsupdates/new-mgwindowsupdatesupdatableasset
schema: 2.0.0
---

# New-MgWindowsUpdatesUpdatableAsset

## SYNOPSIS
Create a new updatableAssetGroup object.
The **updatableAssetGroup** resource inherits from updatableAsset.

## SYNTAX

### CreateExpanded (Default)
```
New-MgWindowsUpdatesUpdatableAsset [-AdditionalProperties <Hashtable>] [-Id <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgWindowsUpdatesUpdatableAsset -BodyParameter <Hashtable> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new updatableAssetGroup object.
The **updatableAssetGroup** resource inherits from updatableAsset.

## EXAMPLES

### Example 1: Using the New-MgWindowsUpdatesUpdatableAsset Cmdlet
```powershell
Import-Module Microsoft.Graph.WindowsUpdates
$params = @{
	"@odata.type" = "#microsoft.graph.windowsUpdates.updatableAssetGroup"
}
New-MgWindowsUpdatesUpdatableAsset -BodyParameter $params
```

This example shows how to use the New-MgWindowsUpdatesUpdatableAsset Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded
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
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
Read-only.

```yaml
Type: System.String
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

### System.Collections.Hashtable

## OUTPUTS

### System.String

## NOTES

ALIASES

### New-MgWuUpdatableAsset

## RELATED LINKS

