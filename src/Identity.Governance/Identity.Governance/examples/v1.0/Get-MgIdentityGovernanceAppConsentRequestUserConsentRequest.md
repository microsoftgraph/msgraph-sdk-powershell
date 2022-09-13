###Example 1
```
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceAppConsentRequestUserConsentRequest -AppConsentRequestId $appConsentRequestId -UserConsentRequestId $userConsentRequestId
```
###Example 2
```
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceAppConsentRequestUserConsentRequest -AppConsentRequestId $appConsentRequestId
```
###Example 3
```
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceAppConsentRequestUserConsentRequest -AppConsentRequestId $appConsentRequestId -UserConsentRequestId $userConsentRequestId -Filter " (status eq 'Completed')" 
```
