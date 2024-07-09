### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Search

$params = @{
	acl = @(
		@{
			type = "everyone"
			value = "67a141d8-cf4e-4528-ba07-bed21bfacd2d"
			accessType = "grant"
		}
	)
}

Set-MgExternalConnectionItem -ExternalConnectionId $externalConnectionId -ExternalItemId $externalItemId -BodyParameter $params

```
This example shows how to use the Set-MgExternalConnectionItem Cmdlet.

