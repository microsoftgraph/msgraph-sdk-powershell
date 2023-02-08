### Example 1: Using the Get-MgBetaUserOnenoteSectionGroupSection Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Notes
# A UPN can also be used as -UserId.
Get-MgBetaUserOnenoteSectionGroupSection -UserId $userId -SectionGroupId $sectionGroupId
```
This example shows how to use the Get-MgBetaUserOnenoteSectionGroupSection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
