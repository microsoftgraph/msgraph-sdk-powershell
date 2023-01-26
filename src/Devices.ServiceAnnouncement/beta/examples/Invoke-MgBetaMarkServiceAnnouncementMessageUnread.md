### Example 1: Using the Invoke-MgBetaMarkServiceAnnouncementMessageUnread Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Devices.ServiceAnnouncement
$params = @{
	MessageIds = @(
		"MC172851"
		"MC167983"
	)
}
Invoke-MgBetaMarkServiceAnnouncementMessageUnread -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaMarkServiceAnnouncementMessageUnread Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
