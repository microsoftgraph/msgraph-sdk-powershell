### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Search

$params = @{
	description = "The dates that Contoso offices will be closed to observe holidays. These dates may differ from the actual date of the holiday in cases where the holiday falls on a wee​kend."
}

Update-MgSearchQna -QnaId $qnaId -BodyParameter $params

```
This example shows how to use the Update-MgSearchQna Cmdlet.

