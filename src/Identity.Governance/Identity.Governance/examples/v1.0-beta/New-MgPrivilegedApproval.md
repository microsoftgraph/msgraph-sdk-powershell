### Example 1: Using the New-MgBetaPrivilegedApproval Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
$params = @{
	UserId = "userId-value"
	RoleId = "roleId-value"
	ApprovalType = "approvalType-value"
	ApprovalState = "approvalState-value"
	ApprovalDuration = "datetime-value"
}
New-MgBetaPrivilegedApproval -BodyParameter $params
```
This example shows how to use the New-MgBetaPrivilegedApproval Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
