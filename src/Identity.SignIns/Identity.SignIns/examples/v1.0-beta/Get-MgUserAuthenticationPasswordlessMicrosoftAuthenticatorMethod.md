### Example 1: Using the Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethod Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethod -UserId $userId -PasswordlessMicrosoftAuthenticatorAuthenticationMethodId $passwordlessMicrosoftAuthenticatorAuthenticationMethodId
```
This example shows how to use the Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethod Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethod -UserId $userId
```
This example shows how to use the Get-MgUserAuthenticationPasswordlessMicrosoftAuthenticatorMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
