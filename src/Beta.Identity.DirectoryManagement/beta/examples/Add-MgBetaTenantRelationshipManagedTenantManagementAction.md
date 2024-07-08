### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	tenantId = "String"
	tenantGroupId = "String"
	managementTemplateId = "String"
}

Add-MgBetaTenantRelationshipManagedTenantManagementAction -ManagementActionId $managementActionId -BodyParameter $params

```
This example shows how to use the Add-MgBetaTenantRelationshipManagedTenantManagementAction Cmdlet.

