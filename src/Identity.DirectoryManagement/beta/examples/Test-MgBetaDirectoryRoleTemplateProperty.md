### Example 1: Code snippet

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
This example shows how to use the Test-MgBetaDirectoryRoleTemplateProperty Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

