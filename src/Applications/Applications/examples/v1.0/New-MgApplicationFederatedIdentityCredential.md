### Example 1: Using the New-MgApplicationFederatedIdentityCredential Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
$params = @{
	Name = "testing02"
	Issuer = "https://login.microsoftonline.com/3d1e2be9-a10a-4a0c-8380-7ce190f98ed9/v2.0"
	Subject = "a7d388c3-5e3f-4959-ac7d-786b3383006a"
	Audiences = @(
		"api://AzureADTokenExchange"
	)
}
New-MgApplicationFederatedIdentityCredential -ApplicationId $applicationId -BodyParameter $params
```
This example shows how to use the New-MgApplicationFederatedIdentityCredential Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
