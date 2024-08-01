### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Reports

$params = @{
	"@odata.type" = "#microsoft.graph.deviceManagementReports"
}

Update-MgDeviceManagementReport -BodyParameter $params

```
This example shows how to use the Update-MgDeviceManagementReport Cmdlet.

