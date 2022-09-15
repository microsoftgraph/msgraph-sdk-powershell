### Example 1: Using the Update-MgIdentityGovernanceAccessReviewPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	IsGroupOwnerManagementEnabled = $true
}
Update-MgIdentityGovernanceAccessReviewPolicy -BodyParameter $params
```
This example shows how to use the Update-MgIdentityGovernanceAccessReviewPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
