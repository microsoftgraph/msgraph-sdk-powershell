### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CorporateManagement

$params = @{
	"@odata.type" = "#microsoft.graph.windowsMobileMSI"
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
	commandLine = "Command Line value"
	productCode = "Product Code value"
	productVersion = "Product Version value"
	ignoreVersionDetection = $true
}

New-MgDeviceAppManagementMobileApp -BodyParameter $params

```
This example shows how to use the New-MgDeviceAppManagementMobileApp Cmdlet.

