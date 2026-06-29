### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CorporateManagement

$params = @{
	"@odata.type" = "#microsoft.graph.iosVppApp"
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
	usedLicenseCount = 
	totalLicenseCount = 
	releaseDateTime = "2017-01-01T00:01:34.7470482-08:00"
	appStoreUrl = "https://example.com/appStoreUrl/"
	licensingType = @{
		"@odata.type" = "microsoft.graph.vppLicensingType"
		supportsUserLicensing = $true
		supportsDeviceLicensing = $true
	}
	applicableDeviceType = @{
		"@odata.type" = "microsoft.graph.iosDeviceType"
		iPad = $true
		iPhoneAndIPod = $true
	}
	vppTokenOrganizationName = "Vpp Token Organization Name value"
	vppTokenAccountType = "education"
	vppTokenAppleId = "Vpp Token Apple Id value"
	bundleId = "Bundle Id value"
}

Update-MgDeviceAppManagementMobileApp -MobileAppId $mobileAppId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceAppManagementMobileApp Cmdlet.

