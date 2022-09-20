### Example 1: Using the New-MgRoleManagementEntitlementManagementRoleAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
$params = @{
	PrincipalId = "679a9213-c497-48a4-830a-8d3d25d94ddc"
	RoleDefinitionId = "ae79f266-94d4-4dab-b730-feca7e132178"
	AppScopeId = "/AccessPackageCatalog/beedadfe-01d5-4025-910b-84abb9369997"
}
New-MgRoleManagementEntitlementManagementRoleAssignment -BodyParameter $params
```
This example shows how to use the New-MgRoleManagementEntitlementManagementRoleAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
