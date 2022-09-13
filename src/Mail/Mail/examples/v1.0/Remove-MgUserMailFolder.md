###Example 1
```
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Remove-MgUserMailFolder -UserId $userId -MailFolderId $mailFolderId
```
