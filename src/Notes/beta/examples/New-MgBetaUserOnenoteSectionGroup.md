### Example 1: Using the New-MgBetaUserOnenoteSectionGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Notes
$params = @{
	DisplayName = "Section group name"
}
# A UPN can also be used as -UserId.
New-MgBetaUserOnenoteSectionGroup -UserId $userId -SectionGroupId $sectionGroupId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserOnenoteSectionGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
