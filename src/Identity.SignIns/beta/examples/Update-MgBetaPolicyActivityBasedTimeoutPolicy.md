### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	displayName = "Idle timeout for all apps"
}

Update-MgBetaPolicyActivityBasedTimeoutPolicy -ActivityBasedTimeoutPolicyId $activityBasedTimeoutPolicyId -BodyParameter $params

```
This example shows how to use the Update-MgBetaPolicyActivityBasedTimeoutPolicy Cmdlet.

