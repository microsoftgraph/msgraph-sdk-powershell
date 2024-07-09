### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CorporateManagement

$params = @{
	"@odata.type" = "#microsoft.graph.targetedManagedAppPolicyAssignment"
	target = @{
		"@odata.type" = "microsoft.graph.configurationManagerCollectionAssignmentTarget"
		collectionId = "Collection Id value"
	}
}

Update-MgDeviceAppManagementiOSManagedAppProtectionAssignment -IosManagedAppProtectionId $iosManagedAppProtectionId -TargetedManagedAppPolicyAssignmentId $targetedManagedAppPolicyAssignmentId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceAppManagementiOSManagedAppProtectionAssignment Cmdlet.

