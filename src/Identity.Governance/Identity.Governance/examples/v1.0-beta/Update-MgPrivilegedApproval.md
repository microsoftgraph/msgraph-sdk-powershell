### Example 1: Using the Update-MgBetaPrivilegedApproval Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
$params = @{
	ApprovalState = "approvalState-value"
	ApproverReason = "approverReason-value"
}
Update-MgBetaPrivilegedApproval -PrivilegedApprovalId $privilegedApprovalId -BodyParameter $params
```
This example shows how to use the Update-MgBetaPrivilegedApproval Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
