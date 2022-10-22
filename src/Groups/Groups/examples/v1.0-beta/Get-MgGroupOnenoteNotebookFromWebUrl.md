### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Users.Actions

$params = @{
	WebUrl = "webUrl value"
}

# A UPN can also be used as -UserId.
Get-MgUserOnenoteNotebookFromWebUrl -UserId $userId -BodyParameter $params
```
This example shows how to use the Get-MgGroupOnenoteNotebookFromWebUrl Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

