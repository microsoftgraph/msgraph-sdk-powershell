### Example 1: Using the New-MgBetaUserOnenoteSectionGroupSection Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Notes
$params = @{
	DisplayName = "Section name"
}
# A UPN can also be used as -UserId.
New-MgBetaUserOnenoteSectionGroupSection -UserId $userId -SectionGroupId $sectionGroupId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserOnenoteSectionGroupSection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
