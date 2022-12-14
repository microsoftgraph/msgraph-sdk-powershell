### Example 1: Using the Get-MgBetaUserFollowedSite Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Sites
# A UPN can also be used as -UserId.
Get-MgBetaUserFollowedSite -UserId $userId
```
This example shows how to use the Get-MgBetaUserFollowedSite Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
