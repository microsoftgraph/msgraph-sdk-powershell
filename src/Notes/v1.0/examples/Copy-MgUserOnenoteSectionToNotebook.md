### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Notes

$params = @{
	id = "id-value"
	groupId = "groupId-value"
	renameAs = "renameAs-value"
}

# A UPN can also be used as -UserId.
Copy-MgUserOnenoteSectionToNotebook -UserId $userId -OnenoteSectionId $onenoteSectionId -BodyParameter $params

```
This example shows how to use the Copy-MgUserOnenoteSectionToNotebook Cmdlet.

