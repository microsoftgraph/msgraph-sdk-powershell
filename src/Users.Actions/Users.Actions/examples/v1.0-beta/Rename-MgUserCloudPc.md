### Example 1: Using the Rename-MgUserCloudPc Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
# A UPN can also be used as -UserId.
Rename-MgUserCloudPc -UserId $userId -CloudPCId $cloudPCId
```
This example shows how to use the Rename-MgUserCloudPc Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
