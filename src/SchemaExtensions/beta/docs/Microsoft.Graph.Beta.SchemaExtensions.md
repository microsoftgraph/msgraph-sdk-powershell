---
Module Name: Microsoft.Graph.Beta.SchemaExtensions
Module Guid: ebb511b7-7b64-4653-9ab6-8f6f24cf7fa1
Download Help Link: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.schemaextensions
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Beta.SchemaExtensions Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Beta.SchemaExtensions Cmdlets
### [Get-MgBetaSchemaExtension](Get-MgBetaSchemaExtension.md)
Get the properties of the specified schemaExtension definition.

### [Get-MgBetaSchemaExtensionCount](Get-MgBetaSchemaExtensionCount.md)
Get the number of the resource

### [New-MgBetaSchemaExtension](New-MgBetaSchemaExtension.md)
Create a new schemaExtension definition and its associated schema extension property to extend a supporting resource type.
Schema extensions let you add strongly-typed custom data to a resource.
The app that creates a schema extension is the owner app.
Depending on the \nstate of the extension, the owner app, and only the owner app, may update or delete the extension.
See examples of how to define a schema extension that describes a training course, \nuse the schema extension definition to create a new group with training course data, and \nadd training course data to an existing group.

### [Remove-MgBetaSchemaExtension](Remove-MgBetaSchemaExtension.md)
Delete the definition of a schema extension.
In app-only scenarios, only the app that created the schema extension (owner app) can delete the schema extension definition, and only when the extension is in the InDevelopment state.
In delegated scenarios, the owner of the owner app can delete the schema extension definition, and only when the extension is in the InDevelopment state.
Deleting a schema extension definition before deleting the data associated with the extension in the target resources makes the data inaccessible.
To recover the data, you can recreate the schema extension definition with the same configuration, but only if you used the verified domain for the schema extension id.

### [Update-MgBetaSchemaExtension](Update-MgBetaSchemaExtension.md)
Update properties in the definition of the specified schemaExtension.
Additive updates to the extension can only be made when the extension is in the InDevelopment or Available status.
This means custom properties or target resource types cannot be removed from the definition, but new custom properties can be added and the description of the extension changed.
The update applies to all the resources that are included in the targetTypes property of the extension.
These resources are among the supporting resource types.
For delegated flows, the signed-in user can update a schema extension as long as the owner property of the extension is set to the appId of an application the signed-in user owns.
That application can be the one that initially created the extension, or some other application owned by the signed-in user.
This criteria for the owner property allows a signed-in user to make updates through other applications they don't own, such as Microsoft Graph Explorer.
When using Graph Explorer to update a schemaExtension resource, include the owner property in the PATCH request body.

