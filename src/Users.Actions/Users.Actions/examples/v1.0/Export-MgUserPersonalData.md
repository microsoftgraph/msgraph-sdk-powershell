###Example 1
```
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	StorageLocation = "storageLocation-value"
}
Export-MgUserPersonalData -UserId $userId -BodyParameter $params
```
