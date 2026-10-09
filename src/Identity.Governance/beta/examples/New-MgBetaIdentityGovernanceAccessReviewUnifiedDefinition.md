### Example 1: Create a user-centric (catalog) access review definition

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

$params = @{
	displayName = "Catalog access review"
	descriptionForAdmins = "Quarterly user-centric review of catalog resources"
	scope = @{
		"@odata.type" = "#microsoft.graph.principalResourceMembershipsScope"
		principalScopes = @(
			@{
				"@odata.type" = "#microsoft.graph.accessReviewPrincipalScope"
				scopeType = "allUsers"
			}
		)
		resourceScopes = @(
			@{
				"@odata.type" = "#microsoft.graph.accessReviewResourceScope"
				resourceId = "c6010d0c-ff41-4929-9776-fa03a03dd5ac"
				scopeType = "catalog"
			}
		)
	}
	reviewers = @(
		@{
			"@odata.type" = "#microsoft.graph.accessReviewReviewerScope"
			scopeType = "manager"
		}
	)
	settings = @{
		mailNotificationsEnabled = $true
		reminderNotificationsEnabled = $true
		justificationRequiredOnApproval = $true
		instanceDurationInDays = 6
		recommendationsEnabled = $true
		recurrence = @{
			pattern = @{
				type = "absoluteMonthly"
				interval = 1
			}
			range = @{
				type = "noEnd"
				startDate = "2026-08-31"
			}
		}
	}
}

New-MgBetaIdentityGovernanceAccessReviewUnifiedDefinition -BodyParameter $params

```
This example will create a user-centric (catalog) access review definition

