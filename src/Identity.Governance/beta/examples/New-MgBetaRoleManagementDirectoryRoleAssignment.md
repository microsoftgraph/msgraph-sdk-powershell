### Example 1: Create a role assignment with tenant scope

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	"@odata.type" = "#microsoft.graph.unifiedRoleAssignment"
	roleDefinitionId = "c2cf284d-6c41-4e6b-afac-4b80928c9034"
	principalId = "f8ca5a85-489a-49a0-b555-0a6d81e56f0d"
	directoryScopeId = "/"
}

New-MgBetaRoleManagementDirectoryRoleAssignment -BodyParameter $params

```
This example will create a role assignment with tenant scope

### Example 2: Create a role assignment with administrative unit scope

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	"@odata.type" = "#microsoft.graph.unifiedRoleAssignment"
	roleDefinitionId = "fe930be7-5e62-47db-91af-98c3a49a38b1"
	principalId = "f8ca5a85-489a-49a0-b555-0a6d81e56f0d"
	directoryScopeId = "/administrativeUnits/5d107bba-d8e2-4e13-b6ae-884be90e5d1a"
}

New-MgBetaRoleManagementDirectoryRoleAssignment -BodyParameter $params

```
This example will create a role assignment with administrative unit scope

### Example 3: Create a role assignment with attribute set scope

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	"@odata.type" = "#microsoft.graph.unifiedRoleAssignment"
	roleDefinitionId = "58a13ea3-c632-46ae-9ee0-9c0d43cd7f3d"
	principalId = "f8ca5a85-489a-49a0-b555-0a6d81e56f0d"
	directoryScopeId = "/attributeSets/Engineering"
}

New-MgBetaRoleManagementDirectoryRoleAssignment -BodyParameter $params

```
This example will create a role assignment with attribute set scope

