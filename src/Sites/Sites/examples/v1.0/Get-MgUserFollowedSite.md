### Example 1: Using the Get-MgUserFollowedSite Cmdlet
```powershell
Import-Module Microsoft.Graph.Sites
# A UPN can also be used as -UserId.
Get-MgUserFollowedSite -UserId $userId
```
This example shows how to use the Get-MgUserFollowedSite Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
