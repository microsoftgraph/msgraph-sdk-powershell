### Example 1: Using the Remove-MgUserAuthenticationEmailMethod Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Remove-MgUserAuthenticationEmailMethod -UserId $userId -EmailAuthenticationMethodId $emailAuthenticationMethodId
```
This example shows how to use the Remove-MgUserAuthenticationEmailMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
