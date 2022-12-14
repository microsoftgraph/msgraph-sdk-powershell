### Example 1: Using the Get-MgBetaUserCloudPcLaunchInfo Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Functions
# A UPN can also be used as -UserId.
Get-MgBetaUserCloudPcLaunchInfo -UserId $userId -CloudPCId $cloudPCId
```
This example shows how to use the Get-MgBetaUserCloudPcLaunchInfo Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
