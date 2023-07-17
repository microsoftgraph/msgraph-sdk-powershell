### Example 1: Retrieve a decision from a stage of a multi-stage access review

```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStageDecision -AccessReviewScheduleDefinitionId $accessReviewScheduleDefinitionId -AccessReviewInstanceId $accessReviewInstanceId -AccessReviewStageId $accessReviewStageId -AccessReviewInstanceDecisionItemId $accessReviewInstanceDecisionItemId
```
This example shows how to use the Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceStageDecision Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

