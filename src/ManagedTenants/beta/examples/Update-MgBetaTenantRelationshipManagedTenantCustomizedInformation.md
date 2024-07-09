### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.ManagedTenants

$params = @{
	"@odata.type" = "#microsoft.graph.managedTenants.tenantCustomizedInformation"
	tenantId = "String"
	contacts = @(
		@{
			"@odata.type" = "microsoft.graph.managedTenants.tenantContactInformation"
			name = "String"
			title = "String"
			email = "String"
			phone = "String"
			notes = "String"
		}
	)
	website = "String"
}

Update-MgBetaTenantRelationshipManagedTenantCustomizedInformation -TenantCustomizedInformationId $tenantCustomizedInformationId -BodyParameter $params

```
This example shows how to use the Update-MgBetaTenantRelationshipManagedTenantCustomizedInformation Cmdlet.

