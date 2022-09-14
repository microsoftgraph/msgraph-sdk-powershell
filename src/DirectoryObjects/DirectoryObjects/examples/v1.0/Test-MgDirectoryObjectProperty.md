### Example 1
```powershell
Import-Module Microsoft.Graph.DirectoryObjects
$params = @{
	EntityType = "Group"
	DisplayName = "Myprefix_test_mysuffix"
	MailNickname = "Myprefix_test_mysuffix"
	OnBehalfOfUserId = "onBehalfOfUserId-value"
}
Test-MgDirectoryObjectProperty -BodyParameter $params
```
