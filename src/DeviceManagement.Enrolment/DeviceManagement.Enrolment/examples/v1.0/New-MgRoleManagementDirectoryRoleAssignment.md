### Example 1: Using the New-MgRoleManagementDirectoryRoleAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
$params = @{
	"@odata.type" = "#microsoft.graph.unifiedRoleAssignment"
	RoleDefinitionId = "c2cf284d-6c41-4e6b-afac-4b80928c9034"
	PrincipalId = "f8ca5a85-489a-49a0-b555-0a6d81e56f0d"
	DirectoryScopeId = "/"
}
New-MgRoleManagementDirectoryRoleAssignment -BodyParameter $params
```
This example shows how to use the New-MgRoleManagementDirectoryRoleAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgRoleManagementDirectoryRoleAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
$params = @{
	"@odata.type" = "#microsoft.graph.unifiedRoleAssignment"
	RoleDefinitionId = "fe930be7-5e62-47db-91af-98c3a49a38b1"
	PrincipalId = "f8ca5a85-489a-49a0-b555-0a6d81e56f0d"
	DirectoryScopeId = "/administrativeUnits/5d107bba-d8e2-4e13-b6ae-884be90e5d1a"
}
New-MgRoleManagementDirectoryRoleAssignment -BodyParameter $params
```
This example shows how to use the New-MgRoleManagementDirectoryRoleAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the New-MgRoleManagementDirectoryRoleAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
$params = @{
	"@odata.type" = "#microsoft.graph.unifiedRoleAssignment"
	PrincipalId = "6b937a9d-c731-465b-a844-2d5b5368c161"
	RoleDefinitionId = "9b895d92-2cd3-44c7-9d02-a6ac2d5ea5c3"
	DirectoryScopeId = "/661e1310-bd76-4795-89a7-8f3c8f855bfc"
}
New-MgRoleManagementDirectoryRoleAssignment -BodyParameter $params
```
This example shows how to use the New-MgRoleManagementDirectoryRoleAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
