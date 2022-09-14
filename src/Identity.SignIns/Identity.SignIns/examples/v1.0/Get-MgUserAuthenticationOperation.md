### Example 1: Using the Get-MgUserAuthenticationOperation Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgUserAuthenticationOperation -UserId $userId -LongRunningOperationId $longRunningOperationId
```
This example shows how to use the Get-MgUserAuthenticationOperation Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
