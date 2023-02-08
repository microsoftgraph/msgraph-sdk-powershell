### Example 1: Using the New-MgBetaGroupLifecyclePolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Groups
$params = @{
	GroupLifetimeInDays = 100
	ManagedGroupTypes = "Selected"
	AlternateNotificationEmails = "admin@contoso.com"
}
New-MgBetaGroupLifecyclePolicy -BodyParameter $params
```
This example shows how to use the New-MgBetaGroupLifecyclePolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
