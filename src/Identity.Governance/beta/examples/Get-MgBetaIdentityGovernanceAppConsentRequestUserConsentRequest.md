### Example 1: Using the Get-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
Get-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequest -AppConsentRequestId $appConsentRequestId -UserConsentRequestId $userConsentRequestId
```
This example shows how to use the Get-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
Get-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequest -AppConsentRequestId $appConsentRequestId
```
This example shows how to use the Get-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
Get-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequest -AppConsentRequestId $appConsentRequestId -UserConsentRequestId $userConsentRequestId -Filter " (status eq 'Completed')" 
```
This example shows how to use the Get-MgBetaIdentityGovernanceAppConsentRequestUserConsentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
