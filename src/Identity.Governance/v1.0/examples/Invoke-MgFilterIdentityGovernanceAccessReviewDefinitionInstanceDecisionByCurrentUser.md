### Example 1: Retrieve all decisions on an accessReviewInstance for which the calling user is the reviewer

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Invoke-MgFilterIdentityGovernanceAccessReviewDefinitionInstanceDecisionByCurrentUser -AccessReviewScheduleDefinitionId $accessReviewScheduleDefinitionId -AccessReviewInstanceId $accessReviewInstanceId -On $onId 

```
This example will retrieve all decisions on an accessreviewinstance for which the calling user is the reviewer

