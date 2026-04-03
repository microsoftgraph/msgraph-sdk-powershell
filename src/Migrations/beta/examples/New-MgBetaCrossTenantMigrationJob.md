### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Migrations

$params = @{
	displayName = "xtmigration_user_req_1"
	completeAfterDateTime = [System.DateTime]::Parse("2024-12-09T22:48:03.092Z")
	sourceTenantId = "12345678-1234-1234-1234-123456789012"
	exchangeSettings = @{
		targetDeliveryDomain = "xtmigration.onmicrosoft.com"
		sourceEndpoint = "sampleEndpointText"
	}
	resources = @(
	"4dd550d9-9ea2-4e71-a16b-60b1d1c4f506"
"63f15b55-f61a-49cb-a599-2e3d233afb2c"
"41d94bac-3a53-47d6-a89e-583830104e15"
)
resourceType = "Users"
workloads = @(
"Teams"
"Exchange"
"ODSP"
)
}

New-MgBetaCrossTenantMigrationJob -BodyParameter $params

```
This example shows how to use the New-MgBetaCrossTenantMigrationJob Cmdlet.

