### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Enrollment

$params = @{
	"@odata.type" = "#microsoft.graph.windowsAutopilotDeviceIdentity"
	groupTag = "Group Tag value"
	purchaseOrderIdentifier = "Purchase Order Identifier value"
	serialNumber = "Serial Number value"
	productKey = "Product Key value"
	manufacturer = "Manufacturer value"
	model = "Model value"
	enrollmentState = "enrolled"
	lastContactedDateTime = [System.DateTime]::Parse("2016-12-31T23:58:44.2908994-08:00")
	addressableUserName = "Addressable User Name value"
	userPrincipalName = "User Principal Name value"
	resourceName = "Resource Name value"
	skuNumber = "Sku Number value"
	systemFamily = "System Family value"
	azureActiveDirectoryDeviceId = "Azure Active Directory Device Id value"
	managedDeviceId = "Managed Device Id value"
	displayName = "Display Name value"
}

New-MgDeviceManagementWindowsAutopilotDeviceIdentity -BodyParameter $params

```
This example shows how to use the New-MgDeviceManagementWindowsAutopilotDeviceIdentity Cmdlet.

