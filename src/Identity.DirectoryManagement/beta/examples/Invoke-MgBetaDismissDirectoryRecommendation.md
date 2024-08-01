### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	dismissReason = "Recommendations is not relevant for my organization because..."
}

Invoke-MgBetaDismissDirectoryRecommendation -RecommendationId $recommendationId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaDismissDirectoryRecommendation Cmdlet.

