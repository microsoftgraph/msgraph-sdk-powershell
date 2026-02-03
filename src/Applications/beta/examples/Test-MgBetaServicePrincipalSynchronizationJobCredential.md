### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Applications

$params = @{
	credentials = @(
		@{
			key = "UserName"
			value = "user@domain.com"
		}
		@{
			key = "Password"
			value = "password-value"
		}
	)
}

Test-MgBetaServicePrincipalSynchronizationJobCredential -ServicePrincipalId $servicePrincipalId -SynchronizationJobId $synchronizationJobId -BodyParameter $params

```
This example shows how to use the Test-MgBetaServicePrincipalSynchronizationJobCredential Cmdlet.

