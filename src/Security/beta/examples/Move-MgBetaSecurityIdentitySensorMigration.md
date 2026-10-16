### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	sensorIds = @(
	"fdce0c43-15e8-e322-7656-aff297505af5"
"a1b2c3d4-e5f6-7890-abcd-ef1234567890"
)
}

Move-MgBetaSecurityIdentitySensorMigration -BodyParameter $params

```
This example shows how to use the Move-MgBetaSecurityIdentitySensorMigration Cmdlet.

