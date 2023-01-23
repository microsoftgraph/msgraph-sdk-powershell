### Example 1: Using the Update-MgBetaExternalConnectionItem Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Search
$params = @{
	Acl = @(
		@{
			Type = "everyone"
			Value = "67a141d8-cf4e-4528-ba07-bed21bfacd2d"
			AccessType = "grant"
		}
	)
}
Update-MgBetaExternalConnectionItem -ExternalConnectionId $externalConnectionId -ExternalItemId $externalItemId -BodyParameter $params
```
This example shows how to use the Update-MgBetaExternalConnectionItem Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
