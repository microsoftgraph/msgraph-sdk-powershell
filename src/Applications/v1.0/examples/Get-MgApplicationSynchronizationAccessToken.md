### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Applications

$params = @{
	credentials = @(
		@{
			"@odata.type" = "microsoft.graph.synchronizationSecretKeyStringValuePair"
		}
	)
}

Get-MgApplicationSynchronizationAccessToken -ApplicationId $applicationId -BodyParameter $params

```
This example shows how to use the Get-MgApplicationSynchronizationAccessToken Cmdlet.

