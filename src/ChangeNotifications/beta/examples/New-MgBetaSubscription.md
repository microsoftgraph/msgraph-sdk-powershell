### Example 1: Using the New-MgBetaSubscription Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.ChangeNotifications
$params = @{
	ChangeType = "created"
	NotificationUrl = "https://webhook.azurewebsites.net/api/send/myNotifyClient"
	Resource = "me/mailFolders('Inbox')/messages"
	ExpirationDateTime = [System.DateTime]::Parse("2016-11-20T18:23:45.9356913Z")
	ClientState = "secretClientValue"
	LatestSupportedTlsVersion = "v1_2"
}
New-MgBetaSubscription -BodyParameter $params
```
This example shows how to use the New-MgBetaSubscription Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
