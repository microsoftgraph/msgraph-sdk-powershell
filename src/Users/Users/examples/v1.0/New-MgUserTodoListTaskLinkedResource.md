###Example 1
```
Import-Module Microsoft.Graph.Users
$params = @{
	WebUrl = "https://microsoft.com"
	ApplicationName = "Microsoft"
	DisplayName = "Microsoft"
	ExternalId = "dk9cddce2-dce2-f9dd-e2dc-cdf9e2dccdf9"
}
# A UPN can also be used as -UserId.
New-MgUserTodoListTaskLinkedResource -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId -BodyParameter $params
```
