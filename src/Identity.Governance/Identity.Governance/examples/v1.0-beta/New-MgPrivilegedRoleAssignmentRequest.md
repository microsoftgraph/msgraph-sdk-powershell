### Example 1: Using the New-MgPrivilegedRoleAssignmentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	Duration = "2"
	Reason = "Activate the role for business purpose"
	TicketNumber = "234"
	TicketSystem = "system"
	Schedule = @{
		StartDateTime = [System.DateTime]::Parse("2018-02-08T02:35:17.903Z")
	}
	Type = "UserAdd"
	AssignmentState = "Active"
	RoleId = "88d8e3e3-8f55-4a1e-953a-9b9898b8876b"
}
New-MgPrivilegedRoleAssignmentRequest -BodyParameter $params
```
This example shows how to use the New-MgPrivilegedRoleAssignmentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
