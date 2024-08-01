### Example 1:  List all appConsentRequests

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgIdentityGovernanceAppConsentRequest

```
This example will  list all appconsentrequests

### Example 2: List all appConsentRequests with at least one userConsentRequest whose status is InProgress

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgIdentityGovernanceAppConsentRequest -Filter "userConsentRequests/any (u:u/status eq 'InProgress')" 

```
This example will list all appconsentrequests with at least one userconsentrequest whose status is inprogress

