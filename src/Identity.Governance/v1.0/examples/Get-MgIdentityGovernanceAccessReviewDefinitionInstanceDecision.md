### Example 1: Retrieve a decision on an accessReviewInstance

```powershellImport-Module Microsoft.Graph.Identity.Governance

Get-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision -AccessReviewScheduleDefinitionId $accessReviewScheduleDefinitionId -AccessReviewInstanceId $accessReviewInstanceId -AccessReviewInstanceDecisionItemId $accessReviewInstanceDecisionItemId
```
This example shows how to use the Get-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Retrieve a decision from a stage of a multi-stage access review

```powershellImport-Module Microsoft.Graph.Identity.Governance

Get-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecision -AccessReviewScheduleDefinitionId $accessReviewScheduleDefinitionId -AccessReviewInstanceId $accessReviewInstanceId -AccessReviewStageId $accessReviewStageId -AccessReviewInstanceDecisionItemId $accessReviewInstanceDecisionItemId
```
This example shows how to use the Get-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

