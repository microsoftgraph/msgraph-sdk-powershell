### Example 1: List all appConsentRequests

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceAppConsentRequest

```
This example will list all appconsentrequests

### Example 2: List all appConsentRequests with at least one userConsentRequest whose status is InProgress

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceAppConsentRequest -Filter "userConsentRequests/any (u:u/status eq 'InProgress')" 

```
This example will list all appconsentrequests with at least one userconsentrequest whose status is inprogress

