### Example 1: Return documents that user has modified

```powershellImport-Module Microsoft.Graph.People

# A UPN can also be used as -UserId.
Get-MgUserUsedInsight -UserId $userId
```
This example shows how to use the Get-MgUserUsedInsight Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Return the most recently viewed documents that the signed-in user might or might not have modified

```powershellImport-Module Microsoft.Graph.People

# A UPN can also be used as -UserId.
Get-MgUserUsedInsight -UserId $userId -Sort "LastUsed/LastAccessedDateTime desc"
```
This example shows how to use the Get-MgUserUsedInsight Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

