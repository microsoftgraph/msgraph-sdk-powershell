### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	classification = "TruePositive"
	determination = "MultiStagedAttack"
	customTags = @(
	"Demo"
)
}

Update-MgSecurityIncident -IncidentId $incidentId -BodyParameter $params

```
This example shows how to use the Update-MgSecurityIncident Cmdlet.

