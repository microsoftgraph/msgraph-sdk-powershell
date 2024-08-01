### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Actions

$params = @{
	assignments = @(
		@{
			"@odata.type" = "#microsoft.graph.deviceCompliancePolicyAssignment"
			id = "92dc3fef-3fef-92dc-ef3f-dc92ef3fdc92"
			target = @{
				"@odata.type" = "microsoft.graph.configurationManagerCollectionAssignmentTarget"
				collectionId = "Collection Id value"
			}
		}
	)
}

Set-MgDeviceManagementDeviceCompliancePolicy -DeviceCompliancePolicyId $deviceCompliancePolicyId -BodyParameter $params

```
This example shows how to use the Set-MgDeviceManagementDeviceCompliancePolicy Cmdlet.

