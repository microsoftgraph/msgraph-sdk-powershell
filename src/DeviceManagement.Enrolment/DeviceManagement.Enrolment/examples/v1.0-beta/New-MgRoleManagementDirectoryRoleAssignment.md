### Example 1: Using the New-MgRoleManagementDirectoryRoleAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
$params = @{
	"@odata.type" = "#microsoft.graph.unifiedRoleAssignment"
	RoleDefinitionId = "58a13ea3-c632-46ae-9ee0-9c0d43cd7f3d"
	PrincipalId = "f8ca5a85-489a-49a0-b555-0a6d81e56f0d"
	DirectoryScopeId = "/attributeSets/Engineering"
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
	RoleDefinitionId = "c2cf284d-6c41-4e6b-afac-4b80928c9034"
	PrincipalId = "f8ca5a85-489a-49a0-b555-0a6d81e56f0d"
	DirectoryScopeId = "/"
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
	RoleDefinitionId = "fe930be7-5e62-47db-91af-98c3a49a38b1"
	PrincipalId = "f8ca5a85-489a-49a0-b555-0a6d81e56f0d"
	DirectoryScopeId = "/administrativeUnits/5d107bba-d8e2-4e13-b6ae-884be90e5d1a"
}
New-MgRoleManagementDirectoryRoleAssignment -BodyParameter $params
```
This example shows how to use the New-MgRoleManagementDirectoryRoleAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
