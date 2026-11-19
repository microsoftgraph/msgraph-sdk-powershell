### Example 2: Create a subscription targeting a Web Push endpoint

```powershell

Import-Module Microsoft.Graph.Beta.ChangeNotifications

$params = @{
	changeType = "created"
	notificationUrl = "https://webhook.azurewebsites.net/api/send/myNotifyClient"
	resource = "me/mailFolders('Inbox')/messages"
	expirationDateTime = [System.DateTime]::Parse("2016-11-20T18:23:45.9356913Z")
	clientState = "secretClientValue"
	latestSupportedTlsVersion = "v1_2"
}

New-MgBetaSubscription -BodyParameter $params

```
This example will create a subscription targeting a web push endpoint

