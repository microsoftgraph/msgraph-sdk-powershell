### Example 1: Get a specific message

```powershellImport-Module Microsoft.Graph.Beta.Mail

# A UPN can also be used as -UserId.
Get-MgBetaUserMessage -UserId $userId -MessageId $messageId
```
This example shows how to use the Get-MgBetaUserMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get Internet message headers

```powershellImport-Module Microsoft.Graph.Beta.Mail

# A UPN can also be used as -UserId.
Get-MgBetaUserMessage -UserId $userId -MessageId $messageId -Property "internetMessageHeaders"
```
This example shows how to use the Get-MgBetaUserMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Get message body in text format

```powershellImport-Module Microsoft.Graph.Beta.Mail

# A UPN can also be used as -UserId.
Get-MgBetaUserMessage -UserId $userId -MessageId $messageId -Property "subject,body,bodyPreview,uniqueBody"
```
This example shows how to use the Get-MgBetaUserMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 4: Get MIME content

```powershellImport-Module Microsoft.Graph.Beta.Mail

# A UPN can also be used as -UserId.
Get-MgBetaUserMessageContent -UserId $userId -MessageId $messageId -OutFile $outFileId
```
This example shows how to use the Get-MgBetaUserMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

