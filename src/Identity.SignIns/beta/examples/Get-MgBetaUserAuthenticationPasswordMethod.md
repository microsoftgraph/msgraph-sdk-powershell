### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

# A UPN can also be used as -UserId.
Get-MgBetaUserAuthenticationPasswordMethod -UserId $userId -PasswordAuthenticationMethodId $passwordAuthenticationMethodId
```
This example shows how to use the Get-MgBetaBetaUserAuthenticationPasswordMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

