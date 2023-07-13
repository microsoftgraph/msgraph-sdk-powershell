### Example 1: Using the Invoke-MgBetaSupportedUserOutlookLanguage Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Functions
# A UPN can also be used as -UserId.
Invoke-MgBetaSupportedUserOutlookLanguage -UserId $userId
```
This example shows how to use the Invoke-MgBetaSupportedUserOutlookLanguage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
