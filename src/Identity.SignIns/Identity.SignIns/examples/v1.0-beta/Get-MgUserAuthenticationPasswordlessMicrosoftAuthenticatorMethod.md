### Example 1: Using the Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethod Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethod -UserId $userId -PasswordlessMicrosoftAuthenticatorAuthenticationMethodId $passwordlessMicrosoftAuthenticatorAuthenticationMethodId
```
This example shows how to use the Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethod Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
# A UPN can also be used as -UserId.
Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethod -UserId $userId
```
This example shows how to use the Get-MgBetaUserAuthenticationPasswordlessMicrosoftAuthenticatorMethod Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
