### Example 1: Using the Export-MgBetaUserPersonalData Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
$params = @{
	StorageLocation = "storageLocation-value"
}
Export-MgBetaUserPersonalData -UserId $userId -BodyParameter $params
```
This example shows how to use the Export-MgBetaUserPersonalData Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
