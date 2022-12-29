### Example 1: Using the Get-MgBetaUserOnenoteNotebookFromWebUrl Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
$params = @{
	WebUrl = "webUrl value"
}
# A UPN can also be used as -UserId.
Get-MgBetaUserOnenoteNotebookFromWebUrl -UserId $userId -BodyParameter $params
```
This example shows how to use the Get-MgBetaUserOnenoteNotebookFromWebUrl Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
