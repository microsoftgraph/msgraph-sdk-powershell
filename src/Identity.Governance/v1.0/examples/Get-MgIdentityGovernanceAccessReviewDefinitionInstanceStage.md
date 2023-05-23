### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Identity.Governance

$params = @{
	"@odata.type" = "#microsoft.graph.accessReviewStage"
	reviewers = @(
		@{
			query = "/users/1ed8ac56-4827-4733-8f80-86adc2e67db5"
			queryType = "MicrosoftGraph"
		}
	)
	fallbackReviewers = @(
		@{
			query = "/users/4562bcc8-c436-4f95-b7c0-4f8ce89dca5e"
			queryType = "MicrosoftGraph"
		}
		@{
			query = "/users/1ed8ac56-4827-4733-8f80-86adc2e67db5"
			queryType = "MicrosoftGraph"
		}
	)
}

Update-MgIdentityGovernanceAccessReviewDefinitionInstanceStage -AccessReviewScheduleDefinitionId $accessReviewScheduleDefinitionId -AccessReviewInstanceId $accessReviewInstanceId -AccessReviewStageId $accessReviewStageId -BodyParameter $params
```
This example shows how to use the Get-MgIdentityGovernanceAccessReviewDefinitionInstanceStage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

