### Example 1: Send an existing draft message

```powershell

Import-Module Microsoft.Graph.Mail

# A UPN can also be used as -UserId.
Send-MgUserMessage -UserId $userId -MessageId $messageId

```
This example will send an existing draft message

