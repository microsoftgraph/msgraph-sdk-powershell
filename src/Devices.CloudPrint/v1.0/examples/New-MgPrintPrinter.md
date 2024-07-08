### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CloudPrint

$params = @{
	displayName = "Test Printer"
	manufacturer = "Test Printer Manufacturer"
	model = "Test Printer Model"
	physicalDeviceId = $null
	hasPhysicalDevice = $false
	certificateSigningRequest = @{
		content = '{content}'
		transportKey = '{sampleTransportKey}'
	}
	connectorId = $null
}

New-MgPrintPrinter -BodyParameter $params

```
This example shows how to use the New-MgPrintPrinter Cmdlet.

