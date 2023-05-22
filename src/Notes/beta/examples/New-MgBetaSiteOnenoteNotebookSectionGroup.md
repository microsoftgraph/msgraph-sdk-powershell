### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Notes

$params = @{
	displayName = "Section group name"
}

# A UPN can also be used as -UserId.
New-MgBetaUserOnenoteNotebookSectionGroup -UserId $userId -NotebookId $notebookId -BodyParameter $params
```
This example shows how to use the New-MgBetaBetaSiteOnenoteNotebookSectionGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

