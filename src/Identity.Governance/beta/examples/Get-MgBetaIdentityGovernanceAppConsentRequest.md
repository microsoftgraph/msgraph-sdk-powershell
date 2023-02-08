### Example 1: Using the Get-MgBetaIdentityGovernanceAppConsentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
Get-MgBetaIdentityGovernanceAppConsentRequest -AppConsentRequestId $appConsentRequestId -Filter "userConsentRequests/any(u:u/status eq 'InProgress')" 
```
This example shows how to use the Get-MgBetaIdentityGovernanceAppConsentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaIdentityGovernanceAppConsentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
Get-MgBetaIdentityGovernanceAppConsentRequest -AppConsentRequestId $appConsentRequestId
```
This example shows how to use the Get-MgBetaIdentityGovernanceAppConsentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgBetaIdentityGovernanceAppConsentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
Get-MgBetaIdentityGovernanceAppConsentRequest
```
This example shows how to use the Get-MgBetaIdentityGovernanceAppConsentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgBetaIdentityGovernanceAppConsentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
Get-MgBetaIdentityGovernanceAppConsentRequest -Filter "userConsentRequests/any (u:u/status eq 'InProgress')" 
```
This example shows how to use the Get-MgBetaIdentityGovernanceAppConsentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
