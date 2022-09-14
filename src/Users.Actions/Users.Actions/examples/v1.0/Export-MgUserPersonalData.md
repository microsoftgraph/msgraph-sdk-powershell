### Example 1
```powershell
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	StorageLocation = "storageLocation-value"
}
Export-MgUserPersonalData -UserId $userId -BodyParameter $params
```
