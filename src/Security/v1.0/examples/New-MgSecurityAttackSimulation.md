### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	displayName = "Graph Simulation"
	"payload@odata.bind" = "https://graph.microsoft.com/v1.0/security/attacksimulation/payloads/12345678-9abc-def0-123456789a"
	"loginPage@odata.bind" = "https://graph.microsoft.com/v1.0/security/attacksimulation/loginPages/1w345678-9abc-def0-123456789a"
	"landingPage@odata.bind" = "https://graph.microsoft.com/v1.0/security/attacksimulation/landingPages/1c345678-9abc-def0-123456789a"
	createdBy = @{
		email = "john@contoso.com"
	}
	durationInDays = "3"
	attackTechnique = "credentialHarvesting"
	status = "scheduled"
	includedAccountTarget = @{
		"@odata.type" = "#microsoft.graph.addressBookAccountTargetContent"
		type = "addressBook"
		accountTargetEmails = @(
			"john@contoso.com"
		)
	}
	trainingSetting = @{
		settingType = "noTraining"
	}
	endUserNotificationSetting = @{
		notificationPreference = "microsoft"
		settingType = "noTraining"
		positiveReinforcement = @{
			deliveryPreference = "deliverAfterCampaignEnd"
			endUserNotification = "https://graph.microsoft.com/v1.0/security/attacksimulation/endUserNotifications/1ewer3678-9abc-def0-123456789a"
			defaultLanguage = "en"
		}
	}
}

New-MgSecurityAttackSimulation -BodyParameter $params

```
This example shows how to use the New-MgSecurityAttackSimulation Cmdlet.

