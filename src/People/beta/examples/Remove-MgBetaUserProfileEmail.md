### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.People

# A UPN can also be used as -UserId.
Remove-MgBetaUserProfileEmail -UserId $userId -ItemEmailId $itemEmailId

```
This example shows how to use the Remove-MgBetaUserProfileEmail Cmdlet.

