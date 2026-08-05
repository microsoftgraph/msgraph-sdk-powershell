### Example 1: Merge incidents

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	incidentIds = @(
	"2972395"
"2972396"
)
incidentComment = "Merging related incidents from the same campaign"
mergeReasons = "sameCampaign, sameActor"
}

Merge-MgSecurityIncident -BodyParameter $params

```
This example will merge incidents

