### Example 1: Using the New-MgUserOutlookTaskFolderTask Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
$params = @{
	Subject = "Shop for dinner"
	StartDateTime = @{
		DateTime = "2016-04-23T18:00:00"
		TimeZone = "Pacific Standard Time"
	}
	DueDateTime = @{
		DateTime = "2016-04-25T13:00:00"
		TimeZone = "Pacific Standard Time"
	}
}
# A UPN can also be used as -UserId.
New-MgUserOutlookTaskFolderTask -UserId $userId -OutlookTaskFolderId $outlookTaskFolderId -BodyParameter $params
```
This example shows how to use the New-MgUserOutlookTaskFolderTask Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
