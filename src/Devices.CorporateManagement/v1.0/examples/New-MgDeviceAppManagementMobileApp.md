### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CorporateManagement

$params = @{
	"@odata.type" = "#microsoft.graph.androidStoreApp"
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
	packageId = "Package Id value"
	appStoreUrl = "https://example.com/appStoreUrl/"
	minimumSupportedOperatingSystem = @{
		"@odata.type" = "microsoft.graph.androidMinimumOperatingSystem"
		v4_0 = $true
		v4_0_3 = $true
		v4_1 = $true
		v4_2 = $true
		v4_3 = $true
		v4_4 = $true
		v5_0 = $true
		v5_1 = $true
		v6_0 = $true
		v7_0 = $true
		v7_1 = $true
		v8_0 = $true
		v8_1 = $true
		v9_0 = $true
		v10_0 = $true
		v11_0 = $true
	}
}

New-MgDeviceAppManagementMobileApp -BodyParameter $params

```
This example shows how to use the New-MgDeviceAppManagementMobileApp Cmdlet.

