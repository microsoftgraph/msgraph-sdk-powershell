### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Notes

$params = @{
	displayName = "Section name"
}

# A UPN can also be used as -UserId.
New-MgBetaUserOnenoteNotebookSection -UserId $userId -NotebookId $notebookId -BodyParameter $params
```
This example shows how to use the New-MgBetaBetaGroupOnenoteNotebookSection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

