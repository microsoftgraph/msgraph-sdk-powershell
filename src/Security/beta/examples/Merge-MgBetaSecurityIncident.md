### Example 1: Merge incidents

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	incidentIds = @(
	"2972395"
"2972396"
)
incidentComment = "Merging related incidents from the same campaign"
mergeReasons = "sameCampaign, sameActor"
}

Merge-MgBetaSecurityIncident -BodyParameter $params

```
This example will merge incidents

