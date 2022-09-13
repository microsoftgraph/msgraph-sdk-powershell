###Example 1
```
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Get-MgUserMessageExtension -UserId $userId -MessageId $messageId -ExtensionId $extensionId
```
