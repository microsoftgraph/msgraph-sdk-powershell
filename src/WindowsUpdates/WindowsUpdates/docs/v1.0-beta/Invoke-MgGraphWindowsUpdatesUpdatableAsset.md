---
external help file:
Module Name: Microsoft.Graph.Beta.WindowsUpdates
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.windowsupdates/invoke-mggraphwindowsupdatesupdatableasset
schema: 2.0.0
---

# Invoke-MgBetaGraphWindowsUpdatesUpdatableAsset

## SYNOPSIS
Invoke action unenrollAssetsById

## SYNTAX

### GraphExpanded (Default)
```
Invoke-MgBetaGraphWindowsUpdatesUpdatableAsset [-AdditionalProperties <Hashtable>] [-Ids <String[]>]
 [-MemberEntityType <String>] [-UpdateCategory <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Graph
```
Invoke-MgBetaGraphWindowsUpdatesUpdatableAsset
 -BodyParameter <IPaths4Wme8AdminWindowsUpdatesUpdatableassetsMicrosoftGraphWindowsupdatesUnenrollassetsbyidPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action unenrollAssetsById

## EXAMPLES

### Example 1: Using the Invoke-MgBetaGraphWindowsUpdatesUpdatableAsset Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.WindowsUpdates
$params = @{
	UpdateCategory = "feature"
	MemberEntityType = "#Microsoft.Graph.Beta.windowsUpdates.azureADDevice"
	Ids = @(
		"String"
		"String"
		"String"
	)
}
Invoke-MgBetaGraphWindowsUpdatesUpdatableAsset -BodyParameter $params
```

This example shows how to use the Invoke-MgBetaGraphWindowsUpdatesUpdatableAsset Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: GraphExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths4Wme8AdminWindowsUpdatesUpdatableassetsMicrosoftGraphWindowsupdatesUnenrollassetsbyidPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Graph
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Ids
.

```yaml
Type: System.String[]
Parameter Sets: GraphExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MemberEntityType
.

```yaml
Type: System.String
Parameter Sets: GraphExpanded
Aliases:

Required: False
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

### -UpdateCategory
updateCategory

```yaml
Type: System.String
Parameter Sets: GraphExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IPaths4Wme8AdminWindowsUpdatesUpdatableassetsMicrosoftGraphWindowsupdatesUnenrollassetsbyidPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

### Invoke-MgBetaGraphWuUpdatableAsset

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths4Wme8AdminWindowsUpdatesUpdatableassetsMicrosoftGraphWindowsupdatesUnenrollassetsbyidPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Ids <String[]>]`: 
  - `[MemberEntityType <String>]`: 
  - `[UpdateCategory <String>]`: updateCategory

## RELATED LINKS

