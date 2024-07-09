### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CorporateManagement

$params = @{
	"@odata.type" = "#microsoft.graph.windowsAppX"
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
	applicableArchitectures = "x86"
	identityName = "Identity Name value"
	identityPublisherHash = "Identity Publisher Hash value"
	identityResourceIdentifier = "Identity Resource Identifier value"
	isBundle = $true
	minimumSupportedOperatingSystem = @{
		"@odata.type" = "microsoft.graph.windowsMinimumOperatingSystem"
		v8_0 = $true
		v8_1 = $true
		v10_0 = $true
	}
	identityVersion = "Identity Version value"
}

New-MgDeviceAppManagementMobileApp -BodyParameter $params

```
This example shows how to use the New-MgDeviceAppManagementMobileApp Cmdlet.

