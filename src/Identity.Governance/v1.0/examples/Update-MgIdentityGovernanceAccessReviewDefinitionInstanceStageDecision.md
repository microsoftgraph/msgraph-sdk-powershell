### Example 1: Update a decision on an accessReviewInstance

```powershell
Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	decision = "Approve"
	justification = "This person is still on my team"
}

Update-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecision -AccessReviewScheduleDefinitionId $accessReviewScheduleDefinitionId -AccessReviewInstanceId $accessReviewInstanceId -AccessReviewStageId $accessReviewStageId -AccessReviewInstanceDecisionItemId $accessReviewInstanceDecisionItemId -BodyParameter $params
```
This example shows how to use the Update-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecision Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Update a decision on an stage in a multi-stage access review

```powershell
Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	decision = "Approve"
	justification = "This person is still on my team"
}

Update-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecision -AccessReviewScheduleDefinitionId $accessReviewScheduleDefinitionId -AccessReviewInstanceId $accessReviewInstanceId -AccessReviewStageId $accessReviewStageId -AccessReviewInstanceDecisionItemId $accessReviewInstanceDecisionItemId -BodyParameter $params
```
This example shows how to use the Update-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecision Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

