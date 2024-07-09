### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	reviewResult = "Approve"
	justification = "OK"
}

Update-MgEntitlementManagementAccessPackageAssignmentApprovalStage -ApprovalId $approvalId -ApprovalStageId $approvalStageId -BodyParameter $params

```
This example shows how to use the Update-MgEntitlementManagementAccessPackageAssignmentApprovalStage Cmdlet.

