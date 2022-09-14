### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	Decision = "Approve"
	Justification = "All principals with access need continued access to the resource (Marketing Group) as all the principals are on the marketing team"
	ResourceId = "a5c51e59-3fcd-4a37-87a1-835c0c21488a"
}
Invoke-MgBatchIdentityGovernanceAccessReviewDefinitionInstanceRecordDecision -AccessReviewScheduleDefinitionId $accessReviewScheduleDefinitionId -AccessReviewInstanceId $accessReviewInstanceId -BodyParameter $params
```
