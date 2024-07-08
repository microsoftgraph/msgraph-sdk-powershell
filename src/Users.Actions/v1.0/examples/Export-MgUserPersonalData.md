### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Users.Actions

$params = @{
	storageLocation = "storageLocation-value"
}

Export-MgUserPersonalData -UserId $userId -BodyParameter $params

```
This example shows how to use the Export-MgUserPersonalData Cmdlet.

