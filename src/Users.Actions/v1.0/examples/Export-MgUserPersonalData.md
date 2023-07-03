### Example 1: Using the Export-MgUserPersonalData Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	StorageLocation = "storageLocation-value"
}
Export-MgUserPersonalData -UserId $userId -BodyParameter $params
```
This example shows how to use the Export-MgUserPersonalData Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
