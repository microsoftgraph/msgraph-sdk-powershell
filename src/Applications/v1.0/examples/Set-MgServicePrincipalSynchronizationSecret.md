### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Applications

$params = @{
	value = @(
		@{
			key = "BaseAddress"
			value = "user@domain.com"
		}
		@{
			key = "SecretToken"
			value = "password-value"
		}
		@{
			key = "SyncNotificationSettings"
			value = '{"Enabled":false,"DeleteThresholdEnabled":false}'
		}
		@{
			key = "SyncAll"
			value = "false"
		}
	)
}

Set-MgServicePrincipalSynchronizationSecret -ServicePrincipalId $servicePrincipalId -BodyParameter $params

```
This example shows how to use the Set-MgServicePrincipalSynchronizationSecret Cmdlet.

