### Example 1: Using the Test-MgBetaGroupProperty Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Groups
$params = @{
	DisplayName = "Myprefix_test_mysuffix"
	MailNickname = "Myprefix_test_mysuffix"
	OnBehalfOfUserId = "onBehalfOfUserId-value"
}
Test-MgBetaGroupProperty -GroupId $groupId -BodyParameter $params
```
This example shows how to use the Test-MgBetaGroupProperty Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
