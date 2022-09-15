### Example 1: Using the Suspend-MgServicePrincipalSynchronizationJob Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
Suspend-MgServicePrincipalSynchronizationJob -ServicePrincipalId $servicePrincipalId -SynchronizationJobId $synchronizationJobId
```
This example shows how to use the Suspend-MgServicePrincipalSynchronizationJob Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
