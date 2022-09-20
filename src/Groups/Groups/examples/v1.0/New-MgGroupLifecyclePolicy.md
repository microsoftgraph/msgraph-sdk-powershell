### Example 1: Using the New-MgGroupLifecyclePolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Groups
$params = @{
	GroupLifetimeInDays = 100
	ManagedGroupTypes = "Selected"
	AlternateNotificationEmails = "admin@contoso.com"
}
New-MgGroupLifecyclePolicy -BodyParameter $params
```
This example shows how to use the New-MgGroupLifecyclePolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
