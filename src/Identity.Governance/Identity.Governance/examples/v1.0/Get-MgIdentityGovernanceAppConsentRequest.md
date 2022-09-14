### Example 1: Using the Get-MgIdentityGovernanceAppConsentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceAppConsentRequest -AppConsentRequestId $appConsentRequestId -Filter "userConsentRequests/any(u:u/status eq 'InProgress')" 
```
This example shows how to use the Get-MgIdentityGovernanceAppConsentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgIdentityGovernanceAppConsentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceAppConsentRequest -AppConsentRequestId $appConsentRequestId
```
This example shows how to use the Get-MgIdentityGovernanceAppConsentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgIdentityGovernanceAppConsentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceAppConsentRequest
```
This example shows how to use the Get-MgIdentityGovernanceAppConsentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgIdentityGovernanceAppConsentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceAppConsentRequest -Filter "userConsentRequests/any (u:u/status eq 'InProgress')" 
```
This example shows how to use the Get-MgIdentityGovernanceAppConsentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
