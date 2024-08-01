### Example 1: Create a role assignment with tenant scope

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	"@odata.type" = "#microsoft.graph.unifiedRoleAssignment"
	roleDefinitionId = "c2cf284d-6c41-4e6b-afac-4b80928c9034"
	principalId = "f8ca5a85-489a-49a0-b555-0a6d81e56f0d"
	directoryScopeId = "/"
}

New-MgRoleManagementDirectoryRoleAssignment -BodyParameter $params

```
This example will create a role assignment with tenant scope

### Example 2: Create a role assignment with administrative unit scope

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	"@odata.type" = "#microsoft.graph.unifiedRoleAssignment"
	roleDefinitionId = "fe930be7-5e62-47db-91af-98c3a49a38b1"
	principalId = "f8ca5a85-489a-49a0-b555-0a6d81e56f0d"
	directoryScopeId = "/administrativeUnits/5d107bba-d8e2-4e13-b6ae-884be90e5d1a"
}

New-MgRoleManagementDirectoryRoleAssignment -BodyParameter $params

```
This example will### Example 2: create a role assignment with administrative unit scope

### Example 3: Create a role assignment with application scope

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	"@odata.type" = "#microsoft.graph.unifiedRoleAssignment"
	principalId = "6b937a9d-c731-465b-a844-2d5b5368c161"
	roleDefinitionId = "9b895d92-2cd3-44c7-9d02-a6ac2d5ea5c3"
	directoryScopeId = "/661e1310-bd76-4795-89a7-8f3c8f855bfc"
}

New-MgRoleManagementDirectoryRoleAssignment -BodyParameter $params

```
This example will### Example 3: create a role assignment with application scope

