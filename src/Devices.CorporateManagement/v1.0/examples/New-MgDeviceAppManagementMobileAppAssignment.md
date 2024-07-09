### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CorporateManagement

$params = @{
	"@odata.type" = "#microsoft.graph.mobileAppAssignment"
	intent = "required"
	target = @{
		"@odata.type" = "microsoft.graph.allLicensedUsersAssignmentTarget"
	}
	settings = @{
		"@odata.type" = "microsoft.graph.windowsUniversalAppXAppAssignmentSettings"
		useDeviceContext = $true
	}
}

New-MgDeviceAppManagementMobileAppAssignment -MobileAppId $mobileAppId -BodyParameter $params

```
This example shows how to use the New-MgDeviceAppManagementMobileAppAssignment Cmdlet.

