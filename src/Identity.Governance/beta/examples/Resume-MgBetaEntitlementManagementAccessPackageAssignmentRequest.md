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

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	source = "Contoso.AADProcess"
	type = "microsoft.graph.accessPackageCustomExtensionStage.assignmentRequestCreated"
	data = @{
		"@odata.type" = "microsoft.graph.accessPackageRequestApprovalStageCallbackConfiguration"
		stage = "assignmentRequestCreated"
		customExtensionStageInstanceId = "7bf58d34-b3f9-4bae-8deb-abcd25cddea1"
		customExtensionStageInstanceDetail = "Completed."
	}
}

Resume-MgBetaEntitlementManagementAccessPackageAssignmentRequest -AccessPackageAssignmentRequestId $accessPackageAssignmentRequestId -BodyParameter $params

```
This example shows how to use the Resume-MgBetaEntitlementManagementAccessPackageAssignmentRequest Cmdlet.

### Example 3: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	source = "Contoso.CustoEXT"
	type = "microsoft.graph.accessPackageCustomExtensionStage.assignmentRequestCreated"
	data = @{
		"@odata.type" = "microsoft.graph.microsoft.graph.assignmentRequestApprovalStageCallbackData"
		approvalStage = @{
			durationBeforeAutomaticDenial = "P2D"
			escalationApprovers = @(
			)
			fallbackEscalationApprovers = @(
			)
			fallbackPrimaryApprovers = @(
			)
			isApproverJustificationRequired = $false
			isEscalationEnabled = $false
			primaryApprovers = @(
				@{
					"@@odata.type" = "#microsoft.graph.singleUser"
					description = "Primary approver of access package assignment."
					id = ""
					isBackup = $false
				}
			)
		}
		customExtensionStageInstanceDetail = "A approval stage from Logic Apps"
		customExtensionStageInstanceId = "@{triggerBody()?['CustomExtensionStageInstanceId']}"
		stage = "assignmentRequestDeterminingApprovalRequirements"
	}
	source = "LogicApps"
	type = "microsoft.graph.accessPackageCustomExtensionStage.assignmentRequestCreated"
}

Resume-MgBetaEntitlementManagementAccessPackageAssignmentRequest -AccessPackageAssignmentRequestId $accessPackageAssignmentRequestId -BodyParameter $params

```
This example shows how to use the Resume-MgBetaEntitlementManagementAccessPackageAssignmentRequest Cmdlet.

