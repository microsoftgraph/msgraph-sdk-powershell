###Example 1
```
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	DisplayName = "Review employee access to LinkedIn"
	DescriptionForAdmins = "Review employee access to LinkedIn"
	Scope = @{
		"@odata.type" = "#microsoft.graph.principalResourceMembershipsScope"
		PrincipalScopes = @(
			@{
				"@odata.type" = "#microsoft.graph.accessReviewQueryScope"
				Query = "/users"
				QueryType = "MicrosoftGraph"
			}
		)
		ResourceScopes = @(
			@{
				"@odata.type" = "#microsoft.graph.accessReviewQueryScope"
				Query = "/servicePrincipals/bae11f90-7d5d-46ba-9f55-8112b59d92ae"
				QueryType = "MicrosoftGraph"
			}
		)
	}
	Reviewers = @(
		@{
			Query = "./manager"
			QueryType = "MicrosoftGraph"
			QueryRoot = "decisions"
		}
	)
	BackupReviewers = @(
	)
	FallbackReviewers = @(
		@{
			Query = "/groups/072ac5f4-3f13-4088-ab30-0a276f3e6322/transitiveMembers"
			QueryType = "MicrosoftGraph"
		}
	)
	Settings = @{
		MailNotificationsEnabled = $true
		ReminderNotificationsEnabled = $true
		JustificationRequiredOnApproval = $true
		DefaultDecisionEnabled = $true
		DefaultDecision = "Recommendation"
		InstanceDurationInDays = 180
		AutoApplyDecisionsEnabled = $true
		RecommendationsEnabled = $true
		Recurrence = @{
			Pattern = @{
				Type = "absoluteMonthly"
				Interval = 6
				DayOfMonth = 0
			}
			Range = @{
				Type = "numbered"
				StartDate = "2021-05-05"
				EndDate = "2022-05-05"
			}
		}
	}
}
New-MgIdentityGovernanceAccessReviewDefinition -BodyParameter $params
```
###Example 2
```
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	DisplayName = "Group Multi-stage Access Review"
	DescriptionForAdmins = "New scheduled access review"
	DescriptionForReviewers = "If you have any questions, contact jerry@contoso.com"
	Scope = @{
		"@odata.type" = "#microsoft.graph.accessReviewQueryScope"
		Query = "/groups/02f3bafb-448c-487c-88c2-5fd65ce49a41/transitiveMembers"
		QueryType = "MicrosoftGraph"
	}
	StageSettings = @(
		@{
			StageId = "1"
			DurationInDays = 2
			RecommendationsEnabled = $false
			DecisionsThatWillMoveToNextStage = @(
				"NotReviewed"
				"Approve"
			)
			Reviewers = @(
				@{
					Query = "/users/398164b1-5196-49dd-ada2-364b49f99b27"
					QueryType = "MicrosoftGraph"
				}
			)
		}
		@{
			StageId = "2"
			DependsOn = @(
				"1"
			)
			DurationInDays = 2
			RecommendationsEnabled = $true
			Reviewers = @(
				@{
					Query = "./manager"
					QueryType = "MicrosoftGraph"
					QueryRoot = "decisions"
				}
			)
			FallbackReviewers = @(
				@{
					Query = "/groups/072ac5f4-3f13-4088-ab30-0a276f3e6322/transitiveMembers"
					QueryType = "MicrosoftGraph"
				}
			)
		}
	)
	Settings = @{
		MailNotificationsEnabled = $true
		ReminderNotificationsEnabled = $true
		JustificationRequiredOnApproval = $true
		DefaultDecisionEnabled = $false
		DefaultDecision = "None"
		InstanceDurationInDays = 4
		Recurrence = @{
			Pattern = @{
				Type = "weekly"
				Interval = 1
			}
			Range = @{
				Type = "noEnd"
				StartDate = "2020-09-08T12:02:30.667Z"
			}
		}
		DecisionHistoriesForReviewersEnabled = $true
	}
}
New-MgIdentityGovernanceAccessReviewDefinition -BodyParameter $params
```
###Example 3
```
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	DisplayName = "Review inactive guests on teams"
	DescriptionForAdmins = "Control guest user access to our teams."
	DescriptionForReviewers = "Information security is everyone's responsibility. Review our access policy for more."
	InstanceEnumerationScope = @{
		"@odata.type" = "#microsoft.graph.accessReviewQueryScope"
		Query = "/groups?$filter=(groupTypes/any(c:c+eq+'Unified') and resourceProvisioningOptions/Any(x:x eq 'Team')')"
		QueryType = "MicrosoftGraph"
	}
	Scope = @{
		"@odata.type" = "#microsoft.graph.accessReviewInactiveUsersQueryScope"
		Query = "./members/microsoft.graph.user/?$filter=(userType eq 'Guest')"
		QueryType = "MicrosoftGraph"
		InactiveDuration = "P30D"
	}
	Reviewers = @(
		@{
			Query = "./owners"
			QueryType = "MicrosoftGraph"
		}
	)
	FallbackReviewers = @(
		@{
			Query = "/users/fc9a2c2b-1ddc-486d-a211-5fe8ca77fa1f"
			QueryType = "MicrosoftGraph"
		}
	)
	Settings = @{
		MailNotificationsEnabled = $true
		ReminderNotificationsEnabled = $true
		JustificationRequiredOnApproval = $true
		RecommendationsEnabled = $true
		InstanceDurationInDays = 3
		Recurrence = @{
			Pattern = @{
				Type = "absoluteMonthly"
				DayOfMonth = 5
				Interval = 3
			}
			Range = @{
				Type = "noEnd"
				StartDate = "2020-05-04T00:00:00.000Z"
			}
		}
		DefaultDecisionEnabled = $true
		DefaultDecision = "Deny"
		AutoApplyDecisionsEnabled = $true
	}
}
New-MgIdentityGovernanceAccessReviewDefinition -BodyParameter $params
```
###Example 4
```
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	DisplayName = "Test create"
	DescriptionForAdmins = "New scheduled access review"
	DescriptionForReviewers = "If you have any questions, contact jerry@contoso.com"
	Scope = @{
		"@odata.type" = "#microsoft.graph.accessReviewQueryScope"
		Query = "/groups/02f3bafb-448c-487c-88c2-5fd65ce49a41/transitiveMembers"
		QueryType = "MicrosoftGraph"
	}
	Reviewers = @(
		@{
			Query = "/users/398164b1-5196-49dd-ada2-364b49f99b27"
			QueryType = "MicrosoftGraph"
		}
	)
	Settings = @{
		MailNotificationsEnabled = $true
		ReminderNotificationsEnabled = $true
		JustificationRequiredOnApproval = $true
		DefaultDecisionEnabled = $false
		DefaultDecision = "None"
		InstanceDurationInDays = 1
		RecommendationsEnabled = $true
		Recurrence = @{
			Pattern = @{
				Type = "weekly"
				Interval = 1
			}
			Range = @{
				Type = "noEnd"
				StartDate = "2020-09-08T12:02:30.667Z"
			}
		}
	}
}
New-MgIdentityGovernanceAccessReviewDefinition -BodyParameter $params
```
