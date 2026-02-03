### Example 1: Using the Get-MgBetaIdentityGovernanceAccessReviewDecision Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
Get-MgBetaIdentityGovernanceAccessReviewDecision -AccessReviewInstanceDecisionItemId $accessReviewInstanceDecisionItemId -ExpandProperty "instance(`$expand=definition)" 
```
This example shows how to use the Get-MgBetaIdentityGovernanceAccessReviewDecision Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
