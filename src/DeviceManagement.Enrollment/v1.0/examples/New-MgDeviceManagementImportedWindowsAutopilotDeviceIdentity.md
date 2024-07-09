### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Enrollment

$params = @{
	"@odata.type" = "#microsoft.graph.importedWindowsAutopilotDeviceIdentity"
	groupTag = "Group Tag value"
	serialNumber = "Serial Number value"
	productKey = "Product Key value"
	importId = "Import Id value"
	hardwareIdentifier = [System.Text.Encoding]::ASCII.GetBytes("aGFyZHdhcmVJZGVudGlmaWVy")
	state = @{
		"@odata.type" = "microsoft.graph.importedWindowsAutopilotDeviceIdentityState"
		deviceImportStatus = "pending"
		deviceRegistrationId = "Device Registration Id value"
		deviceErrorCode = 15
		deviceErrorName = "Device Error Name value"
	}
	assignedUserPrincipalName = "Assigned User Principal Name value"
}

New-MgDeviceManagementImportedWindowsAutopilotDeviceIdentity -BodyParameter $params

```
This example shows how to use the New-MgDeviceManagementImportedWindowsAutopilotDeviceIdentity Cmdlet.

