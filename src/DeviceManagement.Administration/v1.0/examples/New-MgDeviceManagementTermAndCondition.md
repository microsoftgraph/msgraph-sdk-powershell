### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Administration

$params = @{
	"@odata.type" = "#microsoft.graph.termsAndConditions"
	displayName = "Display Name value"
	description = "Description value"
	title = "Title value"
	bodyText = "Body Text value"
	acceptanceStatement = "Acceptance Statement value"
	version = 7
}

New-MgDeviceManagementTermAndCondition -BodyParameter $params

```
This example shows how to use the New-MgDeviceManagementTermAndCondition Cmdlet.

