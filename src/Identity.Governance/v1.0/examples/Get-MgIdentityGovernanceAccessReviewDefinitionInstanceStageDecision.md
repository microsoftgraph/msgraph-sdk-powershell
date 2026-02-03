### Example 1: Retrieve a decision from a stage of a multi-stage access review

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecision -AccessReviewScheduleDefinitionId $accessReviewScheduleDefinitionId -AccessReviewInstanceId $accessReviewInstanceId -AccessReviewStageId $accessReviewStageId -AccessReviewInstanceDecisionItemId $accessReviewInstanceDecisionItemId -Property "accessReviewId,reviewedDateTime,decision,justification,recommendation,reviewedBy,target" 

```
This example will retrieve a decision from a stage of a multi-stage access review

