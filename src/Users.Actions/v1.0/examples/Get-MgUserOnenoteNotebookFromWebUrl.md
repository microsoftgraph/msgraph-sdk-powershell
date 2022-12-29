### Example 1: Using the Get-MgUserOnenoteNotebookFromWebUrl Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	WebUrl = "webUrl value"
}
# A UPN can also be used as -UserId.
Get-MgUserOnenoteNotebookFromWebUrl -UserId $userId -BodyParameter $params
```
This example shows how to use the Get-MgUserOnenoteNotebookFromWebUrl Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
