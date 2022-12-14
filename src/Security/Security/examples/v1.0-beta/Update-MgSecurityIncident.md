### Example 1: Using the Update-MgBetaSecurityIncident Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	Classification = "TruePositive"
	Determination = "MultiStagedAttack"
	Tags = @(
		"Demo"
	)
}
Update-MgBetaSecurityIncident -IncidentId $incidentId -BodyParameter $params
```
This example shows how to use the Update-MgBetaSecurityIncident Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
