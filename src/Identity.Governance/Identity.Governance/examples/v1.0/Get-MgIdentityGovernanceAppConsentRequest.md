###Example 1
```
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceAppConsentRequest -AppConsentRequestId $appConsentRequestId -Filter "userConsentRequests/any(u:u/status eq 'InProgress')" 
```
###Example 2
```
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceAppConsentRequest -AppConsentRequestId $appConsentRequestId
```
###Example 3
```
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceAppConsentRequest
```
###Example 4
```
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceAppConsentRequest -Filter "userConsentRequests/any (u:u/status eq 'InProgress')" 
```
