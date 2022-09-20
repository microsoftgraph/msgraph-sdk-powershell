### Example 1: Using the Update-MgIdentityGovernanceAccessReviewDefinitionInstanceStage Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	"@odata.type" = "#microsoft.graph.accessReviewStage"
	Reviewers = @(
		@{
			Query = "/users/1ed8ac56-4827-4733-8f80-86adc2e67db5"
			QueryType = "MicrosoftGraph"
		}
	)
	FallbackReviewers = @(
		@{
			Query = "/users/4562bcc8-c436-4f95-b7c0-4f8ce89dca5e"
			QueryType = "MicrosoftGraph"
		}
		@{
			Query = "/users/1ed8ac56-4827-4733-8f80-86adc2e67db5"
			QueryType = "MicrosoftGraph"
		}
	)
}
Update-MgIdentityGovernanceAccessReviewDefinitionInstanceStage -AccessReviewScheduleDefinitionId $accessReviewScheduleDefinitionId -AccessReviewInstanceId $accessReviewInstanceId -AccessReviewStageId $accessReviewStageId -BodyParameter $params
```
This example shows how to use the Update-MgIdentityGovernanceAccessReviewDefinitionInstanceStage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
