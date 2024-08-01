### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Administration

$params = @{
	"@odata.type" = "#microsoft.graph.termsAndConditionsAssignment"
	target = @{
		"@odata.type" = "microsoft.graph.configurationManagerCollectionAssignmentTarget"
		collectionId = "Collection Id value"
	}
}

New-MgDeviceManagementTermAndConditionAssignment -TermsAndConditionsId $termsAndConditionsId -BodyParameter $params

```
This example shows how to use the New-MgDeviceManagementTermAndConditionAssignment Cmdlet.

