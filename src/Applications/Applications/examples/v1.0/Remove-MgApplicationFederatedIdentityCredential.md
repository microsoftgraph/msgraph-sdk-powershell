### Example 1
```powershell
Import-Module Microsoft.Graph.Applications
Remove-MgApplicationFederatedIdentityCredential -ApplicationId $applicationId -FederatedIdentityCredentialId $federatedIdentityCredentialId
```
