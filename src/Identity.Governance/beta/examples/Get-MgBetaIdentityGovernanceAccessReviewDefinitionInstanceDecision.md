### Example 1: Retrieve a decision on an accessReviewInstance

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecision -AccessReviewScheduleDefinitionId $accessReviewScheduleDefinitionId -AccessReviewInstanceId $accessReviewInstanceId -AccessReviewInstanceDecisionItemId $accessReviewInstanceDecisionItemId

```
This example will retrieve a decision on an accessreviewinstance

