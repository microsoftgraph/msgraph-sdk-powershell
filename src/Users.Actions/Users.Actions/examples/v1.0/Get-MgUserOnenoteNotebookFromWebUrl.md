###Example 1
```
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	WebUrl = "webUrl value"
}
# A UPN can also be used as -UserId.
Get-MgUserOnenoteNotebookFromWebUrl -UserId $userId -BodyParameter $params
```
