### Example 1: Create an access review on a group

```powershellImport-Module Microsoft.Graph.Identity.Governance

$params = @{
	displayName = "Test create"
	descriptionForAdmins = "New scheduled access review"
	descriptionForReviewers = "If you have any questions, contact jerry@contoso.com"
	scope = @{
		"@odata.type" = "#microsoft.graph.accessReviewQueryScope"
		query = "/groups/02f3bafb-448c-487c-88c2-5fd65ce49a41/transitiveMembers"
		queryType = "MicrosoftGraph"
	}
	reviewers = @(
		@{
			query = "/users/398164b1-5196-49dd-ada2-364b49f99b27"
			queryType = "MicrosoftGraph"
		}
	)
	settings = @{
		mailNotificationsEnabled = $true
		reminderNotificationsEnabled = $true
		justificationRequiredOnApproval = $true
		defaultDecisionEnabled = $false
		defaultDecision = "None"
		instanceDurationInDays = 1
		recommendationsEnabled = $true
		recurrence = @{
			pattern = @{
				type = "weekly"
				interval = 1
			}
			range = @{
				type = "noEnd"
				startDate = "2020-09-08T12:02:30.667Z"
			}
		}
	}
}

New-MgIdentityGovernanceAccessReviewDefinition -BodyParameter $params
```
This example shows how to use the New-MgIdentityGovernanceAccessReviewDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Create an access review on all teams with inactive guest users

```powershellImport-Module Microsoft.Graph.Identity.Governance

$params = @{
	displayName = "Review inactive guests on teams"
	descriptionForAdmins = "Control guest user access to our teams."
	descriptionForReviewers = "Information security is everyone's responsibility. Review our access policy for more."
	instanceEnumerationScope = @{
		"@odata.type" = "#microsoft.graph.accessReviewQueryScope"
		query = "/groups?$filter=(groupTypes/any(c:c+eq+'Unified') and resourceProvisioningOptions/Any(x:x eq 'Team')')"
		queryType = "MicrosoftGraph"
	}
	scope = @{
		"@odata.type" = "#microsoft.graph.accessReviewInactiveUsersQueryScope"
		query = "./members/microsoft.graph.user/?$filter=(userType eq 'Guest')"
		queryType = "MicrosoftGraph"
		inactiveDuration = "P30D"
	}
	reviewers = @(
		@{
			query = "./owners"
			queryType = "MicrosoftGraph"
		}
	)
	fallbackReviewers = @(
		@{
			query = "/users/fc9a2c2b-1ddc-486d-a211-5fe8ca77fa1f"
			queryType = "MicrosoftGraph"
		}
	)
	settings = @{
		mailNotificationsEnabled = $true
		reminderNotificationsEnabled = $true
		justificationRequiredOnApproval = $true
		recommendationsEnabled = $true
		instanceDurationInDays = 3
		recurrence = @{
			pattern = @{
				type = "absoluteMonthly"
				dayOfMonth = 5
				interval = 3
			}
			range = @{
				type = "noEnd"
				startDate = "2020-05-04T00:00:00.000Z"
			}
		}
		defaultDecisionEnabled = $true
		defaultDecision = "Deny"
		autoApplyDecisionsEnabled = $true
	}
}

New-MgIdentityGovernanceAccessReviewDefinition -BodyParameter $params
```
This example shows how to use the New-MgIdentityGovernanceAccessReviewDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Create an access review of all users to an application

```powershellImport-Module Microsoft.Graph.Identity.Governance

$params = @{
	displayName = "Review employee access to LinkedIn"
	descriptionForAdmins = "Review employee access to LinkedIn"
	scope = @{
		"@odata.type" = "#microsoft.graph.principalResourceMembershipsScope"
		principalScopes = @(
			@{
				"@odata.type" = "#microsoft.graph.accessReviewQueryScope"
				query = "/users"
				queryType = "MicrosoftGraph"
			}
		)
		resourceScopes = @(
			@{
				"@odata.type" = "#microsoft.graph.accessReviewQueryScope"
				query = "/servicePrincipals/bae11f90-7d5d-46ba-9f55-8112b59d92ae"
				queryType = "MicrosoftGraph"
			}
		)
	}
	reviewers = @(
		@{
			query = "./manager"
			queryType = "MicrosoftGraph"
			queryRoot = "decisions"
		}
	)
	backupReviewers = @(
	)
	fallbackReviewers = @(
		@{
			query = "/groups/072ac5f4-3f13-4088-ab30-0a276f3e6322/transitiveMembers"
			queryType = "MicrosoftGraph"
		}
	)
	settings = @{
		mailNotificationsEnabled = $true
		reminderNotificationsEnabled = $true
		justificationRequiredOnApproval = $true
		defaultDecisionEnabled = $true
		defaultDecision = "Recommendation"
		instanceDurationInDays = 180
		autoApplyDecisionsEnabled = $true
		recommendationsEnabled = $true
		recurrence = @{
			pattern = @{
				type = "absoluteMonthly"
				interval = 6
				dayOfMonth = 0
			}
			range = @{
				type = "numbered"
				startDate = "2021-05-05"
				endDate = "2022-05-05"
			}
		}
	}
}

New-MgIdentityGovernanceAccessReviewDefinition -BodyParameter $params
```
This example shows how to use the New-MgIdentityGovernanceAccessReviewDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 4: Create an access review on a group with multiple stages

```powershellImport-Module Microsoft.Graph.Identity.Governance

$params = @{
	displayName = "Group Multi-stage Access Review"
	descriptionForAdmins = "New scheduled access review"
	descriptionForReviewers = "If you have any questions, contact jerry@contoso.com"
	scope = @{
		"@odata.type" = "#microsoft.graph.accessReviewQueryScope"
		query = "/groups/02f3bafb-448c-487c-88c2-5fd65ce49a41/transitiveMembers"
		queryType = "MicrosoftGraph"
	}
	stageSettings = @(
		@{
			stageId = "1"
			durationInDays = 2
			recommendationsEnabled = $false
			decisionsThatWillMoveToNextStage = @(
				"NotReviewed"
				"Approve"
			)
			reviewers = @(
				@{
					query = "/users/398164b1-5196-49dd-ada2-364b49f99b27"
					queryType = "MicrosoftGraph"
				}
			)
		}
		@{
			stageId = "2"
			dependsOn = @(
				"1"
			)
			durationInDays = 2
			recommendationsEnabled = $true
			reviewers = @(
				@{
					query = "./manager"
					queryType = "MicrosoftGraph"
					queryRoot = "decisions"
				}
			)
			fallbackReviewers = @(
				@{
					query = "/groups/072ac5f4-3f13-4088-ab30-0a276f3e6322/transitiveMembers"
					queryType = "MicrosoftGraph"
				}
			)
		}
	)
	settings = @{
		mailNotificationsEnabled = $true
		reminderNotificationsEnabled = $true
		justificationRequiredOnApproval = $true
		defaultDecisionEnabled = $false
		defaultDecision = "None"
		instanceDurationInDays = 4
		recurrence = @{
			pattern = @{
				type = "weekly"
				interval = 1
			}
			range = @{
				type = "noEnd"
				startDate = "2020-09-08T12:02:30.667Z"
			}
		}
		decisionHistoriesForReviewersEnabled = $true
	}
}

New-MgIdentityGovernanceAccessReviewDefinition -BodyParameter $params
```
This example shows how to use the New-MgIdentityGovernanceAccessReviewDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

