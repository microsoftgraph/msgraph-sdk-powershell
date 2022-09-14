### Example 1: Using the Update-MgSubscription Cmdlet
```powershell
Import-Module Microsoft.Graph.ChangeNotifications
$params = @{
	ExpirationDateTime = [System.DateTime]::Parse("2016-11-22T18:23:45.9356913Z")
}
Update-MgSubscription -SubscriptionId $subscriptionId -BodyParameter $params
```
This example shows how to use the Update-MgSubscription Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
