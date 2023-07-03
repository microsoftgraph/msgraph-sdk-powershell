### Example 1: Using the Invoke-MgBetaArchiveServiceAnnouncementMessage Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Devices.ServiceAnnouncement
$params = @{
	MessageIds = @(
		"MC172851"
		"MC167983"
	)
}
Invoke-MgBetaArchiveServiceAnnouncementMessage -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaArchiveServiceAnnouncementMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
