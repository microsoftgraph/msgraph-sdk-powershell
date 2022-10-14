### Example 1: Using the New-MgAccessReview Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.Governance
$params = @{
	DisplayName = "TestReview"
	StartDateTime = [System.DateTime]::Parse("2017-02-10T00:35:53.214Z")
	EndDateTime = [System.DateTime]::Parse("2017-03-12T00:35:53.214Z")
	ReviewedEntity = @{
		Id = "99025615-a0b1-47ec-9117-35377b10998b"
	}
	ReviewerType = "delegated"
	BusinessFlowTemplateId = "6e4f3d20-c5c3-407f-9695-8460952bcc68"
	Description = "Sample description"
	Reviewers = @(
		@{
			Id = "f260246a-09b1-4fd5-8d18-daed736071ec"
		}
		@{
			Id = "5a4e184c-4ee5-4883-96e9-b371f8da88e3"
		}
	)
	Settings = @{
		MailNotificationsEnabled = $true
		RemindersEnabled = $true
		JustificationRequiredOnApproval = $true
		AutoReviewEnabled = $false
		ActivityDurationInDays = 30
		AutoApplyReviewResultsEnabled = $false
		AccessRecommendationsEnabled = $false
		RecurrenceSettings = @{
			RecurrenceType = "onetime"
			RecurrenceEndType = "endBy"
			DurationInDays = 0
			RecurrenceCount = 0
		}
		AutoReviewSettings = @{
			NotReviewedResult = "Deny"
		}
	}
}
New-MgAccessReview -BodyParameter $params
```
This example shows how to use the New-MgAccessReview Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
