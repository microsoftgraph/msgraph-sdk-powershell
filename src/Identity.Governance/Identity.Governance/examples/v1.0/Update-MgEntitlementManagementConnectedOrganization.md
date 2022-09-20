### Example 1: Using the Update-MgEntitlementManagementConnectedOrganization Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	DisplayName = "Connected organization new name"
	Description = "Connected organization new description"
	State = "configured"
}
Update-MgEntitlementManagementConnectedOrganization -ConnectedOrganizationId $connectedOrganizationId -BodyParameter $params
```
This example shows how to use the Update-MgEntitlementManagementConnectedOrganization Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
