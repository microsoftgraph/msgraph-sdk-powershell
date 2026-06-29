### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Notes

$params = @{
	webUrl = "webUrl value"
}

# A UPN can also be used as -UserId.
Get-MgBetaUserOnenoteNotebookFromWebUrl -UserId $userId -BodyParameter $params

```
This example shows how to use the Get-MgBetaUserOnenoteNotebookFromWebUrl Cmdlet.

