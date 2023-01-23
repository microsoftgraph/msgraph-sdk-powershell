### Example 1: Using the Invoke-MgArchiveServiceAnnouncementMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Devices.ServiceAnnouncement
$params = @{
	MessageIds = @(
		"MC172851"
		"MC167983"
	)
}
Invoke-MgArchiveServiceAnnouncementMessage -BodyParameter $params
```
This example shows how to use the Invoke-MgArchiveServiceAnnouncementMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
