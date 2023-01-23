### Example 1: Using the Invoke-MgBetaSelfPrivilegedRoleActivate Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
$params = @{
	Reason = "reason-value"
	Duration = "duration-value"
	TicketNumber = "ticketNumber-value"
	TicketSystem = "ticketSystem-value"
}
Invoke-MgBetaSelfPrivilegedRoleActivate -PrivilegedRoleId $privilegedRoleId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaSelfPrivilegedRoleActivate Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
