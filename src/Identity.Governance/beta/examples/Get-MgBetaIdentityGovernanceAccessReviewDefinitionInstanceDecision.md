### Example 1: Retrieve all decisions for an instance of an access review

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecision -AccessReviewScheduleDefinitionId $accessReviewScheduleDefinitionId -AccessReviewInstanceId $accessReviewInstanceId -Top 100 -Skip 0 

```
This example will retrieve all decisions for an instance of an access review

### Example 2: Retrieve all decisions for an instance of an access review along with insights

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceAccessReviewDefinitionInstanceDecision -AccessReviewScheduleDefinitionId $accessReviewScheduleDefinitionId -AccessReviewInstanceId $accessReviewInstanceId -ExpandProperty "insights" 

```
This example will retrieve all decisions for an instance of an access review along with insights

