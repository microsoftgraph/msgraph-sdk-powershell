###Example 1
```
Import-Module Microsoft.Graph.Users.Actions
# A UPN can also be used as -UserId.
Send-MgUserMessage -UserId $userId -MessageId $messageId
```
