---
external help file:
Module Name: Microsoft.Graph.Beta.SchemaExtensions
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.schemaextensions/remove-mgbetaschemaextension
schema: 2.0.0
---

# Remove-MgBetaSchemaExtension

## SYNOPSIS
Delete the definition of a schema extension.
In app-only scenarios, only the app that created the schema extension (owner app) can delete the schema extension definition, and only when the extension is in the InDevelopment state.
In delegated scenarios, the owner of the owner app can delete the schema extension definition, and only when the extension is in the InDevelopment state.
Deleting a schema extension definition before deleting the data associated with the extension in the target resources makes the data inaccessible.
To recover the data, you can recreate the schema extension definition with the same configuration, but only if you used the verified domain for the schema extension id.

## SYNTAX

### Delete (Default)
```
Remove-MgBetaSchemaExtension -SchemaExtensionId <String> [-IfMatch <String>]
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### DeleteViaIdentity
```
Remove-MgBetaSchemaExtension -InputObject <ISchemaExtensionsIdentity> [-IfMatch <String>]
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Delete the definition of a schema extension.
In app-only scenarios, only the app that created the schema extension (owner app) can delete the schema extension definition, and only when the extension is in the InDevelopment state.
In delegated scenarios, the owner of the owner app can delete the schema extension definition, and only when the extension is in the InDevelopment state.
Deleting a schema extension definition before deleting the data associated with the extension in the target resources makes the data inaccessible.
To recover the data, you can recreate the schema extension definition with the same configuration, but only if you used the verified domain for the schema extension id.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.SchemaExtensions
```

Remove-MgBetaSchemaExtension -SchemaExtensionId $schemaExtensionId

## PARAMETERS

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

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
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.ISchemaExtensionsIdentity
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

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SchemaExtensionId
The unique identifier of schemaExtension

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

### Microsoft.Graph.Beta.PowerShell.Models.ISchemaExtensionsIdentity

### System.Collections.IDictionary

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`INPUTOBJECT <ISchemaExtensionsIdentity>`: Identity Parameter
  - `[SchemaExtensionId <String>]`: The unique identifier of schemaExtension

## RELATED LINKS

