### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Applications

$params = @{
	criteria = @{
		resetScope = "Watermark, Escrows, QuarantineState"
	}
}

Restart-MgServicePrincipalSynchronizationJob -ServicePrincipalId $servicePrincipalId -SynchronizationJobId $synchronizationJobId -BodyParameter $params

```
This example shows how to use the Restart-MgServicePrincipalSynchronizationJob Cmdlet.

