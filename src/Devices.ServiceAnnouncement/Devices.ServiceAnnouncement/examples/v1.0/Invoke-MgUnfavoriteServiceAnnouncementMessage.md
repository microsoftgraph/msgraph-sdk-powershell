### Example 1
``` powershell
Import-Module Microsoft.Graph.Devices.ServiceAnnouncement
$params = @{
	MessageIds = @(
		"MC172851"
		"MC167983"
	)
}
Invoke-MgUnfavoriteServiceAnnouncementMessage -BodyParameter $params
```
