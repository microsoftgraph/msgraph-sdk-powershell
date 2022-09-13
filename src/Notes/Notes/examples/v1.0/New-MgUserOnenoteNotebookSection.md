###Example 1
```
Import-Module Microsoft.Graph.Notes
$params = @{
	DisplayName = "Section name"
}
# A UPN can also be used as -UserId.
New-MgUserOnenoteNotebookSection -UserId $userId -NotebookId $notebookId -BodyParameter $params
```
