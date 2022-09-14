### Example 1
``` powershell
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Get-MgUserMailFolderMessage -UserId $userId -MailFolderId $mailFolderId
```
