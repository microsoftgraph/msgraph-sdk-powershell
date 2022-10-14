### Example 1: Using the Get-MgIdentityGovernanceAccessReviewDecision Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
Get-MgIdentityGovernanceAccessReviewDecision -AccessReviewInstanceDecisionItemId $accessReviewInstanceDecisionItemId -ExpandProperty "instance(`$expand=definition)" 
```
This example shows how to use the Get-MgIdentityGovernanceAccessReviewDecision Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
