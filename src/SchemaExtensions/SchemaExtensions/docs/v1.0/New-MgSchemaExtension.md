---
external help file:
Module Name: Microsoft.Graph.SchemaExtensions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.schemaextensions/new-mgschemaextension
schema: 2.0.0
---

# New-MgSchemaExtension

## SYNOPSIS
Add new entity to schemaExtensions

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgSchemaExtension [-AdditionalProperties <Hashtable>] [-Description <String>] [-Id <String>]
 [-Owner <String>] [-Properties <IMicrosoftGraphExtensionSchemaProperty[]>] [-Status <String>]
 [-TargetTypes <String[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgSchemaExtension -BodyParameter <IMicrosoftGraphSchemaExtension> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Add new entity to schemaExtensions

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
schemaExtension
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSchemaExtension
Parameter Sets: Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Description
Description for the schema extension.
Supports $filter (eq).

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Owner
The appId of the application that is the owner of the schema extension.
This property can be supplied on creation, to set the owner.
If not supplied, then the calling application's appId will be set as the owner.
In either case, the signed-in user must be the owner of the application.
So, for example, if creating a new schema extension definition using Graph Explorer, you must supply the owner property.
Once set, this property is read-only and cannot be changed.
Supports $filter (eq).

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Properties
The collection of property names and types that make up the schema extension definition.
To construct, please use Get-Help -Online and see NOTES section for PROPERTIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExtensionSchemaProperty[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
The lifecycle state of the schema extension.
Possible states are InDevelopment, Available, and Deprecated.
Automatically set to InDevelopment on creation.
Schema extensions provides more information on the possible state transitions and behaviors.
Supports $filter (eq).

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetTypes
Set of Microsoft Graph types (that can support extensions) that the schema extension can be applied to.
Select from contact, device, event, group, message, organization, post, or user.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSchemaExtension

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSchemaExtension

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphSchemaExtension>: schemaExtension
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Description <String>]`: Description for the schema extension. Supports $filter (eq).
  - `[Owner <String>]`: The appId of the application that is the owner of the schema extension. This property can be supplied on creation, to set the owner.  If not supplied, then the calling application's appId will be set as the owner. In either case, the signed-in user must be the owner of the application. So, for example, if creating a new schema extension definition using Graph Explorer, you must supply the owner property. Once set, this property is read-only and cannot be changed. Supports $filter (eq).
  - `[Properties <IMicrosoftGraphExtensionSchemaProperty[]>]`: The collection of property names and types that make up the schema extension definition.
    - `[Name <String>]`: The name of the strongly-typed property defined as part of a schema extension.
    - `[Type <String>]`: The type of the property that is defined as part of a schema extension.  Allowed values are Binary, Boolean, DateTime, Integer or String.  See the table below for more details.
  - `[Status <String>]`: The lifecycle state of the schema extension. Possible states are InDevelopment, Available, and Deprecated. Automatically set to InDevelopment on creation. Schema extensions provides more information on the possible state transitions and behaviors. Supports $filter (eq).
  - `[TargetTypes <String[]>]`: Set of Microsoft Graph types (that can support extensions) that the schema extension can be applied to. Select from contact, device, event, group, message, organization, post, or user.

PROPERTIES <IMicrosoftGraphExtensionSchemaProperty[]>: The collection of property names and types that make up the schema extension definition.
  - `[Name <String>]`: The name of the strongly-typed property defined as part of a schema extension.
  - `[Type <String>]`: The type of the property that is defined as part of a schema extension.  Allowed values are Binary, Boolean, DateTime, Integer or String.  See the table below for more details.

## RELATED LINKS

