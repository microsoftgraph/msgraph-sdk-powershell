### Example 1: Using the New-MgPrivilegedRoleAssignmentPermanent Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	Reason = "reason-value"
	TicketNumber = "ticketNumber-value"
	TicketSystem = "ticketSystem-value"
}
New-MgPrivilegedRoleAssignmentPermanent -PrivilegedRoleAssignmentId $privilegedRoleAssignmentId -BodyParameter $params
```
This example shows how to use the New-MgPrivilegedRoleAssignmentPermanent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
