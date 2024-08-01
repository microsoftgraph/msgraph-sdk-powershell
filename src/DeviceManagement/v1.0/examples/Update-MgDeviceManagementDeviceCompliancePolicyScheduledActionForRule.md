### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	"@odata.type" = "#microsoft.graph.deviceComplianceScheduledActionForRule"
	ruleName = "Rule Name value"
}

Update-MgDeviceManagementDeviceCompliancePolicyScheduledActionForRule -DeviceCompliancePolicyId $deviceCompliancePolicyId -DeviceComplianceScheduledActionForRuleId $deviceComplianceScheduledActionForRuleId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceManagementDeviceCompliancePolicyScheduledActionForRule Cmdlet.

