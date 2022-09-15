### Example 1: Using the Restart-MgServicePrincipalSynchronizationJob Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
$params = @{
	Criteria = @{
		ResetScope = "Watermark, Escrows, QuarantineState"
	}
}
Restart-MgServicePrincipalSynchronizationJob -ServicePrincipalId $servicePrincipalId -SynchronizationJobId $synchronizationJobId -BodyParameter $params
```
This example shows how to use the Restart-MgServicePrincipalSynchronizationJob Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
