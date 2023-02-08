### Example 1: Using the Invoke-MgUnfavoriteServiceAnnouncementMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Devices.ServiceAnnouncement
$params = @{
	MessageIds = @(
		"MC172851"
		"MC167983"
	)
}
Invoke-MgUnfavoriteServiceAnnouncementMessage -BodyParameter $params
```
This example shows how to use the Invoke-MgUnfavoriteServiceAnnouncementMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
