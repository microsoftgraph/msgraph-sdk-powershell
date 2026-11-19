### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Migrations

$params = @{
	completeAfterDateTime = [System.DateTime]::Parse("2025-05-22T17:14:52Z")
}

Update-MgBetaCrossTenantMigrationJob -CrossTenantMigrationJobId $crossTenantMigrationJobId -BodyParameter $params

```
This example shows how to use the Update-MgBetaCrossTenantMigrationJob Cmdlet.

