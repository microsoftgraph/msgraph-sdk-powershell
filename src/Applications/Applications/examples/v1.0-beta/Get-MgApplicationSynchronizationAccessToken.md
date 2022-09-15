### Example 1: Using the Get-MgApplicationSynchronizationAccessToken Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
$params = @{
	Credentials = @(
		@{
			"@odata.type" = "microsoft.graph.synchronizationSecretKeyStringValuePair"
		}
	)
}
Get-MgApplicationSynchronizationAccessToken -ApplicationId $applicationId -BodyParameter $params
```
This example shows how to use the Get-MgApplicationSynchronizationAccessToken Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
