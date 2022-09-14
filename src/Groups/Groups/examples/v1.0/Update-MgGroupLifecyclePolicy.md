### Example 1: Using the Update-MgGroupLifecyclePolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Groups
$params = @{
	GroupLifetimeInDays = 180
	ManagedGroupTypes = "Selected"
	AlternateNotificationEmails = "admin@contoso.com"
}
Update-MgGroupLifecyclePolicy -GroupLifecyclePolicyId $groupLifecyclePolicyId -BodyParameter $params
```
This example shows how to use the Update-MgGroupLifecyclePolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
