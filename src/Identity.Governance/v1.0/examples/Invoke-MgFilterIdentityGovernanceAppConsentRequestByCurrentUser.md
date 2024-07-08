### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Invoke-MgFilterIdentityGovernanceAppConsentRequestByCurrentUser -Filter "userConsentRequests/any(u:u/status eq 'InProgress')"  -On $onId 

```
This example shows how to use the Invoke-MgFilterIdentityGovernanceAppConsentRequestByCurrentUser Cmdlet.

