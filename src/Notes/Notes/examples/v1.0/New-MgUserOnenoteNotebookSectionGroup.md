### Example 1
``` powershell
Import-Module Microsoft.Graph.Notes
$params = @{
	DisplayName = "Section group name"
}
# A UPN can also be used as -UserId.
New-MgUserOnenoteNotebookSectionGroup -UserId $userId -NotebookId $notebookId -BodyParameter $params
```
