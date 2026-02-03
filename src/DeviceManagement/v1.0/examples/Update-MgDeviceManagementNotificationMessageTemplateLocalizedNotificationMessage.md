### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	"@odata.type" = "#microsoft.graph.localizedNotificationMessage"
	locale = "Locale value"
	subject = "Subject value"
	messageTemplate = "Message Template value"
	isDefault = $true
}

Update-MgDeviceManagementNotificationMessageTemplateLocalizedNotificationMessage -NotificationMessageTemplateId $notificationMessageTemplateId -LocalizedNotificationMessageId $localizedNotificationMessageId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceManagementNotificationMessageTemplateLocalizedNotificationMessage Cmdlet.

