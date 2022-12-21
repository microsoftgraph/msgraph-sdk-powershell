### Example 1: Using the Update-MgBetaUserOutlookTaskFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
$params = @{
	Name = "Charity work"
}
# A UPN can also be used as -UserId.
Update-MgBetaUserOutlookTaskFolder -UserId $userId -OutlookTaskFolderId $outlookTaskFolderId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserOutlookTaskFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
