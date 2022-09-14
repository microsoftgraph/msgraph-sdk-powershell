### Example 1
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	DisplayName = "Last quarter's group reviews April 2021"
	Decisions = @(
		"approve"
		"deny"
		"dontKnow"
		"notReviewed"
		"notNotified"
	)
	ScheduleSettings = @{
		ReportRange = "P1M"
		Recurrence = @{
			Pattern = @{
				Type = "monthly"
				Interval = 1
			}
			Range = @{
				Type = "noEnd"
				StartDate = "2018-08-03T21:02:30.667Z"
				Count = 
			}
		}
	}
	Scopes = @(
		@{
			"@odata.type" = "#microsoft.graph.accessReviewQueryScope"
			QueryType = "MicrosoftGraph"
			Query = "/identityGovernance/accessReviews/definitions?$filter=contains(scope/query, 'accessPackageAssignments')"
			QueryRoot = $null
		}
		@{
			"@odata.type" = "#microsoft.graph.accessReviewQueryScope"
			QueryType = "MicrosoftGraph"
			Query = "/identityGovernance/accessReviews/definitions?$filter=contains(scope/query, '/groups')"
			QueryRoot = $null
		}
	)
}
New-MgIdentityGovernanceAccessReviewHistoryDefinition -BodyParameter $params
```
