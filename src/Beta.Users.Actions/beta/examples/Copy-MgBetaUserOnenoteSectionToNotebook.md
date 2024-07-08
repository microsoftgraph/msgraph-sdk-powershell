### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	id = "id-value"
	groupId = "groupId-value"
	renameAs = "renameAs-value"
}

# A UPN can also be used as -UserId.
Copy-MgBetaUserOnenoteSectionToNotebook -UserId $userId -OnenoteSectionId $onenoteSectionId -BodyParameter $params

```
This example shows how to use the Copy-MgBetaUserOnenoteSectionToNotebook Cmdlet.

