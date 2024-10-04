### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CorporateManagement

$params = @{
	"@odata.type" = "#microsoft.graph.macOSLobApp"
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
	minimumSupportedOperatingSystem = @{
		"@odata.type" = "microsoft.graph.macOSMinimumOperatingSystem"
		v10_7 = $true
		v10_8 = $true
		v10_9 = $true
		v10_10 = $true
		v10_11 = $true
		v10_12 = $true
		v10_13 = $true
		v10_14 = $true
		v10_15 = $true
		v11_0 = $true
		v12_0 = $true
		v13_0 = $true
	}
	buildNumber = "Build Number value"
	versionNumber = "Version Number value"
	childApps = @(
		@{
			"@odata.type" = "microsoft.graph.macOSLobChildApp"
			bundleId = "Bundle Id value"
			buildNumber = "Build Number value"
			versionNumber = "Version Number value"
		}
	)
	md5HashChunkSize = 
	md5Hash = @(
	"Md5Hash value"
)
ignoreVersionDetection = $true
installAsManaged = $true
}

New-MgDeviceAppManagementMobileApp -BodyParameter $params

```
This example shows how to use the New-MgDeviceAppManagementMobileApp Cmdlet.

