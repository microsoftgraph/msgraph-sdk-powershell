### Example 1: Using the Find-MgUserRoomList Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Functions
# A UPN can also be used as -UserId.
Find-MgUserRoomList -UserId $userId
```
This example shows how to use the Find-MgUserRoomList Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
