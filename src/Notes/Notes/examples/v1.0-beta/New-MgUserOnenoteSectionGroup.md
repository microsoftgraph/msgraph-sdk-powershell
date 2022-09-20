### Example 1: Using the New-MgUserOnenoteSectionGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Notes
$params = @{
	DisplayName = "Section group name"
}
# A UPN can also be used as -UserId.
New-MgUserOnenoteSectionGroup -UserId $userId -SectionGroupId $sectionGroupId -BodyParameter $params
```
This example shows how to use the New-MgUserOnenoteSectionGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
