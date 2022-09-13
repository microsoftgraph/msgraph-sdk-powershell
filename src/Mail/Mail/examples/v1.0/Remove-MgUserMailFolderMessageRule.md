###Example 1
```
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Remove-MgUserMailFolderMessageRule -UserId $userId -MailFolderId $mailFolderId -MessageRuleId $messageRuleId
```
