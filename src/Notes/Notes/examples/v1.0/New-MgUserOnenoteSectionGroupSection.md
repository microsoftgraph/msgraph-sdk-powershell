### Example 1: Using the New-MgUserOnenoteSectionGroupSection Cmdlet
```powershell
Import-Module Microsoft.Graph.Notes
$params = @{
	DisplayName = "Section name"
}
# A UPN can also be used as -UserId.
New-MgUserOnenoteSectionGroupSection -UserId $userId -SectionGroupId $sectionGroupId -BodyParameter $params
```
This example shows how to use the New-MgUserOnenoteSectionGroupSection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
