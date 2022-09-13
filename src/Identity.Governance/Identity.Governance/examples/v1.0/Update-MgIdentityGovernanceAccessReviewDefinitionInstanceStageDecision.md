###Example 1
```
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	Decision = "Approve"
	Justification = "This person is still on my team"
}
Update-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecision -AccessReviewScheduleDefinitionId $accessReviewScheduleDefinitionId -AccessReviewInstanceId $accessReviewInstanceId -AccessReviewStageId $accessReviewStageId -AccessReviewInstanceDecisionItemId $accessReviewInstanceDecisionItemId -BodyParameter $params
```
###Example 2
```
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	Decision = "Approve"
	Justification = "This person is still on my team"
}
Update-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecision -AccessReviewScheduleDefinitionId $accessReviewScheduleDefinitionId -AccessReviewInstanceId $accessReviewInstanceId -AccessReviewStageId $accessReviewStageId -AccessReviewInstanceDecisionItemId $accessReviewInstanceDecisionItemId -BodyParameter $params
```
###Example 3
```
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	Decision = "Approve"
	Justification = "This person is still on my team"
}
Update-MgIdentityGovernanceAccessReviewDefinitionInstanceStageDecision -AccessReviewScheduleDefinitionId $accessReviewScheduleDefinitionId -AccessReviewInstanceId $accessReviewInstanceId -AccessReviewStageId $accessReviewStageId -AccessReviewInstanceDecisionItemId $accessReviewInstanceDecisionItemId -BodyParameter $params
```
