### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DirectoryObjects

$params = @{
	entityType = "Group"
	displayName = "Myprefix_test_mysuffix"
	mailNickname = "Myprefix_test_mysuffix"
	onBehalfOfUserId = "onBehalfOfUserId-value"
}

Test-MgDirectoryObjectProperty -BodyParameter $params

```
This example shows how to use the Test-MgDirectoryObjectProperty Cmdlet.

