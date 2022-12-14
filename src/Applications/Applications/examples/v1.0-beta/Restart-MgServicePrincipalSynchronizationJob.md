### Example 1: Using the Restart-MgBetaServicePrincipalSynchronizationJob Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
$params = @{
	Criteria = @{
		ResetScope = "Watermark, Escrows, QuarantineState"
	}
}
Restart-MgBetaServicePrincipalSynchronizationJob -ServicePrincipalId $servicePrincipalId -SynchronizationJobId $synchronizationJobId -BodyParameter $params
```
This example shows how to use the Restart-MgBetaServicePrincipalSynchronizationJob Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
