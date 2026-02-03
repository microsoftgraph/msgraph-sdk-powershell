### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Invoke-MgBetaFilterIdentityGovernanceAppConsentRequestByCurrentUser -Filter "userConsentRequests/any(u:u/status eq 'InProgress')"  -On $onId 

```
This example shows how to use the Invoke-MgBetaFilterIdentityGovernanceAppConsentRequestByCurrentUser Cmdlet.

