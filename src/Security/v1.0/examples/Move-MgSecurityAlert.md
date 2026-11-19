### Example 1: Move alerts to an incident

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	alertIds = @(
	"da637551227677560813_-961444813"
"da637551227677560813_-961444814"
)
incidentId = "2972395"
alertComment = "Moving alerts for investigation consolidation"
newCorrelationReasons = "sameAsset, temporalProximity"
}

Move-MgSecurityAlert -BodyParameter $params

```
This example will move alerts to an incident

