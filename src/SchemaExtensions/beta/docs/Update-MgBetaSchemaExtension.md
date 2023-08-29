---
external help file:
Module Name: Microsoft.Graph.Beta.SchemaExtensions
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.schemaextensions/update-mgbetaschemaextension
schema: 2.0.0
---

# Update-MgBetaSchemaExtension

## SYNOPSIS
Update properties in the definition of the specified schemaExtension.
Additive updates to the extension can only be made when the extension is in the InDevelopment or Available status.
This means custom properties or target resource types cannot be removed from the definition, but new custom properties can be added and the description of the extension changed.
The update applies to all the resources that are included in the targetTypes property of the extension.
These resources are among the supporting resource types.
For delegated flows, the signed-in user can update a schema extension as long as the owner property of the extension is set to the appId of an application the signed-in user owns.
That application can be the one that initially created the extension, or some other application owned by the signed-in user.
This criteria for the owner property allows a signed-in user to make updates through other applications they don't own, such as Microsoft Graph Explorer.
When using Graph Explorer to update a schemaExtension resource, include the owner property in the PATCH request body.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaSchemaExtension -SchemaExtensionId <String> [-AdditionalProperties <Hashtable>]
 [-Description <String>] [-Id <String>] [-Owner <String>]
 [-Properties <IMicrosoftGraphExtensionSchemaProperty[]>] [-Status <String>] [-TargetTypes <String[]>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaSchemaExtension -SchemaExtensionId <String> -BodyParameter <IMicrosoftGraphSchemaExtension>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaSchemaExtension -InputObject <ISchemaExtensionsIdentity>
 -BodyParameter <IMicrosoftGraphSchemaExtension> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaSchemaExtension -InputObject <ISchemaExtensionsIdentity> [-AdditionalProperties <Hashtable>]
 [-Description <String>] [-Id <String>] [-Owner <String>]
 [-Properties <IMicrosoftGraphExtensionSchemaProperty[]>] [-Status <String>] [-TargetTypes <String[]>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update properties in the definition of the specified schemaExtension.
Additive updates to the extension can only be made when the extension is in the InDevelopment or Available status.
This means custom properties or target resource types cannot be removed from the definition, but new custom properties can be added and the description of the extension changed.
The update applies to all the resources that are included in the targetTypes property of the extension.
These resources are among the supporting resource types.
For delegated flows, the signed-in user can update a schema extension as long as the owner property of the extension is set to the appId of an application the signed-in user owns.
That application can be the one that initially created the extension, or some other application owned by the signed-in user.
This criteria for the owner property allows a signed-in user to make updates through other applications they don't own, such as Microsoft Graph Explorer.
When using Graph Explorer to update a schemaExtension resource, include the owner property in the PATCH request body.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.SchemaExtensions
```

$params = @{
	owner = "ef4cb9a8-97c3-4ca7-854b-5cb5ced376fa"
	properties = @(
		@{
			name = "courseId"
			type = "Integer"
		}
		@{
			name = "courseName"
			type = "String"
		}
		@{
			name = "courseType"
			type = "String"
		}
		@{
			name = "courseSupervisors"
			type = "String"
		}
	)
}

Update-MgBetaSchemaExtension -SchemaExtensionId $schemaExtensionId -BodyParameter $params

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
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSchemaExtension
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
The unique identifier for an entity.
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
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.ISchemaExtensionsIdentity
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
The owner of the schema definition must be explicitly specified during the Create and Update operations, or it will be implied and auto-assigned by Azure AD as follows: In delegated access: The signed-in user must be the owner of the app that calls Microsoft Graph to create the schema extension definition.
If the signed-in user isn't the owner of the calling app, they must explicitly specify the owner property, and assign it the appId of an app that they own.
In app-only access: The owner property isn't required in the request body.
Instead, the calling app is assigned ownership of the schema extension.
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

### -Properties
The collection of property names and types that make up the schema extension definition.
To construct, see NOTES section for PROPERTIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphExtensionSchemaProperty[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSchemaExtension

### Microsoft.Graph.Beta.PowerShell.Models.ISchemaExtensionsIdentity

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSchemaExtension

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphSchemaExtension>`: schemaExtension
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Description <String>]`: Description for the schema extension. Supports $filter (eq).
  - `[Owner <String>]`: The appId of the application that is the owner of the schema extension. The owner of the schema definition must be explicitly specified during the Create and Update operations, or it will be implied and auto-assigned by Azure AD as follows: In delegated access: The signed-in user must be the owner of the app that calls Microsoft Graph to create the schema extension definition.  If the signed-in user isn't the owner of the calling app, they must explicitly specify the owner property, and assign it the appId of an app that they own. In app-only access:  The owner property isn't required in the request body. Instead, the calling app is assigned ownership of the schema extension. So, for example, if creating a new schema extension definition using Graph Explorer, you must supply the owner property. Once set, this property is read-only and cannot be changed. Supports $filter (eq).
  - `[Properties <IMicrosoftGraphExtensionSchemaProperty[]>]`: The collection of property names and types that make up the schema extension definition.
    - `[Name <String>]`: The name of the strongly typed property defined as part of a schema extension.
    - `[Type <String>]`: The type of the property that is defined as part of a schema extension.  Allowed values are Binary, Boolean, DateTime, Integer or String. See the table below for more details.
  - `[Status <String>]`: The lifecycle state of the schema extension. Possible states are InDevelopment, Available, and Deprecated. Automatically set to InDevelopment on creation. For more information about the possible state transitions and behaviors, see Schema extensions lifecycle. Supports $filter (eq).
  - `[TargetTypes <String[]>]`: Set of Microsoft Graph types (that can support extensions) that the schema extension can be applied to. Select from administrativeUnit, contact, device, event, group, message, organization, post, todoTask, todoTaskList, or user.

`INPUTOBJECT <ISchemaExtensionsIdentity>`: Identity Parameter
  - `[SchemaExtensionId <String>]`: The unique identifier of schemaExtension

`PROPERTIES <IMicrosoftGraphExtensionSchemaProperty[]>`: The collection of property names and types that make up the schema extension definition.
  - `[Name <String>]`: The name of the strongly typed property defined as part of a schema extension.
  - `[Type <String>]`: The type of the property that is defined as part of a schema extension.  Allowed values are Binary, Boolean, DateTime, Integer or String. See the table below for more details.

## RELATED LINKS

