### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	id = "request-id"
	requestStatus = "cancelled"
}

Stop-MgBetaEntitlementManagementAccessPackageAssignmentRequest -AccessPackageAssignmentRequestId $accessPackageAssignmentRequestId -BodyParameter $params

```
This example shows how to use the Stop-MgBetaEntitlementManagementAccessPackageAssignmentRequest Cmdlet.

