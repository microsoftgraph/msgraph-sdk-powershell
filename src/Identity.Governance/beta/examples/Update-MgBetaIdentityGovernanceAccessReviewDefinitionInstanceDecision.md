### Example 1: Update a applyResult on an accessReviewInstance

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	applyResult = "AppliedSuccessfully"
	applyDescription = "Completed by John Doe"
}

Update-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecision -AccessReviewScheduleDefinitionId $accessReviewScheduleDefinitionId -AccessReviewInstanceId $accessReviewInstanceId -AccessReviewInstanceDecisionItemId $accessReviewInstanceDecisionItemId -BodyParameter $params

```
This example will update a applyresult on an accessreviewinstance

