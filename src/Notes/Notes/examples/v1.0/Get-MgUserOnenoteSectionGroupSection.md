### Example 1: Using the Get-MgUserOnenoteSectionGroupSection Cmdlet
```powershell
Import-Module Microsoft.Graph.Notes
# A UPN can also be used as -UserId.
Get-MgUserOnenoteSectionGroupSection -UserId $userId -SectionGroupId $sectionGroupId
```
This example shows how to use the Get-MgUserOnenoteSectionGroupSection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
