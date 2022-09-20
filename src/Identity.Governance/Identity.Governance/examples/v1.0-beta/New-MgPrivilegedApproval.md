### Example 1: Using the New-MgPrivilegedApproval Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	UserId = "userId-value"
	RoleId = "roleId-value"
	ApprovalType = "approvalType-value"
	ApprovalState = "approvalState-value"
	ApprovalDuration = "datetime-value"
}
New-MgPrivilegedApproval -BodyParameter $params
```
This example shows how to use the New-MgPrivilegedApproval Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
