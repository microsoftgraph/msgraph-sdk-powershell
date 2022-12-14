### Example 1: Using the Update-MgBetaGroupLifecyclePolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Groups
$params = @{
	GroupLifetimeInDays = 180
	ManagedGroupTypes = "Selected"
	AlternateNotificationEmails = "admin@contoso.com"
}
Update-MgBetaGroupLifecyclePolicy -GroupLifecyclePolicyId $groupLifecyclePolicyId -BodyParameter $params
```
This example shows how to use the Update-MgBetaGroupLifecyclePolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
