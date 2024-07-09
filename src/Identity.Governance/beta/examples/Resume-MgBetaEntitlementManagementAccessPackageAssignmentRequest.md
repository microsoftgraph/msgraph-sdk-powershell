### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	source = "Contoso.SodCheckProcess"
	type = "microsoft.graph.accessPackageCustomExtensionStage.assignmentRequestCreated"
	data = @{
		"@odata.type" = "microsoft.graph.accessPackageAssignmentRequestCallbackData"
		stage = "assignmentRequestCreated"
		customExtensionStageInstanceId = "957d0c50-466b-4840-bb5b-c92cea7141ff"
		customExtensionStageInstanceDetail = "This user is all verified"
	}
}

Resume-MgBetaEntitlementManagementAccessPackageAssignmentRequest -AccessPackageAssignmentRequestId $accessPackageAssignmentRequestId -BodyParameter $params

```
This example shows how to use the Resume-MgBetaEntitlementManagementAccessPackageAssignmentRequest Cmdlet.

