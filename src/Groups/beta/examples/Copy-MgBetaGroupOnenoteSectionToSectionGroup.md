### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	Id = "id-value"
	GroupId = "groupId-value"
	RenameAs = "renameAs-value"
}

# A UPN can also be used as -UserId.
Copy-MgBetaUserOnenoteSectionToSectionGroup -UserId $userId -OnenoteSectionId $onenoteSectionId -BodyParameter $params
```
This example shows how to use the Copy-MgBetaGroupOnenoteSectionToSectionGroup Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

