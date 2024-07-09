### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CorporateManagement

$params = @{
	"@odata.type" = "#microsoft.graph.mobileAppCategory"
	displayName = "Display Name value"
}

New-MgDeviceAppManagementMobileAppCategory -BodyParameter $params

```
This example shows how to use the New-MgDeviceAppManagementMobileAppCategory Cmdlet.

