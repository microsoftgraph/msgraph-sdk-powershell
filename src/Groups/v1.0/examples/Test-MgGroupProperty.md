### Example 1: Using the Test-MgGroupProperty Cmdlet
```powershell
Import-Module Microsoft.Graph.Groups
$params = @{
	DisplayName = "Myprefix_test_mysuffix"
	MailNickname = "Myprefix_test_mysuffix"
	OnBehalfOfUserId = "onBehalfOfUserId-value"
}
Test-MgGroupProperty -GroupId $groupId -BodyParameter $params
```
This example shows how to use the Test-MgGroupProperty Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
