### Example 1: Using the Test-MgBetaDirectoryObjectProperty Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.DirectoryObjects
$params = @{
	EntityType = "Group"
	DisplayName = "Myprefix_test_mysuffix"
	MailNickname = "Myprefix_test_mysuffix"
	OnBehalfOfUserId = "onBehalfOfUserId-value"
}
Test-MgBetaDirectoryObjectProperty -BodyParameter $params
```
This example shows how to use the Test-MgBetaDirectoryObjectProperty Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
