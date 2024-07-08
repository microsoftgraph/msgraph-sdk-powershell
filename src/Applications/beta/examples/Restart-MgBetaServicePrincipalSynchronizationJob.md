### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Applications

$params = @{
	criteria = @{
		resetScope = "Watermark, Escrows, QuarantineState"
	}
}

Restart-MgBetaServicePrincipalSynchronizationJob -ServicePrincipalId $servicePrincipalId -SynchronizationJobId $synchronizationJobId -BodyParameter $params

```
This example shows how to use the Restart-MgBetaServicePrincipalSynchronizationJob Cmdlet.

