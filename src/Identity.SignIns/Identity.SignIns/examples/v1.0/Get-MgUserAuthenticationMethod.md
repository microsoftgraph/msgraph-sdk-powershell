### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Identity.SignIns

# A UPN can also be used as -UserId.
Get-MgUserAuthenticationMethod -UserId $userId
```
This example shows how to use the Get-MgUserAuthenticationMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

