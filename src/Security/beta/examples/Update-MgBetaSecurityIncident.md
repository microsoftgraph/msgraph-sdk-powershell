### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Security

$params = @{
	classification = "TruePositive"
	determination = "MultiStagedAttack"
	customTags = @(
		"Demo"
	)
}

Update-MgBetaSecurityIncident -IncidentId $incidentId -BodyParameter $params
```
This example shows how to use the Update-MgBetaBetaSecurityIncident Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

