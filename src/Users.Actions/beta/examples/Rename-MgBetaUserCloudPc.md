### Example 1: Using the Rename-MgBetaUserCloudPc Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
# A UPN can also be used as -UserId.
Rename-MgBetaUserCloudPc -UserId $userId -CloudPCId $cloudPCId
```
This example shows how to use the Rename-MgBetaUserCloudPc Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
