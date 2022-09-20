### Example 1: Using the Get-MgIdentityGovernanceAppConsentRequestUserConsentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceAppConsentRequestUserConsentRequest -AppConsentRequestId $appConsentRequestId -UserConsentRequestId $userConsentRequestId
```
This example shows how to use the Get-MgIdentityGovernanceAppConsentRequestUserConsentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgIdentityGovernanceAppConsentRequestUserConsentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceAppConsentRequestUserConsentRequest -AppConsentRequestId $appConsentRequestId
```
This example shows how to use the Get-MgIdentityGovernanceAppConsentRequestUserConsentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgIdentityGovernanceAppConsentRequestUserConsentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceAppConsentRequestUserConsentRequest -AppConsentRequestId $appConsentRequestId -UserConsentRequestId $userConsentRequestId -Filter " (status eq 'Completed')" 
```
This example shows how to use the Get-MgIdentityGovernanceAppConsentRequestUserConsentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
