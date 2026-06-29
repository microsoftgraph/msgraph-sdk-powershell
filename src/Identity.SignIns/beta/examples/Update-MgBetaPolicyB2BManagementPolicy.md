### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.b2bManagementPolicy"
	description = "Policy used for B2B features"
	displayName = "Policy1"
	definition = @(
	'{'B2BManagementPolicy':{'Version':1}}'
)
isOrganizationDefault = "true"
}

Update-MgBetaPolicyB2BManagementPolicy -B2bManagementPolicyId $b2bManagementPolicyId -BodyParameter $params

```
This example shows how to use the Update-MgBetaPolicyB2BManagementPolicy Cmdlet.

