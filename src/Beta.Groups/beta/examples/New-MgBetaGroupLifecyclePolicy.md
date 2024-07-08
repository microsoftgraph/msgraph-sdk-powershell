### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Groups

$params = @{
	groupLifetimeInDays = 100
	managedGroupTypes = "Selected"
	alternateNotificationEmails = "admin@contoso.com"
}

New-MgBetaGroupLifecyclePolicy -BodyParameter $params

```
This example shows how to use the New-MgBetaGroupLifecyclePolicy Cmdlet.

