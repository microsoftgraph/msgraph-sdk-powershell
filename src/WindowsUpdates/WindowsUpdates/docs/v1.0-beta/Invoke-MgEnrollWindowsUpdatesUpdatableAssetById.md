---
external help file:
Module Name: Microsoft.Graph.Beta.WindowsUpdates
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.windowsupdates/invoke-mgenrollwindowsupdatesupdatableassetbyid
schema: 2.0.0
---

# Invoke-MgBetaEnrollWindowsUpdatesUpdatableAssetById

## SYNOPSIS
Invoke action enrollAssetsById

## SYNTAX

### EnrollExpanded (Default)
```
Invoke-MgBetaEnrollWindowsUpdatesUpdatableAssetById [-AdditionalProperties <Hashtable>] [-Ids <String[]>]
 [-MemberEntityType <String>] [-UpdateCategory <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Enroll
```
Invoke-MgBetaEnrollWindowsUpdatesUpdatableAssetById
 -BodyParameter <IPaths134Mc7AdminWindowsUpdatesUpdatableassetsMicrosoftGraphWindowsupdatesEnrollassetsbyidPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action enrollAssetsById

## EXAMPLES

### Example 1: Using the Invoke-MgBetaEnrollWindowsUpdatesUpdatableAssetById Cmdlet
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
Invoke-MgBetaEnrollWindowsUpdatesUpdatableAssetById -BodyParameter $params
```

This example shows how to use the Invoke-MgBetaEnrollWindowsUpdatesUpdatableAssetById Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: EnrollExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths134Mc7AdminWindowsUpdatesUpdatableassetsMicrosoftGraphWindowsupdatesEnrollassetsbyidPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Enroll
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
Parameter Sets: EnrollExpanded
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
Parameter Sets: EnrollExpanded
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
Parameter Sets: EnrollExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IPaths134Mc7AdminWindowsUpdatesUpdatableassetsMicrosoftGraphWindowsupdatesEnrollassetsbyidPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

### Invoke-MgBetaEnrollWuUpdatableAssetGraphBPreId

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths134Mc7AdminWindowsUpdatesUpdatableassetsMicrosoftGraphWindowsupdatesEnrollassetsbyidPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Ids <String[]>]`: 
  - `[MemberEntityType <String>]`: 
  - `[UpdateCategory <String>]`: updateCategory

## RELATED LINKS

