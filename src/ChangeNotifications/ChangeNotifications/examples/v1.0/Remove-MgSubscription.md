### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.ChangeNotifications

$params = @{
	expirationDateTime = [System.DateTime]::Parse("2016-11-22T18:23:45.9356913Z")
}

Update-MgSubscription -SubscriptionId $subscriptionId -BodyParameter $params
```
This example shows how to use the Remove-MgSubscription Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

