### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Notes

$params = @{
	webUrl = "webUrl value"
}

# A UPN can also be used as -UserId.
Get-MgUserOnenoteNotebookFromWebUrl -UserId $userId -BodyParameter $params

```
This example shows how to use the Get-MgUserOnenoteNotebookFromWebUrl Cmdlet.

