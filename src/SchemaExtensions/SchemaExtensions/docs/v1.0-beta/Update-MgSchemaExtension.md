---
external help file:
Module Name: Microsoft.Graph.SchemaExtensions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.schemaextensions/update-mgschemaextension
schema: 2.0.0
---

# Update-MgSchemaExtension

## SYNOPSIS
Update properties in the definition of the specified schemaExtension.
Additive updates to the extension can only be made when the extension is in the `InDevelopment` or `Available` status.
This means custom properties or target resource types cannot be removed from the definition, but new custom properties can be added and the description of the extension changed.
The update applies to all the resources that are included in the **targetTypes** property of the extension.
These resources are among the supporting resource types.
For delegated flows, the signed-in user can update a schema extension as long as the **owner** property of the extension is set to the **appId** of an application the signed-in user owns.
That application can be the one that initially created the extension, or some other application owned by the signed-in user.
This criteria for the **owner** property allows a signed-in user to make updates through other applications they don't own, such as Microsoft Graph Explorer.
When using Graph Explorer to update a **schemaExtension** resource, include the **owner** property in the PATCH request body.
For more information, see the Extensions section in Known issues with Microsoft Graph.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgSchemaExtension -SchemaExtensionId <String> [-AdditionalProperties <Hashtable>]
 [-Description <String>] [-Id <String>] [-Owner <String>]
 [-Properties <IMicrosoftGraphExtensionSchemaProperty[]>] [-Status <String>] [-TargetTypes <String[]>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgSchemaExtension -SchemaExtensionId <String> -BodyParameter <IMicrosoftGraphSchemaExtension>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgSchemaExtension -InputObject <ISchemaExtensionsIdentity>
 -BodyParameter <IMicrosoftGraphSchemaExtension> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgSchemaExtension -InputObject <ISchemaExtensionsIdentity> [-AdditionalProperties <Hashtable>]
 [-Description <String>] [-Id <String>] [-Owner <String>]
 [-Properties <IMicrosoftGraphExtensionSchemaProperty[]>] [-Status <String>] [-TargetTypes <String[]>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update properties in the definition of the specified schemaExtension.
Additive updates to the extension can only be made when the extension is in the `InDevelopment` or `Available` status.
This means custom properties or target resource types cannot be removed from the definition, but new custom properties can be added and the description of the extension changed.
The update applies to all the resources that are included in the **targetTypes** property of the extension.
These resources are among the supporting resource types.
For delegated flows, the signed-in user can update a schema extension as long as the **owner** property of the extension is set to the **appId** of an application the signed-in user owns.
That application can be the one that initially created the extension, or some other application owned by the signed-in user.
This criteria for the **owner** property allows a signed-in user to make updates through other applications they don't own, such as Microsoft Graph Explorer.
When using Graph Explorer to update a **schemaExtension** resource, include the **owner** property in the PATCH request body.
For more information, see the Extensions section in Known issues with Microsoft Graph.

## EXAMPLES

### Example 1: Using the Update-MgSchemaExtension Cmdlet
```powershell
Import-Module Microsoft.Graph.SchemaExtensions
$params = @{
	Owner = "ef4cb9a8-97c3-4ca7-854b-5cb5ced376fa"
	Properties = @(
		@{
			Name = "courseId"
			Type = "Integer"
		}
		@{
			Name = "courseName"
			Type = "String"
		}
		@{
			Name = "courseType"
			Type = "String"
		}
		@{
			Name = "courseSupervisors"
			Type = "String"
		}
	)
}
Update-MgSchemaExtension -SchemaExtensionId $schemaExtensionId -BodyParameter $params
```

This example shows how to use the Update-MgSchemaExtension Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Using the Update-MgSchemaExtension Cmdlet
```powershell
Import-Module Microsoft.Graph.SchemaExtensions
$params = @{
	Owner = "ef4cb9a8-97c3-4ca7-854b-5cb5ced376fa"
	Properties = @(
		@{
			Name = "courseId"
			Type = "Integer"
		}
		@{
			Name = "courseName"
			Type = "String"
		}
		@{
			Name = "courseType"
			Type = "String"
		}
		@{
			Name = "courseSupervisors"
			Type = "String"
		}
	)
}
Update-MgSchemaExtension -SchemaExtensionId $schemaExtensionId -BodyParameter $params
```

This example shows how to use the Update-MgSchemaExtension Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

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
schemaExtension
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSchemaExtension
Parameter Sets: Update, UpdateViaIdentity
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
.

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
Type: Microsoft.Graph.PowerShell.Models.ISchemaExtensionsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### -Properties
The collection of property names and types that make up the schema extension definition.
To construct, please use Get-Help -Online and see NOTES section for PROPERTIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphExtensionSchemaProperty[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
The lifecycle state of the schema extension.
Possible states are InDevelopment, Available, and Deprecated.
Automatically set to InDevelopment on creation.
For more information about the possible state transitions and behaviors, see Schema extensions lifecycle.
Supports $filter (eq).

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

### -TargetTypes
Set of Microsoft Graph types (that can support extensions) that the schema extension can be applied to.
Select from administrativeUnit, contact, device, event, group, message, organization, post, todoTask, todoTaskList, or user.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.ISchemaExtensionsIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphSchemaExtension>: schemaExtension
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[Description <String>]`: Description for the schema extension. Supports $filter (eq).
  - `[Owner <String>]`: The appId of the application that is the owner of the schema extension. This property can be supplied on creation, to set the owner.  If not supplied, then the calling application's appId will be set as the owner. In either case, the signed-in user must be the owner of the application. So, for example, if creating a new schema extension definition using Graph Explorer, you must supply the owner property. Once set, this property is read-only and cannot be changed. Supports $filter (eq).
  - `[Properties <IMicrosoftGraphExtensionSchemaProperty[]>]`: The collection of property names and types that make up the schema extension definition.
    - `[Name <String>]`: The name of the strongly-typed property defined as part of a schema extension.
    - `[Type <String>]`: The type of the property that is defined as part of a schema extension.  Allowed values are Binary, Boolean, DateTime, Integer or String. See the table below for more details.
  - `[Status <String>]`: The lifecycle state of the schema extension. Possible states are InDevelopment, Available, and Deprecated. Automatically set to InDevelopment on creation. For more information about the possible state transitions and behaviors, see Schema extensions lifecycle. Supports $filter (eq).
  - `[TargetTypes <String[]>]`: Set of Microsoft Graph types (that can support extensions) that the schema extension can be applied to. Select from administrativeUnit, contact, device, event, group, message, organization, post, todoTask, todoTaskList, or user.

INPUTOBJECT <ISchemaExtensionsIdentity>: Identity Parameter
  - `[SchemaExtensionId <String>]`: key: id of schemaExtension

PROPERTIES <IMicrosoftGraphExtensionSchemaProperty[]>: The collection of property names and types that make up the schema extension definition.
  - `[Name <String>]`: The name of the strongly-typed property defined as part of a schema extension.
  - `[Type <String>]`: The type of the property that is defined as part of a schema extension.  Allowed values are Binary, Boolean, DateTime, Integer or String. See the table below for more details.

## RELATED LINKS

