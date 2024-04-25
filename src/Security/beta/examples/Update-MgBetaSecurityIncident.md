### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	classification = "TruePositive"
	determination = "MultiStagedAttack"
	customTags = @(
	"Demo"
)
}

Update-MgBetaSecurityIncident -IncidentId $incidentId -BodyParameter $params

```
This example shows how to use the Update-MgBetaSecurityIncident Cmdlet.

