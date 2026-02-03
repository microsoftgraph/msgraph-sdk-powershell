### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Invoke-MgFilterIdentityGovernanceAppConsentRequestUserConsentRequestByCurrentUser -AppConsentRequestId $appConsentRequestId -Filter " (status eq 'Completed')"  -On $onId 

```
This example shows how to use the Invoke-MgFilterIdentityGovernanceAppConsentRequestUserConsentRequestByCurrentUser Cmdlet.

