### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	definition = @(
	'{"ActivityBasedTimeoutPolicy":{"Version":1,"ApplicationPolicies":[{"ApplicationId":"default","WebSessionIdleTimeout":"00:05:00"}]}}'
)
displayName = "activityBasedTimeoutPolicies test"
isOrganizationDefault = $true
}

New-MgPolicyActivityBasedTimeoutPolicy -BodyParameter $params

```
This example shows how to use the New-MgPolicyActivityBasedTimeoutPolicy Cmdlet.

