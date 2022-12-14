### Example 1: Using the Restart-MgBetaUserCloudPc Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
# A UPN can also be used as -UserId.
Restart-MgBetaUserCloudPc -UserId $userId -CloudPCId $cloudPCId
```
This example shows how to use the Restart-MgBetaUserCloudPc Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
