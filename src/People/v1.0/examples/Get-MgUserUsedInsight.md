### Example 1: Using the Get-MgUserUsedInsight Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserUsedInsight -UserId $userId -Sort "LastUsed/LastAccessedDateTime desc" 
```
This example shows how to use the Get-MgUserUsedInsight Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserUsedInsight Cmdlet
```powershell
Import-Module Microsoft.Graph.People
# A UPN can also be used as -UserId.
Get-MgUserUsedInsight -UserId $userId
```
This example shows how to use the Get-MgUserUsedInsight Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
