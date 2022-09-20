### Example 1: Using the Update-MgUserOutlookTaskFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
$params = @{
	Name = "Charity work"
}
# A UPN can also be used as -UserId.
Update-MgUserOutlookTaskFolder -UserId $userId -OutlookTaskFolderId $outlookTaskFolderId -BodyParameter $params
```
This example shows how to use the Update-MgUserOutlookTaskFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
