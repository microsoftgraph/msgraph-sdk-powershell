### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	displayName = "Updated Production Zone"
	description = "Updated description for production environments"
}

Update-MgBetaSecurityZone -ZoneId $zoneId -BodyParameter $params

```
This example shows how to use the Update-MgBetaSecurityZone Cmdlet.

