---
external help file:
Module Name: Microsoft.Graph.SchemaExtensions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.schemaextensions/remove-mgschemaextension
schema: 2.0.0
---

# Remove-MgSchemaExtension

## SYNOPSIS
Delete the definition of a schema extension.
Only the app that created the schema extension (owner app) can delete the schema extension definition, and only when the extension is in the `InDevelopment` state.
Deleting a schema extension definition does not affect accessing custom data that has been added to resource instances based on that definition.

## SYNTAX

### Delete (Default)
```
Remove-MgSchemaExtension -SchemaExtensionId <String> [-IfMatch <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### DeleteViaIdentity
```
Remove-MgSchemaExtension -InputObject <ISchemaExtensionsIdentity> [-IfMatch <String>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Delete the definition of a schema extension.
Only the app that created the schema extension (owner app) can delete the schema extension definition, and only when the extension is in the `InDevelopment` state.
Deleting a schema extension definition does not affect accessing custom data that has been added to resource instances based on that definition.

## EXAMPLES

### Example 1: Using the Remove-MgSchemaExtension Cmdlet
```powershell
Import-Module Microsoft.Graph.SchemaExtensions
Remove-MgSchemaExtension -SchemaExtensionId $schemaExtensionId
```

This example shows how to use the Remove-MgSchemaExtension Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -IfMatch
ETag

```yaml
Type: System.String
Parameter Sets: (All)
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
Type: Microsoft.Graph.PowerShell.Models.ISchemaExtensionsIdentity
Parameter Sets: DeleteViaIdentity
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

### -SchemaExtensionId
key: id of schemaExtension

```yaml
Type: System.String
Parameter Sets: Delete
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

### Microsoft.Graph.PowerShell.Models.ISchemaExtensionsIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <ISchemaExtensionsIdentity>: Identity Parameter
  - `[SchemaExtensionId <String>]`: key: id of schemaExtension

## RELATED LINKS

