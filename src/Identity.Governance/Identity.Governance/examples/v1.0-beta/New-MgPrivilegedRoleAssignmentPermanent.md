### Example 1: Using the New-MgBetaPrivilegedRoleAssignmentPermanent Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
$params = @{
	Reason = "reason-value"
	TicketNumber = "ticketNumber-value"
	TicketSystem = "ticketSystem-value"
}
New-MgBetaPrivilegedRoleAssignmentPermanent -PrivilegedRoleAssignmentId $privilegedRoleAssignmentId -BodyParameter $params
```
This example shows how to use the New-MgBetaPrivilegedRoleAssignmentPermanent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
