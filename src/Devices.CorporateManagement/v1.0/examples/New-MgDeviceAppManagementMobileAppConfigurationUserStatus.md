### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CorporateManagement

$params = @{
	"@odata.type" = "#microsoft.graph.managedDeviceMobileAppConfigurationUserStatus"
	userDisplayName = "User Display Name value"
	devicesCount = 12
	status = "notApplicable"
	lastReportedDateTime = [System.DateTime]::Parse("2017-01-01T00:00:17.7769392-08:00")
	userPrincipalName = "User Principal Name value"
}

New-MgDeviceAppManagementMobileAppConfigurationUserStatus -ManagedDeviceMobileAppConfigurationId $managedDeviceMobileAppConfigurationId -BodyParameter $params

```
This example shows how to use the New-MgDeviceAppManagementMobileAppConfigurationUserStatus Cmdlet.

