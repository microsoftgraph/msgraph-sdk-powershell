### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	displayName = "Connected organization new name"
	description = "Connected organization new description"
	state = "configured"
}

Update-MgBetaEntitlementManagementConnectedOrganization -ConnectedOrganizationId $connectedOrganizationId -BodyParameter $params
```
This example shows how to use the Update-MgBetaEntitlementManagementConnectedOrganization Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

