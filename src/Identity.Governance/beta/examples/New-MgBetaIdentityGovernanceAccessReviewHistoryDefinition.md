### Example 1: Using the New-MgBetaIdentityGovernanceAccessReviewHistoryDefinition Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
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
New-MgBetaIdentityGovernanceAccessReviewHistoryDefinition -BodyParameter $params
```
This example shows how to use the New-MgBetaIdentityGovernanceAccessReviewHistoryDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
