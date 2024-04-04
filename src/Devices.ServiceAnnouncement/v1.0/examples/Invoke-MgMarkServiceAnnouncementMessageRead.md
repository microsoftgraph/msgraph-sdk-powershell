### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.ServiceAnnouncement

$params = @{
	messageIds = @(
	"MC172851"
"MC167983"
)
}

Invoke-MgMarkServiceAnnouncementMessageRead -BodyParameter $params

```
This example shows how to use the Invoke-MgMarkServiceAnnouncementMessageRead Cmdlet.

