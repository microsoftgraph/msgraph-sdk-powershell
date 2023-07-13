### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Groups

$params = @{
	groupLifetimeInDays = 180
	managedGroupTypes = "Selected"
	alternateNotificationEmails = "admin@contoso.com"
}

Update-MgBetaGroupLifecyclePolicy -GroupLifecyclePolicyId $groupLifecyclePolicyId -BodyParameter $params
```
This example shows how to use the Update-MgBetaGroupLifecyclePolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

