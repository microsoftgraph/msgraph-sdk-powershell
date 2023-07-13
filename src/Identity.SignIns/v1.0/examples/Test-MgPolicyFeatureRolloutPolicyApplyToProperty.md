### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.DirectoryObjects

$params = @{
	EntityType = "Group"
	DisplayName = "Myprefix_test_mysuffix"
	MailNickname = "Myprefix_test_mysuffix"
	OnBehalfOfUserId = "onBehalfOfUserId-value"
}

Test-MgDirectoryObjectProperty -BodyParameter $params
```
This example shows how to use the Test-MgPolicyFeatureRolloutPolicyApplyToProperty Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

