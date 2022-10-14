### Example 1: Using the Invoke-MgTroubleshootUserCloudPc Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
# A UPN can also be used as -UserId.
Invoke-MgTroubleshootUserCloudPc -UserId $userId -CloudPCId $cloudPCId
```
This example shows how to use the Invoke-MgTroubleshootUserCloudPc Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
