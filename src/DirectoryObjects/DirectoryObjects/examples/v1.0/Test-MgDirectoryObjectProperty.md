### Example 1: Using the Test-MgDirectoryObjectProperty Cmdlet
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
This example shows how to use the Test-MgDirectoryObjectProperty Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
