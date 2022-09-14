### Example 1
``` powershell
Import-Module Microsoft.Graph.Notes
$params = @{
	DisplayName = "Section name"
}
# A UPN can also be used as -UserId.
New-MgUserOnenoteSectionGroupSection -UserId $userId -SectionGroupId $sectionGroupId -BodyParameter $params
```
