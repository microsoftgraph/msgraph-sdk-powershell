### Example 1: Get a specific message

```powershell
Import-Module Microsoft.Graph.Mail

# A UPN can also be used as -UserId.
Get-MgUserMessage -UserId $userId -MessageId $messageId
```
This example shows how to use the Get-MgUserMessage Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get Internet message headers

```powershell
Import-Module Microsoft.Graph.Mail

# A UPN can also be used as -UserId.
Get-MgUserMessage -UserId $userId -MessageId $messageId -Property "internetMessageHeaders"
```
This example shows how to use the Get-MgUserMessage Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Get message body in text format

```powershell
Import-Module Microsoft.Graph.Mail

# A UPN can also be used as -UserId.
Get-MgUserMessage -UserId $userId -MessageId $messageId -Property "subject,body,bodyPreview,uniqueBody"
```
This example shows how to use the Get-MgUserMessage Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

