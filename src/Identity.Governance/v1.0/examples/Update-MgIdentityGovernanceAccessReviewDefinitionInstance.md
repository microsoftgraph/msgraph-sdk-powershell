### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Identity.Governance

$params = @{
	scope = @{
		"@odata.type" = "#microsoft.graph.principalResourceMembershipsScope"
		principalScopes = @(
			@{
				"@odata.type" = "#microsoft.graph.accessReviewQueryScope"
				query = "/v1.0/users"
				queryType = "MicrosoftGraph"
			}
			@{
				"@odata.type" = "#microsoft.graph.accessReviewQueryScope"
				query = "/v1.0/groups"
				queryType = "MicrosoftGraph"
			}
		)
		resourceScopes = @(
			@{
				"@odata.type" = "#microsoft.graph.accessReviewQueryScope"
				query = "/beta/roleManagement/directory/roleDefinitions/9b895d92-2cd3-44c7-9d02-a6ac2d5ea5c3"
				queryType = "MicrosoftGraph"
			}
		)
	}
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

Update-MgIdentityGovernanceAccessReviewDefinitionInstance -AccessReviewScheduleDefinitionId $accessReviewScheduleDefinitionId -AccessReviewInstanceId $accessReviewInstanceId -BodyParameter $params
```
This example shows how to use the Update-MgIdentityGovernanceAccessReviewDefinitionInstance Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

