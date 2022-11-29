### Example 1: Using the Invoke-MgUnarchiveServiceAnnouncementMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Devices.ServiceAnnouncement
$params = @{
	MessageIds = @(
		"MC172851"
		"MC167983"
	)
}
Invoke-MgUnarchiveServiceAnnouncementMessage -BodyParameter $params
```
This example shows how to use the Invoke-MgUnarchiveServiceAnnouncementMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
