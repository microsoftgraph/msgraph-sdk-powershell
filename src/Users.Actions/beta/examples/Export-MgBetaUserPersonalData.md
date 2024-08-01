### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	storageLocation = "storageLocation-value"
}

Export-MgBetaUserPersonalData -UserId $userId -BodyParameter $params

```
This example shows how to use the Export-MgBetaUserPersonalData Cmdlet.

