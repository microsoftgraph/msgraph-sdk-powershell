### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Users.Actions

# A UPN can also be used as -UserId.
Invoke-MgBetaInvalidateAllUserRefreshToken -UserId $userId

```
This example shows how to use the Invoke-MgBetaInvalidateAllUserRefreshToken Cmdlet.

