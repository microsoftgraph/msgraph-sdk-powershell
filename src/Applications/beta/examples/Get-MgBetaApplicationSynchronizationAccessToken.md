### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Applications

$params = @{
	credentials = @(
		@{
			"@odata.type" = "microsoft.graph.synchronizationSecretKeyStringValuePair"
		}
	)
}

Get-MgBetaApplicationSynchronizationAccessToken -ApplicationId $applicationId -BodyParameter $params

```
This example shows how to use the Get-MgBetaApplicationSynchronizationAccessToken Cmdlet.

