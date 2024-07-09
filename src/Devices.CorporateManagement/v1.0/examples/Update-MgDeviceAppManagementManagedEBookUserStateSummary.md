### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CorporateManagement

$params = @{
	"@odata.type" = "#microsoft.graph.userInstallStateSummary"
	userName = "User Name value"
	installedDeviceCount = 4
	failedDeviceCount = 1
	notInstalledDeviceCount = 7
}

Update-MgDeviceAppManagementManagedEBookUserStateSummary -ManagedEBookId $managedEBookId -UserInstallStateSummaryId $userInstallStateSummaryId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceAppManagementManagedEBookUserStateSummary Cmdlet.

