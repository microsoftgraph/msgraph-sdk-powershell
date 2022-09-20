### Example 1: Using the Restart-MgUserCloudPc Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
# A UPN can also be used as -UserId.
Restart-MgUserCloudPc -UserId $userId -CloudPCId $cloudPCId
```
This example shows how to use the Restart-MgUserCloudPc Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
