### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Groups

$params = @{
	displayName = "Myprefix_test_mysuffix"
	mailNickname = "Myprefix_test_mysuffix"
	onBehalfOfUserId = "onBehalfOfUserId-value"
}

Test-MgGroupProperty -GroupId $groupId -BodyParameter $params

```
This example shows how to use the Test-MgGroupProperty Cmdlet.

