### Example 1: A successful validation request

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
This example will a successful validation request

### Example 2: An unsuccessful validation request

```powershell

Import-Module Microsoft.Graph.DirectoryObjects

$params = @{
	entityType = "Group"
	displayName = "test"
	mailNickname = "test"
	onBehalfOfUserId = "onBehalfOfUserId-value"
}

Test-MgDirectoryObjectProperty -BodyParameter $params

```
This example will an unsuccessful validation request

