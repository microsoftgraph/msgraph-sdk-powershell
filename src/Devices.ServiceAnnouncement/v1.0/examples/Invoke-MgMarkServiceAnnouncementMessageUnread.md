### Example 1: Using the Invoke-MgMarkServiceAnnouncementMessageUnread Cmdlet
```powershell
Import-Module Microsoft.Graph.Devices.ServiceAnnouncement
$params = @{
	MessageIds = @(
		"MC172851"
		"MC167983"
	)
}
Invoke-MgMarkServiceAnnouncementMessageUnread -BodyParameter $params
```
This example shows how to use the Invoke-MgMarkServiceAnnouncementMessageUnread Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
