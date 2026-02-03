### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Notes

$params = @{
	displayName = "Section name"
}

# A UPN can also be used as -UserId.
New-MgUserOnenoteNotebookSection -UserId $userId -NotebookId $notebookId -BodyParameter $params

```
This example shows how to use the New-MgUserOnenoteNotebookSection Cmdlet.

