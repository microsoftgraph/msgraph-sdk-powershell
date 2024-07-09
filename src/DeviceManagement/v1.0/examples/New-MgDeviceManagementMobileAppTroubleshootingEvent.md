### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	"@odata.type" = "#microsoft.graph.mobileAppTroubleshootingEvent"
}

New-MgDeviceManagementMobileAppTroubleshootingEvent -BodyParameter $params

```
This example shows how to use the New-MgDeviceManagementMobileAppTroubleshootingEvent Cmdlet.

