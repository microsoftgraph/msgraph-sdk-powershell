### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Actions

$params = @{
	filter = "ActionState eq 'failed'"
	select = @(
	"Id"
"CloudPcDeviceDisplayName"
"BulkActionId"
"BulkActionDisplayName"
"CloudPcId"
"InitiatedByUserPrincipalName"
"DeviceOwnerUserPrincipalName"
"Action"
"ActionState"
"RequestDateTime"
"LastUpdatedDateTime"
"ActionParameters"
)
skip = 0
top = 50
}

Get-MgBetaDeviceManagementVirtualEndpointReportActionStatusReport -BodyParameter $params

```
This example shows how to use the Get-MgBetaDeviceManagementVirtualEndpointReportActionStatusReport Cmdlet.

