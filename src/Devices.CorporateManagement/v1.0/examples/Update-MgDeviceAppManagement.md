### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CorporateManagement

$params = @{
	"@odata.type" = "#microsoft.graph.deviceAppManagement"
	microsoftStoreForBusinessLastSuccessfulSyncDateTime = [System.DateTime]::Parse("2016-12-31T23:57:45.2453148-08:00")
	isEnabledForMicrosoftStoreForBusiness = $true
	microsoftStoreForBusinessLanguage = "Microsoft Store For Business Language value"
	microsoftStoreForBusinessLastCompletedApplicationSyncTime = [System.DateTime]::Parse("2017-01-01T00:02:00.0421137-08:00")
}

Update-MgDeviceAppManagement -BodyParameter $params

```
This example shows how to use the Update-MgDeviceAppManagement Cmdlet.

