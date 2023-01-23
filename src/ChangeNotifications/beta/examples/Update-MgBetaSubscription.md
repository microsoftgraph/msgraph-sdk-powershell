### Example 1: Using the Update-MgBetaSubscription Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.ChangeNotifications
$params = @{
	ExpirationDateTime = [System.DateTime]::Parse("2016-11-22T18:23:45.9356913Z")
}
Update-MgBetaSubscription -SubscriptionId $subscriptionId -BodyParameter $params
```
This example shows how to use the Update-MgBetaSubscription Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
