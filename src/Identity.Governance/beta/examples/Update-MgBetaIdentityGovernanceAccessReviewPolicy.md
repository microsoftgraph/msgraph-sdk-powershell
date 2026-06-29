### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	isGroupOwnerManagementEnabled = $true
}

Update-MgBetaIdentityGovernanceAccessReviewPolicy -BodyParameter $params

```
This example shows how to use the Update-MgBetaIdentityGovernanceAccessReviewPolicy Cmdlet.

