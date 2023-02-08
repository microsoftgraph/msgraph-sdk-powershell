### Example 1: Using the Update-MgIdentityGovernanceAccessReviewDefinitionInstance Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	Scope = @{
		"@odata.type" = "#microsoft.graph.principalResourceMembershipsScope"
		PrincipalScopes = @(
			@{
				"@odata.type" = "#microsoft.graph.accessReviewQueryScope"
				Query = "/v1.0/users"
				QueryType = "MicrosoftGraph"
			}
			@{
				"@odata.type" = "#microsoft.graph.accessReviewQueryScope"
				Query = "/v1.0/groups"
				QueryType = "MicrosoftGraph"
			}
		)
		ResourceScopes = @(
			@{
				"@odata.type" = "#microsoft.graph.accessReviewQueryScope"
				Query = "/beta/roleManagement/directory/roleDefinitions/9b895d92-2cd3-44c7-9d02-a6ac2d5ea5c3"
				QueryType = "MicrosoftGraph"
			}
		)
	}
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
Update-MgIdentityGovernanceAccessReviewDefinitionInstance -AccessReviewScheduleDefinitionId $accessReviewScheduleDefinitionId -AccessReviewInstanceId $accessReviewInstanceId -BodyParameter $params
```
This example shows how to use the Update-MgIdentityGovernanceAccessReviewDefinitionInstance Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
