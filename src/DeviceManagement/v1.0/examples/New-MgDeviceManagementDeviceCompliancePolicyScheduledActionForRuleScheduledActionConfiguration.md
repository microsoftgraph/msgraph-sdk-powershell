### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	"@odata.type" = "#microsoft.graph.deviceComplianceActionItem"
	gracePeriodHours = 0
	actionType = "notification"
	notificationTemplateId = "Notification Template Id value"
	notificationMessageCCList = @(
	"Notification Message CCList value"
)
}

New-MgDeviceManagementDeviceCompliancePolicyScheduledActionForRuleScheduledActionConfiguration -DeviceCompliancePolicyId $deviceCompliancePolicyId -DeviceComplianceScheduledActionForRuleId $deviceComplianceScheduledActionForRuleId -BodyParameter $params

```
This example shows how to use the New-MgDeviceManagementDeviceCompliancePolicyScheduledActionForRuleScheduledActionConfiguration Cmdlet.

