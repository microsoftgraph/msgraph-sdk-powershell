### Example 1
```powershell
Import-Module Microsoft.Graph.Search
$params = @{
	Acl = @(
		@{
			Type = "everyone"
			Value = "67a141d8-cf4e-4528-ba07-bed21bfacd2d"
			AccessType = "grant"
		}
	)
}
Update-MgExternalConnectionItem -ExternalConnectionId $externalConnectionId -ExternalItemId $externalItemId -BodyParameter $params
```
