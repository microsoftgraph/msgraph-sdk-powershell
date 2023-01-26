### Example 1: Using the Update-MgBetaTenantRelationshipManagedTenantCustomizedInformation Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.ManagedTenants
$params = @{
	"@odata.type" = "#microsoft.graph.managedTenants.tenantCustomizedInformation"
	TenantId = "String"
	Contacts = @(
		@{
			"@odata.type" = "microsoft.graph.managedTenants.tenantContactInformation"
			Name = "String"
			Title = "String"
			Email = "String"
			Phone = "String"
			Notes = "String"
		}
	)
	Website = "String"
}
Update-MgBetaTenantRelationshipManagedTenantCustomizedInformation -TenantCustomizedInformationId $tenantCustomizedInformationId -BodyParameter $params
```
This example shows how to use the Update-MgBetaTenantRelationshipManagedTenantCustomizedInformation Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
