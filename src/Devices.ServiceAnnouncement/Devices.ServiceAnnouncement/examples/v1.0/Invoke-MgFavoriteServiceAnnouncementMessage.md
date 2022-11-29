### Example 1: Using the Invoke-MgFavoriteServiceAnnouncementMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Devices.ServiceAnnouncement
$params = @{
	MessageIds = @(
		"MC172851"
		"MC167983"
	)
}
Invoke-MgFavoriteServiceAnnouncementMessage -BodyParameter $params
```
This example shows how to use the Invoke-MgFavoriteServiceAnnouncementMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
