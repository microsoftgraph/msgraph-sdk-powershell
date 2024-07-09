### Example 1: Create a role assignment with access package catalog scope

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	principalId = "679a9213-c497-48a4-830a-8d3d25d94ddc"
	roleDefinitionId = "ae79f266-94d4-4dab-b730-feca7e132178"
	appScopeId = "/AccessPackageCatalog/beedadfe-01d5-4025-910b-84abb9369997"
}

New-MgRoleManagementEntitlementManagementRoleAssignment -BodyParameter $params

```
This example will create a role assignment with access package catalog scope

