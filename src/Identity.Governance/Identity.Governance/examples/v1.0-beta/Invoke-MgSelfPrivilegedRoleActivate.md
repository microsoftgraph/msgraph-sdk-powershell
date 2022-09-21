### Example 1: Using the Invoke-MgSelfPrivilegedRoleActivate Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	Reason = "reason-value"
	Duration = "duration-value"
	TicketNumber = "ticketNumber-value"
	TicketSystem = "ticketSystem-value"
}
Invoke-MgSelfPrivilegedRoleActivate -PrivilegedRoleId $privilegedRoleId -BodyParameter $params
```
This example shows how to use the Invoke-MgSelfPrivilegedRoleActivate Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
