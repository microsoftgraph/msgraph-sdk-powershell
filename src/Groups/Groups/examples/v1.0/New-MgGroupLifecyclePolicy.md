###Example 1
```
Import-Module Microsoft.Graph.Groups
$params = @{
	GroupLifetimeInDays = 100
	ManagedGroupTypes = "Selected"
	AlternateNotificationEmails = "admin@contoso.com"
}
New-MgGroupLifecyclePolicy -BodyParameter $params
```
