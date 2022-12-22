### Example 1: Using the New-MgBetaUserTodoListTaskLinkedResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
$params = @{
	WebUrl = "https://microsoft.com"
	ApplicationName = "Microsoft"
	DisplayName = "Microsoft"
	ExternalId = "dk9cddce2-dce2-f9dd-e2dc-cdf9e2dccdf9"
}
# A UPN can also be used as -UserId.
New-MgBetaUserTodoListTaskLinkedResource -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserTodoListTaskLinkedResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
