### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Mail

# A UPN can also be used as -UserId.
Get-MgBetaUserMessage -UserId $userId -MessageId $messageId
```
This example shows how to use the Get-MgBetaUserMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Mail

# A UPN can also be used as -UserId.
Get-MgBetaUserMessage -UserId $userId -MessageId $messageId -Property "internetMessageHeaders"
```
This example shows how to use the Get-MgBetaUserMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Mail

# A UPN can also be used as -UserId.
Get-MgBetaUserMessageContent -UserId $userId -MessageId $messageId -OutFile $outFileId
```
This example shows how to use the Get-MgBetaUserMessage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

