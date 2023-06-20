### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Mail

# A UPN can also be used as -UserId.
Get-MgUserMessage -UserId $userId -MessageId $messageId -ExpandProperty "singleValueExtendedProperties(`$filter=id eq 'String {66f5a359-4659-4830-9070-00047ec6ac6e} Name Color')"
```
This example shows how to use the Get-MgUserMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

