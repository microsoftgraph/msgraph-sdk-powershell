### Example 1: Using the Get-MgUserCloudPcLaunchInfo Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Functions
# A UPN can also be used as -UserId.
Get-MgUserCloudPcLaunchInfo -UserId $userId -CloudPCId $cloudPCId
```
This example shows how to use the Get-MgUserCloudPcLaunchInfo Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
