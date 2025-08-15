### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	isNotificationEnabled = $true
}

Update-MgBetaDirectoryRecommendationConfiguration -BodyParameter $params

```
This example shows how to use the Update-MgBetaDirectoryRecommendationConfiguration Cmdlet.

