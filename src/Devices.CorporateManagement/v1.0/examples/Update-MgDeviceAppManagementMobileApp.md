### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CorporateManagement

$params = @{
	"@odata.type" = "#microsoft.graph.iosLobApp"
	displayName = "Display Name value"
	description = "Description value"
	publisher = "Publisher value"
	largeIcon = @{
		"@odata.type" = "microsoft.graph.mimeContent"
		type = "Type value"
		value = [System.Text.Encoding]::ASCII.GetBytes("dmFsdWU=")
	}
	isFeatured = $true
	privacyInformationUrl = "https://example.com/privacyInformationUrl/"
	informationUrl = "https://example.com/informationUrl/"
	owner = "Owner value"
	developer = "Developer value"
	notes = "Notes value"
	publishingState = "processing"
	committedContentVersion = "Committed Content Version value"
	fileName = "File Name value"
	size = 
	bundleId = "Bundle Id value"
	applicableDeviceType = @{
		"@odata.type" = "microsoft.graph.iosDeviceType"
		iPad = $true
		iPhoneAndIPod = $true
	}
	minimumSupportedOperatingSystem = @{
		"@odata.type" = "microsoft.graph.iosMinimumOperatingSystem"
		v8_0 = $true
		v9_0 = $true
		v10_0 = $true
		v11_0 = $true
		v12_0 = $true
		v13_0 = $true
		v14_0 = $true
		v15_0 = $true
	}
	expirationDateTime = "2016-12-31T23:57:57.2481234-08:00"
	versionNumber = "Version Number value"
	buildNumber = "Build Number value"
}

Update-MgDeviceAppManagementMobileApp -MobileAppId $mobileAppId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceAppManagementMobileApp Cmdlet.

