### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Invoke-MgBetaFilterIdentityGovernanceAppConsentRequestUserConsentRequestByCurrentUser -AppConsentRequestId $appConsentRequestId -Filter " (status eq 'Completed')"  -On $onId 

```
This example shows how to use the Invoke-MgBetaFilterIdentityGovernanceAppConsentRequestUserConsentRequestByCurrentUser Cmdlet.

