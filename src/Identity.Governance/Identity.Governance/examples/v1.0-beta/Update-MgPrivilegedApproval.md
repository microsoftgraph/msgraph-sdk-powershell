### Example 1: Using the Update-MgPrivilegedApproval Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	ApprovalState = "approvalState-value"
	ApproverReason = "approverReason-value"
}
Update-MgPrivilegedApproval -PrivilegedApprovalId $privilegedApprovalId -BodyParameter $params
```
This example shows how to use the Update-MgPrivilegedApproval Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
