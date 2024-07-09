### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	"@odata.type" = "#microsoft.graph.deviceComplianceScheduledActionForRule"
	ruleName = "Rule Name value"
}

New-MgDeviceManagementDeviceCompliancePolicyScheduledActionForRule -DeviceCompliancePolicyId $deviceCompliancePolicyId -BodyParameter $params

```
This example shows how to use the New-MgDeviceManagementDeviceCompliancePolicyScheduledActionForRule Cmdlet.

