### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Migrations

$params = @{
	displayName = "Contoso_migration_validation_job"
	completeAfterDateTime = "2025-05-22T17:14:52Z"
	sourceTenantId = "12345678-1234-1234-1234-123456789012"
	exchangeSettings = @{
		targetDeliveryDomain = "fabrikam.com"
		sourceEndpoint = "EXOHandler"
	}
	resources = @(
	"b5b8bc4f-0e36-4ad3-8ddf-248b68260b89"
"ac87d040-a081-426c-a73b-81133f458a29"
)
workloads = @(
"Teams"
)
resourceType = "Users"
}

Test-MgBetaCrossTenantMigrationJob -BodyParameter $params

```
This example shows how to use the Test-MgBetaCrossTenantMigrationJob Cmdlet.

