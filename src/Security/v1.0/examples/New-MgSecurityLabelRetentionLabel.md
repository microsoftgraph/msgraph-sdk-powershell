### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	"@odata.type" = "#microsoft.graph.security.retentionLabel"
	displayName = "Retention Schedule 10005"
	behaviorDuringRetentionPeriod = "retain"
	actionAfterRetentionPeriod = "startDispositionReview"
	retentionTrigger = "dateOfEvent"
	"retentionEventType@odata.bind" = "https://graph.microsoft.com/v1.0/security/triggerTypes/retentionEventTypes('e095f4fc-b966-4c40-94de-fb8a383658e4')"
	retentionDuration = @{
		"@odata.type" = "microsoft.graph.security.retentionDurationInDays"
		days = 
	}
	dispositionReviewStages = @(
		@{
			stageNumber = 1
			name = "Stage1"
			"reviewersEmailAddresses " = @(
			"Admin@contoso.onmicrosoft.com"
		)
	}
)
descriptionForAdmins = "retain for 7 years"
descriptionForUsers = "retain for 7 years"
descriptors = @{
	"authorityTemplate@odata.bind" = "https://graph.microsoft.com/v1.0/security/labels/authorities('fie3f4fc-b966-4c40-94de-fb8a383658e4')"
	"categoryTemplate@odata.bind" = "https://graph.microsoft.com/v1.0/security/labels/categories('0bjk8-b966-4c40-94de-fb8a383658e4')"
	"citationTemplate@odata.bind" = "https://graph.microsoft.com/v1.0/security/labels/citations('0e23f4fc-b966-4c40-94de-fb8a383658e4')"
	"departmentTemplate@odata.bind" = "https://graph.microsoft.com/v1.0/security/labels/departments('p99ef4fc-b966-4c40-94de-fb8a383658e4')"
	"filePlanReferenceTemplate@odata.bind" = "https://graph.microsoft.com/v1.0/security/labels/filePlanReferences('e095f4fc-b966-4c40-94de-fb8a383658e4')"
}
defaultRecordBehavior = "startLocked"
}

New-MgSecurityLabelRetentionLabel -BodyParameter $params

```
This example shows how to use the New-MgSecurityLabelRetentionLabel Cmdlet.

