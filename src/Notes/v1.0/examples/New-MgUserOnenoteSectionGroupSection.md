### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Notes

$params = @{
	displayName = "Section name"
}

# A UPN can also be used as -UserId.
New-MgUserOnenoteSectionGroupSection -UserId $userId -SectionGroupId $sectionGroupId -BodyParameter $params

```
This example shows how to use the New-MgUserOnenoteSectionGroupSection Cmdlet.

