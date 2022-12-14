### Example 1: Using the Invoke-MgBetaReprovisionUserCloudPc Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
# A UPN can also be used as -UserId.
Invoke-MgBetaReprovisionUserCloudPc -UserId $userId -CloudPCId $cloudPCId
```
This example shows how to use the Invoke-MgBetaReprovisionUserCloudPc Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
