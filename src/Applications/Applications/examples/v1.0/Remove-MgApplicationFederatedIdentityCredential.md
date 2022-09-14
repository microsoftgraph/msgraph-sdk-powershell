### Example 1: Using the Remove-MgApplicationFederatedIdentityCredential Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
Remove-MgApplicationFederatedIdentityCredential -ApplicationId $applicationId -FederatedIdentityCredentialId $federatedIdentityCredentialId
```
This example shows how to use the Remove-MgApplicationFederatedIdentityCredential Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
