### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Administration

$params = @{
	"@odata.type" = "#microsoft.graph.applePushNotificationCertificate"
	appleIdentifier = "Apple Identifier value"
	topicIdentifier = "Topic Identifier value"
	expirationDateTime = [System.DateTime]::Parse("2016-12-31T23:57:57.2481234-08:00")
	certificateUploadStatus = "Certificate Upload Status value"
	certificateUploadFailureReason = "Certificate Upload Failure Reason value"
	certificateSerialNumber = "Certificate Serial Number value"
	certificate = "Certificate value"
}

Update-MgDeviceManagementApplePushNotificationCertificate -BodyParameter $params

```
This example shows how to use the Update-MgDeviceManagementApplePushNotificationCertificate Cmdlet.

