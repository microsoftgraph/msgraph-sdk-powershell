### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.DirectoryObjects

$params = @{
	entityType = "Group"
	displayName = "Myprefix_test_mysuffix"
	mailNickname = "Myprefix_test_mysuffix"
	onBehalfOfUserId = "onBehalfOfUserId-value"
}

Test-MgBetaDirectoryObjectProperty -BodyParameter $params

```
This example shows how to use the Test-MgBetaDirectoryObjectProperty Cmdlet.

