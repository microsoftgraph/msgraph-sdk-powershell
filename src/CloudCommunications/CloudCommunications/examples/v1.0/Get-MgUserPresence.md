### Example 1: Using the Get-MgUserPresence Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
Get-MgUserPresence -UserId $userId
```
This example shows how to use the Get-MgUserPresence Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserPresence Cmdlet
```powershell
Import-Module Microsoft.Graph.CloudCommunications
# A UPN can also be used as -UserId.
Get-MgUserPresence -UserId $userId
```
This example shows how to use the Get-MgUserPresence Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
