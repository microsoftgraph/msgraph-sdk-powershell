### Example 1: Using the New-MgBetaProgramControl Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
$params = @{
	ControlId = "7e59d237-2fb0-4e5d-b7bb-d4f9f9129213"
	ControlTypeId = "6e4f3d20-c5c3-407f-9695-8460952bcc68"
	ProgramId = "7e59d237-2fb0-4e5d-b7bb-d4f9f9129213"
}
New-MgBetaProgramControl -BodyParameter $params
```
This example shows how to use the New-MgBetaProgramControl Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
