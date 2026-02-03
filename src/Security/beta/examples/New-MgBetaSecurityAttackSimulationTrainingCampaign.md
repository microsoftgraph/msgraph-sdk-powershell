### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	displayName = "Graph Training Campaign"
	description = "Graph Training Campaign Description"
	createdBy = @{
		email = "john@contoso.com"
	}
	lastModifiedBy = @{
		email = "john@contoso.com"
	}
	includedAccountTarget = @{
		type = "addressBook"
		accountTargetEmails = @(
		"john@contoso.com"
	)
}
endUserNotificationSetting = @{
	notificationPreference = "microsoft"
	settingType = "trainingSelected"
	trainingReminder = @{
		deliveryFrequency = "weekly"
		"endUserNotification@odata.bind" = "https://graph.microsoft.com/beta/security/attackSimulation/endUserNotifications('fe521249-9901-4584-a987-026a9980c58e')"
		defaultLanguage = "en"
	}
	trainingAssignment = @{
		"endUserNotification@odata.bind" = "https://graph.microsoft.com/beta/security/attackSimulation/endUserNotifications('36fb4dc1-7c37-4b96-9096-12e6d6014fae')"
		defaultLanguage = "en"
	}
}
trainingSetting = @{
	settingType = "microsoftCustom"
	trainingAssignmentMappings = @(
		@{
			assignedTo = @(
			"allUsers"
		)
		"training@odata.bind" = "https://graph.microsoft.com/beta/security/attackSimulation/trainings('40454905-dc26-4f36-b854-3042a5362cb3')"
	}
	@{
		assignedTo = @(
		"allUsers"
	)
	"training@odata.bind" = "https://graph.microsoft.com/beta/security/attackSimulation/trainings('ea70ae06-3859-4818-be9d-270ee81d80a4')"
}
@{
	assignedTo = @(
	"allUsers"
)
"training@odata.bind" = "https://graph.microsoft.com/beta/security/attackSimulation/trainings('d733d88c-1b5a-48e3-a588-9910e41ac21d')"
}
)
}
campaignSchedule = @{
launchDateTime = [System.DateTime]::Parse("2024-02-15T07:59:44Z")
completionDateTime = [System.DateTime]::Parse("2024-02-18T07:59:44Z")
status = "Scheduled"
}
}

New-MgBetaSecurityAttackSimulationTrainingCampaign -BodyParameter $params

```
This example shows how to use the New-MgBetaSecurityAttackSimulationTrainingCampaign Cmdlet.

