### Example 1: Using the Invoke-MgBetaTroubleshootUserCloudPc Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
# A UPN can also be used as -UserId.
Invoke-MgBetaTroubleshootUserCloudPc -UserId $userId -CloudPCId $cloudPCId
```
This example shows how to use the Invoke-MgBetaTroubleshootUserCloudPc Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
