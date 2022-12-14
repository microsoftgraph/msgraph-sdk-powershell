### Example 1: Using the Get-MgBetaApplicationSynchronizationAccessToken Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
$params = @{
	Credentials = @(
		@{
			"@odata.type" = "microsoft.graph.synchronizationSecretKeyStringValuePair"
		}
	)
}
Get-MgBetaApplicationSynchronizationAccessToken -ApplicationId $applicationId -BodyParameter $params
```
This example shows how to use the Get-MgBetaApplicationSynchronizationAccessToken Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
