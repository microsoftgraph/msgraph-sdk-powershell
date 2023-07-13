### Example 1: Retrieve a decision on an accessReviewInstance

```powershell
Import-Module Microsoft.Graph.Identity.Governance

Get-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision -AccessReviewScheduleDefinitionId $accessReviewScheduleDefinitionId -AccessReviewInstanceId $accessReviewInstanceId -AccessReviewInstanceDecisionItemId $accessReviewInstanceDecisionItemId
```
This example shows how to use the Get-MgIdentityGovernanceAccessReviewDefinitionInstanceDecision Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

