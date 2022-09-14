### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceAppConsentRequestUserConsentRequest -AppConsentRequestId $appConsentRequestId -UserConsentRequestId $userConsentRequestId
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceAppConsentRequestUserConsentRequest -AppConsentRequestId $appConsentRequestId
```
### Example 3
``` powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceAppConsentRequestUserConsentRequest -AppConsentRequestId $appConsentRequestId -UserConsentRequestId $userConsentRequestId -Filter " (status eq 'Completed')" 
```
