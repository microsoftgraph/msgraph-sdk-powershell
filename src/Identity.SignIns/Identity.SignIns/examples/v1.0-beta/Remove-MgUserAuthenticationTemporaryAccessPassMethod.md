### Example 1: Using the Remove-MgUserAuthenticationTemporaryAccessPassMethod Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Remove-MgUserAuthenticationTemporaryAccessPassMethod -UserId $userId -TemporaryAccessPassAuthenticationMethodId $temporaryAccessPassAuthenticationMethodId
```
This example shows how to use the Remove-MgUserAuthenticationTemporaryAccessPassMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
