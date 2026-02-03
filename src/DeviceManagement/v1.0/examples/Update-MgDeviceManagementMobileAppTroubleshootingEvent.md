### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	"@odata.type" = "#microsoft.graph.mobileAppTroubleshootingEvent"
}

Update-MgDeviceManagementMobileAppTroubleshootingEvent -MobileAppTroubleshootingEventId $mobileAppTroubleshootingEventId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceManagementMobileAppTroubleshootingEvent Cmdlet.

