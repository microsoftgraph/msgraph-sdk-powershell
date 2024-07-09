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

Update-MgDeviceAppManagementMobileAppAssignment -MobileAppId $mobileAppId -MobileAppAssignmentId $mobileAppAssignmentId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceAppManagementMobileAppAssignment Cmdlet.

