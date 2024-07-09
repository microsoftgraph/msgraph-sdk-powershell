### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CorporateManagement

$params = @{
	"@odata.type" = "#microsoft.graph.managedMobileApp"
	mobileAppIdentifier = @{
		"@odata.type" = "microsoft.graph.androidMobileAppIdentifier"
		packageId = "Package Id value"
	}
	version = "Version value"
}

New-MgDeviceAppManagementiOSManagedAppProtectionApp -IosManagedAppProtectionId $iosManagedAppProtectionId -BodyParameter $params

```
This example shows how to use the New-MgDeviceAppManagementiOSManagedAppProtectionApp Cmdlet.

