### Example 1: Using the Update-MgBetaIdentityGovernanceAccessReviewPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
$params = @{
	IsGroupOwnerManagementEnabled = $true
}
Update-MgBetaIdentityGovernanceAccessReviewPolicy -BodyParameter $params
```
This example shows how to use the Update-MgBetaIdentityGovernanceAccessReviewPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
