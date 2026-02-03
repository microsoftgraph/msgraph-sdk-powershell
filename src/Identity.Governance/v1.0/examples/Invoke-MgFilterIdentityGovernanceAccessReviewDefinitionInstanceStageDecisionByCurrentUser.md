### Example 1: Retrieve all decisions on an accessReviewStage of a multi-stage access review for which the calling user is the reviewer

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Invoke-MgFilterIdentityGovernanceAccessReviewDefinitionInstanceStageDecisionByCurrentUser -AccessReviewScheduleDefinitionId $accessReviewScheduleDefinitionId -AccessReviewInstanceId $accessReviewInstanceId -AccessReviewStageId $accessReviewStageId -Property "accessReviewId,reviewedDateTime,decision,justification,recommendation,reviewedBy,target"  -On $onId 

```
This example will retrieve all decisions on an accessreviewstage of a multi-stage access review for which the calling user is the reviewer

