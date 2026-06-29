### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Mail

# A UPN can also be used as -UserId.
New-MgUserMessageReply -UserId $userId -MessageId $messageId

```
This example shows how to use the New-MgUserMessageReply Cmdlet.

