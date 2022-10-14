### Example 1: Using the Update-MgSecurityIncident Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	Classification = "TruePositive"
	Determination = "MultiStagedAttack"
	Tags = @(
		"Demo"
	)
}
Update-MgSecurityIncident -IncidentId $incidentId -BodyParameter $params
```
This example shows how to use the Update-MgSecurityIncident Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
