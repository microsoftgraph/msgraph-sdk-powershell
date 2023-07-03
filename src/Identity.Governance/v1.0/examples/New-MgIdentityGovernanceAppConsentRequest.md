### Example 1:  List all appConsentRequests

```powershellImport-Module Microsoft.Graph.Identity.Governance

Get-MgIdentityGovernanceAppConsentRequest
```
This example shows how to use the New-MgIdentityGovernanceAppConsentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: List all appConsentRequests with at least one userConsentRequest whose status is InProgress

```powershellImport-Module Microsoft.Graph.Identity.Governance

Get-MgIdentityGovernanceAppConsentRequest -Filter "userConsentRequests/any (u:u/status eq 'InProgress')"
```
This example shows how to use the New-MgIdentityGovernanceAppConsentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

