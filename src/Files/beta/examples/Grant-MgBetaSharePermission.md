### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Files

$params = @{
	recipients = @(
		@{
			email = "john@contoso.com"
		}
		@{
			email = "ryan@external.com"
		}
	)
	roles = @(
	"read"
)
}

Grant-MgBetaSharePermission -SharedDriveItemId $sharedDriveItemId -BodyParameter $params

```
This example shows how to use the Grant-MgBetaSharePermission Cmdlet.

