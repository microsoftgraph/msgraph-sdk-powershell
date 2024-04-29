---
external help file:
Module Name: Microsoft.Graph.Beta.WindowsUpdates
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.windowsupdates/invoke-mgbetagraphwindowsupdatesupdatableasset
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
 -Body <IPaths4Wme8AdminWindowsUpdatesUpdatableassetsMicrosoftGraphWindowsupdatesUnenrollassetsbyidPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action unenrollAssetsById

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.WindowsUpdates
$params = @{
	UpdateCategory = "feature"
	MemberEntityType = "#microsoft.graph.windowsUpdates.azureADDevice"
	Ids = @(
		"String"
		"String"
		"String"
	)
}
Invoke-MgBetaGraphWindowsUpdatesUpdatableAsset -BodyParameter $params
```



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

### -Body
.
To construct, see NOTES section for BODY properties and create a hash table.

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

Invoke-MgBetaGraphWuUpdatableAsset

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IPaths4Wme8AdminWindowsUpdatesUpdatableassetsMicrosoftGraphWindowsupdatesUnenrollassetsbyidPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Ids <String[]>]`: 
  - `[MemberEntityType <String>]`: 
  - `[UpdateCategory <String>]`: updateCategory

## RELATED LINKS

