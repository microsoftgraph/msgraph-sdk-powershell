###Example 1
```
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Get-MgUserMailFolderMessageRule -UserId $userId -MailFolderId $mailFolderId -MessageRuleId $messageRuleId
```
###Example 2
```
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Get-MgUserMailFolderMessageRule -UserId $userId -MailFolderId $mailFolderId
```
