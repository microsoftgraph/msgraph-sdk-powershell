### Example 1: Retrieve a decision on an accessReviewInstance

```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecision -AccessReviewScheduleDefinitionId $accessReviewScheduleDefinitionId -AccessReviewInstanceId $accessReviewInstanceId -AccessReviewInstanceDecisionItemId $accessReviewInstanceDecisionItemId
```
This example shows how to use the Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecision Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

