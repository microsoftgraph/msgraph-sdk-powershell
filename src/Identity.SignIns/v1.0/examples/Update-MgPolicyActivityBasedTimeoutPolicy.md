### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	displayName = "Idle timeout for all apps"
}

Update-MgPolicyActivityBasedTimeoutPolicy -ActivityBasedTimeoutPolicyId $activityBasedTimeoutPolicyId -BodyParameter $params

```
This example shows how to use the Update-MgPolicyActivityBasedTimeoutPolicy Cmdlet.

