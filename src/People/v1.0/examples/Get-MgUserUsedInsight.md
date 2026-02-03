### Example 1: Return documents that user has modified

```powershell

Import-Module Microsoft.Graph.People

# A UPN can also be used as -UserId.
Get-MgUserUsedInsight -UserId $userId

```
This example will return documents that user has modified

### Example 2: Return the most recently viewed documents that the signed-in user might or might not have modified

```powershell

Import-Module Microsoft.Graph.People

# A UPN can also be used as -UserId.
Get-MgUserUsedInsight -UserId $userId -Sort "LastUsed/LastAccessedDateTime desc" 

```
This example will return the most recently viewed documents that the signed-in user might or might not have modified

