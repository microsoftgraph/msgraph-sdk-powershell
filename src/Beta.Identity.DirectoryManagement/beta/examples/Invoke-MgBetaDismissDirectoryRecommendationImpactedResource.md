### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	dismissReason = "Application is no longer needed."
}

Invoke-MgBetaDismissDirectoryRecommendationImpactedResource -RecommendationId $recommendationId -ImpactedResourceId $impactedResourceId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaDismissDirectoryRecommendationImpactedResource Cmdlet.

