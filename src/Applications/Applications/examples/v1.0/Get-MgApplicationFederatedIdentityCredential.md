### Example 1
``` powershell
Import-Module Microsoft.Graph.Applications
Get-MgApplicationFederatedIdentityCredential -ApplicationId $applicationId -FederatedIdentityCredentialId $federatedIdentityCredentialId
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Applications
Get-MgApplicationFederatedIdentityCredential -ApplicationId $applicationId
```
