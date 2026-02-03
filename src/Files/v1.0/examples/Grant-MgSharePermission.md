### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Files

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

Grant-MgSharePermission -SharedDriveItemId $sharedDriveItemId -BodyParameter $params

```
This example shows how to use the Grant-MgSharePermission Cmdlet.

